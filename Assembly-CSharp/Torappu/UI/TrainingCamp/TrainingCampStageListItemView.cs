using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TrainingCamp
{
	// Token: 0x02003D1C RID: 15644
	[Token(Token = "0x2003D1C")]
	public class TrainingCampStageListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601862C RID: 99884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601862C")]
		[Address(RVA = "0x10D36F0", Offset = "0x10D22F0", VA = "0x1810D36F0")]
		public void Render(TrainingCampStageListItemViewModel viewModel)
		{
		}

		// Token: 0x0601862D RID: 99885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601862D")]
		[Address(RVA = "0x10D35C0", Offset = "0x10D21C0", VA = "0x1810D35C0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601862E RID: 99886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601862E")]
		[Address(RVA = "0x10D3AE0", Offset = "0x10D26E0", VA = "0x1810D3AE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601862F RID: 99887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601862F")]
		[Address(RVA = "0x10D3B70", Offset = "0x10D2770", VA = "0x1810D3B70")]
		private void _SetDynContent(TrainingCampStageListItemView.DynContent comp)
		{
		}

		// Token: 0x06018630 RID: 99888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018630")]
		[Address(RVA = "0x10D3CA0", Offset = "0x10D28A0", VA = "0x1810D3CA0")]
		public TrainingCampStageListItemView()
		{
		}

		// Token: 0x0401DD16 RID: 122134
		[Token(Token = "0x401DD16")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainingCampStageListItemView.DynContent _availContent;

		// Token: 0x0401DD17 RID: 122135
		[Token(Token = "0x401DD17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TrainingCampStageListItemView.DynContent _selectContent;

		// Token: 0x0401DD18 RID: 122136
		[Token(Token = "0x401DD18")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TrainingCampStageListItemView.DynContent _doneContent;

		// Token: 0x0401DD19 RID: 122137
		[Token(Token = "0x401DD19")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _doneObj;

		// Token: 0x0401DD1A RID: 122138
		[Token(Token = "0x401DD1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _trackPointObj;

		// Token: 0x0401DD1B RID: 122139
		[Token(Token = "0x401DD1B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _stageViewContainer;

		// Token: 0x0401DD1C RID: 122140
		[Token(Token = "0x401DD1C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _tipsViewContainer;

		// Token: 0x0401DD1D RID: 122141
		[Token(Token = "0x401DD1D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _tipsText;

		// Token: 0x0401DD1E RID: 122142
		[Token(Token = "0x401DD1E")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0401DD1F RID: 122143
		[Token(Token = "0x401DD1F")]
		[FieldOffset(Offset = "0x60")]
		private TrainingCampStageListItemViewModel m_cachedViewModel;

		// Token: 0x0401DD20 RID: 122144
		[Token(Token = "0x401DD20")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401DD21 RID: 122145
		[Token(Token = "0x401DD21")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401DD22 RID: 122146
		[Token(Token = "0x401DD22")]
		[FieldOffset(Offset = "0x88")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0401DD23 RID: 122147
		[Token(Token = "0x401DD23")]
		[FieldOffset(Offset = "0x90")]
		private Sprite m_cachedIcon;

		// Token: 0x0401DD24 RID: 122148
		[Token(Token = "0x401DD24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DD25 RID: 122149
		[Token(Token = "0x401DD25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401DD26 RID: 122150
		[Token(Token = "0x401DD26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DD27 RID: 122151
		[Token(Token = "0x401DD27")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetDynContent;

		// Token: 0x0401DD28 RID: 122152
		[Token(Token = "0x401DD28")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D1D RID: 15645
		[Token(Token = "0x2003D1D")]
		[Serializable]
		private class DynContent
		{
			// Token: 0x06018631 RID: 99889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018631")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DynContent()
			{
			}

			// Token: 0x0401DD29 RID: 122153
			[Token(Token = "0x401DD29")]
			[FieldOffset(Offset = "0x10")]
			public GameObject container;

			// Token: 0x0401DD2A RID: 122154
			[Token(Token = "0x401DD2A")]
			[FieldOffset(Offset = "0x18")]
			public Image iconImg;

			// Token: 0x0401DD2B RID: 122155
			[Token(Token = "0x401DD2B")]
			[FieldOffset(Offset = "0x20")]
			public Text nameText;
		}
	}
}
