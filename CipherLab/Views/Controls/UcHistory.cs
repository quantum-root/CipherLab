using System;
using System.Windows.Forms;
using CipherLab.Services;

namespace CipherLab.Views.Controls
{
    public partial class UcHistory : UserControl
    {
        public UcHistory()
        {
            InitializeComponent();
            LoadHistoryData();
        }

        private void LoadHistoryData()
        {
            try
            {
                var logs = JsonLogService.LoadLogs();

                dgvHistory.DataSource = null;
                dgvHistory.DataSource = logs;

                if (dgvHistory.Columns.Count > 0)
                {
                    dgvHistory.Columns["Operation"].HeaderText = "Operation Type";
                    dgvHistory.Columns["InputText"].HeaderText = "Input / Cipher Text";
                    dgvHistory.Columns["OutputText"].HeaderText = "Result";
                    dgvHistory.Columns["Timestamp"].HeaderText = "Date & Time";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to clear all history?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    JsonLogService.ClearHistory(); 

                    dgvHistory.DataSource = null; 
                    dgvHistory.Rows.Clear();      

                    MessageBox.Show("History cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}