using System;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	internal struct ArrayMetadata
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public Type ElementType
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x55AC9D0", Offset = "0x55AB5D0", VA = "0x1855AC9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public bool IsArray
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xFEDEE0", Offset = "0xFECAE0", VA = "0x180FEDEE0")]
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000024A8 File Offset: 0x000006A8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		public bool IsList
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x4C084E0", Offset = "0x4C070E0", VA = "0x184C084E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x53811A0", Offset = "0x537FDA0", VA = "0x1853811A0")]
			set
			{
			}
		}

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x8")]
		private bool is_array;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x9")]
		private bool is_list;
	}
}
