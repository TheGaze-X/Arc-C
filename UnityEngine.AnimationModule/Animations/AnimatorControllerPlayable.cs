using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
	[RequiredByNativeCode]
	public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable>
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x5916FF0", Offset = "0x5915BF0", VA = "0x185916FF0")]
		internal AnimatorControllerPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x5916D90", Offset = "0x5915990", VA = "0x185916D90")]
		public void SetHandle(PlayableHandle handle)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x5916CF0", Offset = "0x59158F0", VA = "0x185916CF0", Slot = "5")]
		public bool Equals(AnimatorControllerPlayable other)
		{
			return default(bool);
		}

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AnimatorControllerPlayable m_NullPlayable;
	}
}
