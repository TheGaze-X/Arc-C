using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069D2 RID: 27090
	[Token(Token = "0x20069D2")]
	public class ZoneRecordRewardsAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17005B7A RID: 23418
		// (get) Token: 0x06026C1C RID: 158748 RVA: 0x000CC318 File Offset: 0x000CA518
		[Token(Token = "0x17005B7A")]
		public override int count
		{
			[Token(Token = "0x6026C1C")]
			[Address(RVA = "0x21E4D90", Offset = "0x21E3990", VA = "0x1821E4D90", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06026C1D RID: 158749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C1D")]
		[Address(RVA = "0x21E4440", Offset = "0x21E3040", VA = "0x1821E4440", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06026C1E RID: 158750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C1E")]
		[Address(RVA = "0x21E4BA0", Offset = "0x21E37A0", VA = "0x1821E4BA0")]
		private void _OnItemCardClicked(int position)
		{
		}

		// Token: 0x06026C1F RID: 158751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C1F")]
		[Address(RVA = "0x21E4C80", Offset = "0x21E3880", VA = "0x1821E4C80")]
		public ZoneRecordRewardsAdapter()
		{
		}

		// Token: 0x04036BE8 RID: 224232
		[Token(Token = "0x4036BE8")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<UIItemViewModel> rewardList;

		// Token: 0x04036BE9 RID: 224233
		[Token(Token = "0x4036BE9")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public List<UIItemCard> itemCards;

		// Token: 0x04036BEA RID: 224234
		[Token(Token = "0x4036BEA")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public float scaleFactor;

		// Token: 0x04036BEB RID: 224235
		[Token(Token = "0x4036BEB")]
		[FieldOffset(Offset = "0x34")]
		[NonSerialized]
		public Color mainColor;

		// Token: 0x04036BEC RID: 224236
		[Token(Token = "0x4036BEC")]
		[FieldOffset(Offset = "0x44")]
		[NonSerialized]
		public bool showLeftTime;

		// Token: 0x04036BED RID: 224237
		[Token(Token = "0x4036BED")]
		[FieldOffset(Offset = "0x45")]
		[NonSerialized]
		public bool showLimitPart;

		// Token: 0x04036BEE RID: 224238
		[Token(Token = "0x4036BEE")]
		[FieldOffset(Offset = "0x48")]
		private GameObject m_itemPrefab;

		// Token: 0x04036BEF RID: 224239
		[Token(Token = "0x4036BEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04036BF0 RID: 224240
		[Token(Token = "0x4036BF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04036BF1 RID: 224241
		[Token(Token = "0x4036BF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x04036BF2 RID: 224242
		[Token(Token = "0x4036BF2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
