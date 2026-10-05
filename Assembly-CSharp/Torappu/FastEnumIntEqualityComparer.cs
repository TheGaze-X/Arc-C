using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013E3 RID: 5091
	[Token(Token = "0x20013E3")]
	internal struct FastEnumIntEqualityComparer<TEnum> : IEqualityComparer<TEnum> where TEnum : struct
	{
		// Token: 0x06007435 RID: 29749 RVA: 0x00033B10 File Offset: 0x00031D10
		[Token(Token = "0x6007435")]
		private int ToInt(TEnum en)
		{
			return 0;
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x00033B28 File Offset: 0x00031D28
		[Token(Token = "0x6007436")]
		public bool Equals(TEnum firstEnum, TEnum secondEnum)
		{
			return default(bool);
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x00033B40 File Offset: 0x00031D40
		[Token(Token = "0x6007437")]
		public int GetHashCode(TEnum firstEnum)
		{
			return 0;
		}
	}
}
