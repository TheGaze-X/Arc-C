using System;
using Il2CppDummyDll;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004816 RID: 18454
	[Token(Token = "0x2004816")]
	public struct MonopolyCalculateDelayInfoInput
	{
		// Token: 0x040245FC RID: 148988
		[Token(Token = "0x40245FC")]
		[FieldOffset(Offset = "0x0")]
		public MonopolyEventType eventType;

		// Token: 0x040245FD RID: 148989
		[Token(Token = "0x40245FD")]
		[FieldOffset(Offset = "0x4")]
		public bool taskProgressed;

		// Token: 0x040245FE RID: 148990
		[Token(Token = "0x40245FE")]
		[FieldOffset(Offset = "0x5")]
		public bool combo;
	}
}
