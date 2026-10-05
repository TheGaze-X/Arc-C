using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008E9 RID: 2281
	[Token(Token = "0x20008E9")]
	public interface ISquadMemberCompInfo : IHotfixable
	{
		// Token: 0x060065A2 RID: 26018
		[Token(Token = "0x60065A2")]
		IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo();

		// Token: 0x060065A3 RID: 26019
		[Token(Token = "0x60065A3")]
		int ExtraTmplCount();

		// Token: 0x060065A4 RID: 26020
		[Token(Token = "0x60065A4")]
		string GetDefaultEquipId();
	}
}
