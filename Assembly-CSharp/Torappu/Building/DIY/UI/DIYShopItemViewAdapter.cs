using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200194A RID: 6474
	[Token(Token = "0x200194A")]
	public class DIYShopItemViewAdapter : LoopScrollAdapter<DIYShopItemViewAdapter.ViewHolder, DIYShopItemViewData>
	{
		// Token: 0x14000048 RID: 72
		// (add) Token: 0x0600A2C8 RID: 41672 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A2C9 RID: 41673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000048")]
		public event Action<DIYShopItemViewData> furnitureSelected
		{
			[Token(Token = "0x600A2C8")]
			[Address(RVA = "0x31C4880", Offset = "0x31C3480", VA = "0x1831C4880")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A2C9")]
			[Address(RVA = "0x31C4980", Offset = "0x31C3580", VA = "0x1831C4980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2CA")]
		[Address(RVA = "0x31C4770", Offset = "0x31C3370", VA = "0x1831C4770")]
		private void _OnButtonPressed(DIYShopItemViewData data, ShopFurnitureItemView view)
		{
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2CB")]
		[Address(RVA = "0x31C4520", Offset = "0x31C3120", VA = "0x1831C4520", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2CC")]
		[Address(RVA = "0x31C45D0", Offset = "0x31C31D0", VA = "0x1831C45D0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, DIYShopItemViewAdapter.ViewHolder holder, DIYShopItemViewData data)
		{
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2CD")]
		[Address(RVA = "0x31C4810", Offset = "0x31C3410", VA = "0x1831C4810")]
		public DIYShopItemViewAdapter()
		{
		}

		// Token: 0x0400993A RID: 39226
		[Token(Token = "0x400993A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _furnitureViewPrefab;

		// Token: 0x0400993C RID: 39228
		[Token(Token = "0x400993C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_furnitureSelected;

		// Token: 0x0400993D RID: 39229
		[Token(Token = "0x400993D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_furnitureSelected;

		// Token: 0x0400993E RID: 39230
		[Token(Token = "0x400993E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnButtonPressed;

		// Token: 0x0400993F RID: 39231
		[Token(Token = "0x400993F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04009940 RID: 39232
		[Token(Token = "0x4009940")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04009941 RID: 39233
		[Token(Token = "0x4009941")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200194B RID: 6475
		[Token(Token = "0x200194B")]
		public struct ViewHolder
		{
			// Token: 0x04009942 RID: 39234
			[Token(Token = "0x4009942")]
			[FieldOffset(Offset = "0x0")]
			public GameObject panel;
		}
	}
}
