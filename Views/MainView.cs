﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            BtnProviders.Click += delegate { ShowProvidersView?.Invoke(this, EventArgs.Empty); };
            BtnCategorie.Click += delegate { ShowCategorieView?.Invoke(this, EventArgs.Empty); };
            BtnExit.Click += delegate { this.Close(); };

        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowCustomerView;
        public event EventHandler ShowProvidersView;
        public event EventHandler ShowCategorieView;
    }
}
