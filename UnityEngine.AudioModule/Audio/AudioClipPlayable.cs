using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable>
	{
		// Token: 0x06000030 RID: 48 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x591ABC0", Offset = "0x59197C0", VA = "0x18591ABC0")]
		public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping)
		{
			return default(AudioClipPlayable);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x591AAD0", Offset = "0x59196D0", VA = "0x18591AAD0")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping)
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x591B510", Offset = "0x591A110", VA = "0x18591B510")]
		internal AudioClipPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x59110A0", Offset = "0x590FCA0", VA = "0x1859110A0")]
		public static implicit operator Playable(AudioClipPlayable playable)
		{
			return default(Playable);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x591B600", Offset = "0x591A200", VA = "0x18591B600")]
		public static explicit operator AudioClipPlayable(Playable playable)
		{
			return default(AudioClipPlayable);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x591AE30", Offset = "0x5919A30", VA = "0x18591AE30", Slot = "5")]
		public bool Equals(AudioClipPlayable other)
		{
			return default(bool);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x591B430", Offset = "0x591A030", VA = "0x18591B430")]
		internal void SetVolume(float value)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x591B300", Offset = "0x5919F00", VA = "0x18591B300")]
		internal void SetStereoPan(float value)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x591B180", Offset = "0x5919D80", VA = "0x18591B180")]
		internal void SetSpatialBlend(float value)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x591AF20", Offset = "0x5919B20", VA = "0x18591AF20")]
		public void Seek(double startTime, double startDelay, [DefaultValue("0")] double duration)
		{
		}

		// Token: 0x0600003B RID: 59
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x591B3E0", Offset = "0x5919FE0", VA = "0x18591B3E0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetVolumeInternal(ref PlayableHandle hdl, float volume);

		// Token: 0x0600003C RID: 60
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x591B2B0", Offset = "0x5919EB0", VA = "0x18591B2B0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan);

		// Token: 0x0600003D RID: 61
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x591B130", Offset = "0x5919D30", VA = "0x18591B130")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend);

		// Token: 0x0600003E RID: 62
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x591B260", Offset = "0x5919E60", VA = "0x18591B260")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetStartDelayInternal(ref PlayableHandle hdl, double delay);

		// Token: 0x0600003F RID: 63
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x591B0E0", Offset = "0x5919CE0", VA = "0x18591B0E0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern void SetPauseDelayInternal(ref PlayableHandle hdl, double delay);

		// Token: 0x06000040 RID: 64
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x591AEB0", Offset = "0x5919AB0", VA = "0x18591AEB0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle);

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;
	}
}
