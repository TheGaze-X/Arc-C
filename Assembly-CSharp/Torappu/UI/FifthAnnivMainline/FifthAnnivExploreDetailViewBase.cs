using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EAA RID: 20138
	[Token(Token = "0x2004EAA")]
	public abstract class FifthAnnivExploreDetailViewBase : DataBinder<FifthAnnivExploreDecisionProp>
	{
		// Token: 0x17004684 RID: 18052
		// (get) Token: 0x0601E0C2 RID: 123074
		[Token(Token = "0x17004684")]
		protected abstract FifthAnnivExploreDecisionModel.DecisionStatus status { [Token(Token = "0x601E0C2")] get; }

		// Token: 0x0601E0C3 RID: 123075
		[Token(Token = "0x601E0C3")]
		protected abstract void OnDataUpdate();

		// Token: 0x0601E0C4 RID: 123076 RVA: 0x000AD430 File Offset: 0x000AB630
		[Token(Token = "0x601E0C4")]
		[Address(RVA = "0x17BA7D0", Offset = "0x17B93D0", VA = "0x1817BA7D0", Slot = "10")]
		protected virtual UIAnimationLocation GetEnterAnim()
		{
			return default(UIAnimationLocation);
		}

		// Token: 0x0601E0C5 RID: 123077 RVA: 0x000AD448 File Offset: 0x000AB648
		[Token(Token = "0x601E0C5")]
		[Address(RVA = "0x17BA850", Offset = "0x17B9450", VA = "0x1817BA850", Slot = "11")]
		public virtual bool IsTweenPlaying()
		{
			return default(bool);
		}

		// Token: 0x0601E0C6 RID: 123078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0C6")]
		[Address(RVA = "0x17BA8C0", Offset = "0x17B94C0", VA = "0x1817BA8C0", Slot = "7")]
		public sealed override void OnValueChanged(FifthAnnivExploreDecisionProp property)
		{
		}

		// Token: 0x0601E0C7 RID: 123079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0C7")]
		[Address(RVA = "0x17BAC80", Offset = "0x17B9880", VA = "0x1817BAC80")]
		private void _SetViewVisible(bool isVisible)
		{
		}

		// Token: 0x0601E0C8 RID: 123080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0C8")]
		[Address(RVA = "0x17BAB30", Offset = "0x17B9730", VA = "0x1817BAB30")]
		private void _PlayEnterAnimIfNeed()
		{
		}

		// Token: 0x0601E0C9 RID: 123081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0C9")]
		[Address(RVA = "0x17BAE50", Offset = "0x17B9A50", VA = "0x1817BAE50")]
		protected FifthAnnivExploreDetailViewBase()
		{
		}

		// Token: 0x04027F5A RID: 163674
		[Token(Token = "0x4027F5A")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isVisible;

		// Token: 0x04027F5B RID: 163675
		[Token(Token = "0x4027F5B")]
		[FieldOffset(Offset = "0x24")]
		private int m_cacheEnterSeqNum;

		// Token: 0x04027F5C RID: 163676
		[Token(Token = "0x4027F5C")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_enterTween;

		// Token: 0x04027F5D RID: 163677
		[Token(Token = "0x4027F5D")]
		[FieldOffset(Offset = "0x30")]
		protected FifthAnnivExploreDecisionModel m_decisionModel;

		// Token: 0x04027F5E RID: 163678
		[Token(Token = "0x4027F5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEnterAnim;

		// Token: 0x04027F5F RID: 163679
		[Token(Token = "0x4027F5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsTweenPlaying;

		// Token: 0x04027F60 RID: 163680
		[Token(Token = "0x4027F60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027F61 RID: 163681
		[Token(Token = "0x4027F61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetViewVisible;

		// Token: 0x04027F62 RID: 163682
		[Token(Token = "0x4027F62")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEnterAnimIfNeed;

		// Token: 0x04027F63 RID: 163683
		[Token(Token = "0x4027F63")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
