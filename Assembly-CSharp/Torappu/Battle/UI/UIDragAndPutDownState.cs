using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003323 RID: 13091
	[Token(Token = "0x2003323")]
	public class UIDragAndPutDownState : UIStateNode
	{
		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x06014D21 RID: 85281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003154")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x6014D21")]
			[Address(RVA = "0xD4AC40", Offset = "0xD49840", VA = "0x180D4AC40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x06014D22 RID: 85282 RVA: 0x00088B18 File Offset: 0x00086D18
		[Token(Token = "0x17003155")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014D22")]
			[Address(RVA = "0xD4B040", Offset = "0xD49C40", VA = "0x180D4B040", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x06014D23 RID: 85283 RVA: 0x00088B30 File Offset: 0x00086D30
		[Token(Token = "0x17003156")]
		public UIDragAndPutDownState.State state
		{
			[Token(Token = "0x6014D23")]
			[Address(RVA = "0xD4AF80", Offset = "0xD49B80", VA = "0x180D4AF80")]
			get
			{
				return UIDragAndPutDownState.State.NONE;
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x06014D24 RID: 85284 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014D25 RID: 85285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003157")]
		public UICard uiCard
		{
			[Token(Token = "0x6014D24")]
			[Address(RVA = "0xD4AFE0", Offset = "0xD49BE0", VA = "0x180D4AFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6014D25")]
			[Address(RVA = "0xD4B120", Offset = "0xD49D20", VA = "0x180D4B120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x06014D26 RID: 85286 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014D27 RID: 85287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003158")]
		public Deck.Card card
		{
			[Token(Token = "0x6014D26")]
			[Address(RVA = "0xD4ABE0", Offset = "0xD497E0", VA = "0x180D4ABE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6014D27")]
			[Address(RVA = "0xD4B0A0", Offset = "0xD49CA0", VA = "0x180D4B0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x06014D28 RID: 85288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003159")]
		protected virtual UIDirectionSelector directionSelector
		{
			[Token(Token = "0x6014D28")]
			[Address(RVA = "0xD4ACC0", Offset = "0xD498C0", VA = "0x180D4ACC0", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x06014D29 RID: 85289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700315A")]
		protected Character dummy
		{
			[Token(Token = "0x6014D29")]
			[Address(RVA = "0xD4ADA0", Offset = "0xD499A0", VA = "0x180D4ADA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x06014D2A RID: 85290 RVA: 0x00088B48 File Offset: 0x00086D48
		[Token(Token = "0x1700315B")]
		public override bool enablePause
		{
			[Token(Token = "0x6014D2A")]
			[Address(RVA = "0xD4AE00", Offset = "0xD49A00", VA = "0x180D4AE00", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x06014D2B RID: 85291 RVA: 0x00088B60 File Offset: 0x00086D60
		[Token(Token = "0x1700315C")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014D2B")]
			[Address(RVA = "0xD4AF20", Offset = "0xD49B20", VA = "0x180D4AF20", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x06014D2C RID: 85292 RVA: 0x00088B78 File Offset: 0x00086D78
		[Token(Token = "0x1700315D")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014D2C")]
			[Address(RVA = "0xD4AEC0", Offset = "0xD49AC0", VA = "0x180D4AEC0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x06014D2D RID: 85293 RVA: 0x00088B90 File Offset: 0x00086D90
		[Token(Token = "0x1700315E")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6014D2D")]
			[Address(RVA = "0xD4AE60", Offset = "0xD49A60", VA = "0x180D4AE60", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x06014D2E RID: 85294 RVA: 0x00088BA8 File Offset: 0x00086DA8
		[Token(Token = "0x1700315F")]
		private bool dragDisabled
		{
			[Token(Token = "0x6014D2E")]
			[Address(RVA = "0xD4AD20", Offset = "0xD49920", VA = "0x180D4AD20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014D2F RID: 85295 RVA: 0x00088BC0 File Offset: 0x00086DC0
		[Token(Token = "0x6014D2F")]
		[Address(RVA = "0xD47A60", Offset = "0xD46660", VA = "0x180D47A60", Slot = "30")]
		protected virtual bool NeedPutDownCamera()
		{
			return default(bool);
		}

		// Token: 0x06014D30 RID: 85296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D30")]
		[Address(RVA = "0xD49360", Offset = "0xD47F60", VA = "0x180D49360")]
		protected void _OnBeginDrag(UICard uiCard)
		{
		}

		// Token: 0x06014D31 RID: 85297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D31")]
		[Address(RVA = "0xD49AC0", Offset = "0xD486C0", VA = "0x180D49AC0")]
		private void _OnEndDrag()
		{
		}

		// Token: 0x06014D32 RID: 85298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D32")]
		[Address(RVA = "0xD49740", Offset = "0xD48340", VA = "0x180D49740")]
		private void _OnBottomMaskClicked(object arg)
		{
		}

		// Token: 0x06014D33 RID: 85299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D33")]
		[Address(RVA = "0xD48210", Offset = "0xD46E10", VA = "0x180D48210", Slot = "24")]
		public override void OnInit(UIStateEnum uiState, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014D34 RID: 85300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D34")]
		[Address(RVA = "0xD47B20", Offset = "0xD46720", VA = "0x180D47B20", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014D35 RID: 85301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D35")]
		[Address(RVA = "0xD484D0", Offset = "0xD470D0", VA = "0x180D484D0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014D36 RID: 85302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D36")]
		[Address(RVA = "0xD48050", Offset = "0xD46C50", VA = "0x180D48050", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014D37 RID: 85303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D37")]
		[Address(RVA = "0xD48BA0", Offset = "0xD477A0", VA = "0x180D48BA0")]
		private void _ClearDummy()
		{
		}

		// Token: 0x06014D38 RID: 85304 RVA: 0x00088BD8 File Offset: 0x00086DD8
		[Token(Token = "0x6014D38")]
		[Address(RVA = "0xD48AC0", Offset = "0xD476C0", VA = "0x180D48AC0")]
		private bool _CheckLocatable(Tile tile, Vector2 mapPos)
		{
			return default(bool);
		}

		// Token: 0x06014D39 RID: 85305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D39")]
		[Address(RVA = "0xD49B20", Offset = "0xD48720", VA = "0x180D49B20")]
		private void _PutDownInternal(Tile tile)
		{
		}

		// Token: 0x06014D3A RID: 85306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D3A")]
		[Address(RVA = "0xD49FD0", Offset = "0xD48BD0", VA = "0x180D49FD0", Slot = "31")]
		protected virtual void _UpdateBuildableHighlight()
		{
		}

		// Token: 0x06014D3B RID: 85307 RVA: 0x00088BF0 File Offset: 0x00086DF0
		[Token(Token = "0x6014D3B")]
		[Address(RVA = "0xD49E20", Offset = "0xD48A20", VA = "0x180D49E20")]
		private bool _TryGetScreenPos(out Vector2 screenPos)
		{
			return default(bool);
		}

		// Token: 0x06014D3C RID: 85308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D3C")]
		[Address(RVA = "0xD4A2A0", Offset = "0xD48EA0", VA = "0x180D4A2A0")]
		private void _UpdateInternal()
		{
		}

		// Token: 0x06014D3D RID: 85309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D3D")]
		[Address(RVA = "0xD498D0", Offset = "0xD484D0", VA = "0x180D498D0")]
		private void _OnDirectionSelected(bool selected, SharedConsts.Direction direction)
		{
		}

		// Token: 0x06014D3E RID: 85310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D3E")]
		[Address(RVA = "0xD479D0", Offset = "0xD465D0", VA = "0x180D479D0", Slot = "32")]
		protected virtual void ExitDragState()
		{
		}

		// Token: 0x06014D3F RID: 85311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D3F")]
		[Address(RVA = "0xD47880", Offset = "0xD46480", VA = "0x180D47880", Slot = "33")]
		protected virtual void DisableUiCardIsOn(int nextState)
		{
		}

		// Token: 0x06014D40 RID: 85312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D40")]
		[Address(RVA = "0xD49220", Offset = "0xD47E20", VA = "0x180D49220")]
		private void _MoveToMatch(Tile tile)
		{
		}

		// Token: 0x06014D41 RID: 85313 RVA: 0x00088C08 File Offset: 0x00086E08
		[Token(Token = "0x6014D41")]
		[Address(RVA = "0xD48DA0", Offset = "0xD479A0", VA = "0x180D48DA0")]
		private Vector2 _ConvertScreenPos(Vector2 screenPos)
		{
			return default(Vector2);
		}

		// Token: 0x06014D42 RID: 85314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D42")]
		[Address(RVA = "0xD48E70", Offset = "0xD47A70", VA = "0x180D48E70")]
		protected void _EnableBuildableHighlight()
		{
		}

		// Token: 0x06014D43 RID: 85315 RVA: 0x00088C20 File Offset: 0x00086E20
		[Token(Token = "0x6014D43")]
		[Address(RVA = "0xD486F0", Offset = "0xD472F0", VA = "0x180D486F0")]
		private bool _CheckBuildable(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06014D44 RID: 85316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D44")]
		[Address(RVA = "0xD47AC0", Offset = "0xD466C0", VA = "0x180D47AC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014D45 RID: 85317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D45")]
		[Address(RVA = "0xD4AAB0", Offset = "0xD496B0", VA = "0x180D4AAB0")]
		public UIDragAndPutDownState()
		{
		}

		// Token: 0x06014D48 RID: 85320 RVA: 0x00088C38 File Offset: 0x00086E38
		[Token(Token = "0x6014D48")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014D49 RID: 85321 RVA: 0x00088C50 File Offset: 0x00086E50
		[Token(Token = "0x6014D49")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014D4A RID: 85322 RVA: 0x00088C68 File Offset: 0x00086E68
		[Token(Token = "0x6014D4A")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014D4B RID: 85323 RVA: 0x00088C80 File Offset: 0x00086E80
		[Token(Token = "0x6014D4B")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06014D4C RID: 85324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D4C")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06014D4D RID: 85325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D4D")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014D4E RID: 85326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D4E")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04018C21 RID: 101409
		[Token(Token = "0x4018C21")]
		private const float DRAG_UNHOOK_RADIUS_SQR = 0.7f;

		// Token: 0x04018C22 RID: 101410
		[Token(Token = "0x4018C22")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIDirectionSelector _directionSelector;

		// Token: 0x04018C23 RID: 101411
		[Token(Token = "0x4018C23")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _tileLocateRadius;

		// Token: 0x04018C24 RID: 101412
		[Token(Token = "0x4018C24")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 _touchOffset;

		// Token: 0x04018C25 RID: 101413
		[Token(Token = "0x4018C25")]
		[FieldOffset(Offset = "0x34")]
		private UIDragAndPutDownState.State m_state;

		// Token: 0x04018C26 RID: 101414
		[Token(Token = "0x4018C26")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_dragPlane;

		// Token: 0x04018C27 RID: 101415
		[Token(Token = "0x4018C27")]
		[FieldOffset(Offset = "0x40")]
		private Character m_dummy;

		// Token: 0x04018C28 RID: 101416
		[Token(Token = "0x4018C28")]
		[FieldOffset(Offset = "0x48")]
		private Tile m_currentTile;

		// Token: 0x04018C29 RID: 101417
		[Token(Token = "0x4018C29")]
		[FieldOffset(Offset = "0x50")]
		private UIDragAndPutDownState.BattleQuickOperation m_quickOperation;

		// Token: 0x04018C2C RID: 101420
		[Token(Token = "0x4018C2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x04018C2D RID: 101421
		[Token(Token = "0x4018C2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018C2E RID: 101422
		[Token(Token = "0x4018C2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x04018C2F RID: 101423
		[Token(Token = "0x4018C2F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_uiCard;

		// Token: 0x04018C30 RID: 101424
		[Token(Token = "0x4018C30")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_uiCard;

		// Token: 0x04018C31 RID: 101425
		[Token(Token = "0x4018C31")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_card;

		// Token: 0x04018C32 RID: 101426
		[Token(Token = "0x4018C32")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_card;

		// Token: 0x04018C33 RID: 101427
		[Token(Token = "0x4018C33")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_directionSelector;

		// Token: 0x04018C34 RID: 101428
		[Token(Token = "0x4018C34")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_dummy;

		// Token: 0x04018C35 RID: 101429
		[Token(Token = "0x4018C35")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018C36 RID: 101430
		[Token(Token = "0x4018C36")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018C37 RID: 101431
		[Token(Token = "0x4018C37")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018C38 RID: 101432
		[Token(Token = "0x4018C38")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x04018C39 RID: 101433
		[Token(Token = "0x4018C39")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_dragDisabled;

		// Token: 0x04018C3A RID: 101434
		[Token(Token = "0x4018C3A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_NeedPutDownCamera;

		// Token: 0x04018C3B RID: 101435
		[Token(Token = "0x4018C3B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnBeginDrag;

		// Token: 0x04018C3C RID: 101436
		[Token(Token = "0x4018C3C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnEndDrag;

		// Token: 0x04018C3D RID: 101437
		[Token(Token = "0x4018C3D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBottomMaskClicked;

		// Token: 0x04018C3E RID: 101438
		[Token(Token = "0x4018C3E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018C3F RID: 101439
		[Token(Token = "0x4018C3F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018C40 RID: 101440
		[Token(Token = "0x4018C40")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018C41 RID: 101441
		[Token(Token = "0x4018C41")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018C42 RID: 101442
		[Token(Token = "0x4018C42")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ClearDummy;

		// Token: 0x04018C43 RID: 101443
		[Token(Token = "0x4018C43")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CheckLocatable;

		// Token: 0x04018C44 RID: 101444
		[Token(Token = "0x4018C44")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__PutDownInternal;

		// Token: 0x04018C45 RID: 101445
		[Token(Token = "0x4018C45")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__UpdateBuildableHighlight;

		// Token: 0x04018C46 RID: 101446
		[Token(Token = "0x4018C46")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TryGetScreenPos;

		// Token: 0x04018C47 RID: 101447
		[Token(Token = "0x4018C47")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateInternal;

		// Token: 0x04018C48 RID: 101448
		[Token(Token = "0x4018C48")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnDirectionSelected;

		// Token: 0x04018C49 RID: 101449
		[Token(Token = "0x4018C49")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ExitDragState;

		// Token: 0x04018C4A RID: 101450
		[Token(Token = "0x4018C4A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_DisableUiCardIsOn;

		// Token: 0x04018C4B RID: 101451
		[Token(Token = "0x4018C4B")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__MoveToMatch;

		// Token: 0x04018C4C RID: 101452
		[Token(Token = "0x4018C4C")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__ConvertScreenPos;

		// Token: 0x04018C4D RID: 101453
		[Token(Token = "0x4018C4D")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__EnableBuildableHighlight;

		// Token: 0x04018C4E RID: 101454
		[Token(Token = "0x4018C4E")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__CheckBuildable;

		// Token: 0x04018C4F RID: 101455
		[Token(Token = "0x4018C4F")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018C50 RID: 101456
		[Token(Token = "0x4018C50")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003324 RID: 13092
		[Token(Token = "0x2003324")]
		public enum State
		{
			// Token: 0x04018C52 RID: 101458
			[Token(Token = "0x4018C52")]
			NONE,
			// Token: 0x04018C53 RID: 101459
			[Token(Token = "0x4018C53")]
			DRAGGING,
			// Token: 0x04018C54 RID: 101460
			[Token(Token = "0x4018C54")]
			SELECTING
		}

		// Token: 0x02003325 RID: 13093
		[Token(Token = "0x2003325")]
		private class BattleQuickOperation : IHotfixable, IDisposable
		{
			// Token: 0x17003160 RID: 12640
			// (get) Token: 0x06014D4F RID: 85327 RVA: 0x00088C98 File Offset: 0x00086E98
			[Token(Token = "0x17003160")]
			public bool started
			{
				[Token(Token = "0x6014D4F")]
				[Address(RVA = "0xD32A80", Offset = "0xD31680", VA = "0x180D32A80")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06014D50 RID: 85328 RVA: 0x00088CB0 File Offset: 0x00086EB0
			[Token(Token = "0x6014D50")]
			[Address(RVA = "0xD32860", Offset = "0xD31460", VA = "0x180D32860")]
			private bool _CheckValid()
			{
				return default(bool);
			}

			// Token: 0x06014D51 RID: 85329 RVA: 0x00088CC8 File Offset: 0x00086EC8
			[Token(Token = "0x6014D51")]
			[Address(RVA = "0xD325E0", Offset = "0xD311E0", VA = "0x180D325E0")]
			public bool TryStartQuickOp()
			{
				return default(bool);
			}

			// Token: 0x06014D52 RID: 85330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014D52")]
			[Address(RVA = "0xD32540", Offset = "0xD31140", VA = "0x180D32540", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06014D53 RID: 85331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014D53")]
			[Address(RVA = "0xD32A20", Offset = "0xD31620", VA = "0x180D32A20")]
			public BattleQuickOperation()
			{
			}

			// Token: 0x04018C55 RID: 101461
			[Token(Token = "0x4018C55")]
			[FieldOffset(Offset = "0x10")]
			private bool m_cachePaused;

			// Token: 0x04018C56 RID: 101462
			[Token(Token = "0x4018C56")]
			[FieldOffset(Offset = "0x11")]
			private bool m_started;

			// Token: 0x04018C57 RID: 101463
			[Token(Token = "0x4018C57")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_started;

			// Token: 0x04018C58 RID: 101464
			[Token(Token = "0x4018C58")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__CheckValid;

			// Token: 0x04018C59 RID: 101465
			[Token(Token = "0x4018C59")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_TryStartQuickOp;

			// Token: 0x04018C5A RID: 101466
			[Token(Token = "0x4018C5A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x04018C5B RID: 101467
			[Token(Token = "0x4018C5B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
