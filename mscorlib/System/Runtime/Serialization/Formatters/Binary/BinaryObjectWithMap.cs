using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	internal sealed class BinaryObjectWithMap
	{
		// Token: 0x060020B1 RID: 8369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal BinaryObjectWithMap()
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		internal BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x4B96850", Offset = "0x4B95450", VA = "0x184B96850")]
		internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId)
		{
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x4B968B0", Offset = "0x4B954B0", VA = "0x184B968B0", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x4B96710", Offset = "0x4B95310", VA = "0x184B96710", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x40011A8")]
		[FieldOffset(Offset = "0x10")]
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x040011A9 RID: 4521
		[Token(Token = "0x40011A9")]
		[FieldOffset(Offset = "0x14")]
		internal int objectId;

		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x40011AA")]
		[FieldOffset(Offset = "0x18")]
		internal string name;

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		[FieldOffset(Offset = "0x20")]
		internal int numMembers;

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		[FieldOffset(Offset = "0x28")]
		internal string[] memberNames;

		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x40011AD")]
		[FieldOffset(Offset = "0x30")]
		internal int assemId;
	}
}
