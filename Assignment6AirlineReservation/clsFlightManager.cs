using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6AirlineReservation
{
    class clsFlightManager
    {
        #region attributes
        /// <summary>
        /// ArrayLIst to hold the list fo flights
        /// </summary>
        public ArrayList myFlightsList = new ArrayList();

        /// <summary>
        /// Array list to hold the list of passengers
        /// </summary>
        public  ArrayList myPassengerList = new ArrayList();

        /// <summary>
        /// Dictionary to hold the seats and names of the people in flight one
        /// </summary>
        public  IDictionary<string, string> myPassengerSeatsFlight1 = new Dictionary<string, string>();

        /// <summary>
        /// Dictionary to hold the seats and names of the people ine flight two
        /// </summary>
        public  IDictionary<string, string> myPassengerSeatsFlight2 = new Dictionary<string, string>();

        /// <summary>
        /// Dictionary to hold the seats of the names and seat number of the passengers
        /// </summary>
        public  IDictionary<string, string> myPassengerSeats = new Dictionary<string, string>();

        /// <summary>
        /// Dictionary to hold the names and IDs of the passengers
        /// </summary>
        public IDictionary<string, string> myPassengerIDNames = new Dictionary<string, string>();


        /// <summary>
        /// New clsDataAccess object to create new database connection
        /// </summary>
        clsDataAccess db = new clsDataAccess();

        /// <summary>
        /// new flights class object 
        /// </summary>
        clsFlights clsFlights; //Used to load the return values into the combo box

        /// <summary>
        /// String for flight one
        /// </summary>
        public string sFlightIDone = "1";

        /// <summary>
        /// String for flight two
        /// </summary>
        public string sFlightIDtwo = "2";

        /// <summary>
        /// Method to get an ArrayList of the flights
        /// </summary>
        /// <returns></returns>
        public ArrayList getFlights()
        {
            try
            {
                string sSQL;    //Holds an SQL statement
                int iRet = 0;   //Number of return values
                DataSet ds = new DataSet(); //Holds the return values

                //Create the SQL statement to extract the passengers
                sSQL = "SELECT Flight_ID, Flight_Number, AirCraft_Type FROM Flight; ";
                
                //Extract the passengers and put them into the DataSet
                ds = db.ExecuteSQLStatement(sSQL, ref iRet);

                clsFlights = new clsFlights();

                //Loop through the data and create passenger classes
                for (int i = 0; i < iRet; i++)
                {

                    clsFlights.sFlightID = ds.Tables[0].Rows[i][0].ToString();
                    clsFlights.sFlightNum = ds.Tables[0].Rows[i][1].ToString();
                    clsFlights.sAircraftType = ds.Tables[0].Rows[i]["Aircraft_Type"].ToString();

                    string sMyFlight =  clsFlights.sFlightID + ": " + clsFlights.sFlightNum + " " + clsFlights.sAircraftType;

                    myFlightsList.Add(sMyFlight);
                    
                }
                return myFlightsList;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// String for the seat that has been displayed
        /// </summary>
        public string currentSeatNumDisplayed;

        /// <summary>
        /// String for the current passenger's id
        /// </summary>
        public string currentPassengerID;

        /// <summary>
        /// String for the seat number chosen
        /// </summary>
        public string seatNumberChosen;
        #endregion

        #region Methods
        /// <summary>
        /// Method to get an arrayLIst of passengers
        /// </summary>
        /// <returns></returns>
        public ArrayList getPassengers(string sFlightID)
        {
            try
            {
                string sSQL;
                int iRet = 0;
                DataSet ds = new DataSet();
                clsPassenger clsPassenger;
                myPassengerList.Clear();
                myPassengerSeats.Clear();
                myPassengerSeatsFlight1.Clear();
                myPassengerSeatsFlight2.Clear();
                myPassengerIDNames.Clear();

                sSQL = "SELECT Flight.Flight_ID, PASSENGER.Passenger_ID, First_Name, Last_Name, Seat_Number " +
                        "FROM FLIGHT_PASSENGER_LINK, FLIGHT, PASSENGER " +
                        "WHERE FLIGHT.Flight_ID = FLIGHT_PASSENGER_LINK.Flight_ID AND " +
                        "FLIGHT_PASSENGER_LINK.PASSENGER_ID = PASSENGER.PASSENGER_ID AND " +
                        "Flight.Flight_ID = " + sFlightID + ";";

                ds = db.ExecuteSQLStatement(sSQL, ref iRet);

                if(sFlightID == "1")
                {
                    for (int i = 0; i < iRet; i++)
                    {
                        clsPassenger = new clsPassenger();
                        clsPassenger.sFlightID = ds.Tables[0].Rows[i]["Flight_ID"].ToString();
                        clsPassenger.sSeat = ds.Tables[0].Rows[i]["Seat_Number"].ToString();
                        clsPassenger.sFirstName = ds.Tables[0].Rows[i]["First_Name"].ToString();
                        clsPassenger.sLastName = ds.Tables[0].Rows[i]["Last_Name"].ToString();
                        clsPassenger.sID = ds.Tables[0].Rows[i]["Passenger_ID"].ToString();

                        string sMyPassenger = clsPassenger.ToString();

                        myPassengerList.Add(sMyPassenger);
                        myPassengerSeatsFlight1.Add(clsPassenger.ToString(), clsPassenger.sSeat);
                        myPassengerSeats.Add(clsPassenger.ToString(), clsPassenger.sSeat);
                        myPassengerIDNames.Add(clsPassenger.sID, clsPassenger.ToString());

                    }
                }
                else if(sFlightID == "2")
                {
                    for (int i = 0; i < iRet; i++)
                    {
                        clsPassenger = new clsPassenger();
                        clsPassenger.sFlightID = ds.Tables[0].Rows[i]["Flight_ID"].ToString();
                        clsPassenger.sSeat = ds.Tables[0].Rows[i]["Seat_Number"].ToString();
                        clsPassenger.sFirstName = ds.Tables[0].Rows[i]["First_Name"].ToString();
                        clsPassenger.sLastName = ds.Tables[0].Rows[i]["Last_Name"].ToString();
                        clsPassenger.sID = ds.Tables[0].Rows[i]["Passenger_ID"].ToString();

                        string sMyPassenger = clsPassenger.ToString();

                        myPassengerList.Add(sMyPassenger);
                        myPassengerSeatsFlight2.Add(clsPassenger.ToString(), clsPassenger.sSeat);
                        myPassengerSeats.Add(clsPassenger.ToString(), clsPassenger.sSeat);
                        myPassengerIDNames.Add(clsPassenger.sID, clsPassenger.ToString());

                    }
                }
                
                return myPassengerList;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// This method inserts the new passenger into the database
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void InsertNewPassenger(string firstName, string lastName)
        {
            try
            {
                string sSQL;    //Holds an SQL statement

                //Inserting a passenger
                sSQL = "INSERT INTO PASSENGER(First_Name, Last_Name) VALUES('" + firstName + "' ,'" + lastName + "')";
                db.ExecuteNonQuery(sSQL);

                //sSQL = "SELECT Passenger_ID from Passenger where First_Name = 'Shawn' AND Last_Name = 'Cowder'";
                // db.ExecuteScalarSQL(sSQL);
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }


        }

        /// <summary>
        /// This method returns the Passenger ID for the most recently created passenger 
        /// </summary>
        /// <returns></returns>
        public string getMaxPassenger()
        {
            try
            {
                string sSQL = "SELECT MAX(Passenger_ID) FROM Passenger";
                string newestPassengerID = db.ExecuteScalarSQL(sSQL);

                return newestPassengerID;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
           
        }

        /// <summary>
        /// This method gets the first and last name of the newest passenger added and concatenates them into a single string
        /// </summary>
        /// <param name="passengerID"></param>
        /// <returns></returns>
        public string getNewsestPassenger(string passengerID)
        {
            try
            {
                string sSQL;
                int iRet = 0;
                DataSet ds = new DataSet();
                string newestPassenger;
                clsPassenger clsPassenger;
                clsPassenger = new clsPassenger();

                sSQL = "SELECT First_Name, Last_Name FROM Passenger WHERE Passenger_ID =" + passengerID;
                ds = db.ExecuteSQLStatement(sSQL, ref iRet);

                for (int i = 0; i < iRet; i++)
                {
                    clsPassenger.sFirstName = ds.Tables[0].Rows[i]["First_Name"].ToString();
                    clsPassenger.sLastName = ds.Tables[0].Rows[i]["Last_Name"].ToString();

                }
                newestPassenger = clsPassenger.sFirstName + " " + clsPassenger.sLastName;

                return newestPassenger;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }

        
        /// <summary>
        /// This method inserts the passenger, id and seat number into flight 1
        /// </summary>
        public void insertPassengerLinkFlightOne()
        {
            try
            {
                string sSQL;
                sSQL = "INSERT INTO Flight_Passenger_Link(Flight_ID, Passenger_ID, Seat_Number) " +
                       "VALUES('" + 1 + "','" + getMaxPassenger() + "','" + currentSeatNumDisplayed + "')";
                db.ExecuteNonQuery(sSQL);
                //myPassengerSeatsFlight1.Add(getNewsestPassenger("1"), currentSeatNumDisplayed);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method inserts the passenger, id and seat number into flight 2
        /// </summary>
        public void insertPassengerLinkFlightTwo()
        {
            try
            {
                string sSQL;
                sSQL = "INSERT INTO Flight_Passenger_Link(Flight_ID, Passenger_ID, Seat_Number) " +
                       "VALUES('" + 2 + "','" + getMaxPassenger() + "','" + currentSeatNumDisplayed + "')";
                db.ExecuteNonQuery(sSQL);

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method deletes a passenger from the flight
        /// </summary>
        /// <param name="passID"></param>
        public void deletePassenger(string passID)
        {
            string sSQL = "Delete FROM PASSENGER WHERE PASSENGER_ID =" + passID;
            db.ExecuteNonQuery(sSQL);

        }

        #endregion
    }


}
