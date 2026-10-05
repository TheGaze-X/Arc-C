using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059F3 RID: 23027
	[Token(Token = "0x20059F3")]
	public class CrisisV2TimeLimitItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060218F1 RID: 137457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218F1")]
		[Address(RVA = "0x1C0DE50", Offset = "0x1C0CA50", VA = "0x181C0DE50")]
		public void Render(CrisisV2TimeLimitItemModel timeLimitItem, bool isClaimed)
		{
		}

		// Token: 0x060218F2 RID: 137458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218F2")]
		[Address(RVA = "0x1C0E090", Offset = "0x1C0CC90", VA = "0x181C0E090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060218F3 RID: 137459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218F3")]
		[Address(RVA = "0x1C0E2D0", Offset = "0x1C0CED0", VA = "0x181C0E2D0")]
		public CrisisV2TimeLimitItem()
		{
		}

		// Token: 0x0402DDC6 RID: 187846
		[Token(Token = "0x402DDC6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _cardScale;

		// Token: 0x0402DDC7 RID: 187847
		[Token(Token = "0x402DDC7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cardRoot;

		// Token: 0x0402DDC8 RID: 187848
		[Token(Token = "0x402DDC8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _remainTimeObject;

		// Token: 0x0402DDC9 RID: 187849
		[Token(Token = "0x402DDC9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _itemObject;

		// Token: 0x0402DDCA RID: 187850
		[Token(Token = "0x402DDCA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x0402DDCB RID: 187851
		[Token(Token = "0x402DDCB")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0402DDCC RID: 187852
		[Token(Token = "0x402DDCC")]
		[FieldOffset(Offset = "0x48")]
		private UIItemCard m_uiItemCard;

		// Token: 0x0402DDCD RID: 187853
		[Token(Token = "0x402DDCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DDCE RID: 187854
		[Token(Token = "0x402DDCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DDCF RID: 187855
		[Token(Token = "0x402DDCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
