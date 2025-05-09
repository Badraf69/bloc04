﻿using System.Windows;
using System.Windows.Controls;
using Annuaire.Services;
using Annuaire.ViewModel;

namespace Annuaire.Views
{

    public partial class ListeEmployeePage : Page
    {
        public ListeEmployeePage()
        {
            InitializeComponent();
            //var employeeService = new EmployeeService();
            DataContext = new ListEmployeeViewModel(new EmployeeService());
        }

        private void EmployeesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is ListEmployeeViewModel viewModel && viewModel.SelectedEmployee != null)
            {
                viewModel.NavigateToFicheEmployeeCommand.Execute(null);
            }
        }

        private void BtnRetour_Click(object sender, RoutedEventArgs e)
        {
            Annuaire.NavigationService.Instance.GoBack();
        }
        

    }
}