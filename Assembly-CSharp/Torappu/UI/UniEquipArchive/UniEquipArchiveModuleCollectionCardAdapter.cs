using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BF2 RID: 15346
	[Token(Token = "0x2003BF2")]
	public class UniEquipArchiveModuleCollectionCardAdapter : LoopScrollAdapter<UniEquipArchiveModuleCollectionCardAdapter.ViewHolder, UniEquipArchiveModuleCollectionItemViewModel>
	{
		// Token: 0x0601801D RID: 98333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601801D")]
		[Address(RVA = "0x1080F10", Offset = "0x107FB10", VA = "0x181080F10", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601801E RID: 98334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601801E")]
		[Address(RVA = "0x1081040", Offset = "0x107FC40", VA = "0x181081040", Slot = "13")]
		public override void UpdateView(int position, GameObject view, UniEquipArchiveModuleCollectionCardAdapter.ViewHolder holder, UniEquipArchiveModuleCollectionItemViewModel data)
		{
		}

		// Token: 0x0601801F RID: 98335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601801F")]
		[Address(RVA = "0x10811A0", Offset = "0x107FDA0", VA = "0x1810811A0")]
		public UniEquipArchiveModuleCollectionCardAdapter()
		{
		}

		// Token: 0x0401D170 RID: 119152
		[Token(Token = "0x401D170")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UniEquipArchiveModuleCollectionItemView _viewPrefab;

		// Token: 0x0401D171 RID: 119153
		[Token(Token = "0x401D171")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401D172 RID: 119154
		[Token(Token = "0x401D172")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401D173 RID: 119155
		[Token(Token = "0x401D173")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BF3 RID: 15347
		[Token(Token = "0x2003BF3")]
		public class ViewHolder
		{
			// Token: 0x06018020 RID: 98336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018020")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0401D174 RID: 119156
			[Token(Token = "0x401D174")]
			[FieldOffset(Offset = "0x10")]
			public UniEquipArchiveModuleCollectionItemView view;
		}
	}
}
