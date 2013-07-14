// Проект: WindowsPhoneTestApplication
// Имя файла: ApplicationBootstrapper.cs
// GUID файла: C16FE24E-6DE4-403E-A522-A273B4478CBF
// Автор: Mike Eshva (mike@eshva.ru)
// Дата создания: 14.05.2012

using System;
using System.Windows.Navigation;
using Autofac;
using Caliburn.Micro;
using Fryst.ViewModels;

namespace Fryst.Frameworks
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationBootstrapper : AutofacBootstrapper
    {
        #region Protected interface

        

        protected override void ConfigureContainer(ContainerBuilder aBuilder)
        {
         
            this.RootFrame.Navigated += RootFrameOnNavigated;
           // aBuilder.RegisterType<ShellViewModel>().AsSelf();
            //aBuilder.RegisterType<ToDoViewModel > ().AsSelf();
            //aBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            //aBuilder.RegisterGeneric(typeof (BaseEntityFactory<>)).As(typeof (IEntityFactory<>)).SingleInstance();
            //aBuilder.RegisterAssemblyTypes(typeof (BaseEntityFactory<>).Assembly).Where(x => x.Name.EndsWith("Factory"))
            //    .AsImplementedInterfaces().AsSelf().SingleInstance();
            //aBuilder.Register((c, p) => new BonumVitaeContext(p.Named<string>(App.DbConnection))).InstancePerLifetimeScope();
        }

        private void RootFrameOnNavigated(object sender, NavigationEventArgs e)
        {
            var navService = GetInstance(typeof(INavigationService), null) as INavigationService;
            if (e.NavigationMode == System.Windows.Navigation.NavigationMode.New && e.Uri.ToString().Contains("BackNavSkipOne=True"))
            {
                RootFrame.RemoveBackEntry();
            }
        }

        #endregion
    }
}