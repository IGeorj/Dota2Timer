using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using static Dota2Timer.Win32;

namespace Dota2Timer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        private List<Skill> skills;
        private DispatcherTimer Timer1;
        private DispatcherTimer Timer2;
        private DispatcherTimer Timer3;
        private DispatcherTimer Timer4;
        private DispatcherTimer Timer5;
        private List<Skill> SelectedSkills = new List<Skill>();
        private bool HiddenMode = false;
        private IntPtr _windowHandle;
        private HwndSource _source;

        public StartWindow()
        {
            InitializeComponent();

            skills = new List<Skill>()
            {
                new Skill{ Name = "BlackHole", ImageData = LoadImage("Images/BlackHole.png"), SkillCooldown = new int[] { 200, 180, 160 } },
                new Skill { Name = "ReversePolarity", ImageData = LoadImage("Images/ReversePolarity.png"), SkillCooldown = new int[] { 130, 130, 130 } },
                new Skill { Name = "Aegis", ImageData = LoadImage("Images/Aegis.png"), SkillCooldown = new int[] { 300, 300, 300 } }
            };
            SelectedSkills.Add(skills.FirstOrDefault(s => s.Name == "BlackHole"));
            SelectedSkills.Add(skills.FirstOrDefault(s => s.Name == "BlackHole"));
            SelectedSkills.Add(skills.FirstOrDefault(s => s.Name == "BlackHole"));
            SelectedSkills.Add(skills.FirstOrDefault(s => s.Name == "BlackHole"));
            SelectedSkills.Add(skills.FirstOrDefault(s => s.Name == "BlackHole"));
            Timer1 = new DispatcherTimer();
            Timer2 = new DispatcherTimer();
            Timer3 = new DispatcherTimer();
            Timer4 = new DispatcherTimer();
            Timer5 = new DispatcherTimer();
            Timer1.Tick += TimerTickEvent1;
            Timer2.Tick += TimerTickEvent2;
            Timer3.Tick += TimerTickEvent3;
            Timer4.Tick += TimerTickEvent4;
            Timer5.Tick += TimerTickEvent5;

            ImageHolder1.Source = SelectedSkills[0].ImageData;
            ImageHolder2.Source = SelectedSkills[1].ImageData;
            ImageHolder3.Source = SelectedSkills[2].ImageData;
            ImageHolder4.Source = SelectedSkills[3].ImageData;
            ImageHolder5.Source = SelectedSkills[4].ImageData;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            _windowHandle = new WindowInteropHelper(this).Handle;
            _source = HwndSource.FromHwnd(_windowHandle);
            _source.AddHook(HwndHook);

            RegisterHotKey(_windowHandle, HOTKEY_ID, MOD_ALT, VK_F5); //ALT + F5
        }

        private IntPtr HwndHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            const int WM_HOTKEY = 0x0312;
            switch (msg)
            {
                case WM_HOTKEY:
                    switch (wParam.ToInt32())
                    {
                        case HOTKEY_ID:
                            int vkey = (((int)lParam >> 16) & 0xFFFF);
                            if (vkey == VK_F5)
                            {
                                if (HiddenMode == false)
                                {
                                    MakeTransparent(_windowHandle);
                                    HiddenMode = true;
                                    Application.Current.MainWindow.Height = 150;
                                    Application.Current.MainWindow.Width = 400;
                                    CooldownTimer1.Margin = new Thickness(0, 0, 0, 0);
                                    CooldownTimer2.Margin = new Thickness(0, 0, 0, 0);
                                    CooldownTimer3.Margin = new Thickness(0, 0, 0, 0);
                                    CooldownTimer4.Margin = new Thickness(0, 0, 0, 0);
                                    CooldownTimer5.Margin = new Thickness(0, 0, 0, 0);
                                    ImageHolder1.Height = 40;
                                    ImageHolder2.Height = 40;
                                    ImageHolder3.Height = 40;
                                    ImageHolder4.Height = 40;
                                    ImageHolder5.Height = 40;
                                    ChangeImage1.Visibility = Visibility.Collapsed;
                                    ChangeImage2.Visibility = Visibility.Collapsed;
                                    ChangeImage3.Visibility = Visibility.Collapsed;
                                    ChangeImage4.Visibility = Visibility.Collapsed;
                                    ChangeImage5.Visibility = Visibility.Collapsed;
                                    StartTimer1.Visibility = Visibility.Collapsed;
                                    StartTimer2.Visibility = Visibility.Collapsed;
                                    StartTimer3.Visibility = Visibility.Collapsed;
                                    StartTimer4.Visibility = Visibility.Collapsed;
                                    StartTimer5.Visibility = Visibility.Collapsed;
                                    SkillLvl1.Visibility = Visibility.Collapsed;
                                    SkillLvl2.Visibility = Visibility.Collapsed;
                                    SkillLvl3.Visibility = Visibility.Collapsed;
                                    SkillLvl4.Visibility = Visibility.Collapsed;
                                    SkillLvl5.Visibility = Visibility.Collapsed;
                                    CloseButton.Visibility = Visibility.Collapsed;
                                }
                                else
                                {
                                    MakeNormal(_windowHandle);
                                    HiddenMode = false;
                                    Application.Current.MainWindow.Height = 300;
                                    Application.Current.MainWindow.Width = 500;
                                    CooldownTimer1.Margin = new Thickness(0, 0, 0, 100);
                                    CooldownTimer2.Margin = new Thickness(0, 0, 0, 100);
                                    CooldownTimer3.Margin = new Thickness(0, 0, 0, 100);
                                    CooldownTimer4.Margin = new Thickness(0, 0, 0, 100);
                                    CooldownTimer5.Margin = new Thickness(0, 0, 0, 100);
                                    ImageHolder1.Height = 70;
                                    ImageHolder2.Height = 70;
                                    ImageHolder3.Height = 70;
                                    ImageHolder4.Height = 70;
                                    ImageHolder5.Height = 70;
                                    ChangeImage1.Visibility = Visibility.Visible;
                                    ChangeImage2.Visibility = Visibility.Visible;
                                    ChangeImage3.Visibility = Visibility.Visible;
                                    ChangeImage4.Visibility = Visibility.Visible;
                                    ChangeImage5.Visibility = Visibility.Visible;
                                    StartTimer1.Visibility = Visibility.Visible;
                                    StartTimer2.Visibility = Visibility.Visible;
                                    StartTimer3.Visibility = Visibility.Visible;
                                    StartTimer4.Visibility = Visibility.Visible;
                                    StartTimer5.Visibility = Visibility.Visible;
                                    SkillLvl1.Visibility = Visibility.Visible;
                                    SkillLvl2.Visibility = Visibility.Visible;
                                    SkillLvl3.Visibility = Visibility.Visible;
                                    SkillLvl4.Visibility = Visibility.Visible;
                                    SkillLvl5.Visibility = Visibility.Visible;
                                    CloseButton.Visibility = Visibility.Visible;
                                }
                            }
                            handled = true;
                            break;
                    }
                    break;
            }
            return IntPtr.Zero;
        }

        protected override void OnClosed(EventArgs e)
        {
            _source.RemoveHook(HwndHook);
            UnregisterHotKey(_windowHandle, HOTKEY_ID);
            base.OnClosed(e);
        }



        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            this.DragMove();
        }

        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri("pack://application:,,,/" + filename));
        }

        private void TimerTick(Label labelCDTimer, DispatcherTimer timer)
        {
            if (labelCDTimer.Content.ToString() == "0")
            {
                labelCDTimer.Content = "READY";
                timer.Stop();
            }
            else
            {
                labelCDTimer.Content = int.Parse(labelCDTimer.Content.ToString()) - 1;
            }
        }

        private void TimerTickEvent1(object sender, EventArgs e)
        {
            TimerTick(CooldownTimer1, Timer1);
        }

        private void TimerTickEvent2(object sender, EventArgs e)
        {
            TimerTick(CooldownTimer2, Timer2);
        }

        private void TimerTickEvent3(object sender, EventArgs e)
        {
            TimerTick(CooldownTimer3, Timer3);
        }

        private void TimerTickEvent4(object sender, EventArgs e)
        {
            TimerTick(CooldownTimer4, Timer4);
        }

        private void TimerTickEvent5(object sender, EventArgs e)
        {
            TimerTick(CooldownTimer5, Timer5);
        }

        private void StartTimer(int id, DispatcherTimer timer, Label lableCDTimer, ComboBox comboBoxSkillLvl)
        {
            timer.Stop();
            lableCDTimer.Content = SelectedSkills[id - 1].SkillCooldown[int.Parse(comboBoxSkillLvl.Text) - 1].ToString();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }
        private void ChangeImage(int id, DispatcherTimer timer, Label labelCDTimer, Image image)
        {
            SkillSelection HS = new SkillSelection();

            if (HS.ShowDialog() == true)
            {
                if (timer.IsEnabled)
                {
                    labelCDTimer.Content = "0";
                    timer.Stop();
                }
                SelectedSkills[id - 1] = skills.FirstOrDefault(s => s.Name == HS.SkillName);
                image.Source = SelectedSkills[id - 1].ImageData;
            }
        }
        private void StartTimer1_Click(object sender, RoutedEventArgs e)
        {
            StartTimer(1, Timer1, CooldownTimer1, SkillLvl1);
        }

        private void StartTimer2_Click(object sender, RoutedEventArgs e)
        {
            StartTimer(2, Timer2, CooldownTimer2, SkillLvl2);
        }

        private void StartTimer3_Click(object sender, RoutedEventArgs e)
        {
            StartTimer(3, Timer3, CooldownTimer3, SkillLvl3);
        }

        private void StartTimer4_Click(object sender, RoutedEventArgs e)
        {
            StartTimer(4, Timer4, CooldownTimer4, SkillLvl4);
        }

        private void StartTimer5_Click(object sender, RoutedEventArgs e)
        {
            StartTimer(5, Timer5, CooldownTimer5, SkillLvl5);
        }

        private void ChangeImage1_Click(object sender, RoutedEventArgs e)
        {
            ChangeImage(1, Timer1, CooldownTimer1, ImageHolder1);
        }

        private void ChangeImage2_Click(object sender, RoutedEventArgs e)
        {
            ChangeImage(2, Timer2, CooldownTimer2, ImageHolder2);
        }

        private void ChangeImage3_Click(object sender, RoutedEventArgs e)
        {
            ChangeImage(3, Timer3, CooldownTimer3, ImageHolder3);
        }

        private void ChangeImage4_Click(object sender, RoutedEventArgs e)
        {
            ChangeImage(4, Timer4, CooldownTimer4, ImageHolder4);
        }

        private void ChangeImage5_Click(object sender, RoutedEventArgs e)
        {
            ChangeImage(5, Timer5, CooldownTimer5, ImageHolder5);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}