using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020013A4 RID: 5028
	[Token(Token = "0x20013A4")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActArchiveType
	{
		// Token: 0x04006F94 RID: 28564
		[Token(Token = "0x4006F94")]
		NONE,
		// Token: 0x04006F95 RID: 28565
		[Token(Token = "0x4006F95")]
		TIMELINE,
		// Token: 0x04006F96 RID: 28566
		[Token(Token = "0x4006F96")]
		MUSIC,
		// Token: 0x04006F97 RID: 28567
		[Token(Token = "0x4006F97")]
		PIC,
		// Token: 0x04006F98 RID: 28568
		[Token(Token = "0x4006F98")]
		AVG,
		// Token: 0x04006F99 RID: 28569
		[Token(Token = "0x4006F99")]
		STORY,
		// Token: 0x04006F9A RID: 28570
		[Token(Token = "0x4006F9A")]
		NEWS,
		// Token: 0x04006F9B RID: 28571
		[Token(Token = "0x4006F9B")]
		BUFF,
		// Token: 0x04006F9C RID: 28572
		[Token(Token = "0x4006F9C")]
		RELIC,
		// Token: 0x04006F9D RID: 28573
		[Token(Token = "0x4006F9D")]
		CAPSULE,
		// Token: 0x04006F9E RID: 28574
		[Token(Token = "0x4006F9E")]
		TRAP,
		// Token: 0x04006F9F RID: 28575
		[Token(Token = "0x4006F9F")]
		CHAT,
		// Token: 0x04006FA0 RID: 28576
		[Token(Token = "0x4006FA0")]
		LANDMARK,
		// Token: 0x04006FA1 RID: 28577
		[Token(Token = "0x4006FA1")]
		LOG,
		// Token: 0x04006FA2 RID: 28578
		[Token(Token = "0x4006FA2")]
		ACTIVITY_ENTRY,
		// Token: 0x04006FA3 RID: 28579
		[Token(Token = "0x4006FA3")]
		DYNAMIC_MUSIC,
		// Token: 0x04006FA4 RID: 28580
		[Token(Token = "0x4006FA4")]
		DYNAMIC_PIC,
		// Token: 0x04006FA5 RID: 28581
		[Token(Token = "0x4006FA5")]
		ENDBOOK,
		// Token: 0x04006FA6 RID: 28582
		[Token(Token = "0x4006FA6")]
		DYNAMIC_STORY,
		// Token: 0x04006FA7 RID: 28583
		[Token(Token = "0x4006FA7")]
		TOTEM,
		// Token: 0x04006FA8 RID: 28584
		[Token(Token = "0x4006FA8")]
		CHAOS,
		// Token: 0x04006FA9 RID: 28585
		[Token(Token = "0x4006FA9")]
		CHALLENGE_BOOK,
		// Token: 0x04006FAA RID: 28586
		[Token(Token = "0x4006FAA")]
		ACHIEVEMENT,
		// Token: 0x04006FAB RID: 28587
		[Token(Token = "0x4006FAB")]
		QUEST,
		// Token: 0x04006FAC RID: 28588
		[Token(Token = "0x4006FAC")]
		FRAGMENT,
		// Token: 0x04006FAD RID: 28589
		[Token(Token = "0x4006FAD")]
		DISASTER,
		// Token: 0x04006FAE RID: 28590
		[Token(Token = "0x4006FAE")]
		COPPER,
		// Token: 0x04006FAF RID: 28591
		[Token(Token = "0x4006FAF")]
		WRATH
	}
}
