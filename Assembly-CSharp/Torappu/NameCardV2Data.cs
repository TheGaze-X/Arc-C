using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001003 RID: 4099
	[Token(Token = "0x2001003")]
	public class NameCardV2Data
	{
		// Token: 0x06006D5B RID: 27995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D5B")]
		[Address(RVA = "0x21085F0", Offset = "0x21071F0", VA = "0x1821085F0")]
		public NameCardV2Data()
		{
		}

		// Token: 0x040056F9 RID: 22265
		[Token(Token = "0x40056F9")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, NameCardV2ModuleData> fixedModuleData;

		// Token: 0x040056FA RID: 22266
		[Token(Token = "0x40056FA")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, NameCardV2RemovableModuleData> removableModuleData;

		// Token: 0x040056FB RID: 22267
		[Token(Token = "0x40056FB")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, NameCardV2SkinData> skinData;

		// Token: 0x040056FC RID: 22268
		[Token(Token = "0x40056FC")]
		[FieldOffset(Offset = "0x28")]
		public List<ArtGalleryGroupData> skinGroupDatas;

		// Token: 0x040056FD RID: 22269
		[Token(Token = "0x40056FD")]
		[FieldOffset(Offset = "0x30")]
		public NameCardV2Consts consts;
	}
}
