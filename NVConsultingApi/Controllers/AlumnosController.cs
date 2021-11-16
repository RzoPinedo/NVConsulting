using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NVConsultingApi.Models;
using NVConsultingApi.VIewModel;
using Microsoft.EntityFrameworkCore;

namespace NVConsultingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private readonly DBNVConsultingContext bd;

        public AlumnosController(DBNVConsultingContext context)
        {
            bd = context;
        }

        //LISTAR
        [HttpGet]
        public IEnumerable<VMAlumno> Listaralumnos()
        {
            List<VMAlumno> lstalu = new List<VMAlumno>();
            var alums = (from Alumno c in bd.Alumnos
                        select c).ToList();
            foreach (var item in alums)
            {
                lstalu.Add(new VMAlumno()
                { IdAlumno = item.IdAlumno, Nombres = item.Nombres, Apellidos = item.Apellidos, Dni=item.Dni,Correo=item.Correo,Telefono=item.Telefono,Direccion=item.Direccion } // falta agregar productos
                    );

            }

            return lstalu;
        }

        //OBTENER
        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerAlumno(int id)
        {
            var alu = await bd.Alumnos.FirstOrDefaultAsync(x => x.IdAlumno == id);

            if (alu != null)
            {
                VMAlumno obj = new VMAlumno() { IdAlumno = alu.IdAlumno, Nombres = alu.Nombres, Apellidos = alu.Apellidos, Dni = alu.Dni, Correo = alu.Correo, Telefono = alu.Telefono, Direccion = alu.Direccion };
                return Ok(alu);
            }

            return NotFound();
        }

        [HttpPost("Insert")]
        public IActionResult Crear([FromBody] VMAlumno palu)
        {
            Alumno bdalu = new Alumno() { Nombres = palu.Nombres, Apellidos = palu.Apellidos,Dni=palu.Dni, Correo = palu.Correo, Telefono = palu.Telefono, Direccion = palu.Direccion };
            if (ModelState.IsValid)
            {

                bd.Add(bdalu);
                bd.SaveChanges();

                palu.IdAlumno = bdalu.IdAlumno;
                return Ok(palu);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Editar([FromBody] VMAlumno pAlu)
        {
            Alumno obj = bd.Alumnos.FirstOrDefault(x => x.IdAlumno == pAlu.IdAlumno);

            if (obj == null)
            {
                return BadRequest();
            }

            obj.Nombres = pAlu.Nombres;
            obj.Apellidos = pAlu.Apellidos;
            obj.Dni = pAlu.Dni;
            obj.Correo = pAlu.Correo;
            obj.Telefono = pAlu.Telefono;
            obj.Direccion = pAlu.Direccion;

            bd.Entry(obj).State = EntityState.Modified;
            bd.SaveChanges();
            return Ok(pAlu);
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var obj = bd.Alumnos.FirstOrDefault(P => P.IdAlumno == id);
            if (obj == null)
            {
                return NotFound();
            }
            bd.Alumnos.Remove(obj);
            bd.SaveChanges();
            return Ok();

        }


    }
}
