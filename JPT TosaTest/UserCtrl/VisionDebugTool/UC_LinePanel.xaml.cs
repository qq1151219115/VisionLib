﻿using GalaSoft.MvvmLight.Command;
using JPT_TosaTest.Classes;
using JPT_TosaTest.Vision.VisionTool;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JPT_TosaTest.UserCtrl.VisionDebugTool
{
    /// <summary>
    /// UC_LinePanel.xaml 的交互逻辑
    /// </summary>
    public partial class UC_LinePanel : System.Windows.Controls.UserControl
    {
        private LineTool Tool = new LineTool();
        public UC_LinePanel()
        {
            InitializeComponent();
            DataContext = Tool;
        }
        public string LinePara
        {
            get { return Tool.ToString(); }
        }
        private void SliderContrast_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Tool.UpdateLineResultCommand.Execute(null);
        }
        private void TbCaliberNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            Tool.UpdateLineResultCommand.Execute(null);
        }
        private void CbSelectType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tool.UpdateLineResultCommand.Execute(null);
        }
        private void CbPolarity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tool.UpdateLineResultCommand.Execute(null);
        }

        public ObservableCollection<string> ModelList
        {
            get {
                return GetValue(ModelListProperty) as ObservableCollection<string>;
            }
            set
            {
                SetValue(ModelListProperty, value);
            }

        }
        public static readonly DependencyProperty ModelListProperty = DependencyProperty.Register("ModelList", typeof(ObservableCollection<string>), typeof(UC_LinePanel));


    }
}
