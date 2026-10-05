using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000428 RID: 1064
	[Token(Token = "0x2000428")]
	internal sealed class SerializationHeaderRecord
	{
		// Token: 0x06002087 RID: 8327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002087")]
		[Address(RVA = "0x161CFD0", Offset = "0x161BBD0", VA = "0x18161CFD0")]
		internal SerializationHeaderRecord()
		{
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002088")]
		[Address(RVA = "0x4BABC30", Offset = "0x4BAA830", VA = "0x184BABC30")]
		internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion)
		{
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002089")]
		[Address(RVA = "0x4BABAD0", Offset = "0x4BAA6D0", VA = "0x184BABAD0", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000136B0 File Offset: 0x000118B0
		[Token(Token = "0x600208A")]
		[Address(RVA = "0x4BAB800", Offset = "0x4BAA400", VA = "0x184BAB800")]
		private static int GetInt32(byte[] buffer, int index)
		{
			return 0;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208B")]
		[Address(RVA = "0x4BAB870", Offset = "0x4BAA470", VA = "0x184BAB870", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x04001185 RID: 4485
		[Token(Token = "0x4001185")]
		[FieldOffset(Offset = "0x10")]
		internal int binaryFormatterMajorVersion;

		// Token: 0x04001186 RID: 4486
		[Token(Token = "0x4001186")]
		[FieldOffset(Offset = "0x14")]
		internal int binaryFormatterMinorVersion;

		// Token: 0x04001187 RID: 4487
		[Token(Token = "0x4001187")]
		[FieldOffset(Offset = "0x18")]
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04001188 RID: 4488
		[Token(Token = "0x4001188")]
		[FieldOffset(Offset = "0x1C")]
		internal int topId;

		// Token: 0x04001189 RID: 4489
		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x20")]
		internal int headerId;

		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x400118A")]
		[FieldOffset(Offset = "0x24")]
		internal int majorVersion;

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x28")]
		internal int minorVersion;
	}
}
