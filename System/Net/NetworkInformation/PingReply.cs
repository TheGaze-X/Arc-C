using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200036D RID: 877
	[Token(Token = "0x200036D")]
	public class PingReply
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001851")]
		[Address(RVA = "0x50A1DD0", Offset = "0x50A09D0", VA = "0x1850A1DD0")]
		internal PingReply(IPAddress address, byte[] buffer, PingOptions options, long roundtripTime, IPStatus status)
		{
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x1700055B")]
		public long RoundtripTime
		{
			[Token(Token = "0x6001852")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x10")]
		private IPAddress address;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x18")]
		private PingOptions options;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x20")]
		private IPStatus ipStatus;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x28")]
		private long rtt;

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x30")]
		private byte[] buffer;
	}
}
