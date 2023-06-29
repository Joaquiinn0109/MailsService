﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mails.Winform
{
    public partial class MenuForm : Form
    {
        private readonly Uri _baseAddress = new Uri("https://localhost:7004/api");
        private readonly HttpClient _client;
        private readonly string _email;
        public MenuForm(string email)
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
            _email = email;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}