using System;
using System.IO;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B76 RID: 31606
	[Token(Token = "0x2007B76")]
	public static class fsJsonPrinter
	{
		// Token: 0x0602C3C9 RID: 181193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3C9")]
		[Address(RVA = "0x282F1E0", Offset = "0x282DDE0", VA = "0x18282F1E0")]
		private static void InsertSpacing(TextWriter stream, int count)
		{
		}

		// Token: 0x0602C3CA RID: 181194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C3CA")]
		[Address(RVA = "0x282EE30", Offset = "0x282DA30", VA = "0x18282EE30")]
		private static string EscapeString(string str)
		{
			return null;
		}

		// Token: 0x0602C3CB RID: 181195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3CB")]
		[Address(RVA = "0x282DED0", Offset = "0x282CAD0", VA = "0x18282DED0")]
		private static void BuildCompressedString(fsData data, TextWriter stream)
		{
		}

		// Token: 0x0602C3CC RID: 181196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3CC")]
		[Address(RVA = "0x282E3C0", Offset = "0x282CFC0", VA = "0x18282E3C0")]
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth)
		{
		}

		// Token: 0x0602C3CD RID: 181197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3CD")]
		[Address(RVA = "0x282F3E0", Offset = "0x282DFE0", VA = "0x18282F3E0")]
		public static void PrettyJson(fsData data, TextWriter outputStream)
		{
		}

		// Token: 0x0602C3CE RID: 181198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C3CE")]
		[Address(RVA = "0x282F280", Offset = "0x282DE80", VA = "0x18282F280")]
		public static string PrettyJson(fsData data)
		{
			return null;
		}

		// Token: 0x0602C3CF RID: 181199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3CF")]
		[Address(RVA = "0x282EC70", Offset = "0x282D870", VA = "0x18282EC70")]
		public static void CompressedJson(fsData data, StreamWriter outputStream)
		{
		}

		// Token: 0x0602C3D0 RID: 181200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C3D0")]
		[Address(RVA = "0x282EB20", Offset = "0x282D720", VA = "0x18282EB20")]
		public static string CompressedJson(fsData data)
		{
			return null;
		}

		// Token: 0x0602C3D1 RID: 181201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C3D1")]
		[Address(RVA = "0x282EC80", Offset = "0x282D880", VA = "0x18282EC80")]
		private static string ConvertDoubleToString(double d)
		{
			return null;
		}
	}
}
