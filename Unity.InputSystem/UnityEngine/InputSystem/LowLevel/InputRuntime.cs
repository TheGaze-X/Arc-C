using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	internal static class InputRuntime
	{
		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		[FieldOffset(Offset = "0x0")]
		public static IInputRuntime s_Instance;

		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		[FieldOffset(Offset = "0x8")]
		public static double s_CurrentTimeOffsetToRealtimeSinceStartup;
	}
}
