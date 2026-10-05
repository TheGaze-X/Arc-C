using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CAE RID: 7342
	[Token(Token = "0x2001CAE")]
	public class StationCharSlotPosition
	{
		// Token: 0x0600B5F4 RID: 46580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StationCharSlotPosition()
		{
		}

		// Token: 0x0400B2AD RID: 45741
		[Token(Token = "0x400B2AD")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x0400B2AE RID: 45742
		[Token(Token = "0x400B2AE")]
		[FieldOffset(Offset = "0x18")]
		public int index;
	}
}
