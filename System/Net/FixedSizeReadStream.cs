using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	internal class FixedSizeReadStream : WebReadStream
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00009F48 File Offset: 0x00008148
		[Token(Token = "0x17000489")]
		public long ContentLength
		{
			[Token(Token = "0x600158A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x5071920", Offset = "0x5070520", VA = "0x185071920")]
		public FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength)
		{
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x50717D0", Offset = "0x50703D0", VA = "0x1850717D0", Slot = "38")]
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		[FieldOffset(Offset = "0x48")]
		private long position;
	}
}
