using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BE5 RID: 7141
	[Token(Token = "0x2001BE5")]
	public class BuildingWorkshopFormulaCostItem : MonoBehaviour
	{
		// Token: 0x0600B21E RID: 45598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B21E")]
		[Address(RVA = "0x32BCC70", Offset = "0x32BB870", VA = "0x1832BCC70")]
		public void Render(IFormulaItem cost)
		{
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B21F")]
		[Address(RVA = "0x32BCD70", Offset = "0x32BB970", VA = "0x1832BCD70")]
		private void _Init()
		{
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B220")]
		[Address(RVA = "0x32BCF20", Offset = "0x32BBB20", VA = "0x1832BCF20")]
		private void _RenderActive(IFormulaItem cost)
		{
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B221")]
		[Address(RVA = "0x32BD0E0", Offset = "0x32BBCE0", VA = "0x1832BD0E0")]
		public BuildingWorkshopFormulaCostItem()
		{
		}

		// Token: 0x0400ACC8 RID: 44232
		[Token(Token = "0x400ACC8")]
		private const int MAX_COUNT_LENGTH = 7;

		// Token: 0x0400ACC9 RID: 44233
		[Token(Token = "0x400ACC9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400ACCA RID: 44234
		[Token(Token = "0x400ACCA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400ACCB RID: 44235
		[Token(Token = "0x400ACCB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400ACCC RID: 44236
		[Token(Token = "0x400ACCC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0400ACCD RID: 44237
		[Token(Token = "0x400ACCD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400ACCE RID: 44238
		[Token(Token = "0x400ACCE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLack;

		// Token: 0x0400ACCF RID: 44239
		[Token(Token = "0x400ACCF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _lackColor;

		// Token: 0x0400ACD0 RID: 44240
		[Token(Token = "0x400ACD0")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0400ACD1 RID: 44241
		[Token(Token = "0x400ACD1")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_itemCard;

		// Token: 0x0400ACD2 RID: 44242
		[Token(Token = "0x400ACD2")]
		[FieldOffset(Offset = "0x68")]
		private UIItemViewModel m_itemModel;
	}
}
