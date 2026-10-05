using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x0200649A RID: 25754
	[Token(Token = "0x200649A")]
	public class AutoChessBattleUIGameStartDialog : UICompDialog<AutoChessBattleUIGameStartDialog.Input>
	{
		// Token: 0x0602508D RID: 151693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602508D")]
		[Address(RVA = "0x1FE9690", Offset = "0x1FE8290", VA = "0x181FE9690", Slot = "18")]
		protected override void OnRender(AutoChessBattleUIGameStartDialog.Input input)
		{
		}

		// Token: 0x0602508E RID: 151694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602508E")]
		[Address(RVA = "0x1FE9950", Offset = "0x1FE8550", VA = "0x181FE9950")]
		public AutoChessBattleUIGameStartDialog()
		{
		}

		// Token: 0x04033D9A RID: 212378
		[Token(Token = "0x4033D9A")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static float MAX_SHOW_TIME;

		// Token: 0x04033D9B RID: 212379
		[Token(Token = "0x4033D9B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x04033D9C RID: 212380
		[Token(Token = "0x4033D9C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x04033D9D RID: 212381
		[Token(Token = "0x4033D9D")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_tween;

		// Token: 0x04033D9E RID: 212382
		[Token(Token = "0x4033D9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033D9F RID: 212383
		[Token(Token = "0x4033D9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200649B RID: 25755
		[Token(Token = "0x200649B")]
		public class Input
		{
			// Token: 0x06025091 RID: 151697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025091")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04033DA0 RID: 212384
			[Token(Token = "0x4033DA0")]
			[FieldOffset(Offset = "0x10")]
			public string modeId;
		}
	}
}
