using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x0200708B RID: 28811
	[Token(Token = "0x200708B")]
	public class ActMultiV3BattleFinishFootballModeView : ActMultiV3BattleFinishModeViewBase
	{
		// Token: 0x170060D9 RID: 24793
		// (get) Token: 0x06028EE1 RID: 167649 RVA: 0x000D39E0 File Offset: 0x000D1BE0
		[Token(Token = "0x170060D9")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028EE1")]
			[Address(RVA = "0x244C310", Offset = "0x244AF10", VA = "0x18244C310", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028EE2 RID: 167650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028EE2")]
		[Address(RVA = "0x244BE20", Offset = "0x244AA20", VA = "0x18244BE20", Slot = "5")]
		public override Tween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06028EE3 RID: 167651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EE3")]
		[Address(RVA = "0x244BF10", Offset = "0x244AB10", VA = "0x18244BF10", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028EE4 RID: 167652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EE4")]
		[Address(RVA = "0x244C1E0", Offset = "0x244ADE0", VA = "0x18244C1E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028EE5 RID: 167653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EE5")]
		[Address(RVA = "0x244C270", Offset = "0x244AE70", VA = "0x18244C270")]
		public ActMultiV3BattleFinishFootballModeView()
		{
		}

		// Token: 0x0403A66A RID: 239210
		[Token(Token = "0x403A66A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0403A66B RID: 239211
		[Token(Token = "0x403A66B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textGoalMine;

		// Token: 0x0403A66C RID: 239212
		[Token(Token = "0x403A66C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textGoalOther;

		// Token: 0x0403A66D RID: 239213
		[Token(Token = "0x403A66D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textGoalDiff;

		// Token: 0x0403A66E RID: 239214
		[Token(Token = "0x403A66E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _newGoalGO;

		// Token: 0x0403A66F RID: 239215
		[Token(Token = "0x403A66F")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403A670 RID: 239216
		[Token(Token = "0x403A670")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_animTween;

		// Token: 0x0403A671 RID: 239217
		[Token(Token = "0x403A671")]
		[FieldOffset(Offset = "0x70")]
		private BattleFinishFootballMapModel m_footballModel;

		// Token: 0x0403A672 RID: 239218
		[Token(Token = "0x403A672")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A673 RID: 239219
		[Token(Token = "0x403A673")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0403A674 RID: 239220
		[Token(Token = "0x403A674")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A675 RID: 239221
		[Token(Token = "0x403A675")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A676 RID: 239222
		[Token(Token = "0x403A676")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
