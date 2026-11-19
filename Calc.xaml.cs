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
		string result = (checkFunction(Equastion.Text).ToString());
		Equastion.Text = result;
	}

	private int checkFunction(string currentEq)
	{
		char[] arr = new char[currentEq.Length];
		int num = 0;
		int j = 0;
		for (int i = 0; i < currentEq.Length; i++)
		{
			arr[i] = currentEq[i];
		}
        for (j = 0; ((arr[j] > '0') && (arr[j] <= '9')); j++)
        {
            num *= 10;
            num += int.Parse(arr[j].ToString());
        }
		switch (arr[j])
		{
			case '+':
				num = Sum(arr, j++, num);
				break;

			case '-':
				num = Sub(arr, j++, num);
				break;

			case '*':
				num = Mul(arr, j++, num);
				break;

			case '/':
				num = Div(arr, j++, num);
				break;
		}
		return num;



    }
	private int Sum(char[] arr, int j, int num)
	{
		int num1 = 0;
        for (int i = j; (((arr[i] > '0') && (arr[i] <= '9')) && (i < arr.Length)); i++)
        {
            num1 *= 10;
            num1 += int.Parse(arr[i].ToString());
        }
		return (num + num1);

    }
	private int Sub(char[] arr, int j, int num)
	{
        int num1 = 0;
        for (; (((arr[j] > '0') && (arr[j] <= '9')) && (j < arr.Length)); j++)
        {
            num1 *= 10;
            num1 += int.Parse(arr[j].ToString());
        }
        return (num - num1);
    }

	private int Mul(char[] arr, int j, int num)
	{
        int num1 = 0;
        for (; (((arr[j] > '0') && (arr[j] <= '9')) && (j < arr.Length)); j++)
        {
            num1 *= 10;
            num1 += int.Parse(arr[j].ToString());
        }
        return (num * num1);
    }

	private int Div(char[] arr, int j, int num)
	{
        int num1 = 0;
        for (; (((arr[j] > '0') && (arr[j] <= '9')) && (j < arr.Length)); j++)
        {
            num1 *= 10;
            num1 += int.Parse(arr[j].ToString());
        }
        return (num * num1);
    }



}