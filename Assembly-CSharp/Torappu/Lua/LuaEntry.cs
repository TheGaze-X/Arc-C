using System;
using Il2CppDummyDll;

namespace Torappu.Lua
{
	// Token: 0x020015EF RID: 5615
	[Token(Token = "0x20015EF")]
	internal static class LuaEntry
	{
		// Token: 0x040080E1 RID: 32993
		[Token(Token = "0x40080E1")]
		[FieldOffset(Offset = "0x0")]
		public static Action Init;

		// Token: 0x040080E2 RID: 32994
		[Token(Token = "0x40080E2")]
		[FieldOffset(Offset = "0x8")]
		public static Action Dispose;

		// Token: 0x040080E3 RID: 32995
		[Token(Token = "0x40080E3")]
		[FieldOffset(Offset = "0x10")]
		public static bool driveUpdate;

		// Token: 0x040080E4 RID: 32996
		[Token(Token = "0x40080E4")]
		[FieldOffset(Offset = "0x18")]
		public static Action<float, float> Update;
	}
}
