using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
	[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable>
	{
		// Token: 0x06000048 RID: 72 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x591BB40", Offset = "0x591A740", VA = "0x18591BB40")]
		public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = false)
		{
			return default(AudioMixerPlayable);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x591BA40", Offset = "0x591A640", VA = "0x18591BA40")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes)
		{
			return default(PlayableHandle);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x591BD90", Offset = "0x591A990", VA = "0x18591BD90")]
		internal AudioMixerPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x59110A0", Offset = "0x590FCA0", VA = "0x1859110A0")]
		public static implicit operator Playable(AudioMixerPlayable playable)
		{
			return default(Playable);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x591BD10", Offset = "0x591A910", VA = "0x18591BD10", Slot = "5")]
		public bool Equals(AudioMixerPlayable other)
		{
			return default(bool);
		}

		// Token: 0x0600004E RID: 78
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x591B9E0", Offset = "0x591A5E0", VA = "0x18591B9E0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle);

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
