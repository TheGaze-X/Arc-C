using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A27 RID: 10791
	[Token(Token = "0x2002A27")]
	public class LegionModeProfessionBuffDetail
	{
		// Token: 0x06011EA7 RID: 73383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EA7")]
		[Address(RVA = "0x9C8DD0", Offset = "0x9C79D0", VA = "0x1809C8DD0")]
		public LegionModeProfessionBuffDetail(LegionModeBuffData.LegionModeBuffDataPart data, List<Blackboard> blackboards)
		{
		}

		// Token: 0x040142E0 RID: 82656
		[Token(Token = "0x40142E0")]
		[FieldOffset(Offset = "0x10")]
		public List<Blackboard> blackboards;

		// Token: 0x040142E1 RID: 82657
		[Token(Token = "0x40142E1")]
		[FieldOffset(Offset = "0x18")]
		public bool isRedrawWhenReplace;

		// Token: 0x040142E2 RID: 82658
		[Token(Token = "0x40142E2")]
		[FieldOffset(Offset = "0x19")]
		public bool isInheritable;

		// Token: 0x040142E3 RID: 82659
		[Token(Token = "0x40142E3")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x040142E4 RID: 82660
		[Token(Token = "0x40142E4")]
		[FieldOffset(Offset = "0x28")]
		public string descriptionHead;
	}
}
