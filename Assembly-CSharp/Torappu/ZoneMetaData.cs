using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013CD RID: 5069
	[Token(Token = "0x20013CD")]
	public class ZoneMetaData
	{
		// Token: 0x060073BD RID: 29629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BD")]
		[Address(RVA = "0x2218090", Offset = "0x2216C90", VA = "0x182218090")]
		public ZoneMetaData()
		{
		}

		// Token: 0x040070BD RID: 28861
		[Token(Token = "0x40070BD")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ZoneRecordMissionData> ZoneRecordMissionData;
	}
}
