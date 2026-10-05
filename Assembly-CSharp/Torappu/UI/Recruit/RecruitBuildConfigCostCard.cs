using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004730 RID: 18224
	[Token(Token = "0x2004730")]
	public class RecruitBuildConfigCostCard : MonoBehaviour
	{
		// Token: 0x0601B9FD RID: 113149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9FD")]
		[Address(RVA = "0x14F5A00", Offset = "0x14F4600", VA = "0x1814F5A00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B9FE RID: 113150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9FE")]
		[Address(RVA = "0x14F58F0", Offset = "0x14F44F0", VA = "0x1814F58F0")]
		public void Render(UIItemViewModel viewModel, long curCount, long requireCount, bool showCostText = true)
		{
		}

		// Token: 0x0601B9FF RID: 113151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9FF")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RecruitBuildConfigCostCard()
		{
		}

		// Token: 0x04023D0D RID: 146701
		[Token(Token = "0x4023D0D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _itemCardPrefab;

		// Token: 0x04023D0E RID: 146702
		[Token(Token = "0x4023D0E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RecruitBuildConfigCostText _costText;

		// Token: 0x04023D0F RID: 146703
		[Token(Token = "0x4023D0F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x04023D10 RID: 146704
		[Token(Token = "0x4023D10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _cardScale;

		// Token: 0x04023D11 RID: 146705
		[Token(Token = "0x4023D11")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard;

		// Token: 0x04023D12 RID: 146706
		[Token(Token = "0x4023D12")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;
	}
}
