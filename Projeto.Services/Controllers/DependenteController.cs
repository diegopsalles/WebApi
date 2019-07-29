using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper; //importando
using Projeto.Entities; //importando
using Projeto.Services.Models; //importando

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/Dependente")]
    public class DependenteController : ApiController
    {
        [HttpPost] //requisições do tipo POST
        public HttpResponseMessage Post(DependenteCadastroViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    //transferir os dados da model para entidade
                    var dependente = Mapper.Map<Dependente>(model);
                    //TODO..

                    return Request.CreateResponse(HttpStatusCode.OK,
                        $"Dependente {model.Nome}, cadastrado com sucesso.");
                }
                catch(Exception e)
                {
                    //erro HTTP 500 -> INTERNAL SERVER ERROR
                    return Request.CreateResponse(HttpStatusCode.InternalServerError,
                        "Erro interno de servidor: " + e.Message);
                }
            }
            else
            {
                //erro HTTP 400 -> BAD REQUEST
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                                        "Ocorreram erros de validação.");
            }
        }

        [HttpPut] //requisições do tipo PUT
        public HttpResponseMessage Put(DependenteEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //transferir os dados da model para entidade
                    var dependente = Mapper.Map<Dependente>(model);
                    //TODO..

                    return Request.CreateResponse(HttpStatusCode.OK,
                        $"Dependente {model.Nome}, atualizado com sucesso.");
                }
                catch (Exception e)
                {
                    //erro HTTP 500 -> INTERNAL SERVER ERROR
                    return Request.CreateResponse(HttpStatusCode.InternalServerError,
                        "Erro interno de servidor: " + e.Message);
                }
            }
            else
            {
                //erro HTTP 400 -> BAD REQUEST
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                                        "Ocorreram erros de validação.");
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                //TODO..

                return Request.CreateResponse(HttpStatusCode.OK,
                            "Dependente excluído com sucesso.");
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,
                    "Erro interno de servidor: " + e.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                //TODO..
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,
                    "Erro interno de servidor: " + e.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                //TODO..
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,
                    "Erro interno de servidor: " + e.Message);
            }
        }

    }
}
