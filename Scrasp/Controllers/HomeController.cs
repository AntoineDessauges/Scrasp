﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scrasp.Models;

namespace Scrasp.Controllers
{
    public class HomeController : Controller
    {

        List<User> users = new List<User>();
        List<Task> tasks = new List<Task>();
        List<Story> stories = new List<Story>();

        public HomeController()
        {
            initData();
        }

        public ActionResult Index()
        {           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Scrasp, un outil de gestion de projet Scrum developpé sur ASP MVC par la classe SI-T2a de 2018";
            return View();
        }

        public ActionResult Add()
        {
            // Ajoutez-y un utilisateur supplémentaire
            users.Add(new User("doran", "1234", "user"));

            ViewBag.Message = "Utilisateur ajouté";
            return View("Index");
        }

        public ActionResult Rename(int id)
        {
            // Renomme un utilisateur
            User user = users.Find(x => x.Id == id);
            if (user == null){
                ViewBag.Message = string.Format("Utilisateur inconnu");
            }
            else{
                ViewBag.Message = string.Format("Utilisateur {0} renommé", id);
                user.UserName = "Toto";
            }
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            // Supprime un utilisateur
            User user = users.Find(x => x.Id == id);
            if (user == null){
                ViewBag.Message = string.Format("Utilisateur inconnu");
            }
            else{
                ViewBag.Message = string.Format("Utilisateur {0} supprimé", id);
                users.Remove(user);
            }
            return View("Index");
        }

        public ActionResult ChangeId(int id, int newId)
        {
            // Change l'id d'un utilisateur
            User user = users.Find(x => x.Id == id);
            if (user == null){
                ViewBag.Message = string.Format("Utilisateur inconnu");
            }
            else{
                try{
                    ViewBag.Message = string.Format("Utilisateur {0} $ maintenat l'id {1}", id, newId);
                    user.Id = newId;
                }
                catch(Exception e){
                    ViewBag.Message = e.Message;
                }
            }
            return View("Index");
        }

        private List<string> getTodoList()
        {
            return 
                new List<string>(new string[] {
                    "Coder les classes décrites dans le modèle Scrasp.asta",
                    "Instancier des objets Story, Task et User hardcodés dans HomeController.Index, les mettre dans des listes, les passer à la vue avec le ViewBag et les afficher dans la section Données ci-dessous",
                    "Compléter HomeController.Add() et Index.cshtml pour faire fonctionner l'ajout d'un utilisateur (premier lien dans les actions ci-dessous)",
                    "Faire de même pour le renommage (deuxième lien lien dans les actions ci-dessous). Observer la différence des routes et méthodes (passage de paramètre)",
                    "Modifier App_Start/RouteConfig.cs pour configurer les routes supplémentaires delete et changeid. Créer les méthodes nécessaires dans HomeController et modifier Index.cshtml pour faire fonctionner les liens de suppression et de modification",
                    "Autoriser la modification de l'attribut id avec une auto-property dans IdentifiableEntity. L'attribut statique lastId prendra la valeur d'id donnée",
                    "Modifier IdentifiableEntity de telle sorte qu'elle lève une exception si l'application tente de changer l'id d'un objet à une valeur inférieure ou égale à lastId. Choisissez la bonne exception en vous appuyant sur https://docs.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions",
                    "Soumettre vos questions au moyen d'issues dans le repo Git"
                });
        }

        private void initData(){

            // Préparez vos données comme dans la méthode Index
            List<string> todo = getTodoList();
            ViewBag.Todo = todo;

            ViewBag.Users = users;
            ViewBag.Tasks = tasks;
            ViewBag.Stories = stories;

            users.Add(new User("antoine", "1234", "user"));
            users.Add(new User("struan", "1234", "user"));

            tasks.Add(new Task("task1", Task.States.pending, users[0], DateTime.Now, 3));
            tasks.Add(new Task("task2", Task.States.pending, users[1], DateTime.Now, 4));
            tasks.Add(new Task("task3", Task.States.pending, users[1], DateTime.Now, 55));

            stories.Add(new Story("story1", "ref1", "antoine", Story.Types.normal, Story.States.pending, 5, tasks));
            stories.Add(new Story("story2", "ref2", "antoine", Story.Types.normal, Story.States.pending, 5, tasks));

        }

    }
}