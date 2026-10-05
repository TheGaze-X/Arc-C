using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002EA RID: 746
	[Token(Token = "0x20002EA")]
	internal struct ObjectMetadata
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001F3")]
		public Type ElementType
		{
			[Token(Token = "0x6001100")]
			[Address(RVA = "0x5CDF830", Offset = "0x5CDE430", VA = "0x185CDF830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001101")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00004844 File Offset: 0x00002A44
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001F4")]
		public bool IsDictionary
		{
			[Token(Token = "0x6001102")]
			[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001103")]
			[Address(RVA = "0xFEDEE0", Offset = "0xFECAE0", VA = "0x180FEDEE0")]
			set
			{
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001F5")]
		public IDictionary<string, PropertyMetadata> Properties
		{
			[Token(Token = "0x6001104")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001105")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x04000DE8 RID: 3560
		[Token(Token = "0x4000DE8")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x04000DE9 RID: 3561
		[Token(Token = "0x4000DE9")]
		[FieldOffset(Offset = "0x8")]
		private bool is_dictionary;

		// Token: 0x04000DEA RID: 3562
		[Token(Token = "0x4000DEA")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, PropertyMetadata> properties;
	}
}
