using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	public class AsyncCompletedEventArgs : EventArgs
	{
		// Token: 0x06000D50 RID: 3408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x51567C0", Offset = "0x51553C0", VA = "0x1851567C0")]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AsyncCompletedEventArgs()
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x5156720", Offset = "0x5155320", VA = "0x185156720")]
		public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState)
		{
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x170002BB")]
		[SRDescription("True if operation was cancelled.")]
		public bool Cancelled
		{
			[Token(Token = "0x6000D52")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BC")]
		[SRDescription("Exception that occurred during operation.  Null if no error.")]
		public Exception Error
		{
			[Token(Token = "0x6000D53")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		[SRDescription("User-supplied state to identify operation.")]
		public object UserState
		{
			[Token(Token = "0x6000D54")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x5156620", Offset = "0x5155220", VA = "0x185156620")]
		protected void RaiseExceptionIfNecessary()
		{
		}

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x10")]
		private readonly Exception error;

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool cancelled;

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x20")]
		private readonly object userState;
	}
}
