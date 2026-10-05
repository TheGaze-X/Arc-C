using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
	internal struct AnimationPosePlayable : IPlayable, IEquatable<AnimationPosePlayable>
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x5914B60", Offset = "0x5913760", VA = "0x185914B60")]
		internal AnimationPosePlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x5914970", Offset = "0x5913570", VA = "0x185914970", Slot = "5")]
		public bool Equals(AnimationPosePlayable other)
		{
			return default(bool);
		}

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AnimationPosePlayable m_NullPlayable;
	}
}
