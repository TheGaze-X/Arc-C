using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[NativeHeader("Modules/Director/PlayableDirector.h")]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[RequiredByNativeCode]
	public class PlayableDirector : Behaviour, IExposedPropertyTable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public PlayState state
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x59895C0", Offset = "0x59881C0", VA = "0x1859895C0")]
			get
			{
				return PlayState.Paused;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000002")]
		public DirectorWrapMode extrapolationMode
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x59896B0", Offset = "0x59882B0", VA = "0x1859896B0")]
			get
			{
				return DirectorWrapMode.Hold;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002081 File Offset: 0x00000281
		[Token(Token = "0x17000003")]
		public PlayableAsset playableAsset
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x59899B0", Offset = "0x59885B0", VA = "0x1859899B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x5989920", Offset = "0x5988520", VA = "0x185989920")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x17000004")]
		public PlayableGraph playableGraph
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x5989A80", Offset = "0x5988680", VA = "0x185989A80")]
			get
			{
				return default(PlayableGraph);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002081 File Offset: 0x00000281
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x5989860", Offset = "0x5988460", VA = "0x185989860")]
		internal void Play(FrameRate frameRate)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002081 File Offset: 0x00000281
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5989730", Offset = "0x5988330", VA = "0x185989730")]
		public void SetGenericBinding(Object key, Object value)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9
		// (set) Token: 0x06000008 RID: 8
		[Token(Token = "0x17000005")]
		public extern double time { [Token(Token = "0x6000009")] [Address(RVA = "0x5989AE0", Offset = "0x59886E0", VA = "0x185989AE0")] [MethodImpl(4096)] get; [Token(Token = "0x6000008")] [Address(RVA = "0x5989B20", Offset = "0x5988720", VA = "0x185989B20")] [MethodImpl(4096)] set; }

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5989490", Offset = "0x5988090", VA = "0x185989490")]
		[NativeThrows]
		[MethodImpl(4096)]
		public extern void Evaluate();

		// Token: 0x0600000B RID: 11 RVA: 0x00002081 File Offset: 0x00000281
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5989820", Offset = "0x5988420", VA = "0x185989820")]
		[NativeThrows]
		private void PlayOnFrame(FrameRate frameRate)
		{
		}

		// Token: 0x0600000C RID: 12
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x59898A0", Offset = "0x59884A0", VA = "0x1859898A0")]
		[NativeThrows]
		[MethodImpl(4096)]
		public extern void Play();

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x5989970", Offset = "0x5988570", VA = "0x185989970")]
		[MethodImpl(4096)]
		public extern void Stop();

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5989790", Offset = "0x5988390", VA = "0x185989790")]
		[MethodImpl(4096)]
		public extern void Pause();

		// Token: 0x0600000F RID: 15 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5989660", Offset = "0x5988260", VA = "0x185989660", Slot = "4")]
		public Object GetReferenceValue(PropertyName id, out bool idValid)
		{
			return null;
		}

		// Token: 0x06000010 RID: 16
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x59894D0", Offset = "0x59880D0", VA = "0x1859894D0")]
		[NativeMethod("GetBindingFor")]
		[MethodImpl(4096)]
		public extern Object GetGenericBinding(Object key);

		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x5989440", Offset = "0x5988040", VA = "0x185989440")]
		[NativeMethod("ClearBindingFor")]
		[MethodImpl(4096)]
		public extern void ClearGenericBinding(Object key);

		// Token: 0x06000012 RID: 18
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x59895C0", Offset = "0x59881C0", VA = "0x1859895C0")]
		[MethodImpl(4096)]
		private extern PlayState GetPlayState();

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59896B0", Offset = "0x59882B0", VA = "0x1859896B0")]
		[MethodImpl(4096)]
		private extern DirectorWrapMode GetWrapMode();

		// Token: 0x06000014 RID: 20 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5989570", Offset = "0x5988170", VA = "0x185989570")]
		private PlayableGraph GetGraphHandle()
		{
			return default(PlayableGraph);
		}

		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5989730", Offset = "0x5988330", VA = "0x185989730")]
		[NativeThrows]
		[MethodImpl(4096)]
		private extern void Internal_SetGenericBinding(Object key, Object value);

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5989920", Offset = "0x5988520", VA = "0x185989920")]
		[MethodImpl(4096)]
		private extern void SetPlayableAsset(ScriptableObject asset);

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x59896F0", Offset = "0x59882F0", VA = "0x1859896F0")]
		[MethodImpl(4096)]
		private extern ScriptableObject Internal_GetPlayableAsset();

		// Token: 0x06000018 RID: 24 RVA: 0x00002081 File Offset: 0x00000281
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5989900", Offset = "0x5988500", VA = "0x185989900")]
		[RequiredByNativeCode]
		private void SendOnPlayableDirectorPlay()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002081 File Offset: 0x00000281
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x59898E0", Offset = "0x59884E0", VA = "0x1859898E0")]
		[RequiredByNativeCode]
		private void SendOnPlayableDirectorPause()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002081 File Offset: 0x00000281
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x31BD1E0", Offset = "0x31BBDE0", VA = "0x1831BD1E0")]
		[RequiredByNativeCode]
		private void SendOnPlayableDirectorStop()
		{
		}

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x59897D0", Offset = "0x59883D0", VA = "0x1859897D0")]
		[MethodImpl(4096)]
		private extern void PlayOnFrame_Injected(ref FrameRate frameRate);

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5989600", Offset = "0x5988200", VA = "0x185989600", Slot = "5")]
		[MethodImpl(4096)]
		private extern Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid);

		// Token: 0x0600001D RID: 29
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5989520", Offset = "0x5988120", VA = "0x185989520")]
		[MethodImpl(4096)]
		private extern void GetGraphHandle_Injected(out PlayableGraph ret);

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<PlayableDirector> played;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<PlayableDirector> paused;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<PlayableDirector> stopped;
	}
}
