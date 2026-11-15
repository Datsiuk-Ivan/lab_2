using Lab02.Data.Entities;
using Lab02.Data.Services;

namespace Lab02.App;

public partial class MainForm : Form
{
    private readonly MeasurementService _measurementService = new();
    private readonly MonitoringPointService _pointService = new();
    private readonly InstrumentService _instrumentService = new();

    private List<Measurement> _measurements = new();
    private List<MonitoringPoint> _points = new();
    private List<Instrument> _instruments = new();
    private bool _showSuspiciousOnly;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadMeasurements();
        LoadPoints();
        LoadInstruments();
    }

    private void LoadMeasurements()
    {
        try
        {
            _measurements = _showSuspiciousOnly
                ? _measurementService.GetSuspicious()
                : _measurementService.GetAll();
        }
        catch (DataOperationException ex)
        {
            ShowError(ex.Message);
            return;
        }

        dgvMeasurements.DataSource = _measurements
            .Select(m => new
            {
                ID = m.Id,
                Дата = m.MeasuredAt.ToString("yyyy-MM-dd HH:mm"),
                Точка = m.MonitoringPoint?.Code,
                Прилад = m.Instrument?.Name,
                Учасник = m.Participant?.FullName,
                Параметр = m.Parameter,
                Значення = m.Value,
                Одиниця = m.Unit,
                Глибина = m.Depth,
                Дубль = m.IsControl ? "так" : "",
                Фактичне_місце = m.ActualLatitude.HasValue ? $"{m.ActualLatitude:F6}; {m.ActualLongitude:F6}" : "",
                Причина_перенесення = m.RelocationReason,
                Статус = m.Status.ToString(),
                Примітка = m.Note
            })
            .ToList();

        lblMeasurementsMode.Text = _showSuspiciousOnly
            ? $"Показано: підозрілі виміри ({_measurements.Count})"
            : $"Показано: усі виміри ({_measurements.Count})";
    }

    private void LoadPoints()
    {
        try
        {
            _points = _pointService.GetAll();
        }
        catch (DataOperationException ex)
        {
            ShowError(ex.Message);
            return;
        }

        dgvPoints.DataSource = _points
            .Select(p => new
            {
                ID = p.Id,
                Код = p.Code,
                Місцевість = p.Location?.Name,
                Тип_місцевості = p.Location?.Type.ToString(),
                Призначення = p.Purpose.ToString(),
                Планова_широта = p.PlannedLatitude,
                Планова_довгота = p.PlannedLongitude
            })
            .ToList();
    }

    private void LoadInstruments()
    {
        try
        {
            _instruments = _instrumentService.GetAll();
        }
        catch (DataOperationException ex)
        {
            ShowError(ex.Message);
            return;
        }

        dgvInstruments.DataSource = _instruments
            .Select(i => new
            {
                ID = i.Id,
                Назва = i.Name,
                Тип = i.Type.ToString(),
                Серійний_номер = i.SerialNumber,
                Статус = i.Status.ToString(),
                Калібрувань = i.Calibrations.Count,
                Останнє_калібрування = i.Calibrations
                    .OrderByDescending(c => c.CalibratedAt)
                    .Select(c => c.CalibratedAt.ToString("yyyy-MM-dd"))
                    .FirstOrDefault()
            })
            .ToList();
    }

    private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        var grid = (DataGridView)sender;
        if (grid.DataSource is not IEnumerable<object> rows || !rows.Any())
            return;

        var column = grid.Columns[e.ColumnIndex];
        var property = rows.First().GetType().GetProperty(column.DataPropertyName);
        if (property == null)
            return;

        bool descending = column.HeaderCell.SortGlyphDirection != SortOrder.Descending;
        grid.DataSource = descending
            ? rows.OrderByDescending(row => property.GetValue(row)).ToList()
            : rows.OrderBy(row => property.GetValue(row)).ToList();

        foreach (DataGridViewColumn gridColumn in grid.Columns)
            gridColumn.SortMode = DataGridViewColumnSortMode.Programmatic;

        grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = descending ? SortOrder.Descending : SortOrder.Ascending;
    }

    private static int? GetSelectedId(DataGridView grid)
    {
        if (grid.CurrentRow == null)
            return null;

        return grid.CurrentRow.Cells["ID"].Value as int?;
    }

    private static bool Confirm(string question)
    {
        return MessageBox.Show(question, "Підтвердження видалення",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
    }

    private static void ShowError(string message)
    {
        MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private static void ShowWarning(string message)
    {
        MessageBox.Show(message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btnMeasurementsRefresh_Click(object sender, EventArgs e)
    {
        _showSuspiciousOnly = false;
        LoadMeasurements();
    }

    private void btnShowSuspicious_Click(object sender, EventArgs e)
    {
        _showSuspiciousOnly = true;
        LoadMeasurements();
    }

    private void btnMeasurementAdd_Click(object sender, EventArgs e)
    {
        using var form = new MeasurementForm(null);
        if (form.ShowDialog(this) == DialogResult.OK)
            LoadMeasurements();
    }

    private void btnMeasurementEdit_Click(object sender, EventArgs e)
    {
        int? id = GetSelectedId(dgvMeasurements);
        var measurement = _measurements.FirstOrDefault(m => m.Id == id);
        if (measurement == null)
        {
            ShowWarning("Виберіть вимір у таблиці.");
            return;
        }

        using var form = new MeasurementForm(measurement);
        if (form.ShowDialog(this) == DialogResult.OK)
            LoadMeasurements();
    }

    private void btnMeasurementDelete_Click(object sender, EventArgs e)
    {
        int? id = GetSelectedId(dgvMeasurements);
        var measurement = _measurements.FirstOrDefault(m => m.Id == id);
        if (measurement == null)
        {
            ShowWarning("Виберіть вимір у таблиці.");
            return;
        }

        if (!Confirm($"Видалити вимір «{measurement.Parameter}» від {measurement.MeasuredAt:dd.MM.yyyy HH:mm} у точці {measurement.MonitoringPoint?.Code}?"))
            return;

        try
        {
            _measurementService.Delete(measurement.Id);
        }
        catch (DataOperationException ex)
        {
            ShowError(ex.Message);
        }

        LoadMeasurements();
    }

    private void btnPointsRefresh_Click(object sender, EventArgs e)
    {
        LoadPoints();
    }

    private void btnPointAdd_Click(object sender, EventArgs e)
    {
        using var form = new PointForm(null);
        if (form.ShowDialog(this) == DialogResult.OK)
            LoadPoints();
    }

    private void btnPointEdit_Click(object sender, EventArgs e)
    {
        int? id = GetSelectedId(dgvPoints);
        var point = _points.FirstOrDefault(p => p.Id == id);
        if (point == null)
        {
            ShowWarning("Виберіть точку в таблиці.");
            return;
        }

        using var form = new PointForm(point);
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            LoadPoints();
            LoadMeasurements();
        }
    }

    private void btnPointDelete_Click(object sender, EventArgs e)
    {
        int? id = GetSelectedId(dgvPoints);
        var point = _points.FirstOrDefault(p => p.Id == id);
        if (point == null)
        {
            ShowWarning("Виберіть точку в таблиці.");
            return;
        }

        if (!Confirm($"Видалити точку «{point.Code}»?"))
            return;

        try
        {
            _pointService.Delete(point.Id);
        }
        catch (DataOperationException ex)
        {
            ShowError(ex.Message);
        }

        LoadPoints();
    }

    private void btnInstrumentsRefresh_Click(object sender, EventArgs e)
    {
        LoadInstruments();
    }

    private void btnInstrumentAdd_Click(object sender, EventArgs e)
    {
        using var form = new InstrumentForm(null);
        if (form.ShowDialog(this) == DialogResult.OK)
            LoadInstruments();
    }

    private void btnInstrumentEdit_Click(object sender, EventArgs e)
    {
        int? id = GetSelectedId(dgvInstruments);
        var instrument = _instruments.FirstOrDefault(i => i.Id == id);
        if (instrument == null)
        {
            ShowWarning("Виберіть прилад у таблиці.");
            return;
        }

        using var form = new InstrumentForm(instrument);
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            LoadInstruments();
            LoadMeasurements();
        }
    }

    private void btnInstrumentDelete_Click(object sender, EventArgs e)
    {
        int? id = GetSelectedId(dgvInstruments);
        var instrument = _instruments.FirstOrDefault(i => i.Id == id);
        if (instrument == null)
        {
            ShowWarning("Виберіть прилад у таблиці.");
            return;
        }

        if (!Confirm($"Видалити прилад «{instrument.Name}» ({instrument.SerialNumber})?"))
            return;

        try
        {
            _instrumentService.Delete(instrument.Id);
        }
        catch (DataOperationException ex)
        {
            ShowError(ex.Message);
        }

        LoadInstruments();
    }
}