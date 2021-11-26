using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NVConsultingApi.Models;
using NVConsultingApi.VIewModel;
using Microsoft.EntityFrameworkCore;

namespace NVConsultingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : Controller
    {
        private readonly DBNVConsultingContext bd;

        public CursosController(DBNVConsultingContext context)
        {
            bd = context;
        }

        //LISTAR
        [HttpGet]
        public IEnumerable<VMCurso> Listarcursos()
        {
            List<VMCurso> lstacur = new List<VMCurso>();
            var curs = (from Curso c in bd.Cursos
                         select c).ToList();
            foreach (var item in curs)
            {
                lstacur.Add(new VMCurso()
                { IdCursos = item.IdCursos, Nombre = item.Nombre, NroHoras = item.NroHoras, FechaInicio = item.FechaInicio, FechaFin = item.FechaFin, PrecioCurso = item.PrecioCurso, IdEmpleados = item.IdEmpleados } // falta agregar productos
                    );

            }

            return lstacur;
        }

        //OBTENER
        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerCurso(int id)
        {
            var cur = await bd.Cursos.FirstOrDefaultAsync(x => x.IdCursos == id);

            if (cur != null)
            {
                VMCurso obj = new VMCurso() { IdCursos = cur.IdCursos, Nombre = cur.Nombre, NroHoras = cur.NroHoras, FechaInicio = cur.FechaInicio, FechaFin = cur.FechaFin, PrecioCurso = cur.PrecioCurso, IdEmpleados = cur.IdEmpleados };
                return Ok(cur);
            }

            return NotFound();
        }

        [HttpPost("Insert")]
        public IActionResult Crear([FromBody] VMCurso pcur)
        {
            Curso bdcur = new Curso() { Nombre = pcur.Nombre, NroHoras = pcur.NroHoras, FechaInicio = pcur.FechaInicio, FechaFin = pcur.FechaFin, PrecioCurso = pcur.PrecioCurso, IdEmpleados = pcur.IdEmpleados };
            if (ModelState.IsValid)
            {

                bd.Add(bdcur);
                bd.SaveChanges();

                pcur.IdCursos = bdcur.IdCursos;
                return Ok(pcur);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Editar([FromBody] VMCurso pCur)
        {
            Curso obj = bd.Cursos.FirstOrDefault(x => x.IdCursos == pCur.IdCursos);

            if (obj == null)
            {
                return BadRequest();
            }

            obj.Nombre = pCur.Nombre;
            obj.NroHoras = pCur.NroHoras;
            obj.FechaInicio = pCur.FechaInicio;
            obj.FechaFin = pCur.FechaFin;
            obj.PrecioCurso = pCur.PrecioCurso;
            obj.IdEmpleados = pCur.IdEmpleados;

            bd.Entry(obj).State = EntityState.Modified;
            bd.SaveChanges();
            return Ok(pCur);
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var obj = bd.Cursos.FirstOrDefault(P => P.IdCursos == id);
            if (obj == null)
            {
                return NotFound();
            }
            bd.Cursos.Remove(obj);
            bd.SaveChanges();
            return Ok();

        }

    }
}
