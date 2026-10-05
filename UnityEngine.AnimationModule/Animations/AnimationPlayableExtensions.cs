using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
	[NativeHeader("Modules/Animation/AnimationClip.h")]
	public static class AnimationPlayableExtensions
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		public static void SetAnimatedProperties<U>(this U playable, AnimationClip clip) where U : struct, IPlayable
		{
		}

		// Token: 0x06000148 RID: 328
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x5914220", Offset = "0x5912E20", VA = "0x185914220")]
		[NativeThrows]
		[MethodImpl(4096)]
		internal static extern void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties);
	}
}
