using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007376 RID: 29558
	[Token(Token = "0x2007376")]
	public class Act42D0EffectSelectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029CA4 RID: 171172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CA4")]
		[Address(RVA = "0x255A670", Offset = "0x2559270", VA = "0x18255A670")]
		public void Render(Act42D0EffectItemViewModel viewModel, int sequenceNum)
		{
		}

		// Token: 0x06029CA5 RID: 171173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CA5")]
		[Address(RVA = "0x255AB10", Offset = "0x2559710", VA = "0x18255AB10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029CA6 RID: 171174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CA6")]
		[Address(RVA = "0x255A460", Offset = "0x2559060", VA = "0x18255A460")]
		public void OnClick()
		{
		}

		// Token: 0x06029CA7 RID: 171175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CA7")]
		[Address(RVA = "0x255AC50", Offset = "0x2559850", VA = "0x18255AC50")]
		public Act42D0EffectSelectItemView()
		{
		}

		// Token: 0x0403BD60 RID: 245088
		[Token(Token = "0x403BD60")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _bg;

		// Token: 0x0403BD61 RID: 245089
		[Token(Token = "0x403BD61")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _cost;

		// Token: 0x0403BD62 RID: 245090
		[Token(Token = "0x403BD62")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403BD63 RID: 245091
		[Token(Token = "0x403BD63")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403BD64 RID: 245092
		[Token(Token = "0x403BD64")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _lightAnim;

		// Token: 0x0403BD65 RID: 245093
		[Token(Token = "0x403BD65")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _light;

		// Token: 0x0403BD66 RID: 245094
		[Token(Token = "0x403BD66")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _lightCanvasGroup;

		// Token: 0x0403BD67 RID: 245095
		[Token(Token = "0x403BD67")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _selectBgColor;

		// Token: 0x0403BD68 RID: 245096
		[Token(Token = "0x403BD68")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _unselectBgColor;

		// Token: 0x0403BD69 RID: 245097
		[Token(Token = "0x403BD69")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _selectColor;

		// Token: 0x0403BD6A RID: 245098
		[Token(Token = "0x403BD6A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _unselectColor;

		// Token: 0x0403BD6B RID: 245099
		[Token(Token = "0x403BD6B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelNull;

		// Token: 0x0403BD6C RID: 245100
		[Token(Token = "0x403BD6C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelView;

		// Token: 0x0403BD6D RID: 245101
		[Token(Token = "0x403BD6D")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0403BD6E RID: 245102
		[Token(Token = "0x403BD6E")]
		[FieldOffset(Offset = "0xB0")]
		private Act42D0EffectSelectItemView.SelectSwithTween m_switchTween;

		// Token: 0x0403BD6F RID: 245103
		[Token(Token = "0x403BD6F")]
		[FieldOffset(Offset = "0xB8")]
		private Act42D0EffectItemViewModel m_cachedViewModel;

		// Token: 0x0403BD70 RID: 245104
		[Token(Token = "0x403BD70")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BD71 RID: 245105
		[Token(Token = "0x403BD71")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cachedSequenceNum;

		// Token: 0x0403BD72 RID: 245106
		[Token(Token = "0x403BD72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BD73 RID: 245107
		[Token(Token = "0x403BD73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BD74 RID: 245108
		[Token(Token = "0x403BD74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403BD75 RID: 245109
		[Token(Token = "0x403BD75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007377 RID: 29559
		[Token(Token = "0x2007377")]
		private class SelectSwithTween : UISwitchTween
		{
			// Token: 0x06029CA8 RID: 171176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CA8")]
			[Address(RVA = "0x25681F0", Offset = "0x2566DF0", VA = "0x1825681F0")]
			public SelectSwithTween(Act42D0EffectSelectItemView closure)
			{
			}

			// Token: 0x06029CA9 RID: 171177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029CA9")]
			[Address(RVA = "0x2567D40", Offset = "0x2566940", VA = "0x182567D40", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06029CAA RID: 171178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029CAA")]
			[Address(RVA = "0x2567AC0", Offset = "0x25666C0", VA = "0x182567AC0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06029CAB RID: 171179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CAB")]
			[Address(RVA = "0x2567A40", Offset = "0x2566640", VA = "0x182567A40", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06029CAC RID: 171180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CAC")]
			[Address(RVA = "0x25679C0", Offset = "0x25665C0", VA = "0x1825679C0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06029CAD RID: 171181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CAD")]
			[Address(RVA = "0x25680A0", Offset = "0x2566CA0", VA = "0x1825680A0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06029CAE RID: 171182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CAE")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06029CAF RID: 171183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CAF")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x06029CB0 RID: 171184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CB0")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403BD76 RID: 245110
			[Token(Token = "0x403BD76")]
			[FieldOffset(Offset = "0x48")]
			private Act42D0EffectSelectItemView m_closure;

			// Token: 0x0403BD77 RID: 245111
			[Token(Token = "0x403BD77")]
			[FieldOffset(Offset = "0x50")]
			private Tween m_lightTween;

			// Token: 0x0403BD78 RID: 245112
			[Token(Token = "0x403BD78")]
			private const float ANIM_DURATION = 0.12f;

			// Token: 0x0403BD79 RID: 245113
			[Token(Token = "0x403BD79")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BD7A RID: 245114
			[Token(Token = "0x403BD7A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403BD7B RID: 245115
			[Token(Token = "0x403BD7B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403BD7C RID: 245116
			[Token(Token = "0x403BD7C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403BD7D RID: 245117
			[Token(Token = "0x403BD7D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0403BD7E RID: 245118
			[Token(Token = "0x403BD7E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
