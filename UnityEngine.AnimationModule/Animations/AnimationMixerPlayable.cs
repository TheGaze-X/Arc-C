using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable>
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x5912990", Offset = "0x5911590", VA = "0x185912990")]
		public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0)
		{
			return default(AnimationMixerPlayable);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x5912840", Offset = "0x5911440", VA = "0x185912840")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0)
		{
			return default(PlayableHandle);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x5912DD0", Offset = "0x59119D0", VA = "0x185912DD0")]
		internal AnimationMixerPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x5912EC0", Offset = "0x5911AC0", VA = "0x185912EC0")]
		public static implicit operator Playable(AnimationMixerPlayable playable)
		{
			return default(Playable);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x5912BE0", Offset = "0x59117E0", VA = "0x185912BE0", Slot = "5")]
		public bool Equals(AnimationMixerPlayable other)
		{
			return default(bool);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x59127C0", Offset = "0x59113C0", VA = "0x1859127C0")]
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return default(bool);
		}

		// Token: 0x06000132 RID: 306
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x5912770", Offset = "0x5911370", VA = "0x185912770")]
		[MethodImpl(4096)]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle);

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AnimationMixerPlayable m_NullPlayable;
	}
}
