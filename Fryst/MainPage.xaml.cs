using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Maps.Services;
using Microsoft.Phone.Shell;
using Fryst.Resources;
using Windows.Devices.Geolocation;

namespace Fryst
{
    public static class CoordinateConverter
    {
        public static GeoCoordinate ConvertGeocoordinate(Geocoordinate geocoordinate)
        {
            return new GeoCoordinate
                (
                geocoordinate.Latitude,
                geocoordinate.Longitude,
                geocoordinate.Altitude ?? Double.NaN,
                geocoordinate.Accuracy,
                geocoordinate.AltitudeAccuracy ?? Double.NaN,
                geocoordinate.Speed ?? Double.NaN,
                geocoordinate.Heading ?? Double.NaN
                );
        }
    }

    public partial class MainPage : PhoneApplicationPage
    {
        private RouteQuery MyQuery = null;
        private GeocodeQuery Mygeocodequery = null;
        private List<GeoCoordinate> MyCoordinates = new List<GeoCoordinate>();

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Grid MyGrid = new Grid();
            MyGrid.RowDefinitions.Add(new RowDefinition());
            MyGrid.RowDefinitions.Add(new RowDefinition());
            MyGrid.RowDefinitions.Add(new RowDefinition());
            MyGrid.Background = new SolidColorBrush(Colors.Transparent);

            //Creating a Rectangle
            Rectangle MyRectangle = new Rectangle();
            MyRectangle.Fill = new SolidColorBrush(Colors.Green);
            MyRectangle.Height = 20;
            MyRectangle.Width = 20;
            MyRectangle.SetValue(Grid.RowProperty, 0);
            MyRectangle.SetValue(Grid.ColumnProperty, 0);
            
            //Adding the Rectangle to the Grid
            MyGrid.Children.Add(MyRectangle);

            //Creating a Polygon
            Polygon MyPolygon = new Polygon();
            MyPolygon.Points.Add(new Point(2, 0));
            MyPolygon.Points.Add(new Point(22, 0));
            MyPolygon.Points.Add(new Point(2, 40));
            MyPolygon.Stroke = new SolidColorBrush(Colors.Red);
            MyPolygon.Fill = new SolidColorBrush(Colors.Black);
            MyPolygon.SetValue(Grid.RowProperty, 1);
            MyPolygon.SetValue(Grid.ColumnProperty, 0);

            //Adding the Polygon to the Grid
            MyGrid.Children.Add(MyPolygon);

            var button = new Button() {Content = "Hello World"};
            button.Click += ButtonOnClick;
            MyGrid.Children.Add(button);

            MapOverlay MyOverlay = new MapOverlay();
            MyOverlay.Content = MyGrid;
            MyOverlay.GeoCoordinate = new GeoCoordinate(47.6097, -122.3331);
            MyOverlay.PositionOrigin = new Point(0, 0.5); MapLayer MyLayer = new MapLayer();
            MyLayer.Add(MyOverlay);
            MyMap.Layers.Add(MyLayer);
        }

        private void ButtonOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
        }
    }
}