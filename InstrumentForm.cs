using Lab02.Data.Entities;
using Lab02.Data.Services;

namespace Lab02.App;

public partial class InstrumentForm : Form
{
    private readonly InstrumentService _instrumentService = new();
    private readonly Instrument? _instrument;

    public InstrumentForm(Instrument? instrument)
    {
        InitializeComponent();
        _instrument = instrument;
    }

    private void InstrumentForm_Load(object sender, EventArgs e)
    {
        cmbType.DataSource = Enum.GetValues<InstrumentType>();
        cmbStatus.DataSource = Enum.GetValues<InstrumentStatus>();

        if (_instrument == null)
        {
            Text = "Новий прилад";
            return;
        }

        Text = "Редагування приладу";
        txtName.Text = _instrument.Name;
        cmbType.SelectedItem = _instrument.Type;
        txtSerialNumber.Text = _instrument.SerialNumber;
        cmbStatus.SelectedItem = _instrument.Status;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var instrument = new Instrument
        {
            Name = txtName.Text,
            Type = (InstrumentType)cmbType.SelectedItem!,
            SerialNumber = txtSerialNumber.Text,
            Status = (InstrumentStatus)cmbStatus.SelectedItem!
        };

        try
        {
            if (_instrument == null)
            {
                _instrumentService.Add(instrument);
            }
            else
            {
                instrument.Id = _instrument.Id;
                _instrumentService.Update(instrument);
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
