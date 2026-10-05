using System;
using Il2CppDummyDll;
using Torappu.Battle.UI.HalfIdle;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200329C RID: 12956
	[Token(Token = "0x200329C")]
	public class HalfIdleUIBuildTrapState : UIStateNode
	{
		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x06014926 RID: 84262 RVA: 0x000877B0 File Offset: 0x000859B0
		[Token(Token = "0x170030AC")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014926")]
			[Address(RVA = "0xCD1AB0", Offset = "0xCD06B0", VA = "0x180CD1AB0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x06014927 RID: 84263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030AD")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x6014927")]
			[Address(RVA = "0xCD16A0", Offset = "0xCD02A0", VA = "0x180CD16A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x06014928 RID: 84264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030AE")]
		private UICardList cardList
		{
			[Token(Token = "0x6014928")]
			[Address(RVA = "0xCD1620", Offset = "0xCD0220", VA = "0x180CD1620")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x06014929 RID: 84265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030AF")]
		private UIDirectionSelector directionSelector
		{
			[Token(Token = "0x6014929")]
			[Address(RVA = "0xCD1720", Offset = "0xCD0320", VA = "0x180CD1720")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x0601492A RID: 84266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030B0")]
		private Transform dragPlane
		{
			[Token(Token = "0x601492A")]
			[Address(RVA = "0xCD17A0", Offset = "0xCD03A0", VA = "0x180CD17A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0601492B RID: 84267 RVA: 0x000877C8 File Offset: 0x000859C8
		[Token(Token = "0x170030B1")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x601492B")]
			[Address(RVA = "0xCD18E0", Offset = "0xCD04E0", VA = "0x180CD18E0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0601492C RID: 84268 RVA: 0x000877E0 File Offset: 0x000859E0
		[Token(Token = "0x170030B2")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x601492C")]
			[Address(RVA = "0xCD1880", Offset = "0xCD0480", VA = "0x180CD1880", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0601492D RID: 84269 RVA: 0x000877F8 File Offset: 0x000859F8
		[Token(Token = "0x170030B3")]
		public override bool enableCameraDrag
		{
			[Token(Token = "0x601492D")]
			[Address(RVA = "0xCD1820", Offset = "0xCD0420", VA = "0x180CD1820", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x0601492E RID: 84270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030B4")]
		private HalfIdleUIPlugin uiPlugin
		{
			[Token(Token = "0x601492E")]
			[Address(RVA = "0xCD1940", Offset = "0xCD0540", VA = "0x180CD1940")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601492F RID: 84271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601492F")]
		[Address(RVA = "0xCD0AA0", Offset = "0xCCF6A0", VA = "0x180CD0AA0")]
		private void _OnCardToggled(object arg)
		{
		}

		// Token: 0x06014930 RID: 84272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014930")]
		[Address(RVA = "0xCD1130", Offset = "0xCCFD30", VA = "0x180CD1130")]
		private void _OnTileClicked(Tile tile)
		{
		}

		// Token: 0x06014931 RID: 84273 RVA: 0x00087810 File Offset: 0x00085A10
		[Token(Token = "0x6014931")]
		[Address(RVA = "0xCCFEF0", Offset = "0xCCEAF0", VA = "0x180CCFEF0")]
		private bool TryPutDownTrap(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06014932 RID: 84274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014932")]
		[Address(RVA = "0xCD0F80", Offset = "0xCCFB80", VA = "0x180CD0F80")]
		private void _OnDirectionSelected(bool selected, SharedConsts.Direction direction)
		{
		}

		// Token: 0x06014933 RID: 84275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014933")]
		[Address(RVA = "0xCD0960", Offset = "0xCCF560", VA = "0x180CD0960")]
		private void _MoveToMatch(Tile tile)
		{
		}

		// Token: 0x06014934 RID: 84276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014934")]
		[Address(RVA = "0xCD0780", Offset = "0xCCF380", VA = "0x180CD0780")]
		private void _ClearDummy()
		{
		}

		// Token: 0x06014935 RID: 84277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014935")]
		[Address(RVA = "0xCCFA60", Offset = "0xCCE660", VA = "0x180CCFA60", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014936 RID: 84278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014936")]
		[Address(RVA = "0xCCF400", Offset = "0xCCE000", VA = "0x180CCF400", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014937 RID: 84279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014937")]
		[Address(RVA = "0xCCFC10", Offset = "0xCCE810", VA = "0x180CCFC10", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014938 RID: 84280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014938")]
		[Address(RVA = "0xCCF830", Offset = "0xCCE430", VA = "0x180CCF830", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014939 RID: 84281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014939")]
		[Address(RVA = "0xCD15C0", Offset = "0xCD01C0", VA = "0x180CD15C0")]
		public HalfIdleUIBuildTrapState()
		{
		}

		// Token: 0x0601493B RID: 84283 RVA: 0x00087828 File Offset: 0x00085A28
		[Token(Token = "0x601493B")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0601493C RID: 84284 RVA: 0x00087840 File Offset: 0x00085A40
		[Token(Token = "0x601493C")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x0601493D RID: 84285 RVA: 0x00087858 File Offset: 0x00085A58
		[Token(Token = "0x601493D")]
		[Address(RVA = "0xCD0770", Offset = "0xCCF370", VA = "0x180CD0770")]
		private bool <>xLuaBaseProxy_get_enableCameraDrag()
		{
			return default(bool);
		}

		// Token: 0x0601493E RID: 84286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601493E")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x0601493F RID: 84287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601493F")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014940 RID: 84288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014940")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04018577 RID: 99703
		[Token(Token = "0x4018577")]
		private const string TRAP_BUILDING_STATE = "TRAP_BUILDING_STATE";

		// Token: 0x04018578 RID: 99704
		[Token(Token = "0x4018578")]
		[FieldOffset(Offset = "0x20")]
		private Character m_dummy;

		// Token: 0x04018579 RID: 99705
		[Token(Token = "0x4018579")]
		[FieldOffset(Offset = "0x28")]
		private Tile m_currentTile;

		// Token: 0x0401857A RID: 99706
		[Token(Token = "0x401857A")]
		[FieldOffset(Offset = "0x30")]
		private Deck.Card m_card;

		// Token: 0x0401857B RID: 99707
		[Token(Token = "0x401857B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0401857C RID: 99708
		[Token(Token = "0x401857C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x0401857D RID: 99709
		[Token(Token = "0x401857D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cardList;

		// Token: 0x0401857E RID: 99710
		[Token(Token = "0x401857E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_directionSelector;

		// Token: 0x0401857F RID: 99711
		[Token(Token = "0x401857F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_dragPlane;

		// Token: 0x04018580 RID: 99712
		[Token(Token = "0x4018580")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018581 RID: 99713
		[Token(Token = "0x4018581")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x04018582 RID: 99714
		[Token(Token = "0x4018582")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_enableCameraDrag;

		// Token: 0x04018583 RID: 99715
		[Token(Token = "0x4018583")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_uiPlugin;

		// Token: 0x04018584 RID: 99716
		[Token(Token = "0x4018584")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCardToggled;

		// Token: 0x04018585 RID: 99717
		[Token(Token = "0x4018585")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTileClicked;

		// Token: 0x04018586 RID: 99718
		[Token(Token = "0x4018586")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryPutDownTrap;

		// Token: 0x04018587 RID: 99719
		[Token(Token = "0x4018587")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnDirectionSelected;

		// Token: 0x04018588 RID: 99720
		[Token(Token = "0x4018588")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__MoveToMatch;

		// Token: 0x04018589 RID: 99721
		[Token(Token = "0x4018589")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ClearDummy;

		// Token: 0x0401858A RID: 99722
		[Token(Token = "0x401858A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401858B RID: 99723
		[Token(Token = "0x401858B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401858C RID: 99724
		[Token(Token = "0x401858C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401858D RID: 99725
		[Token(Token = "0x401858D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401858E RID: 99726
		[Token(Token = "0x401858E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
