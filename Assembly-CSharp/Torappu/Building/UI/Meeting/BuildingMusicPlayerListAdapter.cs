using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D53 RID: 7507
	[Token(Token = "0x2001D53")]
	public class BuildingMusicPlayerListAdapter : LoopScrollAdapter<BuildingMusicPlayerListAdapter.ViewHolder, BuildingMusicItemViewModel>, IHotfixable
	{
		// Token: 0x0600B949 RID: 47433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B949")]
		[Address(RVA = "0x3362690", Offset = "0x3361290", VA = "0x183362690")]
		public void RenderList(BuildingMusicPlayerViewModel model)
		{
		}

		// Token: 0x0600B94A RID: 47434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B94A")]
		[Address(RVA = "0x33625E0", Offset = "0x33611E0", VA = "0x1833625E0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600B94B RID: 47435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94B")]
		[Address(RVA = "0x3362780", Offset = "0x3361380", VA = "0x183362780", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, BuildingMusicPlayerListAdapter.ViewHolder holder, BuildingMusicItemViewModel data)
		{
		}

		// Token: 0x0600B94C RID: 47436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B94C")]
		[Address(RVA = "0x33628D0", Offset = "0x33614D0", VA = "0x1833628D0")]
		public BuildingMusicPlayerListAdapter()
		{
		}

		// Token: 0x0400B7B0 RID: 47024
		[Token(Token = "0x400B7B0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0400B7B1 RID: 47025
		[Token(Token = "0x400B7B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderList;

		// Token: 0x0400B7B2 RID: 47026
		[Token(Token = "0x400B7B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0400B7B3 RID: 47027
		[Token(Token = "0x400B7B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400B7B4 RID: 47028
		[Token(Token = "0x400B7B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D54 RID: 7508
		[Token(Token = "0x2001D54")]
		public class ViewHolder
		{
			// Token: 0x0600B94D RID: 47437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B94D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0400B7B5 RID: 47029
			[Token(Token = "0x400B7B5")]
			[FieldOffset(Offset = "0x10")]
			public BuildingMusicPlayerItemView view;
		}
	}
}
