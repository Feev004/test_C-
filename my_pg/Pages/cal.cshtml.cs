using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CalModel : PageModel
{
    [BindProperty]
    public double Num1 { get; set; }

    [BindProperty]
    public double Num2 { get; set; }

    [BindProperty]
    public string Operation { get; set; } = "+";

    public double Result { get; set; }
    public bool HasResult { get; set; } = false;

    public void OnPost()
    {
        HasResult = true;

        switch (Operation)
        {
            case "+": Result = Num1 + Num2; break;
            case "-": Result = Num1 - Num2; break;
            case "*": Result = Num1 * Num2; break;
            case "/":
                Result = Num2 != 0 ? Num1 / Num2 : 0;
                break;
        }
    }
}
