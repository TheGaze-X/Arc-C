using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public static class FontUpdateTracker
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5A128B0", Offset = "0x5A114B0", VA = "0x185A128B0")]
		public static void TrackText(Text t)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5A12740", Offset = "0x5A11340", VA = "0x185A12740")]
		private static void RebuildForFont(Font f)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x5A12B10", Offset = "0x5A11710", VA = "0x185A12B10")]
		public static void UntrackText(Text t)
		{
		}

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Font, HashSet<Text>> m_Tracked;
	}
}
