using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimaisPrologApp 
{
    public partial class Form1 : Form
    {       
        private const string SwiPrologExePath = @"D:\Program Files\swipl\bin\swipl.exe"; 

        private const string PrologFilePath = @"C:\Users\Lucca\Desktop\trabFlavia\animais_complexo.pl";

        public Form1()
        {
            InitializeComponent();
            PopulateAnimalComboBox();
            labelResult.Text = "";
            AddToolTips();
        }

        private void PopulateAnimalComboBox()
        {
            comboBoxAnimalName.Items.Clear();

            List<string> animals = new List<string>
            {
                "cachorro", "gato", "leao", "macaco", "pardal", "pato", "galinha",
                "cobra", "peixe", "baleia", "vaca", "coelho"
            };

            animals = animals.OrderBy(a => a).ToList();

            if (animals.Any())
            {
                foreach (string animal in animals)
                {
                    comboBoxAnimalName.Items.Add(animal);
                }
                if (comboBoxAnimalName.Items.Count > 0)
                {
                    comboBoxAnimalName.SelectedIndex = 0;
                }
            }
            else
            {
                comboBoxAnimalName.Items.Add("Erro: Nenhuma opção de animal disponível.");
                comboBoxAnimalName.Enabled = false;
            }
        }

        private string RunPrologQuery(string query)
        {
            string result = "";

            if (!File.Exists(PrologFilePath))
            {
                MessageBox.Show($"Erro: O arquivo Prolog '{PrologFilePath}' não foi encontrado.\nPor favor, verifique o caminho e se o arquivo existe.",
                                 "Erro de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }

            if (!File.Exists(SwiPrologExePath))
            {
                MessageBox.Show($"Erro: O executável do SWI-Prolog não foi encontrado em: '{SwiPrologExePath}'.\nPor favor, verifique o caminho e a instalação do SWI-Prolog.",
                                "Erro de Execução", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }

            string finalQuery = $"({query} -> writeln(prolog_result_true) ; writeln(prolog_result_false)).";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = SwiPrologExePath,

                Arguments = $"-q -s \"{PrologFilePath.Replace("\\", "/")}\" -g \"{finalQuery}\" -g halt",
                RedirectStandardOutput = true, 
                RedirectStandardError = true, 
                UseShellExecute = false,       
                CreateNoWindow = true,        

                WorkingDirectory = Path.GetDirectoryName(SwiPrologExePath)
            };

            try
            {
                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                  
                    StringBuilder errorBuilder = new StringBuilder();
                    process.ErrorDataReceived += (sender, e) => {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            errorBuilder.AppendLine(e.Data);
                        }
                    };
                    process.BeginErrorReadLine();

                    string output = process.StandardOutput.ReadToEnd();

                    if (!process.WaitForExit(5000))
                    {
                        process.Kill();
                        MessageBox.Show("O processo do SWI-Prolog excedeu o tempo limite e foi encerrado forçadamente.", "Erro de Tempo Limite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return result;
                    }

                    string errorOutput = errorBuilder.ToString();

                    if (!string.IsNullOrWhiteSpace(errorOutput))
                    {
                        MessageBox.Show($"Ocorreu um erro no interpretador Prolog:\n{errorOutput}", "Erro de Processo Prolog", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (!string.IsNullOrWhiteSpace(output))
                    {
                        string rawResult = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault()?.Trim().TrimEnd('.');

                        if (rawResult == "prolog_result_true")
                            result = "true";
                        else if (rawResult == "prolog_result_false")
                            result = "false";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado ao tentar executar o SWI-Prolog: {ex.Message}\nVerifique se o caminho para 'swipl.exe' está correto.",
                                "Erro de Execução", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void ProcessAnimalCharacteristic(string predicateName, string questionPhrase)
        {
            labelResult.Text = "Resposta: ";
            if (comboBoxAnimalName.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um animal da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string animalName = comboBoxAnimalName.SelectedItem.ToString().Trim().ToLower();
            string query = $"{predicateName}('{animalName}')";

            string result = RunPrologQuery(query);

            if (result == "true")
            {
                labelResult.Text = $"Sim, {animalName} {questionPhrase}.";
            }
            else if (result == "false")
            {
                labelResult.Text = $"Não, {animalName} não {questionPhrase}.";
            }
            else
            {
                labelResult.Text = $"Não foi possível determinar se {animalName} {questionPhrase}.";
            }
        }

        private void btnIsBird_Click(object sender, EventArgs e)
        {
            ProcessAnimalCharacteristic("passaro", "é um pássaro");
        }

        private void btnIsMammal_Click(object sender, EventArgs e)
        {
            ProcessAnimalCharacteristic("mamifero", "é um mamífero");
        }

        private void btnIsDangerous_Click(object sender, EventArgs e)
        {
            ProcessAnimalCharacteristic("perigoso", "é um animal perigoso");
        }

        private void btnIsDomestic_Click(object sender, EventArgs e)
        {
            ProcessAnimalCharacteristic("animal_domestico", "é um animal doméstico");
        }

        private void AddToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnIsBird, "Verifica se o animal selecionado é um pássaro.");
            toolTip.SetToolTip(btnIsMammal, "Verifica se o animal selecionado é um mamífero.");
            toolTip.SetToolTip(btnIsDangerous, "Verifica se o animal selecionado é perigoso.");
            toolTip.SetToolTip(btnIsDomestic, "Verifica se o animal selecionado é doméstico.");
            toolTip.SetToolTip(comboBoxAnimalName, "Selecione um animal da lista para consultar suas características.");
        }
    }
}