using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public class YoSDKIOS : YoSDKUnity, IYoSDK
	{
		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x5C1DA30", Offset = "0x5C1C630", VA = "0x185C1DA30", Slot = "4")]
		public AreaServer GetAreaServer()
		{
			return null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x5C1DAA0", Offset = "0x5C1C6A0", VA = "0x185C1DAA0", Slot = "5")]
		public void Init(PayStore payStore, string pid, string gameServerUrl)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public void Init(PayStore payStore, Server? area, string pid, string gameServerUrl)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public void Login()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		public void QuerySkuDetails(string[] skus)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		public void Pay(string productId, string payNotifyUrl, string extraData)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, PaymentMode gmoPayMode, GMOPayMethod gmoPayMethod = GMOPayMethod.Instant)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		public void Pay(string productId, string productName, double productPrice, string payNotifyUrl, string extraData, int paymentTermDay, int paymentExpiryDateTime)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public void ShowAihelp()
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public void ShowSwitchAccount()
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		public void ShowAccountCenter()
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public void ShowUserCenter(string accountDeleteNotifyUrl, string accountRecoveredNotifyUrl, string extraData)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x5C1B5B0", Offset = "0x5C1A1B0", VA = "0x185C1B5B0", Slot = "22")]
		public string GetSdkVer()
		{
			return null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public void UserEventUpload(string strEventName, [Optional] Dictionary<string, string> parameter)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public void SystemShare(string strShareText, [Optional] Texture2D texShare)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		public void RequestStoreReview()
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "23")]
		public void GoogleServerToServer(string devToken, string linkID, string eventName, string priceValue, string currencyCode)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x5C1DB00", Offset = "0x5C1C700", VA = "0x185C1DB00", Slot = "20")]
		public string QueryErrorMsg(int code)
		{
			return null;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x5C1DB30", Offset = "0x5C1C730", VA = "0x185C1DB30", Slot = "24")]
		public string QueryRemoteConfig(string configKey)
		{
			return null;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		public void ShowAgreement(string[] agreementTypes)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public void ShowSurvey(string activityID, string gameUID, string notifyUrl, string extraData)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "25")]
		public void RoleInfoUpload(string serverId, string roleUid, string roleName, string[] tags, Dictionary<string, string> customField)
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "30")]
		public void _CrashTest()
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "26")]
		public void Share(ShareContent shareContent)
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "27")]
		public void ShowWebView(OpenType openType, string title, string webUrl, string pid)
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "28")]
		public void ShowNetworkTest(string gameServerUrl)
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		public void QueryTextLegality(string sourceText)
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
		public void OnPause()
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "32")]
		public void OnResume()
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "33")]
		public void SetDefaultCursor(Texture2D cursorTexture, Vector2 hotspot, CursorMode cursorMode)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		public void FetchDeviceTrackingID()
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "35")]
		public bool CheckUserCacheExist()
		{
			return default(bool);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "36")]
		public void BuildLocalNotification(int identifier, string title, string content, long timestamp)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "37")]
		public void DeleteLocalNotification(int[] identifierList)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "38")]
		public void SetBirthday()
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public YoSDKIOS()
		{
		}
	}
}
