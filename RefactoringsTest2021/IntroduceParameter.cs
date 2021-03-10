namespace RefactoringsTest2021
{
    public class IntroduceParameter
    {
        public void IntroduceParameter1()
        {
            var introduceParameter = new IntroduceParameter();
            // Introduce here
            var selectSomeThing = introduceParameter.SelectSomeThing.SelectSomeThing.SelectSomeThing.SelectSomeThing.SelectSomeThing;

            var v1 = "hello";
            var v2 = IntroduceParameter2(v1);
        }

        static int IntroduceParameter2(string? param) => param!.Length;

        public IntroduceParameter SelectSomeThing;

        #region Helpers

        private void Use()
        {
            IntroduceParameter1();
            IntroduceParameter2(null);
        }

        #endregion
    }
}