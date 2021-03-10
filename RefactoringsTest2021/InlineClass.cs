namespace RefactoringsTest2021
{
    public partial class InlineClass
    {
        private class Circle
        {
            /// <summary>
            /// Inline here.
            /// </summary>
            private Painter myPainter1;

            public Circle(Color c)
            {
                MyPainter1 = new Painter(c, null);
            }

            public Painter MyPainter1
            {
                get => myPainter1;
                set => myPainter1 = value;
            }
        }
    }

    public partial class InlineClass
    {
        class Painter
        {
            private Color myColor;

            public Painter(Color c, string s)
            {
                myColor = c;
                InitPainter(myColor);
            }

            private void InitPainter(Color color)
            {
                //init painter
            }
        }
    }

    #region Helpers

    internal class Color
    {
        public string Name;
    }

    #endregion
}