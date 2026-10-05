using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003AD6 RID: 15062
	[Token(Token = "0x2003AD6")]
	public class MedalNotifyViewParam : NotifyViewParam
	{
		// Token: 0x06017C03 RID: 97283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C03")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public MedalNotifyViewParam()
		{
		}

		// Token: 0x0401CADD RID: 117469
		[Token(Token = "0x401CADD")]
		[FieldOffset(Offset = "0x10")]
		public List<MedalPerData> medals;
	}
}
