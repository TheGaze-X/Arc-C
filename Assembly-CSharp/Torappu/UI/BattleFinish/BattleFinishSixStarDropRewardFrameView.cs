using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x0200621E RID: 25118
	[Token(Token = "0x200621E")]
	public class BattleFinishSixStarDropRewardFrameView : BattleFinishDropRewardFrameView
	{
		// Token: 0x060243D2 RID: 148434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243D2")]
		[Address(RVA = "0x1F18D40", Offset = "0x1F17940", VA = "0x181F18D40")]
		private void Update()
		{
		}

		// Token: 0x060243D3 RID: 148435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243D3")]
		[Address(RVA = "0x1F18DA0", Offset = "0x1F179A0", VA = "0x181F18DA0")]
		private void _UpdateWidth()
		{
		}

		// Token: 0x060243D4 RID: 148436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243D4")]
		[Address(RVA = "0x1F18A90", Offset = "0x1F17690", VA = "0x181F18A90", Slot = "4")]
		public override void Render(BattleFinishDropRewardFrameHolder battleFinishDropRewardFrameHolder, DropInfoGroupViewModel dropInfoGroupViewModel)
		{
		}

		// Token: 0x060243D5 RID: 148437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243D5")]
		[Address(RVA = "0x1F18C70", Offset = "0x1F17870", VA = "0x181F18C70", Slot = "5")]
		public override void SetLayout(LayoutGroup layoutGroup)
		{
		}

		// Token: 0x060243D6 RID: 148438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243D6")]
		[Address(RVA = "0x1F18FA0", Offset = "0x1F17BA0", VA = "0x181F18FA0")]
		public BattleFinishSixStarDropRewardFrameView()
		{
		}

		// Token: 0x0403262F RID: 206383
		[Token(Token = "0x403262F")]
		private const int PADDING_LEFT = 40;

		// Token: 0x04032630 RID: 206384
		[Token(Token = "0x4032630")]
		private const int PADDING_RIGHT = 40;

		// Token: 0x04032631 RID: 206385
		[Token(Token = "0x4032631")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("anim")]
		private float _fadeDurationPerItem;

		// Token: 0x04032632 RID: 206386
		[Token(Token = "0x4032632")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Group("anim")]
		private float _widthChangeDurationPerItem;

		// Token: 0x04032633 RID: 206387
		[Token(Token = "0x4032633")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("anim")]
		private CanvasGroup _frame;

		// Token: 0x04032634 RID: 206388
		[Token(Token = "0x4032634")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_holderRoot;

		// Token: 0x04032635 RID: 206389
		[Token(Token = "0x4032635")]
		[FieldOffset(Offset = "0x30")]
		private bool m_enableChangeWidth;

		// Token: 0x04032636 RID: 206390
		[Token(Token = "0x4032636")]
		[FieldOffset(Offset = "0x34")]
		private int m_itemAvailCount;

		// Token: 0x04032637 RID: 206391
		[Token(Token = "0x4032637")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04032638 RID: 206392
		[Token(Token = "0x4032638")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateWidth;

		// Token: 0x04032639 RID: 206393
		[Token(Token = "0x4032639")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403263A RID: 206394
		[Token(Token = "0x403263A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetLayout;

		// Token: 0x0403263B RID: 206395
		[Token(Token = "0x403263B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
