using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
	[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable>
	{
		// Token: 0x0600011D RID: 285 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x5911E20", Offset = "0x5910A20", VA = "0x185911E20")]
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0)
		{
			return default(AnimationLayerMixerPlayable);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x5912000", Offset = "0x5910C00", VA = "0x185912000")]
		public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization)
		{
			return default(AnimationLayerMixerPlayable);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x5911CD0", Offset = "0x59108D0", VA = "0x185911CD0")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0)
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x59125B0", Offset = "0x59111B0", VA = "0x1859125B0")]
		internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x59126F0", Offset = "0x59112F0", VA = "0x1859126F0")]
		public static implicit operator Playable(AnimationLayerMixerPlayable playable)
		{
			return default(Playable);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x59121C0", Offset = "0x5910DC0", VA = "0x1859121C0", Slot = "5")]
		public bool Equals(AnimationLayerMixerPlayable other)
		{
			return default(bool);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x59122B0", Offset = "0x5910EB0", VA = "0x1859122B0")]
		public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x5911C50", Offset = "0x5910850", VA = "0x185911C50")]
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return default(bool);
		}

		// Token: 0x06000126 RID: 294
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x59124D0", Offset = "0x59110D0", VA = "0x1859124D0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value);

		// Token: 0x06000127 RID: 295
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x5912260", Offset = "0x5910E60", VA = "0x185912260")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask);

		// Token: 0x06000129 RID: 297
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x5911C00", Offset = "0x5910800", VA = "0x185911C00")]
		[MethodImpl(4096)]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle);

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AnimationLayerMixerPlayable m_NullPlayable;
	}
}
