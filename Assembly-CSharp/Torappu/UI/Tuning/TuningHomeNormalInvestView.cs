using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CA6 RID: 15526
	[Token(Token = "0x2003CA6")]
	public class TuningHomeNormalInvestView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060183AF RID: 99247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183AF")]
		[Address(RVA = "0x10BEB20", Offset = "0x10BD720", VA = "0x1810BEB20")]
		public void Render(TuningHomeNormalInvestViewModel viewModel, int entryAnimSeq)
		{
		}

		// Token: 0x060183B0 RID: 99248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183B0")]
		[Address(RVA = "0x10BE9C0", Offset = "0x10BD5C0", VA = "0x1810BE9C0")]
		public void EventOnStartInvestClicked()
		{
		}

		// Token: 0x060183B1 RID: 99249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183B1")]
		[Address(RVA = "0x10BEFB0", Offset = "0x10BDBB0", VA = "0x1810BEFB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060183B2 RID: 99250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183B2")]
		[Address(RVA = "0x10BF1D0", Offset = "0x10BDDD0", VA = "0x1810BF1D0")]
		private void _OnItemCardClick(int index)
		{
		}

		// Token: 0x060183B3 RID: 99251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183B3")]
		[Address(RVA = "0x10BF2E0", Offset = "0x10BDEE0", VA = "0x1810BF2E0")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x060183B4 RID: 99252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183B4")]
		[Address(RVA = "0x10BF450", Offset = "0x10BE050", VA = "0x1810BF450")]
		public TuningHomeNormalInvestView()
		{
		}

		// Token: 0x0401D888 RID: 120968
		[Token(Token = "0x401D888")]
		private const float ITEM_CARD_SCALE = 0.42f;

		// Token: 0x0401D889 RID: 120969
		[Token(Token = "0x401D889")]
		private const float ALPHA_COMPLETE = 0.5f;

		// Token: 0x0401D88A RID: 120970
		[Token(Token = "0x401D88A")]
		private const float ALPHA_UNCOMPLETE = 1f;

		// Token: 0x0401D88B RID: 120971
		[Token(Token = "0x401D88B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_AVATAR_COMPLETE;

		// Token: 0x0401D88C RID: 120972
		[Token(Token = "0x401D88C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_AVATAR_UNCOMPLETE;

		// Token: 0x0401D88D RID: 120973
		[Token(Token = "0x401D88D")]
		private const string ENTRY_ANIM_NAME = "tuning_home_normal_invest_entry_anim";

		// Token: 0x0401D88E RID: 120974
		[Token(Token = "0x401D88E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _panelComplete;

		// Token: 0x0401D88F RID: 120975
		[Token(Token = "0x401D88F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _panelUncomplete;

		// Token: 0x0401D890 RID: 120976
		[Token(Token = "0x401D890")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgCharAvatar;

		// Token: 0x0401D891 RID: 120977
		[Token(Token = "0x401D891")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _textName;

		// Token: 0x0401D892 RID: 120978
		[Token(Token = "0x401D892")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _panelItemCardContainer;

		// Token: 0x0401D893 RID: 120979
		[Token(Token = "0x401D893")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroupItemCard;

		// Token: 0x0401D894 RID: 120980
		[Token(Token = "0x401D894")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401D895 RID: 120981
		[Token(Token = "0x401D895")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D896 RID: 120982
		[Token(Token = "0x401D896")]
		[FieldOffset(Offset = "0x60")]
		private string m_cacheInvestId;

		// Token: 0x0401D897 RID: 120983
		[Token(Token = "0x401D897")]
		[FieldOffset(Offset = "0x68")]
		private int m_currAnimSeq;

		// Token: 0x0401D898 RID: 120984
		[Token(Token = "0x401D898")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_entryAnim;

		// Token: 0x0401D899 RID: 120985
		[Token(Token = "0x401D899")]
		[FieldOffset(Offset = "0x78")]
		private UIItemCard m_itemCard;

		// Token: 0x0401D89A RID: 120986
		[Token(Token = "0x401D89A")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0401D89B RID: 120987
		[Token(Token = "0x401D89B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D89C RID: 120988
		[Token(Token = "0x401D89C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnStartInvestClicked;

		// Token: 0x0401D89D RID: 120989
		[Token(Token = "0x401D89D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D89E RID: 120990
		[Token(Token = "0x401D89E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnItemCardClick;

		// Token: 0x0401D89F RID: 120991
		[Token(Token = "0x401D89F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0401D8A0 RID: 120992
		[Token(Token = "0x401D8A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
