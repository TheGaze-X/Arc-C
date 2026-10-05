using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YoStar.SDK;

namespace YostarSDKV2
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public sealed class YostarPcSdkFacade : IYostarPcSdkFacade
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x51A990", Offset = "0x519590", VA = "0x18051A990", Slot = "4")]
		public void PrepareInitData()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x51A530", Offset = "0x519130", VA = "0x18051A530", Slot = "5")]
		public void Init(YostarPcSdkInitRequest request)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x51A6F0", Offset = "0x5192F0", VA = "0x18051A6F0", Slot = "6")]
		public void Login()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x51A7E0", Offset = "0x5193E0", VA = "0x18051A7E0", Slot = "7")]
		public void Pay(YostarPcSdkPayRequest request)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x51ADD0", Offset = "0x5199D0", VA = "0x18051ADD0", Slot = "8")]
		public void ShowAgreement()
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x51A470", Offset = "0x519070", VA = "0x18051A470", Slot = "9")]
		public bool CheckUserCacheExist()
		{
			return default(bool);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x51AF70", Offset = "0x519B70", VA = "0x18051AF70", Slot = "10")]
		public void ShowUserCenter()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x51AF20", Offset = "0x519B20", VA = "0x18051AF20", Slot = "11")]
		public void ShowSwitchAccount()
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x51AED0", Offset = "0x519AD0", VA = "0x18051AED0", Slot = "12")]
		public void ShowAihelp()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x51A740", Offset = "0x519340", VA = "0x18051A740", Slot = "13")]
		public void OnPause()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x51A790", Offset = "0x519390", VA = "0x18051A790", Slot = "14")]
		public void OnResume()
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x51B080", Offset = "0x519C80", VA = "0x18051B080", Slot = "15")]
		public void UserEventUpload(string eventName, Dictionary<string, string> parameters)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x51AAC0", Offset = "0x5196C0", VA = "0x18051AAC0", Slot = "16")]
		public void RoleInfoUpload(YostarPcSdkRoleInfoRequest request)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x51ACA0", Offset = "0x5198A0", VA = "0x18051ACA0", Slot = "17")]
		public void SetDefaultCursor()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x51A4D0", Offset = "0x5190D0", VA = "0x18051A4D0", Slot = "18")]
		public string GetSdkVersion()
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x51B0F0", Offset = "0x519CF0", VA = "0x18051B0F0")]
		private static Server _MapServer(YostarPcArea area)
		{
			return Server.En;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public YostarPcSdkFacade()
		{
		}
	}
}
