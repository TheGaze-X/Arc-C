using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B57 RID: 27479
	[Token(Token = "0x2006B57")]
	public class ArchiveCopperListAdapter : LoopScrollAdapter<ArchiveCopperListAdapter.ViewHolder, ArchiveCopperGroupModel>, IHotfixable
	{
		// Token: 0x17005CCB RID: 23755
		// (get) Token: 0x0602744E RID: 160846 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602744F RID: 160847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CCB")]
		public ArchiveCopperController controller
		{
			[Token(Token = "0x602744E")]
			[Address(RVA = "0x2271D00", Offset = "0x2270900", VA = "0x182271D00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602744F")]
			[Address(RVA = "0x2271D60", Offset = "0x2270960", VA = "0x182271D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027450 RID: 160848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027450")]
		[Address(RVA = "0x22719C0", Offset = "0x22705C0", VA = "0x1822719C0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06027451 RID: 160849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027451")]
		[Address(RVA = "0x2271B40", Offset = "0x2270740", VA = "0x182271B40", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, ArchiveCopperListAdapter.ViewHolder holder, ArchiveCopperGroupModel data)
		{
		}

		// Token: 0x06027452 RID: 160850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027452")]
		[Address(RVA = "0x2271C90", Offset = "0x2270890", VA = "0x182271C90")]
		public ArchiveCopperListAdapter()
		{
		}

		// Token: 0x04037978 RID: 227704
		[Token(Token = "0x4037978")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ArchiveCopperGroupView _itemPrefab;

		// Token: 0x0403797A RID: 227706
		[Token(Token = "0x403797A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0403797B RID: 227707
		[Token(Token = "0x403797B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0403797C RID: 227708
		[Token(Token = "0x403797C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0403797D RID: 227709
		[Token(Token = "0x403797D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403797E RID: 227710
		[Token(Token = "0x403797E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B58 RID: 27480
		[Token(Token = "0x2006B58")]
		public class ViewHolder
		{
			// Token: 0x06027453 RID: 160851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027453")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403797F RID: 227711
			[Token(Token = "0x403797F")]
			[FieldOffset(Offset = "0x10")]
			public ArchiveCopperGroupView view;
		}
	}
}
