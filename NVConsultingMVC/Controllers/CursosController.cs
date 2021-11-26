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
    public class CursosController : Controller
    {
        public string BaseUrl { get; set; }

        public CursosController()
        {
            this.BaseUrl = "http://localhost:23043/api/Cursos";

        }
        // GET: AlumnosController
        public async Task<ActionResult> Index()
        {
            List<VMCurso> lst = new List<VMCurso>();

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(BaseUrl);
            HttpResponseMessage resp = await client.GetAsync(""); //la cadena vacia es para ingresar parametros o ruta adicionañ

            if (resp.IsSuccessStatusCode)
            {
                var readtask = resp.Content.ReadAsStringAsync().Result;
                lst = JsonConvert.DeserializeObject<List<VMCurso>>(readtask);
            }
            return View(lst);

        }

        // GET: AlumnosController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            VMCurso _Cur;

            //string strUrl = _apiUsuario.BaseUrl + "/api/Usuarios/GetUsuario?id=" + id.ToString();
            //HttpClient client = new HttpClient(); 

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(this.BaseUrl + "/" + id.ToString());

            HttpResponseMessage resp = await client.GetAsync(""); //la cadena vacia es para ingresar parametros o ruta adicionañ

            if (resp.IsSuccessStatusCode)
            {
                var readtask = resp.Content.ReadAsStringAsync().Result;
                _Cur = JsonConvert.DeserializeObject<VMCurso>(readtask);
                return View(_Cur);
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
        public async Task<ActionResult> Create(VMCurso Cur)
        {
            try
            {
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(this.BaseUrl + "/Insert");


                StringContent content = new StringContent(JsonConvert.SerializeObject(Cur), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await client.PostAsync("", content); //la cadena vacia es para ingresar parametros o ruta adicionañ

                if (resp.IsSuccessStatusCode)
                {
                    var readtask = resp.Content.ReadAsStringAsync().Result;
                    Cur = JsonConvert.DeserializeObject<VMCurso>(readtask);
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
            VMCurso _Cur;


            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(this.BaseUrl + "/" + id.ToString());

            HttpResponseMessage resp = await client.GetAsync("");

            if (resp.IsSuccessStatusCode)
            {
                var readtask = resp.Content.ReadAsStringAsync().Result;
                _Cur = JsonConvert.DeserializeObject<VMCurso>(readtask);
                return View(_Cur);
            }
            return View();
        }

        // POST: CategoriasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(VMCurso Cur)
        {
            try
            {
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(this.BaseUrl + "/Edit");


                StringContent content = new StringContent(JsonConvert.SerializeObject(Cur), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await client.PutAsync("", content); //la cadena vacia es para ingresar parametros o ruta adicionañ

                if (resp.IsSuccessStatusCode)
                {
                    var readtask = resp.Content.ReadAsStringAsync().Result;
                    Cur = JsonConvert.DeserializeObject<VMCurso>(readtask);
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
            VMCurso _Cur;


            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(this.BaseUrl + "/" + id.ToString());

            HttpResponseMessage resp = await client.GetAsync(""); //la cadena vacia es para ingresar parametros o ruta adicionañ

            if (resp.IsSuccessStatusCode)
            {
                var readtask = resp.Content.ReadAsStringAsync().Result;
                _Cur = JsonConvert.DeserializeObject<VMCurso>(readtask);
                return View(_Cur);
            }
            return View();
        }

        // POST: CategoriasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(this.BaseUrl + "/" + id.ToString());


                //StringContent content = new StringContent(JsonConvert.SerializeObject(Cat), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await client.DeleteAsync(""); //la cadena vacia es para ingresar parametros o ruta adicionañ

                if (resp.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }

                return View();

            }
            catch
            {
                return View();
            }
        }
    }
}
