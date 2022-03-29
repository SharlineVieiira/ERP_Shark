using ERP_Shark.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace ERP_Shark
{
    public class Model
    {
        /*  internal DtoUsuario2 GetUsuarioId(int iD)
          {
              throw new NotImplementedException();
          }

          internal void DeletarUsuario(int v)
          {
              throw new NotImplementedException();
          }

          internal List<DtoUsuario> ListUsuarios()
          {
              throw new NotImplementedException();
          }

          internal void EditUsuario(DtoUsuario u)
          {
              throw new NotImplementedException();
          }

          internal void SetUsuario(DtoUsuario u)
          {
              throw new NotImplementedException();
          }
      }
  }*/
        
        
            public void SetUsuario(DtoUsuario u)
            {
                Context db = new Context();

            db.usuario.Add(u);
            db.SaveChanges();
            }

            public void EditUsuario(DtoUsuario u)
            {
                Context db = new Context();
                DtoUsuario e = db.usuario.FirstOrDefault(p => p.id == u.id);
                e.nome = u.nome;
                e.login = u.login;
                e.senha = u.senha;

            db.SaveChanges();
            }

            public List<DtoUsuario2> ListUsuarios()
            {
                Context db = new Context();
            List<DtoUsuario2> result = (from a in db.usuario
                                            select new DtoUsuario2
                                            {
                                                id = a.id,
                                                nome = a.nome
                                            }).ToList();

                return new List<DtoUsuario2>(result);


            }

            public DtoUsuario2 GetUsuarioId(int id)
            {
                Context db = new Context();
                var result = (from a in db.usuario
                              where a.id == id
                              select new DtoUsuario2
                              {
                                  id = a.id,
                                  nome = a.nome
                              }).FirstOrDefault();

                var result1 = db.usuario.Where(p => p.id == id).FirstOrDefault();

                return result;
            }

            public void DeletarUsuario(int id)
            {
                Context db = new Context();
                DtoUsuario u = db.usuario.FirstOrDefault(p => p.id == id);
            db.usuario.Remove(u);
            db.SaveChanges();
            }
        }
    }