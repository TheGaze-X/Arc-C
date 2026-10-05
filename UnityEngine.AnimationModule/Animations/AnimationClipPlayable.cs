using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
	public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable>
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x5910C30", Offset = "0x590F830", VA = "0x185910C30")]
		public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip)
		{
			return default(AnimationClipPlayable);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x5910B50", Offset = "0x590F750", VA = "0x185910B50")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip)
		{
			return default(PlayableHandle);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x5910FB0", Offset = "0x590FBB0", VA = "0x185910FB0")]
		internal AnimationClipPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x59110A0", Offset = "0x590FCA0", VA = "0x1859110A0")]
		public static implicit operator Playable(AnimationClipPlayable playable)
		{
			return default(Playable);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x5910DF0", Offset = "0x590F9F0", VA = "0x185910DF0", Slot = "5")]
		public bool Equals(AnimationClipPlayable other)
		{
			return default(bool);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x5910E70", Offset = "0x590FA70", VA = "0x185910E70")]
		public void SetApplyFootIK(bool value)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x5910F60", Offset = "0x590FB60", VA = "0x185910F60")]
		internal void SetRemoveStartOffset(bool value)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x5910F10", Offset = "0x590FB10", VA = "0x185910F10")]
		internal void SetOverrideLoopTime(bool value)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x5910EC0", Offset = "0x590FAC0", VA = "0x185910EC0")]
		internal void SetLoopTime(bool value)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x5910AF0", Offset = "0x590F6F0", VA = "0x185910AF0")]
		[NativeThrows]
		private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
		{
			return default(bool);
		}

		// Token: 0x06000118 RID: 280
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x5910E70", Offset = "0x590FA70", VA = "0x185910E70")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetApplyFootIKInternal(ref PlayableHandle handle, bool value);

		// Token: 0x06000119 RID: 281
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x5910F60", Offset = "0x590FB60", VA = "0x185910F60")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value);

		// Token: 0x0600011A RID: 282
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x5910F10", Offset = "0x590FB10", VA = "0x185910F10")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value);

		// Token: 0x0600011B RID: 283
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x5910EC0", Offset = "0x590FAC0", VA = "0x185910EC0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetLoopTimeInternal(ref PlayableHandle handle, bool value);

		// Token: 0x0600011C RID: 284
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x5910A90", Offset = "0x590F690", VA = "0x185910A90")]
		[MethodImpl(4096)]
		private static extern bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle);

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
