using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200766E RID: 30318
	[Token(Token = "0x200766E")]
	public class Act20sideEntertainCompetitionState : PopupFadeState
	{
		// Token: 0x0602AA52 RID: 174674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA52")]
		[Address(RVA = "0x2674FA0", Offset = "0x2673BA0", VA = "0x182674FA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AA53 RID: 174675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA53")]
		[Address(RVA = "0x2675000", Offset = "0x2673C00", VA = "0x182675000", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AA54 RID: 174676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA54")]
		[Address(RVA = "0x2674E20", Offset = "0x2673A20", VA = "0x182674E20")]
		public void EventOnBackBtnClick()
		{
		}

		// Token: 0x0602AA55 RID: 174677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA55")]
		[Address(RVA = "0x2674EA0", Offset = "0x2673AA0", VA = "0x182674EA0")]
		public void EventOnStage1StartBtnClick()
		{
		}

		// Token: 0x0602AA56 RID: 174678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA56")]
		[Address(RVA = "0x2674F20", Offset = "0x2673B20", VA = "0x182674F20")]
		public void EventOnStage2StartBtnClick()
		{
		}

		// Token: 0x0602AA57 RID: 174679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA57")]
		[Address(RVA = "0x26759F0", Offset = "0x26745F0", VA = "0x1826759F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AA58 RID: 174680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA58")]
		[Address(RVA = "0x2675B10", Offset = "0x2674710", VA = "0x182675B10")]
		private void _StartBattle(string stageId)
		{
		}

		// Token: 0x0602AA59 RID: 174681 RVA: 0x000D9500 File Offset: 0x000D7700
		[Token(Token = "0x602AA59")]
		[Address(RVA = "0x2675300", Offset = "0x2673F00", VA = "0x182675300")]
		private bool _CheckIfStartBattleValid()
		{
			return default(bool);
		}

		// Token: 0x0602AA5A RID: 174682 RVA: 0x000D9518 File Offset: 0x000D7718
		[Token(Token = "0x602AA5A")]
		[Address(RVA = "0x2675390", Offset = "0x2673F90", VA = "0x182675390")]
		private BattleStartController.Param _CreateParamToStartBattle(string stageId)
		{
			return default(BattleStartController.Param);
		}

		// Token: 0x0602AA5B RID: 174683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA5B")]
		[Address(RVA = "0x2675DC0", Offset = "0x26749C0", VA = "0x182675DC0")]
		public Act20sideEntertainCompetitionState()
		{
		}

		// Token: 0x0602AA5C RID: 174684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA5C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403D6B0 RID: 251568
		[Token(Token = "0x403D6B0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIFullScreenImage _fullScreenImage;

		// Token: 0x0403D6B1 RID: 251569
		[Token(Token = "0x403D6B1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act20sideEntertainCompetitionView _view;

		// Token: 0x0403D6B2 RID: 251570
		[Token(Token = "0x403D6B2")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403D6B3 RID: 251571
		[Token(Token = "0x403D6B3")]
		[FieldOffset(Offset = "0x88")]
		private Act20sideEntertainCompViewModel m_viewModel;

		// Token: 0x0403D6B4 RID: 251572
		[Token(Token = "0x403D6B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D6B5 RID: 251573
		[Token(Token = "0x403D6B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D6B6 RID: 251574
		[Token(Token = "0x403D6B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClick;

		// Token: 0x0403D6B7 RID: 251575
		[Token(Token = "0x403D6B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnStage1StartBtnClick;

		// Token: 0x0403D6B8 RID: 251576
		[Token(Token = "0x403D6B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnStage2StartBtnClick;

		// Token: 0x0403D6B9 RID: 251577
		[Token(Token = "0x403D6B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D6BA RID: 251578
		[Token(Token = "0x403D6BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__StartBattle;

		// Token: 0x0403D6BB RID: 251579
		[Token(Token = "0x403D6BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckIfStartBattleValid;

		// Token: 0x0403D6BC RID: 251580
		[Token(Token = "0x403D6BC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateParamToStartBattle;

		// Token: 0x0403D6BD RID: 251581
		[Token(Token = "0x403D6BD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
