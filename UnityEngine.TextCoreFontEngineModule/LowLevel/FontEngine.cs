using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
	public sealed class FontEngine
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x59CFBA0", Offset = "0x59CE7A0", VA = "0x1859CFBA0")]
		public static FontEngineError InitializeFontEngine()
		{
			return FontEngineError.Success;
		}

		// Token: 0x06000048 RID: 72
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x59CFB70", Offset = "0x59CE770", VA = "0x1859CFB70")]
		[NativeMethod(Name = "TextCore::FontEngine::InitFontEngine", IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern int InitializeFontEngine_Internal();

		// Token: 0x06000049 RID: 73 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x59CFE50", Offset = "0x59CEA50", VA = "0x1859CFE50")]
		public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex)
		{
			return FontEngineError.Success;
		}

		// Token: 0x0600004A RID: 74
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x59CFC00", Offset = "0x59CE800", VA = "0x1859CFC00")]
		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex);

		// Token: 0x0600004B RID: 75 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x59CFDD0", Offset = "0x59CE9D0", VA = "0x1859CFDD0")]
		public static FontEngineError LoadFontFace(Font font, int pointSize)
		{
			return FontEngineError.Success;
		}

		// Token: 0x0600004C RID: 76
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x59CFC50", Offset = "0x59CE850", VA = "0x1859CFC50")]
		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize);

		// Token: 0x0600004D RID: 77 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x59CFD40", Offset = "0x59CE940", VA = "0x1859CFD40")]
		public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex)
		{
			return FontEngineError.Success;
		}

		// Token: 0x0600004E RID: 78
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x59CFC90", Offset = "0x59CE890", VA = "0x1859CFC90")]
		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex);

		// Token: 0x0600004F RID: 79 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x59CFEE0", Offset = "0x59CEAE0", VA = "0x1859CFEE0")]
		public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize)
		{
			return FontEngineError.Success;
		}

		// Token: 0x06000050 RID: 80
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x59CFCE0", Offset = "0x59CE8E0", VA = "0x1859CFCE0")]
		[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize);

		// Token: 0x06000051 RID: 81 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x59D13A0", Offset = "0x59CFFA0", VA = "0x1859D13A0")]
		internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef)
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x59D1340", Offset = "0x59CFF40", VA = "0x1859D1340")]
		[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = true, IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef);

		// Token: 0x06000053 RID: 83 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x59CF710", Offset = "0x59CE310", VA = "0x1859CF710")]
		public static FaceInfo GetFaceInfo()
		{
			return default(FaceInfo);
		}

		// Token: 0x06000054 RID: 84
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x59CF6D0", Offset = "0x59CE2D0", VA = "0x1859CF6D0")]
		[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = true, IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern int GetFaceInfo_Internal(ref FaceInfo faceInfo);

		// Token: 0x06000055 RID: 85
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x59CF7F0", Offset = "0x59CE3F0", VA = "0x1859CF7F0")]
		[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = true, IsFreeFunction = true)]
		[MethodImpl(4096)]
		internal static extern uint GetGlyphIndex(uint unicode);

		// Token: 0x06000056 RID: 86 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x59D11F0", Offset = "0x59CFDF0", VA = "0x1859D11F0")]
		public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph)
		{
			return default(bool);
		}

		// Token: 0x06000057 RID: 87
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x59D11A0", Offset = "0x59CFDA0", VA = "0x1859D11A0")]
		[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = true, IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct);

		// Token: 0x06000058 RID: 88 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x59D1050", Offset = "0x59CFC50", VA = "0x1859D1050")]
		public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph)
		{
			return default(bool);
		}

		// Token: 0x06000059 RID: 89
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x59D1000", Offset = "0x59CFC00", VA = "0x1859D1000")]
		[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = true, IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct);

		// Token: 0x0600005A RID: 90
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x59D0000", Offset = "0x59CEC00", VA = "0x1859D0000")]
		[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = true, IsFreeFunction = true)]
		[MethodImpl(4096)]
		internal static extern void SetTextureUploadMode(bool shouldUploadImmediately);

		// Token: 0x0600005B RID: 91 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x59D00A0", Offset = "0x59CECA0", VA = "0x1859D00A0")]
		internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph)
		{
			return default(bool);
		}

		// Token: 0x0600005C RID: 92
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x59D0040", Offset = "0x59CEC40", VA = "0x1859D0040")]
		[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph);

		// Token: 0x0600005D RID: 93 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x59D0650", Offset = "0x59CF250", VA = "0x1859D0650")]
		internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs)
		{
			return default(bool);
		}

		// Token: 0x0600005E RID: 94
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x59D05E0", Offset = "0x59CF1E0", VA = "0x1859D05E0")]
		[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = true, IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount);

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x59CF9D0", Offset = "0x59CE5D0", VA = "0x1859CF9D0")]
		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes)
		{
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x59CF830", Offset = "0x59CE430", VA = "0x1859CF830")]
		internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount)
		{
			return null;
		}

		// Token: 0x06000061 RID: 97
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x59CFF70", Offset = "0x59CEB70", VA = "0x1859CFF70")]
		[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount);

		// Token: 0x06000062 RID: 98
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x59CFB30", Offset = "0x59CE730", VA = "0x1859CFB30")]
		[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern int GetPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords);

		// Token: 0x06000063 RID: 99 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x6000063")]
		private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref T[] dstArray)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002069 File Offset: 0x00000269
		[Token(Token = "0x6000064")]
		private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount)
		{
		}

		// Token: 0x06000065 RID: 101
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x59CFFC0", Offset = "0x59CEBC0", VA = "0x1859CFFC0")]
		[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = true)]
		[MethodImpl(4096)]
		internal static extern void ResetAtlasTexture(Texture2D texture);

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Glyph[] s_Glyphs;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static uint[] s_GlyphIndexes_MarshallingArray_A;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static GlyphRect[] s_FreeGlyphRects;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GlyphRect[] s_UsedGlyphRects;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Dictionary<uint, Glyph> s_GlyphLookupDictionary;
	}
}
