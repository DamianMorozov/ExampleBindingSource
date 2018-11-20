using System;
using System.Collections;
using System.Windows.Forms;

namespace ExampleBindingSource
{
	public partial class Form1 : Form
	{
		private ArrayList _states;

		public Form1()
		{
			InitializeComponent();

			buttonCreateNewDataSource_Click(null, null);
		}

		private ArrayList CreateArrayList()
		{
			return new ArrayList
			{
				new ClassCity("Moscow", "Moscow"),
				new ClassCity("Moscow", "Khimki"),
				new ClassCity("Moscow", "Balashikha"),
				new ClassCity("Moscow", "Lyubertsy"),
				new ClassCity("Moscow", "Dzerzhinsky"),
				new ClassCity("Moscow", "Domodedovo"),
				new ClassCity("Moscow", "Podolsk"),
				new ClassCity("Moscow", "Troitsk"),
				new ClassCity("Moscow", "Puchkovo"),
				new ClassCity("Moscow", "Odintsovo"),
				new ClassCity("Moscow", "Barvikha"),
				new ClassCity("Moscow", "Krasnogorsk"),
				new ClassCity("Moscow", "Otradnoye"),

				new ClassCity("Saint Petersburg", "Saint Petersburg"),
				new ClassCity("Saint Petersburg", "Roshchino"),
				new ClassCity("Saint Petersburg", "Zelenogorsk"),
				new ClassCity("Saint Petersburg", "Repino"),
				new ClassCity("Saint Petersburg", "Sestroretsk"),
				new ClassCity("Saint Petersburg", "Sertolovo"),
				new ClassCity("Saint Petersburg", "Toksovo"),
				new ClassCity("Saint Petersburg", "Vsevolozhsk"),
				new ClassCity("Saint Petersburg", "Kolpino"),
				new ClassCity("Saint Petersburg", "Pushkin"),
				new ClassCity("Saint Petersburg", "Petergof"),
			};
		}

		private void buttonCreateNewDataSource_Click(object sender, EventArgs e)
		{
			comboBoxCity.DataSource = null;
			comboBoxCity.SelectedIndex = -1;
			textBoxRegion.DataBindings.Clear();
			bindingSourceState.Clear();

			bindingSourceState.DataSource = _states = CreateArrayList();

			textBoxRegion.DataBindings.Add(nameof(textBoxRegion.Text), bindingSourceState, nameof(ClassCity.Region));

			comboBoxCity.DataSource = bindingSourceState;
			comboBoxCity.DisplayMember = comboBoxCity.ValueMember = nameof(ClassCity.Name);
		}

		private void buttonRemoveItem_Click(object sender, EventArgs e)
		{
			if (_states?.Count > 0)
			{
				_states.Remove(comboBoxCity.SelectedItem);
				bindingSourceState.ResetBindings(false);
			}
		}
	}
}
