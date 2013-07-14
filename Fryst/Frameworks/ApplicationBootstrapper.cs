// Проект: WindowsPhoneTestApplication
// Имя файла: ApplicationBootstrapper.cs
// GUID файла: C16FE24E-6DE4-403E-A522-A273B4478CBF
// Автор: Mike Eshva (mike@eshva.ru)
// Дата создания: 14.05.2012

using Autofac;
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
         
           // aBuilder.RegisterType<TestViewModel>().AsSelf();
            //aBuilder.RegisterType<ToDoViewModel > ().AsSelf();
            //aBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            //aBuilder.RegisterGeneric(typeof (BaseEntityFactory<>)).As(typeof (IEntityFactory<>)).SingleInstance();
            //aBuilder.RegisterAssemblyTypes(typeof (BaseEntityFactory<>).Assembly).Where(x => x.Name.EndsWith("Factory"))
            //    .AsImplementedInterfaces().AsSelf().SingleInstance();
            //aBuilder.Register((c, p) => new BonumVitaeContext(p.Named<string>(App.DbConnection))).InstancePerLifetimeScope();
        }

        #endregion
    }
}