using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003DB RID: 987
	[Token(Token = "0x20003DB")]
	internal abstract class LimitedInputStream : BaseInputStream
	{
		// Token: 0x06002128 RID: 8488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x5340CC0", Offset = "0x533F8C0", VA = "0x185340CC0")]
		internal LimitedInputStream(Stream inStream, int limit)
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0000F708 File Offset: 0x0000D908
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "38")]
		internal virtual int GetRemaining()
		{
			return 0;
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212A")]
		[Address(RVA = "0x5340B10", Offset = "0x533F710", VA = "0x185340B10", Slot = "39")]
		protected virtual void SetParentEofDetect(bool on)
		{
		}

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x30")]
		protected readonly Stream _in;

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x38")]
		private int _limit;
	}
}
