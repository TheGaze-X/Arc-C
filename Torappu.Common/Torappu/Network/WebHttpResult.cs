using System;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x02000230 RID: 560
	[Token(Token = "0x2000230")]
	public class WebHttpResult
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x000085F4 File Offset: 0x000067F4
		[Token(Token = "0x17000156")]
		public bool isCanceled
		{
			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0xF3CBA0", Offset = "0xF3B7A0", VA = "0x180F3CBA0")]
		public void Cancel()
		{
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0xF3CBA0", Offset = "0xF3B7A0", VA = "0x180F3CBA0")]
		public void NetworkerOnlyMarkCanceled()
		{
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WebHttpResult()
		{
		}

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isCanceled;

		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		[FieldOffset(Offset = "0x18")]
		public Action<WebHttpResponse> response;

		// Token: 0x04000D0D RID: 3341
		[Token(Token = "0x4000D0D")]
		[FieldOffset(Offset = "0x20")]
		public Func<string, string, bool> beforeRequest;

		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		[FieldOffset(Offset = "0x28")]
		public Action onCanceled;

		// Token: 0x04000D0F RID: 3343
		[Token(Token = "0x4000D0F")]
		[FieldOffset(Offset = "0x30")]
		public bool forceNotSecured;
	}
}
