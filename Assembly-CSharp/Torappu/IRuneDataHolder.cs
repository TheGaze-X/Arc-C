using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001264 RID: 4708
	[Token(Token = "0x2001264")]
	public interface IRuneDataHolder
	{
		// Token: 0x060071E3 RID: 29155
		[Token(Token = "0x60071E3")]
		void ForeachRuneData(Action<RuneData> visitor);

		// Token: 0x060071E4 RID: 29156
		[Token(Token = "0x60071E4")]
		void ForeachPackedRuneData(Action<RuneTable.PackedRuneData> visitor);
	}
}
