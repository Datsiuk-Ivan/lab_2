using Lab02.Data;
using Lab02.Data.Services;

namespace Lab02.App;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            DbInitializer.Initialize();
        }
        catch (DataOperationException ex)
        {
            MessageBox.Show(ex.Message, "Помилка бази даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Application.Run(new MainForm());
    }
}
