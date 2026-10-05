using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CE2 RID: 23778
	[Token(Token = "0x2005CE2")]
	public class ClimbTowerBuffSelectState : PopupFadeState
	{
		// Token: 0x060226BB RID: 140987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60226BB")]
		[Address(RVA = "0x1CCDE20", Offset = "0x1CCCA20", VA = "0x181CCDE20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060226BC RID: 140988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226BC")]
		[Address(RVA = "0x1CCE110", Offset = "0x1CCCD10", VA = "0x181CCE110", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060226BD RID: 140989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226BD")]
		[Address(RVA = "0x1CCECC0", Offset = "0x1CCD8C0", VA = "0x181CCECC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060226BE RID: 140990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226BE")]
		[Address(RVA = "0x1CCE660", Offset = "0x1CCD260", VA = "0x181CCE660", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060226BF RID: 140991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226BF")]
		[Address(RVA = "0x1CCE5F0", Offset = "0x1CCD1F0", VA = "0x181CCE5F0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x060226C0 RID: 140992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226C0")]
		[Address(RVA = "0x1CCF230", Offset = "0x1CCDE30", VA = "0x181CCF230")]
		private void _OnBuffTabToggle(ProfessionCategory profession)
		{
		}

		// Token: 0x060226C1 RID: 140993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226C1")]
		[Address(RVA = "0x1CCE880", Offset = "0x1CCD480", VA = "0x181CCE880")]
		private void _OpenCreateSquadState()
		{
		}

		// Token: 0x060226C2 RID: 140994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60226C2")]
		[Address(RVA = "0x1CCE9C0", Offset = "0x1CCD5C0", VA = "0x181CCE9C0")]
		private TowerTactical _GenerateTactical()
		{
			return null;
		}

		// Token: 0x060226C3 RID: 140995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226C3")]
		[Address(RVA = "0x1CCE910", Offset = "0x1CCD510", VA = "0x181CCE910")]
		private void _NavToLayerState()
		{
		}

		// Token: 0x060226C4 RID: 140996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226C4")]
		[Address(RVA = "0x1CCF560", Offset = "0x1CCE160", VA = "0x181CCF560")]
		private void _SendSettleGameRequest()
		{
		}

		// Token: 0x060226C5 RID: 140997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226C5")]
		[Address(RVA = "0x1CCF820", Offset = "0x1CCE420", VA = "0x181CCF820")]
		private void _TriggerTutorialCoroutine()
		{
		}

		// Token: 0x060226C6 RID: 140998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226C6")]
		[Address(RVA = "0x1CCF770", Offset = "0x1CCE370", VA = "0x181CCF770")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x060226C7 RID: 140999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60226C7")]
		[Address(RVA = "0x1CCF950", Offset = "0x1CCE550", VA = "0x181CCF950")]
		private IEnumerator _WaitAndTrigTutorial()
		{
			return null;
		}

		// Token: 0x060226C8 RID: 141000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226C8")]
		[Address(RVA = "0x1CCEEF0", Offset = "0x1CCDAF0", VA = "0x181CCEEF0")]
		private void _OnBtnConfirm()
		{
		}

		// Token: 0x060226C9 RID: 141001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226C9")]
		[Address(RVA = "0x1CCE560", Offset = "0x1CCD160", VA = "0x181CCE560")]
		public void OnOpenPlanState()
		{
		}

		// Token: 0x060226CA RID: 141002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226CA")]
		[Address(RVA = "0x1CCDE80", Offset = "0x1CCCA80", VA = "0x181CCDE80")]
		public void OnBtnQuit()
		{
		}

		// Token: 0x060226CB RID: 141003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226CB")]
		[Address(RVA = "0x1CCFA00", Offset = "0x1CCE600", VA = "0x181CCFA00")]
		public ClimbTowerBuffSelectState()
		{
		}

		// Token: 0x060226CE RID: 141006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226CE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060226CF RID: 141007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226CF")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060226D0 RID: 141008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226D0")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0402F501 RID: 193793
		[Token(Token = "0x402F501")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerBuffSelectView _view;

		// Token: 0x0402F502 RID: 193794
		[Token(Token = "0x402F502")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402F503 RID: 193795
		[Token(Token = "0x402F503")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ClimbTowerMenuButton _menuButtonPrefab;

		// Token: 0x0402F504 RID: 193796
		[Token(Token = "0x402F504")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerBuffSelectStateBean m_stateBean;

		// Token: 0x0402F505 RID: 193797
		[Token(Token = "0x402F505")]
		[FieldOffset(Offset = "0x90")]
		private ClimbTowerBuffSelectState.MenuAdapter m_menuAdapter;

		// Token: 0x0402F506 RID: 193798
		[Token(Token = "0x402F506")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402F507 RID: 193799
		[Token(Token = "0x402F507")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0402F508 RID: 193800
		[Token(Token = "0x402F508")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F509 RID: 193801
		[Token(Token = "0x402F509")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F50A RID: 193802
		[Token(Token = "0x402F50A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F50B RID: 193803
		[Token(Token = "0x402F50B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F50C RID: 193804
		[Token(Token = "0x402F50C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402F50D RID: 193805
		[Token(Token = "0x402F50D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBuffTabToggle;

		// Token: 0x0402F50E RID: 193806
		[Token(Token = "0x402F50E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OpenCreateSquadState;

		// Token: 0x0402F50F RID: 193807
		[Token(Token = "0x402F50F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateTactical;

		// Token: 0x0402F510 RID: 193808
		[Token(Token = "0x402F510")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__NavToLayerState;

		// Token: 0x0402F511 RID: 193809
		[Token(Token = "0x402F511")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SendSettleGameRequest;

		// Token: 0x0402F512 RID: 193810
		[Token(Token = "0x402F512")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TriggerTutorialCoroutine;

		// Token: 0x0402F513 RID: 193811
		[Token(Token = "0x402F513")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402F514 RID: 193812
		[Token(Token = "0x402F514")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__WaitAndTrigTutorial;

		// Token: 0x0402F515 RID: 193813
		[Token(Token = "0x402F515")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnBtnConfirm;

		// Token: 0x0402F516 RID: 193814
		[Token(Token = "0x402F516")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnOpenPlanState;

		// Token: 0x0402F517 RID: 193815
		[Token(Token = "0x402F517")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnBtnQuit;

		// Token: 0x0402F518 RID: 193816
		[Token(Token = "0x402F518")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CE3 RID: 23779
		[Token(Token = "0x2005CE3")]
		private class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x060226D1 RID: 141009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226D1")]
			[Address(RVA = "0x1CDE340", Offset = "0x1CDCF40", VA = "0x181CDE340")]
			public MenuAdapter(ClimbTowerBuffSelectState closure)
			{
			}

			// Token: 0x170050E8 RID: 20712
			// (get) Token: 0x060226D2 RID: 141010 RVA: 0x000BD558 File Offset: 0x000BB758
			[Token(Token = "0x170050E8")]
			public override bool showMenu
			{
				[Token(Token = "0x60226D2")]
				[Address(RVA = "0x1CDE580", Offset = "0x1CDD180", VA = "0x181CDE580", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170050E9 RID: 20713
			// (get) Token: 0x060226D3 RID: 141011 RVA: 0x000BD570 File Offset: 0x000BB770
			[Token(Token = "0x170050E9")]
			public override bool hideBuffBtnWithHolder
			{
				[Token(Token = "0x60226D3")]
				[Address(RVA = "0x1CDE520", Offset = "0x1CDD120", VA = "0x181CDE520", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170050EA RID: 20714
			// (get) Token: 0x060226D4 RID: 141012 RVA: 0x000BD588 File Offset: 0x000BB788
			[Token(Token = "0x170050EA")]
			public override bool showSquadBtn
			{
				[Token(Token = "0x60226D4")]
				[Address(RVA = "0x1CDE640", Offset = "0x1CDD240", VA = "0x181CDE640", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170050EB RID: 20715
			// (get) Token: 0x060226D5 RID: 141013 RVA: 0x000BD5A0 File Offset: 0x000BB7A0
			[Token(Token = "0x170050EB")]
			public override bool showProfessionBtns
			{
				[Token(Token = "0x60226D5")]
				[Address(RVA = "0x1CDE5E0", Offset = "0x1CDD1E0", VA = "0x181CDE5E0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170050EC RID: 20716
			// (get) Token: 0x060226D6 RID: 141014 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170050EC")]
			public override ClimbTowerMenuButton buttonPrefab
			{
				[Token(Token = "0x60226D6")]
				[Address(RVA = "0x1CDE4B0", Offset = "0x1CDD0B0", VA = "0x181CDE4B0", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x170050ED RID: 20717
			// (get) Token: 0x060226D7 RID: 141015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170050ED")]
			public override Action buttonCallback
			{
				[Token(Token = "0x60226D7")]
				[Address(RVA = "0x1CDE400", Offset = "0x1CDD000", VA = "0x181CDE400", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x060226D8 RID: 141016 RVA: 0x000BD5B8 File Offset: 0x000BB7B8
			[Token(Token = "0x60226D8")]
			[Address(RVA = "0x1CD20F0", Offset = "0x1CD0CF0", VA = "0x181CD20F0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x060226D9 RID: 141017 RVA: 0x000BD5D0 File Offset: 0x000BB7D0
			[Token(Token = "0x60226D9")]
			[Address(RVA = "0x1CD1F10", Offset = "0x1CD0B10", VA = "0x181CD1F10")]
			private bool <>xLuaBaseProxy_get_hideBuffBtnWithHolder()
			{
				return default(bool);
			}

			// Token: 0x060226DA RID: 141018 RVA: 0x000BD5E8 File Offset: 0x000BB7E8
			[Token(Token = "0x60226DA")]
			[Address(RVA = "0x1CD21B0", Offset = "0x1CD0DB0", VA = "0x181CD21B0")]
			private bool <>xLuaBaseProxy_get_showSquadBtn()
			{
				return default(bool);
			}

			// Token: 0x060226DB RID: 141019 RVA: 0x000BD600 File Offset: 0x000BB800
			[Token(Token = "0x60226DB")]
			[Address(RVA = "0x1CD2150", Offset = "0x1CD0D50", VA = "0x181CD2150")]
			private bool <>xLuaBaseProxy_get_showProfessionBtns()
			{
				return default(bool);
			}

			// Token: 0x060226DC RID: 141020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60226DC")]
			[Address(RVA = "0x1CD1EB0", Offset = "0x1CD0AB0", VA = "0x181CD1EB0")]
			private ClimbTowerMenuButton <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x060226DD RID: 141021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60226DD")]
			[Address(RVA = "0x1CD1DF0", Offset = "0x1CD09F0", VA = "0x181CD1DF0")]
			private Action <>xLuaBaseProxy_get_buttonCallback()
			{
				return null;
			}

			// Token: 0x0402F519 RID: 193817
			[Token(Token = "0x402F519")]
			[FieldOffset(Offset = "0x18")]
			private ClimbTowerBuffSelectState m_closure;

			// Token: 0x0402F51A RID: 193818
			[Token(Token = "0x402F51A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F51B RID: 193819
			[Token(Token = "0x402F51B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402F51C RID: 193820
			[Token(Token = "0x402F51C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_hideBuffBtnWithHolder;

			// Token: 0x0402F51D RID: 193821
			[Token(Token = "0x402F51D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_showSquadBtn;

			// Token: 0x0402F51E RID: 193822
			[Token(Token = "0x402F51E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_showProfessionBtns;

			// Token: 0x0402F51F RID: 193823
			[Token(Token = "0x402F51F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x0402F520 RID: 193824
			[Token(Token = "0x402F520")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_buttonCallback;
		}
	}
}
