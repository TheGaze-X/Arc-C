using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
	[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	public struct AnimationPlayableOutput : IPlayableOutput
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x59142D0", Offset = "0x5912ED0", VA = "0x1859142D0")]
		public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target)
		{
			return default(AnimationPlayableOutput);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x5914610", Offset = "0x5913210", VA = "0x185914610")]
		internal AnimationPlayableOutput(PlayableOutputHandle handle)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x17000048")]
		public static AnimationPlayableOutput Null
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x5914700", Offset = "0x5913300", VA = "0x185914700")]
			get
			{
				return default(AnimationPlayableOutput);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x59110A0", Offset = "0x590FCA0", VA = "0x1859110A0")]
		public static implicit operator PlayableOutput(AnimationPlayableOutput output)
		{
			return default(PlayableOutput);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x5914830", Offset = "0x5913430", VA = "0x185914830")]
		public static explicit operator AnimationPlayableOutput(PlayableOutput output)
		{
			return default(AnimationPlayableOutput);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x5914580", Offset = "0x5913180", VA = "0x185914580")]
		public Animator GetTarget()
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x59145C0", Offset = "0x59131C0", VA = "0x1859145C0")]
		public void SetTarget(Animator value)
		{
		}

		// Token: 0x06000152 RID: 338
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x5914580", Offset = "0x5913180", VA = "0x185914580")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern Animator InternalGetTarget(ref PlayableOutputHandle handle);

		// Token: 0x06000153 RID: 339
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x59145C0", Offset = "0x59131C0", VA = "0x1859145C0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void InternalSetTarget(ref PlayableOutputHandle handle, Animator target);

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;
	}
}
