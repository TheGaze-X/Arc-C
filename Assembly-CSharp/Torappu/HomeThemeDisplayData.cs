using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FF5 RID: 4085
	[Token(Token = "0x2000FF5")]
	[Serializable]
	public class HomeThemeDisplayData
	{
		// Token: 0x06006D4E RID: 27982 RVA: 0x00031C50 File Offset: 0x0002FE50
		[Token(Token = "0x6006D4E")]
		[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
		public bool ShouldSerializechangeRule()
		{
			return default(bool);
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x00031C68 File Offset: 0x0002FE68
		[Token(Token = "0x6006D4F")]
		[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
		public bool ShouldSerializemultiPicId()
		{
			return default(bool);
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D50")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemeDisplayData()
		{
		}

		// Token: 0x040056A7 RID: 22183
		[Token(Token = "0x40056A7")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040056A8 RID: 22184
		[Token(Token = "0x40056A8")]
		[FieldOffset(Offset = "0x18")]
		public string type;

		// Token: 0x040056A9 RID: 22185
		[Token(Token = "0x40056A9")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x040056AA RID: 22186
		[Token(Token = "0x40056AA")]
		[FieldOffset(Offset = "0x28")]
		public long startTime;

		// Token: 0x040056AB RID: 22187
		[Token(Token = "0x40056AB")]
		[FieldOffset(Offset = "0x30")]
		public bool isSecret;

		// Token: 0x040056AC RID: 22188
		[Token(Token = "0x40056AC")]
		[FieldOffset(Offset = "0x38")]
		public string tmName;

		// Token: 0x040056AD RID: 22189
		[Token(Token = "0x40056AD")]
		[FieldOffset(Offset = "0x40")]
		public string tmDes;

		// Token: 0x040056AE RID: 22190
		[Token(Token = "0x40056AE")]
		[FieldOffset(Offset = "0x48")]
		public string tmUsage;

		// Token: 0x040056AF RID: 22191
		[Token(Token = "0x40056AF")]
		[FieldOffset(Offset = "0x50")]
		public bool isMultiForm;

		// Token: 0x040056B0 RID: 22192
		[Token(Token = "0x40056B0")]
		[FieldOffset(Offset = "0x54")]
		public HomeMultiFormChangeRule changeRule;

		// Token: 0x040056B1 RID: 22193
		[Token(Token = "0x40056B1")]
		[FieldOffset(Offset = "0x58")]
		public List<HomeThemeMultiFormData> multiFormList;

		// Token: 0x040056B2 RID: 22194
		[Token(Token = "0x40056B2")]
		[FieldOffset(Offset = "0x60")]
		public string obtainApproach;

		// Token: 0x040056B3 RID: 22195
		[Token(Token = "0x40056B3")]
		[FieldOffset(Offset = "0x68")]
		public List<string> unlockDesList;

		// Token: 0x040056B4 RID: 22196
		[Token(Token = "0x40056B4")]
		[FieldOffset(Offset = "0x70")]
		public bool isLimitObtain;

		// Token: 0x040056B5 RID: 22197
		[Token(Token = "0x40056B5")]
		[FieldOffset(Offset = "0x71")]
		public bool hideWhenLimit;

		// Token: 0x040056B6 RID: 22198
		[Token(Token = "0x40056B6")]
		[FieldOffset(Offset = "0x74")]
		public ItemRarity rarity;

		// Token: 0x040056B7 RID: 22199
		[Token(Token = "0x40056B7")]
		[FieldOffset(Offset = "0x78")]
		public string multiPicId;
	}
}
