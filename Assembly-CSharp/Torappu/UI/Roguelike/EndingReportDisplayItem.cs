using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005382 RID: 21378
	[Token(Token = "0x2005382")]
	public class EndingReportDisplayItem
	{
		// Token: 0x0601F835 RID: 129077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F835")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EndingReportDisplayItem()
		{
		}

		// Token: 0x0402A67D RID: 173693
		[Token(Token = "0x402A67D")]
		[FieldOffset(Offset = "0x10")]
		public ReportItemType itemType;

		// Token: 0x0402A67E RID: 173694
		[Token(Token = "0x402A67E")]
		[FieldOffset(Offset = "0x18")]
		public string zoneId;

		// Token: 0x0402A67F RID: 173695
		[Token(Token = "0x402A67F")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeEventType eventType;

		// Token: 0x0402A680 RID: 173696
		[Token(Token = "0x402A680")]
		[FieldOffset(Offset = "0x24")]
		public int nodeDisplaySubType;

		// Token: 0x0402A681 RID: 173697
		[Token(Token = "0x402A681")]
		[FieldOffset(Offset = "0x28")]
		public string ending;

		// Token: 0x0402A682 RID: 173698
		[Token(Token = "0x402A682")]
		[FieldOffset(Offset = "0x30")]
		public List<string> descList;

		// Token: 0x0402A683 RID: 173699
		[Token(Token = "0x402A683")]
		[FieldOffset(Offset = "0x38")]
		public RoguelikeSkyZoneNodeType spZoneEventType;
	}
}
