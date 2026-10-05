using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	public class SDKUnbindConfirmState : HGSDKPopupPage.UIState
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x1700010D")]
		public override HGSDKPopupPage.PopupState myState
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x1AE4200", Offset = "0x1AE2E00", VA = "0x181AE4200", Slot = "13")]
			get
			{
				return HGSDKPopupPage.PopupState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1AE3CA0", Offset = "0x1AE28A0", VA = "0x181AE3CA0", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1AE3B20", Offset = "0x1AE2720", VA = "0x181AE3B20", Slot = "24")]
		public override HGSDKPopupPage.UIState.FloatV2Handler GetFloatV2Handler()
		{
			return default(HGSDKPopupPage.UIState.FloatV2Handler);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1AE3E90", Offset = "0x1AE2A90", VA = "0x181AE3E90")]
		private void _EventOnCloseClicked()
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1AE3DF0", Offset = "0x1AE29F0", VA = "0x181AE3DF0")]
		private void _EventOnBackClicked()
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1AE4080", Offset = "0x1AE2C80", VA = "0x181AE4080")]
		private void _OnUnbindGrantSuc(APIV2RespWrapper<UnbindGrantResponse> response)
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1AE3F00", Offset = "0x1AE2B00", VA = "0x181AE3F00")]
		private void _OnUnbindGrantFail(APIV2FailResponse response)
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1AE38D0", Offset = "0x1AE24D0", VA = "0x181AE38D0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1AE41A0", Offset = "0x1AE2DA0", VA = "0x181AE41A0")]
		public SDKUnbindConfirmState()
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1AE0F80", Offset = "0x1ADFB80", VA = "0x181AE0F80")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1AE3D60", Offset = "0x1AE2960", VA = "0x181AE3D60")]
		private HGSDKPopupPage.UIState.FloatV2Handler <>xLuaBaseProxy_GetFloatV2Handler()
		{
			return default(HGSDKPopupPage.UIState.FloatV2Handler);
		}

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFloatV2Handler;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnCloseClicked;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnBackClicked;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnUnbindGrantSuc;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnbindGrantFail;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020001BE RID: 446
		[Token(Token = "0x20001BE")]
		public class Param
		{
			// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040009D4 RID: 2516
			[Token(Token = "0x40009D4")]
			[FieldOffset(Offset = "0x10")]
			public string phoneNum;

			// Token: 0x040009D5 RID: 2517
			[Token(Token = "0x40009D5")]
			[FieldOffset(Offset = "0x18")]
			public string smsCode;

			// Token: 0x040009D6 RID: 2518
			[Token(Token = "0x40009D6")]
			[FieldOffset(Offset = "0x20")]
			public string realName;

			// Token: 0x040009D7 RID: 2519
			[Token(Token = "0x40009D7")]
			[FieldOffset(Offset = "0x28")]
			public string idNumber;
		}
	}
}
