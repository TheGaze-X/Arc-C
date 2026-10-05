using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200047E RID: 1150
	[Token(Token = "0x200047E")]
	internal struct ObjectMetadata
	{
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002509 RID: 9481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000505")]
		public Type ElementType
		{
			[Token(Token = "0x6002508")]
			[Address(RVA = "0x539D1D0", Offset = "0x539BDD0", VA = "0x18539D1D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002509")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x00010020 File Offset: 0x0000E220
		// (set) Token: 0x0600250B RID: 9483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000506")]
		public bool IsDictionary
		{
			[Token(Token = "0x600250A")]
			[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600250B")]
			[Address(RVA = "0xFEDEE0", Offset = "0xFECAE0", VA = "0x180FEDEE0")]
			set
			{
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600250D RID: 9485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000507")]
		public IDictionary<string, PropertyMetadata> Properties
		{
			[Token(Token = "0x600250C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600250D")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x040014AD RID: 5293
		[Token(Token = "0x40014AD")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x040014AE RID: 5294
		[Token(Token = "0x40014AE")]
		[FieldOffset(Offset = "0x8")]
		private bool is_dictionary;

		// Token: 0x040014AF RID: 5295
		[Token(Token = "0x40014AF")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, PropertyMetadata> properties;
	}
}
