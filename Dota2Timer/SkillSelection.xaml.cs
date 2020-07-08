using System;
using System.Reflection;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Dota2Timer
{
    /// <summary>
    /// Логика взаимодействия для HeroSelection.xaml
    /// </summary>
    public partial class SkillSelection : Window
    {
        List<Skill> skillList;

        private string _SkillName;

        public string SkillName
        {
            get { return this._SkillName; }
            set { this._SkillName = value; }
        }
        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri("pack://application:,,,/" + filename));
        }
        public SkillSelection()
        {
            InitializeComponent();
            skillList = new List<Skill>()
            {
                new Skill { Name = "BlackHole", ImageData = LoadImage("Images/BlackHole.png"), SkillCooldown = new int[] { 200, 180, 160 } },
                new Skill { Name = "ReversePolarity", ImageData = LoadImage("Images/ReversePolarity.png"), SkillCooldown = new int[] { 130, 130, 130 } },
                new Skill { Name = "Aegis", ImageData = LoadImage("Images/Aegis.png"), SkillCooldown = new int[] { 300, 300, 300 } }
            };
            lstView.ItemsSource = skillList;
        }

        private void BlackHole_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SkillName = "BlackHole";
            this.DialogResult = true;
        }

        private void ReversePolarity_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SkillName = "ReversePolarity";
            this.DialogResult = true;
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
        }

        private void Aegis_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SkillName = "Aegis";
            this.DialogResult = true;
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null )
            {
                SkillName = item.Content.GetType().GetProperty("Name").GetValue(item.Content) as string;
                this.DialogResult = true;
            }
        }
    }
}