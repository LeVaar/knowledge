﻿using System.Windows;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Documents;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;
using FinalProject.Pages;
using DevExpress.Mvvm;
using System.Windows.Input;

namespace FinalProject.ViewModel
{
    public class DiseaseViewModel : BaseVM
    {
        private BaseContext _context;
        public Disease diseases { get; set; }

        /*public DiseaseViewModel(BaseContext context)
        {
            _context = context;
            diseases = new Disease();
        }*/
        
        public ICommand AddClick => new DelegateCommand(() =>
        {
            _context.Diseases.Add(diseases);
            _context.SaveChanges();
        });
    }
}