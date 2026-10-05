using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable>
	{
		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x5915610", Offset = "0x5914210", VA = "0x185915610")]
		internal AnimationScriptPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x5915420", Offset = "0x5914020", VA = "0x185915420", Slot = "5")]
		public bool Equals(AnimationScriptPlayable other)
		{
			return default(bool);
		}

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AnimationScriptPlayable m_NullPlayable;
	}
}
