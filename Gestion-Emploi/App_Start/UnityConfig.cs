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

      container.RegisterType<IDAO<Seance>, SeanceService>();

      container.RegisterType<IDAO<Niveau>, NiveauService>();
            container.RegisterType<IDAO<Filiere>, FiliereService>();
            container.RegisterType<IProfessorService, ProfessorService>();
            container.RegisterType<ICourService, CourService>();
      container.RegisterSingleton<IDAO<Emplois>, EmploisService>();
      container.RegisterSingleton<IDAO<DetailEmplois>, DetailEmploisService>();
      container.RegisterType<ISemaineService, SemainService>();
      container.RegisterType<IDAO<Local>, LocalService>();
      container.RegisterType<IDAO<Group>, GroupService>();
      container.RegisterType<IDAO<Annee>, AnneeService>();
      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}