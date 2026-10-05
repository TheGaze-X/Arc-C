using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.DB.Test
{
	// Token: 0x020016BB RID: 5819
	[Token(Token = "0x20016BB")]
	[Serializable]
	public class SkillData
	{
		// Token: 0x06009333 RID: 37683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009333")]
		[Address(RVA = "0x2B3B6A0", Offset = "0x2B3A2A0", VA = "0x182B3B6A0")]
		public SkillData()
		{
		}

		// Token: 0x040088DF RID: 35039
		[Token(Token = "0x40088DF")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x040088E0 RID: 35040
		[Token(Token = "0x40088E0")]
		[FieldOffset(Offset = "0x18")]
		public int sortID;

		// Token: 0x040088E1 RID: 35041
		[Token(Token = "0x40088E1")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x040088E2 RID: 35042
		[Token(Token = "0x40088E2")]
		[FieldOffset(Offset = "0x28")]
		public string info;

		// Token: 0x040088E3 RID: 35043
		[Token(Token = "0x40088E3")]
		[FieldOffset(Offset = "0x30")]
		public string animationKey;

		// Token: 0x040088E4 RID: 35044
		[Token(Token = "0x40088E4")]
		[FieldOffset(Offset = "0x38")]
		public int maxLvl;

		// Token: 0x040088E5 RID: 35045
		[Token(Token = "0x40088E5")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<int, string> lvlInfo;

		// Token: 0x040088E6 RID: 35046
		[Token(Token = "0x40088E6")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<int, List<BuffData>> lvlBuffData;

		// Token: 0x040088E7 RID: 35047
		[Token(Token = "0x40088E7")]
		[FieldOffset(Offset = "0x50")]
		public string childSkillId;

		// Token: 0x040088E8 RID: 35048
		[Token(Token = "0x40088E8")]
		[FieldOffset(Offset = "0x58")]
		public string preSkillId;

		// Token: 0x040088E9 RID: 35049
		[Token(Token = "0x40088E9")]
		[FieldOffset(Offset = "0x60")]
		public float scale;

		// Token: 0x040088EA RID: 35050
		[Token(Token = "0x40088EA")]
		[FieldOffset(Offset = "0x68")]
		public ElementInfo elementInfo;

		// Token: 0x040088EB RID: 35051
		[Token(Token = "0x40088EB")]
		[FieldOffset(Offset = "0x70")]
		public string actualSkillId;
	}
}
