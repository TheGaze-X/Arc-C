using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F3A RID: 28474
	[Token(Token = "0x2006F3A")]
	public class ActMultiV3MilestoneMainRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028701 RID: 165633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028701")]
		[Address(RVA = "0x23CAB80", Offset = "0x23C9780", VA = "0x1823CAB80")]
		public void Render(ActMultiV3MilestoneViewModel viewModel)
		{
		}

		// Token: 0x06028702 RID: 165634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028702")]
		[Address(RVA = "0x23CADD0", Offset = "0x23C99D0", VA = "0x1823CADD0")]
		public ActMultiV3MilestoneMainRewardView()
		{
		}

		// Token: 0x04039866 RID: 235622
		[Token(Token = "0x4039866")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActMultiV3MilestoneMainRewardItemView _item1View;

		// Token: 0x04039867 RID: 235623
		[Token(Token = "0x4039867")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActMultiV3MilestoneMainRewardItemView _item2View;

		// Token: 0x04039868 RID: 235624
		[Token(Token = "0x4039868")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039869 RID: 235625
		[Token(Token = "0x4039869")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
