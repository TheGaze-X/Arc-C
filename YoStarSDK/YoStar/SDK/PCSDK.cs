using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public class PCSDK : YoSDKUnity
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x5C0EE10", Offset = "0x5C0DA10", VA = "0x185C0EE10")]
		public string GetSdkVer()
		{
			return null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void GoogleServerToServer(string devToken, string linkID, string eventName, string priceValue, string currencyCode)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x5C0F8E0", Offset = "0x5C0E4E0", VA = "0x185C0F8E0")]
		private void PreInit(Server? area, string pid, string gameServerUrl)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x5C0EE40", Offset = "0x5C0DA40", VA = "0x185C0EE40")]
		private void GrayTest()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x5C0EF90", Offset = "0x5C0DB90", VA = "0x185C0EF90")]
		public void Init(PayStore payStore, Server? area, string pid, string gameServerUrl)
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x5C0F4A0", Offset = "0x5C0E0A0", VA = "0x185C0F4A0")]
		public void Login()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x5C0F660", Offset = "0x5C0E260", VA = "0x185C0F660")]
		public void Pay(string productId, string payNotifyUrl, string strExtraData)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x5C0F520", Offset = "0x5C0E120", VA = "0x185C0F520")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, PaymentMode payMode, GMOPayMethod gmoPayType)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, int paymentTermDay, int paymentExpiryDateTime)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x5C0FD90", Offset = "0x5C0E990", VA = "0x185C0FD90")]
		public string QueryErrorMsg(int code)
		{
			return null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x5C0FE50", Offset = "0x5C0EA50", VA = "0x185C0FE50")]
		public string QueryRemoteConfig(string configKey)
		{
			return null;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x5C0FE80", Offset = "0x5C0EA80", VA = "0x185C0FE80")]
		public void QuerySkuDetails(string[] skus)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x5C0FEF0", Offset = "0x5C0EAF0", VA = "0x185C0FEF0")]
		public void QueryTextLegality(string sourceText)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void RequestStoreReview()
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x5C0FF60", Offset = "0x5C0EB60", VA = "0x185C0FF60")]
		public void RoleInfoUpload(string serverId, string roleUid, string roleName, string[] tags, Dictionary<string, string> customField)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x5C10090", Offset = "0x5C0EC90", VA = "0x185C10090")]
		public void Share(ShareContent shareContent)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x5C10180", Offset = "0x5C0ED80", VA = "0x185C10180")]
		public void ShowAccountCenter()
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x5C10200", Offset = "0x5C0EE00", VA = "0x185C10200")]
		public void ShowAgreement(string[] agreementTypes)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x5C10310", Offset = "0x5C0EF10", VA = "0x185C10310")]
		public void ShowAihelp()
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x5C103D0", Offset = "0x5C0EFD0", VA = "0x185C103D0")]
		public void ShowNetworkTest(string gameServerUrl)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x5C104A0", Offset = "0x5C0F0A0", VA = "0x185C104A0")]
		public void ShowSurvey(string activityID, string gameUID, string notifyUrl, string extraData)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x5C10530", Offset = "0x5C0F130", VA = "0x185C10530")]
		public void ShowSwitchAccount()
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x5C105B0", Offset = "0x5C0F1B0", VA = "0x185C105B0")]
		public void ShowUserCenter(string accountDeleteNotifyUrl, string accountRecoveredNotifyUrl, string extraData)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x5C10700", Offset = "0x5C0F300", VA = "0x185C10700")]
		public void ShowWebView(OpenType openType, string title, string webUrl, string pid)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void SystemShare(string strShareText, [Optional] Texture2D texShare)
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x5C10800", Offset = "0x5C0F400", VA = "0x185C10800")]
		public void UserEventUpload(string strEventName, [Optional] Dictionary<string, string> parameter)
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void _CrashTest()
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x5C0F500", Offset = "0x5C0E100", VA = "0x185C0F500")]
		public void OnPause()
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x5C0F510", Offset = "0x5C0E110", VA = "0x185C0F510")]
		public void OnResume()
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x5C0EDB0", Offset = "0x5C0D9B0", VA = "0x185C0EDB0")]
		public void FetchDeviceTrackingID()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x5C0ECB0", Offset = "0x5C0D8B0", VA = "0x185C0ECB0")]
		public bool CheckUserCacheExist()
		{
			return default(bool);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x5C0FFF0", Offset = "0x5C0EBF0", VA = "0x185C0FFF0")]
		public void SetBirthday(bool callback = true)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public PCSDK()
		{
		}
	}
}
