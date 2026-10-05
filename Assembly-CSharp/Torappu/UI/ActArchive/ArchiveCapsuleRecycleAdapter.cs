using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B28 RID: 27432
	[Token(Token = "0x2006B28")]
	public class ArchiveCapsuleRecycleAdapter : RecycleLoopScrollAdapter<ArchiveCapsuleRecycleAdapter.ViewHolder, CapsuleItemModel>
	{
		// Token: 0x17005CA7 RID: 23719
		// (get) Token: 0x0602736A RID: 160618 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602736B RID: 160619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CA7")]
		public ArchiveCapsuleController controller
		{
			[Token(Token = "0x602736A")]
			[Address(RVA = "0x22660C0", Offset = "0x2264CC0", VA = "0x1822660C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602736B")]
			[Address(RVA = "0x2266180", Offset = "0x2264D80", VA = "0x182266180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CA8 RID: 23720
		// (get) Token: 0x0602736C RID: 160620 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602736D RID: 160621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CA8")]
		public string selectItemId
		{
			[Token(Token = "0x602736C")]
			[Address(RVA = "0x2266120", Offset = "0x2264D20", VA = "0x182266120")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602736D")]
			[Address(RVA = "0x2266200", Offset = "0x2264E00", VA = "0x182266200")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602736E RID: 160622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602736E")]
		[Address(RVA = "0x2265B40", Offset = "0x2264740", VA = "0x182265B40")]
		public Sprite LoadItemIcon(string capsuleId)
		{
			return null;
		}

		// Token: 0x0602736F RID: 160623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602736F")]
		[Address(RVA = "0x2265CF0", Offset = "0x22648F0", VA = "0x182265CF0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ArchiveCapsuleRecycleAdapter.ViewHolder holder, CapsuleItemModel data)
		{
		}

		// Token: 0x06027370 RID: 160624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027370")]
		[Address(RVA = "0x2265EC0", Offset = "0x2264AC0", VA = "0x182265EC0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06027371 RID: 160625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027371")]
		[Address(RVA = "0x2266050", Offset = "0x2264C50", VA = "0x182266050")]
		public ArchiveCapsuleRecycleAdapter()
		{
		}

		// Token: 0x040377B5 RID: 227253
		[Token(Token = "0x40377B5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ArchiveCapsuleListItemView _itemPrefab;

		// Token: 0x040377B8 RID: 227256
		[Token(Token = "0x40377B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040377B9 RID: 227257
		[Token(Token = "0x40377B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040377BA RID: 227258
		[Token(Token = "0x40377BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectItemId;

		// Token: 0x040377BB RID: 227259
		[Token(Token = "0x40377BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectItemId;

		// Token: 0x040377BC RID: 227260
		[Token(Token = "0x40377BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadItemIcon;

		// Token: 0x040377BD RID: 227261
		[Token(Token = "0x40377BD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040377BE RID: 227262
		[Token(Token = "0x40377BE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040377BF RID: 227263
		[Token(Token = "0x40377BF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B29 RID: 27433
		[Token(Token = "0x2006B29")]
		public class ViewHolder
		{
			// Token: 0x06027372 RID: 160626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027372")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040377C0 RID: 227264
			[Token(Token = "0x40377C0")]
			[FieldOffset(Offset = "0x10")]
			public ArchiveCapsuleListItemView capsuleItem;
		}
	}
}
