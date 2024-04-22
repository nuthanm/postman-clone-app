namespace PostManClone.UI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void apiClick_Click(object sender, EventArgs e)
    {
        // async void => When it's an event

        try
        {
            apiStatus.Text = "Calling API...";

            // Todo: To see the behaviour of status strip we added this Delay.
            await Task.Delay(2000);

            apiStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            apiStatus.Text = "Error";
        }
    }
}
