using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	internal sealed class FileWebStream : FileStream, ICloseEx
	{
		// Token: 0x060014E4 RID: 5348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x5057470", Offset = "0x5056070", VA = "0x185057470")]
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing)
		{
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x5057510", Offset = "0x5056110", VA = "0x185057510")]
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async)
		{
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x50571D0", Offset = "0x5055DD0", VA = "0x1850571D0", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x5057360", Offset = "0x5055F60", VA = "0x185057360", Slot = "40")]
		private void CloseEx(CloseExState closeState)
		{
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00009D08 File Offset: 0x00007F08
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x50572D0", Offset = "0x5055ED0", VA = "0x1850572D0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int size)
		{
			return 0;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x50573E0", Offset = "0x5055FE0", VA = "0x1850573E0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x5056FD0", Offset = "0x5055BD0", VA = "0x185056FD0", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00009D20 File Offset: 0x00007F20
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x5057250", Offset = "0x5055E50", VA = "0x185057250", Slot = "23")]
		public override int EndRead(IAsyncResult ar)
		{
			return 0;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x5057080", Offset = "0x5055C80", VA = "0x185057080", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x5057290", Offset = "0x5055E90", VA = "0x185057290", Slot = "27")]
		public override void EndWrite(IAsyncResult ar)
		{
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x5057130", Offset = "0x5055D30", VA = "0x185057130")]
		private void CheckError()
		{
		}

		// Token: 0x04000B72 RID: 2930
		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0x70")]
		private FileWebRequest m_request;
	}
}
