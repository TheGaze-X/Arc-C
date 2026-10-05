using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FF4 RID: 4084
	[Token(Token = "0x2000FF4")]
	public class HomeBackgroundData
	{
		// Token: 0x06006D4D RID: 27981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D4D")]
		[Address(RVA = "0x2105B10", Offset = "0x2104710", VA = "0x182105B10")]
		public HomeBackgroundData()
		{
		}

		// Token: 0x0400569B RID: 22171
		[Token(Token = "0x400569B")]
		[FieldOffset(Offset = "0x10")]
		public string defaultBackgroundId;

		// Token: 0x0400569C RID: 22172
		[Token(Token = "0x400569C")]
		[FieldOffset(Offset = "0x18")]
		public string defaultThemeId;

		// Token: 0x0400569D RID: 22173
		[Token(Token = "0x400569D")]
		[FieldOffset(Offset = "0x20")]
		public List<HomeBackgroundSingleData> homeBgDataList;

		// Token: 0x0400569E RID: 22174
		[Token(Token = "0x400569E")]
		[FieldOffset(Offset = "0x28")]
		public List<ArtGalleryGroupData> backgroundGroupDatas;

		// Token: 0x0400569F RID: 22175
		[Token(Token = "0x400569F")]
		[FieldOffset(Offset = "0x30")]
		public List<HomeThemeDisplayData> themeList;

		// Token: 0x040056A0 RID: 22176
		[Token(Token = "0x40056A0")]
		[FieldOffset(Offset = "0x38")]
		public List<ArtGalleryGroupData> themeGroupDatas;

		// Token: 0x040056A1 RID: 22177
		[Token(Token = "0x40056A1")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, HomeBackgroundLimitData> backgroundLimitData;

		// Token: 0x040056A2 RID: 22178
		[Token(Token = "0x40056A2")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, HomeThemeLimitData> themeLimitData;

		// Token: 0x040056A3 RID: 22179
		[Token(Token = "0x40056A3")]
		[FieldOffset(Offset = "0x50")]
		public List<HomeMultiFormInfoData> multiFormInfoData;

		// Token: 0x040056A4 RID: 22180
		[Token(Token = "0x40056A4")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, List<HomeMultiFormTimeRuleData>> timeRuleData;

		// Token: 0x040056A5 RID: 22181
		[Token(Token = "0x40056A5")]
		[FieldOffset(Offset = "0x60")]
		public string defaultBgMusicId;

		// Token: 0x040056A6 RID: 22182
		[Token(Token = "0x40056A6")]
		[FieldOffset(Offset = "0x68")]
		public long themeStartTime;
	}
}
