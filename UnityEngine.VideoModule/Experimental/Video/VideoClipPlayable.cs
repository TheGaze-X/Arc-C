using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Video
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("VideoClipPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Video/Public/VideoClip.h")]
	[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
	[RequiredByNativeCode]
	public struct VideoClipPlayable : IPlayable, IEquatable<VideoClipPlayable>
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5BA1900", Offset = "0x5BA0500", VA = "0x185BA1900", Slot = "5")]
		public bool Equals(VideoClipPlayable other)
		{
			return default(bool);
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
