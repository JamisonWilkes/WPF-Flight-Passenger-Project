using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6AirlineReservation
{
    class clsPassenger
    {
        //Class variables
        /// <summary>
        /// string for passenger ID
        /// </summary>
        public string sID;
        /// <summary>
        /// strign for passenger first name
        /// </summary>
        public string sFirstName;
        /// <summary>
        /// string for passenger last name
        /// </summary>
        public string sLastName;
        /// <summary>
        /// string for passenger seat num
        /// </summary>
        public string sSeat;
        /// <summary>
        /// string for passenger flight
        /// </summary>
        public string sFlightID;

        /// <summary>
        /// Override the ToString method so that this string is displayed in the combo box.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            try
            {
                return sFirstName + " " + sLastName;

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
