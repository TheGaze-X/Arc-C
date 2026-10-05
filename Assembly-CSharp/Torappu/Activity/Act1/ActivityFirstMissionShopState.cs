using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B4D RID: 31565
	[Token(Token = "0x2007B4D")]
	public class ActivityFirstMissionShopState : PopupFloatState, IHotfixable
	{
		// Token: 0x0602C2ED RID: 180973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C2ED")]
		[Address(RVA = "0x28135A0", Offset = "0x28121A0", VA = "0x1828135A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C2EE RID: 180974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2EE")]
		[Address(RVA = "0x2813600", Offset = "0x2812200", VA = "0x182813600", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C2EF RID: 180975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2EF")]
		[Address(RVA = "0x2813680", Offset = "0x2812280", VA = "0x182813680", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602C2F0 RID: 180976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2F0")]
		[Address(RVA = "0x2813FB0", Offset = "0x2812BB0", VA = "0x182813FB0")]
		private void _ApplyState()
		{
		}

		// Token: 0x0602C2F1 RID: 180977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2F1")]
		[Address(RVA = "0x2813D20", Offset = "0x2812920", VA = "0x182813D20")]
		public void TweenToMission()
		{
		}

		// Token: 0x0602C2F2 RID: 180978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2F2")]
		[Address(RVA = "0x2813D90", Offset = "0x2812990", VA = "0x182813D90")]
		public void TweenToShop()
		{
		}

		// Token: 0x0602C2F3 RID: 180979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2F3")]
		[Address(RVA = "0x2813730", Offset = "0x2812330", VA = "0x182813730")]
		private void RefreshCoinState()
		{
		}

		// Token: 0x0602C2F4 RID: 180980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2F4")]
		[Address(RVA = "0x2813C50", Offset = "0x2812850", VA = "0x182813C50")]
		public void TweenToMap()
		{
		}

		// Token: 0x0602C2F5 RID: 180981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C2F5")]
		[Address(RVA = "0x2814370", Offset = "0x2812F70", VA = "0x182814370")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602C2F6 RID: 180982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C2F6")]
		[Address(RVA = "0x2814420", Offset = "0x2813020", VA = "0x182814420")]
		private IEnumerator _ReceiveItemsCoroutine(RewardItemModel rewarditem)
		{
			return null;
		}

		// Token: 0x0602C2F7 RID: 180983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2F7")]
		[Address(RVA = "0x2813A40", Offset = "0x2812640", VA = "0x182813A40")]
		public void SendShopListRequest()
		{
		}

		// Token: 0x0602C2F8 RID: 180984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2F8")]
		[Address(RVA = "0x28134B0", Offset = "0x28120B0", VA = "0x1828134B0")]
		public void AddShopTop(ActivityShopData shopData)
		{
		}

		// Token: 0x0602C2F9 RID: 180985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2F9")]
		[Address(RVA = "0x28137E0", Offset = "0x28123E0", VA = "0x1828137E0")]
		public void SendMissionRequest(string missionId)
		{
		}

		// Token: 0x0602C2FA RID: 180986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2FA")]
		[Address(RVA = "0x28144F0", Offset = "0x28130F0", VA = "0x1828144F0")]
		public ActivityFirstMissionShopState()
		{
		}

		// Token: 0x0602C2FD RID: 180989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2FD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602C2FE RID: 180990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2FE")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040400D8 RID: 262360
		[Token(Token = "0x40400D8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActivityFirstStateBean _stateBean;

		// Token: 0x040400D9 RID: 262361
		[Token(Token = "0x40400D9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggle _missionButton;

		// Token: 0x040400DA RID: 262362
		[Token(Token = "0x40400DA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TwoStateToggle _shopButton;

		// Token: 0x040400DB RID: 262363
		[Token(Token = "0x40400DB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ActivityFirstMissionView _missionView;

		// Token: 0x040400DC RID: 262364
		[Token(Token = "0x40400DC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ActivityFirstShopView _shopView;

		// Token: 0x040400DD RID: 262365
		[Token(Token = "0x40400DD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x040400DE RID: 262366
		[Token(Token = "0x40400DE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _coinRemain;

		// Token: 0x040400DF RID: 262367
		[Token(Token = "0x40400DF")]
		[FieldOffset(Offset = "0xA8")]
		private ActivityFirstMissionShopEnum m_currentState;

		// Token: 0x040400E0 RID: 262368
		[Token(Token = "0x40400E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040400E1 RID: 262369
		[Token(Token = "0x40400E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040400E2 RID: 262370
		[Token(Token = "0x40400E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040400E3 RID: 262371
		[Token(Token = "0x40400E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyState;

		// Token: 0x040400E4 RID: 262372
		[Token(Token = "0x40400E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TweenToMission;

		// Token: 0x040400E5 RID: 262373
		[Token(Token = "0x40400E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TweenToShop;

		// Token: 0x040400E6 RID: 262374
		[Token(Token = "0x40400E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshCoinState;

		// Token: 0x040400E7 RID: 262375
		[Token(Token = "0x40400E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TweenToMap;

		// Token: 0x040400E8 RID: 262376
		[Token(Token = "0x40400E8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x040400E9 RID: 262377
		[Token(Token = "0x40400E9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1__ReceiveItemsCoroutine;

		// Token: 0x040400EA RID: 262378
		[Token(Token = "0x40400EA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SendShopListRequest;

		// Token: 0x040400EB RID: 262379
		[Token(Token = "0x40400EB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AddShopTop;

		// Token: 0x040400EC RID: 262380
		[Token(Token = "0x40400EC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SendMissionRequest;

		// Token: 0x040400ED RID: 262381
		[Token(Token = "0x40400ED")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
