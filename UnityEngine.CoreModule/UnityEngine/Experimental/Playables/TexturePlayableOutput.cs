using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
	public struct TexturePlayableOutput : IPlayableOutput
	{
		// Token: 0x06000F98 RID: 3992 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;
	}
}
