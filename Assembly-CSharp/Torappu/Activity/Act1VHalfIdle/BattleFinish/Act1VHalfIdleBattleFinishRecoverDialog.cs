using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007830 RID: 30768
	[Token(Token = "0x2007830")]
	public class Act1VHalfIdleBattleFinishRecoverDialog : UICompDialog<Act1VHalfIdleBattleFinishRecoverDialog.Option>
	{
		// Token: 0x170064F4 RID: 25844
		// (get) Token: 0x0602B270 RID: 176752 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B271 RID: 176753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064F4")]
		private string actId
		{
			[Token(Token = "0x602B270")]
			[Address(RVA = "0x26F5860", Offset = "0x26F4460", VA = "0x1826F5860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B271")]
			[Address(RVA = "0x26F58C0", Offset = "0x26F44C0", VA = "0x1826F58C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B272 RID: 176754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B272")]
		[Address(RVA = "0x26F52B0", Offset = "0x26F3EB0", VA = "0x1826F52B0", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleBattleFinishRecoverDialog.Option input)
		{
		}

		// Token: 0x0602B273 RID: 176755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B273")]
		[Address(RVA = "0x26F5690", Offset = "0x26F4290", VA = "0x1826F5690")]
		private void _EventOnIncomeClick(bool confirm)
		{
		}

		// Token: 0x0602B274 RID: 176756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B274")]
		[Address(RVA = "0x26F55D0", Offset = "0x26F41D0", VA = "0x1826F55D0")]
		private void _DoneReplace()
		{
		}

		// Token: 0x0602B275 RID: 176757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B275")]
		[Address(RVA = "0x26F57F0", Offset = "0x26F43F0", VA = "0x1826F57F0")]
		public Act1VHalfIdleBattleFinishRecoverDialog()
		{
		}

		// Token: 0x0403E61B RID: 255515
		[Token(Token = "0x403E61B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1VHalfIdleBattleFinishIncomeView _incomeView;

		// Token: 0x0403E61C RID: 255516
		[Token(Token = "0x403E61C")]
		[FieldOffset(Offset = "0x78")]
		private Act1VHalfIdleBattleFinishIncomeViewModel m_model;

		// Token: 0x0403E61D RID: 255517
		[Token(Token = "0x403E61D")]
		[FieldOffset(Offset = "0x80")]
		private Act1VHalfIdleBattleFinishIncomeReplace m_replaceLogic;

		// Token: 0x0403E61E RID: 255518
		[Token(Token = "0x403E61E")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine m_entryAnimCoroutine;

		// Token: 0x0403E620 RID: 255520
		[Token(Token = "0x403E620")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403E621 RID: 255521
		[Token(Token = "0x403E621")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403E622 RID: 255522
		[Token(Token = "0x403E622")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E623 RID: 255523
		[Token(Token = "0x403E623")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnIncomeClick;

		// Token: 0x0403E624 RID: 255524
		[Token(Token = "0x403E624")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoneReplace;

		// Token: 0x0403E625 RID: 255525
		[Token(Token = "0x403E625")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007831 RID: 30769
		[Token(Token = "0x2007831")]
		public class Option
		{
			// Token: 0x0602B276 RID: 176758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B276")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403E626 RID: 255526
			[Token(Token = "0x403E626")]
			[FieldOffset(Offset = "0x10")]
			public string activityId;
		}
	}
}
