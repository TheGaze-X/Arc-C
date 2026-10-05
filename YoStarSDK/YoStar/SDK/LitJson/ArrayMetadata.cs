using System;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x20002E9")]
	internal struct ArrayMetadata
	{
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001F0")]
		public Type ElementType
		{
			[Token(Token = "0x60010FA")]
			[Address(RVA = "0x5CD2790", Offset = "0x5CD1390", VA = "0x185CD2790")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010FB")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x00004814 File Offset: 0x00002A14
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001F1")]
		public bool IsArray
		{
			[Token(Token = "0x60010FC")]
			[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010FD")]
			[Address(RVA = "0xFEDEE0", Offset = "0xFECAE0", VA = "0x180FEDEE0")]
			set
			{
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x0000482C File Offset: 0x00002A2C
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001F2")]
		public bool IsList
		{
			[Token(Token = "0x60010FE")]
			[Address(RVA = "0x4C084E0", Offset = "0x4C070E0", VA = "0x184C084E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010FF")]
			[Address(RVA = "0x53811A0", Offset = "0x537FDA0", VA = "0x1853811A0")]
			set
			{
			}
		}

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x04000DE6 RID: 3558
		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x8")]
		private bool is_array;

		// Token: 0x04000DE7 RID: 3559
		[Token(Token = "0x4000DE7")]
		[FieldOffset(Offset = "0x9")]
		private bool is_list;
	}
}
