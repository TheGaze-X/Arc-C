using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FF0 RID: 4080
	[Token(Token = "0x2000FF0")]
	public class HomeBackgroundSingleData
	{
		// Token: 0x06006D47 RID: 27975 RVA: 0x00031C20 File Offset: 0x0002FE20
		[Token(Token = "0x6006D47")]
		[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
		public bool ShouldSerializechangeRule()
		{
			return default(bool);
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x00031C38 File Offset: 0x0002FE38
		[Token(Token = "0x6006D48")]
		[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
		public bool ShouldSerializemultiPicId()
		{
			return default(bool);
		}

		// Token: 0x06006D49 RID: 27977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D49")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeBackgroundSingleData()
		{
		}

		// Token: 0x04005683 RID: 22147
		[Token(Token = "0x4005683")]
		[FieldOffset(Offset = "0x10")]
		public string bgId;

		// Token: 0x04005684 RID: 22148
		[Token(Token = "0x4005684")]
		[FieldOffset(Offset = "0x18")]
		public string bgType;

		// Token: 0x04005685 RID: 22149
		[Token(Token = "0x4005685")]
		[FieldOffset(Offset = "0x20")]
		public int bgSortId;

		// Token: 0x04005686 RID: 22150
		[Token(Token = "0x4005686")]
		[FieldOffset(Offset = "0x28")]
		public long bgStartTime;

		// Token: 0x04005687 RID: 22151
		[Token(Token = "0x4005687")]
		[FieldOffset(Offset = "0x30")]
		public bool isSecret;

		// Token: 0x04005688 RID: 22152
		[Token(Token = "0x4005688")]
		[FieldOffset(Offset = "0x38")]
		public string bgName;

		// Token: 0x04005689 RID: 22153
		[Token(Token = "0x4005689")]
		[FieldOffset(Offset = "0x40")]
		public string bgDes;

		// Token: 0x0400568A RID: 22154
		[Token(Token = "0x400568A")]
		[FieldOffset(Offset = "0x48")]
		public string bgUsage;

		// Token: 0x0400568B RID: 22155
		[Token(Token = "0x400568B")]
		[FieldOffset(Offset = "0x50")]
		public bool isMultiForm;

		// Token: 0x0400568C RID: 22156
		[Token(Token = "0x400568C")]
		[FieldOffset(Offset = "0x54")]
		public HomeMultiFormChangeRule changeRule;

		// Token: 0x0400568D RID: 22157
		[Token(Token = "0x400568D")]
		[FieldOffset(Offset = "0x58")]
		public List<HomeBackgroundMultiFormData> multiFormList;

		// Token: 0x0400568E RID: 22158
		[Token(Token = "0x400568E")]
		[FieldOffset(Offset = "0x60")]
		public string obtainApproach;

		// Token: 0x0400568F RID: 22159
		[Token(Token = "0x400568F")]
		[FieldOffset(Offset = "0x68")]
		public List<string> unlockDesList;

		// Token: 0x04005690 RID: 22160
		[Token(Token = "0x4005690")]
		[FieldOffset(Offset = "0x70")]
		public string multiPicId;
	}
}
