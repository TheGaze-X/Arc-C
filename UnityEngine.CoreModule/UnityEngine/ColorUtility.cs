using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	[NativeHeader("Runtime/Export/Math/ColorUtility.bindings.h")]
	public class ColorUtility
	{
		// Token: 0x060006E7 RID: 1767
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x5948450", Offset = "0x5947050", VA = "0x185948450")]
		[FreeFunction]
		[MethodImpl(4096)]
		internal static extern bool DoTryParseHtmlColor(string htmlString, out Color32 color);

		// Token: 0x060006E8 RID: 1768 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x5948B10", Offset = "0x5947710", VA = "0x185948B10")]
		public static bool TryParseHtmlString(string htmlString, out Color color)
		{
			return default(bool);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x5948840", Offset = "0x5947440", VA = "0x185948840")]
		public static string ToHtmlStringRGB(Color color)
		{
			return null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x59484A0", Offset = "0x59470A0", VA = "0x1859484A0")]
		public static string ToHtmlStringRGBA(Color color)
		{
			return null;
		}
	}
}
