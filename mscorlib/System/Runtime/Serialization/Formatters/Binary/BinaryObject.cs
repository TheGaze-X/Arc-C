using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200042B RID: 1067
	[Token(Token = "0x200042B")]
	internal sealed class BinaryObject
	{
		// Token: 0x06002095 RID: 8341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002095")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal BinaryObject()
		{
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002096")]
		[Address(RVA = "0x4B96A80", Offset = "0x4B95680", VA = "0x184B96A80")]
		internal void Set(int objectId, int mapId)
		{
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002097")]
		[Address(RVA = "0x4B96A90", Offset = "0x4B95690", VA = "0x184B96A90", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x4B94DE0", Offset = "0x4B939E0", VA = "0x184B94DE0", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002099")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x10")]
		internal int objectId;

		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x14")]
		internal int mapId;
	}
}
