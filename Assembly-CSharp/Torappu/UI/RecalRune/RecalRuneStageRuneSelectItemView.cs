using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047C3 RID: 18371
	[Token(Token = "0x20047C3")]
	public class RecalRuneStageRuneSelectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BCF3 RID: 113907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCF3")]
		[Address(RVA = "0x1532D70", Offset = "0x1531970", VA = "0x181532D70")]
		public void OnClickEvent()
		{
		}

		// Token: 0x0601BCF4 RID: 113908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCF4")]
		[Address(RVA = "0x1532EA0", Offset = "0x1531AA0", VA = "0x181532EA0")]
		public void Render(RecalRuneStageRuneItemViewModel item, bool focused, bool fastMode)
		{
		}

		// Token: 0x0601BCF5 RID: 113909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCF5")]
		[Address(RVA = "0x15331F0", Offset = "0x1531DF0", VA = "0x1815331F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BCF6 RID: 113910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCF6")]
		[Address(RVA = "0x1533580", Offset = "0x1532180", VA = "0x181533580")]
		private void _RenderIcons(RecalRuneStageRuneItemViewModel item)
		{
		}

		// Token: 0x0601BCF7 RID: 113911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCF7")]
		[Address(RVA = "0x1533430", Offset = "0x1532030", VA = "0x181533430")]
		private void _RenderGroups(RecalRuneStageRuneItemViewModel item, bool focused, bool fastMode)
		{
		}

		// Token: 0x0601BCF8 RID: 113912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCF8")]
		[Address(RVA = "0x15336F0", Offset = "0x15322F0", VA = "0x1815336F0")]
		private void _SetGroup(UISwitchTween tween, bool show, bool fastMode)
		{
		}

		// Token: 0x0601BCF9 RID: 113913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCF9")]
		[Address(RVA = "0x15337A0", Offset = "0x15323A0", VA = "0x1815337A0")]
		public RecalRuneStageRuneSelectItemView()
		{
		}

		// Token: 0x040242CE RID: 148174
		[Token(Token = "0x40242CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canSelectGroup;

		// Token: 0x040242CF RID: 148175
		[Token(Token = "0x40242CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x040242D0 RID: 148176
		[Token(Token = "0x40242D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _excludedGroup;

		// Token: 0x040242D1 RID: 148177
		[Token(Token = "0x40242D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _switchDuration;

		// Token: 0x040242D2 RID: 148178
		[Token(Token = "0x40242D2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _focusAnimation;

		// Token: 0x040242D3 RID: 148179
		[Token(Token = "0x40242D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Ease _focusEase;

		// Token: 0x040242D4 RID: 148180
		[Token(Token = "0x40242D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Image> _runeIconImages;

		// Token: 0x040242D5 RID: 148181
		[Token(Token = "0x40242D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _passedVariant;

		// Token: 0x040242D6 RID: 148182
		[Token(Token = "0x40242D6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _scoreVariant;

		// Token: 0x040242D7 RID: 148183
		[Token(Token = "0x40242D7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _scoreText;

		// Token: 0x040242D8 RID: 148184
		[Token(Token = "0x40242D8")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_finder;

		// Token: 0x040242D9 RID: 148185
		[Token(Token = "0x40242D9")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x040242DA RID: 148186
		[Token(Token = "0x40242DA")]
		[FieldOffset(Offset = "0x88")]
		private ILoadAsset m_loadAsset;

		// Token: 0x040242DB RID: 148187
		[Token(Token = "0x40242DB")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_canSelectGroupTween;

		// Token: 0x040242DC RID: 148188
		[Token(Token = "0x40242DC")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_selectedGroupTween;

		// Token: 0x040242DD RID: 148189
		[Token(Token = "0x40242DD")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_excludedGroupTween;

		// Token: 0x040242DE RID: 148190
		[Token(Token = "0x40242DE")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_focusTween;

		// Token: 0x040242DF RID: 148191
		[Token(Token = "0x40242DF")]
		[FieldOffset(Offset = "0xB0")]
		private RecalRuneStageRuneItemViewModel m_cachedItem;

		// Token: 0x040242E0 RID: 148192
		[Token(Token = "0x40242E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x040242E1 RID: 148193
		[Token(Token = "0x40242E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040242E2 RID: 148194
		[Token(Token = "0x40242E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040242E3 RID: 148195
		[Token(Token = "0x40242E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderIcons;

		// Token: 0x040242E4 RID: 148196
		[Token(Token = "0x40242E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderGroups;

		// Token: 0x040242E5 RID: 148197
		[Token(Token = "0x40242E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetGroup;

		// Token: 0x040242E6 RID: 148198
		[Token(Token = "0x40242E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
