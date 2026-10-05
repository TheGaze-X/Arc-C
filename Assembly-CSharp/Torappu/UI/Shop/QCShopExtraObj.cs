using System;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B02 RID: 23298
	[Token(Token = "0x2005B02")]
	public class QCShopExtraObj
	{
		// Token: 0x17004F37 RID: 20279
		// (get) Token: 0x06021DAA RID: 138666 RVA: 0x000BB698 File Offset: 0x000B9898
		[Token(Token = "0x17004F37")]
		public ExtraShopGroupType groupType
		{
			[Token(Token = "0x6021DAA")]
			[Address(RVA = "0x1C4A630", Offset = "0x1C49230", VA = "0x181C4A630")]
			get
			{
				return ExtraShopGroupType.TEMP;
			}
		}

		// Token: 0x06021DAB RID: 138667 RVA: 0x000BB6B0 File Offset: 0x000B98B0
		[Token(Token = "0x6021DAB")]
		[Address(RVA = "0x1C4A520", Offset = "0x1C49120", VA = "0x181C4A520")]
		public QCShopExtraObj.SortingOrderGroup GetSortingOrderGroup()
		{
			return QCShopExtraObj.SortingOrderGroup.PERM_AVAIL;
		}

		// Token: 0x17004F38 RID: 20280
		// (get) Token: 0x06021DAC RID: 138668 RVA: 0x000BB6C8 File Offset: 0x000B98C8
		[Token(Token = "0x17004F38")]
		public bool SoldOutFlag
		{
			[Token(Token = "0x6021DAC")]
			[Address(RVA = "0x1C4A5F0", Offset = "0x1C491F0", VA = "0x181C4A5F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004F39 RID: 20281
		// (get) Token: 0x06021DAD RID: 138669 RVA: 0x000BB6E0 File Offset: 0x000B98E0
		[Token(Token = "0x17004F39")]
		public int RemainCount
		{
			[Token(Token = "0x6021DAD")]
			[Address(RVA = "0x1C4A5B0", Offset = "0x1C491B0", VA = "0x181C4A5B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021DAE RID: 138670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DAE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QCShopExtraObj()
		{
		}

		// Token: 0x0402E5F2 RID: 189938
		[Token(Token = "0x402E5F2")]
		[FieldOffset(Offset = "0x10")]
		public ExtraQCObject objData;

		// Token: 0x0402E5F3 RID: 189939
		[Token(Token = "0x402E5F3")]
		[FieldOffset(Offset = "0x18")]
		public PlayerGoodItemData playerShop;

		// Token: 0x0402E5F4 RID: 189940
		[Token(Token = "0x402E5F4")]
		[FieldOffset(Offset = "0x20")]
		public bool isNew;

		// Token: 0x02005B03 RID: 23299
		[Token(Token = "0x2005B03")]
		public enum SortingOrderGroup
		{
			// Token: 0x0402E5F6 RID: 189942
			[Token(Token = "0x402E5F6")]
			PERM_AVAIL,
			// Token: 0x0402E5F7 RID: 189943
			[Token(Token = "0x402E5F7")]
			MONTH,
			// Token: 0x0402E5F8 RID: 189944
			[Token(Token = "0x402E5F8")]
			TEMP_AVAIL,
			// Token: 0x0402E5F9 RID: 189945
			[Token(Token = "0x402E5F9")]
			PERM_SOLDOUT,
			// Token: 0x0402E5FA RID: 189946
			[Token(Token = "0x402E5FA")]
			TEMP_SOLDOUT,
			// Token: 0x0402E5FB RID: 189947
			[Token(Token = "0x402E5FB")]
			ENUM
		}
	}
}
