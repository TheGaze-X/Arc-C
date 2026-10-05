using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004732 RID: 18226
	[Token(Token = "0x2004732")]
	public class RecruitBuildConfigCostView : DataBinder<BuildConfigCostViewProperty>
	{
		// Token: 0x0601BA03 RID: 113155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA03")]
		[Address(RVA = "0x14F61E0", Offset = "0x14F4DE0", VA = "0x1814F61E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BA04 RID: 113156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA04")]
		[Address(RVA = "0x14F5E40", Offset = "0x14F4A40", VA = "0x1814F5E40", Slot = "7")]
		public override void OnValueChanged(BuildConfigCostViewProperty property)
		{
		}

		// Token: 0x0601BA05 RID: 113157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA05")]
		[Address(RVA = "0x14F6410", Offset = "0x14F5010", VA = "0x1814F6410")]
		private static void _UpdateItemCard(RecruitBuildConfigCostCard costCard, UIItemViewModel viewModel, long curCount)
		{
		}

		// Token: 0x0601BA06 RID: 113158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA06")]
		[Address(RVA = "0x14F6550", Offset = "0x14F5150", VA = "0x1814F6550")]
		public RecruitBuildConfigCostView()
		{
		}

		// Token: 0x04023D17 RID: 146711
		[Token(Token = "0x4023D17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _costCardPrefab;

		// Token: 0x04023D18 RID: 146712
		[Token(Token = "0x4023D18")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _costCardContainer;

		// Token: 0x04023D19 RID: 146713
		[Token(Token = "0x4023D19")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _specialTag;

		// Token: 0x04023D1A RID: 146714
		[Token(Token = "0x4023D1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _specialTagText;

		// Token: 0x04023D1B RID: 146715
		[Token(Token = "0x4023D1B")]
		public const int MAX_COST_ITEM = 2;

		// Token: 0x04023D1C RID: 146716
		[Token(Token = "0x4023D1C")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04023D1D RID: 146717
		[Token(Token = "0x4023D1D")]
		[FieldOffset(Offset = "0x48")]
		private RecruitBuildConfigCostCard m_itemGold;

		// Token: 0x04023D1E RID: 146718
		[Token(Token = "0x4023D1E")]
		[FieldOffset(Offset = "0x50")]
		private RecruitBuildConfigCostCard m_itemRecruitLicense;

		// Token: 0x04023D1F RID: 146719
		[Token(Token = "0x4023D1F")]
		[FieldOffset(Offset = "0x58")]
		private List<RecruitBuildConfigCostCard> m_itemCardList;

		// Token: 0x04023D20 RID: 146720
		[Token(Token = "0x4023D20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023D21 RID: 146721
		[Token(Token = "0x4023D21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023D22 RID: 146722
		[Token(Token = "0x4023D22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateItemCard;

		// Token: 0x04023D23 RID: 146723
		[Token(Token = "0x4023D23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
