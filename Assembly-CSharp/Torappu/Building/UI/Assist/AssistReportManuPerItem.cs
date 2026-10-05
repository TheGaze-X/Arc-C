using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E08 RID: 7688
	[Token(Token = "0x2001E08")]
	public class AssistReportManuPerItem : MonoBehaviour
	{
		// Token: 0x0600BDCF RID: 48591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCF")]
		[Address(RVA = "0x339C8F0", Offset = "0x339B4F0", VA = "0x18339C8F0")]
		public void Render(UIItemViewModel itemViewModel, BuildingManuFactureItemReport report)
		{
		}

		// Token: 0x0600BDD0 RID: 48592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD0")]
		[Address(RVA = "0x339C800", Offset = "0x339B400", VA = "0x18339C800")]
		private void Awake()
		{
		}

		// Token: 0x0600BDD1 RID: 48593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD1")]
		[Address(RVA = "0x339CB30", Offset = "0x339B730", VA = "0x18339CB30")]
		private void Update()
		{
		}

		// Token: 0x0600BDD2 RID: 48594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD2")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AssistReportManuPerItem()
		{
		}

		// Token: 0x0400BE7D RID: 48765
		[Token(Token = "0x400BE7D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0400BE7E RID: 48766
		[Token(Token = "0x400BE7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0400BE7F RID: 48767
		[Token(Token = "0x400BE7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x0400BE80 RID: 48768
		[Token(Token = "0x400BE80")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _hourCount;

		// Token: 0x0400BE81 RID: 48769
		[Token(Token = "0x400BE81")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _countLabelPosAdjustWeight;

		// Token: 0x0400BE82 RID: 48770
		[Token(Token = "0x400BE82")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _countLabelPosAdjustBias;

		// Token: 0x0400BE83 RID: 48771
		[Token(Token = "0x400BE83")]
		[FieldOffset(Offset = "0x40")]
		private float m_countLabelXPos;

		// Token: 0x0400BE84 RID: 48772
		[Token(Token = "0x400BE84")]
		[FieldOffset(Offset = "0x48")]
		private RectTransform m_countLabelRect;
	}
}
