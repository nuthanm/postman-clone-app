using PostmanClone.Library;

namespace PostManClone.UI;

public partial class Dashboard : Form
{
    private readonly ApiAccess api = new();
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void apiClick_Click(object sender, EventArgs e)
    {
        // async void => When it's an event

        // Validate API URl => We pushed this logic in Library project
        // We can reuse even if UI application is different and loosely coupled.


        try
        {
            apiStatus.Text = "Calling API...";

            resultsText.Text = await api.CallApiAsync(apiText.Text);
            
            apiStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            apiStatus.Text = "Error";
        }
    }
}
