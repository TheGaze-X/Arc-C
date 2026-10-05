using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B5D RID: 2909
	[Token(Token = "0x2000B5D")]
	public class PlayerFirework
	{
		// Token: 0x060067FE RID: 26622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067FE")]
		[Address(RVA = "0x1EFA270", Offset = "0x1EF8E70", VA = "0x181EFA270")]
		public PlayerFirework()
		{
		}

		// Token: 0x04003C94 RID: 15508
		[Token(Token = "0x4003C94")]
		[FieldOffset(Offset = "0x10")]
		public bool unlock;

		// Token: 0x04003C95 RID: 15509
		[Token(Token = "0x4003C95")]
		[FieldOffset(Offset = "0x18")]
		public PlayerFirework.PlayerPlate plate;

		// Token: 0x04003C96 RID: 15510
		[Token(Token = "0x4003C96")]
		[FieldOffset(Offset = "0x20")]
		public PlayerFirework.PlayerAnimal animal;

		// Token: 0x02000B5E RID: 2910
		[Token(Token = "0x2000B5E")]
		public class PlayerPlate
		{
			// Token: 0x060067FF RID: 26623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067FF")]
			[Address(RVA = "0x1EFC100", Offset = "0x1EFAD00", VA = "0x181EFC100")]
			public PlayerPlate()
			{
			}

			// Token: 0x04003C97 RID: 15511
			[Token(Token = "0x4003C97")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> unlock;

			// Token: 0x04003C98 RID: 15512
			[Token(Token = "0x4003C98")]
			[FieldOffset(Offset = "0x18")]
			public List<FireworkData.PlateSlotData> slots;
		}

		// Token: 0x02000B5F RID: 2911
		[Token(Token = "0x2000B5F")]
		public class PlayerAnimal
		{
			// Token: 0x06006800 RID: 26624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006800")]
			[Address(RVA = "0x1EF0EC0", Offset = "0x1EEFAC0", VA = "0x181EF0EC0")]
			public PlayerAnimal()
			{
			}

			// Token: 0x04003C99 RID: 15513
			[Token(Token = "0x4003C99")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> unlock;

			// Token: 0x04003C9A RID: 15514
			[Token(Token = "0x4003C9A")]
			[FieldOffset(Offset = "0x18")]
			public string select;
		}
	}
}
