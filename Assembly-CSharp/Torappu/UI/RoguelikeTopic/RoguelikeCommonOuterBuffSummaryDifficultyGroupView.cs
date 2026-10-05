using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004508 RID: 17672
	[Token(Token = "0x2004508")]
	public class RoguelikeCommonOuterBuffSummaryDifficultyGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF73 RID: 110451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF73")]
		[Address(RVA = "0x1420DB0", Offset = "0x141F9B0", VA = "0x181420DB0")]
		public void Render(string topicId, RoguelikeCommonOuterBuffSummaryDifficultyItemModel viewModel)
		{
		}

		// Token: 0x0601AF74 RID: 110452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF74")]
		[Address(RVA = "0x1421150", Offset = "0x141FD50", VA = "0x181421150")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF75 RID: 110453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF75")]
		[Address(RVA = "0x14212A0", Offset = "0x141FEA0", VA = "0x1814212A0")]
		public RoguelikeCommonOuterBuffSummaryDifficultyGroupView()
		{
		}

		// Token: 0x040229BE RID: 141758
		[Token(Token = "0x40229BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040229BF RID: 141759
		[Token(Token = "0x40229BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _deco;

		// Token: 0x040229C0 RID: 141760
		[Token(Token = "0x40229C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _title;

		// Token: 0x040229C1 RID: 141761
		[Token(Token = "0x40229C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _enableDesc;

		// Token: 0x040229C2 RID: 141762
		[Token(Token = "0x40229C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelEffect;

		// Token: 0x040229C3 RID: 141763
		[Token(Token = "0x40229C3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040229C4 RID: 141764
		[Token(Token = "0x40229C4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040229C5 RID: 141765
		[Token(Token = "0x40229C5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _inactiveSummaryAlpha;

		// Token: 0x040229C6 RID: 141766
		[Token(Token = "0x40229C6")]
		[FieldOffset(Offset = "0x54")]
		private bool m_isInited;

		// Token: 0x040229C7 RID: 141767
		[Token(Token = "0x40229C7")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040229C8 RID: 141768
		[Token(Token = "0x40229C8")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeCommonOuterBuffSummaryDifficultyGroupView.RawTextAdapter m_adapter;

		// Token: 0x040229C9 RID: 141769
		[Token(Token = "0x40229C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040229CA RID: 141770
		[Token(Token = "0x40229CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040229CB RID: 141771
		[Token(Token = "0x40229CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004509 RID: 17673
		[Token(Token = "0x2004509")]
		private class RawTextAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004004 RID: 16388
			// (get) Token: 0x0601AF76 RID: 110454 RVA: 0x000A3BD8 File Offset: 0x000A1DD8
			[Token(Token = "0x17004004")]
			public override int count
			{
				[Token(Token = "0x601AF76")]
				[Address(RVA = "0x1418780", Offset = "0x1417380", VA = "0x181418780", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AF77 RID: 110455 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AF77")]
			[Address(RVA = "0x1418200", Offset = "0x1416E00", VA = "0x181418200", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AF78 RID: 110456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AF78")]
			[Address(RVA = "0x14186B0", Offset = "0x14172B0", VA = "0x1814186B0")]
			public RawTextAdapter()
			{
			}

			// Token: 0x040229CC RID: 141772
			[Token(Token = "0x40229CC")]
			[FieldOffset(Offset = "0x20")]
			public List<string> datas;

			// Token: 0x040229CD RID: 141773
			[Token(Token = "0x40229CD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040229CE RID: 141774
			[Token(Token = "0x40229CE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040229CF RID: 141775
			[Token(Token = "0x40229CF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
