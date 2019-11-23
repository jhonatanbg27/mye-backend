using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Hospital.Service;
using Hospital.Entity;
using System;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;

namespace Hospital.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController (IUserService userService)
        {
            this.userService = userService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult  Get()
        {
            return Ok(
                userService.GetAll()
            );
        }

        // GET api/values/5
  
        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] User  user)
        {
            return Ok(
            userService.Save( user)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] User  user)
        {
            return Ok(
            userService.Update( user)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            userService.Delete(id)
            
            );
        }

          //   [HttpPost("[action]")]
          //
        //public async Task<IActionResult> Login( model)
       // {
           // var email = model.email.ToLower();
            //verificare primero si existe un usuario con el mismo email
           // var usuario = await _context.Usuarios.Where(u => u.condicion == true).Include(u => u.rol).FirstOrDefaultAsync(u => u.email == email);
            //if (usuario == null)
          //  {
            //    return NotFound();
          //  }
            //verificamos password
           // if (!VerificarPassword(model.password, usuario.password_hash, usuario.password_salt))
//{
         //       //Si es falso
             //   return NotFound();
          //  }

            //Estos claims contendrán informacion sobre el usuario
        //    var claims = new List<Claim>
           // {
                //Para netcore
              //  new Claim(ClaimTypes.NameIdentifier, usuario.idusuario.ToString()),
//                new Claim(ClaimTypes.Email, email),
        //        new Claim(ClaimTypes.Role, usuario.rol.nombre),
                //Para vuetify
             //   new Claim("idusuario", usuario.idusuario.ToString()),
//                new Claim("rol", usuario.rol.nombre),
            //    new Claim("nombre", usuario.nombre)
         //   };

            //El frontend recibirá este token y conocerá sus roles
           // return Ok(new { token = GenerarToken(claims) });
       // }

        //Nuestro servidor es el que generará el token y le indicará al usuario que
        //privilegio va tener mediante ese token
        //Usamos para esto jason web token
      //  private string GenerarToken(List<Claim> claims)
     //   {
         //   var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
         //   var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

          //  var token = new JwtSecurityToken(
        //      _config["Jwt:Issuer"],
             // _config["Jwt:Issuer"],
          //    expires: DateTime.Now.AddMinutes(30),
           //   signingCredentials: creds,
              //claims: claims);

           // return new JwtSecurityTokenHandler().WriteToken(token);
      //  }

        

     //   private bool VerificarPassword(string password, string[] passwordHash_almacenado, byte[] passwordSalt )
      //  {
            //Vamos a encriptar el password usando la llave passwordSalt y si el resultado es igual al password Hash entonces el password es correcto
           // using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) {
              //  var passwordHashNuevo = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                //Con esto comparamos la secuencia de bytes, devolvera true si son iguales
             //   return new ReadOnlySpan<string>(passwordHash_almacenado).SequenceEqual(new ReadOnlySpan<string>(passwordHashNuevo));
//}
      ////}
    }



}
