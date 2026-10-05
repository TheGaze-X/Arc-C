using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public class YoSDKStandalone : YoSDKUnity, IYoSDK
	{
		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x5C1DDB0", Offset = "0x5C1C9B0", VA = "0x185C1DDB0", Slot = "4")]
		public AreaServer GetAreaServer()
		{
			return null;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x5C1E4E0", Offset = "0x5C1D0E0", VA = "0x185C1E4E0", Slot = "22")]
		public string GetSdkVer()
		{
			return null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x5C1E560", Offset = "0x5C1D160", VA = "0x185C1E560", Slot = "23")]
		public void GoogleServerToServer(string devToken, string linkID, string eventName, string priceValue, string currencyCode)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x5C1E360", Offset = "0x5C1CF60", VA = "0x185C1E360")]
		private PCSDK GetInstance(PayStore payStore)
		{
			return null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x5C1E5A0", Offset = "0x5C1D1A0", VA = "0x185C1E5A0", Slot = "5")]
		public void Init(PayStore payStore, string pid, string gameServerUrl)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x5C1E8A0", Offset = "0x5C1D4A0", VA = "0x185C1E8A0", Slot = "6")]
		public void Init(PayStore payStore, Server? area, string pid, string gameServerUrl)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x5C1ECE0", Offset = "0x5C1D8E0", VA = "0x185C1ECE0", Slot = "7")]
		public void Login()
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x5C1F540", Offset = "0x5C1E140", VA = "0x185C1F540", Slot = "12")]
		public void Pay(string productId, string payNotifyUrl, string strExtraData)
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x5C1EE50", Offset = "0x5C1DA50", VA = "0x185C1EE50", Slot = "13")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, PaymentMode gmoPayMode, GMOPayMethod gmoPayMethod = GMOPayMethod.Instant)
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x5C1EE10", Offset = "0x5C1DA10", VA = "0x185C1EE10", Slot = "14")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, int paymentTermDay, int paymentExpiryDateTime)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x5C1F7E0", Offset = "0x5C1E3E0", VA = "0x185C1F7E0", Slot = "20")]
		public string QueryErrorMsg(int code)
		{
			return null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x5C1F910", Offset = "0x5C1E510", VA = "0x185C1F910", Slot = "24")]
		public string QueryRemoteConfig(string configKey)
		{
			return null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x5C1F980", Offset = "0x5C1E580", VA = "0x185C1F980", Slot = "21")]
		public void QuerySkuDetails(string[] skus)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x5C1FA60", Offset = "0x5C1E660", VA = "0x185C1FA60", Slot = "29")]
		public void QueryTextLegality(string sourceText)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x5C1FB10", Offset = "0x5C1E710", VA = "0x185C1FB10", Slot = "18")]
		public void RequestStoreReview()
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x5C1FB50", Offset = "0x5C1E750", VA = "0x185C1FB50", Slot = "25")]
		public void RoleInfoUpload(string serverId, string roleUid, string roleName, string[] tags, Dictionary<string, string> customField)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x5C202C0", Offset = "0x5C1EEC0", VA = "0x185C202C0", Slot = "26")]
		public void Share(ShareContent shareContent)
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x5C203E0", Offset = "0x5C1EFE0", VA = "0x185C203E0", Slot = "10")]
		public void ShowAccountCenter()
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x5C20490", Offset = "0x5C1F090", VA = "0x185C20490", Slot = "11")]
		public void ShowAgreement(string[] agreementTypes)
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x5C20610", Offset = "0x5C1F210", VA = "0x185C20610", Slot = "16")]
		public void ShowAihelp()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x5C20710", Offset = "0x5C1F310", VA = "0x185C20710", Slot = "28")]
		public void ShowNetworkTest(string gameServerUrl)
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x5C20840", Offset = "0x5C1F440", VA = "0x185C20840", Slot = "15")]
		public void ShowSurvey(string activityID, string gameUID, string notifyUrl, string extraData)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x5C20BE0", Offset = "0x5C1F7E0", VA = "0x185C20BE0", Slot = "9")]
		public void ShowSwitchAccount()
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x5C20C90", Offset = "0x5C1F890", VA = "0x185C20C90", Slot = "8")]
		public void ShowUserCenter(string accountDeleteNotifyUrl, string accountRecoveredNotifyUrl, string extraData)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x5C21070", Offset = "0x5C1FC70", VA = "0x185C21070", Slot = "27")]
		public void ShowWebView(OpenType openType, string title, string webUrl, string pid)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x5C214B0", Offset = "0x5C200B0", VA = "0x185C214B0", Slot = "17")]
		public void SystemShare(string strShareText, [Optional] Texture2D texShare)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x5C214F0", Offset = "0x5C200F0", VA = "0x185C214F0", Slot = "19")]
		public void UserEventUpload(string strEventName, [Optional] Dictionary<string, string> parameter)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x5C21640", Offset = "0x5C20240", VA = "0x185C21640", Slot = "30")]
		public void _CrashTest()
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x5C1ED70", Offset = "0x5C1D970", VA = "0x185C1ED70", Slot = "31")]
		public void OnPause()
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x5C1EDC0", Offset = "0x5C1D9C0", VA = "0x185C1EDC0", Slot = "32")]
		public void OnResume()
		{
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x5C200E0", Offset = "0x5C1ECE0", VA = "0x185C200E0", Slot = "33")]
		public void SetDefaultCursor(Texture2D cursorTexture, Vector2 hotspot, CursorMode cursorMode)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x5C1DD20", Offset = "0x5C1C920", VA = "0x185C1DD20", Slot = "34")]
		public void FetchDeviceTrackingID()
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x5C1DBA0", Offset = "0x5C1C7A0", VA = "0x185C1DBA0", Slot = "35")]
		public bool CheckUserCacheExist()
		{
			return default(bool);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x5C1DB60", Offset = "0x5C1C760", VA = "0x185C1DB60", Slot = "36")]
		public void BuildLocalNotification(int identifier, string title, string content, long timestamp)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x5C1DCE0", Offset = "0x5C1C8E0", VA = "0x185C1DCE0", Slot = "37")]
		public void DeleteLocalNotification(int[] identifierList)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x5C20010", Offset = "0x5C1EC10", VA = "0x185C20010", Slot = "38")]
		public void SetBirthday()
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public YoSDKStandalone()
		{
		}

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PCSDK instance;
	}
}
