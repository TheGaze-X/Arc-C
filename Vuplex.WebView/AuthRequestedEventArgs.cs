using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public class AuthRequestedEventArgs : EventArgs
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x5BA35D0", Offset = "0x5BA21D0", VA = "0x185BA35D0")]
		public AuthRequestedEventArgs(string host, bool isProxy, Action<string, string> continueCallback, Action cancelCallback)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x18C6860", Offset = "0x18C5460", VA = "0x1818C6860")]
		public void Cancel()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5BA35A0", Offset = "0x5BA21A0", VA = "0x185BA35A0")]
		public void Continue(string username, string password)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		public readonly string Host;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool IsProxy;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		private Action _cancelCallback;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		private Action<string, string> _continueCallback;
	}
}
