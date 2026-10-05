using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
	internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable>
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x5913160", Offset = "0x5911D60", VA = "0x185913160")]
		public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph)
		{
			return default(AnimationMotionXToDeltaPlayable);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x5913010", Offset = "0x5911C10", VA = "0x185913010")]
		private static PlayableHandle CreateHandle(PlayableGraph graph)
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x5913670", Offset = "0x5912270", VA = "0x185913670")]
		private AnimationMotionXToDeltaPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x5913760", Offset = "0x5912360", VA = "0x185913760")]
		public static implicit operator Playable(AnimationMotionXToDeltaPlayable playable)
		{
			return default(Playable);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x59133B0", Offset = "0x5911FB0", VA = "0x1859133B0", Slot = "5")]
		public bool Equals(AnimationMotionXToDeltaPlayable other)
		{
			return default(bool);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x59134A0", Offset = "0x59120A0", VA = "0x1859134A0")]
		public void SetAbsoluteMotion(bool value)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x5912F90", Offset = "0x5911B90", VA = "0x185912F90")]
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return default(bool);
		}

		// Token: 0x0600013B RID: 315
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x5913450", Offset = "0x5912050", VA = "0x185913450")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value);

		// Token: 0x0600013D RID: 317
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x5912F40", Offset = "0x5911B40", VA = "0x185912F40")]
		[MethodImpl(4096)]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle);

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable;
	}
}
