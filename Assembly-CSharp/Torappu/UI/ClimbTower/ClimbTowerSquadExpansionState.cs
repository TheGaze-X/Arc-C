using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D99 RID: 23961
	[Token(Token = "0x2005D99")]
	public class ClimbTowerSquadExpansionState : PopupFadeState
	{
		// Token: 0x06022BD7 RID: 142295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022BD7")]
		[Address(RVA = "0x1D38CB0", Offset = "0x1D378B0", VA = "0x181D38CB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022BD8 RID: 142296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BD8")]
		[Address(RVA = "0x1D39170", Offset = "0x1D37D70", VA = "0x181D39170", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022BD9 RID: 142297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BD9")]
		[Address(RVA = "0x1D395A0", Offset = "0x1D381A0", VA = "0x181D395A0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06022BDA RID: 142298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BDA")]
		[Address(RVA = "0x1D39680", Offset = "0x1D38280", VA = "0x181D39680", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022BDB RID: 142299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BDB")]
		[Address(RVA = "0x1D39610", Offset = "0x1D38210", VA = "0x181D39610", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06022BDC RID: 142300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BDC")]
		[Address(RVA = "0x1D3A090", Offset = "0x1D38C90", VA = "0x181D3A090")]
		private void _PlaySpawnAnim()
		{
		}

		// Token: 0x06022BDD RID: 142301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BDD")]
		[Address(RVA = "0x1D39850", Offset = "0x1D38450", VA = "0x181D39850")]
		private void _ClearAnimCoroutine()
		{
		}

		// Token: 0x06022BDE RID: 142302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022BDE")]
		[Address(RVA = "0x1D39FE0", Offset = "0x1D38BE0", VA = "0x181D39FE0")]
		private IEnumerator _PlaySpawnAnimCoro()
		{
			return null;
		}

		// Token: 0x06022BDF RID: 142303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BDF")]
		[Address(RVA = "0x1D39930", Offset = "0x1D38530", VA = "0x181D39930")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022BE0 RID: 142304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BE0")]
		[Address(RVA = "0x1D39D10", Offset = "0x1D38910", VA = "0x181D39D10")]
		private void _OnCharSelect(bool isGiveUp, string groupId, string charId)
		{
		}

		// Token: 0x06022BE1 RID: 142305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BE1")]
		[Address(RVA = "0x1D39E80", Offset = "0x1D38A80", VA = "0x181D39E80")]
		private void _OnConfirmCallBack()
		{
		}

		// Token: 0x06022BE2 RID: 142306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BE2")]
		[Address(RVA = "0x1D39AF0", Offset = "0x1D386F0", VA = "0x181D39AF0")]
		private void _NavToSquadState()
		{
		}

		// Token: 0x06022BE3 RID: 142307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BE3")]
		[Address(RVA = "0x1D3A350", Offset = "0x1D38F50", VA = "0x181D3A350")]
		private void _TriggerTutorialCoroutine()
		{
		}

		// Token: 0x06022BE4 RID: 142308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BE4")]
		[Address(RVA = "0x1D3A270", Offset = "0x1D38E70", VA = "0x181D3A270")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x06022BE5 RID: 142309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022BE5")]
		[Address(RVA = "0x1D3A580", Offset = "0x1D39180", VA = "0x181D3A580")]
		private IEnumerator _WaitForExpandAnimComplete()
		{
			return null;
		}

		// Token: 0x06022BE6 RID: 142310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022BE6")]
		[Address(RVA = "0x1D3A4D0", Offset = "0x1D390D0", VA = "0x181D3A4D0")]
		private IEnumerator _WaitAndTrigTutorial()
		{
			return null;
		}

		// Token: 0x06022BE7 RID: 142311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BE7")]
		[Address(RVA = "0x1D38D10", Offset = "0x1D37910", VA = "0x181D38D10")]
		public void OnBtnRecruit()
		{
		}

		// Token: 0x06022BE8 RID: 142312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BE8")]
		[Address(RVA = "0x1D3A1F0", Offset = "0x1D38DF0", VA = "0x181D3A1F0")]
		private void _RecordNewCharTrigger(string selectCharId)
		{
		}

		// Token: 0x06022BE9 RID: 142313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BE9")]
		[Address(RVA = "0x1D390E0", Offset = "0x1D37CE0", VA = "0x181D390E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06022BEA RID: 142314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BEA")]
		[Address(RVA = "0x1D3A630", Offset = "0x1D39230", VA = "0x181D3A630")]
		public ClimbTowerSquadExpansionState()
		{
		}

		// Token: 0x06022BEB RID: 142315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BEB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022BEC RID: 142316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BEC")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06022BED RID: 142317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BED")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06022BEE RID: 142318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BEE")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0402FC32 RID: 195634
		[Token(Token = "0x402FC32")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgBg;

		// Token: 0x0402FC33 RID: 195635
		[Token(Token = "0x402FC33")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerSquadExpansionView _view;

		// Token: 0x0402FC34 RID: 195636
		[Token(Token = "0x402FC34")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x0402FC35 RID: 195637
		[Token(Token = "0x402FC35")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerSquadExpansionStateBean m_stateBean;

		// Token: 0x0402FC36 RID: 195638
		[Token(Token = "0x402FC36")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0402FC37 RID: 195639
		[Token(Token = "0x402FC37")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine m_coroutine;

		// Token: 0x0402FC38 RID: 195640
		[Token(Token = "0x402FC38")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0402FC39 RID: 195641
		[Token(Token = "0x402FC39")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isAnim;

		// Token: 0x0402FC3A RID: 195642
		[Token(Token = "0x402FC3A")]
		[FieldOffset(Offset = "0xB0")]
		private ClimbTowerSquadExpansionState.MenuAdapter m_menuAdapter;

		// Token: 0x0402FC3B RID: 195643
		[Token(Token = "0x402FC3B")]
		[FieldOffset(Offset = "0xB8")]
		private UIPopupWindow.UIBlocker m_blocker;

		// Token: 0x0402FC3C RID: 195644
		[Token(Token = "0x402FC3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402FC3D RID: 195645
		[Token(Token = "0x402FC3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402FC3E RID: 195646
		[Token(Token = "0x402FC3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402FC3F RID: 195647
		[Token(Token = "0x402FC3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402FC40 RID: 195648
		[Token(Token = "0x402FC40")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402FC41 RID: 195649
		[Token(Token = "0x402FC41")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlaySpawnAnim;

		// Token: 0x0402FC42 RID: 195650
		[Token(Token = "0x402FC42")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearAnimCoroutine;

		// Token: 0x0402FC43 RID: 195651
		[Token(Token = "0x402FC43")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlaySpawnAnimCoro;

		// Token: 0x0402FC44 RID: 195652
		[Token(Token = "0x402FC44")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FC45 RID: 195653
		[Token(Token = "0x402FC45")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCharSelect;

		// Token: 0x0402FC46 RID: 195654
		[Token(Token = "0x402FC46")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnConfirmCallBack;

		// Token: 0x0402FC47 RID: 195655
		[Token(Token = "0x402FC47")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__NavToSquadState;

		// Token: 0x0402FC48 RID: 195656
		[Token(Token = "0x402FC48")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TriggerTutorialCoroutine;

		// Token: 0x0402FC49 RID: 195657
		[Token(Token = "0x402FC49")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402FC4A RID: 195658
		[Token(Token = "0x402FC4A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__WaitForExpandAnimComplete;

		// Token: 0x0402FC4B RID: 195659
		[Token(Token = "0x402FC4B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__WaitAndTrigTutorial;

		// Token: 0x0402FC4C RID: 195660
		[Token(Token = "0x402FC4C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBtnRecruit;

		// Token: 0x0402FC4D RID: 195661
		[Token(Token = "0x402FC4D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RecordNewCharTrigger;

		// Token: 0x0402FC4E RID: 195662
		[Token(Token = "0x402FC4E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402FC4F RID: 195663
		[Token(Token = "0x402FC4F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D9A RID: 23962
		[Token(Token = "0x2005D9A")]
		public class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x17005209 RID: 21001
			// (get) Token: 0x06022BEF RID: 142319 RVA: 0x000BEA40 File Offset: 0x000BCC40
			[Token(Token = "0x17005209")]
			public override bool showMenu
			{
				[Token(Token = "0x6022BEF")]
				[Address(RVA = "0x1D5DC60", Offset = "0x1D5C860", VA = "0x181D5DC60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06022BF0 RID: 142320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022BF0")]
			[Address(RVA = "0x1D5DC00", Offset = "0x1D5C800", VA = "0x181D5DC00")]
			public MenuAdapter()
			{
			}

			// Token: 0x06022BF1 RID: 142321 RVA: 0x000BEA58 File Offset: 0x000BCC58
			[Token(Token = "0x6022BF1")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x0402FC50 RID: 195664
			[Token(Token = "0x402FC50")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402FC51 RID: 195665
			[Token(Token = "0x402FC51")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
