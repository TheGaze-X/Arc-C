using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x0200708C RID: 28812
	[Token(Token = "0x200708C")]
	public class ActMultiV3BattleFinishFootballResultView : ActMultiV3BattleFinishResultViewBase
	{
		// Token: 0x170060DA RID: 24794
		// (get) Token: 0x06028EE6 RID: 167654 RVA: 0x000D39F8 File Offset: 0x000D1BF8
		[Token(Token = "0x170060DA")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028EE6")]
			[Address(RVA = "0x244C580", Offset = "0x244B180", VA = "0x18244C580", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028EE7 RID: 167655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EE7")]
		[Address(RVA = "0x244C370", Offset = "0x244AF70", VA = "0x18244C370", Slot = "5")]
		protected override void OnRender()
		{
		}

		// Token: 0x06028EE8 RID: 167656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EE8")]
		[Address(RVA = "0x244C4E0", Offset = "0x244B0E0", VA = "0x18244C4E0")]
		public ActMultiV3BattleFinishFootballResultView()
		{
		}

		// Token: 0x0403A677 RID: 239223
		[Token(Token = "0x403A677")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textGoalDiff;

		// Token: 0x0403A678 RID: 239224
		[Token(Token = "0x403A678")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A679 RID: 239225
		[Token(Token = "0x403A679")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403A67A RID: 239226
		[Token(Token = "0x403A67A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
