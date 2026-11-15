using Lab02.Data.Entities;
using Lab02.Data.Services;

namespace Lab02.App;

public partial class PointForm : Form
{
    private readonly MonitoringPointService _pointService = new();
    private readonly ReferenceService _referenceService = new();
    private readonly MonitoringPoint? _point;

    public PointForm(MonitoringPoint? point)
    {
        InitializeComponent();
        _point = point;
    }

    private void PointForm_Load(object sender, EventArgs e)
    {
        try
        {
            cmbLocation.DataSource = _referenceService.GetLocations();
        }
        catch (DataOperationException ex)
        {
            MessageBox.Show(ex.Message, "Помилка завантаження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
            return;
        }

        cmbPurpose.DataSource = Enum.GetValues<PointPurpose>();

        if (_point == null)
        {
            Text = "Нова точка спостереження";
            return;
        }

        Text = "Редагування точки спостереження";
        cmbLocation.SelectedValue = _point.LocationId;
        txtCode.Text = _point.Code;
        cmbPurpose.SelectedItem = _point.Purpose;
        numPlannedLatitude.Value = (decimal)_point.PlannedLatitude;
        numPlannedLongitude.Value = (decimal)_point.PlannedLongitude;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var point = new MonitoringPoint
        {
            LocationId = Convert.ToInt32(cmbLocation.SelectedValue),
            Code = txtCode.Text,
            Purpose = (PointPurpose)cmbPurpose.SelectedItem!,
            PlannedLatitude = (double)numPlannedLatitude.Value,
            PlannedLongitude = (double)numPlannedLongitude.Value
        };

        try
        {
            if (_point == null)
            {
                _pointService.Add(point);
            }
            else
            {
                point.Id = _point.Id;
                _pointService.Update(point);
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
