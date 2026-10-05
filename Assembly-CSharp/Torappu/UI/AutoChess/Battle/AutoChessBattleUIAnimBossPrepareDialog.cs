using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006496 RID: 25750
	[Token(Token = "0x2006496")]
	public class AutoChessBattleUIAnimBossPrepareDialog : UICompDialog<AutoChessBattleUIAnimBossPrepareDialog.Input>
	{
		// Token: 0x06025085 RID: 151685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025085")]
		[Address(RVA = "0x1FE1F90", Offset = "0x1FE0B90", VA = "0x181FE1F90", Slot = "18")]
		protected override void OnRender(AutoChessBattleUIAnimBossPrepareDialog.Input input)
		{
		}

		// Token: 0x06025086 RID: 151686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025086")]
		[Address(RVA = "0x1FE2350", Offset = "0x1FE0F50", VA = "0x181FE2350")]
		public AutoChessBattleUIAnimBossPrepareDialog()
		{
		}

		// Token: 0x04033D91 RID: 212369
		[Token(Token = "0x4033D91")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static float MAX_SHOW_TIME;

		// Token: 0x04033D92 RID: 212370
		[Token(Token = "0x4033D92")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgBossIcon;

		// Token: 0x04033D93 RID: 212371
		[Token(Token = "0x4033D93")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04033D94 RID: 212372
		[Token(Token = "0x4033D94")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_tween;

		// Token: 0x04033D95 RID: 212373
		[Token(Token = "0x4033D95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033D96 RID: 212374
		[Token(Token = "0x4033D96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006497 RID: 25751
		[Token(Token = "0x2006497")]
		public class Input
		{
			// Token: 0x06025089 RID: 151689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025089")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04033D97 RID: 212375
			[Token(Token = "0x4033D97")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessBattleBossRoundModel bossRoundModel;
		}
	}
}
