using NTier.Business.Concrete;
using NTier.DataAccess.Concrete.EntityFramework;
using NTier.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NTier.WinAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TaskManager taskManager = new TaskManager(new EfTaskDAL());
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (dataGridView1.SelectedRows.Count == 0)
            {
                taskManager.Add(new Task
                {
                    SubTaskID = 0,
                    TaskName = txtGorev.Text,
                    TaskDescription = txtGorevNotu.Text,
                    Date = DateTime.Now.Date,
                    IsItCompleted = false
                });
            }
            else
            {
                taskManager.Add(new Task
                {
                    SubTaskID = id,
                    TaskName = txtGorev.Text,
                    TaskDescription = txtGorevNotu.Text,
                    Date = DateTime.Now.Date,
                    IsItCompleted = false
                });
            }
            dataGridView1.DataSource = taskManager.GetTaskList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = taskManager.GetTaskList();
            cmbAy.Items.Add("Ay Seçiniz");
            for (int i = 1; i <= 12; i++)
            {
                cmbAy.Items.Add(i);
            }
            cmbYil.Items.Add("Yıl Seçiniz");
            for (int i = Convert.ToInt32(DateTime.Now.Year); i >= 1900; i--)
            {
                cmbYil.Items.Add(i);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void btnTamamlanmisGorevler_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    dataGridView2.DataSource = taskManager.GetTaskListByIsItCompleted(true).Where(x => x.SubTaskID > 0 & x.SubTaskID == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).ToList();
            //}
            dataGridView1.DataSource = taskManager.GetTaskListByIsItCompleted(true);


        }

        private void btnTamamlanmamisGorevler_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    dataGridView2.DataSource = taskManager.GetTaskListByIsItCompleted(false).Where(x => x.SubTaskID > 0 & x.SubTaskID == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).ToList();
            //}
            dataGridView1.DataSource = taskManager.GetTaskListByIsItCompleted(false);


        }

        private void btnTumListeyiGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taskManager.GetTaskList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = taskManager.GetTaskListBySubTaskId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
        }

        private void btnGoreviSil_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                taskManager.Delete(new Task { Id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value), SubTaskID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) });

            }
            else
            {
                taskManager.Delete(new Task { Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) });

            }
            dataGridView1.DataSource = taskManager.GetTaskList();
        }
        private void txtIsimVeyaAciklama_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = taskManager.GetTaskList().Where(x=> x.TaskName.Contains(txtIsimVeyaAciklama.Text) || x.TaskDescription.Contains(txtIsimVeyaAciklama.Text)).ToList();
        }

        private void btnAnaGorevAra_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = taskManager.GetTaskListByMonthAndYear(Convert.ToInt32(cmbAy.Text), Convert.ToInt32(cmbYil.Text));

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Ay ve Yıl Seçiniz");
            }
        }

        private void btnSecilenYilaGoreAra_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = taskManager.GetTaskListByYear(Convert.ToInt32(cmbYil.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen yıl seçiniz");
            }
        }
    }
}
