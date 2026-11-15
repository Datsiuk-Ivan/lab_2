using Lab02.Data.Entities;
using Lab02.Data.Services;

namespace Lab02.App;

public partial class MeasurementForm : Form
{
    private readonly MeasurementService _measurementService = new();
    private readonly MonitoringPointService _pointService = new();
    private readonly InstrumentService _instrumentService = new();
    private readonly ReferenceService _referenceService = new();
    private readonly Measurement? _measurement;

    public MeasurementForm(Measurement? measurement)
    {
        InitializeComponent();
        _measurement = measurement;
    }

    private void MeasurementForm_Load(object sender, EventArgs e)
    {
        try
        {
            cmbPoint.DataSource = _pointService.GetAll();
            cmbInstrument.DataSource = _instrumentService.GetAll();
            cmbParticipant.DataSource = _referenceService.GetParticipants();
        }
        catch (DataOperationException ex)
        {
            MessageBox.Show(ex.Message, "Помилка завантаження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
            return;
        }

        cmbStatus.DataSource = Enum.GetValues<MeasurementStatus>();

        if (_measurement == null)
        {
            Text = "Новий вимір";
            dtpMeasuredAt.Value = DateTime.Now;
            return;
        }

        Text = "Редагування виміру";
        cmbPoint.SelectedValue = _measurement.MonitoringPointId;
        cmbInstrument.SelectedValue = _measurement.InstrumentId;
        cmbParticipant.SelectedValue = _measurement.ParticipantId;
        dtpMeasuredAt.Value = _measurement.MeasuredAt;
        txtParameter.Text = _measurement.Parameter;
        numValue.Value = (decimal)_measurement.Value;
        txtUnit.Text = _measurement.Unit;
        chkIsControl.Checked = _measurement.IsControl;
        cmbStatus.SelectedItem = _measurement.Status;
        txtNote.Text = _measurement.Note;

        if (_measurement.Depth.HasValue)
        {
            chkHasDepth.Checked = true;
            numDepth.Value = (decimal)_measurement.Depth.Value;
        }

        if (_measurement.ActualLatitude.HasValue && _measurement.ActualLongitude.HasValue)
        {
            chkRelocated.Checked = true;
            numActualLatitude.Value = (decimal)_measurement.ActualLatitude.Value;
            numActualLongitude.Value = (decimal)_measurement.ActualLongitude.Value;
            txtRelocationReason.Text = _measurement.RelocationReason;
        }
    }

    private void chkHasDepth_CheckedChanged(object sender, EventArgs e)
    {
        numDepth.Enabled = chkHasDepth.Checked;
    }

    private void chkRelocated_CheckedChanged(object sender, EventArgs e)
    {
        numActualLatitude.Enabled = chkRelocated.Checked;
        numActualLongitude.Enabled = chkRelocated.Checked;
        txtRelocationReason.Enabled = chkRelocated.Checked;

        if (chkRelocated.Checked && numActualLatitude.Value == 0 && numActualLongitude.Value == 0
            && cmbPoint.SelectedItem is MonitoringPoint point)
        {
            numActualLatitude.Value = (decimal)point.PlannedLatitude;
            numActualLongitude.Value = (decimal)point.PlannedLongitude;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var measurement = new Measurement
        {
            MonitoringPointId = Convert.ToInt32(cmbPoint.SelectedValue),
            InstrumentId = Convert.ToInt32(cmbInstrument.SelectedValue),
            ParticipantId = Convert.ToInt32(cmbParticipant.SelectedValue),
            MeasuredAt = dtpMeasuredAt.Value,
            Parameter = txtParameter.Text,
            Value = (double)numValue.Value,
            Unit = txtUnit.Text,
            Depth = chkHasDepth.Checked ? (double)numDepth.Value : null,
            IsControl = chkIsControl.Checked,
            Status = (MeasurementStatus)cmbStatus.SelectedItem!,
            Note = txtNote.Text
        };

        if (chkRelocated.Checked)
        {
            measurement.ActualLatitude = (double)numActualLatitude.Value;
            measurement.ActualLongitude = (double)numActualLongitude.Value;
            measurement.RelocationReason = txtRelocationReason.Text;
        }

        try
        {
            if (_measurement == null)
            {
                _measurementService.Add(measurement);
            }
            else
            {
                measurement.Id = _measurement.Id;
                _measurementService.Update(measurement);
            }

            DialogResult = DialogResult.OK;
        }
        catch (DataValidationException ex)
        {
            MessageBox.Show(ex.Message, "Перевірте дані", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (DataOperationException ex)
        {
            MessageBox.Show(ex.Message, "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
