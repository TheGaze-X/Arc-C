using System;
using System.IO;
using System.Text;
using System.Threading;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	internal class AsyncStreamReader
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x50C4360", Offset = "0x50C2F60", VA = "0x1850C4360", Slot = "4")]
		public virtual void Close()
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x5104F00", Offset = "0x5103B00", VA = "0x185104F00", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x5104EF0", Offset = "0x5103AF0", VA = "0x185104EF0")]
		internal void CancelOperation()
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x5105210", Offset = "0x5103E10", VA = "0x185105210")]
		internal void WaitUtilEOF()
		{
		}

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x10")]
		private Stream stream;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x18")]
		private Encoding encoding;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x20")]
		private Decoder decoder;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x28")]
		private byte[] byteBuffer;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x30")]
		private char[] charBuffer;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x38")]
		private bool cancelOperation;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x40")]
		private ManualResetEvent eofEvent;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x48")]
		private object syncObject;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x50")]
		private IAsyncResult asyncReadResult;
	}
}
