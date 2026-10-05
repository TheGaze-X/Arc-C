using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	internal sealed class ObjectProgress
	{
		// Token: 0x060020DB RID: 8411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x4BA8BA0", Offset = "0x4BA77A0", VA = "0x184BA8BA0")]
		internal ObjectProgress()
		{
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x4BA8AA0", Offset = "0x4BA76A0", VA = "0x184BA8AA0")]
		internal void Init()
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x4BA8930", Offset = "0x4BA7530", VA = "0x184BA8930")]
		internal void ArrayCountIncrement(int value)
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x000136C8 File Offset: 0x000118C8
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x4BA8940", Offset = "0x4BA7540", VA = "0x184BA8940")]
		internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation)
		{
			return default(bool);
		}

		// Token: 0x040011CF RID: 4559
		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x0")]
		internal static int opRecordIdCount;

		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x10")]
		internal bool isInitial;

		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0x14")]
		internal int count;

		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x18")]
		internal BinaryTypeEnum expectedType;

		// Token: 0x040011D3 RID: 4563
		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0x20")]
		internal object expectedTypeInformation;

		// Token: 0x040011D4 RID: 4564
		[Token(Token = "0x40011D4")]
		[FieldOffset(Offset = "0x28")]
		internal string name;

		// Token: 0x040011D5 RID: 4565
		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0x30")]
		internal InternalObjectTypeE objectTypeEnum;

		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x34")]
		internal InternalMemberTypeE memberTypeEnum;

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0x38")]
		internal InternalMemberValueE memberValueEnum;

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0x40")]
		internal System.Type dtType;

		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		[FieldOffset(Offset = "0x48")]
		internal int numItems;

		// Token: 0x040011DA RID: 4570
		[Token(Token = "0x40011DA")]
		[FieldOffset(Offset = "0x4C")]
		internal BinaryTypeEnum binaryTypeEnum;

		// Token: 0x040011DB RID: 4571
		[Token(Token = "0x40011DB")]
		[FieldOffset(Offset = "0x50")]
		internal object typeInformation;

		// Token: 0x040011DC RID: 4572
		[Token(Token = "0x40011DC")]
		[FieldOffset(Offset = "0x58")]
		internal int nullCount;

		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x40011DD")]
		[FieldOffset(Offset = "0x5C")]
		internal int memberLength;

		// Token: 0x040011DE RID: 4574
		[Token(Token = "0x40011DE")]
		[FieldOffset(Offset = "0x60")]
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x040011DF RID: 4575
		[Token(Token = "0x40011DF")]
		[FieldOffset(Offset = "0x68")]
		internal object[] typeInformationA;

		// Token: 0x040011E0 RID: 4576
		[Token(Token = "0x40011E0")]
		[FieldOffset(Offset = "0x70")]
		internal string[] memberNames;

		// Token: 0x040011E1 RID: 4577
		[Token(Token = "0x40011E1")]
		[FieldOffset(Offset = "0x78")]
		internal System.Type[] memberTypes;

		// Token: 0x040011E2 RID: 4578
		[Token(Token = "0x40011E2")]
		[FieldOffset(Offset = "0x80")]
		internal ParseRecord pr;
	}
}
