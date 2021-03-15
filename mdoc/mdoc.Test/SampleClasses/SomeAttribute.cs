﻿using Mono.Cecil;
using System;

namespace mdoc.Test.SampleClasses
{
    public class SomeAttribute
    {
        [TestDataType(TypeType = null)]
        public void PropertyTypeTypeWithNull()
        {
        }

        [TestDataType(TypeType = typeof(TypeReference))]
        public void PropertyTypeType()
        {
        }

        [TestDataType(BoolType = true)]
        public void PropertyBoolType()
        {
        }

        [TestDataType(SByteType = SByte.MinValue)]
        public void PropertySByteType()
        {
        }

        [TestDataType(ByteType = Byte.MaxValue)]
        public void PropertyByteType()
        {
        }

        [TestDataType(Int16Type = Int16.MinValue)]
        public void PropertyInt16Type()
        {
        }

        [TestDataType(UInt16Type = UInt16.MaxValue)]
        public void PropertyUInt16Type()
        {
        }

        [TestDataType(Int32Type = Int32.MinValue)]
        public void PropertyInt32Type()
        {
        }

        [TestDataType(UInt32Type = UInt32.MaxValue)]
        public void PropertyUInt32Type()
        {
        }

        [TestDataType(Int64Type = Int64.MinValue)]
        public void PropertyInt64Type()
        {
        }

        [TestDataType(UInt64Type = UInt64.MaxValue)]
        public void PropertyUInt64Type()
        {
        }

        [TestDataType(SingleType = Single.MinValue)]
        public void PropertySingleType()
        {
        }

        [TestDataType(DoubleType = Double.MinValue)]
        public void PropertyDoubleType()
        {
        }

        [TestDataType(CharType = 'C')]
        public void PropertyCharType()
        {
        }

        [TestDataType(StringType = "This is a string argument.")]
        public void PropertyStringType()
        {
        }

        [TestDataType(StringType = null)]
        public void PropertyStringTypeWithNull()
        {
        }

        [TestDataType(ArrayOfIntType = new[] { 0, 0, 7 })]
        public void PropertyArrayOfIntType()
        {
        }

        [TestDataType(ArrayOfIntType = null)]
        public void PropertyArrayOfIntTypeWithNull()
        {
        }

        [TestDataType(FlagsEnumType = AttributeTargets.Class | AttributeTargets.Enum)]
        public void PropertyFlagsEnumType()
        {
        }

        [TestDataType(FlagsEnumType = AttributeTargets.All)]
        public void PropertyFlagsEnumTypeWithAll()
        {
        }

        [TestDataType(InternalEnumType = SomeEnum.TestEnumElement2)]
        public void PropertyInternalEnumType()
        {
        }

        [TestDataType(DotNetPlatformEnumType = ConsoleColor.Red)]
        public void PropertyDotNetPlatformEnumType()
        {
        }

        [TestDataType(ObjectType = null)]
        public void PropertyObjectWithNull()
        {
        }

        [TestDataType(ObjectType = typeof(TypeReference))]
        public void PropertyObjectWithTypeType()
        {
        }

        [TestDataType(ObjectType = true)]
        public void PropertyObjectWithBoolType()
        {
        }

        [TestDataType(ObjectType = SByte.MinValue)]
        public void PropertyObjectWithSByteType()
        {
        }

        [TestDataType(ObjectType = Byte.MaxValue)]
        public void PropertyObjectWithByteType()
        {
        }

        [TestDataType(ObjectType = Int16.MinValue)]
        public void PropertyObjectWithInt16Type()
        {
        }

        [TestDataType(ObjectType = UInt16.MaxValue)]
        public void PropertyObjectWithUInt16Type()
        {
        }

        [TestDataType(ObjectType = Int32.MinValue)]
        public void PropertyObjectWithInt32Type()
        {
        }

        [TestDataType(ObjectType = UInt32.MaxValue)]
        public void PropertyObjectWithUInt32Type()
        {
        }

        [TestDataType(ObjectType = Int64.MinValue)]
        public void PropertyObjectWithInt64Type()
        {
        }

        [TestDataType(ObjectType = UInt64.MaxValue)]
        public void PropertyObjectWithUInt64Type()
        {
        }

        [TestDataType(ObjectType = Single.MinValue)]
        public void PropertyObjectWithSingleType()
        {
        }

        [TestDataType(ObjectType = Double.MinValue)]
        public void PropertyObjectWithDoubleType()
        {
        }

        [TestDataType(ObjectType = 'C')]
        public void PropertyObjectWithCharType()
        {
        }

        [TestDataType(ObjectType = "This is a string argument.")]
        public void PropertyObjectWithStringType()
        {
        }

        [TestDataType(ObjectType = new[] { 0, 0, 7 })]
        public void PropertyObjectWithArrayOfIntType()
        {
        }

        [TestDataType(ObjectType = AttributeTargets.Class | AttributeTargets.Enum)]
        public void PropertyObjectWithFlagsEnumType()
        {
        }

        [TestDataType(ObjectType = AttributeTargets.All)]
        public void PropertyObjectWithAllFlagsEnumType()
        {
        }

        [TestDataType(ObjectType = SomeEnum.TestEnumElement2)]
        public void PropertyObjectWithInternalEnumType()
        {
        }

        [TestDataType(ObjectType = ConsoleColor.Red)]
        public void PropertyObjectWithDotNetPlatformEnumType()
        {
        }
    }
}