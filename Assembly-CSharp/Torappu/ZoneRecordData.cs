using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013C8 RID: 5064
	[Token(Token = "0x20013C8")]
	[Serializable]
	public class ZoneRecordData
	{
		// Token: 0x060073B9 RID: 29625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZoneRecordData()
		{
		}

		// Token: 0x0400709E RID: 28830
		[Token(Token = "0x400709E")]
		[FieldOffset(Offset = "0x10")]
		public string recordId;

		// Token: 0x0400709F RID: 28831
		[Token(Token = "0x400709F")]
		[FieldOffset(Offset = "0x18")]
		public string zoneId;

		// Token: 0x040070A0 RID: 28832
		[Token(Token = "0x40070A0")]
		[FieldOffset(Offset = "0x20")]
		public string recordTitleName;

		// Token: 0x040070A1 RID: 28833
		[Token(Token = "0x40070A1")]
		[FieldOffset(Offset = "0x28")]
		public string preRecordId;

		// Token: 0x040070A2 RID: 28834
		[Token(Token = "0x40070A2")]
		[FieldOffset(Offset = "0x30")]
		public string nodeTitle1;

		// Token: 0x040070A3 RID: 28835
		[Token(Token = "0x40070A3")]
		[FieldOffset(Offset = "0x38")]
		public string nodeTitle2;

		// Token: 0x040070A4 RID: 28836
		[Token(Token = "0x40070A4")]
		[FieldOffset(Offset = "0x40")]
		public List<RecordRewardInfo> rewards;
	}
}
