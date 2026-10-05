using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001251 RID: 4689
	[Token(Token = "0x2001251")]
	public class RoguelikeEndingDetailText
	{
		// Token: 0x060071CA RID: 29130 RVA: 0x00032B80 File Offset: 0x00030D80
		[Token(Token = "0x60071CA")]
		[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
		public bool ShouldSerializespZoneEvtType()
		{
			return default(bool);
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeEndingDetailText()
		{
		}

		// Token: 0x04006762 RID: 26466
		[Token(Token = "0x4006762")]
		[FieldOffset(Offset = "0x10")]
		public string textId;

		// Token: 0x04006763 RID: 26467
		[Token(Token = "0x4006763")]
		[FieldOffset(Offset = "0x18")]
		public string text;

		// Token: 0x04006764 RID: 26468
		[Token(Token = "0x4006764")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeEventType eventType;

		// Token: 0x04006765 RID: 26469
		[Token(Token = "0x4006765")]
		[FieldOffset(Offset = "0x28")]
		public string spZoneEvtType;

		// Token: 0x04006766 RID: 26470
		[Token(Token = "0x4006766")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeEndingDetailText.Type showType;

		// Token: 0x04006767 RID: 26471
		[Token(Token = "0x4006767")]
		[FieldOffset(Offset = "0x38")]
		public string choiceSceneId;

		// Token: 0x04006768 RID: 26472
		[Token(Token = "0x4006768")]
		[FieldOffset(Offset = "0x40")]
		public List<string> paramList;

		// Token: 0x04006769 RID: 26473
		[Token(Token = "0x4006769")]
		[FieldOffset(Offset = "0x48")]
		public string otherPara1;

		// Token: 0x02001252 RID: 4690
		[Token(Token = "0x2001252")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Type
		{
			// Token: 0x0400676B RID: 26475
			[Token(Token = "0x400676B")]
			SHOW_CHOICE,
			// Token: 0x0400676C RID: 26476
			[Token(Token = "0x400676C")]
			SHOW_RELIC,
			// Token: 0x0400676D RID: 26477
			[Token(Token = "0x400676D")]
			SHOW_CAPSULE,
			// Token: 0x0400676E RID: 26478
			[Token(Token = "0x400676E")]
			SHOW_ACTIVE_TOOL,
			// Token: 0x0400676F RID: 26479
			[Token(Token = "0x400676F")]
			SHOW_ACCELERATE_CHAR,
			// Token: 0x04006770 RID: 26480
			[Token(Token = "0x4006770")]
			SHOW_NORMAL_RECRUIT,
			// Token: 0x04006771 RID: 26481
			[Token(Token = "0x4006771")]
			SHOW_DIRECT_RECRUIT,
			// Token: 0x04006772 RID: 26482
			[Token(Token = "0x4006772")]
			SHOW_FRIEND_RECRUIT,
			// Token: 0x04006773 RID: 26483
			[Token(Token = "0x4006773")]
			SHOW_FREE_RECRUIT,
			// Token: 0x04006774 RID: 26484
			[Token(Token = "0x4006774")]
			BUY,
			// Token: 0x04006775 RID: 26485
			[Token(Token = "0x4006775")]
			INVEST,
			// Token: 0x04006776 RID: 26486
			[Token(Token = "0x4006776")]
			SHOW_STAGE,
			// Token: 0x04006777 RID: 26487
			[Token(Token = "0x4006777")]
			SHOW_CONST,
			// Token: 0x04006778 RID: 26488
			[Token(Token = "0x4006778")]
			SUM,
			// Token: 0x04006779 RID: 26489
			[Token(Token = "0x4006779")]
			SHOW_BOSS_END,
			// Token: 0x0400677A RID: 26490
			[Token(Token = "0x400677A")]
			SHOW_BATTLE
		}
	}
}
