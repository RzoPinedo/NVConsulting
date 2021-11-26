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
        public class EmpleadosController : ControllerBase
        {
            private readonly DBNVConsultingContext bd;

            public EmpleadosController(DBNVConsultingContext context)
            {
                bd = context;
            }

            //LISTAR
            [HttpGet]
            public IEnumerable<VMEmpleados> Listarempleados()
            {
                List<VMEmpleados> lstemp = new List<VMEmpleados>();
                var emps = (from Empleado e in bd.Empleados
                             select e).ToList();
                foreach (var item in emps)
                {
                    lstemp.Add(new VMEmpleados()
                    { IdEmpleados = item.IdEmpleados, Nombres = item.Nombres, Apellidos = item.Apellidos, Dni = item.Dni, Correo = item.Correo, Telefono = item.Telefono, Direccion = item.Direccion, IdCargo = item.IdCargo}
                        );

                }

                return lstemp;
            }

            //OBTENER
            [HttpGet("{id}")]
            public async Task<IActionResult> ObtenerEmpleado(int id)
            {
                var emp = await bd.Empleados.FirstOrDefaultAsync(x => x.IdEmpleados == id);

                if (emp != null)
                {
                    VMEmpleados obj = new VMEmpleados() { IdEmpleados = emp.IdEmpleados, Nombres = emp.Nombres, Apellidos = emp.Apellidos, Dni = emp.Dni, Correo = emp.Correo, Telefono = emp.Telefono, Direccion = emp.Direccion, IdCargo = emp.IdCargo };
                    return Ok(emp);
                }

                return NotFound();
            }

            [HttpPost("Insert")]
            public IActionResult Crear([FromBody] VMEmpleados pemp)
            {
                Empleado bdemp = new Empleado() { Nombres = pemp.Nombres, Apellidos = pemp.Apellidos, Dni = pemp.Dni, Correo = pemp.Correo, Telefono = pemp.Telefono, Direccion = pemp.Direccion, IdCargo = pemp.IdCargo };
                if (ModelState.IsValid)
                {

                    bd.Add(bdemp);
                    bd.SaveChanges();

                    pemp.IdEmpleados = bdemp.IdEmpleados;
                    return Ok(pemp);
                }
                return BadRequest(ModelState);
            }

            [HttpPut("{id}")]
            public IActionResult Editar([FromBody] VMEmpleados pEmp)
            {
                Empleado obj = bd.Empleados.FirstOrDefault(x => x.IdEmpleados == pEmp.IdEmpleados);

                if (obj == null)
                {
                    return BadRequest();
                }

                obj.Nombres = pEmp.Nombres;
                obj.Apellidos = pEmp.Apellidos;
                obj.Dni = pEmp.Dni;
                obj.Correo = pEmp.Correo;
                obj.Telefono = pEmp.Telefono;
                obj.Direccion = pEmp.Direccion;
                obj.IdCargo = pEmp.IdCargo;

                bd.Entry(obj).State = EntityState.Modified;
                bd.SaveChanges();
                return Ok(pEmp);
            }

            [HttpDelete("{id}")]
            public IActionResult Eliminar(int id)
            {
                var obj = bd.Empleados.FirstOrDefault(P => P.IdEmpleados == id);
                if (obj == null)
                {
                    return NotFound();
                }
                bd.Empleados.Remove(obj);
                bd.SaveChanges();
                return Ok();

            }
        }
}
