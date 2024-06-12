using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class Client
    {
        private Component component;
        public void MakeAction()
        {
            component = new ConcreteDecoratorA
                        (
                            new ConcreteDecoratorB
                            (
                                new ConcreteComponent()
                            )
                        );
            component.Operation();
        }
    }
    abstract class Component
    {
        abstract public void Operation();
    }
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            throw new NotImplementedException();
        }
    }
    class Decorator : Component
    {
        private Component component;
        public Decorator(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
                component.Operation();
        }
    }
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component)
        : base(component)
        {

        }
        public override void Operation()
        {
            //do something before
            base.Operation();
            //do something after
        }
    }
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component)
        : base(component)
        {

        }
        public override void Operation()
        {
            //do something before
            base.Operation();
            //do something after
        }
    }
}
