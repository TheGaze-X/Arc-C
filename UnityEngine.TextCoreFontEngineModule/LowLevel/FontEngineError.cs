using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public enum FontEngineError
	{
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		Success,
		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		Invalid_File_Path,
		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		Invalid_File_Format,
		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		Invalid_File_Structure,
		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		Invalid_File,
		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		Invalid_Table = 8,
		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		Invalid_Glyph_Index = 16,
		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		Invalid_Character_Code,
		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		Invalid_Pixel_Size = 23,
		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		Invalid_Library = 33,
		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		Invalid_Face = 35,
		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		Invalid_Library_or_Face = 41,
		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		Atlas_Generation_Cancelled = 100,
		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		Invalid_SharedTextureData,
		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		OpenTypeLayoutLookup_Mismatch = 116
	}
}
