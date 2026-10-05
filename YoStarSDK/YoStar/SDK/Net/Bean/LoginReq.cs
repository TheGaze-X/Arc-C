using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	public class LoginReq
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00003974 File Offset: 0x00001B74
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000104")]
		public bool GeeTestEnable
		{
			[Token(Token = "0x6000C29")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x4F6210", Offset = "0x4F4E10", VA = "0x1804F6210")]
			set
			{
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0000398C File Offset: 0x00001B8C
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000105")]
		public bool IsNewUser
		{
			[Token(Token = "0x6000C2B")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x000039A4 File Offset: 0x00001BA4
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000106")]
		public YostarLoginFrom LoginFrom
		{
			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return YostarLoginFrom.NotLoginFrom;
			}
			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000107")]
		public string LoginType
		{
			[Token(Token = "0x6000C2F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000039BC File Offset: 0x00001BBC
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000108")]
		public bool CheckAccount
		{
			[Token(Token = "0x6000C31")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C30")]
			[Address(RVA = "0x5C8A1E0", Offset = "0x5C88DE0", VA = "0x185C8A1E0")]
			set
			{
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x000039D4 File Offset: 0x00001BD4
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000109")]
		public LoginPlatform Platform
		{
			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return LoginPlatform.DEVICE;
			}
			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			set
			{
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700010A")]
		public Dictionary<string, object> Body
		{
			[Token(Token = "0x6000C35")]
			[Address(RVA = "0x5C8A040", Offset = "0x5C88C40", VA = "0x185C8A040")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x5C8A160", Offset = "0x5C88D60", VA = "0x185C8A160")]
			set
			{
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700010B")]
		public Dictionary<string, object> Header
		{
			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x5C8A0D0", Offset = "0x5C88CD0", VA = "0x185C8A0D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x5C8A2B0", Offset = "0x5C88EB0", VA = "0x185C8A2B0")]
			set
			{
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x5C89F60", Offset = "0x5C88B60", VA = "0x185C89F60")]
		public LoginReq()
		{
		}

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x10")]
		private bool isNewUser;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x14")]
		private YostarLoginFrom loginFrom;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x18")]
		private string loginType;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x20")]
		private bool checkAccount;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x21")]
		private bool geeTestEnable;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x24")]
		private LoginPlatform platform;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, object> body;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, object> header;
	}
}
