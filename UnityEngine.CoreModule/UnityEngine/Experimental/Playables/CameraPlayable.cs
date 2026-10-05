using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("CameraPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
	public struct CameraPlayable : IPlayable, IEquatable<CameraPlayable>
	{
		// Token: 0x06000F92 RID: 3986 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x597AAC0", Offset = "0x59796C0", VA = "0x18597AAC0", Slot = "5")]
		public bool Equals(CameraPlayable other)
		{
			return default(bool);
		}

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
