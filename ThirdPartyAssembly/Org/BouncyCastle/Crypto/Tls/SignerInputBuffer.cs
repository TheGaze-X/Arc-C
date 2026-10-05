using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200027A RID: 634
	[Token(Token = "0x200027A")]
	internal class SignerInputBuffer : MemoryStream
	{
		// Token: 0x06001557 RID: 5463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001557")]
		[Address(RVA = "0x52506E0", Offset = "0x524F2E0", VA = "0x1852506E0")]
		internal void UpdateSigner(ISigner s)
		{
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x5249CB0", Offset = "0x52488B0", VA = "0x185249CB0")]
		public SignerInputBuffer()
		{
		}

		// Token: 0x0200027B RID: 635
		[Token(Token = "0x200027B")]
		private class SigStream : BaseOutputStream
		{
			// Token: 0x06001559 RID: 5465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001559")]
			[Address(RVA = "0x5249BE0", Offset = "0x52487E0", VA = "0x185249BE0")]
			internal SigStream(ISigner s)
			{
			}

			// Token: 0x0600155A RID: 5466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600155A")]
			[Address(RVA = "0x5250060", Offset = "0x524EC60", VA = "0x185250060", Slot = "37")]
			public override void WriteByte(byte b)
			{
			}

			// Token: 0x0600155B RID: 5467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600155B")]
			[Address(RVA = "0x52500C0", Offset = "0x524ECC0", VA = "0x1852500C0", Slot = "35")]
			public override void Write(byte[] buf, int off, int len)
			{
			}

			// Token: 0x04000BF2 RID: 3058
			[Token(Token = "0x4000BF2")]
			[FieldOffset(Offset = "0x30")]
			private readonly ISigner s;
		}
	}
}
