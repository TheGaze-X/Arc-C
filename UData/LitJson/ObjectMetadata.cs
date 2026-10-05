using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	internal struct ObjectMetadata
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public Type ElementType
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x55C1C00", Offset = "0x55C0800", VA = "0x1855C1C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000024C0 File Offset: 0x000006C0
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public bool IsDictionary
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xFEDEE0", Offset = "0xFECAE0", VA = "0x180FEDEE0")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public IDictionary<string, PropertyMetadata> Properties
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x8")]
		private bool is_dictionary;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, PropertyMetadata> properties;
	}
}
