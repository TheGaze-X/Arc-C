using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044F4 RID: 17652
	[Token(Token = "0x20044F4")]
	public class RoguelikeCommonOuterBuffBottomDifficultyView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF1D RID: 110365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF1D")]
		[Address(RVA = "0x14189A0", Offset = "0x14175A0", VA = "0x1814189A0")]
		public void Render(RoguelikeCommonOuterBuffDifficultyNodeViewModel viewModel)
		{
		}

		// Token: 0x0601AF1E RID: 110366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF1E")]
		[Address(RVA = "0x1418F30", Offset = "0x1417B30", VA = "0x181418F30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AF1F RID: 110367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF1F")]
		[Address(RVA = "0x1419080", Offset = "0x1417C80", VA = "0x181419080")]
		public RoguelikeCommonOuterBuffBottomDifficultyView()
		{
		}

		// Token: 0x0402290C RID: 141580
		[Token(Token = "0x402290C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _difficultDeco;

		// Token: 0x0402290D RID: 141581
		[Token(Token = "0x402290D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _difficultName;

		// Token: 0x0402290E RID: 141582
		[Token(Token = "0x402290E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEffect;

		// Token: 0x0402290F RID: 141583
		[Token(Token = "0x402290F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNoEffect;

		// Token: 0x04022910 RID: 141584
		[Token(Token = "0x4022910")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x04022911 RID: 141585
		[Token(Token = "0x4022911")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelInactive;

		// Token: 0x04022912 RID: 141586
		[Token(Token = "0x4022912")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _enableDesc;

		// Token: 0x04022913 RID: 141587
		[Token(Token = "0x4022913")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _difficultContent;

		// Token: 0x04022914 RID: 141588
		[Token(Token = "0x4022914")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04022915 RID: 141589
		[Token(Token = "0x4022915")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04022916 RID: 141590
		[Token(Token = "0x4022916")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeCommonOuterBuffBottomDifficultyView.ContentAdapter m_adapter;

		// Token: 0x04022917 RID: 141591
		[Token(Token = "0x4022917")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022918 RID: 141592
		[Token(Token = "0x4022918")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022919 RID: 141593
		[Token(Token = "0x4022919")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044F5 RID: 17653
		[Token(Token = "0x20044F5")]
		private class ContentAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003FFC RID: 16380
			// (get) Token: 0x0601AF20 RID: 110368 RVA: 0x000A3B78 File Offset: 0x000A1D78
			[Token(Token = "0x17003FFC")]
			public override int count
			{
				[Token(Token = "0x601AF20")]
				[Address(RVA = "0x1416CC0", Offset = "0x14158C0", VA = "0x181416CC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AF21 RID: 110369 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AF21")]
			[Address(RVA = "0x1416A20", Offset = "0x1415620", VA = "0x181416A20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AF22 RID: 110370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AF22")]
			[Address(RVA = "0x1416C60", Offset = "0x1415860", VA = "0x181416C60")]
			public ContentAdapter()
			{
			}

			// Token: 0x0402291A RID: 141594
			[Token(Token = "0x402291A")]
			[FieldOffset(Offset = "0x20")]
			public List<string> datas;

			// Token: 0x0402291B RID: 141595
			[Token(Token = "0x402291B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402291C RID: 141596
			[Token(Token = "0x402291C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402291D RID: 141597
			[Token(Token = "0x402291D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
