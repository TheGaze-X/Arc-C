using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052BD RID: 21181
	[Token(Token = "0x20052BD")]
	public class RoguelikeClassicEndingStatsInfoViewModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x0601F3D2 RID: 127954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3D2")]
		[Address(RVA = "0x18F5720", Offset = "0x18F4320", VA = "0x1818F5720", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x0601F3D3 RID: 127955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3D3")]
		[Address(RVA = "0x18F5E30", Offset = "0x18F4A30", VA = "0x1818F5E30")]
		public RoguelikeClassicEndingStatsInfoViewModel()
		{
		}

		// Token: 0x04029F44 RID: 171844
		[Token(Token = "0x4029F44")]
		[FieldOffset(Offset = "0x10")]
		public bool isSuccess;

		// Token: 0x04029F45 RID: 171845
		[Token(Token = "0x4029F45")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeRelicViewModel initialRelic;

		// Token: 0x04029F46 RID: 171846
		[Token(Token = "0x4029F46")]
		[FieldOffset(Offset = "0x20")]
		public string theme;

		// Token: 0x04029F47 RID: 171847
		[Token(Token = "0x4029F47")]
		[FieldOffset(Offset = "0x28")]
		public string endingId;

		// Token: 0x04029F48 RID: 171848
		[Token(Token = "0x4029F48")]
		[FieldOffset(Offset = "0x30")]
		public string failEndingId;

		// Token: 0x04029F49 RID: 171849
		[Token(Token = "0x4029F49")]
		[FieldOffset(Offset = "0x38")]
		public string endingName;

		// Token: 0x04029F4A RID: 171850
		[Token(Token = "0x4029F4A")]
		[FieldOffset(Offset = "0x40")]
		public string endingDesc;

		// Token: 0x04029F4B RID: 171851
		[Token(Token = "0x4029F4B")]
		[FieldOffset(Offset = "0x48")]
		public string endZoneId;

		// Token: 0x04029F4C RID: 171852
		[Token(Token = "0x4029F4C")]
		[FieldOffset(Offset = "0x50")]
		public string endZoneName;

		// Token: 0x04029F4D RID: 171853
		[Token(Token = "0x4029F4D")]
		[FieldOffset(Offset = "0x58")]
		public string endZoneFailDesc;

		// Token: 0x04029F4E RID: 171854
		[Token(Token = "0x4029F4E")]
		[FieldOffset(Offset = "0x60")]
		public long startTs;

		// Token: 0x04029F4F RID: 171855
		[Token(Token = "0x4029F4F")]
		[FieldOffset(Offset = "0x68")]
		public long endTs;

		// Token: 0x04029F50 RID: 171856
		[Token(Token = "0x4029F50")]
		[FieldOffset(Offset = "0x70")]
		public string timeFormatStr;

		// Token: 0x04029F51 RID: 171857
		[Token(Token = "0x4029F51")]
		[FieldOffset(Offset = "0x78")]
		public string nickName;

		// Token: 0x04029F52 RID: 171858
		[Token(Token = "0x4029F52")]
		[FieldOffset(Offset = "0x80")]
		public int modeGrade;

		// Token: 0x04029F53 RID: 171859
		[Token(Token = "0x4029F53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029F54 RID: 171860
		[Token(Token = "0x4029F54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
