using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200032C RID: 812
	[Token(Token = "0x200032C")]
	internal class MonoChunkStream : WebReadStream
	{
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004ED")]
		protected MonoChunkParser Decoder
		{
			[Token(Token = "0x60016A8")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x5087700", Offset = "0x5086300", VA = "0x185087700")]
		public MonoChunkStream(WebOperation operation, Stream innerStream, WebHeaderCollection headers)
		{
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x50873E0", Offset = "0x5085FE0", VA = "0x1850873E0", Slot = "38")]
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x50872D0", Offset = "0x5085ED0", VA = "0x1850872D0", Slot = "39")]
		internal override Task FinishReading(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x5087530", Offset = "0x5086130", VA = "0x185087530")]
		private static void ThrowExpectingChunkTrailer()
		{
		}
	}
}
