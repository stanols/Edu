namespace Edu.DesignPatterns.Structural.Decorator
{
	public abstract class AngularComponent : Component
	{
		protected Component _component;

		public AngularComponent(Component component)
		{
			this._component = component;
		}

		public void SetComponent(Component component)
		{
			_component = component;
		}

		public override string Operation()
		{
			return _component != null
				? _component.Operation()
				: string.Empty;
		}
	}
}
