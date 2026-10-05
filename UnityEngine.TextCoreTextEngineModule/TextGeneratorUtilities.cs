using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	internal static class TextGeneratorUtilities
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x59FA3E0", Offset = "0x59F8FE0", VA = "0x1859FA3E0")]
		public static bool Approximately(float a, float b)
		{
			return default(bool);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x59FBD10", Offset = "0x59FA910", VA = "0x1859FBD10")]
		public static Color32 HexCharsToColor(char[] hexChars, int tagCount)
		{
			return default(Color32);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x59FC380", Offset = "0x59FAF80", VA = "0x1859FC380")]
		public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
		{
			return default(Color32);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x59FC630", Offset = "0x59FB230", VA = "0x1859FC630")]
		public static int HexToInt(char hex)
		{
			return 0;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x59FA5B0", Offset = "0x59F91B0", VA = "0x1859FA5B0")]
		public static float ConvertToFloat(char[] chars, int startIndex, int length)
		{
			return 0f;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x59FA410", Offset = "0x59F9010", VA = "0x1859FA410")]
		public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex)
		{
			return 0f;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x59FC950", Offset = "0x59FB550", VA = "0x1859FC950")]
		public static Vector2 PackUV(float x, float y, float scale)
		{
			return default(Vector2);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x59FD9E0", Offset = "0x59FC5E0", VA = "0x1859FD9E0")]
		public static void StringToCharArray(string sourceText, ref int[] charBuffer, ref TextProcessingStack<int> styleStack, TextGenerationSettings generationSettings)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		private static void ResizeInternalArray<T>(ref T[] array)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x59FC740", Offset = "0x59FB340", VA = "0x1859FC740")]
		private static bool IsTagName(ref string text, string tag, int index)
		{
			return default(bool);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x59FC7F0", Offset = "0x59FB3F0", VA = "0x1859FC7F0")]
		private static bool IsTagName(ref int[] text, string tag, int index)
		{
			return default(bool);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x59FCDD0", Offset = "0x59FB9D0", VA = "0x1859FCDD0")]
		private static bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings)
		{
			return default(bool);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x59FD300", Offset = "0x59FBF00", VA = "0x1859FD300")]
		private static bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings)
		{
			return default(bool);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x59FC990", Offset = "0x59FB590", VA = "0x1859FC990")]
		private static void ReplaceClosingStyleTag(ref int[] charBuffer, ref int writeIndex, ref TextProcessingStack<int> styleStack, ref TextGenerationSettings generationSettings)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x59FB870", Offset = "0x59FA470", VA = "0x1859FB870")]
		private static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode)
		{
			return null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x59FBBB0", Offset = "0x59FA7B0", VA = "0x1859FBBB0")]
		private static int GetUtf32(string text, int i)
		{
			return 0;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x59FBAC0", Offset = "0x59FA6C0", VA = "0x1859FBAC0")]
		private static int GetUtf16(string text, int i)
		{
			return 0;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x59FBA20", Offset = "0x59FA620", VA = "0x1859FBA20")]
		private static int GetTagHashCode(ref int[] text, int index, out int closeIndex)
		{
			return 0;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x59FB960", Offset = "0x59FA560", VA = "0x1859FB960")]
		private static int GetTagHashCode(ref string text, int index, out int closeIndex)
		{
			return 0;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x59FA630", Offset = "0x59F9230", VA = "0x1859FA630")]
		public static void FillCharacterVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x59FAFB0", Offset = "0x59F9BB0", VA = "0x1859FAFB0")]
		public static void FillSpriteVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x59F9FE0", Offset = "0x59F8BE0", VA = "0x1859F9FE0")]
		public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x59FD7F0", Offset = "0x59FC3F0", VA = "0x1859FD7F0")]
		public static void ResizeLineExtents(int size, TextInfo textInfo)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x59FC920", Offset = "0x59FB520", VA = "0x1859FC920")]
		public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle)
		{
			return FontStyles.Normal;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x59FC8A0", Offset = "0x59FB4A0", VA = "0x1859FC8A0")]
		public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor)
		{
			return (TextAlignment)0;
		}

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector2 largePositiveVector2;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Vector2 largeNegativeVector2;
	}
}
