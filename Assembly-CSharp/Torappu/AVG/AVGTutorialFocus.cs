using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F73 RID: 8051
	[Token(Token = "0x2001F73")]
	public class AVGTutorialFocus : UIBehaviour, IHotfixable
	{
		// Token: 0x0600C811 RID: 51217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C811")]
		[Address(RVA = "0x3493FC0", Offset = "0x3492BC0", VA = "0x183493FC0")]
		private CanvasGroup _GetCanvasGroup()
		{
			return null;
		}

		// Token: 0x0600C812 RID: 51218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C812")]
		[Address(RVA = "0x3493A80", Offset = "0x3492680", VA = "0x183493A80")]
		public void OnReset()
		{
		}

		// Token: 0x0600C813 RID: 51219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C813")]
		[Address(RVA = "0x3493B70", Offset = "0x3492770", VA = "0x183493B70")]
		public void SetFocus(AVGTutorialFocus.Style style, Vector2 position, Vector2 size, float black, AVGTutorialPanel.AnchorType anchor)
		{
		}

		// Token: 0x0600C814 RID: 51220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C814")]
		[Address(RVA = "0x34938A0", Offset = "0x34924A0", VA = "0x1834938A0")]
		public void Hide()
		{
		}

		// Token: 0x0600C815 RID: 51221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C815")]
		[Address(RVA = "0x3494140", Offset = "0x3492D40", VA = "0x183494140")]
		private void _SetCircle(Vector2 size)
		{
		}

		// Token: 0x0600C816 RID: 51222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C816")]
		[Address(RVA = "0x3494290", Offset = "0x3492E90", VA = "0x183494290")]
		private void _SetHighlightCircle(Vector2 size)
		{
		}

		// Token: 0x0600C817 RID: 51223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C817")]
		[Address(RVA = "0x3494370", Offset = "0x3492F70", VA = "0x183494370")]
		private void _SetHighlightRect(Vector2 size)
		{
		}

		// Token: 0x0600C818 RID: 51224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C818")]
		[Address(RVA = "0x3494090", Offset = "0x3492C90", VA = "0x183494090")]
		private void _RefreshBlackMasks()
		{
		}

		// Token: 0x0600C819 RID: 51225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C819")]
		[Address(RVA = "0x34939F0", Offset = "0x34925F0", VA = "0x1834939F0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x0600C81A RID: 51226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C81A")]
		[Address(RVA = "0x3494400", Offset = "0x3493000", VA = "0x183494400")]
		public AVGTutorialFocus()
		{
		}

		// Token: 0x0600C81B RID: 51227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C81B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x0400CE73 RID: 52851
		[Token(Token = "0x400CE73")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _focusRect;

		// Token: 0x0400CE74 RID: 52852
		[Token(Token = "0x400CE74")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _defaultFadeTime;

		// Token: 0x0400CE75 RID: 52853
		[Token(Token = "0x400CE75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _circleStyle;

		// Token: 0x0400CE76 RID: 52854
		[Token(Token = "0x400CE76")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _extraScale;

		// Token: 0x0400CE77 RID: 52855
		[Token(Token = "0x400CE77")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _highlightCircleStyle;

		// Token: 0x0400CE78 RID: 52856
		[Token(Token = "0x400CE78")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _highlightCircleObj;

		// Token: 0x0400CE79 RID: 52857
		[Token(Token = "0x400CE79")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _highlightRectStyle;

		// Token: 0x0400CE7A RID: 52858
		[Token(Token = "0x400CE7A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _highlightRectObj;

		// Token: 0x0400CE7B RID: 52859
		[Token(Token = "0x400CE7B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICustomAnchor[] _blackMasks;

		// Token: 0x0400CE7C RID: 52860
		[Token(Token = "0x400CE7C")]
		[FieldOffset(Offset = "0x60")]
		private CanvasGroup m_group;

		// Token: 0x0400CE7D RID: 52861
		[Token(Token = "0x400CE7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetCanvasGroup;

		// Token: 0x0400CE7E RID: 52862
		[Token(Token = "0x400CE7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400CE7F RID: 52863
		[Token(Token = "0x400CE7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetFocus;

		// Token: 0x0400CE80 RID: 52864
		[Token(Token = "0x400CE80")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0400CE81 RID: 52865
		[Token(Token = "0x400CE81")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetCircle;

		// Token: 0x0400CE82 RID: 52866
		[Token(Token = "0x400CE82")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetHighlightCircle;

		// Token: 0x0400CE83 RID: 52867
		[Token(Token = "0x400CE83")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetHighlightRect;

		// Token: 0x0400CE84 RID: 52868
		[Token(Token = "0x400CE84")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshBlackMasks;

		// Token: 0x0400CE85 RID: 52869
		[Token(Token = "0x400CE85")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRectTransformDimensionsChange;

		// Token: 0x0400CE86 RID: 52870
		[Token(Token = "0x400CE86")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F74 RID: 8052
		[Token(Token = "0x2001F74")]
		public enum Style
		{
			// Token: 0x0400CE88 RID: 52872
			[Token(Token = "0x400CE88")]
			Circle,
			// Token: 0x0400CE89 RID: 52873
			[Token(Token = "0x400CE89")]
			HighlightCircle,
			// Token: 0x0400CE8A RID: 52874
			[Token(Token = "0x400CE8A")]
			HighlightRect
		}
	}
}
