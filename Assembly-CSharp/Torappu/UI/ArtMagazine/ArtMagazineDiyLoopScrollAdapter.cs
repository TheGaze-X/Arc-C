using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065A5 RID: 26021
	[Token(Token = "0x20065A5")]
	public class ArtMagazineDiyLoopScrollAdapter : LoopScrollAdapter<ArtMagazineDiyLoopScrollAdapter.ViewHolder, IArtMagazineDiyItemViewModel>
	{
		// Token: 0x06025682 RID: 153218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025682")]
		[Address(RVA = "0x2063BA0", Offset = "0x20627A0", VA = "0x182063BA0")]
		public void UpdateData(IArtMagazineDiyRecycleGroupViewModel groupModel)
		{
		}

		// Token: 0x06025683 RID: 153219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025683")]
		[Address(RVA = "0x2063AE0", Offset = "0x20626E0", VA = "0x182063AE0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06025684 RID: 153220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025684")]
		[Address(RVA = "0x2063D00", Offset = "0x2062900", VA = "0x182063D00", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ArtMagazineDiyLoopScrollAdapter.ViewHolder holder, IArtMagazineDiyItemViewModel data)
		{
		}

		// Token: 0x06025685 RID: 153221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025685")]
		[Address(RVA = "0x2063F30", Offset = "0x2062B30", VA = "0x182063F30")]
		public ArtMagazineDiyLoopScrollAdapter()
		{
		}

		// Token: 0x040347D7 RID: 214999
		[Token(Token = "0x40347D7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ArtMagazineDiyGridItemBase _itemPrefab;

		// Token: 0x040347D8 RID: 215000
		[Token(Token = "0x40347D8")]
		[FieldOffset(Offset = "0x60")]
		private HashSet<string> m_selectedItemIds;

		// Token: 0x040347D9 RID: 215001
		[Token(Token = "0x40347D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040347DA RID: 215002
		[Token(Token = "0x40347DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040347DB RID: 215003
		[Token(Token = "0x40347DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040347DC RID: 215004
		[Token(Token = "0x40347DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065A6 RID: 26022
		[Token(Token = "0x20065A6")]
		public class ViewHolder
		{
			// Token: 0x06025686 RID: 153222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025686")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040347DD RID: 215005
			[Token(Token = "0x40347DD")]
			[FieldOffset(Offset = "0x10")]
			public ArtMagazineDiyGridItemBase itemView;
		}
	}
}
