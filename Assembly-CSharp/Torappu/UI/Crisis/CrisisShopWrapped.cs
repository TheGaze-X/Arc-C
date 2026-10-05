using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Crisis
{
	// Token: 0x020059FB RID: 23035
	[Token(Token = "0x20059FB")]
	public class CrisisShopWrapped
	{
		// Token: 0x0602192A RID: 137514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602192A")]
		[Address(RVA = "0x1C0C100", Offset = "0x1C0AD00", VA = "0x181C0C100")]
		public static CrisisProgressShopItemViewModel GetProgressItem(List<CrisisProgressShopItemViewModel> list, int order)
		{
			return null;
		}

		// Token: 0x17004EDD RID: 20189
		// (get) Token: 0x0602192B RID: 137515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004EDD")]
		public List<CrisisProgressShopItemViewModel> progressViewModelList
		{
			[Token(Token = "0x602192B")]
			[Address(RVA = "0x1C0C3C0", Offset = "0x1C0AFC0", VA = "0x181C0C3C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004EDE RID: 20190
		// (get) Token: 0x0602192C RID: 137516 RVA: 0x000BAC90 File Offset: 0x000B8E90
		[Token(Token = "0x17004EDE")]
		public int buyCount
		{
			[Token(Token = "0x602192C")]
			[Address(RVA = "0x1C0C2D0", Offset = "0x1C0AED0", VA = "0x181C0C2D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004EDF RID: 20191
		// (get) Token: 0x0602192D RID: 137517 RVA: 0x000BACA8 File Offset: 0x000B8EA8
		[Token(Token = "0x17004EDF")]
		public CrisisShopVer shopVer
		{
			[Token(Token = "0x602192D")]
			[Address(RVA = "0x1C0C3F0", Offset = "0x1C0AFF0", VA = "0x181C0C3F0")]
			get
			{
				return CrisisShopVer.CRISIS;
			}
		}

		// Token: 0x17004EE0 RID: 20192
		// (get) Token: 0x0602192E RID: 137518 RVA: 0x000BACC0 File Offset: 0x000B8EC0
		[Token(Token = "0x17004EE0")]
		public int ableBuyCount
		{
			[Token(Token = "0x602192E")]
			[Address(RVA = "0x1C0C2A0", Offset = "0x1C0AEA0", VA = "0x181C0C2A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004EE1 RID: 20193
		// (get) Token: 0x0602192F RID: 137519 RVA: 0x000BACD8 File Offset: 0x000B8ED8
		[Token(Token = "0x17004EE1")]
		public bool isTimeLimited
		{
			[Token(Token = "0x602192F")]
			[Address(RVA = "0x1C0C330", Offset = "0x1C0AF30", VA = "0x181C0C330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004EE2 RID: 20194
		// (get) Token: 0x06021930 RID: 137520 RVA: 0x000BACF0 File Offset: 0x000B8EF0
		[Token(Token = "0x17004EE2")]
		public bool isUnique
		{
			[Token(Token = "0x6021930")]
			[Address(RVA = "0x1C0C360", Offset = "0x1C0AF60", VA = "0x181C0C360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004EE3 RID: 20195
		// (get) Token: 0x06021931 RID: 137521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004EE3")]
		public PlayerGoodProgressData progressInfo
		{
			[Token(Token = "0x6021931")]
			[Address(RVA = "0x1C0C390", Offset = "0x1C0AF90", VA = "0x181C0C390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004EE4 RID: 20196
		// (get) Token: 0x06021932 RID: 137522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004EE4")]
		public CrisisCommonShopItemData commonViewModel
		{
			[Token(Token = "0x6021932")]
			[Address(RVA = "0x1C0C300", Offset = "0x1C0AF00", VA = "0x181C0C300")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021933 RID: 137523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021933")]
		[Address(RVA = "0x1C0C1F0", Offset = "0x1C0ADF0", VA = "0x181C0C1F0")]
		public CrisisShopWrapped()
		{
		}

		// Token: 0x0402DE04 RID: 187908
		[Token(Token = "0x402DE04")]
		[FieldOffset(Offset = "0x10")]
		public CrisisShopWrapped.SeasonFlag seasonFlag;

		// Token: 0x0402DE05 RID: 187909
		[Token(Token = "0x402DE05")]
		[FieldOffset(Offset = "0x18")]
		public CrisisLongTermShopWrapped longTermViewModel;

		// Token: 0x0402DE06 RID: 187910
		[Token(Token = "0x402DE06")]
		[FieldOffset(Offset = "0x20")]
		public CrisisSeasonShopWrapped seasonViewModel;

		// Token: 0x020059FC RID: 23036
		[Token(Token = "0x20059FC")]
		public enum SeasonFlag
		{
			// Token: 0x0402DE08 RID: 187912
			[Token(Token = "0x402DE08")]
			Season,
			// Token: 0x0402DE09 RID: 187913
			[Token(Token = "0x402DE09")]
			LongTerm
		}
	}
}
