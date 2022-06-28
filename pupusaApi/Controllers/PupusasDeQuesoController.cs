using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pupusaApi.Data;

namespace pupusaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PupusasDeQuesoController : ControllerBase
    {
        //Aqui van nuestros metodos que van a responder a peticiones http
        //http:/api/pupusasdequeso/servirComida?deQueLasQuiere=frijolQueso

        [HttpGet("servirComida")]
        public IActionResult dameDosDeQueso(string deQueLasQuiere)
        {
            try
            {
                //validar de alguna forma que el parametro exista o no este vacio, 
                //asi mismo que este el valor de este parametro exista dentro de una lista o arreglo
                return Ok($"Vaya mi amor aqui estan sus pupusas de {deQueLasQuiere} vuelva pront");

            }
            catch (System.Exception e)
            {

                return StatusCode(500 , "Se quemaron las pupas :c" + e);
            }
        }
        //metodo http post el cual va a recivir como parametro un objeto
        // o clase en este caso llamado Pupusa la cual tiene dos atributos 
        // el Id y el Name en el return ok(pupusa) estamos mostrando el json 
        // que enviamos.
        [HttpPost("newPupusa/")]
        public IActionResult crearPupas([FromBody] Pupusa pupusa)
        {
            try
            {
                // accediendo al atributo del objeto recivido (pupusa.name)
                // y asignandolo a la variable string tipoPupusa
                string tipoPupusa = pupusa.Name;
                return Ok(pupusa);
            }
            catch (System.Exception)
            {
                return StatusCode(400, "Ha ocurrido un error");
               
            }
        }
    }
}
