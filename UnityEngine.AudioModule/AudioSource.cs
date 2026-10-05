using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
	[RequireComponent(typeof(Transform))]
	public sealed class AudioSource : AudioBehaviour
	{
		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x591CC90", Offset = "0x591B890", VA = "0x18591CC90")]
		[MethodImpl(4096)]
		private static extern float GetPitch([NotNull("ArgumentNullException")] AudioSource source);

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x591CFC0", Offset = "0x591BBC0", VA = "0x18591CFC0")]
		[MethodImpl(4096)]
		private static extern void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch);

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x591CD40", Offset = "0x591B940", VA = "0x18591CD40")]
		[MethodImpl(4096)]
		private static extern void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay);

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x591CF30", Offset = "0x591BB30", VA = "0x18591CF30")]
		[MethodImpl(4096)]
		private extern void Play(double delay);

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x591CD90", Offset = "0x591B990", VA = "0x18591CD90")]
		[MethodImpl(4096)]
		private static extern void PlayOneShotHelper([NotNull("ArgumentNullException")] AudioSource source, [NotNull("NullExceptionObject")] AudioClip clip, float volumeScale);

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x591D050", Offset = "0x591BC50", VA = "0x18591D050")]
		[MethodImpl(4096)]
		private extern void Stop(bool stopOneShots);

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x0600001D RID: 29
		[Token(Token = "0x17000008")]
		public extern float volume { [Token(Token = "0x600001D")] [Address(RVA = "0x591D3B0", Offset = "0x591BFB0", VA = "0x18591D3B0")] [MethodImpl(4096)] set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002054 File Offset: 0x00000254
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public float pitch
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x591CC90", Offset = "0x591B890", VA = "0x18591CC90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x591CFC0", Offset = "0x591BBC0", VA = "0x18591CFC0")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32
		[Token(Token = "0x1700000A")]
		[NativeProperty("SecPosition")]
		public extern float time { [Token(Token = "0x6000020")] [Address(RVA = "0x591D160", Offset = "0x591BD60", VA = "0x18591D160")] [MethodImpl(4096)] get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000021 RID: 33
		// (set) Token: 0x06000022 RID: 34
		[Token(Token = "0x1700000B")]
		[NativeProperty("SamplePosition")]
		public extern int timeSamples { [Token(Token = "0x6000021")] [Address(RVA = "0x591D120", Offset = "0x591BD20", VA = "0x18591D120")] [NativeMethod(IsThreadSafe = true)] [MethodImpl(4096)] get; [Token(Token = "0x6000022")] [Address(RVA = "0x591D370", Offset = "0x591BF70", VA = "0x18591D370")] [NativeMethod(IsThreadSafe = true)] [MethodImpl(4096)] set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000023 RID: 35
		// (set) Token: 0x06000024 RID: 36
		[Token(Token = "0x1700000C")]
		[NativeProperty("AudioClip")]
		public extern AudioClip clip { [Token(Token = "0x6000023")] [Address(RVA = "0x591D0A0", Offset = "0x591BCA0", VA = "0x18591D0A0")] [MethodImpl(4096)] get; [Token(Token = "0x6000024")] [Address(RVA = "0x591D1A0", Offset = "0x591BDA0", VA = "0x18591D1A0")] [MethodImpl(4096)] set; }

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x06000025 RID: 37
		[Token(Token = "0x1700000D")]
		public extern AudioMixerGroup outputAudioMixerGroup { [Token(Token = "0x6000025")] [Address(RVA = "0x591D240", Offset = "0x591BE40", VA = "0x18591D240")] [MethodImpl(4096)] set; }

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x591CF80", Offset = "0x591BB80", VA = "0x18591CF80")]
		[ExcludeFromDocs]
		public void Play()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x591CCD0", Offset = "0x591B8D0", VA = "0x18591CCD0")]
		public void PlayDelayed(float delay)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x591CED0", Offset = "0x591BAD0", VA = "0x18591CED0")]
		public void PlayScheduled(double time)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x591CDF0", Offset = "0x591B9F0", VA = "0x18591CDF0")]
		public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x591D010", Offset = "0x591BC10", VA = "0x18591D010")]
		public void Stop()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002B RID: 43
		[Token(Token = "0x1700000E")]
		public extern bool isPlaying { [Token(Token = "0x600002B")] [Address(RVA = "0x591D0E0", Offset = "0x591BCE0", VA = "0x18591D0E0")] [NativeName("IsPlayingScripting")] [MethodImpl(4096)] get; }

		// Token: 0x1700000F RID: 15
		// (set) Token: 0x0600002C RID: 44
		[Token(Token = "0x1700000F")]
		public extern bool loop { [Token(Token = "0x600002C")] [Address(RVA = "0x591D1F0", Offset = "0x591BDF0", VA = "0x18591D1F0")] [MethodImpl(4096)] set; }

		// Token: 0x17000010 RID: 16
		// (set) Token: 0x0600002D RID: 45
		[Token(Token = "0x17000010")]
		public extern bool playOnAwake { [Token(Token = "0x600002D")] [Address(RVA = "0x591D290", Offset = "0x591BE90", VA = "0x18591D290")] [MethodImpl(4096)] set; }

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x0600002E RID: 46
		[Token(Token = "0x17000011")]
		[NativeProperty("SpatialBlendMix")]
		public extern float spatialBlend { [Token(Token = "0x600002E")] [Address(RVA = "0x591D320", Offset = "0x591BF20", VA = "0x18591D320")] [MethodImpl(4096)] set; }

		// Token: 0x17000012 RID: 18
		// (set) Token: 0x0600002F RID: 47
		[Token(Token = "0x17000012")]
		public extern AudioRolloffMode rolloffMode { [Token(Token = "0x600002F")] [Address(RVA = "0x591D2E0", Offset = "0x591BEE0", VA = "0x18591D2E0")] [MethodImpl(4096)] set; }
	}
}
