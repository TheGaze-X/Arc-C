using System;
using Il2CppDummyDll;
using Torappu.Multiplayer;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003400 RID: 13312
	[Token(Token = "0x2003400")]
	public class UICooperatePinMarkState : UIStateNode
	{
		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0601542A RID: 87082 RVA: 0x0008AEB8 File Offset: 0x000890B8
		[Token(Token = "0x17003268")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x601542A")]
			[Address(RVA = "0xDBB120", Offset = "0xDB9D20", VA = "0x180DBB120", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0601542B RID: 87083 RVA: 0x0008AED0 File Offset: 0x000890D0
		[Token(Token = "0x17003269")]
		public override bool enablePause
		{
			[Token(Token = "0x601542B")]
			[Address(RVA = "0xDBAFA0", Offset = "0xDB9BA0", VA = "0x180DBAFA0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0601542C RID: 87084 RVA: 0x0008AEE8 File Offset: 0x000890E8
		[Token(Token = "0x1700326A")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x601542C")]
			[Address(RVA = "0xDBB0C0", Offset = "0xDB9CC0", VA = "0x180DBB0C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0601542D RID: 87085 RVA: 0x0008AF00 File Offset: 0x00089100
		[Token(Token = "0x1700326B")]
		public override bool enableShowRange
		{
			[Token(Token = "0x601542D")]
			[Address(RVA = "0xDBB060", Offset = "0xDB9C60", VA = "0x180DBB060", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0601542E RID: 87086 RVA: 0x0008AF18 File Offset: 0x00089118
		[Token(Token = "0x1700326C")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x601542E")]
			[Address(RVA = "0xDBB000", Offset = "0xDB9C00", VA = "0x180DBB000", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601542F RID: 87087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601542F")]
		[Address(RVA = "0xDB9BD0", Offset = "0xDB87D0", VA = "0x180DB9BD0")]
		private void _OnBeginDrag(object arg)
		{
		}

		// Token: 0x06015430 RID: 87088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015430")]
		[Address(RVA = "0xDB9E10", Offset = "0xDB8A10", VA = "0x180DB9E10")]
		private void _OnEndDrag(object arg)
		{
		}

		// Token: 0x06015431 RID: 87089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015431")]
		[Address(RVA = "0xDB9340", Offset = "0xDB7F40", VA = "0x180DB9340", Slot = "24")]
		public override void OnInit(UIStateEnum uiState, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06015432 RID: 87090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015432")]
		[Address(RVA = "0xDB8EB0", Offset = "0xDB7AB0", VA = "0x180DB8EB0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06015433 RID: 87091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015433")]
		[Address(RVA = "0xDB9720", Offset = "0xDB8320", VA = "0x180DB9720", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06015434 RID: 87092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015434")]
		[Address(RVA = "0xDB90F0", Offset = "0xDB7CF0", VA = "0x180DB90F0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06015435 RID: 87093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015435")]
		[Address(RVA = "0xDB98C0", Offset = "0xDB84C0", VA = "0x180DB98C0")]
		private void _ClearDummy()
		{
		}

		// Token: 0x06015436 RID: 87094 RVA: 0x0008AF30 File Offset: 0x00089130
		[Token(Token = "0x6015436")]
		[Address(RVA = "0xDBA8D0", Offset = "0xDB94D0", VA = "0x180DBA8D0")]
		private bool _TryGetScreenPos(out Vector2 screenPos)
		{
			return default(bool);
		}

		// Token: 0x06015437 RID: 87095 RVA: 0x0008AF48 File Offset: 0x00089148
		[Token(Token = "0x6015437")]
		[Address(RVA = "0xDB99C0", Offset = "0xDB85C0", VA = "0x180DB99C0")]
		private Vector2 _ConvertScreenPos(Vector2 screenPos)
		{
			return default(Vector2);
		}

		// Token: 0x06015438 RID: 87096 RVA: 0x0008AF60 File Offset: 0x00089160
		[Token(Token = "0x6015438")]
		[Address(RVA = "0xDB97E0", Offset = "0xDB83E0", VA = "0x180DB97E0")]
		private bool _CheckLocatable(Tile tile, Vector2 mapPos)
		{
			return default(bool);
		}

		// Token: 0x06015439 RID: 87097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015439")]
		[Address(RVA = "0xDB9A90", Offset = "0xDB8690", VA = "0x180DB9A90")]
		private void _MoveToMatch(Tile tile)
		{
		}

		// Token: 0x0601543A RID: 87098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601543A")]
		[Address(RVA = "0xDBAA30", Offset = "0xDB9630", VA = "0x180DBAA30")]
		private void _UpdateInternal()
		{
		}

		// Token: 0x0601543B RID: 87099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601543B")]
		[Address(RVA = "0xDBA020", Offset = "0xDB8C20", VA = "0x180DBA020")]
		private void _PutDownInternal(Tile tile)
		{
		}

		// Token: 0x0601543C RID: 87100 RVA: 0x0008AF78 File Offset: 0x00089178
		[Token(Token = "0x601543C")]
		[Address(RVA = "0xDBA600", Offset = "0xDB9200", VA = "0x180DBA600")]
		private bool _TileOutOfScreen()
		{
			return default(bool);
		}

		// Token: 0x0601543D RID: 87101 RVA: 0x0008AF90 File Offset: 0x00089190
		[Token(Token = "0x601543D")]
		[Address(RVA = "0xDB9F60", Offset = "0xDB8B60", VA = "0x180DB9F60")]
		private bool _PointInScreen(RectTransform screen, Vector2 localPos)
		{
			return default(bool);
		}

		// Token: 0x0601543E RID: 87102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601543E")]
		[Address(RVA = "0xDB9D60", Offset = "0xDB8960", VA = "0x180DB9D60")]
		private void _OnBottomMaskClicked(object arg)
		{
		}

		// Token: 0x0601543F RID: 87103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601543F")]
		[Address(RVA = "0xDBA350", Offset = "0xDB8F50", VA = "0x180DBA350")]
		private void _SendPinMark(PinType type, Tile tile)
		{
		}

		// Token: 0x06015440 RID: 87104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015440")]
		[Address(RVA = "0xDBAEF0", Offset = "0xDB9AF0", VA = "0x180DBAEF0")]
		public UICooperatePinMarkState()
		{
		}

		// Token: 0x06015441 RID: 87105 RVA: 0x0008AFA8 File Offset: 0x000891A8
		[Token(Token = "0x6015441")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06015442 RID: 87106 RVA: 0x0008AFC0 File Offset: 0x000891C0
		[Token(Token = "0x6015442")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015443 RID: 87107 RVA: 0x0008AFD8 File Offset: 0x000891D8
		[Token(Token = "0x6015443")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06015444 RID: 87108 RVA: 0x0008AFF0 File Offset: 0x000891F0
		[Token(Token = "0x6015444")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06015445 RID: 87109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015445")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06015446 RID: 87110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015446")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06015447 RID: 87111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015447")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04019670 RID: 104048
		[Token(Token = "0x4019670")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICooperateBattlePinMarkMenu _pinMarkMenu;

		// Token: 0x04019671 RID: 104049
		[Token(Token = "0x4019671")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _tileLocateRadius;

		// Token: 0x04019672 RID: 104050
		[Token(Token = "0x4019672")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 _touchOffset;

		// Token: 0x04019673 RID: 104051
		[Token(Token = "0x4019673")]
		[FieldOffset(Offset = "0x34")]
		private UICooperatePinMarkState.State m_state;

		// Token: 0x04019674 RID: 104052
		[Token(Token = "0x4019674")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_dummy;

		// Token: 0x04019675 RID: 104053
		[Token(Token = "0x4019675")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_dragPlane;

		// Token: 0x04019676 RID: 104054
		[Token(Token = "0x4019676")]
		[FieldOffset(Offset = "0x48")]
		private Tile m_currentTile;

		// Token: 0x04019677 RID: 104055
		[Token(Token = "0x4019677")]
		[FieldOffset(Offset = "0x50")]
		private UICooperateBattlePinMarkMenu m_pinMarkMenu;

		// Token: 0x04019678 RID: 104056
		[Token(Token = "0x4019678")]
		[FieldOffset(Offset = "0x58")]
		private UICooperatePinMarkCard m_pinMarkCard;

		// Token: 0x04019679 RID: 104057
		[Token(Token = "0x4019679")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0401967A RID: 104058
		[Token(Token = "0x401967A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0401967B RID: 104059
		[Token(Token = "0x401967B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0401967C RID: 104060
		[Token(Token = "0x401967C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0401967D RID: 104061
		[Token(Token = "0x401967D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0401967E RID: 104062
		[Token(Token = "0x401967E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBeginDrag;

		// Token: 0x0401967F RID: 104063
		[Token(Token = "0x401967F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnEndDrag;

		// Token: 0x04019680 RID: 104064
		[Token(Token = "0x4019680")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04019681 RID: 104065
		[Token(Token = "0x4019681")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04019682 RID: 104066
		[Token(Token = "0x4019682")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04019683 RID: 104067
		[Token(Token = "0x4019683")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04019684 RID: 104068
		[Token(Token = "0x4019684")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ClearDummy;

		// Token: 0x04019685 RID: 104069
		[Token(Token = "0x4019685")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryGetScreenPos;

		// Token: 0x04019686 RID: 104070
		[Token(Token = "0x4019686")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ConvertScreenPos;

		// Token: 0x04019687 RID: 104071
		[Token(Token = "0x4019687")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckLocatable;

		// Token: 0x04019688 RID: 104072
		[Token(Token = "0x4019688")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__MoveToMatch;

		// Token: 0x04019689 RID: 104073
		[Token(Token = "0x4019689")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateInternal;

		// Token: 0x0401968A RID: 104074
		[Token(Token = "0x401968A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__PutDownInternal;

		// Token: 0x0401968B RID: 104075
		[Token(Token = "0x401968B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TileOutOfScreen;

		// Token: 0x0401968C RID: 104076
		[Token(Token = "0x401968C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__PointInScreen;

		// Token: 0x0401968D RID: 104077
		[Token(Token = "0x401968D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnBottomMaskClicked;

		// Token: 0x0401968E RID: 104078
		[Token(Token = "0x401968E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SendPinMark;

		// Token: 0x0401968F RID: 104079
		[Token(Token = "0x401968F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003401 RID: 13313
		[Token(Token = "0x2003401")]
		private enum State
		{
			// Token: 0x04019691 RID: 104081
			[Token(Token = "0x4019691")]
			NONE,
			// Token: 0x04019692 RID: 104082
			[Token(Token = "0x4019692")]
			DRAGGING,
			// Token: 0x04019693 RID: 104083
			[Token(Token = "0x4019693")]
			SELECTING
		}
	}
}
