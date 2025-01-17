﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private TiposCargos _Cargo;
        public TiposCargos Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        public enum TiposCargos
        {
            Jefe,
            Ayudante,
            Docente
        }

        private int _IDCurso;
        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        private string _curso;
        public string Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        private int _IDDocente;
        public int IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }

        private string _docente;
        public string Docente
        {
            get { return _docente; }
            set { _docente = value; }
        }

    }
}
