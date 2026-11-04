using Application_Task.Models;
using Application_Task.Repositories;

namespace Application_Task.View;

public partial class HomePage : ContentPage
{
	private ITaskModelRepository _repository;

	public HomePage()
	{
		InitializeComponent();

		_repository = new TaskModelRepository();
		LoadData();
	}
	private void LoadData()
	{
        var tasks = _repository.GetTaskModels();
		CollectionViewTask.ItemsSource = tasks;
		Emptylbl.IsVisible = tasks.Count <= 0;
	}
    private void ButtonToAdd(object sender, EventArgs e)
    {
		_repository.Add(new Models.TaskModel
		{
			Name = "Comprar Frutas",
			Description = "Comprar abacate, laranja, maçã",
			IsComplete = false,
			CreatedTask = DateTime.Now,
			TaskDate = DateTime.Now.AddDays(2)
		});
		LoadData();
		//Navigation.PushModalAsync(new EditTaskPage());
    }
    private void SerchBarHomePage(object sender, TappedEventArgs e)
    {
		Entry_search.Focus();
    }
    private void OncheckedBox(object sender, TappedEventArgs e)
    {
		var task = (TaskModel)e.Parameter;

		task.IsComplete = ((CheckBox)sender).IsChecked;
		_repository.Update(task);

    }
    private async void OnTappedToDelete(object sender, TappedEventArgs e)
    {
        var task = (TaskModel)e.Parameter;

        var res = await DisplayAlertAsync("Aviso!", $"Gostaria de prosseguir com essa ação? {task.Name}", "SIM", "NÃO");

		if (res)
		{
            _repository.Delete(task);
            LoadData();
        }
		else
		{
			return;
		}
       
    }
}