using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020002AF RID: 687
	[Token(Token = "0x20002AF")]
	[RequiredByNativeCode]
	[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
	public struct MaterialEffectPlayable : IPlayable, IEquatable<MaterialEffectPlayable>
	{
		// Token: 0x06000F94 RID: 3988 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x5981440", Offset = "0x5980040", VA = "0x185981440", Slot = "5")]
		public bool Equals(MaterialEffectPlayable other)
		{
			return default(bool);
		}

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
