using System.Threading.Tasks;

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
		checkFunction(Equastion.Text);
	}

	private void checkFunction(string currentEq)
	{
        int num = CalcFunction(currentEq);
        int len = currentEq.Length;
		int num2 = 0;
		string newStr = currentEq.Substring(0, num.ToString().Length + 1);

        for (int i = 0; i < len; i++)
		{
			if((currentEq[i] < '0' || currentEq[i] > '9') && (currentEq[i+1] < '0' || currentEq[i+1] > '9'))
			{
				return;
			}
			else if(currentEq[i] == '-')
			{
				num2 = CalcFunction(newStr);
				num -= num2;

            }
			else if(currentEq[i] == '+')
			{
                num2 = CalcFunction(newStr);
				num += num2;
            }
			else if (currentEq[i] == '/')
			{
				num2 = CalcFunction(newStr);
				num /= num2;
            }
			else if(currentEq[i] == '*')
			{
				num2 = CalcFunction(newStr);
				num *= num2;
            }
            newStr = currentEq.Substring(0, num2.ToString().Length);
        }
		Equastion.Text = num.ToString();

    }
    private int CalcFunction(string currentEq)
    {
        int len = currentEq.Length;
        string temp = "";
        for (int i = 0; i < len; i++)
        {
            if (currentEq[i] > '0' && currentEq[i] <= '9')
            {
                temp += currentEq[i];
            }
            else
            {
                return int.Parse(temp.ToString());
            }
        }
        return int.Parse(temp.ToString());
    }


}