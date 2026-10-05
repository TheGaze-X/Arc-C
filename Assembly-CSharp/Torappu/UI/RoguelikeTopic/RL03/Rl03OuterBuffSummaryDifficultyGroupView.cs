using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045D4 RID: 17876
	[Token(Token = "0x20045D4")]
	public class Rl03OuterBuffSummaryDifficultyGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B312 RID: 111378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B312")]
		[Address(RVA = "0x14680E0", Offset = "0x1466CE0", VA = "0x1814680E0")]
		public void Render(string topicId, Rl03OuterBuffSummaryDifficultyItemModel viewModel)
		{
		}

		// Token: 0x0601B313 RID: 111379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B313")]
		[Address(RVA = "0x14685E0", Offset = "0x14671E0", VA = "0x1814685E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B314 RID: 111380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B314")]
		[Address(RVA = "0x1468730", Offset = "0x1467330", VA = "0x181468730")]
		public Rl03OuterBuffSummaryDifficultyGroupView()
		{
		}

		// Token: 0x0402309C RID: 143516
		[Token(Token = "0x402309C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402309D RID: 143517
		[Token(Token = "0x402309D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _deco;

		// Token: 0x0402309E RID: 143518
		[Token(Token = "0x402309E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _title;

		// Token: 0x0402309F RID: 143519
		[Token(Token = "0x402309F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _effectDesc;

		// Token: 0x040230A0 RID: 143520
		[Token(Token = "0x40230A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelEffect;

		// Token: 0x040230A1 RID: 143521
		[Token(Token = "0x40230A1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040230A2 RID: 143522
		[Token(Token = "0x40230A2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040230A3 RID: 143523
		[Token(Token = "0x40230A3")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x040230A4 RID: 143524
		[Token(Token = "0x40230A4")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040230A5 RID: 143525
		[Token(Token = "0x40230A5")]
		[FieldOffset(Offset = "0x68")]
		private Rl03OuterBuffSummaryDifficultyGroupView.RawTextAdapter m_adapter;

		// Token: 0x040230A6 RID: 143526
		[Token(Token = "0x40230A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040230A7 RID: 143527
		[Token(Token = "0x40230A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040230A8 RID: 143528
		[Token(Token = "0x40230A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045D5 RID: 17877
		[Token(Token = "0x20045D5")]
		private class RawTextAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170040C5 RID: 16581
			// (get) Token: 0x0601B315 RID: 111381 RVA: 0x000A4940 File Offset: 0x000A2B40
			[Token(Token = "0x170040C5")]
			public override int count
			{
				[Token(Token = "0x601B315")]
				[Address(RVA = "0x14669D0", Offset = "0x14655D0", VA = "0x1814669D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B316 RID: 111382 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B316")]
			[Address(RVA = "0x1466180", Offset = "0x1464D80", VA = "0x181466180", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B317 RID: 111383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B317")]
			[Address(RVA = "0x1466830", Offset = "0x1465430", VA = "0x181466830")]
			public RawTextAdapter()
			{
			}

			// Token: 0x040230A9 RID: 143529
			[Token(Token = "0x40230A9")]
			[FieldOffset(Offset = "0x20")]
			public List<string> datas;

			// Token: 0x040230AA RID: 143530
			[Token(Token = "0x40230AA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040230AB RID: 143531
			[Token(Token = "0x40230AB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040230AC RID: 143532
			[Token(Token = "0x40230AC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
