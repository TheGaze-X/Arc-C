using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ADA RID: 23258
	[Token(Token = "0x2005ADA")]
	public class ShopGPCondTrigItemViewModel : ShopGPCommonItemViewModel, IHotfixable
	{
		// Token: 0x06021CF3 RID: 138483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CF3")]
		[Address(RVA = "0x1C4EB30", Offset = "0x1C4D730", VA = "0x181C4EB30", Slot = "4")]
		public override NormalGPItem ReturnCommonItem()
		{
			return null;
		}

		// Token: 0x06021CF4 RID: 138484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CF4")]
		[Address(RVA = "0x1C4EB90", Offset = "0x1C4D790", VA = "0x181C4EB90", Slot = "5")]
		public override PlayerGoodItemData ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x06021CF5 RID: 138485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CF5")]
		[Address(RVA = "0x1C4E880", Offset = "0x1C4D480", VA = "0x181C4E880")]
		public void LoadData(CondTrigGPItem item)
		{
		}

		// Token: 0x06021CF6 RID: 138486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CF6")]
		[Address(RVA = "0x1C4EDF0", Offset = "0x1C4D9F0", VA = "0x181C4EDF0")]
		private void _LoadReturnOnceData()
		{
		}

		// Token: 0x06021CF7 RID: 138487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CF7")]
		[Address(RVA = "0x1C4EF80", Offset = "0x1C4DB80", VA = "0x181C4EF80")]
		private void _LoadReturnProgressData()
		{
		}

		// Token: 0x06021CF8 RID: 138488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CF8")]
		[Address(RVA = "0x1C4EBF0", Offset = "0x1C4D7F0", VA = "0x181C4EBF0")]
		private void _LoadNewProgressData()
		{
		}

		// Token: 0x06021CF9 RID: 138489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CF9")]
		[Address(RVA = "0x1C4F170", Offset = "0x1C4DD70", VA = "0x181C4F170")]
		public ShopGPCondTrigItemViewModel()
		{
		}

		// Token: 0x06021CFA RID: 138490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CFA")]
		[Address(RVA = "0x1C4B9B0", Offset = "0x1C4A5B0", VA = "0x181C4B9B0")]
		private PlayerGoodItemData <>xLuaBaseProxy_ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x0402E49B RID: 189595
		[Token(Token = "0x402E49B")]
		[FieldOffset(Offset = "0x38")]
		public CondTrigGPItem item;

		// Token: 0x0402E49C RID: 189596
		[Token(Token = "0x402E49C")]
		[FieldOffset(Offset = "0x40")]
		public PlayerGoodItemData playerInfo;

		// Token: 0x0402E49D RID: 189597
		[Token(Token = "0x402E49D")]
		[FieldOffset(Offset = "0x48")]
		public long endTime;

		// Token: 0x0402E49E RID: 189598
		[Token(Token = "0x402E49E")]
		[FieldOffset(Offset = "0x50")]
		public int currCheckInDay;

		// Token: 0x0402E49F RID: 189599
		[Token(Token = "0x402E49F")]
		[FieldOffset(Offset = "0x54")]
		public int totalCheckInDay;

		// Token: 0x0402E4A0 RID: 189600
		[Token(Token = "0x402E4A0")]
		[FieldOffset(Offset = "0x58")]
		public bool isCheckInPackage;

		// Token: 0x0402E4A1 RID: 189601
		[Token(Token = "0x402E4A1")]
		[FieldOffset(Offset = "0x5C")]
		public int availCount;

		// Token: 0x0402E4A2 RID: 189602
		[Token(Token = "0x402E4A2")]
		[FieldOffset(Offset = "0x60")]
		public int boughtCount;

		// Token: 0x0402E4A3 RID: 189603
		[Token(Token = "0x402E4A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnCommonItem;

		// Token: 0x0402E4A4 RID: 189604
		[Token(Token = "0x402E4A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReturnPlayerInfo;

		// Token: 0x0402E4A5 RID: 189605
		[Token(Token = "0x402E4A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402E4A6 RID: 189606
		[Token(Token = "0x402E4A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadReturnOnceData;

		// Token: 0x0402E4A7 RID: 189607
		[Token(Token = "0x402E4A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadReturnProgressData;

		// Token: 0x0402E4A8 RID: 189608
		[Token(Token = "0x402E4A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadNewProgressData;

		// Token: 0x0402E4A9 RID: 189609
		[Token(Token = "0x402E4A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
