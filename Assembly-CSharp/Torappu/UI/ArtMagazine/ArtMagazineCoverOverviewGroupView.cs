using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006537 RID: 25911
	[Token(Token = "0x2006537")]
	public class ArtMagazineCoverOverviewGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060253E0 RID: 152544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253E0")]
		[Address(RVA = "0x202F740", Offset = "0x202E340", VA = "0x18202F740")]
		public void Render(ArtMagazineCoverOverviewGroupViewModel viewModel)
		{
		}

		// Token: 0x060253E1 RID: 152545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253E1")]
		[Address(RVA = "0x202F900", Offset = "0x202E500", VA = "0x18202F900")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060253E2 RID: 152546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253E2")]
		[Address(RVA = "0x202FA20", Offset = "0x202E620", VA = "0x18202FA20")]
		public ArtMagazineCoverOverviewGroupView()
		{
		}

		// Token: 0x040343F3 RID: 214003
		[Token(Token = "0x40343F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x040343F4 RID: 214004
		[Token(Token = "0x40343F4")]
		[FieldOffset(Offset = "0x20")]
		private bool m_inited;

		// Token: 0x040343F5 RID: 214005
		[Token(Token = "0x40343F5")]
		[FieldOffset(Offset = "0x28")]
		private ArtMagazineCoverOverviewGroupView.LeafItemsAdapter m_leafItemsAdapter;

		// Token: 0x040343F6 RID: 214006
		[Token(Token = "0x40343F6")]
		[FieldOffset(Offset = "0x30")]
		private List<ArtMagazineCoverOverviewItemViewModel> m_cachedItemViewModels;

		// Token: 0x040343F7 RID: 214007
		[Token(Token = "0x40343F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040343F8 RID: 214008
		[Token(Token = "0x40343F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040343F9 RID: 214009
		[Token(Token = "0x40343F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006538 RID: 25912
		[Token(Token = "0x2006538")]
		private class LeafItemsAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060253E3 RID: 152547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60253E3")]
			[Address(RVA = "0x2040A40", Offset = "0x203F640", VA = "0x182040A40")]
			public LeafItemsAdapter(ArtMagazineCoverOverviewGroupView closure)
			{
			}

			// Token: 0x170057EB RID: 22507
			// (get) Token: 0x060253E4 RID: 152548 RVA: 0x000C7260 File Offset: 0x000C5460
			[Token(Token = "0x170057EB")]
			public override int count
			{
				[Token(Token = "0x60253E4")]
				[Address(RVA = "0x2040AC0", Offset = "0x203F6C0", VA = "0x182040AC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060253E5 RID: 152549 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60253E5")]
			[Address(RVA = "0x20408A0", Offset = "0x203F4A0", VA = "0x1820408A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040343FA RID: 214010
			[Token(Token = "0x40343FA")]
			[FieldOffset(Offset = "0x20")]
			private ArtMagazineCoverOverviewGroupView m_closure;

			// Token: 0x040343FB RID: 214011
			[Token(Token = "0x40343FB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040343FC RID: 214012
			[Token(Token = "0x40343FC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040343FD RID: 214013
			[Token(Token = "0x40343FD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
