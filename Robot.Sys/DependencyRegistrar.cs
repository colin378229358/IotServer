using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;
using Robot.IService;
using Robot.Service;

namespace Robot.Sys
{
    public class DependencyRegistrar
    {
        //需要注册的程序集
        private readonly Assembly _controllerAssembly;
        /// <summary>
        /// 注册依赖类：需要提供需要注册程序所在的程序集
        /// </summary>
        /// <param name="assemblies"></param>
        public DependencyRegistrar(Assembly assemblies)
        {
            _controllerAssembly = assemblies;
        }

        public Autofac.IContainer DataRegister()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            #region 业务逻辑类依赖
            builder.RegisterType<RobotsManagerService>().As<IRobotsManagerService>().InstancePerDependency();
            #endregion

            var _contrainer = builder.Build();
            return _contrainer;
        }
    }
}
