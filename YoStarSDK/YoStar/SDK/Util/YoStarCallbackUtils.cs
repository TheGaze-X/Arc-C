using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	public class YoStarCallbackUtils
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public static YoStarCallbackUtils Instance
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x5C3C7A0", Offset = "0x5C3B3A0", VA = "0x185C3C7A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x5C3BC10", Offset = "0x5C3A810", VA = "0x185C3BC10")]
		public void HandleInitNotify(InitRet ret)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x5C3BCC0", Offset = "0x5C3A8C0", VA = "0x185C3BCC0")]
		public void HandleLoginNotify(LoginRet ret)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x5C3BFD0", Offset = "0x5C3ABD0", VA = "0x185C3BFD0")]
		public void HandleLogoutNotify(LogoutRet ret)
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x5C3C2C0", Offset = "0x5C3AEC0", VA = "0x185C3C2C0")]
		public void HandleQueryTextLegalityNotify(QueryTextLegalityRet ret)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x5C3C290", Offset = "0x5C3AE90", VA = "0x185C3C290")]
		public void HandleQuerySkuDetailsNotify(SkuDetailRet ret)
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x5C3B9F0", Offset = "0x5C3A5F0", VA = "0x185C3B9F0")]
		public void HandleAccountCenterNotify(string url)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x5C3C420", Offset = "0x5C3B020", VA = "0x185C3C420")]
		public void HandleUserSurveyNotify(SurveyRet ret)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x5C3C390", Offset = "0x5C3AF90", VA = "0x185C3C390")]
		public void HandleUnlinkAndLinkNotifyAsync(int code)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x5C3C2F0", Offset = "0x5C3AEF0", VA = "0x185C3C2F0")]
		public void HandleSetBirthNotify(SetBirthdayRet ret)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x5C3C170", Offset = "0x5C3AD70", VA = "0x185C3C170")]
		public void HandleNotify(object obj)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x5C3B950", Offset = "0x5C3A550", VA = "0x185C3B950")]
		public void AgreementVersion()
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x5C3C450", Offset = "0x5C3B050", VA = "0x185C3C450")]
		private void ShowAgreementView()
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public YoStarCallbackUtils()
		{
		}

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object _lockObject;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x8")]
		private static YoStarCallbackUtils _instance;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x10")]
		public LoginRet loginRet;
	}
}
