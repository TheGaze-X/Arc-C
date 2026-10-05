using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001215 RID: 4629
	[Token(Token = "0x2001215")]
	public class RoguelikeChoiceDisplayData
	{
		// Token: 0x06007010 RID: 28688 RVA: 0x00032AF0 File Offset: 0x00030CF0
		[Token(Token = "0x6007010")]
		[Address(RVA = "0x20086C0", Offset = "0x20072C0", VA = "0x1820086C0")]
		public bool ShouldSerializecostHintType()
		{
			return default(bool);
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x00032B08 File Offset: 0x00030D08
		[Token(Token = "0x6007011")]
		[Address(RVA = "0x21109C0", Offset = "0x210F5C0", VA = "0x1821109C0")]
		public bool ShouldSerializeeffectHintType()
		{
			return default(bool);
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x00032B20 File Offset: 0x00030D20
		[Token(Token = "0x6007012")]
		[Address(RVA = "0x1FFE4D0", Offset = "0x1FFD0D0", VA = "0x181FFE4D0")]
		public bool ShouldSerializedifficultyUpgradeRelicGroupId()
		{
			return default(bool);
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007013")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeChoiceDisplayData()
		{
		}

		// Token: 0x040063FA RID: 25594
		[Token(Token = "0x40063FA")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeChoiceDisplayType type;

		// Token: 0x040063FB RID: 25595
		[Token(Token = "0x40063FB")]
		[FieldOffset(Offset = "0x14")]
		public RoguelikeChoiceHintType costHintType;

		// Token: 0x040063FC RID: 25596
		[Token(Token = "0x40063FC")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeChoiceHintType effectHintType;

		// Token: 0x040063FD RID: 25597
		[Token(Token = "0x40063FD")]
		[FieldOffset(Offset = "0x20")]
		public string funcIconId;

		// Token: 0x040063FE RID: 25598
		[Token(Token = "0x40063FE")]
		[FieldOffset(Offset = "0x28")]
		public string itemId;

		// Token: 0x040063FF RID: 25599
		[Token(Token = "0x40063FF")]
		[FieldOffset(Offset = "0x30")]
		public string difficultyUpgradeRelicGroupId;

		// Token: 0x04006400 RID: 25600
		[Token(Token = "0x4006400")]
		[FieldOffset(Offset = "0x38")]
		public string taskId;
	}
}
