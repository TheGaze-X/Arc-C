using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B77 RID: 15223
	[Token(Token = "0x2003B77")]
	public class TermDescriptionTipItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017DDD RID: 97757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DDD")]
		[Address(RVA = "0x101DB00", Offset = "0x101C700", VA = "0x18101DB00")]
		public void RenderTermTip(UITermDescViewModel viewModel, int termCount, bool isFlow)
		{
		}

		// Token: 0x06017DDE RID: 97758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DDE")]
		[Address(RVA = "0x101E930", Offset = "0x101D530", VA = "0x18101E930")]
		private void _SetLayoutState(bool isHide)
		{
		}

		// Token: 0x06017DDF RID: 97759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DDF")]
		[Address(RVA = "0x101E870", Offset = "0x101D470", VA = "0x18101E870")]
		private void _SetContainerState(float endPosY)
		{
		}

		// Token: 0x06017DE0 RID: 97760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE0")]
		[Address(RVA = "0x101ED10", Offset = "0x101D910", VA = "0x18101ED10")]
		private void _StartShowTween()
		{
		}

		// Token: 0x06017DE1 RID: 97761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE1")]
		[Address(RVA = "0x101EA80", Offset = "0x101D680", VA = "0x18101EA80")]
		private void _StartHideTween()
		{
		}

		// Token: 0x06017DE2 RID: 97762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE2")]
		[Address(RVA = "0x101E790", Offset = "0x101D390", VA = "0x18101E790")]
		private void _ResetContainerPos()
		{
		}

		// Token: 0x06017DE3 RID: 97763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE3")]
		[Address(RVA = "0x101E800", Offset = "0x101D400", VA = "0x18101E800")]
		private void _SetContainerPosToTop()
		{
		}

		// Token: 0x06017DE4 RID: 97764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE4")]
		[Address(RVA = "0x101E530", Offset = "0x101D130", VA = "0x18101E530")]
		private void _PlayShowAnimation(bool isSublinTop, bool isFlow)
		{
		}

		// Token: 0x06017DE5 RID: 97765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE5")]
		[Address(RVA = "0x101E400", Offset = "0x101D000", VA = "0x18101E400")]
		private void _PlayHideAnimation(bool isSublinTop, bool isFlow)
		{
		}

		// Token: 0x06017DE6 RID: 97766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE6")]
		[Address(RVA = "0x101E0F0", Offset = "0x101CCF0", VA = "0x18101E0F0")]
		private void _InitTerm(string termId, UICommentedTextData.InfoType termType, bool isFlow, bool isSublinTop)
		{
		}

		// Token: 0x06017DE7 RID: 97767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE7")]
		[Address(RVA = "0x101E640", Offset = "0x101D240", VA = "0x18101E640")]
		private void _RenderRange(AttackRangeDescModel atkRange)
		{
		}

		// Token: 0x06017DE8 RID: 97768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE8")]
		[Address(RVA = "0x101E6E0", Offset = "0x101D2E0", VA = "0x18101E6E0")]
		private void _RenderText(TermDescriptionData viewData)
		{
		}

		// Token: 0x06017DE9 RID: 97769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DE9")]
		[Address(RVA = "0x101DA90", Offset = "0x101C690", VA = "0x18101DA90")]
		public void OnClickEvent()
		{
		}

		// Token: 0x06017DEA RID: 97770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DEA")]
		[Address(RVA = "0x101EF60", Offset = "0x101DB60", VA = "0x18101EF60")]
		public TermDescriptionTipItemView()
		{
		}

		// Token: 0x0401CD64 RID: 118116
		[Token(Token = "0x401CD64")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICommentedText _textDesc;

		// Token: 0x0401CD65 RID: 118117
		[Token(Token = "0x401CD65")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _darkColorComment;

		// Token: 0x0401CD66 RID: 118118
		[Token(Token = "0x401CD66")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0401CD67 RID: 118119
		[Token(Token = "0x401CD67")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _rangeContainer;

		// Token: 0x0401CD68 RID: 118120
		[Token(Token = "0x401CD68")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0401CD69 RID: 118121
		[Token(Token = "0x401CD69")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _uiContainer;

		// Token: 0x0401CD6A RID: 118122
		[Token(Token = "0x401CD6A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _uiCanvasGroup;

		// Token: 0x0401CD6B RID: 118123
		[Token(Token = "0x401CD6B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x0401CD6C RID: 118124
		[Token(Token = "0x401CD6C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _btn;

		// Token: 0x0401CD6D RID: 118125
		[Token(Token = "0x401CD6D")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_showTween;

		// Token: 0x0401CD6E RID: 118126
		[Token(Token = "0x401CD6E")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedIdx;

		// Token: 0x0401CD6F RID: 118127
		[Token(Token = "0x401CD6F")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_showUITween;

		// Token: 0x0401CD70 RID: 118128
		[Token(Token = "0x401CD70")]
		private const float TWEEN_DURATION = 0.23f;

		// Token: 0x0401CD71 RID: 118129
		[Token(Token = "0x401CD71")]
		private const float TWEEN_FADEIN_DURATION = 0.23f;

		// Token: 0x0401CD72 RID: 118130
		[Token(Token = "0x401CD72")]
		private const float CONST_HEIGHT = 55f;

		// Token: 0x0401CD73 RID: 118131
		[Token(Token = "0x401CD73")]
		private const float TERM_DESC_OFFSET_Y = 100f;

		// Token: 0x0401CD74 RID: 118132
		[Token(Token = "0x401CD74")]
		private const float TERM_DESC_ORIGIN_Y = 0f;

		// Token: 0x0401CD75 RID: 118133
		[Token(Token = "0x401CD75")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action clickEvent;

		// Token: 0x0401CD76 RID: 118134
		[Token(Token = "0x401CD76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderTermTip;

		// Token: 0x0401CD77 RID: 118135
		[Token(Token = "0x401CD77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetLayoutState;

		// Token: 0x0401CD78 RID: 118136
		[Token(Token = "0x401CD78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetContainerState;

		// Token: 0x0401CD79 RID: 118137
		[Token(Token = "0x401CD79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__StartShowTween;

		// Token: 0x0401CD7A RID: 118138
		[Token(Token = "0x401CD7A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StartHideTween;

		// Token: 0x0401CD7B RID: 118139
		[Token(Token = "0x401CD7B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetContainerPos;

		// Token: 0x0401CD7C RID: 118140
		[Token(Token = "0x401CD7C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetContainerPosToTop;

		// Token: 0x0401CD7D RID: 118141
		[Token(Token = "0x401CD7D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayShowAnimation;

		// Token: 0x0401CD7E RID: 118142
		[Token(Token = "0x401CD7E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayHideAnimation;

		// Token: 0x0401CD7F RID: 118143
		[Token(Token = "0x401CD7F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitTerm;

		// Token: 0x0401CD80 RID: 118144
		[Token(Token = "0x401CD80")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderRange;

		// Token: 0x0401CD81 RID: 118145
		[Token(Token = "0x401CD81")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderText;

		// Token: 0x0401CD82 RID: 118146
		[Token(Token = "0x401CD82")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x0401CD83 RID: 118147
		[Token(Token = "0x401CD83")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
