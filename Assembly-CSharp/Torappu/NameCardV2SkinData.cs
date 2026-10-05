using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001001 RID: 4097
	[Token(Token = "0x2001001")]
	public class NameCardV2SkinData
	{
		// Token: 0x06006D59 RID: 27993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D59")]
		[Address(RVA = "0x21087A0", Offset = "0x21073A0", VA = "0x1821087A0")]
		public NameCardV2SkinData()
		{
		}

		// Token: 0x040056E0 RID: 22240
		[Token(Token = "0x40056E0")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040056E1 RID: 22241
		[Token(Token = "0x40056E1")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040056E2 RID: 22242
		[Token(Token = "0x40056E2")]
		[FieldOffset(Offset = "0x20")]
		public NameCardV2SkinType type;

		// Token: 0x040056E3 RID: 22243
		[Token(Token = "0x40056E3")]
		[FieldOffset(Offset = "0x24")]
		public bool isSecret;

		// Token: 0x040056E4 RID: 22244
		[Token(Token = "0x40056E4")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;

		// Token: 0x040056E5 RID: 22245
		[Token(Token = "0x40056E5")]
		[FieldOffset(Offset = "0x2C")]
		public bool isSpTheme;

		// Token: 0x040056E6 RID: 22246
		[Token(Token = "0x40056E6")]
		[FieldOffset(Offset = "0x2D")]
		public bool defaultShowDetail;

		// Token: 0x040056E7 RID: 22247
		[Token(Token = "0x40056E7")]
		[FieldOffset(Offset = "0x30")]
		public string themeName;

		// Token: 0x040056E8 RID: 22248
		[Token(Token = "0x40056E8")]
		[FieldOffset(Offset = "0x38")]
		public string themeEnName;

		// Token: 0x040056E9 RID: 22249
		[Token(Token = "0x40056E9")]
		[FieldOffset(Offset = "0x40")]
		public long skinStartTime;

		// Token: 0x040056EA RID: 22250
		[Token(Token = "0x40056EA")]
		[FieldOffset(Offset = "0x48")]
		public string skinDesc;

		// Token: 0x040056EB RID: 22251
		[Token(Token = "0x40056EB")]
		[FieldOffset(Offset = "0x50")]
		public string usageDesc;

		// Token: 0x040056EC RID: 22252
		[Token(Token = "0x40056EC")]
		[FieldOffset(Offset = "0x58")]
		public string skinApproach;

		// Token: 0x040056ED RID: 22253
		[Token(Token = "0x40056ED")]
		[FieldOffset(Offset = "0x60")]
		public int unlockConditionCnt;

		// Token: 0x040056EE RID: 22254
		[Token(Token = "0x40056EE")]
		[FieldOffset(Offset = "0x68")]
		public List<string> unlockDescList;

		// Token: 0x040056EF RID: 22255
		[Token(Token = "0x40056EF")]
		[FieldOffset(Offset = "0x70")]
		public List<string> fixedModuleList;

		// Token: 0x040056F0 RID: 22256
		[Token(Token = "0x40056F0")]
		[FieldOffset(Offset = "0x78")]
		public ItemRarity rarity;

		// Token: 0x040056F1 RID: 22257
		[Token(Token = "0x40056F1")]
		[FieldOffset(Offset = "0x7C")]
		public int skinTmplCnt;

		// Token: 0x040056F2 RID: 22258
		[Token(Token = "0x40056F2")]
		[FieldOffset(Offset = "0x80")]
		public bool canChangeTmpl;

		// Token: 0x040056F3 RID: 22259
		[Token(Token = "0x40056F3")]
		[FieldOffset(Offset = "0x81")]
		public bool isTimeLimit;

		// Token: 0x040056F4 RID: 22260
		[Token(Token = "0x40056F4")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<string, NameCardV2TimeLimitInfo> timeLimitInfoList;
	}
}
