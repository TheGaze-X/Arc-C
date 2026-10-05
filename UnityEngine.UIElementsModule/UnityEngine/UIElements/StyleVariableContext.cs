using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200025B RID: 603
	[Token(Token = "0x200025B")]
	internal class StyleVariableContext
	{
		// Token: 0x06001111 RID: 4369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x5B24FB0", Offset = "0x5B23BB0", VA = "0x185B24FB0")]
		public void Add(StyleVariable sv)
		{
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x5B24EC0", Offset = "0x5B23AC0", VA = "0x185B24EC0")]
		public void AddInitialRange(StyleVariableContext other)
		{
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001113")]
		[Address(RVA = "0x5B25140", Offset = "0x5B23D40", VA = "0x185B25140")]
		public void Clear()
		{
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001114")]
		[Address(RVA = "0x5B25510", Offset = "0x5B24110", VA = "0x185B25510")]
		public StyleVariableContext()
		{
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001115")]
		[Address(RVA = "0x5B25410", Offset = "0x5B24010", VA = "0x185B25410")]
		public StyleVariableContext(StyleVariableContext other)
		{
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x6001116")]
		[Address(RVA = "0x5B251E0", Offset = "0x5B23DE0", VA = "0x185B251E0")]
		public bool TryFindVariable(string name, out StyleVariable v)
		{
			return default(bool);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x6001117")]
		[Address(RVA = "0x592C450", Offset = "0x592B050", VA = "0x18592C450")]
		public int GetVariableHash()
		{
			return 0;
		}

		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StyleVariableContext none;

		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		[FieldOffset(Offset = "0x10")]
		private int m_VariableHash;

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0x18")]
		private List<StyleVariable> m_Variables;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x20")]
		private List<int> m_SortedHash;
	}
}
