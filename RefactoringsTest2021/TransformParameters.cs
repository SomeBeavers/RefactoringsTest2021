namespace RefactoringsTest2021
{
    public class TransformParameters
    {
        public TransformClassReturnInner1 TransformParametersManyParameters(Point ctr, float rad, out bool res,
            out bool res1,
            ref TransformClassReturnInner tri, int t1, int t2, int t3, int t4, int t5, int t6,
            int t7, int t8, int t9, int t10,
            int t11, int t12, int t13, int t14, int t15, int t16, int t17, int t18, int t19,
            int t20, int t21, int t22, int t23, int t24, int t25,
            int t26, int t27, int t28, int t29, int t30, params TransformClassReturnInner[] tpri)
        {
            res = false;
            res1 = false;
            return null;
        }

        public void TransformParameters1(Point ctr, float rad, out bool res, ref TransformClassReturn tcr)
        {
            res = true;
        }

        public (int, string) TransformParameters2(Point ctr, float rad, out bool res, out bool res1)
        {
            res = false;
            res1 = false;
            return (0, "null");
        }

        #region Helpers

        public void UseTransformParameters()
        {
            TransformClassReturn tcr = null;
            bool res;
            TransformParameters1(null, 0, out res, ref tcr);
        }

        public void Test7(Point ctr, float rad, out bool res, out bool res1)
        {
            res = false;
            res1 = false;
        }

        public int Test8(float rad, out bool res, out bool res1)
        {
            res = false;
            res1 = false;
            return 0;
        }

        public TransformClassReturn Test9(Point ctr, float rad, out bool res, out bool res1)
        {
            res = false;
            res1 = false;
            return null;
        }

        public void Test10(Point ctr, float rad, out bool res, out bool res1, int t = 0)
        {
            res = false;
            res1 = false;
        }

        public int Test11(Point ctr, float rad, out bool res, out bool res1, int t = 0)
        {
            res = false;
            res1 = false;
            return 0;
        }

        public TransformClassReturnInner Test12(Point ctr, float rad, out bool res, out bool res1, int t = 0)
        {
            res = false;
            res1 = false;
            return null;
        }

        public void Test13(Point ctr, float rad, out bool res, out bool res1, ref TransformClassReturnInner tri, int t = 0)
        {
            res = false;
            res1 = false;
        }

        public int Test14(Point ctr, float rad, out bool res, out bool res1, ref TransformClassReturnInner tri, int t = 0)
        {
            res = false;
            res1 = false;
            return 0;
        }

        public TransformClassReturnInner Test15(Point ctr, float rad, out bool res, out bool res1, ref TransformClassReturnInner tri, int t = 0)
        {
            res = false;
            res1 = false;
            return null;
        }

        public void Test16(Point ctr, float rad, out bool res, out bool res1, ref TransformClassReturnInner tri, params TransformClassReturnInner[] tpri)
        {
            res = false;
            res1 = false;
        }

        public int Test17(Point ctr, float rad, out bool res, out bool res1, ref TransformClassReturnInner tri, params TransformClassReturnInner[] tpri)
        {
            res = false;
            res1 = false;
            return 0;
        }

        public TransformClassReturnInner1 Test19(ref TransformClassReturnInner tcri)
        {
            return null;
        }

        public TransformClassReturnInner1 Test18(Point ctr, float rad, out bool res, out bool res1, ref TransformClassReturnInner tri, params TransformClassReturnInner[] tpri)
        {
            res = false;
            res1 = false;
            return null;
        }

        public class Point
        {
        }

        public class TransformClassReturnInner1
        {
        }

        public class TransformClassReturnInner
        {
        }

        #endregion
    }

    #region Helpers

    public class TransformClassReturn
    {
    }

    #endregion
}