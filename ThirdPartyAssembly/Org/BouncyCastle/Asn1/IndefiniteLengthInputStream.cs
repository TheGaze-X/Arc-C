using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003D7 RID: 983
	[Token(Token = "0x20003D7")]
	internal class IndefiniteLengthInputStream : LimitedInputStream
	{
		// Token: 0x06002112 RID: 8466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002112")]
		[Address(RVA = "0x533EDF0", Offset = "0x533D9F0", VA = "0x18533EDF0")]
		internal IndefiniteLengthInputStream(Stream inStream, int limit)
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002113")]
		[Address(RVA = "0x533EDE0", Offset = "0x533D9E0", VA = "0x18533EDE0")]
		internal void SetEofOn00(bool eofOn00)
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x0000F678 File Offset: 0x0000D878
		[Token(Token = "0x6002114")]
		[Address(RVA = "0x533EB10", Offset = "0x533D710", VA = "0x18533EB10")]
		private bool CheckForEof()
		{
			return default(bool);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x0000F690 File Offset: 0x0000D890
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x533EC10", Offset = "0x533D810", VA = "0x18533EC10", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x533EBC0", Offset = "0x533D7C0", VA = "0x18533EBC0", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x533ED50", Offset = "0x533D950", VA = "0x18533ED50")]
		private int RequireByte()
		{
			return 0;
		}

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x40")]
		private int _lookAhead;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x44")]
		private bool _eofOn00;
	}
}
