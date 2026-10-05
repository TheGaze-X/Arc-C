using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x0200042F RID: 1071
	[Token(Token = "0x200042F")]
	public class StoreKitReceipt
	{
		// Token: 0x06004955 RID: 18773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004955")]
		[Address(RVA = "0x157D3F0", Offset = "0x157BFF0", VA = "0x18157D3F0")]
		public StoreKitReceipt()
		{
		}

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x10")]
		public string receipt_type;

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x18")]
		public int adam_id;

		// Token: 0x04000DDE RID: 3550
		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x1C")]
		public int app_item_id;

		// Token: 0x04000DDF RID: 3551
		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x20")]
		public string bundle_id;

		// Token: 0x04000DE0 RID: 3552
		[Token(Token = "0x4000DE0")]
		[FieldOffset(Offset = "0x28")]
		public string application_version;

		// Token: 0x04000DE1 RID: 3553
		[Token(Token = "0x4000DE1")]
		[FieldOffset(Offset = "0x30")]
		public int download_id;

		// Token: 0x04000DE2 RID: 3554
		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x34")]
		public int version_external_identifier;

		// Token: 0x04000DE3 RID: 3555
		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x38")]
		public string receipt_creation_date;

		// Token: 0x04000DE4 RID: 3556
		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x40")]
		public string receipt_creation_date_ms;

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x48")]
		public string receipt_creation_date_pst;

		// Token: 0x04000DE6 RID: 3558
		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x50")]
		public string request_date;

		// Token: 0x04000DE7 RID: 3559
		[Token(Token = "0x4000DE7")]
		[FieldOffset(Offset = "0x58")]
		public string request_date_ms;

		// Token: 0x04000DE8 RID: 3560
		[Token(Token = "0x4000DE8")]
		[FieldOffset(Offset = "0x60")]
		public string request_date_pst;

		// Token: 0x04000DE9 RID: 3561
		[Token(Token = "0x4000DE9")]
		[FieldOffset(Offset = "0x68")]
		public string original_purchase_date;

		// Token: 0x04000DEA RID: 3562
		[Token(Token = "0x4000DEA")]
		[FieldOffset(Offset = "0x70")]
		public string original_purchase_date_ms;

		// Token: 0x04000DEB RID: 3563
		[Token(Token = "0x4000DEB")]
		[FieldOffset(Offset = "0x78")]
		public string original_purchase_date_pst;

		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000DEC")]
		[FieldOffset(Offset = "0x80")]
		public string original_application_version;

		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000DED")]
		[FieldOffset(Offset = "0x88")]
		public List<StoreKitReceiptInAppItem> in_app;
	}
}
