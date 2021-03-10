namespace RefactoringsTest2021
{
    public class MoveTypeToOuterScope
    {
        class MoveTypeToOuterScope1
        {
            private void Test()
            {
                var MoveTypeToOuterScope2 = new MoveTypeToOuterScope2();
            }
        }

        class MoveTypeToOuterScope2
        {
            private void Test()
            {
                var MoveTypeToOuterScope1 = new MoveTypeToOuterScope1();
            }
        }
    }
}