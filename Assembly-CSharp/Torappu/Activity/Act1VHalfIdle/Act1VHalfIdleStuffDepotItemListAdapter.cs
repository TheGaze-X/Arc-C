using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200777D RID: 30589
	[Token(Token = "0x200777D")]
	public class Act1VHalfIdleStuffDepotItemListAdapter : RecycleLoopScrollAdapter<Act1VHalfIdleStuffDepotItemListAdapter.ViewHolder, Act1VHalfIdleStuffDepotItemViewModel>
	{
		// Token: 0x170064B9 RID: 25785
		// (get) Token: 0x0602AF6C RID: 175980 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AF6B RID: 175979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064B9")]
		public Action<Act1VHalfIdleStuffDepotItemViewModel> onItemClick
		{
			[Token(Token = "0x602AF6C")]
			[Address(RVA = "0x26D4D80", Offset = "0x26D3980", VA = "0x1826D4D80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AF6B")]
			[Address(RVA = "0x26D4DE0", Offset = "0x26D39E0", VA = "0x1826D4DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AF6D RID: 175981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF6D")]
		[Address(RVA = "0x26D4A30", Offset = "0x26D3630", VA = "0x1826D4A30", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act1VHalfIdleStuffDepotItemListAdapter.ViewHolder holder, Act1VHalfIdleStuffDepotItemViewModel data)
		{
		}

		// Token: 0x0602AF6E RID: 175982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF6E")]
		[Address(RVA = "0x26D4BF0", Offset = "0x26D37F0", VA = "0x1826D4BF0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602AF6F RID: 175983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF6F")]
		[Address(RVA = "0x26D4D10", Offset = "0x26D3910", VA = "0x1826D4D10")]
		public Act1VHalfIdleStuffDepotItemListAdapter()
		{
		}

		// Token: 0x0403DFEE RID: 253934
		[Token(Token = "0x403DFEE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act1VHalfIdleStuffDepotItemView _itemViewPrefab;

		// Token: 0x0403DFF0 RID: 253936
		[Token(Token = "0x403DFF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403DFF1 RID: 253937
		[Token(Token = "0x403DFF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403DFF2 RID: 253938
		[Token(Token = "0x403DFF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403DFF3 RID: 253939
		[Token(Token = "0x403DFF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403DFF4 RID: 253940
		[Token(Token = "0x403DFF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200777E RID: 30590
		[Token(Token = "0x200777E")]
		public class ViewHolder
		{
			// Token: 0x0602AF70 RID: 175984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AF70")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403DFF5 RID: 253941
			[Token(Token = "0x403DFF5")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdleStuffDepotItemView itemView;
		}
	}
}
