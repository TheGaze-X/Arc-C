using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[StaticAccessor("UI::SystemProfilerApi", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/UI/Canvas.h")]
	public static class UISystemProfilerApi
	{
		// Token: 0x06000072 RID: 114
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x5B54AA0", Offset = "0x5B536A0", VA = "0x185B54AA0")]
		[MethodImpl(4096)]
		public static extern void BeginSample(UISystemProfilerApi.SampleType type);

		// Token: 0x06000073 RID: 115
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x5B54AE0", Offset = "0x5B536E0", VA = "0x185B54AE0")]
		[MethodImpl(4096)]
		public static extern void EndSample(UISystemProfilerApi.SampleType type);

		// Token: 0x06000074 RID: 116
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x5B54A50", Offset = "0x5B53650", VA = "0x185B54A50")]
		[MethodImpl(4096)]
		public static extern void AddMarker(string name, Object obj);

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		public enum SampleType
		{
			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			Layout,
			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			Render
		}
	}
}
