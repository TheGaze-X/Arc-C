using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000433 RID: 1075
	[Token(Token = "0x2000433")]
	internal sealed class BinaryObjectWithMapTyped
	{
		// Token: 0x060020B7 RID: 8375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal BinaryObjectWithMapTyped()
		{
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x4B963C0", Offset = "0x4B94FC0", VA = "0x184B963C0")]
		internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId)
		{
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x4B96460", Offset = "0x4B95060", VA = "0x184B96460", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0x4B96090", Offset = "0x4B94C90", VA = "0x184B96090", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x40011AE")]
		[FieldOffset(Offset = "0x10")]
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x040011AF RID: 4527
		[Token(Token = "0x40011AF")]
		[FieldOffset(Offset = "0x14")]
		internal int objectId;

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x40011B0")]
		[FieldOffset(Offset = "0x18")]
		internal string name;

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x20")]
		internal int numMembers;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x40011B2")]
		[FieldOffset(Offset = "0x28")]
		internal string[] memberNames;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[FieldOffset(Offset = "0x30")]
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x38")]
		internal object[] typeInformationA;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[FieldOffset(Offset = "0x40")]
		internal int[] memberAssemIds;

		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x40011B6")]
		[FieldOffset(Offset = "0x48")]
		internal int assemId;
	}
}
