using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Capstone
{
    //[Serializable]
    class BsEntry
    {

        [JsonProperty]private int bloodSugar;
        [JsonProperty]private DateTime dateTime;

        public BsEntry()
        {
            bloodSugar = 0;
            dateTime = new DateTime(01, 01, 0001) ;
        }
        public BsEntry(int theBloodSugar, DateTime theDateTime)
        {
            bloodSugar = theBloodSugar;
            dateTime = theDateTime;
        }

        public int getBloodSugar()
        {
            return bloodSugar;
        }
        public void setBloodSugar(int theBloodSugar)
        {
            bloodSugar = theBloodSugar;
        }
        public DateTime getDateTime()
        {
            return dateTime;
        }
        public void setDateTime(DateTime theDateTime)
        {
            dateTime = theDateTime;
        }
    }
}
