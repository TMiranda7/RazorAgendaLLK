using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_agendaLanlink.Models.Enum;

namespace WEB_agendaLanlink.Models.DataObject
{
    public class TipoEndereco
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Residencia
        {
            get { 
                return Id == (int)tipoEndereco.apartamnto; 
            }
        }
        public bool EBuffet
        {
            get { 
                return Id == (int)tipoEndereco.casa; 
            }
        }
        public bool EComercio
        {
            get {
                return Id == (int)tipoEndereco.sitio; 
            }
        }
        public bool EGalpão
        {
            get { return Id == (int)tipoEndereco.galpao; }
        }
    }
}