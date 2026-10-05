using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[Preserve]
	internal struct JsonPosition
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x4D66760", Offset = "0x4D65360", VA = "0x184D66760")]
		public JsonPosition(JsonContainerType type)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x4D66290", Offset = "0x4D64E90", VA = "0x184D66290")]
		internal int CalculateLength()
		{
			return 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x4D66570", Offset = "0x4D65170", VA = "0x184D66570")]
		internal void WriteTo(StringBuilder sb)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4D66560", Offset = "0x4D65160", VA = "0x184D66560")]
		internal static bool TypeHasIndex(JsonContainerType type)
		{
			return default(bool);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4D65E90", Offset = "0x4D64A90", VA = "0x184D65E90")]
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4D66330", Offset = "0x4D64F30", VA = "0x184D66330")]
		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message)
		{
			return null;
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] SpecialCharacters;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		internal JsonContainerType Type;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x4")]
		internal int Position;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x8")]
		internal string PropertyName;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x10")]
		internal bool HasIndex;
	}
}
