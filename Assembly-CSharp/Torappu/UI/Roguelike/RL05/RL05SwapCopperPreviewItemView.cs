using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055B9 RID: 21945
	[Token(Token = "0x20055B9")]
	public class RL05SwapCopperPreviewItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602037C RID: 131964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602037C")]
		[Address(RVA = "0x1A5C4C0", Offset = "0x1A5B0C0", VA = "0x181A5C4C0")]
		public void Render(IRoguelikeCopperItemModel model)
		{
		}

		// Token: 0x0602037D RID: 131965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602037D")]
		[Address(RVA = "0x1A5CA30", Offset = "0x1A5B630", VA = "0x181A5CA30")]
		public RL05SwapCopperPreviewItemView()
		{
		}

		// Token: 0x0402B941 RID: 178497
		[Token(Token = "0x402B941")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _copperItemContent;

		// Token: 0x0402B942 RID: 178498
		[Token(Token = "0x402B942")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402B943 RID: 178499
		[Token(Token = "0x402B943")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402B944 RID: 178500
		[Token(Token = "0x402B944")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _luckyIcon;

		// Token: 0x0402B945 RID: 178501
		[Token(Token = "0x402B945")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _emptyObjList;

		// Token: 0x0402B946 RID: 178502
		[Token(Token = "0x402B946")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _displayObjList;

		// Token: 0x0402B947 RID: 178503
		[Token(Token = "0x402B947")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0402B948 RID: 178504
		[Token(Token = "0x402B948")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402B949 RID: 178505
		[Token(Token = "0x402B949")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402B94A RID: 178506
		[Token(Token = "0x402B94A")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeAbstractCopperItemCard m_copperCard;

		// Token: 0x0402B94B RID: 178507
		[Token(Token = "0x402B94B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B94C RID: 178508
		[Token(Token = "0x402B94C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
