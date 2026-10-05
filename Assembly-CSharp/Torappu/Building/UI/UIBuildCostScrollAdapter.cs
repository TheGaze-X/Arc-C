using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B5C RID: 7004
	[Token(Token = "0x2001B5C")]
	public class UIBuildCostScrollAdapter : LoopScrollAdapter<UIBuildCostScrollAdapter.ViewHolder, ArchiCostItemModel>
	{
		// Token: 0x0600AFE4 RID: 45028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFE4")]
		[Address(RVA = "0x32B9680", Offset = "0x32B8280", VA = "0x1832B9680", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600AFE5 RID: 45029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFE5")]
		[Address(RVA = "0x32B9790", Offset = "0x32B8390", VA = "0x1832B9790", Slot = "13")]
		public override void UpdateView(int position, GameObject view, UIBuildCostScrollAdapter.ViewHolder holder, ArchiCostItemModel data)
		{
		}

		// Token: 0x0600AFE6 RID: 45030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFE6")]
		[Address(RVA = "0x32B9730", Offset = "0x32B8330", VA = "0x1832B9730", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x0600AFE7 RID: 45031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFE7")]
		[Address(RVA = "0x32B98A0", Offset = "0x32B84A0", VA = "0x1832B98A0")]
		public UIBuildCostScrollAdapter()
		{
		}

		// Token: 0x0400AA21 RID: 43553
		[Token(Token = "0x400AA21")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _costItemPrefab;

		// Token: 0x0400AA22 RID: 43554
		[Token(Token = "0x400AA22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0400AA23 RID: 43555
		[Token(Token = "0x400AA23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400AA24 RID: 43556
		[Token(Token = "0x400AA24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0400AA25 RID: 43557
		[Token(Token = "0x400AA25")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B5D RID: 7005
		[Token(Token = "0x2001B5D")]
		public struct ViewHolder
		{
			// Token: 0x0400AA26 RID: 43558
			[Token(Token = "0x400AA26")]
			[FieldOffset(Offset = "0x0")]
			public GameObject panel;
		}
	}
}
