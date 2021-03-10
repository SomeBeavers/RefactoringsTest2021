using System;

namespace RefactoringsTest2021
{
    public class MakeMethodNonStatic
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public static MakeMethodNonStatic Merge(MakeMethodNonStatic m2)
        {
            return new();
        }
        
        private void Te()
        {
            new ArgumentException(Merge(new MakeMethodNonStatic()).ToString());
        }

        public MakeMethodNonStatic Merge(string name, string id, MakeMethodNonStatic m2, MakeMethodNonStatic m3,
            MakeMethodNonStatic m4, MakeMethodNonStatic m5, MakeMethodNonStatic m6,
            MakeMethodNonStatic m7, MakeMethodNonStatic m8, MakeMethodNonStatic m9, MakeMethodNonStatic m10,
            MakeMethodNonStatic m11, MakeMethodNonStatic m12, MakeMethodNonStatic m13, MakeMethodNonStatic m15,
            MakeMethodNonStatic m16, MakeMethodNonStatic m17, MakeMethodNonStatic m18, MakeMethodNonStatic m19,
            MakeMethodNonStatic m20, MakeMethodNonStatic m21, MakeMethodNonStatic m22, MakeMethodNonStatic m23)
        {
            return new()
            {
                Id = id + m2.Id,
                Name = name + m2.Name
            };
        }

        public static MakeMethodNonStatic Merge(string name, string id, MakeMethodNonStatic m2, MakeMethodNonStatic m3,
            MakeMethodNonStatic m4, MakeMethodNonStatic m5, MakeMethodNonStatic m6,
            MakeMethodNonStatic m7, MakeMethodNonStatic m8, MakeMethodNonStatic m9, MakeMethodNonStatic m10,
            MakeMethodNonStatic m11, MakeMethodNonStatic m12, MakeMethodNonStatic m13,
            MakeMethodNonStatic m14, MakeMethodNonStatic m15, MakeMethodNonStatic m16, MakeMethodNonStatic m17,
            MakeMethodNonStatic m18, MakeMethodNonStatic m19, MakeMethodNonStatic m20, MakeMethodNonStatic m21,
            MakeMethodNonStatic m22, MakeMethodNonStatic m23)
        {
            return new()
            {
                Id = id + m2.Id,
                Name = name + m2.Name
            };
        }

        public static MakeMethodNonStatic Merge(MakeMethodNonStatic m1, MakeMethodNonStatic m2, MakeMethodNonStatic m3,
            MakeMethodNonStatic m4, MakeMethodNonStatic m5, MakeMethodNonStatic m6,
            MakeMethodNonStatic m7, MakeMethodNonStatic m8, MakeMethodNonStatic m9, MakeMethodNonStatic m10,
            MakeMethodNonStatic m11, MakeMethodNonStatic m12, MakeMethodNonStatic m13,
            MakeMethodNonStatic m14, MakeMethodNonStatic m15, MakeMethodNonStatic m16, MakeMethodNonStatic m17,
            MakeMethodNonStatic m18, MakeMethodNonStatic m19, MakeMethodNonStatic m20, MakeMethodNonStatic m21,
            MakeMethodNonStatic m22, MakeMethodNonStatic m23)
        {
            return new()
            {
                Id = m1.Id + m2.Id,
                Name = m1.Name + m2.Name
            };
        }
    }
}