using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiresShopApplication
{
    internal class InnerAutoModif : IDbClass
    {
        private int _id;
        private string _model;
        private int _year;
        private string _diameter;
        private string _nameModel;
        private string _nameMark;

        public int Id { get { return _id; } set { _id = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        public string Diameter { get { return _diameter; } set { _diameter = value; } }
        public string NameModel { get { return _nameModel; } set { _nameModel = value; } }
        public string NameMark { get { return _nameMark; } set { _nameMark = value; } }

        public InnerAutoModif(int id, string autoMarkName, string autoModelName, string autoModifName, int year, string diameter, string nameModel, string namemark)
        {
            _id = id;
            _model = $"{autoMarkName} {autoModelName} {autoModifName}";
            _year = year;
            _diameter = diameter;
            _nameModel = $"{ autoModelName} {autoModifName}";
            _nameMark = $"{autoMarkName} ";

        }
    }
}
