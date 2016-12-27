using System;
using Microsoft.Bot.Builder.FormFlow;

public enum ActionOptions { SaySomething = 1, LookAround, Dance, FireDeathRay};

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    [Prompt("Hi! What is your {&}?")]
    public string Name { get; set; }

    [Prompt("What Would you like Santa to do? {||}")]
    public ActionOptions Action { get; set; }

    [Prompt("What should Santa Say?")]
    public string Words { get; set; }

    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Build();
    } 

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
