using System;

namespace MakingMethodCallsSimpler.ReplaceParameterwithExplicitMethods
{
    public class ReplaceParameterwithExplicitMethodsExample1
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public void SetValue(String name, int value)
        {
            if (name.Equals("height"))
                Height = value;
            if (name.Equals("width"))
                Width = value;
        }
    }
}
