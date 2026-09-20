namespace Application_Task.View;

public partial class EditTaskPage : ContentPage
{
	public EditTaskPage()
	{
		InitializeComponent();
	}

    private void CloseModal(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void SaveData(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private async void Addstep(object sender, EventArgs e)
    {
        var stepName = await DisplayPromptAsync("Tarefas", "Digite o nome da Tarefa ou subtarefa", "Adicionar", "Cancelar");
    }
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        DateTask.WidthRequest = width - 40;
 
    }
}