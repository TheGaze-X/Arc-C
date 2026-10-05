using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007663 RID: 30307
	[Token(Token = "0x2007663")]
	public class CartCompViewModel
	{
		// Token: 0x1700643A RID: 25658
		// (get) Token: 0x0602AA09 RID: 174601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700643A")]
		public string rarityResName
		{
			[Token(Token = "0x602AA09")]
			[Address(RVA = "0x26642A0", Offset = "0x2662EA0", VA = "0x1826642A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602AA0A RID: 174602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA0A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CartCompViewModel()
		{
		}

		// Token: 0x0403D63D RID: 251453
		[Token(Token = "0x403D63D")]
		private const string RARITY_RES_FORMAT = "rarity_{0}";

		// Token: 0x0403D63E RID: 251454
		[Token(Token = "0x403D63E")]
		[FieldOffset(Offset = "0x10")]
		public string compId;

		// Token: 0x0403D63F RID: 251455
		[Token(Token = "0x403D63F")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0403D640 RID: 251456
		[Token(Token = "0x403D640")]
		[FieldOffset(Offset = "0x20")]
		public List<CartComponents.CartAccessoryPos> availPosList;

		// Token: 0x0403D641 RID: 251457
		[Token(Token = "0x403D641")]
		[FieldOffset(Offset = "0x28")]
		public int count;

		// Token: 0x0403D642 RID: 251458
		[Token(Token = "0x403D642")]
		[FieldOffset(Offset = "0x2C")]
		public int inUseCount;

		// Token: 0x0403D643 RID: 251459
		[Token(Token = "0x403D643")]
		[FieldOffset(Offset = "0x30")]
		public int selectUsedCount;

		// Token: 0x0403D644 RID: 251460
		[Token(Token = "0x403D644")]
		[FieldOffset(Offset = "0x34")]
		public CartComponents.CartAccessoryType type;

		// Token: 0x0403D645 RID: 251461
		[Token(Token = "0x403D645")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x0403D646 RID: 251462
		[Token(Token = "0x403D646")]
		[FieldOffset(Offset = "0x40")]
		public bool currentSelect;

		// Token: 0x0403D647 RID: 251463
		[Token(Token = "0x403D647")]
		[FieldOffset(Offset = "0x44")]
		public int rarityLevel;

		// Token: 0x0403D648 RID: 251464
		[Token(Token = "0x403D648")]
		[FieldOffset(Offset = "0x48")]
		public bool isObtained;

		// Token: 0x0403D649 RID: 251465
		[Token(Token = "0x403D649")]
		[FieldOffset(Offset = "0x50")]
		public string detailText;

		// Token: 0x0403D64A RID: 251466
		[Token(Token = "0x403D64A")]
		[FieldOffset(Offset = "0x58")]
		public string detailExhibitText;
	}
}
