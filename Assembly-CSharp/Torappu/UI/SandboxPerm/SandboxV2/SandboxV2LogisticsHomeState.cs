using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004336 RID: 17206
	[Token(Token = "0x2004336")]
	public class SandboxV2LogisticsHomeState : State, IValueMsgReceiver
	{
		// Token: 0x0601A6DF RID: 108255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A6DF")]
		[Address(RVA = "0x1387BB0", Offset = "0x13867B0", VA = "0x181387BB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A6E0 RID: 108256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6E0")]
		[Address(RVA = "0x1387F90", Offset = "0x1386B90", VA = "0x181387F90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A6E1 RID: 108257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6E1")]
		[Address(RVA = "0x1388A90", Offset = "0x1387690", VA = "0x181388A90", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A6E2 RID: 108258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6E2")]
		[Address(RVA = "0x1388370", Offset = "0x1386F70", VA = "0x181388370", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601A6E3 RID: 108259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6E3")]
		[Address(RVA = "0x13881E0", Offset = "0x1386DE0", VA = "0x1813881E0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A6E4 RID: 108260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A6E4")]
		[Address(RVA = "0x1388C80", Offset = "0x1387880", VA = "0x181388C80", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601A6E5 RID: 108261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6E5")]
		[Address(RVA = "0x1387C10", Offset = "0x1386810", VA = "0x181387C10")]
		public void OnBackClicked()
		{
		}

		// Token: 0x0601A6E6 RID: 108262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6E6")]
		[Address(RVA = "0x1387D40", Offset = "0x1386940", VA = "0x181387D40")]
		public void OnDrinkBtnClicked()
		{
		}

		// Token: 0x0601A6E7 RID: 108263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6E7")]
		[Address(RVA = "0x13883E0", Offset = "0x1386FE0", VA = "0x1813883E0")]
		public void OnRemoveCharBtnClicked()
		{
		}

		// Token: 0x0601A6E8 RID: 108264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6E8")]
		[Address(RVA = "0x1388C20", Offset = "0x1387820", VA = "0x181388C20")]
		public void OnUpdateSquadBtnClicked()
		{
		}

		// Token: 0x0601A6E9 RID: 108265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6E9")]
		[Address(RVA = "0x1388E80", Offset = "0x1387A80", VA = "0x181388E80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A6EA RID: 108266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6EA")]
		[Address(RVA = "0x1388FA0", Offset = "0x1387BA0", VA = "0x181388FA0")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x0601A6EB RID: 108267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6EB")]
		[Address(RVA = "0x13890A0", Offset = "0x1387CA0", VA = "0x1813890A0")]
		private void _OnJumpToCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601A6EC RID: 108268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6EC")]
		[Address(RVA = "0x1389530", Offset = "0x1388130", VA = "0x181389530")]
		private void _OnSquadItemClicked(int index)
		{
		}

		// Token: 0x0601A6ED RID: 108269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6ED")]
		[Address(RVA = "0x1389450", Offset = "0x1388050", VA = "0x181389450")]
		private void _OnSquadBlockItemClicked()
		{
		}

		// Token: 0x0601A6EE RID: 108270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6EE")]
		[Address(RVA = "0x13891D0", Offset = "0x1387DD0", VA = "0x1813891D0")]
		private void _OnRemoveCharDialogConfirmed(int charInstId)
		{
		}

		// Token: 0x0601A6EF RID: 108271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6EF")]
		[Address(RVA = "0x1389A30", Offset = "0x1388630", VA = "0x181389A30")]
		private void _TryToOpenSelectCharState(int selectedIndex = -1)
		{
		}

		// Token: 0x0601A6F0 RID: 108272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6F0")]
		[Address(RVA = "0x1389790", Offset = "0x1388390", VA = "0x181389790")]
		private void _ReLoadDataAndRefresh()
		{
		}

		// Token: 0x0601A6F1 RID: 108273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6F1")]
		[Address(RVA = "0x1389900", Offset = "0x1388500", VA = "0x181389900")]
		private void _TryRaiseTutorialSignal()
		{
		}

		// Token: 0x0601A6F2 RID: 108274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A6F2")]
		[Address(RVA = "0x1388DF0", Offset = "0x13879F0", VA = "0x181388DF0")]
		private IEnumerator _CoroutineTriggerTutorial()
		{
			return null;
		}

		// Token: 0x0601A6F3 RID: 108275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6F3")]
		[Address(RVA = "0x1389850", Offset = "0x1388450", VA = "0x181389850")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x0601A6F4 RID: 108276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6F4")]
		[Address(RVA = "0x1389E00", Offset = "0x1388A00", VA = "0x181389E00")]
		public SandboxV2LogisticsHomeState()
		{
		}

		// Token: 0x0601A6F6 RID: 108278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6F6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A6F7 RID: 108279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6F7")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601A6F8 RID: 108280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6F8")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0601A6F9 RID: 108281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A6F9")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04021960 RID: 137568
		[Token(Token = "0x4021960")]
		[NonSerialized]
		public const int MSG_ON_SQUAD_ITEM_CLICKED = 1;

		// Token: 0x04021961 RID: 137569
		[Token(Token = "0x4021961")]
		[NonSerialized]
		public const int MSG_ON_SQUAD_BLOCK_ITEM_CLICKED = 2;

		// Token: 0x04021962 RID: 137570
		[Token(Token = "0x4021962")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public RectTransform _backRectTransform;

		// Token: 0x04021963 RID: 137571
		[Token(Token = "0x4021963")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2LogisticsTotalBuffInfoView _totalBuffInfoView;

		// Token: 0x04021964 RID: 137572
		[Token(Token = "0x4021964")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2LogisticsCharBuffInfoView _charBuffInfoView;

		// Token: 0x04021965 RID: 137573
		[Token(Token = "0x4021965")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SandboxV2LogisticsSquadView _squadView;

		// Token: 0x04021966 RID: 137574
		[Token(Token = "0x4021966")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2LogisticsHomeStateBean m_stateBean;

		// Token: 0x04021967 RID: 137575
		[Token(Token = "0x4021967")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2AdminCharSelectStateBean.OpenOption m_cachedOpenOption;

		// Token: 0x04021968 RID: 137576
		[Token(Token = "0x4021968")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x04021969 RID: 137577
		[Token(Token = "0x4021969")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0402196A RID: 137578
		[Token(Token = "0x402196A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402196B RID: 137579
		[Token(Token = "0x402196B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402196C RID: 137580
		[Token(Token = "0x402196C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402196D RID: 137581
		[Token(Token = "0x402196D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402196E RID: 137582
		[Token(Token = "0x402196E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402196F RID: 137583
		[Token(Token = "0x402196F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04021970 RID: 137584
		[Token(Token = "0x4021970")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x04021971 RID: 137585
		[Token(Token = "0x4021971")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDrinkBtnClicked;

		// Token: 0x04021972 RID: 137586
		[Token(Token = "0x4021972")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRemoveCharBtnClicked;

		// Token: 0x04021973 RID: 137587
		[Token(Token = "0x4021973")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnUpdateSquadBtnClicked;

		// Token: 0x04021974 RID: 137588
		[Token(Token = "0x4021974")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021975 RID: 137589
		[Token(Token = "0x4021975")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x04021976 RID: 137590
		[Token(Token = "0x4021976")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnJumpToCharSelectState;

		// Token: 0x04021977 RID: 137591
		[Token(Token = "0x4021977")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSquadItemClicked;

		// Token: 0x04021978 RID: 137592
		[Token(Token = "0x4021978")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnSquadBlockItemClicked;

		// Token: 0x04021979 RID: 137593
		[Token(Token = "0x4021979")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnRemoveCharDialogConfirmed;

		// Token: 0x0402197A RID: 137594
		[Token(Token = "0x402197A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryToOpenSelectCharState;

		// Token: 0x0402197B RID: 137595
		[Token(Token = "0x402197B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ReLoadDataAndRefresh;

		// Token: 0x0402197C RID: 137596
		[Token(Token = "0x402197C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryRaiseTutorialSignal;

		// Token: 0x0402197D RID: 137597
		[Token(Token = "0x402197D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CoroutineTriggerTutorial;

		// Token: 0x0402197E RID: 137598
		[Token(Token = "0x402197E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402197F RID: 137599
		[Token(Token = "0x402197F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
