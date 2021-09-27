using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6AirlineReservation
{
    class clsFlights
    {
        //Class variables
        /// <summary>
        /// Flight Id variable
        /// </summary>
        public string sFlightID;
        /// <summary>
        /// Flight number variable
        /// </summary>
        public string sFlightNum;
        /// <summary>
        /// Aircraft Type variable
        /// </summary>
        public string sAircraftType;

        /// <summary>
        /// Override the ToString method so that this string is displayed in the combo box.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            try
            {
                return sFlightNum + " " + sAircraftType;

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
