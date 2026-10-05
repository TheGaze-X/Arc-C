using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200047D RID: 1149
	[Token(Token = "0x200047D")]
	internal struct ArrayMetadata
	{
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002503 RID: 9475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000502")]
		public Type ElementType
		{
			[Token(Token = "0x6002502")]
			[Address(RVA = "0x5381100", Offset = "0x537FD00", VA = "0x185381100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002503")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		// (set) Token: 0x06002505 RID: 9477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000503")]
		public bool IsArray
		{
			[Token(Token = "0x6002504")]
			[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002505")]
			[Address(RVA = "0xFEDEE0", Offset = "0xFECAE0", VA = "0x180FEDEE0")]
			set
			{
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x00010008 File Offset: 0x0000E208
		// (set) Token: 0x06002507 RID: 9479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000504")]
		public bool IsList
		{
			[Token(Token = "0x6002506")]
			[Address(RVA = "0x4C084E0", Offset = "0x4C070E0", VA = "0x184C084E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002507")]
			[Address(RVA = "0x53811A0", Offset = "0x537FDA0", VA = "0x1853811A0")]
			set
			{
			}
		}

		// Token: 0x040014AA RID: 5290
		[Token(Token = "0x40014AA")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x040014AB RID: 5291
		[Token(Token = "0x40014AB")]
		[FieldOffset(Offset = "0x8")]
		private bool is_array;

		// Token: 0x040014AC RID: 5292
		[Token(Token = "0x40014AC")]
		[FieldOffset(Offset = "0x9")]
		private bool is_list;
	}
}
