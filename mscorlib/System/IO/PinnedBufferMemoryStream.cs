using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000652 RID: 1618
	[Token(Token = "0x2000652")]
	internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
	{
		// Token: 0x0600308C RID: 12428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308C")]
		[Address(RVA = "0x4C81030", Offset = "0x4C7FC30", VA = "0x184C81030")]
		internal PinnedBufferMemoryStream(byte[] array)
		{
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x0001A538 File Offset: 0x00018738
		[Token(Token = "0x600308D")]
		[Address(RVA = "0x4C80FF0", Offset = "0x4C7FBF0", VA = "0x184C80FF0", Slot = "33")]
		public override int Read(System.Span<byte> buffer)
		{
			return 0;
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308E")]
		[Address(RVA = "0x4C81010", Offset = "0x4C7FC10", VA = "0x184C81010", Slot = "36")]
		public override void Write(System.ReadOnlySpan<byte> buffer)
		{
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308F")]
		[Address(RVA = "0x4C80F70", Offset = "0x4C7FB70", VA = "0x184C80F70", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003090")]
		[Address(RVA = "0x4C80F30", Offset = "0x4C7FB30", VA = "0x184C80F30", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04001ACB RID: 6859
		[Token(Token = "0x4001ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private byte[] _array;

		// Token: 0x04001ACC RID: 6860
		[Token(Token = "0x4001ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private System.Runtime.InteropServices.GCHandle _pinningHandle;
	}
}
