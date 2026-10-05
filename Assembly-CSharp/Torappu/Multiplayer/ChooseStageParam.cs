using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x02001541 RID: 5441
	[Token(Token = "0x2001541")]
	public class ChooseStageParam
	{
		// Token: 0x06007CA9 RID: 31913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChooseStageParam()
		{
		}

		// Token: 0x04007D07 RID: 32007
		[Token(Token = "0x4007D07")]
		[FieldOffset(Offset = "0x10")]
		public int isStageRandom;

		// Token: 0x04007D08 RID: 32008
		[Token(Token = "0x4007D08")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;
	}
}
