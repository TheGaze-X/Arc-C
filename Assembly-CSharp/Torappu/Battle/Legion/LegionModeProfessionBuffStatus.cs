using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A28 RID: 10792
	[Token(Token = "0x2002A28")]
	public struct LegionModeProfessionBuffStatus
	{
		// Token: 0x06011EA8 RID: 73384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EA8")]
		[Address(RVA = "0x9C8E50", Offset = "0x9C7A50", VA = "0x1809C8E50")]
		public LegionModeProfessionBuffStatus(int _level, ProfessionCategory _profession, string _description)
		{
		}

		// Token: 0x040142E5 RID: 82661
		[Token(Token = "0x40142E5")]
		[FieldOffset(Offset = "0x0")]
		public int level;

		// Token: 0x040142E6 RID: 82662
		[Token(Token = "0x40142E6")]
		[FieldOffset(Offset = "0x4")]
		public ProfessionCategory profession;

		// Token: 0x040142E7 RID: 82663
		[Token(Token = "0x40142E7")]
		[FieldOffset(Offset = "0x8")]
		public string description;
	}
}
