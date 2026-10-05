using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B47 RID: 2887
	[Token(Token = "0x2000B47")]
	public class PlayerCartInfo
	{
		// Token: 0x060067F3 RID: 26611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067F3")]
		[Address(RVA = "0x1EF2C90", Offset = "0x1EF1890", VA = "0x181EF2C90")]
		public PlayerCartInfo()
		{
		}

		// Token: 0x04003C47 RID: 15431
		[Token(Token = "0x4003C47")]
		[FieldOffset(Offset = "0x10")]
		public PlayerCartInfo.Cart battleCar;

		// Token: 0x04003C48 RID: 15432
		[Token(Token = "0x4003C48")]
		[FieldOffset(Offset = "0x18")]
		public PlayerCartInfo.Cart exhibitionCar;

		// Token: 0x04003C49 RID: 15433
		[Token(Token = "0x4003C49")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, PlayerCartInfo.CompInfo> accessories;

		// Token: 0x02000B48 RID: 2888
		[Token(Token = "0x2000B48")]
		[Serializable]
		public class Cart : Dictionary<CartComponents.CartAccessoryPos, string>
		{
			// Token: 0x060067F4 RID: 26612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067F4")]
			[Address(RVA = "0x1EE7250", Offset = "0x1EE5E50", VA = "0x181EE7250")]
			public Cart()
			{
			}
		}

		// Token: 0x02000B49 RID: 2889
		[Token(Token = "0x2000B49")]
		public class CompInfo
		{
			// Token: 0x060067F5 RID: 26613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067F5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CompInfo()
			{
			}

			// Token: 0x04003C4A RID: 15434
			[Token(Token = "0x4003C4A")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04003C4B RID: 15435
			[Token(Token = "0x4003C4B")]
			[FieldOffset(Offset = "0x18")]
			public int num;
		}
	}
}
