using System;
using System.Threading;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000681 RID: 1665
	[Token(Token = "0x2000681")]
	internal class FileStreamAsyncResult : System.IAsyncResult
	{
		// Token: 0x060032B8 RID: 12984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B8")]
		[Address(RVA = "0x4C93140", Offset = "0x4C91D40", VA = "0x184C93140")]
		public FileStreamAsyncResult(System.AsyncCallback cb, object state)
		{
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B9")]
		[Address(RVA = "0x4C93010", Offset = "0x4C91C10", VA = "0x184C93010")]
		private static void CBWrapper(System.IAsyncResult ares)
		{
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700081C")]
		public object AsyncState
		{
			[Token(Token = "0x60032BA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x0001B1B0 File Offset: 0x000193B0
		[Token(Token = "0x1700081D")]
		public bool CompletedSynchronously
		{
			[Token(Token = "0x60032BB")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700081E")]
		public System.Threading.WaitHandle AsyncWaitHandle
		{
			[Token(Token = "0x60032BC")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060032BD RID: 12989 RVA: 0x0001B1C8 File Offset: 0x000193C8
		[Token(Token = "0x1700081F")]
		public bool IsCompleted
		{
			[Token(Token = "0x60032BD")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04001BA8 RID: 7080
		[Token(Token = "0x4001BA8")]
		[FieldOffset(Offset = "0x10")]
		private object state;

		// Token: 0x04001BA9 RID: 7081
		[Token(Token = "0x4001BA9")]
		[FieldOffset(Offset = "0x18")]
		private bool completed;

		// Token: 0x04001BAA RID: 7082
		[Token(Token = "0x4001BAA")]
		[FieldOffset(Offset = "0x20")]
		private System.Threading.ManualResetEvent wh;

		// Token: 0x04001BAB RID: 7083
		[Token(Token = "0x4001BAB")]
		[FieldOffset(Offset = "0x28")]
		private System.AsyncCallback cb;

		// Token: 0x04001BAC RID: 7084
		[Token(Token = "0x4001BAC")]
		[FieldOffset(Offset = "0x30")]
		private bool completedSynch;

		// Token: 0x04001BAD RID: 7085
		[Token(Token = "0x4001BAD")]
		[FieldOffset(Offset = "0x34")]
		public int Count;

		// Token: 0x04001BAE RID: 7086
		[Token(Token = "0x4001BAE")]
		[FieldOffset(Offset = "0x38")]
		public int OriginalCount;

		// Token: 0x04001BAF RID: 7087
		[Token(Token = "0x4001BAF")]
		[FieldOffset(Offset = "0x3C")]
		public int BytesRead;

		// Token: 0x04001BB0 RID: 7088
		[Token(Token = "0x4001BB0")]
		[FieldOffset(Offset = "0x40")]
		private System.AsyncCallback realcb;
	}
}
