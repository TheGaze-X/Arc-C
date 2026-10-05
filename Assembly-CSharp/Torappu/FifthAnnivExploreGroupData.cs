using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200104B RID: 4171
	[Token(Token = "0x200104B")]
	public class FifthAnnivExploreGroupData
	{
		// Token: 0x06006DB3 RID: 28083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB3")]
		[Address(RVA = "0x2104810", Offset = "0x2103410", VA = "0x182104810")]
		public FifthAnnivExploreGroupData()
		{
		}

		// Token: 0x04005897 RID: 22679
		[Token(Token = "0x4005897")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005898 RID: 22680
		[Token(Token = "0x4005898")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04005899 RID: 22681
		[Token(Token = "0x4005899")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x0400589A RID: 22682
		[Token(Token = "0x400589A")]
		[FieldOffset(Offset = "0x28")]
		public string code;

		// Token: 0x0400589B RID: 22683
		[Token(Token = "0x400589B")]
		[FieldOffset(Offset = "0x30")]
		public string iconId;

		// Token: 0x0400589C RID: 22684
		[Token(Token = "0x400589C")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, int> initialValues;

		// Token: 0x0400589D RID: 22685
		[Token(Token = "0x400589D")]
		[FieldOffset(Offset = "0x40")]
		public FifthAnnivExploreValueType heritageValueType;
	}
}
