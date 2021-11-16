using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NVConsultingMVC.Models;

using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace NVConsultingMVC.Controllers
{
    public class AlumnosController : Controller
    {
        public string BaseUrl { get; set; }

        public AlumnosController()
        {
            this.BaseUrl = "http://localhost:23043/api/Alumnos";

        }
        // GET: AlumnosController
        public async Task<ActionResult> Index()
        {
            List<VMAlumno> lst = new List<VMAlumno>();

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(BaseUrl);
            HttpResponseMessage resp = await client.GetAsync(""); //la cadena vacia es para ingresar parametros o ruta adicionañ

            if (resp.IsSuccessStatusCode)
            {
                var readtask = resp.Content.ReadAsStringAsync().Result;
                lst = JsonConvert.DeserializeObject<List<VMAlumno>>(readtask);
            }
            return View(lst);

        }

        // GET: AlumnosController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            VMAlumno _Alu;

            //string strUrl = _apiUsuario.BaseUrl + "/api/Usuarios/GetUsuario?id=" + id.ToString();
            //HttpClient client = new HttpClient(); 

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(this.BaseUrl + "/" + id.ToString());

            HttpResponseMessage resp = await client.GetAsync(""); //la cadena vacia es para ingresar parametros o ruta adicionañ

            if (resp.IsSuccessStatusCode)
            {
                var readtask = resp.Content.ReadAsStringAsync().Result;
                _Alu = JsonConvert.DeserializeObject<VMAlumno>(readtask);
                return View(_Alu);
            }
            return View();
        }

        // GET: AlumnosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(VMAlumno Alu)
        {
            try
            {
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(this.BaseUrl + "/Insert");


                StringContent content = new StringContent(JsonConvert.SerializeObject(Alu), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await client.PostAsync("", content); //la cadena vacia es para ingresar parametros o ruta adicionañ

                if (resp.IsSuccessStatusCode)
                {
                    var readtask = resp.Content.ReadAsStringAsync().Result;
                    Alu = JsonConvert.DeserializeObject<VMAlumno>(readtask);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: CategoriasController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            VMAlumno _Alu;


            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(this.BaseUrl + "/" + id.ToString());

            HttpResponseMessage resp = await client.GetAsync("");

            if (resp.IsSuccessStatusCode)
            {
                var readtask = resp.Content.ReadAsStringAsync().Result;
                _Alu = JsonConvert.DeserializeObject<VMAlumno>(readtask);
                return View(_Alu);
            }
            return View();
        }

        // POST: CategoriasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(VMAlumno Alu)
        {
            try
            {
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(this.BaseUrl + "/Edit");


                StringContent content = new StringContent(JsonConvert.SerializeObject(Alu), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await client.PutAsync("", content); //la cadena vacia es para ingresar parametros o ruta adicionañ

                if (resp.IsSuccessStatusCode)
                {
                    var readtask = resp.Content.ReadAsStringAsync().Result;
                    Alu = JsonConvert.DeserializeObject<VMAlumno>(readtask);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriasController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            VMAlumno _Alu;


            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(this.BaseUrl + "/" + id.ToString());

            HttpResponseMessage resp = await client.GetAsync(""); //la cadena vacia es para ingresar parametros o ruta adicionañ

            if (resp.IsSuccessStatusCode)
            {
                var readtask = resp.Content.ReadAsStringAsync().Result;
                _Alu = JsonConvert.DeserializeObject<VMAlumno>(readtask);
                return View(_Alu);
            }
            return View();
        }

        // POST: CategoriasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(VMAlumno Alu)
        {
            try
            {
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(this.BaseUrl + "/Delete" + Alu.IdAlumno.ToString());


                //StringContent content = new StringContent(JsonConvert.SerializeObject(Cat), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await client.DeleteAsync(""); //la cadena vacia es para ingresar parametros o ruta adicionañ

                if (resp.IsSuccessStatusCode)
                {
                    var readtask = resp.Content.ReadAsStringAsync().Result;
                    Alu = JsonConvert.DeserializeObject<VMAlumno>(readtask);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
