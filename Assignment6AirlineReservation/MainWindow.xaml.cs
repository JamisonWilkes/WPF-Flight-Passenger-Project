using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment6AirlineReservation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Instance of the add window form
        /// </summary>
        wndAddPassenger wndAddPass;

        /// <summary>
        /// new flight manager object
        /// </summary>
        clsFlightManager clsFlightManager;

        /// <summary>
        /// new flight class object
        /// </summary>
        clsFlights clsFlights;

        /// <summary>
        /// New passenger class object
        /// </summary>
        clsPassenger clsPassenger;

        /// <summary>
        /// ArrayList to hold the seats that are taken in flight 1
        /// </summary>
        public ArrayList seatsTakenListFlight1 = new ArrayList();

        /// <summary>
        /// Arraylist to hold the seats that are taken in flight 2
        /// </summary>
        public ArrayList seatsTakenListFlight2 = new ArrayList();


        /// <summary>
        /// Initializes the main window
        /// </summary>
        public MainWindow()
        {
            try
            {
                InitializeComponent();

                clsFlightManager = new clsFlightManager();
                clsFlights = new clsFlights();
                clsPassenger = new clsPassenger();
                cbChooseFlight.ItemsSource = clsFlightManager.getFlights();
                cbChoosePassenger.SelectedItem = " ";
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Method to handle the flight selection change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbChooseFlight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                seatsTakenListFlight1.Clear();
                seatsTakenListFlight2.Clear();

                cbChoosePassenger.IsEnabled = true;
                cbChoosePassenger.ItemsSource = null;
                cbChoosePassenger.SelectedItem = " ";

                cmdAddPassenger.IsEnabled = true;

                if (cbChooseFlight.SelectedItem.ToString().Contains("102"))
                {
                    cbChoosePassenger.ItemsSource = null;

                    CanvasA380.Visibility = Visibility.Visible;
                    Canvas767.Visibility = Visibility.Hidden;

                    cbChoosePassenger.ItemsSource = clsFlightManager.getPassengers(clsFlightManager.sFlightIDone);

                    foreach (KeyValuePair<string, string> seat in clsFlightManager.myPassengerSeatsFlight1)
                    {
                       seatsTakenListFlight1.Add(seat.Value);
                    }
                    #region takenSeatsIfLogic
                    if (seatsTakenListFlight1.Contains(SeatA1.Content))
                    {
                        SetBackgroundColorRed(SeatA1);
                        SeatA1.IsEnabled = true;
                        SeatA1.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA2.Content))
                    {
                        SetBackgroundColorRed(SeatA2);
                        SeatA2.IsEnabled = true;
                        SeatA2.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA3.Content))
                    {
                        SetBackgroundColorRed(SeatA3);
                        SeatA3.IsEnabled = true;
                        SeatA3.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA4.Content))
                    {
                        SetBackgroundColorRed(SeatA4);
                        SeatA4.IsEnabled = true;
                        SeatA4.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA5.Content))
                    {
                        SetBackgroundColorRed(SeatA5);
                        SeatA5.IsEnabled = true;
                        SeatA5.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA6.Content))
                    {
                        SetBackgroundColorRed(SeatA6);
                        SeatA6.IsEnabled = true;
                        SeatA6.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA7.Content))
                    {
                        SetBackgroundColorRed(SeatA7);
                        SeatA7.IsEnabled = true;
                        SeatA7.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA8.Content))
                    {
                        SetBackgroundColorRed(SeatA8);
                        SeatA8.IsEnabled = true;
                        SeatA8.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA9.Content))
                    {
                        SetBackgroundColorRed(SeatA9);
                        SeatA9.IsEnabled = true;
                        SeatA9.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA10.Content))
                    {
                        SetBackgroundColorRed(SeatA10);
                        SeatA10.IsEnabled = true;
                        SeatA10.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA11.Content))
                    {
                        SetBackgroundColorRed(SeatA11);
                        SeatA11.IsEnabled = true;
                        SeatA11.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA12.Content))
                    {
                        SetBackgroundColorRed(SeatA12);
                        SeatA12.IsEnabled = true;
                        SeatA12.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA13.Content))
                    {
                        SetBackgroundColorRed(SeatA13);
                        SeatA13.IsEnabled = true;
                        SeatA13.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA14.Content))
                    {
                        SetBackgroundColorRed(SeatA14);
                        SeatA14.IsEnabled = true;
                        SeatA14.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight1.Contains(SeatA15.Content))
                    {
                        SetBackgroundColorRed(SeatA15);
                        SeatA15.IsEnabled = true;
                        SeatA15.Tag = "SeatTaken";
                    }
                    #endregion
                }
                else if(cbChooseFlight.SelectedItem.ToString().Contains("412"))
                {

                    Canvas767.Visibility = Visibility.Visible;
                    CanvasA380.Visibility = Visibility.Hidden;

                    cbChoosePassenger.ItemsSource = null;
                    cbChoosePassenger.ItemsSource = clsFlightManager.getPassengers(clsFlightManager.sFlightIDtwo);

                    foreach (KeyValuePair<string, string> seat in clsFlightManager.myPassengerSeatsFlight2)
                    {
                        seatsTakenListFlight2.Add(seat.Value);
                    }
                    #region takenSeatsIfLogic
                    if (seatsTakenListFlight2.Contains(Seat1.Content))
                    {
                        SetBackgroundColorRed(Seat1);
                        Seat1.IsEnabled = true;
                        Seat1.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat2.Content))
                    {
                        SetBackgroundColorRed(Seat2);
                        Seat2.IsEnabled = true;
                        Seat2.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat3.Content))
                    {
                        SetBackgroundColorRed(Seat3);
                        Seat3.IsEnabled = true;
                        Seat3.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat4.Content))
                    {
                        SetBackgroundColorRed(Seat4);
                        Seat4.IsEnabled = true;
                        Seat4.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat5.Content))
                    {
                        SetBackgroundColorRed(Seat5);
                        Seat5.IsEnabled = true;
                        Seat5.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat6.Content))
                    {
                        SetBackgroundColorRed(Seat6);
                        Seat6.IsEnabled = true;
                        Seat6.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat7.Content))
                    {
                        SetBackgroundColorRed(Seat7);
                        Seat7.IsEnabled = true;
                        Seat7.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat8.Content))
                    {
                        SetBackgroundColorRed(Seat8);
                        Seat8.IsEnabled = true;
                        Seat8.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat9.Content))
                    {
                        SetBackgroundColorRed(Seat9);
                        Seat9.IsEnabled = true;
                        Seat9.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat10.Content))
                    {
                        SetBackgroundColorRed(Seat10);
                        Seat10.IsEnabled = true;
                        Seat10.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat11.Content))
                    {
                        SetBackgroundColorRed(Seat11);
                        Seat11.IsEnabled = true;
                        Seat11.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat12.Content))
                    {
                        SetBackgroundColorRed(Seat12);
                        Seat12.IsEnabled = true;
                        Seat12.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat13.Content))
                    {
                        SetBackgroundColorRed(Seat13);
                        Seat13.IsEnabled = true;
                        Seat13.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat14.Content))
                    {
                        SetBackgroundColorRed(Seat14);
                        Seat14.IsEnabled = true;
                        Seat14.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat15.Content))
                    {
                        SetBackgroundColorRed(Seat15);
                        Seat15.IsEnabled = true;
                        Seat15.Tag = "SeatTaken";
                    }
                    if (seatsTakenListFlight2.Contains(Seat16.Content))
                    {
                        SetBackgroundColorRed(Seat16);
                        Seat16.IsEnabled = true;
                        Seat16.Tag = "SeatTaken";
                    }
                    #endregion
                }

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Opens up the add passenger window when clicked and inserts a new passenger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAddPassenger_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wndAddPass = new wndAddPassenger();
                wndAddPass.ShowDialog();

                clsFlightManager.myPassengerList.Add(clsFlightManager.getNewsestPassenger(clsFlightManager.getMaxPassenger()));
                cbChoosePassenger.SelectedItem = clsFlightManager.getNewsestPassenger(clsFlightManager.getMaxPassenger());
                gbPassengerInformation.IsEnabled = false;
                gPassengerCommands.IsEnabled = false;

                if (cbChooseFlight.SelectedItem.ToString().Contains("102"))
                {
                    #region enableSeatsIFs
                    if (SeatA1.Tag.Equals("SeatEmpty"))
                    {
                        SeatA1.IsEnabled = true;
                    }
                    if (SeatA2.Tag.Equals("SeatEmpty"))
                    {
                        SeatA2.IsEnabled = true;
                    }
                    if (SeatA3.Tag.Equals("SeatEmpty"))
                    {
                        SeatA3.IsEnabled = true;
                    }
                    if (SeatA4.Tag.Equals("SeatEmpty"))
                    {
                        SeatA4.IsEnabled = true;
                    }
                    if (SeatA5.Tag.Equals("SeatEmpty"))
                    {
                        SeatA5.IsEnabled = true;
                    }
                    if (SeatA6.Tag.Equals("SeatEmpty"))
                    {
                        SeatA6.IsEnabled = true;
                    }
                    if (SeatA7.Tag.Equals("SeatEmpty"))
                    {
                        SeatA7.IsEnabled = true;
                    }
                    if (SeatA8.Tag.Equals("SeatEmpty"))
                    {
                        SeatA8.IsEnabled = true;
                    }
                    if (SeatA9.Tag.Equals("SeatEmpty"))
                    {
                        SeatA9.IsEnabled = true;
                    }
                    if (SeatA10.Tag.Equals("SeatEmpty"))
                    {
                        SeatA10.IsEnabled = true;
                    }
                    if (SeatA11.Tag.Equals("SeatEmpty"))
                    {
                        SeatA12.IsEnabled = true;
                    }
                    if (SeatA13.Tag.Equals("SeatEmpty"))
                    {
                        SeatA14.IsEnabled = true;
                    }
                    if (SeatA15.Tag.Equals("SeatEmpty"))
                    {
                        SeatA15.IsEnabled = true;
                    }
                    #endregion

                }
                else if (cbChooseFlight.SelectedItem.ToString().Contains("412"))
                {
                    #region enableSeatsIFs
                    if (Seat1.Tag.Equals("SeatEmpty"))
                    {
                        Seat1.IsEnabled = true;
                    }
                    if (Seat2.Tag.Equals("SeatEmpty"))
                    {
                        Seat2.IsEnabled = true;
                    }
                    if (Seat3.Tag.Equals("SeatEmpty"))
                    {
                        Seat3.IsEnabled = true;
                    }
                    if (Seat4.Tag.Equals("SeatEmpty"))
                    {
                        Seat4.IsEnabled = true;
                    }
                    if (Seat5.Tag.Equals("SeatEmpty"))
                    {
                        Seat5.IsEnabled = true;
                    }
                    if (Seat6.Tag.Equals("SeatEmpty"))
                    {
                        Seat6.IsEnabled = true;
                    }
                    if (Seat7.Tag.Equals("SeatEmpty"))
                    {
                        Seat7.IsEnabled = true;
                    }
                    if (Seat8.Tag.Equals("SeatEmpty"))
                    {
                        Seat8.IsEnabled = true;
                    }
                    if (Seat9.Tag.Equals("SeatEmpty"))
                    {
                        Seat9.IsEnabled = true;
                    }
                    if (Seat10.Tag.Equals("SeatEmpty"))
                    {
                        Seat10.IsEnabled = true;
                    }
                    if (Seat11.Tag.Equals("SeatEmpty"))
                    {
                        Seat12.IsEnabled = true;
                    }
                    if (Seat13.Tag.Equals("SeatEmpty"))
                    {
                        Seat14.IsEnabled = true;
                    }
                    if (Seat15.Tag.Equals("SeatEmpty"))
                    {
                        Seat15.IsEnabled = true;
                    }
                    if (Seat16.Tag.Equals("SeatEmpty"))
                    {
                        Seat16.IsEnabled = true;
                    }
                    #endregion

                }

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// enables the elements of the form that need to be disabled
        /// </summary>
        private void enableForm()
        {
            try
            {
                cbChoosePassenger.IsEnabled = true;
                gPassengerCommands.IsEnabled = true;
                gbPassengerInformation.IsEnabled = true;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// This method handles the error
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles when a seat is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seat_click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Label MyLabel = (Label)sender;
                //MyLabel.Tag = "SeatSelected";
                SetBackgroundColorGreen(MyLabel);
                SetBackgroundColorGreen(lblPassengersSeatNumber);
          
                lblPassengersSeatNumber.Content = MyLabel.Content;
                clsFlightManager.currentSeatNumDisplayed = MyLabel.Content.ToString();

                //SetBackgroundColorGreen(MyLabel);
                var myKeyFlight1 = clsFlightManager.myPassengerSeatsFlight1.FirstOrDefault(x => x.Value == MyLabel.Content.ToString()).Key;
                if (clsFlightManager.myPassengerSeatsFlight1.ContainsKey(myKeyFlight1))
                {
                    cbChoosePassenger.SelectedItem = myKeyFlight1;
                }
                if (cbChooseFlight.SelectedItem.ToString().Contains("102") && MyLabel.Tag.Equals("SeatEmpty"))
                {
                    clsFlightManager.insertPassengerLinkFlightOne();
                    MyLabel.Tag = "SeatTaken";
                    enableForm();

                }
                else if (cbChooseFlight.SelectedItem.ToString().Contains("412"))
                {
                    clsFlightManager.insertPassengerLinkFlightTwo();
                    enableForm();

                    if (clsFlightManager.myPassengerSeatsFlight2 != null)
                    {
                        var myKeyFlight2 = clsFlightManager.myPassengerSeatsFlight2.FirstOrDefault(x => x.Value == MyLabel.Content.ToString()).Key;
                        if (clsFlightManager.myPassengerSeatsFlight2.ContainsKey(myKeyFlight2))
                        {
                            cbChoosePassenger.SelectedItem = myKeyFlight2;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                     MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            

        }

        /// <summary>
        /// Method to set the background color to red of the tiles when a winning move is made
        /// </summary>
        /// <param name="lblLabel"></param>
        private void SetBackgroundColorRed(Label lblLabel)
        {
            try
            {
                var bc = new BrushConverter();

                lblLabel.Background = (Brush)bc.ConvertFrom("#FFFD0000");

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// Method to set the background color to red of the tiles when a winning move is made
        /// </summary>
        /// <param name="lblLabel"></param>
        private void SetBackgroundColorBlue(Label lblLabel)
        {
            try
            {
                var bc = new BrushConverter();

                lblLabel.Background = (Brush)bc.ConvertFrom("#FF0023FD");

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// Method to set the background color to red of the tiles when a winning move is made
        /// </summary>
        /// <param name="lblLabel"></param>
        private void SetBackgroundColorGreen(Label lblLabel)
        {
            try
            {
                var bc = new BrushConverter();

                lblLabel.Background = (Brush)bc.ConvertFrom("#FF00FD00");

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// Hanldes when a new passenger is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbChoosePassenger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cmdChangeSeat.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;

                if (clsFlightManager.myPassengerSeats.ContainsKey(cbChoosePassenger.SelectedItem.ToString()))
                {
                    lblPassengersSeatNumber.Content = clsFlightManager.myPassengerSeats[cbChoosePassenger.SelectedItem.ToString()];
                    clsFlightManager.currentSeatNumDisplayed = lblPassengersSeatNumber.Content.ToString();

                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                                     MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            
            
        }

        /// <summary>
        /// Handles when a passenger is deleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDeletePassenger_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                                   MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
