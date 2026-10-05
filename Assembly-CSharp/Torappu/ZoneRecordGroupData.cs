using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013C7 RID: 5063
	[Token(Token = "0x20013C7")]
	[Serializable]
	public class ZoneRecordGroupData
	{
		// Token: 0x060073B8 RID: 29624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZoneRecordGroupData()
		{
		}

		// Token: 0x0400709B RID: 28827
		[Token(Token = "0x400709B")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x0400709C RID: 28828
		[Token(Token = "0x400709C")]
		[FieldOffset(Offset = "0x18")]
		public List<ZoneRecordData> records;

		// Token: 0x0400709D RID: 28829
		[Token(Token = "0x400709D")]
		[FieldOffset(Offset = "0x20")]
		public ZoneRecordUnlockData unlockData;
	}
}
