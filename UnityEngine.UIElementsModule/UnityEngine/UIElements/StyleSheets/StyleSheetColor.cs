using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002F5 RID: 757
	[Token(Token = "0x20002F5")]
	internal static class StyleSheetColor
	{
		// Token: 0x060014C1 RID: 5313 RVA: 0x0000B160 File Offset: 0x00009360
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x5A85310", Offset = "0x5A83F10", VA = "0x185A85310")]
		public static bool TryGetColor(string name, out Color color)
		{
			return default(bool);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0000B178 File Offset: 0x00009378
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x5A852F0", Offset = "0x5A83EF0", VA = "0x185A852F0")]
		private static Color32 HexToColor32(uint color)
		{
			return default(Color32);
		}

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Color32> s_NameToColor;
	}
}
