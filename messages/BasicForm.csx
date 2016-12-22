using System;
using Microsoft.Bot.Builder.FormFlow;

public enum ActionOptions { Dance = 1, Talk, Scan};
public enum SongOptions { Red = 1, White, Blue };

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    [Prompt("Hi! What is your {&}?")]
    public string Name { get; set; }

    [Prompt("What Would you like Santa to do? {||}")]
    public ActionOptions Action { get; set; }

   
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
