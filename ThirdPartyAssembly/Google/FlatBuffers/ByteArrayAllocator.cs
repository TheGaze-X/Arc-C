using System;
using Il2CppDummyDll;

namespace Google.FlatBuffers
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	public sealed class ByteArrayAllocator : ByteBufferAllocator
	{
		// Token: 0x06000500 RID: 1280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x543F3C0", Offset = "0x543DFC0", VA = "0x18543F3C0")]
		public ByteArrayAllocator(byte[] buffer)
		{
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x543F220", Offset = "0x543DE20", VA = "0x18543F220", Slot = "4")]
		public override void GrowFront(int newSize)
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x543F390", Offset = "0x543DF90", VA = "0x18543F390")]
		private void InitBuffer()
		{
		}

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _buffer;
	}
}
