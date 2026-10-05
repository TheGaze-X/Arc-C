using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013CE RID: 5070
	[Token(Token = "0x20013CE")]
	public class ZoneRecordMissionData
	{
		// Token: 0x060073BE RID: 29630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZoneRecordMissionData()
		{
		}

		// Token: 0x040070BE RID: 28862
		[Token(Token = "0x40070BE")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x040070BF RID: 28863
		[Token(Token = "0x40070BF")]
		[FieldOffset(Offset = "0x18")]
		public string recordStageId;

		// Token: 0x040070C0 RID: 28864
		[Token(Token = "0x40070C0")]
		[FieldOffset(Offset = "0x20")]
		public string templateDesc;

		// Token: 0x040070C1 RID: 28865
		[Token(Token = "0x40070C1")]
		[FieldOffset(Offset = "0x28")]
		public string desc;
	}
}
