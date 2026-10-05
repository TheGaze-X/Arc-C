using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	internal class BufferedReadStream : WebReadStream
	{
		// Token: 0x0600152D RID: 5421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x50696A0", Offset = "0x50682A0", VA = "0x1850696A0")]
		public BufferedReadStream(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer)
		{
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x50694B0", Offset = "0x50680B0", VA = "0x1850694B0", Slot = "38")]
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00009E70 File Offset: 0x00008070
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x5069600", Offset = "0x5068200", VA = "0x185069600")]
		internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, out int result)
		{
			return default(bool);
		}

		// Token: 0x04000B8E RID: 2958
		[Token(Token = "0x4000B8E")]
		[FieldOffset(Offset = "0x40")]
		private readonly BufferOffsetSize readBuffer;
	}
}
