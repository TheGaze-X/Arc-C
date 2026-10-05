using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200408E RID: 16526
	[Token(Token = "0x200408E")]
	public class SandboxV2CookFoodListLoopAdapter : LoopScrollAdapter<SandboxV2CookFoodListLoopAdapter.ViewHolder, SandboxV2CookFoodListItemModel>
	{
		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x06019907 RID: 104711 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019908 RID: 104712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CFD")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x6019907")]
			[Address(RVA = "0x12553F0", Offset = "0x1253FF0", VA = "0x1812553F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019908")]
			[Address(RVA = "0x1255450", Offset = "0x1254050", VA = "0x181255450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019909 RID: 104713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019909")]
		[Address(RVA = "0x1254F90", Offset = "0x1253B90", VA = "0x181254F90", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601990A RID: 104714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601990A")]
		[Address(RVA = "0x1255070", Offset = "0x1253C70", VA = "0x181255070", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SandboxV2CookFoodListLoopAdapter.ViewHolder holder, SandboxV2CookFoodListItemModel data)
		{
		}

		// Token: 0x0601990B RID: 104715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601990B")]
		[Address(RVA = "0x1255380", Offset = "0x1253F80", VA = "0x181255380")]
		public SandboxV2CookFoodListLoopAdapter()
		{
		}

		// Token: 0x0401FE70 RID: 130672
		[Token(Token = "0x401FE70")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2CookFoodListItemView _itemViewPrefab;

		// Token: 0x0401FE72 RID: 130674
		[Token(Token = "0x401FE72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x0401FE73 RID: 130675
		[Token(Token = "0x401FE73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x0401FE74 RID: 130676
		[Token(Token = "0x401FE74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401FE75 RID: 130677
		[Token(Token = "0x401FE75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401FE76 RID: 130678
		[Token(Token = "0x401FE76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200408F RID: 16527
		[Token(Token = "0x200408F")]
		public class ViewHolder
		{
			// Token: 0x0601990C RID: 104716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601990C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0401FE77 RID: 130679
			[Token(Token = "0x401FE77")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2CookFoodListItemView view;
		}
	}
}
