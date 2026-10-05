using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CF6 RID: 7414
	[Token(Token = "0x2001CF6")]
	public class BuildingShopFormulaAdapter : LoopScrollAdapter<BuildingShopFormulaAdapter.ViewHolder, SFormulaViewModel>
	{
		// Token: 0x0600B73B RID: 46907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B73B")]
		[Address(RVA = "0x333EEF0", Offset = "0x333DAF0", VA = "0x18333EEF0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600B73C RID: 46908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B73C")]
		[Address(RVA = "0x333F080", Offset = "0x333DC80", VA = "0x18333F080", Slot = "13")]
		public override void UpdateView(int position, GameObject view, BuildingShopFormulaAdapter.ViewHolder holder, SFormulaViewModel data)
		{
		}

		// Token: 0x0600B73D RID: 46909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B73D")]
		[Address(RVA = "0x333EFB0", Offset = "0x333DBB0", VA = "0x18333EFB0", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B73E")]
		[Address(RVA = "0x333F2E0", Offset = "0x333DEE0", VA = "0x18333F2E0")]
		public BuildingShopFormulaAdapter()
		{
		}

		// Token: 0x0400B50C RID: 46348
		[Token(Token = "0x400B50C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _recycleParent;

		// Token: 0x0400B50D RID: 46349
		[Token(Token = "0x400B50D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BuildingShopFormulaItemView _itemPrefab;

		// Token: 0x0400B50E RID: 46350
		[Token(Token = "0x400B50E")]
		[FieldOffset(Offset = "0x68")]
		private int m_totalCountCache;

		// Token: 0x0400B50F RID: 46351
		[Token(Token = "0x400B50F")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<SFormulaViewModel> onFormulaClicked;

		// Token: 0x0400B510 RID: 46352
		[Token(Token = "0x400B510")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0400B511 RID: 46353
		[Token(Token = "0x400B511")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400B512 RID: 46354
		[Token(Token = "0x400B512")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0400B513 RID: 46355
		[Token(Token = "0x400B513")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CF7 RID: 7415
		[Token(Token = "0x2001CF7")]
		public class ViewHolder
		{
			// Token: 0x0600B73F RID: 46911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B73F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0400B514 RID: 46356
			[Token(Token = "0x400B514")]
			[FieldOffset(Offset = "0x10")]
			public BuildingShopFormulaItemView itemView;
		}
	}
}
