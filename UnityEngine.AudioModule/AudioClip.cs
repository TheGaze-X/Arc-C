using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioClip : Object
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x591B7A0", Offset = "0x591A3A0", VA = "0x18591B7A0")]
		private AudioClip()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10
		[Token(Token = "0x17000002")]
		[NativeProperty("LengthSec")]
		public extern float length { [Token(Token = "0x600000A")] [Address(RVA = "0x591B850", Offset = "0x591A450", VA = "0x18591B850")] [MethodImpl(4096)] get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11
		[Token(Token = "0x17000003")]
		[NativeProperty("SampleCount")]
		public extern int samples { [Token(Token = "0x600000B")] [Address(RVA = "0x591B950", Offset = "0x591A550", VA = "0x18591B950")] [MethodImpl(4096)] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12
		[Token(Token = "0x17000004")]
		public extern int frequency { [Token(Token = "0x600000C")] [Address(RVA = "0x591B810", Offset = "0x591A410", VA = "0x18591B810")] [MethodImpl(4096)] get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13
		[Token(Token = "0x17000005")]
		public extern AudioClipLoadType loadType { [Token(Token = "0x600000D")] [Address(RVA = "0x591B8D0", Offset = "0x591A4D0", VA = "0x18591B8D0")] [MethodImpl(4096)] get; }

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x591B760", Offset = "0x591A360", VA = "0x18591B760")]
		[MethodImpl(4096)]
		public extern bool LoadAudioData();

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15
		[Token(Token = "0x17000006")]
		public extern bool preloadAudioData { [Token(Token = "0x600000F")] [Address(RVA = "0x591B910", Offset = "0x591A510", VA = "0x18591B910")] [MethodImpl(4096)] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16
		[Token(Token = "0x17000007")]
		public extern AudioDataLoadState loadState { [Token(Token = "0x6000010")] [Address(RVA = "0x591B890", Offset = "0x591A490", VA = "0x18591B890")] [NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3104BA0", Offset = "0x31037A0", VA = "0x183104BA0")]
		[RequiredByNativeCode]
		private void InvokePCMReaderCallback_Internal(float[] data)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x591B740", Offset = "0x591A340", VA = "0x18591B740")]
		[RequiredByNativeCode]
		private void InvokePCMSetPositionCallback_Internal(int position)
		{
		}

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x18")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private AudioClip.PCMReaderCallback m_PCMReaderCallback;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000014 RID: 20
		[Token(Token = "0x2000008")]
		public delegate void PCMReaderCallback(float[] data);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000016 RID: 22
		[Token(Token = "0x2000009")]
		public delegate void PCMSetPositionCallback(int position);
	}
}
