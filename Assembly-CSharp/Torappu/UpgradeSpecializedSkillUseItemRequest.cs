using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008DB RID: 2267
	[Token(Token = "0x20008DB")]
	public class UpgradeSpecializedSkillUseItemRequest
	{
		// Token: 0x06006590 RID: 26000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006590")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UpgradeSpecializedSkillUseItemRequest()
		{
		}

		// Token: 0x040032EB RID: 13035
		[Token(Token = "0x40032EB")]
		[FieldOffset(Offset = "0x10")]
		public int charInsId;

		// Token: 0x040032EC RID: 13036
		[Token(Token = "0x40032EC")]
		[FieldOffset(Offset = "0x14")]
		public int skillIndex;

		// Token: 0x040032ED RID: 13037
		[Token(Token = "0x40032ED")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x040032EE RID: 13038
		[Token(Token = "0x40032EE")]
		[FieldOffset(Offset = "0x20")]
		public int itemInsId;
	}
}
