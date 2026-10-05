using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001199 RID: 4505
	[Token(Token = "0x2001199")]
	public class RoguelikeTotemBuffModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06006F86 RID: 28550 RVA: 0x000326E8 File Offset: 0x000308E8
		[Token(Token = "0x17000D3E")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006F86")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F87")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTotemBuffModuleData()
		{
		}

		// Token: 0x04006079 RID: 24697
		[Token(Token = "0x4006079")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeTotemBuffData> totemBuffDatas;

		// Token: 0x0400607A RID: 24698
		[Token(Token = "0x400607A")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeTotemSubBuffData> subBuffs;

		// Token: 0x0400607B RID: 24699
		[Token(Token = "0x400607B")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTotemModuleConsts moduleConsts;
	}
}
