using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class YoSDKAndroid : YoSDKUnity, IYoSDK
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		private static AndroidJavaClass UnityAgent
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x5BF8550", Offset = "0x5BF7150", VA = "0x185BF8550")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x5BF27A0", Offset = "0x5BF13A0", VA = "0x185BF27A0", Slot = "4")]
		public AreaServer GetAreaServer()
		{
			return null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x5BF3300", Offset = "0x5BF1F00", VA = "0x185BF3300", Slot = "5")]
		public void Init(PayStore payStore, string pid, string gameServerUrl)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x5BF3370", Offset = "0x5BF1F70", VA = "0x185BF3370", Slot = "6")]
		public void Init(PayStore payStore, Server? area, string pid, string gameServerUrl)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x5BF3A70", Offset = "0x5BF2670", VA = "0x185BF3A70", Slot = "7")]
		public void Login()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x5BF7620", Offset = "0x5BF6220", VA = "0x185BF7620", Slot = "8")]
		public void ShowUserCenter(string accountDeleteNotifyUrl, string accountRecoveredNotifyUrl, string extraData)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x5BF7520", Offset = "0x5BF6120", VA = "0x185BF7520", Slot = "9")]
		public void ShowSwitchAccount()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x5BF68A0", Offset = "0x5BF54A0", VA = "0x185BF68A0", Slot = "10")]
		public void ShowAccountCenter()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x5BF69A0", Offset = "0x5BF55A0", VA = "0x185BF69A0", Slot = "11")]
		public void ShowAgreement(string[] agreementTypes)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x5BF51C0", Offset = "0x5BF3DC0", VA = "0x185BF51C0", Slot = "12")]
		public void Pay(string productId, string payNotifyUrl, string extraData)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x5BF3B70", Offset = "0x5BF2770", VA = "0x185BF3B70", Slot = "13")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, PaymentMode gmoPayMode, GMOPayMethod gmoPayMethod = GMOPayMethod.Instant)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x5BF46B0", Offset = "0x5BF32B0", VA = "0x185BF46B0", Slot = "14")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, int paymentTermDay, int paymentExpiryDateTime)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x5BF6D60", Offset = "0x5BF5960", VA = "0x185BF6D60", Slot = "15")]
		public void ShowSurvey(string activityID, string gameUID, string notifyUrl, string extraData)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x5BF6B30", Offset = "0x5BF5730", VA = "0x185BF6B30", Slot = "16")]
		public void ShowAihelp()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x5BF7F20", Offset = "0x5BF6B20", VA = "0x185BF7F20", Slot = "17")]
		public void SystemShare(string strShareText, [Optional] Texture2D texShare)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x5BF5EB0", Offset = "0x5BF4AB0", VA = "0x185BF5EB0", Slot = "18")]
		public void RequestStoreReview()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x5BF8180", Offset = "0x5BF6D80", VA = "0x185BF8180", Slot = "19")]
		public void UserEventUpload(string strEventName, [Optional] Dictionary<string, string> parameter)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x5BF5870", Offset = "0x5BF4470", VA = "0x185BF5870", Slot = "20")]
		public string QueryErrorMsg(int code)
		{
			return null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x5BF5BA0", Offset = "0x5BF47A0", VA = "0x185BF5BA0", Slot = "21")]
		public void QuerySkuDetails(string[] skus)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x5BF2CA0", Offset = "0x5BF18A0", VA = "0x185BF2CA0", Slot = "22")]
		public string GetSdkVer()
		{
			return null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x5BF2D20", Offset = "0x5BF1920", VA = "0x185BF2D20", Slot = "23")]
		public void GoogleServerToServer(string devToken, string linkID, string eventName, string priceValue, string currencyCode)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x5BF5A10", Offset = "0x5BF4610", VA = "0x185BF5A10", Slot = "24")]
		public string QueryRemoteConfig(string configKey)
		{
			return null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x5BF84C0", Offset = "0x5BF70C0", VA = "0x185BF84C0")]
		private AndroidJavaObject getGameAct()
		{
			return null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x5BF5FB0", Offset = "0x5BF4BB0", VA = "0x185BF5FB0", Slot = "25")]
		public void RoleInfoUpload(string serverId, string roleUid, string roleName, string[] tags, Dictionary<string, string> customField)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x5BF6730", Offset = "0x5BF5330", VA = "0x185BF6730", Slot = "26")]
		public void Share(ShareContent shareContent)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x5BF7A60", Offset = "0x5BF6660", VA = "0x185BF7A60", Slot = "27")]
		public void ShowWebView(OpenType openType, string title, string webUrl, string pid)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x5BF6C10", Offset = "0x5BF5810", VA = "0x185BF6C10", Slot = "28")]
		public void ShowNetworkTest(string gameServerUrl)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x5BF83C0", Offset = "0x5BF6FC0", VA = "0x185BF83C0", Slot = "30")]
		public void _CrashTest()
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x5BF5D50", Offset = "0x5BF4950", VA = "0x185BF5D50", Slot = "29")]
		public void QueryTextLegality(string sourceText)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
		public void OnPause()
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "32")]
		public void OnResume()
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "33")]
		public void SetDefaultCursor(Texture2D cursorTexture, Vector2 hotspot, CursorMode cursorMode)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x5BF26A0", Offset = "0x5BF12A0", VA = "0x185BF26A0", Slot = "34")]
		public void FetchDeviceTrackingID()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x5BF2380", Offset = "0x5BF0F80", VA = "0x185BF2380", Slot = "35")]
		public bool CheckUserCacheExist()
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x5BF1E30", Offset = "0x5BF0A30", VA = "0x185BF1E30", Slot = "36")]
		public void BuildLocalNotification(int identifier, string title, string content, long timestamp)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x5BF2500", Offset = "0x5BF1100", VA = "0x185BF2500", Slot = "37")]
		public void DeleteLocalNotification(int[] identifierList)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x5BF6630", Offset = "0x5BF5230", VA = "0x185BF6630", Slot = "38")]
		public void SetBirthday()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public YoSDKAndroid()
		{
		}

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		private const string JAVA_CALSS_NAME = "com.yostar.sdk.bridge.YostarSdkUnityBridge";

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass _unityAgent;
	}
}
