using ShopApp.DataAccess;

namespace ShopApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            var dbContext = new ShopDbContext();
            category.Text = dbContext.Categorias.Count().ToString();
            client.Text = dbContext.Clientes.Count().ToString();
            product.Text = dbContext.Productos.Count().ToString();
        }

    }

}
