using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	public static class PointerType
	{
		// Token: 0x06000C80 RID: 3200 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x5AEB420", Offset = "0x5AEA020", VA = "0x185AEB420")]
		internal static string GetPointerType(int pointerId)
		{
			return null;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x5AEB4E0", Offset = "0x5AEA0E0", VA = "0x185AEB4E0")]
		internal static bool IsDirectManipulationDevice(string pointerType)
		{
			return default(bool);
		}

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string mouse;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string touch;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string pen;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string unknown;
	}
}
