using System;

namespace UnityDependencyInjection
{
	[AttributeUsage(AttributeTargets.Field)]
	public class InjectAttribute : Attribute
	{
		public bool CanBeNull { get; private set; }

		public InjectAttribute(bool canBeNull = false)
		{
			CanBeNull = canBeNull;
		}
	}
}