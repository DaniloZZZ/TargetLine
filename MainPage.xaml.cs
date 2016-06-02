using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using System;

// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TargetLine
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            InitializeComponent();
            weekDay mon = new weekDay("mon", 0, weekDays);
            weekDay tue = new weekDay("tue", 1, weekDays);
            weekDay wed = new weekDay("wed", 2, weekDays);
            weekDay thu = new weekDay("thu", 3, weekDays);
            weekDay fri = new weekDay("fri", 4, weekDays);
            weekDay sat = new weekDay("sat", 5, weekDays);
        }

        private void Menu_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            OpenMenu.Begin();

        }

        private void Menu_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            CloseMenu.Begin();

        }




        private void button_Click(object sender, RoutedEventArgs e)
        {
            string text = CreateTask.Text;
        

              taskItem task1= new taskItem(text,TaskList);
            //  TaskList.Items.Add(task1);
           // TestPanel.Children.Add(task1);

        }

        public class weekDay : Page
        {
            private string day;
            int num;

            public weekDay(string day, int num , Grid Parent)
            {
                Grid Day = new Grid();
                Parent.Children.Add(Day);
                Grid.SetColumn(Day, num);
                Day.Name = day;
                Day.HorizontalAlignment = HorizontalAlignment.Stretch;
                Day.VerticalAlignment = VerticalAlignment.Stretch;
                Day.Background = new SolidColorBrush(Color.FromArgb(0, 100, 0, 0));
                Day.Tapped += new TappedEventHandler(Dayclick);

                Rectangle connect = new Rectangle();
                connect.Name = "connect";
                connect.HorizontalAlignment = HorizontalAlignment.Stretch;
                connect.VerticalAlignment = VerticalAlignment.Bottom;
                connect.Margin = new Thickness(0, 0, 0, -12);
                connect.Height = 12;
                connect.Fill = new SolidColorBrush(Color.FromArgb(250, 23, 23, 29));
                connect.Visibility = Visibility.Collapsed;
                Day.Children.Add(connect);
                


                StackPanel tasks = new StackPanel();
                tasks.VerticalAlignment =  VerticalAlignment.Top;
                tasks.Margin = new Thickness(5);

                TextBlock name = new TextBlock();
                Day.Children.Add(name);
                name.FontSize = 13;
                name.Foreground= new SolidColorBrush(Color.FromArgb(250, 43, 43, 43));
                name.FontFamily = new FontFamily("Segoe UI Historic");
                name.VerticalAlignment = VerticalAlignment.Bottom;
                name.Margin = new Thickness(5, 0, 0, 2);
                name.Text = day;

                Rectangle Bord = new Rectangle();
                Day.Children.Add(Bord);
                Bord.StrokeDashArray = new DoubleCollection() { 1, 2 };
                Bord.Width = 1;
                Bord.HorizontalAlignment = HorizontalAlignment.Right;
                Bord.Stroke = new SolidColorBrush(Color.FromArgb(250,43,43,43));

            }

            public  void  Dayclick (object sender, TappedRoutedEventArgs e)
            {
                string tday;
                Rectangle connect = new Rectangle();
                 Grid gr = (Grid)sender;
                Grid parent = (Grid)gr.Parent;
                tday = gr.Name;


                for (int j = 0; j < VisualTreeHelper.GetChildrenCount(parent); j++)
                {
                    DependencyObject ofdays = VisualTreeHelper.GetChild(parent, j);
                    Grid check = (Grid)ofdays;

                    for (int i = 0; i < VisualTreeHelper.GetChildrenCount(check); i++)
                    {
                        DependencyObject child = VisualTreeHelper.GetChild(check, i);

                        if (child != null && child is Rectangle)
                        {
                            Rectangle mbcon = (Rectangle)child;
                            if (mbcon.Name.Equals("connect"))
                            {
                                connect = (Rectangle)child;
                            }
                        }
                    }

                    
                    if (check.Name == tday)
                    {
                            connect.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            connect.Visibility = Visibility.Collapsed;
                        }
                    

                }   
            }
        }


        public  class taskItem : Page
        {
             private string text;
           static  SolidColorBrush DarkBlue = new SolidColorBrush(Color.FromArgb(90, 12, 12, 50));
            

            public taskItem(string text, ListView TaskList)
            {
                this.text = text;
                Task(TaskList);
            }

            public   void  Task(ListView TaskList)
            {
                
                Grid TaskDiv = new Grid();
                TaskDiv.Height = 80;
                TaskDiv.HorizontalAlignment =  HorizontalAlignment.Stretch;
                TaskDiv.Margin = new Thickness(0,3,0,3);
                TaskDiv.Background = DarkBlue;
                TaskDiv.BorderBrush = new SolidColorBrush(Colors.White);
                TaskDiv.BorderThickness = new Thickness(1);
                ColumnDefinition txtcol = new ColumnDefinition();
                txtcol.Width = new GridLength(1, GridUnitType.Star);
                ColumnDefinition btcol = new ColumnDefinition();
                btcol.Width = new GridLength(45, GridUnitType.Pixel);
                TaskDiv.ColumnDefinitions.Add(txtcol);
                TaskDiv.ColumnDefinitions.Add(btcol);

                TextBlock TaskText = new TextBlock();
                TaskDiv.Children.Add(TaskText);
                Grid.SetColumn(TaskText, 0);

                Button tskbtn = new Button();
                TaskDiv.Children.Add(tskbtn);
                Grid.SetColumn(tskbtn, 1);

                tskbtn.Height = 30;
                tskbtn.Width = 45;
                tskbtn.HorizontalAlignment = HorizontalAlignment.Left;
                tskbtn.Content = "Hey";


                TaskText.TextWrapping = TextWrapping.Wrap;
                TaskText.Margin =new Thickness(0,0,4,0);
                TaskText.Foreground = new SolidColorBrush(Colors.White);
                TaskText.FontSize = 17;
                TaskText.Text = text;
                
                
                TaskList.Items.Add(TaskDiv);
            }

        }
    }
}
