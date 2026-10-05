using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004917 RID: 18711
	[Token(Token = "0x2004917")]
	public class StoryReviewRewardsItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C359 RID: 115545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C359")]
		[Address(RVA = "0x15B5810", Offset = "0x15B4410", VA = "0x1815B5810")]
		private UIItemCard _EnsureItemCard()
		{
			return null;
		}

		// Token: 0x0601C35A RID: 115546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C35A")]
		[Address(RVA = "0x15B5660", Offset = "0x15B4260", VA = "0x1815B5660")]
		public void RenderItem(ItemBundle item)
		{
		}

		// Token: 0x0601C35B RID: 115547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C35B")]
		[Address(RVA = "0x15B5A60", Offset = "0x15B4660", VA = "0x1815B5A60")]
		public StoryReviewRewardsItemView()
		{
		}

		// Token: 0x04024E3C RID: 151100
		[Token(Token = "0x4024E3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04024E3D RID: 151101
		[Token(Token = "0x4024E3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04024E3E RID: 151102
		[Token(Token = "0x4024E3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04024E3F RID: 151103
		[Token(Token = "0x4024E3F")]
		[FieldOffset(Offset = "0x30")]
		private UIItemCard m_itemCard;

		// Token: 0x04024E40 RID: 151104
		[Token(Token = "0x4024E40")]
		[FieldOffset(Offset = "0x38")]
		private UIItemViewModel m_cacheItemViewModel;

		// Token: 0x04024E41 RID: 151105
		[Token(Token = "0x4024E41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureItemCard;

		// Token: 0x04024E42 RID: 151106
		[Token(Token = "0x4024E42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x04024E43 RID: 151107
		[Token(Token = "0x4024E43")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
