using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002A4 RID: 676
	[Token(Token = "0x20002A4")]
	public class Authorization
	{
		// Token: 0x06001326 RID: 4902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001326")]
		[Address(RVA = "0x5199500", Offset = "0x5198100", VA = "0x185199500")]
		public Authorization(string token)
		{
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001327")]
		[Address(RVA = "0x5199580", Offset = "0x5198180", VA = "0x185199580")]
		public Authorization(string token, bool finished)
		{
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FC")]
		public string Message
		{
			[Token(Token = "0x6001328")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x170003FD")]
		public bool Complete
		{
			[Token(Token = "0x6001329")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040009E7 RID: 2535
		[Token(Token = "0x40009E7")]
		[FieldOffset(Offset = "0x10")]
		private string m_Message;

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0x18")]
		private bool m_Complete;

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0x20")]
		internal string ModuleAuthenticationType;
	}
}
