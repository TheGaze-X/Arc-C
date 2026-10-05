using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public class YoSDKEditor : YoSDKUnity, IYoSDK
	{
		// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x5C1B200", Offset = "0x5C19E00", VA = "0x185C1B200", Slot = "4")]
		public AreaServer GetAreaServer()
		{
			return null;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x5C1BB90", Offset = "0x5C1A790", VA = "0x185C1BB90", Slot = "5")]
		public void Init(PayStore payStore, string pid, string gameServerUrl)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x5C1B620", Offset = "0x5C1A220", VA = "0x185C1B620", Slot = "6")]
		public void Init(PayStore payStore, Server? area, string pid, string gameServerUrl)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x5C1BC00", Offset = "0x5C1A800", VA = "0x185C1BC00", Slot = "7")]
		public void Login()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x5C1D880", Offset = "0x5C1C480", VA = "0x185C1D880", Slot = "8")]
		public void ShowUserCenter(string accountDeleteNotifyUrl, string accountRecoveredNotifyUrl, string extraData)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x5C1D840", Offset = "0x5C1C440", VA = "0x185C1D840", Slot = "9")]
		public void ShowSwitchAccount()
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x5C1D3B0", Offset = "0x5C1BFB0", VA = "0x185C1D3B0", Slot = "10")]
		public void ShowAccountCenter()
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x5C1D3F0", Offset = "0x5C1BFF0", VA = "0x185C1D3F0", Slot = "11")]
		public void ShowAgreement(string[] agreementTypes)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x5C1CB10", Offset = "0x5C1B710", VA = "0x185C1CB10", Slot = "12")]
		public void Pay(string productId, string payNotifyUrl, string extraData)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x5C1BE70", Offset = "0x5C1AA70", VA = "0x185C1BE70", Slot = "13")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, PaymentMode gmoPayMode, GMOPayMethod gmoPayMethod = GMOPayMethod.Instant)
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x5C1C4D0", Offset = "0x5C1B0D0", VA = "0x185C1C4D0", Slot = "14")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, int paymentTermDay, int paymentExpiryDateTime)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x5C1D500", Offset = "0x5C1C100", VA = "0x185C1D500", Slot = "15")]
		public void ShowSurvey(string activityID, string gameUID, string notifyUrl, string extraData)
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x5C1D480", Offset = "0x5C1C080", VA = "0x185C1D480", Slot = "16")]
		public void ShowAihelp()
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x5C1D900", Offset = "0x5C1C500", VA = "0x185C1D900", Slot = "17")]
		public void SystemShare(string strShareText, [Optional] Texture2D texShare)
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x5C1D2B0", Offset = "0x5C1BEB0", VA = "0x185C1D2B0", Slot = "18")]
		public void RequestStoreReview()
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x5C1D9B0", Offset = "0x5C1C5B0", VA = "0x185C1D9B0", Slot = "19")]
		public void UserEventUpload(string strEventName, [Optional] Dictionary<string, string> strCallbackParameter)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x5C1CE70", Offset = "0x5C1BA70", VA = "0x185C1CE70", Slot = "20")]
		public string QueryErrorMsg(int code)
		{
			return null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x5C1CF50", Offset = "0x5C1BB50", VA = "0x185C1CF50", Slot = "21")]
		public void QuerySkuDetails(string[] skus)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x5C1B5B0", Offset = "0x5C1A1B0", VA = "0x185C1B5B0", Slot = "22")]
		public string GetSdkVer()
		{
			return null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x5C1B5E0", Offset = "0x5C1A1E0", VA = "0x185C1B5E0", Slot = "23")]
		public void GoogleServerToServer(string devToken, string linkID, string eventName, string priceValue, string currencyCode)
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x5C1CEC0", Offset = "0x5C1BAC0", VA = "0x185C1CEC0", Slot = "24")]
		public string QueryRemoteConfig(string configKey)
		{
			return null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x5C1D2F0", Offset = "0x5C1BEF0", VA = "0x185C1D2F0", Slot = "25")]
		public void RoleInfoUpload(string serverId, string roleUid, string roleName, string[] tags, Dictionary<string, string> customField)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x5C1D9F0", Offset = "0x5C1C5F0", VA = "0x185C1D9F0", Slot = "30")]
		public void _CrashTest()
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x5C1D370", Offset = "0x5C1BF70", VA = "0x185C1D370", Slot = "26")]
		public void Share(ShareContent shareContent)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x5C1D8C0", Offset = "0x5C1C4C0", VA = "0x185C1D8C0", Slot = "27")]
		public void ShowWebView(OpenType openType, string title, string webUrl, string pid)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x5C1D4C0", Offset = "0x5C1C0C0", VA = "0x185C1D4C0", Slot = "28")]
		public void ShowNetworkTest(string gameServerUrl)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x5C1D1B0", Offset = "0x5C1BDB0", VA = "0x185C1D1B0", Slot = "29")]
		public void QueryTextLegality(string sourceText)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
		public void OnPause()
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "32")]
		public void OnResume()
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "33")]
		public void SetDefaultCursor(Texture2D cursorTexture, Vector2 hotspot, CursorMode cursorMode)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x5C1B120", Offset = "0x5C19D20", VA = "0x185C1B120", Slot = "34")]
		public void FetchDeviceTrackingID()
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x5C1B0A0", Offset = "0x5C19CA0", VA = "0x185C1B0A0", Slot = "35")]
		public bool CheckUserCacheExist()
		{
			return default(bool);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x5C1B060", Offset = "0x5C19C60", VA = "0x185C1B060", Slot = "36")]
		public void BuildLocalNotification(int identifier, string title, string content, long timestamp)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x5C1B0E0", Offset = "0x5C19CE0", VA = "0x185C1B0E0", Slot = "37")]
		public void DeleteLocalNotification(int[] identifierList)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x5C1D330", Offset = "0x5C1BF30", VA = "0x185C1D330", Slot = "38")]
		public void SetBirthday()
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public YoSDKEditor()
		{
		}
	}
}
