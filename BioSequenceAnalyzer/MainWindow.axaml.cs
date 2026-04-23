using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BioSequenceAnalyzer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void AnalyzeButton_Click(object source, RoutedEventArgs args)
        {
            string input = InputTextBox.Text?.Trim().ToUpper() ?? "";

            input = Regex.Replace(input, "[^ACGT]", "");

            if (input.Length < 4)
            {
                ResultsTextBox.Text = "Sekwencja jest za krotka! Wprowadz minimum 4 nukleotydy.";
                return;
            }

            Dictionary<string, int> sequenceCounts = new Dictionary<string, int>();

            for (int i = 0; i <= input.Length - 4; i++)
            {
                string subSequence = input.Substring(i, 4);

                if (sequenceCounts.ContainsKey(subSequence))
                {
                    sequenceCounts[subSequence]++;
                }
                else
                {
                    sequenceCounts[subSequence] = 1;
                }
            }

            StringBuilder resultBuilder = new StringBuilder();
            var sortedResults = sequenceCounts.OrderByDescending(x => x.Value);

            resultBuilder.AppendLine($"Calkowita dlugosc oczyszczonej sekwencji: {input.Length}");
            resultBuilder.AppendLine($"Znalezione unikalne 4-nukleotydowe sekwencje: {sequenceCounts.Count}\n");

            foreach (var item in sortedResults)
            {
                resultBuilder.AppendLine($"{item.Key}: {item.Value}");
            }

            ResultsTextBox.Text = resultBuilder.ToString();
        }
    }
}