using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x0200649C RID: 25756
	[Token(Token = "0x200649C")]
	public class AutoChessBattleUIHelpBattleDialog : UICompDialog<AutoChessBattleUIHelpBattleDialog.Input>
	{
		// Token: 0x06025092 RID: 151698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025092")]
		[Address(RVA = "0x1FEB5A0", Offset = "0x1FEA1A0", VA = "0x181FEB5A0", Slot = "18")]
		protected override void OnRender(AutoChessBattleUIHelpBattleDialog.Input input)
		{
		}

		// Token: 0x06025093 RID: 151699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025093")]
		[Address(RVA = "0x1FEB850", Offset = "0x1FEA450", VA = "0x181FEB850")]
		public AutoChessBattleUIHelpBattleDialog()
		{
		}

		// Token: 0x04033DA1 RID: 212385
		[Token(Token = "0x4033DA1")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static float MAX_SHOW_TIME;

		// Token: 0x04033DA2 RID: 212386
		[Token(Token = "0x4033DA2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x04033DA3 RID: 212387
		[Token(Token = "0x4033DA3")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_tween;

		// Token: 0x04033DA4 RID: 212388
		[Token(Token = "0x4033DA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033DA5 RID: 212389
		[Token(Token = "0x4033DA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200649D RID: 25757
		[Token(Token = "0x200649D")]
		public class Input
		{
			// Token: 0x06025096 RID: 151702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025096")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}
		}
	}
}
