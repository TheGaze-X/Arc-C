using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct PlayableHandle : IEquatable<PlayableHandle>
	{
		// Token: 0x06000EEA RID: 3818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000EEA")]
		internal T GetObject<T>() where T : class, IPlayableBehaviour
		{
			return null;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x6000EEB")]
		[VisibleToOtherModules]
		internal bool IsPlayableOfType<T>()
		{
			return default(bool);
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x170002FB")]
		public static PlayableHandle Null
		{
			[Token(Token = "0x6000EEC")]
			[Address(RVA = "0x5983DA0", Offset = "0x59829A0", VA = "0x185983DA0")]
			get
			{
				return default(PlayableHandle);
			}
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x5982B30", Offset = "0x5981730", VA = "0x185982B30")]
		internal Playable GetInput(int inputPort)
		{
			return default(Playable);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x5983730", Offset = "0x5982330", VA = "0x185983730")]
		internal bool SetInputWeight(int inputIndex, float weight)
		{
			return default(bool);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x5982A70", Offset = "0x5981670", VA = "0x185982A70")]
		internal float GetInputWeight(int inputIndex)
		{
			return 0f;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x5983E00", Offset = "0x5982A00", VA = "0x185983E00")]
		public static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			return default(bool);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x59824E0", Offset = "0x59810E0", VA = "0x1859824E0", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x59825E0", Offset = "0x59811E0", VA = "0x1859825E0", Slot = "4")]
		public bool Equals(PlayableHandle other)
		{
			return default(bool);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x59827F0", Offset = "0x59813F0", VA = "0x1859827F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x5982490", Offset = "0x5981090", VA = "0x185982490")]
		internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			return default(bool);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x59821B0", Offset = "0x5980DB0", VA = "0x1859821B0")]
		internal bool CheckInputBounds(int inputIndex)
		{
			return default(bool);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x5982210", Offset = "0x5980E10", VA = "0x185982210")]
		internal bool CheckInputBounds(int inputIndex, bool acceptAny)
		{
			return default(bool);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x59831C0", Offset = "0x5981DC0", VA = "0x1859831C0")]
		[VisibleToOtherModules]
		internal bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x5982CF0", Offset = "0x59818F0", VA = "0x185982CF0")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = true, ThrowsException = true)]
		internal Type GetPlayableType()
		{
			return null;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x59839C0", Offset = "0x59825C0", VA = "0x1859839C0")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetScriptInstance", HasExplicitThis = true, ThrowsException = true)]
		internal void SetScriptInstance(object scriptInstance)
		{
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x5982C40", Offset = "0x5981840", VA = "0x185982C40")]
		[FreeFunction("PlayableHandleBindings::GetPlayState", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal PlayState GetPlayState()
		{
			return PlayState.Paused;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x5983320", Offset = "0x5981F20", VA = "0x185983320")]
		[FreeFunction("PlayableHandleBindings::Play", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void Play()
		{
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x5983270", Offset = "0x5981E70", VA = "0x185983270")]
		[FreeFunction("PlayableHandleBindings::Pause", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void Pause()
		{
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x5982F00", Offset = "0x5981B00", VA = "0x185982F00")]
		[FreeFunction("PlayableHandleBindings::GetSpeed", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal double GetSpeed()
		{
			return 0.0;
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x5983A90", Offset = "0x5982690", VA = "0x185983A90")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetSpeed", HasExplicitThis = true, ThrowsException = true)]
		internal void SetSpeed(double value)
		{
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x5983060", Offset = "0x5981C60", VA = "0x185983060")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::GetTime", HasExplicitThis = true, ThrowsException = true)]
		internal double GetTime()
		{
			return 0.0;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x5983C20", Offset = "0x5982820", VA = "0x185983C20")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetTime", HasExplicitThis = true, ThrowsException = true)]
		internal void SetTime(double value)
		{
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x5983110", Offset = "0x5981D10", VA = "0x185983110")]
		[FreeFunction("PlayableHandleBindings::IsDone", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x59833E0", Offset = "0x5981FE0", VA = "0x1859833E0")]
		[FreeFunction("PlayableHandleBindings::SetDone", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void SetDone(bool value)
		{
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x59826B0", Offset = "0x59812B0", VA = "0x1859826B0")]
		[FreeFunction("PlayableHandleBindings::GetDuration", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal double GetDuration()
		{
			return 0.0;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x59834B0", Offset = "0x59820B0", VA = "0x1859834B0")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetDuration", HasExplicitThis = true, ThrowsException = true)]
		internal void SetDuration(double value)
		{
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x59838F0", Offset = "0x59824F0", VA = "0x1859838F0")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetPropagateSetTime", HasExplicitThis = true, ThrowsException = true)]
		internal void SetPropagateSetTime(bool value)
		{
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x5982770", Offset = "0x5981370", VA = "0x185982770")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::GetGraph", HasExplicitThis = true, ThrowsException = true)]
		internal PlayableGraph GetGraph()
		{
			return default(PlayableGraph);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x5982860", Offset = "0x5981460", VA = "0x185982860")]
		[FreeFunction("PlayableHandleBindings::GetInputCount", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal int GetInputCount()
		{
			return 0;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x5983570", Offset = "0x5982170", VA = "0x185983570")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetInputCount", HasExplicitThis = true, ThrowsException = true)]
		internal void SetInputCount(int value)
		{
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x5983810", Offset = "0x5982410", VA = "0x185983810")]
		[FreeFunction("PlayableHandleBindings::SetInputWeight", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void SetInputWeight(PlayableHandle input, float weight)
		{
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x5982DA0", Offset = "0x59819A0", VA = "0x185982DA0")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::GetPreviousTime", HasExplicitThis = true, ThrowsException = true)]
		internal double GetPreviousTime()
		{
			return 0.0;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x5983CE0", Offset = "0x59828E0", VA = "0x185983CE0")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::SetTraversalMode", HasExplicitThis = true, ThrowsException = true)]
		internal void SetTraversalMode(PlayableTraversalMode mode)
		{
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x5982FB0", Offset = "0x5981BB0", VA = "0x185982FB0")]
		[VisibleToOtherModules]
		[FreeFunction("PlayableHandleBindings::GetTimeWrapMode", HasExplicitThis = true, ThrowsException = true)]
		internal DirectorWrapMode GetTimeWrapMode()
		{
			return DirectorWrapMode.Hold;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x5983B50", Offset = "0x5982750", VA = "0x185983B50")]
		[FreeFunction("PlayableHandleBindings::SetTimeWrapMode", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal void SetTimeWrapMode(DirectorWrapMode mode)
		{
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x5982E50", Offset = "0x5981A50", VA = "0x185982E50")]
		[FreeFunction("PlayableHandleBindings::GetScriptInstance", HasExplicitThis = true, ThrowsException = true)]
		private object GetScriptInstance()
		{
			return null;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x5982920", Offset = "0x5981520", VA = "0x185982920")]
		[FreeFunction("PlayableHandleBindings::GetInputHandle", HasExplicitThis = true, ThrowsException = true)]
		private PlayableHandle GetInputHandle(int index)
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x5983640", Offset = "0x5982240", VA = "0x185983640")]
		[FreeFunction("PlayableHandleBindings::SetInputWeightFromIndex", HasExplicitThis = true, ThrowsException = true)]
		private void SetInputWeightFromIndex(int index, float weight)
		{
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x59829F0", Offset = "0x59815F0", VA = "0x1859829F0")]
		[FreeFunction("PlayableHandleBindings::GetInputWeightFromIndex", HasExplicitThis = true, ThrowsException = true)]
		private float GetInputWeightFromIndex(int index)
		{
			return 0f;
		}

		// Token: 0x06000F13 RID: 3859
		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x5983180", Offset = "0x5981D80", VA = "0x185983180")]
		[MethodImpl(4096)]
		private static extern bool IsValid_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F14 RID: 3860
		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x5982CB0", Offset = "0x59818B0", VA = "0x185982CB0")]
		[MethodImpl(4096)]
		private static extern Type GetPlayableType_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F15 RID: 3861
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x5983970", Offset = "0x5982570", VA = "0x185983970")]
		[MethodImpl(4096)]
		private static extern void SetScriptInstance_Injected(ref PlayableHandle _unity_self, object scriptInstance);

		// Token: 0x06000F16 RID: 3862
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x5982C00", Offset = "0x5981800", VA = "0x185982C00")]
		[MethodImpl(4096)]
		private static extern PlayState GetPlayState_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F17 RID: 3863
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x59832E0", Offset = "0x5981EE0", VA = "0x1859832E0")]
		[MethodImpl(4096)]
		private static extern void Play_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F18 RID: 3864
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x5983230", Offset = "0x5981E30", VA = "0x185983230")]
		[MethodImpl(4096)]
		private static extern void Pause_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F19 RID: 3865
		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x5982EC0", Offset = "0x5981AC0", VA = "0x185982EC0")]
		[MethodImpl(4096)]
		private static extern double GetSpeed_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F1A RID: 3866
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x5983A40", Offset = "0x5982640", VA = "0x185983A40")]
		[MethodImpl(4096)]
		private static extern void SetSpeed_Injected(ref PlayableHandle _unity_self, double value);

		// Token: 0x06000F1B RID: 3867
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x5983020", Offset = "0x5981C20", VA = "0x185983020")]
		[MethodImpl(4096)]
		private static extern double GetTime_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F1C RID: 3868
		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x5983BD0", Offset = "0x59827D0", VA = "0x185983BD0")]
		[MethodImpl(4096)]
		private static extern void SetTime_Injected(ref PlayableHandle _unity_self, double value);

		// Token: 0x06000F1D RID: 3869
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x59830D0", Offset = "0x5981CD0", VA = "0x1859830D0")]
		[MethodImpl(4096)]
		private static extern bool IsDone_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F1E RID: 3870
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x5983390", Offset = "0x5981F90", VA = "0x185983390")]
		[MethodImpl(4096)]
		private static extern void SetDone_Injected(ref PlayableHandle _unity_self, bool value);

		// Token: 0x06000F1F RID: 3871
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x5982670", Offset = "0x5981270", VA = "0x185982670")]
		[MethodImpl(4096)]
		private static extern double GetDuration_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F20 RID: 3872
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x5983460", Offset = "0x5982060", VA = "0x185983460")]
		[MethodImpl(4096)]
		private static extern void SetDuration_Injected(ref PlayableHandle _unity_self, double value);

		// Token: 0x06000F21 RID: 3873
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x59838A0", Offset = "0x59824A0", VA = "0x1859838A0")]
		[MethodImpl(4096)]
		private static extern void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value);

		// Token: 0x06000F22 RID: 3874
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0x5982720", Offset = "0x5981320", VA = "0x185982720")]
		[MethodImpl(4096)]
		private static extern void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret);

		// Token: 0x06000F23 RID: 3875
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x5982820", Offset = "0x5981420", VA = "0x185982820")]
		[MethodImpl(4096)]
		private static extern int GetInputCount_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F24 RID: 3876
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x5983530", Offset = "0x5982130", VA = "0x185983530")]
		[MethodImpl(4096)]
		private static extern void SetInputCount_Injected(ref PlayableHandle _unity_self, int value);

		// Token: 0x06000F25 RID: 3877
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x59836D0", Offset = "0x59822D0", VA = "0x1859836D0")]
		[MethodImpl(4096)]
		private static extern void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight);

		// Token: 0x06000F26 RID: 3878
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x5982D60", Offset = "0x5981960", VA = "0x185982D60")]
		[MethodImpl(4096)]
		private static extern double GetPreviousTime_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F27 RID: 3879
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x5983CA0", Offset = "0x59828A0", VA = "0x185983CA0")]
		[MethodImpl(4096)]
		private static extern void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode);

		// Token: 0x06000F28 RID: 3880
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x5982F70", Offset = "0x5981B70", VA = "0x185982F70")]
		[MethodImpl(4096)]
		private static extern DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F29 RID: 3881
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x5983B10", Offset = "0x5982710", VA = "0x185983B10")]
		[MethodImpl(4096)]
		private static extern void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode);

		// Token: 0x06000F2A RID: 3882
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x5982E10", Offset = "0x5981A10", VA = "0x185982E10")]
		[MethodImpl(4096)]
		private static extern object GetScriptInstance_Injected(ref PlayableHandle _unity_self);

		// Token: 0x06000F2B RID: 3883
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x59828D0", Offset = "0x59814D0", VA = "0x1859828D0")]
		[MethodImpl(4096)]
		private static extern void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret);

		// Token: 0x06000F2C RID: 3884
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x59835F0", Offset = "0x59821F0", VA = "0x1859835F0")]
		[MethodImpl(4096)]
		private static extern void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight);

		// Token: 0x06000F2D RID: 3885
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x59829B0", Offset = "0x59815B0", VA = "0x1859829B0")]
		[MethodImpl(4096)]
		private static extern float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index);

		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x0")]
		internal IntPtr m_Handle;

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x8")]
		internal uint m_Version;

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x0")]
		private static readonly PlayableHandle m_Null;
	}
}
