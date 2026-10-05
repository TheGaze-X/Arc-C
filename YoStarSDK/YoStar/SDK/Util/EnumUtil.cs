using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	public class EnumUtil
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x17000041")]
		public LoginPlatform AppleHK
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return LoginPlatform.DEVICE;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x17000042")]
		public LoginPlatform AppleJP
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return LoginPlatform.DEVICE;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x17000043")]
		public LoginPlatform RecoveryEmail
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return LoginPlatform.DEVICE;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x5C0AD50", Offset = "0x5C09950", VA = "0x185C0AD50")]
		public EnumUtil()
		{
		}

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x10")]
		private LoginPlatform privateRecoveryEmail;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x14")]
		private LoginPlatform privateAppleHK;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x18")]
		private LoginPlatform privateAppleJP;
	}
}
