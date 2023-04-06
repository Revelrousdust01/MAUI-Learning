namespace Phoneword;

public partial class MainPage : ContentPage
{
    string translatedNumber;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnTranslate(object sender, EventArgs e)
    {
        string eneteredNumber = PhoneNumberText.Text;
        translatedNumber = Phoneword.PhonewordTranslator.ToNumber(eneteredNumber);

        if (!string.IsNullOrEmpty(translatedNumber))
        {
            CallButton.IsEnabled = true;
            CallButton.Text = "Call" + translatedNumber;
        }
        else
        {
            CallButton.IsEnabled = false;
            CallButton.Text = "Call";
        }
    }
}

