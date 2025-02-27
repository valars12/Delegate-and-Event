﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCalculator
{
    public partial class FormEntryData : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Calculator cal);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler onCreate;

        // deklarasi variabel untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi variabel/objek cal untuk meyimpan data calculator
        private Calculator cal; 

        public FormEntryData()
        {
            InitializeComponent();
        }

        private void FormEntryData_Load(object sender, EventArgs e)
        {

        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (isNewData) cal = new Calculator();
            
            if(operasi.Text == "Penjumlahan")
            {
                cal.Hasil = "Hasil Penjumlahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) + int.Parse(txtNilaiB.Text));
            }
            else if (operasi.Text == "Pengurangan")
            {
                cal.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) - int.Parse(txtNilaiB.Text));
            }
            else if (operasi.Text == "Perkalian")
            {
                cal.Hasil = "Hasil Perkalian " + txtNilaiA.Text + " x " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) * int.Parse(txtNilaiB.Text));
            }
            else if (operasi.Text == "Pembagian")
            {
                cal.Hasil = "Hasil Pembagian " + txtNilaiA.Text + " : " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) / int.Parse(txtNilaiB.Text));
            }

            if (isNewData) 
            {
                onCreate(cal); 
            }
            
        }

       
    }
}
