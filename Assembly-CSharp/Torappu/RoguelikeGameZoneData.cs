using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001210 RID: 4624
	[Token(Token = "0x2001210")]
	public class RoguelikeGameZoneData
	{
		// Token: 0x0600700D RID: 28685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600700D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameZoneData()
		{
		}

		// Token: 0x040063D3 RID: 25555
		[Token(Token = "0x40063D3")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040063D4 RID: 25556
		[Token(Token = "0x40063D4")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040063D5 RID: 25557
		[Token(Token = "0x40063D5")]
		[FieldOffset(Offset = "0x20")]
		public string clockPerformance;

		// Token: 0x040063D6 RID: 25558
		[Token(Token = "0x40063D6")]
		[FieldOffset(Offset = "0x28")]
		public string displayTime;

		// Token: 0x040063D7 RID: 25559
		[Token(Token = "0x40063D7")]
		[FieldOffset(Offset = "0x30")]
		public string description;

		// Token: 0x040063D8 RID: 25560
		[Token(Token = "0x40063D8")]
		[FieldOffset(Offset = "0x38")]
		public string buffDescription;

		// Token: 0x040063D9 RID: 25561
		[Token(Token = "0x40063D9")]
		[FieldOffset(Offset = "0x40")]
		public string endingDescription;

		// Token: 0x040063DA RID: 25562
		[Token(Token = "0x40063DA")]
		[FieldOffset(Offset = "0x48")]
		public string backgroundId;

		// Token: 0x040063DB RID: 25563
		[Token(Token = "0x40063DB")]
		[FieldOffset(Offset = "0x50")]
		public string zoneIconId;

		// Token: 0x040063DC RID: 25564
		[Token(Token = "0x40063DC")]
		[FieldOffset(Offset = "0x58")]
		public bool isHiddenZone;

		// Token: 0x040063DD RID: 25565
		[Token(Token = "0x40063DD")]
		[FieldOffset(Offset = "0x60")]
		public string bgmSignal;

		// Token: 0x040063DE RID: 25566
		[Token(Token = "0x40063DE")]
		[FieldOffset(Offset = "0x68")]
		public string bgmSignalWithLowSan;
	}
}
