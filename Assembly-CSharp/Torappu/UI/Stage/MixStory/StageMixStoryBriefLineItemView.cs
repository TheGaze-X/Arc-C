using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A81 RID: 27265
	[Token(Token = "0x2006A81")]
	public class StageMixStoryBriefLineItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005C2F RID: 23599
		// (get) Token: 0x06027029 RID: 159785 RVA: 0x000CD458 File Offset: 0x000CB658
		[Token(Token = "0x17005C2F")]
		public float focusDuration
		{
			[Token(Token = "0x6027029")]
			[Address(RVA = "0x223C080", Offset = "0x223AC80", VA = "0x18223C080")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602702A RID: 159786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602702A")]
		[Address(RVA = "0x223BD30", Offset = "0x223A930", VA = "0x18223BD30")]
		public void OnClickEvent()
		{
		}

		// Token: 0x0602702B RID: 159787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602702B")]
		[Address(RVA = "0x223BE20", Offset = "0x223AA20", VA = "0x18223BE20")]
		public void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x0602702C RID: 159788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602702C")]
		[Address(RVA = "0x223BBF0", Offset = "0x223A7F0", VA = "0x18223BBF0")]
		public void ApplyDistance(float signedDistance)
		{
		}

		// Token: 0x0602702D RID: 159789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602702D")]
		[Address(RVA = "0x223BF40", Offset = "0x223AB40", VA = "0x18223BF40")]
		private void _GetAnimationLengthIfNot()
		{
		}

		// Token: 0x0602702E RID: 159790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602702E")]
		[Address(RVA = "0x223C010", Offset = "0x223AC10", VA = "0x18223C010")]
		public StageMixStoryBriefLineItemView()
		{
		}

		// Token: 0x040372D5 RID: 226005
		[Token(Token = "0x40372D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIDynImage _titleImage;

		// Token: 0x040372D6 RID: 226006
		[Token(Token = "0x40372D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _positionAnimation;

		// Token: 0x040372D7 RID: 226007
		[Token(Token = "0x40372D7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _positionDistance;

		// Token: 0x040372D8 RID: 226008
		[Token(Token = "0x40372D8")]
		[FieldOffset(Offset = "0x34")]
		private float m_positionAnimationLength;

		// Token: 0x040372D9 RID: 226009
		[Token(Token = "0x40372D9")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_finder;

		// Token: 0x040372DA RID: 226010
		[Token(Token = "0x40372DA")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedStorySetId;

		// Token: 0x040372DB RID: 226011
		[Token(Token = "0x40372DB")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedIconId;

		// Token: 0x040372DC RID: 226012
		[Token(Token = "0x40372DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusDuration;

		// Token: 0x040372DD RID: 226013
		[Token(Token = "0x40372DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x040372DE RID: 226014
		[Token(Token = "0x40372DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040372DF RID: 226015
		[Token(Token = "0x40372DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDistance;

		// Token: 0x040372E0 RID: 226016
		[Token(Token = "0x40372E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetAnimationLengthIfNot;

		// Token: 0x040372E1 RID: 226017
		[Token(Token = "0x40372E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
