using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Audio
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[ExcludeFromPreset]
	[ExcludeFromObjectFactory]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
	[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
	public class AudioMixer : Object
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000041 RID: 65
		[Token(Token = "0x17000013")]
		[NativeProperty]
		public extern AudioMixerGroup outputAudioMixerGroup { [Token(Token = "0x6000041")] [Address(RVA = "0x591C0A0", Offset = "0x591ACA0", VA = "0x18591C0A0")] [MethodImpl(4096)] get; }

		// Token: 0x06000042 RID: 66
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x591BF20", Offset = "0x591AB20", VA = "0x18591BF20")]
		[NativeMethod("FindSnapshotFromName")]
		[MethodImpl(4096)]
		public extern AudioMixerSnapshot FindSnapshot(string name);

		// Token: 0x06000043 RID: 67
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x591BED0", Offset = "0x591AAD0", VA = "0x18591BED0")]
		[NativeMethod("AudioMixerBindings::FindMatchingGroups", IsFreeFunction = true, HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern AudioMixerGroup[] FindMatchingGroups(string subPath);

		// Token: 0x06000044 RID: 68
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x591C030", Offset = "0x591AC30", VA = "0x18591C030")]
		[NativeMethod("AudioMixerBindings::TransitionToSnapshots", IsFreeFunction = true, HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern void TransitionToSnapshots(AudioMixerSnapshot[] snapshots, float[] weights, float timeToReach);

		// Token: 0x06000045 RID: 69
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x591BFD0", Offset = "0x591ABD0", VA = "0x18591BFD0")]
		[NativeMethod]
		[MethodImpl(4096)]
		public extern bool SetFloat(string name, float value);

		// Token: 0x06000046 RID: 70
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x591BF70", Offset = "0x591AB70", VA = "0x18591BF70")]
		[NativeMethod]
		[MethodImpl(4096)]
		public extern bool GetFloat(string name, out float value);
	}
}
