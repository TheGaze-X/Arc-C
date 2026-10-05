using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001098 RID: 4248
	[Token(Token = "0x2001098")]
	[Serializable]
	public class HandBookStoryViewData
	{
		// Token: 0x06006E22 RID: 28194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E22")]
		[Address(RVA = "0x2105750", Offset = "0x2104350", VA = "0x182105750")]
		public HandBookStoryViewData()
		{
		}

		// Token: 0x04005AA5 RID: 23205
		[Token(Token = "0x4005AA5")]
		[FieldOffset(Offset = "0x10")]
		public List<HandBookStoryViewData.StoryText> stories;

		// Token: 0x04005AA6 RID: 23206
		[Token(Token = "0x4005AA6")]
		[FieldOffset(Offset = "0x18")]
		public string storyTitle;

		// Token: 0x04005AA7 RID: 23207
		[Token(Token = "0x4005AA7")]
		[FieldOffset(Offset = "0x20")]
		public bool unLockorNot;

		// Token: 0x02001099 RID: 4249
		[Token(Token = "0x2001099")]
		[Serializable]
		public class StoryText
		{
			// Token: 0x06006E23 RID: 28195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E23")]
			[Address(RVA = "0x21164E0", Offset = "0x21150E0", VA = "0x1821164E0")]
			public StoryText()
			{
			}

			// Token: 0x06006E24 RID: 28196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E24")]
			[Address(RVA = "0x2116550", Offset = "0x2115150", VA = "0x182116550")]
			public StoryText(string text, DataUnlockType unLockType, string unLockParam, string unLockString, List<string> patchIdList)
			{
			}

			// Token: 0x04005AA8 RID: 23208
			[Token(Token = "0x4005AA8")]
			[FieldOffset(Offset = "0x10")]
			public string storyText;

			// Token: 0x04005AA9 RID: 23209
			[Token(Token = "0x4005AA9")]
			[FieldOffset(Offset = "0x18")]
			public DataUnlockType unLockType;

			// Token: 0x04005AAA RID: 23210
			[Token(Token = "0x4005AAA")]
			[FieldOffset(Offset = "0x20")]
			public string unLockParam;

			// Token: 0x04005AAB RID: 23211
			[Token(Token = "0x4005AAB")]
			[FieldOffset(Offset = "0x28")]
			public DataUnlockType showType;

			// Token: 0x04005AAC RID: 23212
			[Token(Token = "0x4005AAC")]
			[FieldOffset(Offset = "0x30")]
			public string showParam;

			// Token: 0x04005AAD RID: 23213
			[Token(Token = "0x4005AAD")]
			[FieldOffset(Offset = "0x38")]
			public string unLockString;

			// Token: 0x04005AAE RID: 23214
			[Token(Token = "0x4005AAE")]
			[FieldOffset(Offset = "0x40")]
			public List<string> patchIdList;
		}
	}
}
