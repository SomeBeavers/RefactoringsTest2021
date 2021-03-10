using System;

namespace RefactoringsTest2021
{
    public class ChangeSignature : ChangeSignatureSimpleBase
    {
        #region Fields
        private readonly string _anotherParameter;
        private readonly char[] _charNewNameRenamed1;
        private readonly char[] _charNewNameRenamed1123123;
        private readonly char[] _charNewNameRenamed1A;
        private readonly char[] _charNewNameRenamed1W;
        private readonly string _sssss;
        private readonly int _t;
        private readonly int _t123;
        private readonly int _t2;
        private readonly int _t2123;
        private readonly int _t2A;
        private readonly int _t2W;
        private readonly int _t3;
        private readonly int _t3123;
        private readonly int _t3A;
        private readonly int _t3W;
        private readonly string _t4123123;
        private readonly string _t4A111;
        private readonly string _t4Renamed;
        private readonly string _t4W;
        private readonly int _ta;
        private readonly int _testIntRenamed;
        private readonly int _testIntRenamed123123;
        private readonly int _testIntRenameda;
        private readonly int _testIntRenamedw;
        private readonly int _tw;
        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="testInt_renamed">comment</param>
        /// <param name="charNewNameRenamed1">comment</param>
        /// <param name="t123">comment</param>
        /// <param name="t2123">comment</param>
        /// <param name="t3123">comment</param>
        /// <param name="t4123123"></param>
        /// <param name="testInt_renamed123123">comment</param>
        /// <param name="charNewNameRenamed1123123">comment</param>
        /// <param name="t">comment</param>
        /// <param name="t2">comment</param>
        /// <param name="t3">comment</param>
        /// <param name="t4_renamed">comment</param>
        /// <param name="testInt_renamedw">comment</param>
        /// <param name="charNewNameRenamed1w">comment</param>
        /// <param name="tw">comment</param>
        /// <param name="t2w">comment</param>
        /// <param name="t3w">comment</param>
        /// <param name="t4w">comment</param>
        /// <param name="testInt_renameda">comment</param>
        /// <param name="charNewNameRenamed1a">comment</param>
        /// <param name="ta">comment</param>
        /// <param name="t2a">comment</param>
        /// <param name="t3a">comment</param>
        /// <param name="t4a111">comment</param>
        /// <param name="anotherParameter">comment</param>
        /// <param name="sssss">comment</param>
        public ChangeSignature(int testInt_renamed,
            ref char[] charNewNameRenamed1,
            int t123, int t2123, int t3123, string t4123123,
            int testInt_renamed123123, ref char[] charNewNameRenamed1123123, int t,
            int t2, int t3, string t4_renamed, int testInt_renamedw, ref char[] charNewNameRenamed1w,
            int tw, int t2w, int t3w, string t4w, int testInt_renameda, ref char[] charNewNameRenamed1a,
            int ta, int t2a, int t3a, string t4a111, string anotherParameter, string sssss)
        {
            _testIntRenamed = testInt_renamed;
            _charNewNameRenamed1 = charNewNameRenamed1;
            _t123 = t123;
            _t2123 = t2123;
            _t3123 = t3123;
            _t4123123 = t4123123;
            _testIntRenamed123123 = testInt_renamed123123;
            _charNewNameRenamed1123123 = charNewNameRenamed1123123;
            _t = t;
            _t2 = t2;
            _t3 = t3;
            _t4Renamed = t4_renamed;
            _testIntRenamedw = testInt_renamedw;
            _charNewNameRenamed1W = charNewNameRenamed1w;
            _tw = tw;
            _t2W = t2w;
            _t3W = t3w;
            _t4W = t4w;
            _testIntRenameda = testInt_renameda;
            _charNewNameRenamed1A = charNewNameRenamed1a;
            _ta = ta;
            _t2A = t2a;
            _t3A = t3a;
            _t4A111 = t4a111;
            _anotherParameter = anotherParameter;
            _sssss = sssss;
        }

        /// <summary>
        /// Method.
        /// </summary>
        /// <param name="s">comment</param>
        /// <param name="xxx">comment</param>
        /// <param name="_1_int">comment</param>
        /// <returns>some string</returns>
        public override string ChangeSignature_method(string? s, int xxx, int _1_int = 0)
        {
            Console.WriteLine("overriden");
            return base.ChangeSignature_method(s, xxx, _1_int);
        }

        /// <summary>
        /// Property.
        /// </summary>
        public string ChangeSignatureProperty { get; set; }

        /// <summary>
        /// Use all here.
        /// </summary>
        public void UseChangeSignature(string useInPullTool)
        {
            var a = "".ToCharArray();
            var b = "".ToCharArray();
            var c = "".ToCharArray();
            var d = "".ToCharArray();

            var changeSignature = new ChangeSignature(
                0, ref a, 0, 0, 0, null, 0, ref b, 0, 0, 0, null, 0, ref d, 0,
                0, 0, null, 0, ref c, 0, 0, 0, null, null, null);

            ChangeSignatureProperty = "";

            ChangeSignature_method("test", 10);

            int @int;
            new SpecializedGenericClass().GenericMethod<ChangeSignature_A>(null, null, null, null, out @int);

            new ChangeSignatureGeneric<MyAttribute>().GenericMethod<ChangeSignature_A>(null, null,
                null, null, out @int);

            var s = new ChangeSignature_Indexer<string>()[1];
        }

        private class SpecializedGenericClass : MeasurementConfigurator<MyAttribute>
        {
            public override int GenericMethod<U>(U xc, U b, MyAttribute instance,
                ChangeSignature_A t, out int @int,
                params string[] paramsArray)
            {
                throw new NotImplementedException();
            }
        }

        private class ChangeSignatureGeneric<T> : MeasurementConfigurator<T> where T : MyAttribute
        {
            public override int GenericMethod<U>(U xc, U b, T instance, ChangeSignature_A t, out int @int,
                params string[] paramsArray)
            {
                throw new NotImplementedException();
            }
        }

        public abstract class MeasurementConfigurator<T> : IMeasurementConfigurator<T>
            where T : MyAttribute
        {
            public abstract int GenericMethod<U>(U xc, U b, T instance, ChangeSignature_A t, out int @int,
                params string[] paramsArray);

            private void Tests()
            {
            }
        }

        public interface IMeasurementConfigurator<in T>
        {
            int GenericMethod<U>(U xc, U b, T instance, ChangeSignature_A t, out int @int,
                params string[] paramsArray);
        }
    }

    public class ChangeSignatureSimpleBase
    {
        public virtual string ChangeSignature_method(string? s, int xxx, int _1_int = 0)
        {
            return string.Format("'{0}': {1} times", s, xxx);
        }

        public string Foo()
        {
            throw new Exception();
        }

        public void Test()
        {
            Foo();
            ChangeSignature_method("test", 10);
        }
    }

    class ChangeSignature_Indexer<T>
    {
        private T[] arr = new T[100];

        /// <summary>
        /// Indexer.
        /// </summary>
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    #region Helpers

    public class MyAttribute
    {
    }
    public class ChangeSignature_A
    {
    }


    #endregion
}