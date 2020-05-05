using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MessageBox = System.Windows.MessageBox;
using OrderingGoods.BusinessLayer;
using OrderingGoods.DataAccessLayer;
using OrderingGoods.PresentationLayer;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using AutoMapper;
using AutoMapper.Configuration;
using OrderingGoods.BusinessLayer.DomainModels;
using OrderingGoods.BusinessLayer.Services;

namespace OrderingGoods
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider(validateScopes: true);

            ShutdownMode = ShutdownMode.OnMainWindowClose;
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IGoodService, GoodService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IShopService, ShopService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton(GetOrderingGoodsMapper());
            services.AddSingleton<IConfigurationProvider, MapperConfiguration>();
            services.AddSingleton<MapperConfigurationExpression, MapperConfigurationExpression>();
            services.AddDbContext<OrderingGoodsContext>(opt =>
                opt.UseSqlServer(ConfigurationManager.ConnectionStrings["OrderingGoodsDatabase"].ConnectionString));
        }

        private IMapper GetOrderingGoodsMapper()
        {
            var configuration = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<DataAccessLayer.Entities.GoodEntity, Good>();
            });
            return configuration.CreateMapper();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var viewModel = new ApplicationViewModel(serviceProvider.GetService<IGoodService>(),
                serviceProvider.GetService<IOrderService>(), serviceProvider.GetService<IShopService>());
            MainWindow = new OrderingGoodsWindow() { DataContext = viewModel};
            MainWindow.Show();
        }

        public static MessageBoxResult ShowMessage(string message, bool isQuestion = false)
        {
            if (string.IsNullOrEmpty(message) == true)
                throw new ArgumentException("Message cannot be empty");
            else if (isQuestion == true)
                return MessageBox.Show(message, "Підтвердіть дію", MessageBoxButton.YesNo, MessageBoxImage.Question);
            else
                return MessageBox.Show(message, "Повідомлення", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
