using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_etudiant.Utils
{
    internal class Validations
    {
        public static void ValidateTextBox(ErrorProvider errorProvider,TextBox textBox, CancelEventArgs e, string errorMessage, bool isNumeric = false, int? length = null)
        {
            // Vérifier si le champ est vide
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider.SetError(textBox, errorMessage);
                return;
            }

            // Validation spécifique pour les champs numériques
            if (isNumeric)
            {
                if (!long.TryParse(textBox.Text, out _) || (length.HasValue && textBox.Text.Length != length.Value))
                {
                    e.Cancel = true;
                    textBox.Focus();
                    errorProvider.SetError(textBox, $"Le champ doit contenir uniquement des chiffres et être de longueur {length}.");
                    return;
                }
            }

            // Si tout va bien
            e.Cancel = false;
            errorProvider.SetError(textBox, null);
        }
        public static void ValidateComboBox(ErrorProvider errorProvider, ComboBox comboBox, CancelEventArgs e, string errorMessage)
        {
            if (comboBox.SelectedIndex == -1 || string.IsNullOrEmpty(comboBox.Text))
            {
                e.Cancel = true;
                comboBox.Focus();
                errorProvider.SetError(comboBox, errorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(comboBox, null);
            }
        }
        public static void ValidateDateTimePicker(ErrorProvider errorProvider, DateTimePicker dateTimePicker, CancelEventArgs e, string errorMessage)
        {
            if (dateTimePicker.Value > DateTime.Now)
            {
                e.Cancel = true;
                dateTimePicker.Focus();
                errorProvider.SetError(dateTimePicker, errorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dateTimePicker, null);
            }
        }


    }
}
