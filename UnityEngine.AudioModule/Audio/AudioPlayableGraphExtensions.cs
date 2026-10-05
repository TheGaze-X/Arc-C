using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[StaticAccessor("AudioPlayableGraphExtensionsBindings", StaticAccessorType.DoubleColon)]
	internal static class AudioPlayableGraphExtensions
	{
		// Token: 0x06000052 RID: 82
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x591C290", Offset = "0x591AE90", VA = "0x18591C290")]
		[NativeThrows]
		[MethodImpl(4096)]
		internal static extern bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle);
	}
}
