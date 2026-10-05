using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CD4 RID: 19668
	[Token(Token = "0x2004CD4")]
	public class GroceryOrderStrategyItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D753 RID: 120659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D753")]
		[Address(RVA = "0x1706550", Offset = "0x1705150", VA = "0x181706550")]
		public void Render(GroceryOrderSelfShopStrategyItemViewModel itemViewModel)
		{
		}

		// Token: 0x0601D754 RID: 120660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D754")]
		[Address(RVA = "0x1706AB0", Offset = "0x17056B0", VA = "0x181706AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D755 RID: 120661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D755")]
		[Address(RVA = "0x1706BD0", Offset = "0x17057D0", VA = "0x181706BD0")]
		private void _PlaySelectLoopTween(bool show)
		{
		}

		// Token: 0x0601D756 RID: 120662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D756")]
		[Address(RVA = "0x1706440", Offset = "0x1705040", VA = "0x181706440")]
		public void OnClick()
		{
		}

		// Token: 0x0601D757 RID: 120663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D757")]
		[Address(RVA = "0x1706D30", Offset = "0x1705930", VA = "0x181706D30")]
		public GroceryOrderStrategyItemView()
		{
		}

		// Token: 0x04026D72 RID: 159090
		[Token(Token = "0x4026D72")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("UnSelect")]
		private CanvasGroup _canvasUnSelect;

		// Token: 0x04026D73 RID: 159091
		[Token(Token = "0x4026D73")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("UnSelect")]
		private Text _txtCount;

		// Token: 0x04026D74 RID: 159092
		[Token(Token = "0x4026D74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("UnSelect")]
		private Text _txtStrategy;

		// Token: 0x04026D75 RID: 159093
		[Token(Token = "0x4026D75")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Select")]
		private CanvasGroup _canvasSelect;

		// Token: 0x04026D76 RID: 159094
		[Token(Token = "0x4026D76")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Select")]
		private Text _txtCountSelect;

		// Token: 0x04026D77 RID: 159095
		[Token(Token = "0x4026D77")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Select")]
		private Text _txtStrategySelect;

		// Token: 0x04026D78 RID: 159096
		[Token(Token = "0x4026D78")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Select")]
		private Image _imgMyShopIcon;

		// Token: 0x04026D79 RID: 159097
		[Token(Token = "0x4026D79")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Select")]
		private UIAnimationLocation _animSelectLoop;

		// Token: 0x04026D7A RID: 159098
		[Token(Token = "0x4026D7A")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInit;

		// Token: 0x04026D7B RID: 159099
		[Token(Token = "0x4026D7B")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedGoodId;

		// Token: 0x04026D7C RID: 159100
		[Token(Token = "0x4026D7C")]
		[FieldOffset(Offset = "0x70")]
		private int m_cachedStrategyIndex;

		// Token: 0x04026D7D RID: 159101
		[Token(Token = "0x4026D7D")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026D7E RID: 159102
		[Token(Token = "0x4026D7E")]
		[FieldOffset(Offset = "0x88")]
		private bool m_loopTweenPlaying;

		// Token: 0x04026D7F RID: 159103
		[Token(Token = "0x4026D7F")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_loopSelectTween;

		// Token: 0x04026D80 RID: 159104
		[Token(Token = "0x4026D80")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_unselectTween;

		// Token: 0x04026D81 RID: 159105
		[Token(Token = "0x4026D81")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_selectTween;

		// Token: 0x04026D82 RID: 159106
		[Token(Token = "0x4026D82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026D83 RID: 159107
		[Token(Token = "0x4026D83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026D84 RID: 159108
		[Token(Token = "0x4026D84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlaySelectLoopTween;

		// Token: 0x04026D85 RID: 159109
		[Token(Token = "0x4026D85")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04026D86 RID: 159110
		[Token(Token = "0x4026D86")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
