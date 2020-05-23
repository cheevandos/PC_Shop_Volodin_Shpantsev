using PC_Shop_Business_Logic.Business_Logic;
using PC_Shop_Business_Logic.Interfaces;
using PC_Shop_Database_Implementation.Implenetations;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace AdministratorView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var unityContainer = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(unityContainer.Resolve<MainForm>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IComponentLogic, ComponentLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderLogic, OrderLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IComputerLogic, ComputerLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IRequestLogic, RequestLogic>(new 
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<ISupplierLogic, SupplierLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWarehouseLogic, WarehouseLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<AdminBusinessLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
