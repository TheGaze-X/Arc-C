using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040A8 RID: 16552
	[Token(Token = "0x20040A8")]
	public class SandboxV2AdminMainInventoryItemListAdapter : RecycleLoopScrollAdapter<SAndboxV2AdminMainInventoryItemView, SandboxV2AdminMainInventoryItemModel>
	{
		// Token: 0x060199BE RID: 104894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199BE")]
		[Address(RVA = "0x124AFB0", Offset = "0x1249BB0", VA = "0x18124AFB0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SAndboxV2AdminMainInventoryItemView holder, SandboxV2AdminMainInventoryItemModel data)
		{
		}

		// Token: 0x060199BF RID: 104895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60199BF")]
		[Address(RVA = "0x124B0F0", Offset = "0x1249CF0", VA = "0x18124B0F0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x060199C0 RID: 104896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199C0")]
		[Address(RVA = "0x124B2D0", Offset = "0x1249ED0", VA = "0x18124B2D0")]
		public SandboxV2AdminMainInventoryItemListAdapter()
		{
		}

		// Token: 0x0401FFDB RID: 131035
		[Token(Token = "0x401FFDB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x0401FFDC RID: 131036
		[Token(Token = "0x401FFDC")]
		[FieldOffset(Offset = "0x70")]
		public Action<int> onItemClick;

		// Token: 0x0401FFDD RID: 131037
		[Token(Token = "0x401FFDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401FFDE RID: 131038
		[Token(Token = "0x401FFDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0401FFDF RID: 131039
		[Token(Token = "0x401FFDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
