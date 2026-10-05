using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CB3 RID: 19635
	[Token(Token = "0x2004CB3")]
	public class GroceryHomeState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0601D6C8 RID: 120520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D6C8")]
		[Address(RVA = "0x16F6630", Offset = "0x16F5230", VA = "0x1816F6630", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601D6C9 RID: 120521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6C9")]
		[Address(RVA = "0x16F6690", Offset = "0x16F5290", VA = "0x1816F6690", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601D6CA RID: 120522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6CA")]
		[Address(RVA = "0x16F6C50", Offset = "0x16F5850", VA = "0x1816F6C50", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601D6CB RID: 120523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6CB")]
		[Address(RVA = "0x16F69D0", Offset = "0x16F55D0", VA = "0x1816F69D0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601D6CC RID: 120524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6CC")]
		[Address(RVA = "0x16F7FB0", Offset = "0x16F6BB0", VA = "0x1816F7FB0")]
		private void _TriggerTutorialAVG()
		{
		}

		// Token: 0x0601D6CD RID: 120525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6CD")]
		[Address(RVA = "0x16F8110", Offset = "0x16F6D10", VA = "0x1816F8110")]
		private void _TryConsumeGuidebook([Optional] Story story)
		{
		}

		// Token: 0x0601D6CE RID: 120526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6CE")]
		[Address(RVA = "0x16F6EF0", Offset = "0x16F5AF0", VA = "0x1816F6EF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D6CF RID: 120527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6CF")]
		[Address(RVA = "0x16F7EE0", Offset = "0x16F6AE0", VA = "0x1816F7EE0")]
		private void _SetLaunchPanelShown(int isShow)
		{
		}

		// Token: 0x0601D6D0 RID: 120528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D0")]
		[Address(RVA = "0x16F7050", Offset = "0x16F5C50", VA = "0x1816F7050")]
		private void _OnBackBtnClicked()
		{
		}

		// Token: 0x0601D6D1 RID: 120529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D1")]
		[Address(RVA = "0x16F71C0", Offset = "0x16F5DC0", VA = "0x1816F71C0")]
		private void _OnMileStoneBtnClicked()
		{
		}

		// Token: 0x0601D6D2 RID: 120530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D2")]
		[Address(RVA = "0x16F7270", Offset = "0x16F5E70", VA = "0x1816F7270")]
		private void _OnSaleBtnClicked()
		{
		}

		// Token: 0x0601D6D3 RID: 120531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D3")]
		[Address(RVA = "0x16F81C0", Offset = "0x16F6DC0", VA = "0x1816F81C0")]
		private void _TryStartSale(string actId)
		{
		}

		// Token: 0x0601D6D4 RID: 120532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D4")]
		[Address(RVA = "0x16F7C80", Offset = "0x16F6880", VA = "0x1816F7C80")]
		private void _SendStartSaleRequestAndOpenOrderState(string actId)
		{
		}

		// Token: 0x0601D6D5 RID: 120533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D5")]
		[Address(RVA = "0x16F7A20", Offset = "0x16F6620", VA = "0x1816F7A20")]
		private void _SendSattleRequestAndShowGainItems(string actId)
		{
		}

		// Token: 0x0601D6D6 RID: 120534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D6")]
		[Address(RVA = "0x16F74D0", Offset = "0x16F60D0", VA = "0x1816F74D0")]
		private void _OnShowSattleGainItems(GrocerySaleSettleResponse response)
		{
		}

		// Token: 0x0601D6D7 RID: 120535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D7")]
		[Address(RVA = "0x16F7700", Offset = "0x16F6300", VA = "0x1816F7700")]
		private void _OnStartSaleProceed(GroceryStartSaleResponse response)
		{
		}

		// Token: 0x0601D6D8 RID: 120536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D8")]
		[Address(RVA = "0x16F77E0", Offset = "0x16F63E0", VA = "0x1816F77E0")]
		private void _OpenOrderState()
		{
		}

		// Token: 0x0601D6D9 RID: 120537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6D9")]
		[Address(RVA = "0x16F7900", Offset = "0x16F6500", VA = "0x1816F7900")]
		private void _OpenSellState()
		{
		}

		// Token: 0x0601D6DA RID: 120538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6DA")]
		[Address(RVA = "0x16F84B0", Offset = "0x16F70B0", VA = "0x1816F84B0")]
		public GroceryHomeState()
		{
		}

		// Token: 0x0601D6DB RID: 120539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6DB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601D6DC RID: 120540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6DC")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04026C2B RID: 158763
		[Token(Token = "0x4026C2B")]
		[NonSerialized]
		public const int ON_MSG_SET_LAUNCH_PANEL_SHOWN = 0;

		// Token: 0x04026C2C RID: 158764
		[Token(Token = "0x4026C2C")]
		[NonSerialized]
		public const int ON_MSG_OPEN_MILE_STONE_STATE = 1;

		// Token: 0x04026C2D RID: 158765
		[Token(Token = "0x4026C2D")]
		[NonSerialized]
		public const int ON_MSG_SALE = 2;

		// Token: 0x04026C2E RID: 158766
		[Token(Token = "0x4026C2E")]
		private const string ENTER_ANIM_NAME = "grocery_home_enter_anim";

		// Token: 0x04026C2F RID: 158767
		[Token(Token = "0x4026C2F")]
		private const int FIRST_DAY = 1;

		// Token: 0x04026C30 RID: 158768
		[Token(Token = "0x4026C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _topMenuContainer;

		// Token: 0x04026C31 RID: 158769
		[Token(Token = "0x4026C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GroceryHomeView _homeView;

		// Token: 0x04026C32 RID: 158770
		[Token(Token = "0x4026C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GroceryHomeLaunchView _launchPanel;

		// Token: 0x04026C33 RID: 158771
		[Token(Token = "0x4026C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AnimationWrapper _animEnter;

		// Token: 0x04026C34 RID: 158772
		[Token(Token = "0x4026C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GroceryHomeStateBean m_stateBean;

		// Token: 0x04026C35 RID: 158773
		[Token(Token = "0x4026C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04026C36 RID: 158774
		[Token(Token = "0x4026C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Tween m_cachedAnim;

		// Token: 0x04026C37 RID: 158775
		[Token(Token = "0x4026C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04026C38 RID: 158776
		[Token(Token = "0x4026C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04026C39 RID: 158777
		[Token(Token = "0x4026C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04026C3A RID: 158778
		[Token(Token = "0x4026C3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04026C3B RID: 158779
		[Token(Token = "0x4026C3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x04026C3C RID: 158780
		[Token(Token = "0x4026C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x04026C3D RID: 158781
		[Token(Token = "0x4026C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026C3E RID: 158782
		[Token(Token = "0x4026C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetLaunchPanelShown;

		// Token: 0x04026C3F RID: 158783
		[Token(Token = "0x4026C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBackBtnClicked;

		// Token: 0x04026C40 RID: 158784
		[Token(Token = "0x4026C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnMileStoneBtnClicked;

		// Token: 0x04026C41 RID: 158785
		[Token(Token = "0x4026C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSaleBtnClicked;

		// Token: 0x04026C42 RID: 158786
		[Token(Token = "0x4026C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryStartSale;

		// Token: 0x04026C43 RID: 158787
		[Token(Token = "0x4026C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SendStartSaleRequestAndOpenOrderState;

		// Token: 0x04026C44 RID: 158788
		[Token(Token = "0x4026C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SendSattleRequestAndShowGainItems;

		// Token: 0x04026C45 RID: 158789
		[Token(Token = "0x4026C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnShowSattleGainItems;

		// Token: 0x04026C46 RID: 158790
		[Token(Token = "0x4026C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnStartSaleProceed;

		// Token: 0x04026C47 RID: 158791
		[Token(Token = "0x4026C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OpenOrderState;

		// Token: 0x04026C48 RID: 158792
		[Token(Token = "0x4026C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OpenSellState;

		// Token: 0x04026C49 RID: 158793
		[Token(Token = "0x4026C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
