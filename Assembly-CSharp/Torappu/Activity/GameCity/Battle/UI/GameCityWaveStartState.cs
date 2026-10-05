using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x02007906 RID: 30982
	[Token(Token = "0x2007906")]
	public class GameCityWaveStartState : UIStateNode
	{
		// Token: 0x170065D4 RID: 26068
		// (get) Token: 0x0602B759 RID: 178009 RVA: 0x000DC188 File Offset: 0x000DA388
		[Token(Token = "0x170065D4")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x602B759")]
			[Address(RVA = "0x2760A10", Offset = "0x275F610", VA = "0x182760A10", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170065D5 RID: 26069
		// (get) Token: 0x0602B75A RID: 178010 RVA: 0x000DC1A0 File Offset: 0x000DA3A0
		[Token(Token = "0x170065D5")]
		public override bool enablePause
		{
			[Token(Token = "0x602B75A")]
			[Address(RVA = "0x2760890", Offset = "0x275F490", VA = "0x182760890", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170065D6 RID: 26070
		// (get) Token: 0x0602B75B RID: 178011 RVA: 0x000DC1B8 File Offset: 0x000DA3B8
		[Token(Token = "0x170065D6")]
		public override bool enableShowRange
		{
			[Token(Token = "0x602B75B")]
			[Address(RVA = "0x2760950", Offset = "0x275F550", VA = "0x182760950", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170065D7 RID: 26071
		// (get) Token: 0x0602B75C RID: 178012 RVA: 0x000DC1D0 File Offset: 0x000DA3D0
		[Token(Token = "0x170065D7")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x602B75C")]
			[Address(RVA = "0x27609B0", Offset = "0x275F5B0", VA = "0x1827609B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170065D8 RID: 26072
		// (get) Token: 0x0602B75D RID: 178013 RVA: 0x000DC1E8 File Offset: 0x000DA3E8
		[Token(Token = "0x170065D8")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x602B75D")]
			[Address(RVA = "0x27608F0", Offset = "0x275F4F0", VA = "0x1827608F0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B75E RID: 178014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B75E")]
		[Address(RVA = "0x2760330", Offset = "0x275EF30", VA = "0x182760330", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x0602B75F RID: 178015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B75F")]
		[Address(RVA = "0x275FDC0", Offset = "0x275E9C0", VA = "0x18275FDC0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0602B760 RID: 178016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B760")]
		[Address(RVA = "0x27605E0", Offset = "0x275F1E0", VA = "0x1827605E0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0602B761 RID: 178017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B761")]
		[Address(RVA = "0x2760290", Offset = "0x275EE90", VA = "0x182760290", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0602B762 RID: 178018 RVA: 0x000DC200 File Offset: 0x000DA400
		[Token(Token = "0x602B762")]
		[Address(RVA = "0x275FD50", Offset = "0x275E950", VA = "0x18275FD50", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x0602B763 RID: 178019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B763")]
		[Address(RVA = "0x2760640", Offset = "0x275F240", VA = "0x182760640")]
		private void _ResetPerformPositionByCameraPos()
		{
		}

		// Token: 0x0602B764 RID: 178020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B764")]
		[Address(RVA = "0x2760830", Offset = "0x275F430", VA = "0x182760830")]
		public GameCityWaveStartState()
		{
		}

		// Token: 0x0602B765 RID: 178021 RVA: 0x000DC218 File Offset: 0x000DA418
		[Token(Token = "0x602B765")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0602B766 RID: 178022 RVA: 0x000DC230 File Offset: 0x000DA430
		[Token(Token = "0x602B766")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0602B767 RID: 178023 RVA: 0x000DC248 File Offset: 0x000DA448
		[Token(Token = "0x602B767")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602B768 RID: 178024 RVA: 0x000DC260 File Offset: 0x000DA460
		[Token(Token = "0x602B768")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x0602B769 RID: 178025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B769")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x0602B76A RID: 178026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B76A")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0602B76B RID: 178027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B76B")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x0602B76C RID: 178028 RVA: 0x000DC278 File Offset: 0x000DA478
		[Token(Token = "0x602B76C")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0403ED63 RID: 257379
		[Token(Token = "0x403ED63")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameCityWaveStartPanel _perform;

		// Token: 0x0403ED64 RID: 257380
		[Token(Token = "0x403ED64")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 m_offset;

		// Token: 0x0403ED65 RID: 257381
		[Token(Token = "0x403ED65")]
		[FieldOffset(Offset = "0x38")]
		private GameCityWaveStartPanel m_panel;

		// Token: 0x0403ED66 RID: 257382
		[Token(Token = "0x403ED66")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403ED67 RID: 257383
		[Token(Token = "0x403ED67")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403ED68 RID: 257384
		[Token(Token = "0x403ED68")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403ED69 RID: 257385
		[Token(Token = "0x403ED69")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403ED6A RID: 257386
		[Token(Token = "0x403ED6A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0403ED6B RID: 257387
		[Token(Token = "0x403ED6B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403ED6C RID: 257388
		[Token(Token = "0x403ED6C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403ED6D RID: 257389
		[Token(Token = "0x403ED6D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403ED6E RID: 257390
		[Token(Token = "0x403ED6E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403ED6F RID: 257391
		[Token(Token = "0x403ED6F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0403ED70 RID: 257392
		[Token(Token = "0x403ED70")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetPerformPositionByCameraPos;

		// Token: 0x0403ED71 RID: 257393
		[Token(Token = "0x403ED71")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
