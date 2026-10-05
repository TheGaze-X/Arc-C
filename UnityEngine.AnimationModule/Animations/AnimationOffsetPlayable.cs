using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable>
	{
		// Token: 0x0600013E RID: 318 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x5913A80", Offset = "0x5912680", VA = "0x185913A80")]
		public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			return default(AnimationOffsetPlayable);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x59138F0", Offset = "0x59124F0", VA = "0x1859138F0")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x5913F00", Offset = "0x5912B00", VA = "0x185913F00")]
		internal AnimationOffsetPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x5913FF0", Offset = "0x5912BF0", VA = "0x185913FF0")]
		public static implicit operator Playable(AnimationOffsetPlayable playable)
		{
			return default(Playable);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x5913D10", Offset = "0x5912910", VA = "0x185913D10", Slot = "5")]
		public bool Equals(AnimationOffsetPlayable other)
		{
			return default(bool);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x5913850", Offset = "0x5912450", VA = "0x185913850")]
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle)
		{
			return default(bool);
		}

		// Token: 0x06000146 RID: 326
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x59137E0", Offset = "0x59123E0", VA = "0x1859137E0")]
		[MethodImpl(4096)]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle);

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AnimationOffsetPlayable m_NullPlayable;
	}
}
