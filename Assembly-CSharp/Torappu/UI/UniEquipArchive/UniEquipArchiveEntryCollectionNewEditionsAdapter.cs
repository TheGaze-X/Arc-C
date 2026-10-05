using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BEE RID: 15342
	[Token(Token = "0x2003BEE")]
	public class UniEquipArchiveEntryCollectionNewEditionsAdapter : LoopScrollAdapter<UniEquipArchiveEntryCollectionNewEditionsAdapter.ViewHolder, UniEquipArchiveEntryCollectionNewEditionItemViewModel>
	{
		// Token: 0x0601800D RID: 98317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601800D")]
		[Address(RVA = "0x107E520", Offset = "0x107D120", VA = "0x18107E520", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601800E RID: 98318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601800E")]
		[Address(RVA = "0x107E5D0", Offset = "0x107D1D0", VA = "0x18107E5D0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, UniEquipArchiveEntryCollectionNewEditionsAdapter.ViewHolder holder, UniEquipArchiveEntryCollectionNewEditionItemViewModel data)
		{
		}

		// Token: 0x0601800F RID: 98319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601800F")]
		[Address(RVA = "0x107E730", Offset = "0x107D330", VA = "0x18107E730")]
		public UniEquipArchiveEntryCollectionNewEditionsAdapter()
		{
		}

		// Token: 0x0401D14F RID: 119119
		[Token(Token = "0x401D14F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemObjPrefab;

		// Token: 0x0401D150 RID: 119120
		[Token(Token = "0x401D150")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401D151 RID: 119121
		[Token(Token = "0x401D151")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401D152 RID: 119122
		[Token(Token = "0x401D152")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BEF RID: 15343
		[Token(Token = "0x2003BEF")]
		public class ViewHolder
		{
			// Token: 0x06018010 RID: 98320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018010")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0401D153 RID: 119123
			[Token(Token = "0x401D153")]
			[FieldOffset(Offset = "0x10")]
			public UniEquipArchiveEntryCollectionNewEditionItemView view;
		}
	}
}
