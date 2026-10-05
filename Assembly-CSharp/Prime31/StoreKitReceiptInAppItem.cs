using System;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	public class StoreKitReceiptInAppItem
	{
		// Token: 0x06004956 RID: 18774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004956")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoreKitReceiptInAppItem()
		{
		}

		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000DEE")]
		[FieldOffset(Offset = "0x10")]
		public string quantity;

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		[FieldOffset(Offset = "0x18")]
		public string product_id;

		// Token: 0x04000DF0 RID: 3568
		[Token(Token = "0x4000DF0")]
		[FieldOffset(Offset = "0x20")]
		public string transaction_id;

		// Token: 0x04000DF1 RID: 3569
		[Token(Token = "0x4000DF1")]
		[FieldOffset(Offset = "0x28")]
		public string original_transaction_id;

		// Token: 0x04000DF2 RID: 3570
		[Token(Token = "0x4000DF2")]
		[FieldOffset(Offset = "0x30")]
		public string purchase_date;

		// Token: 0x04000DF3 RID: 3571
		[Token(Token = "0x4000DF3")]
		[FieldOffset(Offset = "0x38")]
		public string purchase_date_ms;

		// Token: 0x04000DF4 RID: 3572
		[Token(Token = "0x4000DF4")]
		[FieldOffset(Offset = "0x40")]
		public string purchase_date_pst;

		// Token: 0x04000DF5 RID: 3573
		[Token(Token = "0x4000DF5")]
		[FieldOffset(Offset = "0x48")]
		public string original_purchase_date;

		// Token: 0x04000DF6 RID: 3574
		[Token(Token = "0x4000DF6")]
		[FieldOffset(Offset = "0x50")]
		public string original_purchase_date_ms;

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x58")]
		public string original_purchase_date_pst;

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x60")]
		public string is_trial_period;
	}
}
