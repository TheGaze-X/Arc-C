using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.SDK;
using U8.SDK;
using UnityEngine;
using YoStar.SDK;

namespace YostarSDKV2
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public class YostarSDKV2WindowsPlugin : YostarSDKV2Plugin
	{
		// Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x521810", Offset = "0x520410", VA = "0x180521810")]
		public YostarSDKV2WindowsPlugin(YostarSDKV2 sdk)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "20")]
		public override bool UseU8SDK()
		{
			return default(bool);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x51CBE0", Offset = "0x51B7E0", VA = "0x18051CBE0", Slot = "21")]
		public override bool IsSDKReady()
		{
			return default(bool);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x51CAA0", Offset = "0x51B6A0", VA = "0x18051CAA0", Slot = "16")]
		public override void Init()
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x51CBF0", Offset = "0x51B7F0", VA = "0x18051CBF0", Slot = "17")]
		public override void Login(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x520B40", Offset = "0x51F740", VA = "0x180520B40")]
		private void _ShowLoginDialog()
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x520000", Offset = "0x51EC00", VA = "0x180520000")]
		private void _OnUserClickedLoginInDialog()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x520260", Offset = "0x51EE60", VA = "0x180520260")]
		private void _OpenTempLoginDialog(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x520060", Offset = "0x51EC60", VA = "0x180520060")]
		private void _OpenJPLoginDialog(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x51CFC0", Offset = "0x51BBC0", VA = "0x18051CFC0", Slot = "18")]
		public override void Pay(ExternalPluginPayParams args)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x51E270", Offset = "0x51CE70", VA = "0x18051E270")]
		private static string _GetInvalidPayParamsMessage(U8PayParams p, string sdkProductId, string payNotifyUrl)
		{
			return null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x5207D0", Offset = "0x51F3D0", VA = "0x1805207D0")]
		private static string _ResolvePayProductId(U8PayParams p)
		{
			return null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x520590", Offset = "0x51F190", VA = "0x180520590")]
		private static string _ResolveExtensionProductId(string extension)
		{
			return null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x520700", Offset = "0x51F300", VA = "0x180520700")]
		private static string _ResolvePayNotifyUrl(string extension)
		{
			return null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x520460", Offset = "0x51F060", VA = "0x180520460")]
		private static Dictionary<string, object> _ParsePayExtension(string extension)
		{
			return null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x51E140", Offset = "0x51CD40", VA = "0x18051E140")]
		private static string _GetExtensionString(Dictionary<string, object> raw, string key)
		{
			return null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x51CDE0", Offset = "0x51B9E0", VA = "0x18051CDE0", Slot = "19")]
		public override void Logout(ExternalPluginLogoutParams args)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x51CEA0", Offset = "0x51BAA0", VA = "0x18051CEA0", Slot = "22")]
		public override void OpenAgreements(List<string> _)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x51CA50", Offset = "0x51B650", VA = "0x18051CA50", Slot = "23")]
		public override bool CheckIfHasCachedUser()
		{
			return default(bool);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x51CF60", Offset = "0x51BB60", VA = "0x18051CF60", Slot = "24")]
		public override void OpenUserCenter()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x51DA50", Offset = "0x51C650", VA = "0x18051DA50", Slot = "25")]
		public override void SwitchAccount()
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x51CF00", Offset = "0x51BB00", VA = "0x18051CF00", Slot = "26")]
		public override void OpenFeedback()
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x51DB90", Offset = "0x51C790", VA = "0x18051DB90", Slot = "28")]
		public override bool TrySetData(int type, string paramJson)
		{
			return default(bool);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x51DAB0", Offset = "0x51C6B0", VA = "0x18051DAB0", Slot = "29")]
		public override bool TryGetData(int type, string paramJson, out string data)
		{
			return default(bool);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x51DC40", Offset = "0x51C840", VA = "0x18051DC40", Slot = "27")]
		public override bool TrySubmitGameData(U8ExtraGameData data)
		{
			return default(bool);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x51E010", Offset = "0x51CC10", VA = "0x18051E010")]
		private void _EnsureLifecycleDispatcher()
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x51EC70", Offset = "0x51D870", VA = "0x18051EC70")]
		private void _OnApplicationPauseStateChanged(bool paused)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x521450", Offset = "0x520050", VA = "0x180521450")]
		private void _UploadTraceEvent(string paramJson)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x521110", Offset = "0x51FD10", VA = "0x180521110")]
		private void _UploadRoleInfo(U8ExtraGameData data)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x5216E0", Offset = "0x5202E0", VA = "0x1805216E0")]
		private void _UploadUserEvent(U8ExtraGameData data)
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x520E80", Offset = "0x51FA80", VA = "0x180520E80")]
		private static bool _TryParseStringDictionary(string json, out Dictionary<string, string> result)
		{
			return default(bool);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x51DC90", Offset = "0x51C890", VA = "0x18051DC90")]
		private static void _AddIfNotEmpty(Dictionary<string, string> dict, string key, string value)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x51DD10", Offset = "0x51C910", VA = "0x18051DD10")]
		private void _BindEvents()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x51E5B0", Offset = "0x51D1B0", VA = "0x18051E5B0")]
		private void _InitYoStarSDK()
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x51E830", Offset = "0x51D430", VA = "0x18051E830")]
		private static string _LoadSdkPidFromResources()
		{
			return null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x51E1E0", Offset = "0x51CDE0", VA = "0x18051E1E0")]
		private static string _GetGameServerUrl()
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x51E470", Offset = "0x51D070", VA = "0x18051E470")]
		private static string _GetRegionKey()
		{
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x51EC00", Offset = "0x51D800", VA = "0x18051EC00")]
		private static YostarPcArea _MapAreaServer()
		{
			return YostarPcArea.Jp;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x51EE90", Offset = "0x51DA90", VA = "0x18051EE90")]
		private void _OnInitResponse(InitRet ret)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x520AF0", Offset = "0x51F6F0", VA = "0x180520AF0")]
		private void _SetDefaultCursorForSDK()
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x51E510", Offset = "0x51D110", VA = "0x18051E510")]
		private string _GetSdkVersionForLog()
		{
			return null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x51FE00", Offset = "0x51EA00", VA = "0x18051FE00")]
		private void _OnSDKUIAppear()
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x51FEC0", Offset = "0x51EAC0", VA = "0x18051FEC0")]
		private void _OnSDKUIClose()
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x520C60", Offset = "0x51F860", VA = "0x180520C60")]
		private void _StartSDKPanelTracking(SDKHelper.SDKViewState viewState)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x520530", Offset = "0x51F130", VA = "0x180520530")]
		private void _PrepareSystemCursorForSDKView()
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x51E560", Offset = "0x51D160", VA = "0x18051E560")]
		private bool _HasPendingPayFlow()
		{
			return default(bool);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x520C70", Offset = "0x51F870", VA = "0x180520C70")]
		private void _StopSDKPanelTracking(SDKHelper.SDKViewState viewState, bool clearPending)
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x51EFC0", Offset = "0x51DBC0", VA = "0x18051EFC0")]
		private void _OnLoginResponse(LoginRet ret)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x520D10", Offset = "0x51F910", VA = "0x180520D10")]
		private void _SubmitLoginResultToU8(LoginRet ret)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x51F2B0", Offset = "0x51DEB0", VA = "0x18051F2B0")]
		private void _OnPayResponse(PayRet ret)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x51E420", Offset = "0x51D020", VA = "0x18051E420")]
		private static PayFailStatus _GetPayFailStatus(PayRet ret)
		{
			return PayFailStatus.UNKNOWN;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x51E580", Offset = "0x51D180", VA = "0x18051E580")]
		private static bool _HasSDKOrder(PayRet ret)
		{
			return default(bool);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x51E810", Offset = "0x51D410", VA = "0x18051E810")]
		private static bool _IsPayCanceled(int code)
		{
			return default(bool);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x51F210", Offset = "0x51DE10", VA = "0x18051F210")]
		private void _OnLogoutResponse(LogoutRet ret)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x51ED80", Offset = "0x51D980", VA = "0x18051ED80")]
		private void _OnDeleteAccountResponse(DeleteAccountRet ret)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x51FF80", Offset = "0x51EB80", VA = "0x18051FF80")]
		private void _OnSwitchServerResponse(SwitchServerRet ret)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x520960", Offset = "0x51F560", VA = "0x180520960")]
		private static void _SendExtraInfo(int code)
		{
		}

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x68")]
		private ExternalPluginLoginParams m_pendingLoginArgs;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x90")]
		private ExternalPluginPayParams m_pendingPayArgs;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_sdkInited;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_sdkInitRequested;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0xB2")]
		private bool m_eventsBound;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0xB3")]
		private bool m_waitingForSDKLogin;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0xB4")]
		private SDKHelper.SDKViewState m_pendingSdkViewState;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0xB8")]
		private SDKHelper.SDKViewState m_activeSdkViewState;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0xC0")]
		private YostarSDKV2WindowsPlugin.YostarPCLifecycleDispatcher m_lifecycleDispatcher;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0xC8")]
		private readonly IYostarPcSdkFacade m_pcSdk;

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		private class YostarPCLifecycleDispatcher : MonoBehaviour
		{
			// Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			public void Bind(YostarSDKV2WindowsPlugin owner)
			{
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x51A2B0", Offset = "0x518EB0", VA = "0x18051A2B0")]
			private void OnApplicationPause(bool pauseStatus)
			{
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x51A290", Offset = "0x518E90", VA = "0x18051A290")]
			private void OnApplicationFocus(bool hasFocus)
			{
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x51A2B0", Offset = "0x518EB0", VA = "0x18051A2B0")]
			private void _SetPaused(bool paused)
			{
			}

			// Token: 0x060002AA RID: 682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			public YostarPCLifecycleDispatcher()
			{
			}

			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x18")]
			private YostarSDKV2WindowsPlugin m_owner;

			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x20")]
			private bool m_isPaused;
		}
	}
}
