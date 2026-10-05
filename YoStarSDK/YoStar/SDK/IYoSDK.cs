using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public interface IYoSDK
	{
		// Token: 0x06000142 RID: 322
		[Token(Token = "0x6000142")]
		AreaServer GetAreaServer();

		// Token: 0x06000143 RID: 323
		[Token(Token = "0x6000143")]
		void Init(PayStore payStore, string pid, string gameServerUrl);

		// Token: 0x06000144 RID: 324
		[Token(Token = "0x6000144")]
		void Init(PayStore payStore, Server? area, string pid, string gameServerUrl);

		// Token: 0x06000145 RID: 325
		[Token(Token = "0x6000145")]
		void Login();

		// Token: 0x06000146 RID: 326
		[Token(Token = "0x6000146")]
		void ShowUserCenter(string accountDeleteNotifyUrl, string accountRecoveredNotifyUrl, string extraData);

		// Token: 0x06000147 RID: 327
		[Token(Token = "0x6000147")]
		void ShowSwitchAccount();

		// Token: 0x06000148 RID: 328
		[Token(Token = "0x6000148")]
		void ShowAccountCenter();

		// Token: 0x06000149 RID: 329
		[Token(Token = "0x6000149")]
		void ShowAgreement(string[] agreementTypes);

		// Token: 0x0600014A RID: 330
		[Token(Token = "0x600014A")]
		void Pay(string productId, string payNotifyUrl, string strExtraData);

		// Token: 0x0600014B RID: 331
		[Token(Token = "0x600014B")]
		void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, PaymentMode gmoPayMode, GMOPayMethod gmoPayMethod);

		// Token: 0x0600014C RID: 332
		[Token(Token = "0x600014C")]
		void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, int paymentTermDay, int paymentExpiryDateTime);

		// Token: 0x0600014D RID: 333
		[Token(Token = "0x600014D")]
		void ShowSurvey(string activityID, string gameUID, string notifyUrl, string extraData);

		// Token: 0x0600014E RID: 334
		[Token(Token = "0x600014E")]
		void ShowAihelp();

		// Token: 0x0600014F RID: 335
		[Token(Token = "0x600014F")]
		void SystemShare(string strShareText, [Optional] Texture2D texShare);

		// Token: 0x06000150 RID: 336
		[Token(Token = "0x6000150")]
		void RequestStoreReview();

		// Token: 0x06000151 RID: 337
		[Token(Token = "0x6000151")]
		void UserEventUpload(string strEventName, [Optional] Dictionary<string, string> strCallbackParameter);

		// Token: 0x06000152 RID: 338
		[Token(Token = "0x6000152")]
		string QueryErrorMsg(int code);

		// Token: 0x06000153 RID: 339
		[Token(Token = "0x6000153")]
		void QuerySkuDetails(string[] skus);

		// Token: 0x06000154 RID: 340
		[Token(Token = "0x6000154")]
		string GetSdkVer();

		// Token: 0x06000155 RID: 341
		[Token(Token = "0x6000155")]
		void GoogleServerToServer(string devToken, string linkID, string eventName, string priceValue, string currencyCode);

		// Token: 0x06000156 RID: 342
		[Token(Token = "0x6000156")]
		string QueryRemoteConfig(string configKey);

		// Token: 0x06000157 RID: 343
		[Token(Token = "0x6000157")]
		void RoleInfoUpload(string serverId, string roleUid, string roleName, string[] tags, Dictionary<string, string> customField);

		// Token: 0x06000158 RID: 344
		[Token(Token = "0x6000158")]
		void Share(ShareContent shareContent);

		// Token: 0x06000159 RID: 345
		[Token(Token = "0x6000159")]
		void ShowWebView(OpenType openType, string title, string webUrl, string pid);

		// Token: 0x0600015A RID: 346
		[Token(Token = "0x600015A")]
		void ShowNetworkTest(string gameServerUrl);

		// Token: 0x0600015B RID: 347
		[Token(Token = "0x600015B")]
		void QueryTextLegality(string sourceText);

		// Token: 0x0600015C RID: 348
		[Token(Token = "0x600015C")]
		void _CrashTest();

		// Token: 0x0600015D RID: 349
		[Token(Token = "0x600015D")]
		void OnPause();

		// Token: 0x0600015E RID: 350
		[Token(Token = "0x600015E")]
		void OnResume();

		// Token: 0x0600015F RID: 351
		[Token(Token = "0x600015F")]
		void SetDefaultCursor(Texture2D cursorTexture, Vector2 hotspot, CursorMode cursorMode);

		// Token: 0x06000160 RID: 352
		[Token(Token = "0x6000160")]
		void FetchDeviceTrackingID();

		// Token: 0x06000161 RID: 353
		[Token(Token = "0x6000161")]
		bool CheckUserCacheExist();

		// Token: 0x06000162 RID: 354
		[Token(Token = "0x6000162")]
		void BuildLocalNotification(int identifier, string title, string content, long timestamp);

		// Token: 0x06000163 RID: 355
		[Token(Token = "0x6000163")]
		void DeleteLocalNotification(int[] identifier);

		// Token: 0x06000164 RID: 356
		[Token(Token = "0x6000164")]
		void SetBirthday();
	}
}
