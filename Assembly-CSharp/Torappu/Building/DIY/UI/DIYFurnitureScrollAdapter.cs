using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001990 RID: 6544
	[Token(Token = "0x2001990")]
	public class DIYFurnitureScrollAdapter : LoopScrollAdapter<DIYFurnitureScrollAdapter.ViewHolder, DIYItemViewData>
	{
		// Token: 0x1400004B RID: 75
		// (add) Token: 0x0600A421 RID: 42017 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A422 RID: 42018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004B")]
		public event Func<DIYItemViewData, bool> furnitureSubButtonPressed
		{
			[Token(Token = "0x600A421")]
			[Address(RVA = "0x31DDE70", Offset = "0x31DCA70", VA = "0x1831DDE70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A422")]
			[Address(RVA = "0x31DE070", Offset = "0x31DCC70", VA = "0x1831DE070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x0600A423 RID: 42019 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A424 RID: 42020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004C")]
		public event Func<DIYItemViewData, bool> renameButtonPressed
		{
			[Token(Token = "0x600A423")]
			[Address(RVA = "0x31DDF70", Offset = "0x31DCB70", VA = "0x1831DDF70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A424")]
			[Address(RVA = "0x31DE170", Offset = "0x31DCD70", VA = "0x1831DE170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A425")]
		[Address(RVA = "0x31DDA40", Offset = "0x31DC640", VA = "0x1831DDA40")]
		private void _OnButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A426 RID: 42022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A426")]
		[Address(RVA = "0x31DDD10", Offset = "0x31DC910", VA = "0x1831DDD10")]
		private void _OnSubButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A427 RID: 42023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A427")]
		[Address(RVA = "0x31DDC20", Offset = "0x31DC820", VA = "0x1831DDC20")]
		private void _OnRenameButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A428")]
		[Address(RVA = "0x31DDB30", Offset = "0x31DC730", VA = "0x1831DDB30")]
		private void _OnInfoButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A429")]
		[Address(RVA = "0x31DD710", Offset = "0x31DC310", VA = "0x1831DD710", Slot = "13")]
		public override void UpdateView(int position, GameObject view, DIYFurnitureScrollAdapter.ViewHolder holder, DIYItemViewData data)
		{
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A42A")]
		[Address(RVA = "0x31DD660", Offset = "0x31DC260", VA = "0x1831DD660", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600A42B RID: 42027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A42B")]
		[Address(RVA = "0x31DDE00", Offset = "0x31DCA00", VA = "0x1831DDE00")]
		public DIYFurnitureScrollAdapter()
		{
		}

		// Token: 0x04009B3F RID: 39743
		[Token(Token = "0x4009B3F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _furnitureViewPrefab;

		// Token: 0x04009B40 RID: 39744
		[Token(Token = "0x4009B40")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> furnitureSelected;

		// Token: 0x04009B43 RID: 39747
		[Token(Token = "0x4009B43")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> infoButtonPressed;

		// Token: 0x04009B44 RID: 39748
		[Token(Token = "0x4009B44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_furnitureSubButtonPressed;

		// Token: 0x04009B45 RID: 39749
		[Token(Token = "0x4009B45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_furnitureSubButtonPressed;

		// Token: 0x04009B46 RID: 39750
		[Token(Token = "0x4009B46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_add_renameButtonPressed;

		// Token: 0x04009B47 RID: 39751
		[Token(Token = "0x4009B47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_remove_renameButtonPressed;

		// Token: 0x04009B48 RID: 39752
		[Token(Token = "0x4009B48")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnButtonPressed;

		// Token: 0x04009B49 RID: 39753
		[Token(Token = "0x4009B49")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSubButtonPressed;

		// Token: 0x04009B4A RID: 39754
		[Token(Token = "0x4009B4A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnRenameButtonPressed;

		// Token: 0x04009B4B RID: 39755
		[Token(Token = "0x4009B4B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnInfoButtonPressed;

		// Token: 0x04009B4C RID: 39756
		[Token(Token = "0x4009B4C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04009B4D RID: 39757
		[Token(Token = "0x4009B4D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04009B4E RID: 39758
		[Token(Token = "0x4009B4E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001991 RID: 6545
		[Token(Token = "0x2001991")]
		public struct ViewHolder
		{
			// Token: 0x04009B4F RID: 39759
			[Token(Token = "0x4009B4F")]
			[FieldOffset(Offset = "0x0")]
			public GameObject panel;
		}
	}
}
