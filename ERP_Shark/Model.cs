using ERP_Shark.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Shark
{
    public class Model
    {
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

        public void EditProduto(DtoProduto pd)
        {
            Context db = new Context();
            DtoProduto j = db.produto.FirstOrDefault(q => q.idProduto == pd.idProduto);
            j.descricaoproduto = pd.descricaoproduto;
            j.idProduto = pd.idProduto;
            

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
        public List<DtoProduto2> ListProduto()
        {
            Context db = new Context();
            List<DtoProduto2> result = (from b in db.produto
                                        select new DtoProduto2
                                        {
                                            idProduto = b.idProduto,
                                            descricaoproduto = b.descricaoproduto
                                        }).ToList();

            return new List<DtoProduto2>(result);


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

        public void SetProduto(DtoProduto pd)
    {
           
                Context db = new Context();

                db.produto.Add(pd);
                db.SaveChanges();
            }
        }

      
    }

