using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032A9 RID: 12969
	[Token(Token = "0x20032A9")]
	public class AutoChessHighlightState : UIStateNode
	{
		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x060149BF RID: 84415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030CD")]
		private AutoChessUIPlugin uiPlugin
		{
			[Token(Token = "0x60149BF")]
			[Address(RVA = "0xCDD200", Offset = "0xCDBE00", VA = "0x180CDD200")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x060149C0 RID: 84416 RVA: 0x00087C18 File Offset: 0x00085E18
		[Token(Token = "0x170030CE")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60149C0")]
			[Address(RVA = "0xCDD350", Offset = "0xCDBF50", VA = "0x180CDD350", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x060149C1 RID: 84417 RVA: 0x00087C30 File Offset: 0x00085E30
		[Token(Token = "0x170030CF")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x60149C1")]
			[Address(RVA = "0xCDD0E0", Offset = "0xCDBCE0", VA = "0x180CDD0E0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x060149C2 RID: 84418 RVA: 0x00087C48 File Offset: 0x00085E48
		[Token(Token = "0x170030D0")]
		private bool isGameStatusStateValid
		{
			[Token(Token = "0x60149C2")]
			[Address(RVA = "0xCDD140", Offset = "0xCDBD40", VA = "0x180CDD140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060149C3 RID: 84419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149C3")]
		[Address(RVA = "0xCDC0F0", Offset = "0xCDACF0", VA = "0x180CDC0F0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x060149C4 RID: 84420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149C4")]
		[Address(RVA = "0xCDC320", Offset = "0xCDAF20", VA = "0x180CDC320", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060149C5 RID: 84421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149C5")]
		[Address(RVA = "0xCDBE80", Offset = "0xCDAA80", VA = "0x180CDBE80", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060149C6 RID: 84422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149C6")]
		[Address(RVA = "0xCDBF00", Offset = "0xCDAB00", VA = "0x180CDBF00", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x060149C7 RID: 84423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149C7")]
		[Address(RVA = "0xCDCB90", Offset = "0xCDB790", VA = "0x180CDCB90")]
		private void _RefreshRender()
		{
		}

		// Token: 0x060149C8 RID: 84424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149C8")]
		[Address(RVA = "0xCDCF40", Offset = "0xCDBB40", VA = "0x180CDCF40")]
		private void _SwitchToHighLight()
		{
		}

		// Token: 0x060149C9 RID: 84425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149C9")]
		[Address(RVA = "0xCDC600", Offset = "0xCDB200", VA = "0x180CDC600")]
		private void _OnButtomMaskBeginDrag(object arg)
		{
		}

		// Token: 0x060149CA RID: 84426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149CA")]
		[Address(RVA = "0xCDC970", Offset = "0xCDB570", VA = "0x180CDC970")]
		private void _OnTileClicked(object arg)
		{
		}

		// Token: 0x060149CB RID: 84427 RVA: 0x00087C60 File Offset: 0x00085E60
		[Token(Token = "0x60149CB")]
		[Address(RVA = "0xCDC710", Offset = "0xCDB310", VA = "0x180CDC710")]
		private bool _OnTileClicked(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060149CC RID: 84428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149CC")]
		[Address(RVA = "0xCDC400", Offset = "0xCDB000", VA = "0x180CDC400")]
		private void _OnBottomMaskClicked(object arg)
		{
		}

		// Token: 0x060149CD RID: 84429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149CD")]
		[Address(RVA = "0xCDCE50", Offset = "0xCDBA50", VA = "0x180CDCE50")]
		private void _SwitchToDefaultState()
		{
		}

		// Token: 0x060149CE RID: 84430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149CE")]
		[Address(RVA = "0xCDD080", Offset = "0xCDBC80", VA = "0x180CDD080")]
		public AutoChessHighlightState()
		{
		}

		// Token: 0x060149CF RID: 84431 RVA: 0x00087C78 File Offset: 0x00085E78
		[Token(Token = "0x60149CF")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x060149D0 RID: 84432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D0")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x060149D1 RID: 84433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D1")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060149D2 RID: 84434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149D2")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04018638 RID: 99896
		[Token(Token = "0x4018638")]
		[FieldOffset(Offset = "0x20")]
		private AutoChessUIPlugin m_uiPlugin;

		// Token: 0x04018639 RID: 99897
		[Token(Token = "0x4018639")]
		[FieldOffset(Offset = "0x28")]
		private ObjectPtr<Character> m_character;

		// Token: 0x0401863A RID: 99898
		[Token(Token = "0x401863A")]
		[FieldOffset(Offset = "0x38")]
		private Tile m_tile;

		// Token: 0x0401863B RID: 99899
		[Token(Token = "0x401863B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiPlugin;

		// Token: 0x0401863C RID: 99900
		[Token(Token = "0x401863C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0401863D RID: 99901
		[Token(Token = "0x401863D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0401863E RID: 99902
		[Token(Token = "0x401863E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isGameStatusStateValid;

		// Token: 0x0401863F RID: 99903
		[Token(Token = "0x401863F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018640 RID: 99904
		[Token(Token = "0x4018640")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018641 RID: 99905
		[Token(Token = "0x4018641")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018642 RID: 99906
		[Token(Token = "0x4018642")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018643 RID: 99907
		[Token(Token = "0x4018643")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshRender;

		// Token: 0x04018644 RID: 99908
		[Token(Token = "0x4018644")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SwitchToHighLight;

		// Token: 0x04018645 RID: 99909
		[Token(Token = "0x4018645")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnButtomMaskBeginDrag;

		// Token: 0x04018646 RID: 99910
		[Token(Token = "0x4018646")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnTileClicked;

		// Token: 0x04018647 RID: 99911
		[Token(Token = "0x4018647")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1__OnTileClicked;

		// Token: 0x04018648 RID: 99912
		[Token(Token = "0x4018648")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnBottomMaskClicked;

		// Token: 0x04018649 RID: 99913
		[Token(Token = "0x4018649")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SwitchToDefaultState;

		// Token: 0x0401864A RID: 99914
		[Token(Token = "0x401864A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
