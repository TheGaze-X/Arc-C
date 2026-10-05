using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200791F RID: 31007
	[Token(Token = "0x200791F")]
	public class Act1ArcadeBadgeBookDetailContentAnimator : IHotfixable
	{
		// Token: 0x0602B80A RID: 178186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B80A")]
		[Address(RVA = "0x2766550", Offset = "0x2765150", VA = "0x182766550")]
		public Act1ArcadeBadgeBookDetailContentAnimator(UIAnimationLocation animationLocation, Action updateAction)
		{
		}

		// Token: 0x0602B80B RID: 178187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B80B")]
		[Address(RVA = "0x2765C30", Offset = "0x2764830", VA = "0x182765C30")]
		public void UpdateFocusIndex(int index, bool fastMode, Act1ArcadeBadgeBookDetailContentAnimator.Direction preferredDirection = Act1ArcadeBadgeBookDetailContentAnimator.Direction.NONE)
		{
		}

		// Token: 0x0602B80C RID: 178188 RVA: 0x000DC488 File Offset: 0x000DA688
		[Token(Token = "0x602B80C")]
		[Address(RVA = "0x27663C0", Offset = "0x2764FC0", VA = "0x1827663C0")]
		private float _GetPosition()
		{
			return 0f;
		}

		// Token: 0x0602B80D RID: 178189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B80D")]
		[Address(RVA = "0x2766420", Offset = "0x2765020", VA = "0x182766420")]
		private void _SetPosition(float position)
		{
		}

		// Token: 0x0602B80E RID: 178190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B80E")]
		[Address(RVA = "0x27664D0", Offset = "0x27650D0", VA = "0x1827664D0")]
		private void _UpdateView()
		{
		}

		// Token: 0x0602B80F RID: 178191 RVA: 0x000DC4A0 File Offset: 0x000DA6A0
		[Token(Token = "0x602B80F")]
		[Address(RVA = "0x2766310", Offset = "0x2764F10", VA = "0x182766310")]
		private Act1ArcadeBadgeBookDetailContentAnimator.Direction _FetchDirection(Act1ArcadeBadgeBookDetailContentAnimator.Direction preferredDirection)
		{
			return Act1ArcadeBadgeBookDetailContentAnimator.Direction.NONE;
		}

		// Token: 0x0602B810 RID: 178192 RVA: 0x000DC4B8 File Offset: 0x000DA6B8
		[Token(Token = "0x602B810")]
		[Address(RVA = "0x2766270", Offset = "0x2764E70", VA = "0x182766270")]
		private static float _CellModuleOne(float val)
		{
			return 0f;
		}

		// Token: 0x0403EE52 RID: 257618
		[Token(Token = "0x403EE52")]
		[FieldOffset(Offset = "0x10")]
		private float REFRESH_POSITION;

		// Token: 0x0403EE53 RID: 257619
		[Token(Token = "0x403EE53")]
		[FieldOffset(Offset = "0x14")]
		private float REFRESH_WAIT_INTERVAL;

		// Token: 0x0403EE54 RID: 257620
		[Token(Token = "0x403EE54")]
		[FieldOffset(Offset = "0x18")]
		private readonly UIAnimationLocation m_animationLocation;

		// Token: 0x0403EE55 RID: 257621
		[Token(Token = "0x403EE55")]
		[FieldOffset(Offset = "0x28")]
		private readonly float m_animationLength;

		// Token: 0x0403EE56 RID: 257622
		[Token(Token = "0x403EE56")]
		[FieldOffset(Offset = "0x30")]
		private readonly Action m_updateAction;

		// Token: 0x0403EE57 RID: 257623
		[Token(Token = "0x403EE57")]
		[FieldOffset(Offset = "0x38")]
		private int m_focusIndex;

		// Token: 0x0403EE58 RID: 257624
		[Token(Token = "0x403EE58")]
		[FieldOffset(Offset = "0x3C")]
		private int m_presentingIndex;

		// Token: 0x0403EE59 RID: 257625
		[Token(Token = "0x403EE59")]
		[FieldOffset(Offset = "0x40")]
		private float m_playingPosition;

		// Token: 0x0403EE5A RID: 257626
		[Token(Token = "0x403EE5A")]
		[FieldOffset(Offset = "0x44")]
		private Act1ArcadeBadgeBookDetailContentAnimator.Direction m_playingDirection;

		// Token: 0x0403EE5B RID: 257627
		[Token(Token = "0x403EE5B")]
		[FieldOffset(Offset = "0x48")]
		private int m_directionMove;

		// Token: 0x0403EE5C RID: 257628
		[Token(Token = "0x403EE5C")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_playingTween;

		// Token: 0x0403EE5D RID: 257629
		[Token(Token = "0x403EE5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403EE5E RID: 257630
		[Token(Token = "0x403EE5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateFocusIndex;

		// Token: 0x0403EE5F RID: 257631
		[Token(Token = "0x403EE5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x0403EE60 RID: 257632
		[Token(Token = "0x403EE60")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x0403EE61 RID: 257633
		[Token(Token = "0x403EE61")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0403EE62 RID: 257634
		[Token(Token = "0x403EE62")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FetchDirection;

		// Token: 0x0403EE63 RID: 257635
		[Token(Token = "0x403EE63")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CellModuleOne;

		// Token: 0x02007920 RID: 31008
		[Token(Token = "0x2007920")]
		public enum Direction
		{
			// Token: 0x0403EE65 RID: 257637
			[Token(Token = "0x403EE65")]
			NONE,
			// Token: 0x0403EE66 RID: 257638
			[Token(Token = "0x403EE66")]
			FORWARD,
			// Token: 0x0403EE67 RID: 257639
			[Token(Token = "0x403EE67")]
			BACKWARD
		}
	}
}
