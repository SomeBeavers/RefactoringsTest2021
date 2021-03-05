using System;

namespace RefactoringsTest2021
{
    public class EncapsulateField
    {
        private string? fieldWithoutProperty;

        public readonly int fieldWithProperty;
        public int FieldWithProperty => fieldWithProperty;

        private string fieldWithSeveralProperties;

        private string FieldWithSeveralProperties1
        {
            get => fieldWithSeveralProperties;
            set => fieldWithSeveralProperties = value;
        }

        private protected string FieldWithSeveralProperties
        {
            get => fieldWithSeveralProperties;
            set => fieldWithSeveralProperties = value;
        }

        public EncapsulateField(string? fieldWithoutProperty, int fieldWithProperty, string fieldWithSeveralProperties)
        {
            // write usages
            this.fieldWithoutProperty = fieldWithoutProperty;
            this.fieldWithProperty = fieldWithProperty;
            this.fieldWithSeveralProperties = fieldWithSeveralProperties;

            // read usages
            Console.WriteLine(this.fieldWithoutProperty);
            Console.WriteLine(this.fieldWithProperty);
            Console.WriteLine(this.fieldWithSeveralProperties);

            // nameof
            var fieldWithoutPropertyName = nameof(this.fieldWithoutProperty);
            const string fieldWithPropertyName = nameof(this.fieldWithProperty);
            string fieldWithSeveralPropertiesName = nameof(this.fieldWithSeveralProperties);
        }
    }
}