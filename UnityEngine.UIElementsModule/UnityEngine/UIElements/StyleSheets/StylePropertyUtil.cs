using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002E2 RID: 738
	[Token(Token = "0x20002E2")]
	internal static class StylePropertyUtil
	{
		// Token: 0x06001412 RID: 5138 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x6001412")]
		[Address(RVA = "0x5A6EAF0", Offset = "0x5A6D6F0", VA = "0x185A6EAF0")]
		public static bool IsAnimatable(StylePropertyId id)
		{
			return default(bool);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x6001413")]
		[Address(RVA = "0x5A6ECA0", Offset = "0x5A6D8A0", VA = "0x185A6ECA0")]
		public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue)
		{
			return default(bool);
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x6001414")]
		[Address(RVA = "0x5A6EB70", Offset = "0x5A6D770", VA = "0x185A6EB70")]
		public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id)
		{
			return default(bool);
		}

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<StylePropertyId> s_AnimatablePropertiesHash;

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly Dictionary<string, StylePropertyId> s_NameToId;

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly Dictionary<StylePropertyId, string> s_IdToName;

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly StylePropertyId[] s_AnimatableProperties;
	}
}
