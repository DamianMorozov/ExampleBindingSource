namespace ExampleBindingSource
{
	internal class ClassCity
	{
		public string Name { get; private set; }

		public string Region { get; private set; }

		public ClassCity(string region, string name)
		{
			Region = region;
			Name = name;
		}
	}
}
