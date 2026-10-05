using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CB8 RID: 15544
	[Token(Token = "0x2003CB8")]
	public class TuningHomeMajorInvestDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060183E7 RID: 99303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183E7")]
		[Address(RVA = "0x10BC000", Offset = "0x10BAC00", VA = "0x1810BC000")]
		public void Render(TuningHomeMajorInvestItemViewModel model, bool isLast)
		{
		}

		// Token: 0x060183E8 RID: 99304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183E8")]
		[Address(RVA = "0x10BC3A0", Offset = "0x10BAFA0", VA = "0x1810BC3A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060183E9 RID: 99305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183E9")]
		[Address(RVA = "0x10BC5C0", Offset = "0x10BB1C0", VA = "0x1810BC5C0")]
		private void _OnItemCardClick(int index)
		{
		}

		// Token: 0x060183EA RID: 99306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183EA")]
		[Address(RVA = "0x10BC730", Offset = "0x10BB330", VA = "0x1810BC730")]
		public TuningHomeMajorInvestDetailItemView()
		{
		}

		// Token: 0x0401D905 RID: 121093
		[Token(Token = "0x401D905")]
		private const float ALPHA_ITEM_CARD_COMPLETE = 0.5f;

		// Token: 0x0401D906 RID: 121094
		[Token(Token = "0x401D906")]
		private const float ALPHA_ITEM_CARD_NORMAL = 1f;

		// Token: 0x0401D907 RID: 121095
		[Token(Token = "0x401D907")]
		private const float ITEM_CARD_SCALE = 0.35f;

		// Token: 0x0401D908 RID: 121096
		[Token(Token = "0x401D908")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_AVATAR_COMPLETE;

		// Token: 0x0401D909 RID: 121097
		[Token(Token = "0x401D909")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_AVATAR_UNCOMPLETE;

		// Token: 0x0401D90A RID: 121098
		[Token(Token = "0x401D90A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _panelComplete;

		// Token: 0x0401D90B RID: 121099
		[Token(Token = "0x401D90B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _panelUncomplete;

		// Token: 0x0401D90C RID: 121100
		[Token(Token = "0x401D90C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNext;

		// Token: 0x0401D90D RID: 121101
		[Token(Token = "0x401D90D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCharAvatar;

		// Token: 0x0401D90E RID: 121102
		[Token(Token = "0x401D90E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x0401D90F RID: 121103
		[Token(Token = "0x401D90F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroupItemCard;

		// Token: 0x0401D910 RID: 121104
		[Token(Token = "0x401D910")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0401D911 RID: 121105
		[Token(Token = "0x401D911")]
		[FieldOffset(Offset = "0x50")]
		private UIItemCard m_itemCard;

		// Token: 0x0401D912 RID: 121106
		[Token(Token = "0x401D912")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D913 RID: 121107
		[Token(Token = "0x401D913")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D914 RID: 121108
		[Token(Token = "0x401D914")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D915 RID: 121109
		[Token(Token = "0x401D915")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnItemCardClick;

		// Token: 0x0401D916 RID: 121110
		[Token(Token = "0x401D916")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
