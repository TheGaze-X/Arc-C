using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
	public struct AudioPlayableOutput : IPlayableOutput
	{
		// Token: 0x06000053 RID: 83 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x591C2F0", Offset = "0x591AEF0", VA = "0x18591C2F0")]
		public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target)
		{
			return default(AudioPlayableOutput);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x591C640", Offset = "0x591B240", VA = "0x18591C640")]
		internal AudioPlayableOutput(PlayableOutputHandle handle)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x17000014")]
		public static AudioPlayableOutput Null
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x591C730", Offset = "0x591B330", VA = "0x18591C730")]
			get
			{
				return default(AudioPlayableOutput);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x59110A0", Offset = "0x590FCA0", VA = "0x1859110A0")]
		public static implicit operator PlayableOutput(AudioPlayableOutput output)
		{
			return default(PlayableOutput);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x591C860", Offset = "0x591B460", VA = "0x18591C860")]
		public static explicit operator AudioPlayableOutput(PlayableOutput output)
		{
			return default(AudioPlayableOutput);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x591C5F0", Offset = "0x591B1F0", VA = "0x18591C5F0")]
		public void SetTarget(AudioSource value)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x591C5A0", Offset = "0x591B1A0", VA = "0x18591C5A0")]
		public void SetEvaluateOnSeek(bool value)
		{
		}

		// Token: 0x0600005B RID: 91
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x591C5F0", Offset = "0x591B1F0", VA = "0x18591C5F0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target);

		// Token: 0x0600005C RID: 92
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x591C5A0", Offset = "0x591B1A0", VA = "0x18591C5A0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value);

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;
	}
}
