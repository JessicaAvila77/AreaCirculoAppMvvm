using AreaCirculoAppMvvm.Viewmodels;

namespace AreaCirculoAppMvvm.Views;

public partial class AreaCirculoView : ContentPage
{
	//declaro una variable llamada ViewModel de tipo la clase
	private AreaCirculoViewModel ViewModel;

	public AreaCirculoView()
	{
		InitializeComponent();
		ViewModel = new AreaCirculoViewModel();

        //hace posible que los controles visuales en la vista (definidos en XAML)
		//se enlacen a las propiedades y comandos del ViewModel.

        BindingContext = ViewModel;	
	
	}
}