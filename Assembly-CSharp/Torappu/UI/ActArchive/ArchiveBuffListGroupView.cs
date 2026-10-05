using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B15 RID: 27413
	[Token(Token = "0x2006B15")]
	public class ArchiveBuffListGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005CA1 RID: 23713
		// (get) Token: 0x0602731E RID: 160542 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602731F RID: 160543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CA1")]
		public ActArchiveController controller
		{
			[Token(Token = "0x602731E")]
			[Address(RVA = "0x2257570", Offset = "0x2256170", VA = "0x182257570")]
			private get
			{
				return null;
			}
			[Token(Token = "0x602731F")]
			[Address(RVA = "0x22575D0", Offset = "0x22561D0", VA = "0x1822575D0")]
			set
			{
			}
		}

		// Token: 0x06027320 RID: 160544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027320")]
		[Address(RVA = "0x2257200", Offset = "0x2255E00", VA = "0x182257200")]
		public void Render(ArchiveBuffGroupModel viewModel, string selectedBuffId)
		{
		}

		// Token: 0x06027321 RID: 160545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027321")]
		[Address(RVA = "0x22573F0", Offset = "0x2255FF0", VA = "0x1822573F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027322 RID: 160546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027322")]
		[Address(RVA = "0x2257500", Offset = "0x2256100", VA = "0x182257500")]
		public ArchiveBuffListGroupView()
		{
		}

		// Token: 0x04037725 RID: 227109
		[Token(Token = "0x4037725")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x04037726 RID: 227110
		[Token(Token = "0x4037726")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _title;

		// Token: 0x04037727 RID: 227111
		[Token(Token = "0x4037727")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<string> _titleName;

		// Token: 0x04037728 RID: 227112
		[Token(Token = "0x4037728")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasObject _titleAtlas;

		// Token: 0x04037729 RID: 227113
		[Token(Token = "0x4037729")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLine;

		// Token: 0x0403772A RID: 227114
		[Token(Token = "0x403772A")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403772B RID: 227115
		[Token(Token = "0x403772B")]
		[FieldOffset(Offset = "0x48")]
		private ArchiveBuffListGroupView.ArchiveBuffItemAdapter m_adapter;

		// Token: 0x0403772C RID: 227116
		[Token(Token = "0x403772C")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedGroupIndex;

		// Token: 0x0403772D RID: 227117
		[Token(Token = "0x403772D")]
		[FieldOffset(Offset = "0x58")]
		private ActArchiveController m_controller;

		// Token: 0x0403772E RID: 227118
		[Token(Token = "0x403772E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0403772F RID: 227119
		[Token(Token = "0x403772F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037730 RID: 227120
		[Token(Token = "0x4037730")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037731 RID: 227121
		[Token(Token = "0x4037731")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037732 RID: 227122
		[Token(Token = "0x4037732")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B16 RID: 27414
		[Token(Token = "0x2006B16")]
		public class ArchiveBuffItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06027323 RID: 160547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027323")]
			[Address(RVA = "0x2262CC0", Offset = "0x22618C0", VA = "0x182262CC0")]
			public ArchiveBuffItemAdapter(ArchiveBuffListGroupView closure)
			{
			}

			// Token: 0x17005CA2 RID: 23714
			// (get) Token: 0x06027324 RID: 160548 RVA: 0x000CDA28 File Offset: 0x000CBC28
			[Token(Token = "0x17005CA2")]
			public override int count
			{
				[Token(Token = "0x6027324")]
				[Address(RVA = "0x2262D40", Offset = "0x2261940", VA = "0x182262D40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027325 RID: 160549 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027325")]
			[Address(RVA = "0x2262910", Offset = "0x2261510", VA = "0x182262910", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037733 RID: 227123
			[Token(Token = "0x4037733")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveBuffListGroupView m_closure;

			// Token: 0x04037734 RID: 227124
			[Token(Token = "0x4037734")]
			[FieldOffset(Offset = "0x28")]
			public ArchiveBuffGroupModel viewModel;

			// Token: 0x04037735 RID: 227125
			[Token(Token = "0x4037735")]
			[FieldOffset(Offset = "0x30")]
			public string selectedBuffId;

			// Token: 0x04037736 RID: 227126
			[Token(Token = "0x4037736")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037737 RID: 227127
			[Token(Token = "0x4037737")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037738 RID: 227128
			[Token(Token = "0x4037738")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
