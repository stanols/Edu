using System;

namespace Edu.DesignPatterns.Structural.Decorator
{
    public static class Decorator
    {
        public static void Execute()
        {
            var angularDragAndDropComponent = new AngularDragAndDropComponent();

            Console.WriteLine(angularDragAndDropComponent.Operation());
        }
    }
}
