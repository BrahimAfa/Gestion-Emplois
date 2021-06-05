using GestionEmploi.Models;
using GestionEmploi.Services;
using GestionEmploi.Services.Impl;
using System;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace GestionEmploi.App_Start
{
    public static class UnityConfig
    {


        public static void RegisterComponents() {

            var container = new UnityContainer();
            container.RegisterSingleton<IDbContext, GestionEmploisDbContext>();
            
           
            container.RegisterType<IDAO<Niveau>, NiveauService>();
            container.RegisterType<IFiliereService, FiliereService>();
            container.RegisterType<IProfessorService, ProfessorService>();
            container.RegisterType<ICourService, CourService>();

      container.RegisterType<IFiliereService, FiliereService>();
      container.RegisterType<ISemaineService, SemainService>();
      container.RegisterType<IDAO<Local>, LocalService>();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}