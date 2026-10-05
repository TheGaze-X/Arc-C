using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	// Token: 0x020001A5 RID: 421
	[Token(Token = "0x20001A5")]
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
	[RequiredByNativeCode]
	internal struct PlayerLoopSystemInternal
	{
		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x0")]
		public Type type;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x8")]
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x10")]
		public IntPtr updateFunction;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x18")]
		public IntPtr loopConditionFunction;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x20")]
		public int numSubSystems;
	}
}
