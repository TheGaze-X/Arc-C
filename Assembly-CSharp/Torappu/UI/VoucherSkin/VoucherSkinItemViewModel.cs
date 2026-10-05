using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B93 RID: 15251
	[Token(Token = "0x2003B93")]
	public class VoucherSkinItemViewModel : IHotfixable
	{
		// Token: 0x06017E58 RID: 97880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E58")]
		[Address(RVA = "0x10266D0", Offset = "0x10252D0", VA = "0x1810266D0")]
		public static VoucherSkinItemViewModel Create(ShopSkinItemViewModel good)
		{
			return null;
		}

		// Token: 0x06017E59 RID: 97881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E59")]
		[Address(RVA = "0x10263E0", Offset = "0x1024FE0", VA = "0x1810263E0")]
		public static VoucherSkinItemViewModel Create(ItemBundle skinItem)
		{
			return null;
		}

		// Token: 0x06017E5A RID: 97882 RVA: 0x000988F8 File Offset: 0x00096AF8
		[Token(Token = "0x6017E5A")]
		[Address(RVA = "0x1026970", Offset = "0x1025570", VA = "0x181026970")]
		public static int ItemComparison(VoucherSkinItemViewModel a, VoucherSkinItemViewModel b)
		{
			return 0;
		}

		// Token: 0x06017E5B RID: 97883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E5B")]
		[Address(RVA = "0x1026A90", Offset = "0x1025690", VA = "0x181026A90")]
		public VoucherSkinItemViewModel()
		{
		}

		// Token: 0x0401CE50 RID: 118352
		[Token(Token = "0x401CE50")]
		[FieldOffset(Offset = "0x10")]
		public ShopSkinItemViewModel goodShopItem;

		// Token: 0x0401CE51 RID: 118353
		[Token(Token = "0x401CE51")]
		[FieldOffset(Offset = "0x18")]
		public int goodSlotId;

		// Token: 0x0401CE52 RID: 118354
		[Token(Token = "0x401CE52")]
		[FieldOffset(Offset = "0x20")]
		public string skinId;

		// Token: 0x0401CE53 RID: 118355
		[Token(Token = "0x401CE53")]
		[FieldOffset(Offset = "0x28")]
		public string skinName;

		// Token: 0x0401CE54 RID: 118356
		[Token(Token = "0x401CE54")]
		[FieldOffset(Offset = "0x30")]
		public string charId;

		// Token: 0x0401CE55 RID: 118357
		[Token(Token = "0x401CE55")]
		[FieldOffset(Offset = "0x38")]
		public string charName;

		// Token: 0x0401CE56 RID: 118358
		[Token(Token = "0x401CE56")]
		[FieldOffset(Offset = "0x40")]
		public bool hasGot;

		// Token: 0x0401CE57 RID: 118359
		[Token(Token = "0x401CE57")]
		[FieldOffset(Offset = "0x41")]
		public bool isRedeem;

		// Token: 0x0401CE58 RID: 118360
		[Token(Token = "0x401CE58")]
		[FieldOffset(Offset = "0x48")]
		public string skinGroup;

		// Token: 0x0401CE59 RID: 118361
		[Token(Token = "0x401CE59")]
		[FieldOffset(Offset = "0x50")]
		public bool isValid;

		// Token: 0x0401CE5A RID: 118362
		[Token(Token = "0x401CE5A")]
		[FieldOffset(Offset = "0x58")]
		public long endTime;

		// Token: 0x0401CE5B RID: 118363
		[Token(Token = "0x401CE5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0401CE5C RID: 118364
		[Token(Token = "0x401CE5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Create;

		// Token: 0x0401CE5D RID: 118365
		[Token(Token = "0x401CE5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ItemComparison;

		// Token: 0x0401CE5E RID: 118366
		[Token(Token = "0x401CE5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
