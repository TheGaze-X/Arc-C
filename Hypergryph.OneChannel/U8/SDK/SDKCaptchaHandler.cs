using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public abstract class SDKCaptchaHandler
	{
		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		public abstract IEnumerator FetchCaptchaCoroutine(string captchaParams, SDKCaptchaHandler.Result outResult);

		// Token: 0x0600000E RID: 14 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected SDKCaptchaHandler()
		{
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		public enum Status
		{
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			SUC,
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			SYS_BUSY,
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			USER_CANCEL,
			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			NOT_SUPPORT = 50,
			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			INVALID_PARAM,
			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			UNKNOWN = 99
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public class Result
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600000F RID: 15 RVA: 0x00002098 File Offset: 0x00000298
			// (set) Token: 0x06000010 RID: 16 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x17000001")]
			public SDKCaptchaHandler.Status status
			{
				[Token(Token = "0x600000F")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				[CompilerGenerated]
				get
				{
					return SDKCaptchaHandler.Status.SUC;
				}
				[Token(Token = "0x6000010")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000011 RID: 17 RVA: 0x000020B0 File Offset: 0x000002B0
			// (set) Token: 0x06000012 RID: 18 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x17000002")]
			public int errorCode
			{
				[Token(Token = "0x6000011")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000012")]
				[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000013 RID: 19 RVA: 0x000020C6 File Offset: 0x000002C6
			// (set) Token: 0x06000014 RID: 20 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x17000003")]
			public string captcha
			{
				[Token(Token = "0x6000013")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000014")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private Result()
			{
			}

			// Token: 0x06000016 RID: 22 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x4A0D3C0", Offset = "0x4A0BFC0", VA = "0x184A0D3C0")]
			public static SDKCaptchaHandler.Result CreateForOutput()
			{
				return null;
			}

			// Token: 0x06000017 RID: 23 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x4A0D4A0", Offset = "0x4A0C0A0", VA = "0x184A0D4A0")]
			public void MarkSucceed(string captcha)
			{
			}

			// Token: 0x06000018 RID: 24 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x4A0D460", Offset = "0x4A0C060", VA = "0x184A0D460")]
			public void MarkFailed(SDKCaptchaHandler.Status status, int errorCode)
			{
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x4A0D420", Offset = "0x4A0C020", VA = "0x184A0D420")]
			public void MarkFailed(SDKCaptchaHandler.Status status)
			{
			}
		}
	}
}
