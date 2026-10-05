using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007C81 RID: 31873
	[Token(Token = "0x2007C81")]
	public static class fiDisplayNameMapper
	{
		// Token: 0x0602C87A RID: 182394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C87A")]
		[Address(RVA = "0x2867720", Offset = "0x2866320", VA = "0x182867720")]
		public static string Map(string propertyName)
		{
			return null;
		}

		// Token: 0x0602C87B RID: 182395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C87B")]
		[Address(RVA = "0x2867510", Offset = "0x2866110", VA = "0x182867510")]
		private static string MapInternal(string propertyName)
		{
			return null;
		}

		// Token: 0x0602C87C RID: 182396 RVA: 0x000E08F8 File Offset: 0x000DEAF8
		[Token(Token = "0x602C87C")]
		[Address(RVA = "0x2867840", Offset = "0x2866440", VA = "0x182867840")]
		private static bool ShouldInsertSpace(int currentIndex, string str)
		{
			return default(bool);
		}

		// Token: 0x0404036A RID: 263018
		[Token(Token = "0x404036A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, string> _mappedNames;
	}
}
