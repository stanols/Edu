namespace Edu.DesignPatterns.Structural.Decorator
{
	public class AngularDragAndDropComponent : DragAndDropComponent
	{
		public AngularDragAndDropComponent()
		{
		}

		public override string Operation()
		{
			return $"I am angular drag and drop child component. {base.Operation()}";
		}
	}
}
