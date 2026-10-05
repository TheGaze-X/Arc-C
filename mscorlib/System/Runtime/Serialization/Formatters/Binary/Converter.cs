using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x200043B")]
	internal sealed class Converter
	{
		// Token: 0x060020E0 RID: 8416 RVA: 0x000136E0 File Offset: 0x000118E0
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x4B988C0", Offset = "0x4B974C0", VA = "0x184B988C0")]
		internal static InternalPrimitiveTypeE ToCode(System.Type type)
		{
			return InternalPrimitiveTypeE.Invalid;
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000136F8 File Offset: 0x000118F8
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x4B98780", Offset = "0x4B97380", VA = "0x184B98780")]
		internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code)
		{
			return default(bool);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00013710 File Offset: 0x00011910
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x4B99090", Offset = "0x4B97C90", VA = "0x184B99090")]
		internal static int TypeLength(InternalPrimitiveTypeE code)
		{
			return 0;
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x4B987F0", Offset = "0x4B973F0", VA = "0x184B987F0")]
		internal static System.Type ToArrayType(InternalPrimitiveTypeE code)
		{
			return null;
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x4B97630", Offset = "0x4B96230", VA = "0x184B97630")]
		private static void InitTypeA()
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x4B96E20", Offset = "0x4B95A20", VA = "0x184B96E20")]
		private static void InitArrayTypeA()
		{
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x4B98FC0", Offset = "0x4B97BC0", VA = "0x184B98FC0")]
		internal static System.Type ToType(InternalPrimitiveTypeE code)
		{
			return null;
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x4B96B70", Offset = "0x4B95770", VA = "0x184B96B70")]
		internal static System.Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length)
		{
			return null;
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00013728 File Offset: 0x00011928
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x4B98490", Offset = "0x4B97090", VA = "0x184B98490")]
		internal static bool IsPrimitiveArray(System.Type type, out object typeInformation)
		{
			return default(bool);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x4B97E10", Offset = "0x4B96A10", VA = "0x184B97E10")]
		private static void InitValueA()
		{
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x4B989F0", Offset = "0x4B975F0", VA = "0x184B989F0")]
		internal static string ToComType(InternalPrimitiveTypeE code)
		{
			return null;
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x4B97C60", Offset = "0x4B96860", VA = "0x184B97C60")]
		private static void InitTypeCodeA()
		{
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00013740 File Offset: 0x00011940
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x4B98D50", Offset = "0x4B97950", VA = "0x184B98D50")]
		internal static System.TypeCode ToTypeCode(InternalPrimitiveTypeE code)
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x4B97460", Offset = "0x4B96060", VA = "0x184B97460")]
		private static void InitCodeA()
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00013758 File Offset: 0x00011958
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x4B98AC0", Offset = "0x4B976C0", VA = "0x184B98AC0")]
		internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(System.TypeCode typeCode)
		{
			return InternalPrimitiveTypeE.Invalid;
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x4B96D50", Offset = "0x4B95950", VA = "0x184B96D50")]
		internal static object FromString(string value, InternalPrimitiveTypeE code)
		{
			return null;
		}

		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x40011E3")]
		[FieldOffset(Offset = "0x0")]
		private static int primitiveTypeEnumLength;

		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x8")]
		private static System.Type[] typeA;

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x10")]
		private static System.Type[] arrayTypeA;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x18")]
		private static string[] valueA;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x20")]
		private static System.TypeCode[] typeCodeA;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x28")]
		private static InternalPrimitiveTypeE[] codeA;

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x40011E9")]
		[FieldOffset(Offset = "0x30")]
		internal static System.Type typeofISerializable;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		[FieldOffset(Offset = "0x38")]
		internal static System.Type typeofString;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x40")]
		internal static System.Type typeofConverter;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		[FieldOffset(Offset = "0x48")]
		internal static System.Type typeofBoolean;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0x50")]
		internal static System.Type typeofByte;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x58")]
		internal static System.Type typeofChar;

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x40011EF")]
		[FieldOffset(Offset = "0x60")]
		internal static System.Type typeofDecimal;

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		[FieldOffset(Offset = "0x68")]
		internal static System.Type typeofDouble;

		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x40011F1")]
		[FieldOffset(Offset = "0x70")]
		internal static System.Type typeofInt16;

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		[FieldOffset(Offset = "0x78")]
		internal static System.Type typeofInt32;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x80")]
		internal static System.Type typeofInt64;

		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x40011F4")]
		[FieldOffset(Offset = "0x88")]
		internal static System.Type typeofSByte;

		// Token: 0x040011F5 RID: 4597
		[Token(Token = "0x40011F5")]
		[FieldOffset(Offset = "0x90")]
		internal static System.Type typeofSingle;

		// Token: 0x040011F6 RID: 4598
		[Token(Token = "0x40011F6")]
		[FieldOffset(Offset = "0x98")]
		internal static System.Type typeofTimeSpan;

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		[FieldOffset(Offset = "0xA0")]
		internal static System.Type typeofDateTime;

		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x40011F8")]
		[FieldOffset(Offset = "0xA8")]
		internal static System.Type typeofUInt16;

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0xB0")]
		internal static System.Type typeofUInt32;

		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		[FieldOffset(Offset = "0xB8")]
		internal static System.Type typeofUInt64;

		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x40011FB")]
		[FieldOffset(Offset = "0xC0")]
		internal static System.Type typeofObject;

		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		[FieldOffset(Offset = "0xC8")]
		internal static System.Type typeofSystemVoid;

		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		[FieldOffset(Offset = "0xD0")]
		internal static System.Reflection.Assembly urtAssembly;

		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x40011FE")]
		[FieldOffset(Offset = "0xD8")]
		internal static string urtAssemblyString;

		// Token: 0x040011FF RID: 4607
		[Token(Token = "0x40011FF")]
		[FieldOffset(Offset = "0xE0")]
		internal static System.Type typeofTypeArray;

		// Token: 0x04001200 RID: 4608
		[Token(Token = "0x4001200")]
		[FieldOffset(Offset = "0xE8")]
		internal static System.Type typeofObjectArray;

		// Token: 0x04001201 RID: 4609
		[Token(Token = "0x4001201")]
		[FieldOffset(Offset = "0xF0")]
		internal static System.Type typeofStringArray;

		// Token: 0x04001202 RID: 4610
		[Token(Token = "0x4001202")]
		[FieldOffset(Offset = "0xF8")]
		internal static System.Type typeofBooleanArray;

		// Token: 0x04001203 RID: 4611
		[Token(Token = "0x4001203")]
		[FieldOffset(Offset = "0x100")]
		internal static System.Type typeofByteArray;

		// Token: 0x04001204 RID: 4612
		[Token(Token = "0x4001204")]
		[FieldOffset(Offset = "0x108")]
		internal static System.Type typeofCharArray;

		// Token: 0x04001205 RID: 4613
		[Token(Token = "0x4001205")]
		[FieldOffset(Offset = "0x110")]
		internal static System.Type typeofDecimalArray;

		// Token: 0x04001206 RID: 4614
		[Token(Token = "0x4001206")]
		[FieldOffset(Offset = "0x118")]
		internal static System.Type typeofDoubleArray;

		// Token: 0x04001207 RID: 4615
		[Token(Token = "0x4001207")]
		[FieldOffset(Offset = "0x120")]
		internal static System.Type typeofInt16Array;

		// Token: 0x04001208 RID: 4616
		[Token(Token = "0x4001208")]
		[FieldOffset(Offset = "0x128")]
		internal static System.Type typeofInt32Array;

		// Token: 0x04001209 RID: 4617
		[Token(Token = "0x4001209")]
		[FieldOffset(Offset = "0x130")]
		internal static System.Type typeofInt64Array;

		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x400120A")]
		[FieldOffset(Offset = "0x138")]
		internal static System.Type typeofSByteArray;

		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400120B")]
		[FieldOffset(Offset = "0x140")]
		internal static System.Type typeofSingleArray;

		// Token: 0x0400120C RID: 4620
		[Token(Token = "0x400120C")]
		[FieldOffset(Offset = "0x148")]
		internal static System.Type typeofTimeSpanArray;

		// Token: 0x0400120D RID: 4621
		[Token(Token = "0x400120D")]
		[FieldOffset(Offset = "0x150")]
		internal static System.Type typeofDateTimeArray;

		// Token: 0x0400120E RID: 4622
		[Token(Token = "0x400120E")]
		[FieldOffset(Offset = "0x158")]
		internal static System.Type typeofUInt16Array;

		// Token: 0x0400120F RID: 4623
		[Token(Token = "0x400120F")]
		[FieldOffset(Offset = "0x160")]
		internal static System.Type typeofUInt32Array;

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		[FieldOffset(Offset = "0x168")]
		internal static System.Type typeofUInt64Array;

		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001211")]
		[FieldOffset(Offset = "0x170")]
		internal static System.Type typeofMarshalByRefObject;
	}
}
