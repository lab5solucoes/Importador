﻿using CDT.Importacao.Data.Model;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDT.Importacao.Data.DAL.Classes
{
    public class InformacaoDAO
    {
        private class DAO : AbstractCrudDao<Informacao> { }

        DAO _dao = new DAO();


        public void Salvar(Informacao informacao)
        {
            try
            {
                if (informacao.idInformacao == 0)
                {
                    _dao.Add(informacao);
                    _dao.CommitChanges();
                }
                else
                {
                    _dao.Update(informacao, informacao.idInformacao);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Salvar(List<Informacao> informacoes)
        {
            try
            {
                _dao.BulkInsert(informacoes);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       


        //public void BulkInsert(List<Informacao> informacoes)
        //{
        //    try
        //    {
        //        _dao.BulkInsert(informacoes);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<Informacao> ListarTodos()
        {
            return _dao.GetAll();
        }


        public Informacao Buscar(int id)
        {
            return _dao.Get(id);
        }
    }
}
