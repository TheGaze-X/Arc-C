using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	[Flags]
	public enum SearchFilterOptions
	{
		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		PropertyName = 1,
		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		PropertyNiceName = 2,
		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		TypeOfValue = 4,
		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		ValueToString = 8,
		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		ISearchFilterableInterface = 16,
		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		All = -1
	}
}
