using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004722 RID: 18210
	[Token(Token = "0x2004722")]
	public class RecruitBuildCostView : MonoBehaviour
	{
		// Token: 0x0601B992 RID: 113042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B992")]
		[Address(RVA = "0x14DE9E0", Offset = "0x14DD5E0", VA = "0x1814DE9E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B993 RID: 113043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B993")]
		[Address(RVA = "0x14DE630", Offset = "0x14DD230", VA = "0x1814DE630")]
		public void Render(BuildSlotViewModel viewModel)
		{
		}

		// Token: 0x0601B994 RID: 113044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B994")]
		[Address(RVA = "0x14DEBD0", Offset = "0x14DD7D0", VA = "0x1814DEBD0")]
		private static void _UpdateItemCard(RecruitBuildConfigCostCard costCard, UIItemViewModel viewModel, long curCount)
		{
		}

		// Token: 0x0601B995 RID: 113045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B995")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RecruitBuildCostView()
		{
		}

		// Token: 0x04023C31 RID: 146481
		[Token(Token = "0x4023C31")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _costCardPrefab;

		// Token: 0x04023C32 RID: 146482
		[Token(Token = "0x4023C32")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _costCardContainer;

		// Token: 0x04023C33 RID: 146483
		[Token(Token = "0x4023C33")]
		public const int MAX_COST_ITEM = 2;

		// Token: 0x04023C34 RID: 146484
		[Token(Token = "0x4023C34")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x04023C35 RID: 146485
		[Token(Token = "0x4023C35")]
		[FieldOffset(Offset = "0x30")]
		private RecruitBuildConfigCostCard m_itemGold;

		// Token: 0x04023C36 RID: 146486
		[Token(Token = "0x4023C36")]
		[FieldOffset(Offset = "0x38")]
		private RecruitBuildConfigCostCard m_itemRecruitLicense;

		// Token: 0x04023C37 RID: 146487
		[Token(Token = "0x4023C37")]
		[FieldOffset(Offset = "0x40")]
		private List<RecruitBuildConfigCostCard> m_itemCardList;
	}
}
