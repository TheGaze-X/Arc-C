using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EBE RID: 20158
	[Token(Token = "0x2004EBE")]
	public class FifthAnnivExploreGroupChoiceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E14F RID: 123215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E14F")]
		[Address(RVA = "0x17BBE90", Offset = "0x17BAA90", VA = "0x1817BBE90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E150 RID: 123216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E150")]
		[Address(RVA = "0x17BBCE0", Offset = "0x17BA8E0", VA = "0x1817BBCE0")]
		public void Render(FifthAnnivExploreGroupChoiceItemViewModel viewModel)
		{
		}

		// Token: 0x0601E151 RID: 123217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E151")]
		[Address(RVA = "0x17BBBF0", Offset = "0x17BA7F0", VA = "0x1817BBBF0")]
		public void OnClick()
		{
		}

		// Token: 0x0601E152 RID: 123218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E152")]
		[Address(RVA = "0x17BC050", Offset = "0x17BAC50", VA = "0x1817BC050")]
		public FifthAnnivExploreGroupChoiceItemView()
		{
		}

		// Token: 0x0402802F RID: 163887
		[Token(Token = "0x402802F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _groupNameText;

		// Token: 0x04028030 RID: 163888
		[Token(Token = "0x4028030")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _groupIconImg;

		// Token: 0x04028031 RID: 163889
		[Token(Token = "0x4028031")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasObject _groupIconAtlasObject;

		// Token: 0x04028032 RID: 163890
		[Token(Token = "0x4028032")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _valueGroupViewContainer;

		// Token: 0x04028033 RID: 163891
		[Token(Token = "0x4028033")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04028034 RID: 163892
		[Token(Token = "0x4028034")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04028035 RID: 163893
		[Token(Token = "0x4028035")]
		[FieldOffset(Offset = "0x4C")]
		private int m_cachedPosition;

		// Token: 0x04028036 RID: 163894
		[Token(Token = "0x4028036")]
		[FieldOffset(Offset = "0x50")]
		private FifthAnnivExploreValueGroupView m_exploreValueGroupView;

		// Token: 0x04028037 RID: 163895
		[Token(Token = "0x4028037")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04028038 RID: 163896
		[Token(Token = "0x4028038")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028039 RID: 163897
		[Token(Token = "0x4028039")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_selectTween;

		// Token: 0x0402803A RID: 163898
		[Token(Token = "0x402803A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402803B RID: 163899
		[Token(Token = "0x402803B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402803C RID: 163900
		[Token(Token = "0x402803C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402803D RID: 163901
		[Token(Token = "0x402803D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
