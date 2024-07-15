using PostmanClone.Library;

namespace PostManClone.UI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
    }

    private async void apiClick_Click(object sender, EventArgs e)
    {
        apiStatus.Text = "Calling API....";
        resultsText.Text = string.Empty;

        // async void => When it's an event

        // Validate API URl => We pushed this logic in Library project
        // We can reuse even if UI application is different and loosely coupled.
        if (!api.IsValidUrl(apiText.Text))
        {
            apiStatus.Text = "Invalid Url...";
            return;
        }

        try
        {


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
