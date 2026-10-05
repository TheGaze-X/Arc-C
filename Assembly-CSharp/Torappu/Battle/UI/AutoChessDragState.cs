using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032A4 RID: 12964
	[Token(Token = "0x20032A4")]
	public class AutoChessDragState : UIStateNode
	{
		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x06014982 RID: 84354 RVA: 0x00087A50 File Offset: 0x00085C50
		[Token(Token = "0x170030C3")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014982")]
			[Address(RVA = "0xCCAEC0", Offset = "0xCC9AC0", VA = "0x180CCAEC0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x06014983 RID: 84355 RVA: 0x00087A68 File Offset: 0x00085C68
		[Token(Token = "0x170030C4")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6014983")]
			[Address(RVA = "0xCCAB60", Offset = "0xCC9760", VA = "0x180CCAB60", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x06014984 RID: 84356 RVA: 0x00087A80 File Offset: 0x00085C80
		[Token(Token = "0x170030C5")]
		public override bool enableBackpress
		{
			[Token(Token = "0x6014984")]
			[Address(RVA = "0xCCAB00", Offset = "0xCC9700", VA = "0x180CCAB00", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x06014985 RID: 84357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030C6")]
		private UIDirectionSelector directionSelector
		{
			[Token(Token = "0x6014985")]
			[Address(RVA = "0xCCAA00", Offset = "0xCC9600", VA = "0x180CCAA00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x06014986 RID: 84358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030C7")]
		private AutoChessDummyManager dummyManager
		{
			[Token(Token = "0x6014986")]
			[Address(RVA = "0xCCAA80", Offset = "0xCC9680", VA = "0x180CCAA80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x06014987 RID: 84359 RVA: 0x00087A98 File Offset: 0x00085C98
		[Token(Token = "0x170030C8")]
		private bool isGameModeStateValid
		{
			[Token(Token = "0x6014987")]
			[Address(RVA = "0xCCACD0", Offset = "0xCC98D0", VA = "0x180CCACD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x06014988 RID: 84360 RVA: 0x00087AB0 File Offset: 0x00085CB0
		[Token(Token = "0x170030C9")]
		private bool isDragInValid
		{
			[Token(Token = "0x6014988")]
			[Address(RVA = "0xCCABC0", Offset = "0xCC97C0", VA = "0x180CCABC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x06014989 RID: 84361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030CA")]
		private AutoChessUIPlugin uiPlugin
		{
			[Token(Token = "0x6014989")]
			[Address(RVA = "0xCCAD70", Offset = "0xCC9970", VA = "0x180CCAD70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601498A RID: 84362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601498A")]
		[Address(RVA = "0xCC72D0", Offset = "0xCC5ED0", VA = "0x180CC72D0", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x0601498B RID: 84363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601498B")]
		[Address(RVA = "0xCC6B00", Offset = "0xCC5700", VA = "0x180CC6B00", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0601498C RID: 84364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601498C")]
		[Address(RVA = "0xCC7790", Offset = "0xCC6390", VA = "0x180CC7790", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601498D RID: 84365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601498D")]
		[Address(RVA = "0xCC6D70", Offset = "0xCC5970", VA = "0x180CC6D70", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0601498E RID: 84366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601498E")]
		[Address(RVA = "0xCC6A30", Offset = "0xCC5630", VA = "0x180CC6A30")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601498F RID: 84367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601498F")]
		[Address(RVA = "0xCCA680", Offset = "0xCC9280", VA = "0x180CCA680")]
		public IEnumerator _Update()
		{
			return null;
		}

		// Token: 0x06014990 RID: 84368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014990")]
		[Address(RVA = "0xCC8CE0", Offset = "0xCC78E0", VA = "0x180CC8CE0")]
		private void _DoOperation()
		{
		}

		// Token: 0x06014991 RID: 84369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014991")]
		[Address(RVA = "0xCC92B0", Offset = "0xCC7EB0", VA = "0x180CC92B0")]
		private void _OnBottomMaskBeginDrag(object arg)
		{
		}

		// Token: 0x06014992 RID: 84370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014992")]
		[Address(RVA = "0xCC8BC0", Offset = "0xCC77C0", VA = "0x180CC8BC0")]
		private void _DoOnButtomMaskBeginDrag(object arg)
		{
		}

		// Token: 0x06014993 RID: 84371 RVA: 0x00087AC8 File Offset: 0x00085CC8
		[Token(Token = "0x6014993")]
		[Address(RVA = "0xCC8860", Offset = "0xCC7460", VA = "0x180CC8860")]
		private bool _DoOnButtomMaskBeginDrag(PointerEventData pointerData)
		{
			return default(bool);
		}

		// Token: 0x06014994 RID: 84372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014994")]
		[Address(RVA = "0xCC94B0", Offset = "0xCC80B0", VA = "0x180CC94B0")]
		private void _OnDirectionSelected(bool selected, SharedConsts.Direction direction)
		{
		}

		// Token: 0x06014995 RID: 84373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014995")]
		[Address(RVA = "0xCC8ED0", Offset = "0xCC7AD0", VA = "0x180CC8ED0")]
		private void _EquipCharacter()
		{
		}

		// Token: 0x06014996 RID: 84374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014996")]
		[Address(RVA = "0xCC85A0", Offset = "0xCC71A0", VA = "0x180CC85A0")]
		private void _DoEquip()
		{
		}

		// Token: 0x06014997 RID: 84375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014997")]
		[Address(RVA = "0xCC8D80", Offset = "0xCC7980", VA = "0x180CC8D80")]
		private void _DoReplaceEquip()
		{
		}

		// Token: 0x06014998 RID: 84376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014998")]
		[Address(RVA = "0xCCA730", Offset = "0xCC9330", VA = "0x180CCA730")]
		private void _UseMagic(SharedConsts.Direction direction)
		{
		}

		// Token: 0x06014999 RID: 84377 RVA: 0x00087AE0 File Offset: 0x00085CE0
		[Token(Token = "0x6014999")]
		[Address(RVA = "0xCC7A10", Offset = "0xCC6610", VA = "0x180CC7A10")]
		private bool _CheckDummyBuildable(Tile tile, Tile beginTile, ChessInst chessInst, Character dummy)
		{
			return default(bool);
		}

		// Token: 0x0601499A RID: 84378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601499A")]
		[Address(RVA = "0xCC8220", Offset = "0xCC6E20", VA = "0x180CC8220")]
		private void _CreateOutline()
		{
		}

		// Token: 0x0601499B RID: 84379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601499B")]
		[Address(RVA = "0xCC7FF0", Offset = "0xCC6BF0", VA = "0x180CC7FF0")]
		private void _ClearOutline()
		{
		}

		// Token: 0x0601499C RID: 84380 RVA: 0x00087AF8 File Offset: 0x00085CF8
		[Token(Token = "0x601499C")]
		[Address(RVA = "0xCC78B0", Offset = "0xCC64B0", VA = "0x180CC78B0")]
		private bool _CheckBuildable(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0601499D RID: 84381 RVA: 0x00087B10 File Offset: 0x00085D10
		[Token(Token = "0x601499D")]
		[Address(RVA = "0xCC7950", Offset = "0xCC6550", VA = "0x180CC7950")]
		private bool _CheckBuildable(Tile begin, Tile current)
		{
			return default(bool);
		}

		// Token: 0x0601499E RID: 84382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601499E")]
		[Address(RVA = "0xCCA5D0", Offset = "0xCC91D0", VA = "0x180CCA5D0")]
		private void _UpdateInternal()
		{
		}

		// Token: 0x0601499F RID: 84383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601499F")]
		[Address(RVA = "0xCCA1B0", Offset = "0xCC8DB0", VA = "0x180CCA1B0")]
		private void _UpdateCharacterInfo()
		{
		}

		// Token: 0x060149A0 RID: 84384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149A0")]
		[Address(RVA = "0xCC9880", Offset = "0xCC8480", VA = "0x180CC9880")]
		private void _ResetCharacterInfo()
		{
		}

		// Token: 0x060149A1 RID: 84385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149A1")]
		[Address(RVA = "0xCC7F50", Offset = "0xCC6B50", VA = "0x180CC7F50")]
		private void _ClearDummy()
		{
		}

		// Token: 0x060149A2 RID: 84386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149A2")]
		[Address(RVA = "0xCC9B40", Offset = "0xCC8740", VA = "0x180CC9B40")]
		private void _TryMoveToNextState()
		{
		}

		// Token: 0x060149A3 RID: 84387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149A3")]
		[Address(RVA = "0xCC9A50", Offset = "0xCC8650", VA = "0x180CC9A50")]
		private void _SwitchToDefaultState()
		{
		}

		// Token: 0x060149A4 RID: 84388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149A4")]
		[Address(RVA = "0xCC8420", Offset = "0xCC7020", VA = "0x180CC8420")]
		private void _DoBattleOverlap(Character overlapCharacter)
		{
		}

		// Token: 0x060149A5 RID: 84389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149A5")]
		[Address(RVA = "0xCC9910", Offset = "0xCC8510", VA = "0x180CC9910")]
		private void _RevertBattleOverlap(Character currentCharacter)
		{
		}

		// Token: 0x060149A6 RID: 84390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149A6")]
		[Address(RVA = "0xCCA890", Offset = "0xCC9490", VA = "0x180CCA890")]
		public AutoChessDragState()
		{
		}

		// Token: 0x060149A7 RID: 84391 RVA: 0x00087B28 File Offset: 0x00085D28
		[Token(Token = "0x60149A7")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x060149A8 RID: 84392 RVA: 0x00087B40 File Offset: 0x00085D40
		[Token(Token = "0x60149A8")]
		[Address(RVA = "0x785E20", Offset = "0x784A20", VA = "0x180785E20")]
		private bool <>xLuaBaseProxy_get_enableBackpress()
		{
			return default(bool);
		}

		// Token: 0x060149A9 RID: 84393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149A9")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x060149AA RID: 84394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149AA")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060149AB RID: 84395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149AB")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x040185E6 RID: 99814
		[Token(Token = "0x40185E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _touchOffset;

		// Token: 0x040185E7 RID: 99815
		[Token(Token = "0x40185E7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _overlapOffset;

		// Token: 0x040185E8 RID: 99816
		[Token(Token = "0x40185E8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color _overlapColor;

		// Token: 0x040185E9 RID: 99817
		[Token(Token = "0x40185E9")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _worldSnapLen;

		// Token: 0x040185EA RID: 99818
		[Token(Token = "0x40185EA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAutoChessDragEquipPanel _equipStatusPanel;

		// Token: 0x040185EB RID: 99819
		[Token(Token = "0x40185EB")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessUIPlugin m_uiPlugin;

		// Token: 0x040185EC RID: 99820
		[Token(Token = "0x40185EC")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessDragState.State m_state;

		// Token: 0x040185ED RID: 99821
		[Token(Token = "0x40185ED")]
		[FieldOffset(Offset = "0x60")]
		private Character m_outlineDummy;

		// Token: 0x040185EE RID: 99822
		[Token(Token = "0x40185EE")]
		[FieldOffset(Offset = "0x68")]
		private Color m_cacheOverlapDefaultColor;

		// Token: 0x040185EF RID: 99823
		[Token(Token = "0x40185EF")]
		[FieldOffset(Offset = "0x78")]
		private Color m_outlineDefaultColor;

		// Token: 0x040185F0 RID: 99824
		[Token(Token = "0x40185F0")]
		[FieldOffset(Offset = "0x88")]
		private bool m_needRevertBattleOverlap;

		// Token: 0x040185F1 RID: 99825
		[Token(Token = "0x40185F1")]
		[FieldOffset(Offset = "0x89")]
		private bool m_operationFinished;

		// Token: 0x040185F2 RID: 99826
		[Token(Token = "0x40185F2")]
		[FieldOffset(Offset = "0x90")]
		private UIAutoChessDragEquipPanel m_equipStatusPanel;

		// Token: 0x040185F3 RID: 99827
		[Token(Token = "0x40185F3")]
		[FieldOffset(Offset = "0x98")]
		private Tile m_currentTile;

		// Token: 0x040185F4 RID: 99828
		[Token(Token = "0x40185F4")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine m_dragUpdateCoroutine;

		// Token: 0x040185F5 RID: 99829
		[Token(Token = "0x40185F5")]
		[FieldOffset(Offset = "0xA8")]
		private AutoChessDragState.TileDragContext m_dragContext;

		// Token: 0x040185F6 RID: 99830
		[Token(Token = "0x40185F6")]
		[FieldOffset(Offset = "0xB0")]
		private TouchHandler<AutoChessDragState.TileDragContext> m_touchHandler;

		// Token: 0x040185F7 RID: 99831
		[Token(Token = "0x40185F7")]
		[FieldOffset(Offset = "0xB8")]
		private BattleDragOperationHandler m_handler;

		// Token: 0x040185F8 RID: 99832
		[Token(Token = "0x40185F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040185F9 RID: 99833
		[Token(Token = "0x40185F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x040185FA RID: 99834
		[Token(Token = "0x40185FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableBackpress;

		// Token: 0x040185FB RID: 99835
		[Token(Token = "0x40185FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_directionSelector;

		// Token: 0x040185FC RID: 99836
		[Token(Token = "0x40185FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_dummyManager;

		// Token: 0x040185FD RID: 99837
		[Token(Token = "0x40185FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isGameModeStateValid;

		// Token: 0x040185FE RID: 99838
		[Token(Token = "0x40185FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isDragInValid;

		// Token: 0x040185FF RID: 99839
		[Token(Token = "0x40185FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_uiPlugin;

		// Token: 0x04018600 RID: 99840
		[Token(Token = "0x4018600")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018601 RID: 99841
		[Token(Token = "0x4018601")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018602 RID: 99842
		[Token(Token = "0x4018602")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018603 RID: 99843
		[Token(Token = "0x4018603")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018604 RID: 99844
		[Token(Token = "0x4018604")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018605 RID: 99845
		[Token(Token = "0x4018605")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__Update;

		// Token: 0x04018606 RID: 99846
		[Token(Token = "0x4018606")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoOperation;

		// Token: 0x04018607 RID: 99847
		[Token(Token = "0x4018607")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnBottomMaskBeginDrag;

		// Token: 0x04018608 RID: 99848
		[Token(Token = "0x4018608")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DoOnButtomMaskBeginDrag;

		// Token: 0x04018609 RID: 99849
		[Token(Token = "0x4018609")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1__DoOnButtomMaskBeginDrag;

		// Token: 0x0401860A RID: 99850
		[Token(Token = "0x401860A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnDirectionSelected;

		// Token: 0x0401860B RID: 99851
		[Token(Token = "0x401860B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EquipCharacter;

		// Token: 0x0401860C RID: 99852
		[Token(Token = "0x401860C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DoEquip;

		// Token: 0x0401860D RID: 99853
		[Token(Token = "0x401860D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__DoReplaceEquip;

		// Token: 0x0401860E RID: 99854
		[Token(Token = "0x401860E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UseMagic;

		// Token: 0x0401860F RID: 99855
		[Token(Token = "0x401860F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CheckDummyBuildable;

		// Token: 0x04018610 RID: 99856
		[Token(Token = "0x4018610")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CreateOutline;

		// Token: 0x04018611 RID: 99857
		[Token(Token = "0x4018611")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ClearOutline;

		// Token: 0x04018612 RID: 99858
		[Token(Token = "0x4018612")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckBuildable;

		// Token: 0x04018613 RID: 99859
		[Token(Token = "0x4018613")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix1__CheckBuildable;

		// Token: 0x04018614 RID: 99860
		[Token(Token = "0x4018614")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__UpdateInternal;

		// Token: 0x04018615 RID: 99861
		[Token(Token = "0x4018615")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__UpdateCharacterInfo;

		// Token: 0x04018616 RID: 99862
		[Token(Token = "0x4018616")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ResetCharacterInfo;

		// Token: 0x04018617 RID: 99863
		[Token(Token = "0x4018617")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ClearDummy;

		// Token: 0x04018618 RID: 99864
		[Token(Token = "0x4018618")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__TryMoveToNextState;

		// Token: 0x04018619 RID: 99865
		[Token(Token = "0x4018619")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__SwitchToDefaultState;

		// Token: 0x0401861A RID: 99866
		[Token(Token = "0x401861A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__DoBattleOverlap;

		// Token: 0x0401861B RID: 99867
		[Token(Token = "0x401861B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__RevertBattleOverlap;

		// Token: 0x0401861C RID: 99868
		[Token(Token = "0x401861C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032A5 RID: 12965
		[Token(Token = "0x20032A5")]
		private enum State
		{
			// Token: 0x0401861E RID: 99870
			[Token(Token = "0x401861E")]
			NONE,
			// Token: 0x0401861F RID: 99871
			[Token(Token = "0x401861F")]
			DRAGGING,
			// Token: 0x04018620 RID: 99872
			[Token(Token = "0x4018620")]
			SELECTING_DIR
		}

		// Token: 0x020032A6 RID: 12966
		[Token(Token = "0x20032A6")]
		public class TileDragContext : SimpleDragContext
		{
			// Token: 0x060149AC RID: 84396 RVA: 0x00087B58 File Offset: 0x00085D58
			[Token(Token = "0x60149AC")]
			[Address(RVA = "0xCD6B20", Offset = "0xCD5720", VA = "0x180CD6B20", Slot = "14")]
			protected override bool DragBeginInternal(ValueBundle bundle)
			{
				return default(bool);
			}

			// Token: 0x060149AD RID: 84397 RVA: 0x00087B70 File Offset: 0x00085D70
			[Token(Token = "0x60149AD")]
			[Address(RVA = "0xCD7130", Offset = "0xCD5D30", VA = "0x180CD7130", Slot = "15")]
			protected override bool DragUpdateInternal()
			{
				return default(bool);
			}

			// Token: 0x060149AE RID: 84398 RVA: 0x00087B88 File Offset: 0x00085D88
			[Token(Token = "0x60149AE")]
			[Address(RVA = "0xCD7D10", Offset = "0xCD6910", VA = "0x180CD7D10")]
			private bool _IsBeginInstValid(ChessInst chessInst)
			{
				return default(bool);
			}

			// Token: 0x060149AF RID: 84399 RVA: 0x00087BA0 File Offset: 0x00085DA0
			[Token(Token = "0x60149AF")]
			[Address(RVA = "0xCD7DC0", Offset = "0xCD69C0", VA = "0x180CD7DC0")]
			private bool _IsDragPosValid(GridPosition pos)
			{
				return default(bool);
			}

			// Token: 0x060149B0 RID: 84400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60149B0")]
			[Address(RVA = "0xCD7B60", Offset = "0xCD6760", VA = "0x180CD7B60")]
			private Character _CreateDummy(ChessInst chessInst)
			{
				return null;
			}

			// Token: 0x060149B1 RID: 84401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60149B1")]
			[Address(RVA = "0xCD70D0", Offset = "0xCD5CD0", VA = "0x180CD70D0", Slot = "16")]
			protected override void DragClearInternal()
			{
			}

			// Token: 0x060149B2 RID: 84402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60149B2")]
			[Address(RVA = "0xCD7840", Offset = "0xCD6440", VA = "0x180CD7840")]
			public void Reset()
			{
			}

			// Token: 0x060149B3 RID: 84403 RVA: 0x00087BB8 File Offset: 0x00085DB8
			[Token(Token = "0x60149B3")]
			[Address(RVA = "0xCD7940", Offset = "0xCD6540", VA = "0x180CD7940")]
			private Vector2 _ConvertToScreenPos(Vector2 localPos, Vector2 offset, bool isInit = false)
			{
				return default(Vector2);
			}

			// Token: 0x060149B4 RID: 84404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60149B4")]
			[Address(RVA = "0xCD7E80", Offset = "0xCD6A80", VA = "0x180CD7E80")]
			public TileDragContext()
			{
			}

			// Token: 0x060149B5 RID: 84405 RVA: 0x00087BD0 File Offset: 0x00085DD0
			[Token(Token = "0x60149B5")]
			[Address(RVA = "0xCD78F0", Offset = "0xCD64F0", VA = "0x180CD78F0")]
			private bool <>xLuaBaseProxy_DragBeginInternal(ValueBundle P0)
			{
				return default(bool);
			}

			// Token: 0x060149B6 RID: 84406 RVA: 0x00087BE8 File Offset: 0x00085DE8
			[Token(Token = "0x60149B6")]
			[Address(RVA = "0xCD7930", Offset = "0xCD6530", VA = "0x180CD7930")]
			private bool <>xLuaBaseProxy_DragUpdateInternal()
			{
				return default(bool);
			}

			// Token: 0x060149B7 RID: 84407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60149B7")]
			[Address(RVA = "0xCD7920", Offset = "0xCD6520", VA = "0x180CD7920")]
			private void <>xLuaBaseProxy_DragClearInternal()
			{
			}

			// Token: 0x04018621 RID: 99873
			[Token(Token = "0x4018621")]
			private const float DRAG_UNHOOK_RADIUS_SQR = 0.7f;

			// Token: 0x04018622 RID: 99874
			[Token(Token = "0x4018622")]
			[FieldOffset(Offset = "0x18")]
			public Character dummy;

			// Token: 0x04018623 RID: 99875
			[Token(Token = "0x4018623")]
			[FieldOffset(Offset = "0x20")]
			public ChessInst currentInst;

			// Token: 0x04018624 RID: 99876
			[Token(Token = "0x4018624")]
			[FieldOffset(Offset = "0x28")]
			public AutoChessDragState.TileDragContext.Param param;

			// Token: 0x04018625 RID: 99877
			[Token(Token = "0x4018625")]
			[FieldOffset(Offset = "0x30")]
			public Tile beginTile;

			// Token: 0x04018626 RID: 99878
			[Token(Token = "0x4018626")]
			[FieldOffset(Offset = "0x38")]
			public Tile currentTile;

			// Token: 0x04018627 RID: 99879
			[Token(Token = "0x4018627")]
			[FieldOffset(Offset = "0x40")]
			public bool isDragging;

			// Token: 0x04018628 RID: 99880
			[Token(Token = "0x4018628")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DragBeginInternal;

			// Token: 0x04018629 RID: 99881
			[Token(Token = "0x4018629")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DragUpdateInternal;

			// Token: 0x0401862A RID: 99882
			[Token(Token = "0x401862A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__IsBeginInstValid;

			// Token: 0x0401862B RID: 99883
			[Token(Token = "0x401862B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__IsDragPosValid;

			// Token: 0x0401862C RID: 99884
			[Token(Token = "0x401862C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__CreateDummy;

			// Token: 0x0401862D RID: 99885
			[Token(Token = "0x401862D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_DragClearInternal;

			// Token: 0x0401862E RID: 99886
			[Token(Token = "0x401862E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0401862F RID: 99887
			[Token(Token = "0x401862F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__ConvertToScreenPos;

			// Token: 0x04018630 RID: 99888
			[Token(Token = "0x4018630")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020032A7 RID: 12967
			[Token(Token = "0x20032A7")]
			public class Param
			{
				// Token: 0x060149B8 RID: 84408 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60149B8")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x04018631 RID: 99889
				[Token(Token = "0x4018631")]
				[FieldOffset(Offset = "0x10")]
				public Vector2 touchOffset;

				// Token: 0x04018632 RID: 99890
				[Token(Token = "0x4018632")]
				[FieldOffset(Offset = "0x18")]
				public Vector3 overlapOffset;

				// Token: 0x04018633 RID: 99891
				[Token(Token = "0x4018633")]
				[FieldOffset(Offset = "0x28")]
				public Func<Tile, Tile, bool> needSnap;

				// Token: 0x04018634 RID: 99892
				[Token(Token = "0x4018634")]
				[FieldOffset(Offset = "0x30")]
				public float worldSnapLen;
			}
		}
	}
}
