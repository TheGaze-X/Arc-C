using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BF6 RID: 27638
	[Token(Token = "0x2006BF6")]
	public class ArchiveQuestListLoopAdapter : LoopScrollAdapter<ArchiveQuestListLoopAdapter.ViewHolder, ArchiveQuestListItemView.ViewParam>
	{
		// Token: 0x17005D25 RID: 23845
		// (get) Token: 0x06027776 RID: 161654 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027777 RID: 161655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D25")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x6027776")]
			[Address(RVA = "0x22AA110", Offset = "0x22A8D10", VA = "0x1822AA110")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027777")]
			[Address(RVA = "0x22AA1E0", Offset = "0x22A8DE0", VA = "0x1822AA1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D26 RID: 23846
		// (get) Token: 0x06027778 RID: 161656 RVA: 0x000CE700 File Offset: 0x000CC900
		// (set) Token: 0x06027779 RID: 161657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D26")]
		public bool initRender
		{
			[Token(Token = "0x6027778")]
			[Address(RVA = "0x22AA0B0", Offset = "0x22A8CB0", VA = "0x1822AA0B0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6027779")]
			[Address(RVA = "0x22AA170", Offset = "0x22A8D70", VA = "0x1822AA170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602777A RID: 161658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602777A")]
		[Address(RVA = "0x22A9D50", Offset = "0x22A8950", VA = "0x1822A9D50", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602777B RID: 161659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602777B")]
		[Address(RVA = "0x22A9E10", Offset = "0x22A8A10", VA = "0x1822A9E10", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ArchiveQuestListLoopAdapter.ViewHolder holder, ArchiveQuestListItemView.ViewParam data)
		{
		}

		// Token: 0x0602777C RID: 161660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602777C")]
		[Address(RVA = "0x22AA040", Offset = "0x22A8C40", VA = "0x1822AA040")]
		public ArchiveQuestListLoopAdapter()
		{
		}

		// Token: 0x04037EED RID: 229101
		[Token(Token = "0x4037EED")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ArchiveQuestListItemView _itemPrefab;

		// Token: 0x04037EF0 RID: 229104
		[Token(Token = "0x4037EF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x04037EF1 RID: 229105
		[Token(Token = "0x4037EF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x04037EF2 RID: 229106
		[Token(Token = "0x4037EF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_initRender;

		// Token: 0x04037EF3 RID: 229107
		[Token(Token = "0x4037EF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_initRender;

		// Token: 0x04037EF4 RID: 229108
		[Token(Token = "0x4037EF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04037EF5 RID: 229109
		[Token(Token = "0x4037EF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04037EF6 RID: 229110
		[Token(Token = "0x4037EF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BF7 RID: 27639
		[Token(Token = "0x2006BF7")]
		public class ViewHolder
		{
			// Token: 0x0602777D RID: 161661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602777D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04037EF7 RID: 229111
			[Token(Token = "0x4037EF7")]
			[FieldOffset(Offset = "0x10")]
			public ArchiveQuestListItemView view;
		}
	}
}
