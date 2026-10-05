using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
	[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct TextureMixerPlayable : IPlayable, IEquatable<TextureMixerPlayable>
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x5988D20", Offset = "0x5987920", VA = "0x185988D20", Slot = "5")]
		public bool Equals(TextureMixerPlayable other)
		{
			return default(bool);
		}

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
