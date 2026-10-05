using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	public sealed class AudioSettings
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		[Token(Token = "0x17000001")]
		public static extern double dspTime { [Token(Token = "0x6000001")] [Address(RVA = "0x591CBA0", Offset = "0x591B7A0", VA = "0x18591CBA0")] [NativeMethod(Name = "GetDSPTime", IsThreadSafe = true)] [MethodImpl(4096)] get; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public static event AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x591CAE0", Offset = "0x591B6E0", VA = "0x18591CAE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x591CBD0", Offset = "0x591B7D0", VA = "0x18591CBD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x591C9E0", Offset = "0x591B5E0", VA = "0x18591C9E0")]
		[RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x591CA40", Offset = "0x591B640", VA = "0x18591CA40")]
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemShuttingDown()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x591CA90", Offset = "0x591B690", VA = "0x18591CA90")]
		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemStartedUp()
		{
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x8")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnAudioSystemShuttingDown;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x10")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnAudioSystemStartedUp;

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000008 RID: 8
		[Token(Token = "0x2000006")]
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);
	}
}
