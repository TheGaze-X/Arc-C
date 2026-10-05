using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011B8 RID: 4536
	[Token(Token = "0x20011B8")]
	public class RoguelikeCopperModuleData : RoguelikeModuleBaseData
	{
		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06006FA1 RID: 28577 RVA: 0x00032760 File Offset: 0x00030960
		[Token(Token = "0x17000D43")]
		public override RoguelikeModuleType moduleType
		{
			[Token(Token = "0x6006FA1")]
			[Address(RVA = "0x54AFD0", Offset = "0x549BD0", VA = "0x18054AFD0", Slot = "4")]
			get
			{
				return RoguelikeModuleType.NONE;
			}
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA2")]
		[Address(RVA = "0x2110E20", Offset = "0x210FA20", VA = "0x182110E20")]
		public RoguelikeCopperModuleData()
		{
		}

		// Token: 0x04006118 RID: 24856
		[Token(Token = "0x4006118")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeCopperData> copperData;

		// Token: 0x04006119 RID: 24857
		[Token(Token = "0x4006119")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeCopperDivineData> copperDivineData;

		// Token: 0x0400611A RID: 24858
		[Token(Token = "0x400611A")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, RoguelikeCopperGildTypeData> copperGildTypeData;

		// Token: 0x0400611B RID: 24859
		[Token(Token = "0x400611B")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, string> changeCopperMap;

		// Token: 0x0400611C RID: 24860
		[Token(Token = "0x400611C")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeCopperModuleConsts moduleConsts;
	}
}
