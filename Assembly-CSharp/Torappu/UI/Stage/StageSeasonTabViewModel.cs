using System;
using Il2CppDummyDll;
using Torappu.UI.CrisisV2;

namespace Torappu.UI.Stage
{
	// Token: 0x020069BC RID: 27068
	[Token(Token = "0x20069BC")]
	public class StageSeasonTabViewModel : StageZoneTabViewModel
	{
		// Token: 0x06026BCB RID: 158667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BCB")]
		[Address(RVA = "0x21D7310", Offset = "0x21D5F10", VA = "0x1821D7310")]
		public StageSeasonTabViewModel()
		{
		}

		// Token: 0x04036B30 RID: 224048
		[Token(Token = "0x4036B30")]
		[FieldOffset(Offset = "0x20")]
		public CrisisV2SeasonBasicInfo crisisInfo;

		// Token: 0x04036B31 RID: 224049
		[Token(Token = "0x4036B31")]
		[FieldOffset(Offset = "0x50")]
		public ActivityTable.BasicData vecBreakInfo;

		// Token: 0x04036B32 RID: 224050
		[Token(Token = "0x4036B32")]
		[FieldOffset(Offset = "0x58")]
		public bool hasTrackPoint;
	}
}
