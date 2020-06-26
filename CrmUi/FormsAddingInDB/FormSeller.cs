﻿using System;
using System.Windows.Forms;

using CrmBL.Model;

namespace CrmUi.FormsAddingInDB
{
    public partial class FormSeller : Form
    {
        public Seller Seller { get; set; }

        public FormSeller()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Пожалуйста, введите корректное имя продавца.\n" +
                    "Поле не может быть пустым или состоять только из пробелов.", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Seller = new Seller() { Name = name.Trim() };
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
