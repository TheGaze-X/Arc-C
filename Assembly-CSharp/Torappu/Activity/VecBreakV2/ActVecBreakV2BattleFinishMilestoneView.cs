using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DE1 RID: 28129
	[Token(Token = "0x2006DE1")]
	public class ActVecBreakV2BattleFinishMilestoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060280D7 RID: 164055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280D7")]
		[Address(RVA = "0x234CA90", Offset = "0x234B690", VA = "0x18234CA90")]
		public void Render(int totalRewardCount, string tokenItemId, string tokenItemIconId)
		{
		}

		// Token: 0x060280D8 RID: 164056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280D8")]
		[Address(RVA = "0x234C8E0", Offset = "0x234B4E0", VA = "0x18234C8E0")]
		public void RenderLevelPart(BattleFinishMilestoneInfo info)
		{
		}

		// Token: 0x060280D9 RID: 164057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280D9")]
		[Address(RVA = "0x234CC70", Offset = "0x234B870", VA = "0x18234CC70")]
		public ActVecBreakV2BattleFinishMilestoneView()
		{
		}

		// Token: 0x04038CD5 RID: 232661
		[Token(Token = "0x4038CD5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _milestoneTokenIcon;

		// Token: 0x04038CD6 RID: 232662
		[Token(Token = "0x4038CD6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _rewardItemNameText;

		// Token: 0x04038CD7 RID: 232663
		[Token(Token = "0x4038CD7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _rewardPointCount;

		// Token: 0x04038CD8 RID: 232664
		[Token(Token = "0x4038CD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _milestoneLevel;

		// Token: 0x04038CD9 RID: 232665
		[Token(Token = "0x4038CD9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _milestoneCurrPoint;

		// Token: 0x04038CDA RID: 232666
		[Token(Token = "0x4038CDA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _milestoneTargetPoint;

		// Token: 0x04038CDB RID: 232667
		[Token(Token = "0x4038CDB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _milestoneProgress;

		// Token: 0x04038CDC RID: 232668
		[Token(Token = "0x4038CDC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _maxLevelDecor;

		// Token: 0x04038CDD RID: 232669
		[Token(Token = "0x4038CDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038CDE RID: 232670
		[Token(Token = "0x4038CDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderLevelPart;

		// Token: 0x04038CDF RID: 232671
		[Token(Token = "0x4038CDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
