using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x0200708A RID: 28810
	[Token(Token = "0x200708A")]
	public class ActMultiV3BattleFinishDefenceResultView : ActMultiV3BattleFinishResultViewBase
	{
		// Token: 0x170060D8 RID: 24792
		// (get) Token: 0x06028EDE RID: 167646 RVA: 0x000D39C8 File Offset: 0x000D1BC8
		[Token(Token = "0x170060D8")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028EDE")]
			[Address(RVA = "0x244BDC0", Offset = "0x244A9C0", VA = "0x18244BDC0", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028EDF RID: 167647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EDF")]
		[Address(RVA = "0x244BBB0", Offset = "0x244A7B0", VA = "0x18244BBB0", Slot = "5")]
		protected override void OnRender()
		{
		}

		// Token: 0x06028EE0 RID: 167648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EE0")]
		[Address(RVA = "0x244BD20", Offset = "0x244A920", VA = "0x18244BD20")]
		public ActMultiV3BattleFinishDefenceResultView()
		{
		}

		// Token: 0x0403A666 RID: 239206
		[Token(Token = "0x403A666")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textBossDamage;

		// Token: 0x0403A667 RID: 239207
		[Token(Token = "0x403A667")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A668 RID: 239208
		[Token(Token = "0x403A668")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403A669 RID: 239209
		[Token(Token = "0x403A669")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
