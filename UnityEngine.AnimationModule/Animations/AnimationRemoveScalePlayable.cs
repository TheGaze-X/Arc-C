using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType.DoubleColon)]
	internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable>
	{
		// Token: 0x06000158 RID: 344 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x5914E70", Offset = "0x5913A70", VA = "0x185914E70")]
		public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount)
		{
			return default(AnimationRemoveScalePlayable);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x5914D20", Offset = "0x5913920", VA = "0x185914D20")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount)
		{
			return default(PlayableHandle);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x59152B0", Offset = "0x5913EB0", VA = "0x1859152B0")]
		internal AnimationRemoveScalePlayable(PlayableHandle handle)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x59153A0", Offset = "0x5913FA0", VA = "0x1859153A0")]
		public static implicit operator Playable(AnimationRemoveScalePlayable playable)
		{
			return default(Playable);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x59150C0", Offset = "0x5913CC0", VA = "0x1859150C0", Slot = "5")]
		public bool Equals(AnimationRemoveScalePlayable other)
		{
			return default(bool);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x5914CA0", Offset = "0x59138A0", VA = "0x185914CA0")]
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return default(bool);
		}

		// Token: 0x06000160 RID: 352
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x5914C50", Offset = "0x5913850", VA = "0x185914C50")]
		[MethodImpl(4096)]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle);

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AnimationRemoveScalePlayable m_NullPlayable;
	}
}
