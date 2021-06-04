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
      container.RegisterSingleton<IDAO<Emplois>, EmploisService>();
      container.RegisterSingleton<IDAO<DetailEmplois>, DetailEmploisService>();
      container.RegisterSingleton<IDAO<Seance>, SeanceService>();

      container.RegisterType<IFiliereService, FiliereService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}