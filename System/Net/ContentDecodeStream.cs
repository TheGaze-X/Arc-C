using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000305 RID: 773
	[Token(Token = "0x2000305")]
	internal class ContentDecodeStream : WebReadStream
	{
		// Token: 0x06001539 RID: 5433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x506A300", Offset = "0x5068F00", VA = "0x18506A300")]
		public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, ContentDecodeStream.Mode mode)
		{
			return null;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000479")]
		private Stream OriginalInnerStream
		{
			[Token(Token = "0x600153A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x50696A0", Offset = "0x50682A0", VA = "0x1850696A0")]
		private ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream)
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x506A550", Offset = "0x5069150", VA = "0x18506A550", Slot = "38")]
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x506A400", Offset = "0x5069000", VA = "0x18506A400", Slot = "39")]
		internal override Task FinishReading(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x02000306 RID: 774
		[Token(Token = "0x2000306")]
		internal enum Mode
		{
			// Token: 0x04000BA2 RID: 2978
			[Token(Token = "0x4000BA2")]
			GZip,
			// Token: 0x04000BA3 RID: 2979
			[Token(Token = "0x4000BA3")]
			Deflate
		}
	}
}
