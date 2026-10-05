using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AD3 RID: 23251
	[Token(Token = "0x2005AD3")]
	public class ShopGPMonthlySubItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021CD0 RID: 138448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CD0")]
		[Address(RVA = "0x1C4FC20", Offset = "0x1C4E820", VA = "0x181C4FC20")]
		public void ApplyData(ShopGPMonthlySubItemViewModel itemViewModel)
		{
		}

		// Token: 0x06021CD1 RID: 138449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CD1")]
		[Address(RVA = "0x1C500F0", Offset = "0x1C4ECF0", VA = "0x181C500F0")]
		private void _OpenDetailEvent()
		{
		}

		// Token: 0x06021CD2 RID: 138450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CD2")]
		[Address(RVA = "0x1C4FFE0", Offset = "0x1C4EBE0", VA = "0x181C4FFE0")]
		public void EnterDetailEvent()
		{
		}

		// Token: 0x06021CD3 RID: 138451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CD3")]
		[Address(RVA = "0x1C50040", Offset = "0x1C4EC40", VA = "0x181C50040")]
		public void OnClick()
		{
		}

		// Token: 0x06021CD4 RID: 138452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CD4")]
		[Address(RVA = "0x1C50190", Offset = "0x1C4ED90", VA = "0x181C50190")]
		public ShopGPMonthlySubItem()
		{
		}

		// Token: 0x0402E45A RID: 189530
		[Token(Token = "0x402E45A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _gpImg;

		// Token: 0x0402E45B RID: 189531
		[Token(Token = "0x402E45B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x0402E45C RID: 189532
		[Token(Token = "0x402E45C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0402E45D RID: 189533
		[Token(Token = "0x402E45D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _currency;

		// Token: 0x0402E45E RID: 189534
		[Token(Token = "0x402E45E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _price;

		// Token: 0x0402E45F RID: 189535
		[Token(Token = "0x402E45F")]
		[FieldOffset(Offset = "0x40")]
		private ShopGPMonthlySubItemViewModel m_cacheViewModel;

		// Token: 0x0402E460 RID: 189536
		[Token(Token = "0x402E460")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E461 RID: 189537
		[Token(Token = "0x402E461")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OpenDetailEvent;

		// Token: 0x0402E462 RID: 189538
		[Token(Token = "0x402E462")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EnterDetailEvent;

		// Token: 0x0402E463 RID: 189539
		[Token(Token = "0x402E463")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E464 RID: 189540
		[Token(Token = "0x402E464")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005AD4 RID: 23252
		[Token(Token = "0x2005AD4")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<ShopGPMonthlySubItem>
		{
			// Token: 0x06021CD5 RID: 138453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021CD5")]
			[Address(RVA = "0x1C57B40", Offset = "0x1C56740", VA = "0x181C57B40")]
			public VirtualView(ShopGPMonthlySubItemViewModel viewModel, ShopGPMonthlySubItem prefab)
			{
			}

			// Token: 0x06021CD6 RID: 138454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021CD6")]
			[Address(RVA = "0x1C579F0", Offset = "0x1C565F0", VA = "0x181C579F0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06021CD7 RID: 138455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021CD7")]
			[Address(RVA = "0x1C57A80", Offset = "0x1C56680", VA = "0x181C57A80", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06021CD8 RID: 138456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021CD8")]
			[Address(RVA = "0x1C576B0", Offset = "0x1C562B0", VA = "0x181C576B0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06021CD9 RID: 138457 RVA: 0x000BB4B8 File Offset: 0x000B96B8
			[Token(Token = "0x6021CD9")]
			[Address(RVA = "0x1C57720", Offset = "0x1C56320", VA = "0x181C57720", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402E465 RID: 189541
			[Token(Token = "0x402E465")]
			[FieldOffset(Offset = "0x20")]
			private ShopGPMonthlySubItemViewModel m_viewModel;

			// Token: 0x0402E466 RID: 189542
			[Token(Token = "0x402E466")]
			[FieldOffset(Offset = "0x28")]
			private ShopGPMonthlySubItem m_prefab;

			// Token: 0x0402E467 RID: 189543
			[Token(Token = "0x402E467")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E468 RID: 189544
			[Token(Token = "0x402E468")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402E469 RID: 189545
			[Token(Token = "0x402E469")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402E46A RID: 189546
			[Token(Token = "0x402E46A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402E46B RID: 189547
			[Token(Token = "0x402E46B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
