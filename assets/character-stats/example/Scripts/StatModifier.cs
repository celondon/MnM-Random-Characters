namespace Kryz.CharacterStats
{
	public enum StatModType
	{
		Flat = 100,
		PercentAdd = 200,
		PercentMult = 300,
		StatDescription = 1000
	}

	public class StatModifier
	{
		public readonly float Value;
		public readonly string Description;
		public readonly StatModType Type;
		public readonly int Order;
		public readonly object Source;

		public StatModifier(float value, string description, StatModType type, int order, object source)
		{
			Value = value;
			Description = description;
			Type = type;
			Order = order;
			Source = source;
		}

		public StatModifier(float value, string description, StatModType type) : this(value, description, type, (int)type, null) { }

		public StatModifier(float value, string description, StatModType type, int order) : this(value, description, type, order, null) { }

		public StatModifier(float value, string description, StatModType type, object source) : this(value, description, type, (int)type, source) { }
	}
	//public class StatDescription
	//{
	//	public readonly string Description;
	//	public readonly StatModType Type;
	//	public readonly int Order;
	//	public readonly object Source;

	//	public StatDescription(string description, StatModType type, int order, object source)
	//	{
	//		Description = description;
	//		Type = type;
	//		Order = order;
	//		Source = source;
	//	}

	//	public StatDescription(string description, StatModType type) : this(description, type, (int)type, null) { }

	//	public StatDescription(string description, StatModType type, int order) : this(description, type, order, null) { }

	//	public StatDescription(string description, StatModType type, object source) : this(description, type, (int)type, source) { }
	//}
}
