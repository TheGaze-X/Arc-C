using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public class PersistentFileStorage : IDisposable
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x55001F0", Offset = "0x54FEDF0", VA = "0x1855001F0")]
		private static string _GetFileFolder(string fileName)
		{
			return null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x54FF950", Offset = "0x54FE550", VA = "0x1854FF950")]
		public static PersistentFileStorage QueryStorage(string fileName)
		{
			return null;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000056E4 File Offset: 0x000038E4
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x54FF560", Offset = "0x54FE160", VA = "0x1854FF560")]
		public static bool DeleteStorage(string fileName)
		{
			return default(bool);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x55002C0", Offset = "0x54FEEC0", VA = "0x1855002C0")]
		private PersistentFileStorage(string fileName)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x54FF820", Offset = "0x54FE420", VA = "0x1854FF820")]
		private void _TryDisposeSelf()
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x54FF820", Offset = "0x54FE420", VA = "0x1854FF820", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000056FC File Offset: 0x000038FC
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x54FFB10", Offset = "0x54FE710", VA = "0x1854FFB10")]
		public PersistentFileStorage.OptStatus ReadData(Action<string> dataHandler, bool useRetry = false)
		{
			return PersistentFileStorage.OptStatus.OK;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00005714 File Offset: 0x00003914
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x54FFEB0", Offset = "0x54FEAB0", VA = "0x1854FFEB0")]
		public PersistentFileStorage.OptStatus WriteData(string data, bool useRetry = false)
		{
			return PersistentFileStorage.OptStatus.OK;
		}

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		private const int MAX_RETRY_COUNT = 3;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		private const int BUFFER_SIZE = 4096;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, PersistentFileStorage> s_workingStorages;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isDisposed;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x18")]
		private string m_fileName;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x20")]
		private string m_fileFolder;

		// Token: 0x020000C8 RID: 200
		[Token(Token = "0x20000C8")]
		public enum OptStatus
		{
			// Token: 0x040004C6 RID: 1222
			[Token(Token = "0x40004C6")]
			OK,
			// Token: 0x040004C7 RID: 1223
			[Token(Token = "0x40004C7")]
			IO_EXCEPTION,
			// Token: 0x040004C8 RID: 1224
			[Token(Token = "0x40004C8")]
			IO_EXCEPTION_RETRY_EXCEED,
			// Token: 0x040004C9 RID: 1225
			[Token(Token = "0x40004C9")]
			HANDLER_EXCEPTION,
			// Token: 0x040004CA RID: 1226
			[Token(Token = "0x40004CA")]
			ALREADY_DISPOSED
		}
	}
}
