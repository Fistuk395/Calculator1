namespace Calculator1;

public partial class Calc : ContentPage
{
	public Calc()
	{
		InitializeComponent();
	}
    private void Button_Clicked_Num(object sender, EventArgs e)
	{
		Button numGet = (Button)sender;
		string num = "";

		if(Equastion.Text == "0")
		{
			Equastion.Text = numGet.Text;
		}
		else
		{
			Equastion.Text += numGet.Text;
		}

    }
   
    private void Button_Clicked_AC(object sender, EventArgs e)
	{
		Button ac = (Button)sender;

		if(ac.Text == "ac")
		{
			Equastion.Text = "0";
		}
	}
    private void Button_Clicked_Task(object sender, EventArgs e)
	{
		Button task = (Button)sender;

		Equastion.Text += task.Text;
	}
	private void Button_Clicked_Calculate(object sender, EventArgs e)
	{

	}

}