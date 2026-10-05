using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000255 RID: 597
	[Token(Token = "0x2000255")]
	internal class DigestInputBuffer : MemoryStream
	{
		// Token: 0x060014B8 RID: 5304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x5249C10", Offset = "0x5248810", VA = "0x185249C10")]
		internal void UpdateDigest(IDigest d)
		{
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x5249CB0", Offset = "0x52488B0", VA = "0x185249CB0")]
		public DigestInputBuffer()
		{
		}

		// Token: 0x02000256 RID: 598
		[Token(Token = "0x2000256")]
		private class DigStream : BaseOutputStream
		{
			// Token: 0x060014BA RID: 5306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014BA")]
			[Address(RVA = "0x5249BE0", Offset = "0x52487E0", VA = "0x185249BE0")]
			internal DigStream(IDigest d)
			{
			}

			// Token: 0x060014BB RID: 5307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014BB")]
			[Address(RVA = "0x5249B00", Offset = "0x5248700", VA = "0x185249B00", Slot = "37")]
			public override void WriteByte(byte b)
			{
			}

			// Token: 0x060014BC RID: 5308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014BC")]
			[Address(RVA = "0x5249B60", Offset = "0x5248760", VA = "0x185249B60", Slot = "35")]
			public override void Write(byte[] buf, int off, int len)
			{
			}

			// Token: 0x04000AF1 RID: 2801
			[Token(Token = "0x4000AF1")]
			[FieldOffset(Offset = "0x30")]
			private readonly IDigest d;
		}
	}
}
