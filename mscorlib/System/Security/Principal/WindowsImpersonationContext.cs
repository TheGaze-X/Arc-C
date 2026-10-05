using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Principal
{
	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class WindowsImpersonationContext : System.IDisposable
	{
		// Token: 0x06001C14 RID: 7188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x4B69EC0", Offset = "0x4B68AC0", VA = "0x184B69EC0")]
		internal WindowsImpersonationContext(System.IntPtr token)
		{
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x4B69D00", Offset = "0x4B68900", VA = "0x184B69D00", Slot = "4")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public void Dispose()
		{
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x4B69E00", Offset = "0x4B68A00", VA = "0x184B69E00")]
		public void Undo()
		{
		}

		// Token: 0x06001C17 RID: 7191
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x4B69CF0", Offset = "0x4B688F0", VA = "0x184B69CF0")]
		[MethodImpl(4096)]
		private static extern bool CloseToken(System.IntPtr token);

		// Token: 0x06001C18 RID: 7192
		[Token(Token = "0x6001C18")]
		[Address(RVA = "0x4B69DD0", Offset = "0x4B689D0", VA = "0x184B69DD0")]
		[MethodImpl(4096)]
		private static extern System.IntPtr DuplicateToken(System.IntPtr token);

		// Token: 0x06001C19 RID: 7193
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x4B69DF0", Offset = "0x4B689F0", VA = "0x184B69DF0")]
		[MethodImpl(4096)]
		private static extern bool SetCurrentToken(System.IntPtr token);

		// Token: 0x06001C1A RID: 7194
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x4B69DE0", Offset = "0x4B689E0", VA = "0x184B69DE0")]
		[MethodImpl(4096)]
		private static extern bool RevertToSelf();

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.IntPtr _token;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool undo;
	}
}
