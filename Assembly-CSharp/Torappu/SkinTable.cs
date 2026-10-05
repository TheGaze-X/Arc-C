using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001330 RID: 4912
	[Token(Token = "0x2001330")]
	[Serializable]
	public class SkinTable
	{
		// Token: 0x060072F0 RID: 29424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F0")]
		[Address(RVA = "0x2212350", Offset = "0x2210F50", VA = "0x182212350")]
		public SkinTable()
		{
		}

		// Token: 0x04006CFB RID: 27899
		[Token(Token = "0x4006CFB")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CharSkinData> charSkins;

		// Token: 0x04006CFC RID: 27900
		[Token(Token = "0x4006CFC")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ListDict<int, string>> buildinEvolveMap;

		// Token: 0x04006CFD RID: 27901
		[Token(Token = "0x4006CFD")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ListDict<string, string>> buildinPatchMap;

		// Token: 0x04006CFE RID: 27902
		[Token(Token = "0x4006CFE")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CharSkinBrandInfo> brandList;

		// Token: 0x04006CFF RID: 27903
		[Token(Token = "0x4006CFF")]
		[FieldOffset(Offset = "0x30")]
		public HashSet<SpecialSkinInfo> specialSkinInfoList;

		// Token: 0x04006D00 RID: 27904
		[Token(Token = "0x4006D00")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, SpDynIllustInfo> spDynSkins;

		// Token: 0x04006D01 RID: 27905
		[Token(Token = "0x4006D01")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, string> spDynIllustSkinTagsMap;
	}
}
