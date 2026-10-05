using System;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BEC RID: 27628
	[Token(Token = "0x2006BEC")]
	public class ArchiveQuestContentAnimator : IHotfixable
	{
		// Token: 0x06027734 RID: 161588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027734")]
		[Address(RVA = "0x229D250", Offset = "0x229BE50", VA = "0x18229D250")]
		public ArchiveQuestContentAnimator(UIAnimationLocation animationLocation, Action updateAction)
		{
		}

		// Token: 0x06027735 RID: 161589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027735")]
		[Address(RVA = "0x229C9B0", Offset = "0x229B5B0", VA = "0x18229C9B0")]
		public void InitAsBlank()
		{
		}

		// Token: 0x06027736 RID: 161590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027736")]
		[Address(RVA = "0x229CA60", Offset = "0x229B660", VA = "0x18229CA60")]
		public void UpdateFocusIndex(int index, bool fastMode)
		{
		}

		// Token: 0x06027737 RID: 161591 RVA: 0x000CE6B8 File Offset: 0x000CC8B8
		[Token(Token = "0x6027737")]
		[Address(RVA = "0x229D0C0", Offset = "0x229BCC0", VA = "0x18229D0C0")]
		private float _GetPosition()
		{
			return 0f;
		}

		// Token: 0x06027738 RID: 161592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027738")]
		[Address(RVA = "0x229D120", Offset = "0x229BD20", VA = "0x18229D120")]
		private void _SetPosition(float position)
		{
		}

		// Token: 0x06027739 RID: 161593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027739")]
		[Address(RVA = "0x229D1D0", Offset = "0x229BDD0", VA = "0x18229D1D0")]
		private void _UpdateView()
		{
		}

		// Token: 0x0602773A RID: 161594 RVA: 0x000CE6D0 File Offset: 0x000CC8D0
		[Token(Token = "0x602773A")]
		[Address(RVA = "0x229D020", Offset = "0x229BC20", VA = "0x18229D020")]
		private static float _CellModuleOne(float val)
		{
			return 0f;
		}

		// Token: 0x04037E58 RID: 228952
		[Token(Token = "0x4037E58")]
		[FieldOffset(Offset = "0x10")]
		private float REFRESH_POSITION;

		// Token: 0x04037E59 RID: 228953
		[Token(Token = "0x4037E59")]
		[FieldOffset(Offset = "0x14")]
		private float REFRESH_WAIT_INTERVAL;

		// Token: 0x04037E5A RID: 228954
		[Token(Token = "0x4037E5A")]
		[FieldOffset(Offset = "0x18")]
		private readonly UIAnimationLocation m_animationLocation;

		// Token: 0x04037E5B RID: 228955
		[Token(Token = "0x4037E5B")]
		[FieldOffset(Offset = "0x28")]
		private readonly float m_animationLength;

		// Token: 0x04037E5C RID: 228956
		[Token(Token = "0x4037E5C")]
		[FieldOffset(Offset = "0x30")]
		private readonly Action m_updateAction;

		// Token: 0x04037E5D RID: 228957
		[Token(Token = "0x4037E5D")]
		[FieldOffset(Offset = "0x38")]
		private int m_focusIndex;

		// Token: 0x04037E5E RID: 228958
		[Token(Token = "0x4037E5E")]
		[FieldOffset(Offset = "0x3C")]
		private int m_presentingIndex;

		// Token: 0x04037E5F RID: 228959
		[Token(Token = "0x4037E5F")]
		[FieldOffset(Offset = "0x40")]
		private float m_playingPosition;

		// Token: 0x04037E60 RID: 228960
		[Token(Token = "0x4037E60")]
		[FieldOffset(Offset = "0x44")]
		private ArchiveQuestContentAnimator.Direction m_playingDirection;

		// Token: 0x04037E61 RID: 228961
		[Token(Token = "0x4037E61")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_playingTween;

		// Token: 0x04037E62 RID: 228962
		[Token(Token = "0x4037E62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037E63 RID: 228963
		[Token(Token = "0x4037E63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAsBlank;

		// Token: 0x04037E64 RID: 228964
		[Token(Token = "0x4037E64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateFocusIndex;

		// Token: 0x04037E65 RID: 228965
		[Token(Token = "0x4037E65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x04037E66 RID: 228966
		[Token(Token = "0x4037E66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x04037E67 RID: 228967
		[Token(Token = "0x4037E67")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x04037E68 RID: 228968
		[Token(Token = "0x4037E68")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CellModuleOne;

		// Token: 0x02006BED RID: 27629
		[Token(Token = "0x2006BED")]
		private enum Direction
		{
			// Token: 0x04037E6A RID: 228970
			[Token(Token = "0x4037E6A")]
			LEFT,
			// Token: 0x04037E6B RID: 228971
			[Token(Token = "0x4037E6B")]
			RIGHT
		}
	}
}
