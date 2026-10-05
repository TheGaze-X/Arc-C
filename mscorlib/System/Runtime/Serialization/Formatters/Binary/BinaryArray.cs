using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000434 RID: 1076
	[Token(Token = "0x2000434")]
	internal sealed class BinaryArray
	{
		// Token: 0x060020BC RID: 8380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal BinaryArray()
		{
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BD")]
		[Address(RVA = "0x4B93B50", Offset = "0x4B92750", VA = "0x184B93B50")]
		internal BinaryArray(BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x4B93600", Offset = "0x4B92200", VA = "0x184B93600")]
		internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId)
		{
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x4B936C0", Offset = "0x4B922C0", VA = "0x184B936C0", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x4B930C0", Offset = "0x4B91CC0", VA = "0x184B930C0", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x040011B7 RID: 4535
		[Token(Token = "0x40011B7")]
		[FieldOffset(Offset = "0x10")]
		internal int objectId;

		// Token: 0x040011B8 RID: 4536
		[Token(Token = "0x40011B8")]
		[FieldOffset(Offset = "0x14")]
		internal int rank;

		// Token: 0x040011B9 RID: 4537
		[Token(Token = "0x40011B9")]
		[FieldOffset(Offset = "0x18")]
		internal int[] lengthA;

		// Token: 0x040011BA RID: 4538
		[Token(Token = "0x40011BA")]
		[FieldOffset(Offset = "0x20")]
		internal int[] lowerBoundA;

		// Token: 0x040011BB RID: 4539
		[Token(Token = "0x40011BB")]
		[FieldOffset(Offset = "0x28")]
		internal BinaryTypeEnum binaryTypeEnum;

		// Token: 0x040011BC RID: 4540
		[Token(Token = "0x40011BC")]
		[FieldOffset(Offset = "0x30")]
		internal object typeInformation;

		// Token: 0x040011BD RID: 4541
		[Token(Token = "0x40011BD")]
		[FieldOffset(Offset = "0x38")]
		internal int assemId;

		// Token: 0x040011BE RID: 4542
		[Token(Token = "0x40011BE")]
		[FieldOffset(Offset = "0x3C")]
		private BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x040011BF RID: 4543
		[Token(Token = "0x40011BF")]
		[FieldOffset(Offset = "0x40")]
		internal BinaryArrayTypeEnum binaryArrayTypeEnum;
	}
}
