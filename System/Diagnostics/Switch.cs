using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000100")]
	public abstract class Switch
	{
		// Token: 0x06000657 RID: 1623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x5118FD0", Offset = "0x5117BD0", VA = "0x185118FD0")]
		protected Switch(string displayName, string description)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x5119040", Offset = "0x5117C40", VA = "0x185119040")]
		protected Switch(string displayName, string description, string defaultSwitchValue)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x5119250", Offset = "0x5117E50", VA = "0x185119250")]
		private static void _pruneCachedSwitches()
		{
		}

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x10")]
		private readonly string description;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x18")]
		private readonly string displayName;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x20")]
		private string switchValueString;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x28")]
		private string defaultValue;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x0")]
		private static List<WeakReference> switches;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x8")]
		private static int s_LastCollectionCount;
	}
}
