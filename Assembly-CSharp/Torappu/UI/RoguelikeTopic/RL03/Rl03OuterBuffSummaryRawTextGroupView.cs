using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045DD RID: 17885
	[Token(Token = "0x20045DD")]
	public class Rl03OuterBuffSummaryRawTextGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B32A RID: 111402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B32A")]
		[Address(RVA = "0x14697E0", Offset = "0x14683E0", VA = "0x1814697E0")]
		public void Render(string topicId, Rl03OuterBuffSummaryRawTextGroupItemModel viewModel, bool hasBack)
		{
		}

		// Token: 0x0601B32B RID: 111403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B32B")]
		[Address(RVA = "0x1469B50", Offset = "0x1468750", VA = "0x181469B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B32C RID: 111404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B32C")]
		[Address(RVA = "0x1469CA0", Offset = "0x14688A0", VA = "0x181469CA0")]
		public Rl03OuterBuffSummaryRawTextGroupView()
		{
		}

		// Token: 0x040230D6 RID: 143574
		[Token(Token = "0x40230D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040230D7 RID: 143575
		[Token(Token = "0x40230D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _back;

		// Token: 0x040230D8 RID: 143576
		[Token(Token = "0x40230D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _iconLevelGroup;

		// Token: 0x040230D9 RID: 143577
		[Token(Token = "0x40230D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040230DA RID: 143578
		[Token(Token = "0x40230DA")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x040230DB RID: 143579
		[Token(Token = "0x40230DB")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040230DC RID: 143580
		[Token(Token = "0x40230DC")]
		[FieldOffset(Offset = "0x50")]
		private Rl03OuterBuffSummaryRawTextGroupView.RawTextAdapter m_adapter;

		// Token: 0x040230DD RID: 143581
		[Token(Token = "0x40230DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040230DE RID: 143582
		[Token(Token = "0x40230DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040230DF RID: 143583
		[Token(Token = "0x40230DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045DE RID: 17886
		[Token(Token = "0x20045DE")]
		private class RawTextAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170040C8 RID: 16584
			// (get) Token: 0x0601B32D RID: 111405 RVA: 0x000A4988 File Offset: 0x000A2B88
			[Token(Token = "0x170040C8")]
			public override int count
			{
				[Token(Token = "0x601B32D")]
				[Address(RVA = "0x1466960", Offset = "0x1465560", VA = "0x181466960", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B32E RID: 111406 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B32E")]
			[Address(RVA = "0x14663C0", Offset = "0x1464FC0", VA = "0x1814663C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B32F RID: 111407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B32F")]
			[Address(RVA = "0x14667D0", Offset = "0x14653D0", VA = "0x1814667D0")]
			public RawTextAdapter()
			{
			}

			// Token: 0x040230E0 RID: 143584
			[Token(Token = "0x40230E0")]
			[FieldOffset(Offset = "0x20")]
			public List<Rl03OuterBuffSummaryRawTextItemModel> datas;

			// Token: 0x040230E1 RID: 143585
			[Token(Token = "0x40230E1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040230E2 RID: 143586
			[Token(Token = "0x40230E2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040230E3 RID: 143587
			[Token(Token = "0x40230E3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
