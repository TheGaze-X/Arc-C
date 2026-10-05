using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EA7 RID: 20135
	[Token(Token = "0x2004EA7")]
	public class FifthAnnivExploreDetailBackButton : DataBinder<FifthAnnivExploreDecisionProp>
	{
		// Token: 0x0601E0A9 RID: 123049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0A9")]
		[Address(RVA = "0x17B83A0", Offset = "0x17B6FA0", VA = "0x1817B83A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E0AA RID: 123050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0AA")]
		[Address(RVA = "0x17B80D0", Offset = "0x17B6CD0", VA = "0x1817B80D0", Slot = "7")]
		public override void OnValueChanged(FifthAnnivExploreDecisionProp property)
		{
		}

		// Token: 0x0601E0AB RID: 123051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0AB")]
		[Address(RVA = "0x17B8030", Offset = "0x17B6C30", VA = "0x1817B8030")]
		public void OnClicked()
		{
		}

		// Token: 0x0601E0AC RID: 123052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0AC")]
		[Address(RVA = "0x17B84B0", Offset = "0x17B70B0", VA = "0x1817B84B0")]
		public FifthAnnivExploreDetailBackButton()
		{
		}

		// Token: 0x04027F25 RID: 163621
		[Token(Token = "0x4027F25")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FifthAnnivExploreDecisionModel.DecisionStatus[] _enabledStatus;

		// Token: 0x04027F26 RID: 163622
		[Token(Token = "0x4027F26")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x04027F27 RID: 163623
		[Token(Token = "0x4027F27")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x04027F28 RID: 163624
		[Token(Token = "0x4027F28")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween m_showTween;

		// Token: 0x04027F29 RID: 163625
		[Token(Token = "0x4027F29")]
		[FieldOffset(Offset = "0x48")]
		private int m_cacheEnterSeqNum;

		// Token: 0x04027F2A RID: 163626
		[Token(Token = "0x4027F2A")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027F2B RID: 163627
		[Token(Token = "0x4027F2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027F2C RID: 163628
		[Token(Token = "0x4027F2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027F2D RID: 163629
		[Token(Token = "0x4027F2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x04027F2E RID: 163630
		[Token(Token = "0x4027F2E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
