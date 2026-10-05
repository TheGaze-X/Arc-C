using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007667 RID: 30311
	[Token(Token = "0x2007667")]
	public class Act20sideCarVoteEntryState : PopupFadeState
	{
		// Token: 0x0602AA1E RID: 174622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA1E")]
		[Address(RVA = "0x26684D0", Offset = "0x26670D0", VA = "0x1826684D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AA1F RID: 174623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA1F")]
		[Address(RVA = "0x2668530", Offset = "0x2667130", VA = "0x182668530", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AA20 RID: 174624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA20")]
		[Address(RVA = "0x26685A0", Offset = "0x26671A0", VA = "0x1826685A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602AA21 RID: 174625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA21")]
		[Address(RVA = "0x2668610", Offset = "0x2667210", VA = "0x182668610", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602AA22 RID: 174626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA22")]
		[Address(RVA = "0x2668CE0", Offset = "0x26678E0", VA = "0x182668CE0")]
		private void _OnJumpToCarVote(IStateBean stateBean)
		{
		}

		// Token: 0x0602AA23 RID: 174627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA23")]
		[Address(RVA = "0x2668DF0", Offset = "0x26679F0", VA = "0x182668DF0")]
		private void _OnJumpToCartCompSelect(IStateBean stateBean)
		{
		}

		// Token: 0x0602AA24 RID: 174628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA24")]
		[Address(RVA = "0x2668B20", Offset = "0x2667720", VA = "0x182668B20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AA25 RID: 174629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA25")]
		[Address(RVA = "0x2668F40", Offset = "0x2667B40", VA = "0x182668F40")]
		private void _UpdateProperty()
		{
		}

		// Token: 0x0602AA26 RID: 174630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA26")]
		[Address(RVA = "0x2668A70", Offset = "0x2667670", VA = "0x182668A70")]
		private void _GoVote()
		{
		}

		// Token: 0x0602AA27 RID: 174631 RVA: 0x000D94A0 File Offset: 0x000D76A0
		[Token(Token = "0x602AA27")]
		[Address(RVA = "0x2668990", Offset = "0x2667590", VA = "0x182668990")]
		private bool _CheckVersus(ExhibitionVersus versus)
		{
			return default(bool);
		}

		// Token: 0x0602AA28 RID: 174632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA28")]
		[Address(RVA = "0x2668130", Offset = "0x2666D30", VA = "0x182668130")]
		public void EventOnGoVoteClick()
		{
		}

		// Token: 0x0602AA29 RID: 174633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA29")]
		[Address(RVA = "0x2668080", Offset = "0x2666C80", VA = "0x182668080")]
		public void EventOnCartDeco()
		{
		}

		// Token: 0x0602AA2A RID: 174634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA2A")]
		[Address(RVA = "0x2669200", Offset = "0x2667E00", VA = "0x182669200")]
		public Act20sideCarVoteEntryState()
		{
		}

		// Token: 0x0602AA2C RID: 174636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA2C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602AA2D RID: 174637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA2D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602AA2E RID: 174638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA2E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403D676 RID: 251510
		[Token(Token = "0x403D676")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act20sideCarVoteEntryView _entryView;

		// Token: 0x0403D677 RID: 251511
		[Token(Token = "0x403D677")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UICommonTrackPoint _leftTimeTrackPoint;

		// Token: 0x0403D678 RID: 251512
		[Token(Token = "0x403D678")]
		[FieldOffset(Offset = "0x80")]
		private Act20sideCarVoteEntryStateBean m_stateBean;

		// Token: 0x0403D679 RID: 251513
		[Token(Token = "0x403D679")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0403D67A RID: 251514
		[Token(Token = "0x403D67A")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedActId;

		// Token: 0x0403D67B RID: 251515
		[Token(Token = "0x403D67B")]
		[FieldOffset(Offset = "0x98")]
		private ExhibitionVersus m_cachedVersus;

		// Token: 0x0403D67C RID: 251516
		[Token(Token = "0x403D67C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D67D RID: 251517
		[Token(Token = "0x403D67D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D67E RID: 251518
		[Token(Token = "0x403D67E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403D67F RID: 251519
		[Token(Token = "0x403D67F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403D680 RID: 251520
		[Token(Token = "0x403D680")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToCarVote;

		// Token: 0x0403D681 RID: 251521
		[Token(Token = "0x403D681")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToCartCompSelect;

		// Token: 0x0403D682 RID: 251522
		[Token(Token = "0x403D682")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D683 RID: 251523
		[Token(Token = "0x403D683")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateProperty;

		// Token: 0x0403D684 RID: 251524
		[Token(Token = "0x403D684")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GoVote;

		// Token: 0x0403D685 RID: 251525
		[Token(Token = "0x403D685")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckVersus;

		// Token: 0x0403D686 RID: 251526
		[Token(Token = "0x403D686")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnGoVoteClick;

		// Token: 0x0403D687 RID: 251527
		[Token(Token = "0x403D687")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnCartDeco;

		// Token: 0x0403D688 RID: 251528
		[Token(Token = "0x403D688")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
