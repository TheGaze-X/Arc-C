using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F7F RID: 3967
	[Token(Token = "0x2000F7F")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CharWordShowType
	{
		// Token: 0x04005437 RID: 21559
		[Token(Token = "0x4005437")]
		HOME_SHOW,
		// Token: 0x04005438 RID: 21560
		[Token(Token = "0x4005438")]
		HOME_PLACE,
		// Token: 0x04005439 RID: 21561
		[Token(Token = "0x4005439")]
		HOME_WAIT,
		// Token: 0x0400543A RID: 21562
		[Token(Token = "0x400543A")]
		GACHA,
		// Token: 0x0400543B RID: 21563
		[Token(Token = "0x400543B")]
		EVOLVE_ONE,
		// Token: 0x0400543C RID: 21564
		[Token(Token = "0x400543C")]
		EVOLVE_TWO,
		// Token: 0x0400543D RID: 21565
		[Token(Token = "0x400543D")]
		FOUR_STAR,
		// Token: 0x0400543E RID: 21566
		[Token(Token = "0x400543E")]
		THREE_STAR,
		// Token: 0x0400543F RID: 21567
		[Token(Token = "0x400543F")]
		TWO_STAR,
		// Token: 0x04005440 RID: 21568
		[Token(Token = "0x4005440")]
		LOSE,
		// Token: 0x04005441 RID: 21569
		[Token(Token = "0x4005441")]
		LEVEL_UP,
		// Token: 0x04005442 RID: 21570
		[Token(Token = "0x4005442")]
		SQUAD,
		// Token: 0x04005443 RID: 21571
		[Token(Token = "0x4005443")]
		SQUAD_FIRST,
		// Token: 0x04005444 RID: 21572
		[Token(Token = "0x4005444")]
		BATTLE_START,
		// Token: 0x04005445 RID: 21573
		[Token(Token = "0x4005445")]
		BATTLE_FACE_ENEMY,
		// Token: 0x04005446 RID: 21574
		[Token(Token = "0x4005446")]
		BATTLE_SELECT,
		// Token: 0x04005447 RID: 21575
		[Token(Token = "0x4005447")]
		BATTLE_PLACE,
		// Token: 0x04005448 RID: 21576
		[Token(Token = "0x4005448")]
		BATTLE_SKILL_1,
		// Token: 0x04005449 RID: 21577
		[Token(Token = "0x4005449")]
		BATTLE_SKILL_2,
		// Token: 0x0400544A RID: 21578
		[Token(Token = "0x400544A")]
		BATTLE_SKILL_3,
		// Token: 0x0400544B RID: 21579
		[Token(Token = "0x400544B")]
		BATTLE_SKILL_4,
		// Token: 0x0400544C RID: 21580
		[Token(Token = "0x400544C")]
		BUILDING_PLACE,
		// Token: 0x0400544D RID: 21581
		[Token(Token = "0x400544D")]
		BUILDING_DRAGGING,
		// Token: 0x0400544E RID: 21582
		[Token(Token = "0x400544E")]
		BUILDING_FAVOR_BUBBLE,
		// Token: 0x0400544F RID: 21583
		[Token(Token = "0x400544F")]
		BUILDING_TOUCHING,
		// Token: 0x04005450 RID: 21584
		[Token(Token = "0x4005450")]
		LOADING_PANEL,
		// Token: 0x04005451 RID: 21585
		[Token(Token = "0x4005451")]
		BIRTHDAY,
		// Token: 0x04005452 RID: 21586
		[Token(Token = "0x4005452")]
		NEW_YEAR,
		// Token: 0x04005453 RID: 21587
		[Token(Token = "0x4005453")]
		VALENT_DAY,
		// Token: 0x04005454 RID: 21588
		[Token(Token = "0x4005454")]
		DRAGON_BOAT_FESTIVAL,
		// Token: 0x04005455 RID: 21589
		[Token(Token = "0x4005455")]
		HALLOWEEN_DAY,
		// Token: 0x04005456 RID: 21590
		[Token(Token = "0x4005456")]
		CHRISMATS_DAY,
		// Token: 0x04005457 RID: 21591
		[Token(Token = "0x4005457")]
		GREETING,
		// Token: 0x04005458 RID: 21592
		[Token(Token = "0x4005458")]
		ANNIVERSARY,
		// Token: 0x04005459 RID: 21593
		[Token(Token = "0x4005459")]
		UNUSED,
		// Token: 0x0400545A RID: 21594
		[Token(Token = "0x400545A")]
		E_ALL
	}
}
