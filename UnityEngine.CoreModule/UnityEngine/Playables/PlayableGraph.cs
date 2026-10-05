using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[UsedByNativeCode]
	public struct PlayableGraph
	{
		// Token: 0x06000ECD RID: 3789 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x5981FE0", Offset = "0x5980BE0", VA = "0x185981FE0")]
		public Playable GetRootPlayable(int index)
		{
			return default(Playable);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6000ECE")]
		public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : struct, IPlayable where V : struct, IPlayable
		{
			return default(bool);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x5981D90", Offset = "0x5980990", VA = "0x185981D90")]
		public void Evaluate()
		{
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x59820D0", Offset = "0x5980CD0", VA = "0x1859820D0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00007548 File Offset: 0x00005748
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x5982090", Offset = "0x5980C90", VA = "0x185982090")]
		[FreeFunction("PlayableGraphBindings::IsPlaying", HasExplicitThis = true, ThrowsException = true)]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x5981D40", Offset = "0x5980940", VA = "0x185981D40")]
		[FreeFunction("PlayableGraphBindings::Evaluate", HasExplicitThis = true, ThrowsException = true)]
		public void Evaluate([DefaultValue("0")] float deltaTime)
		{
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x5981EB0", Offset = "0x5980AB0", VA = "0x185981EB0")]
		[FreeFunction("PlayableGraphBindings::GetResolver", HasExplicitThis = true, ThrowsException = true)]
		public IExposedPropertyTable GetResolver()
		{
			return null;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x5981E70", Offset = "0x5980A70", VA = "0x185981E70")]
		[FreeFunction("PlayableGraphBindings::GetPlayableCount", HasExplicitThis = true, ThrowsException = true)]
		public int GetPlayableCount()
		{
			return 0;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x5981EF0", Offset = "0x5980AF0", VA = "0x185981EF0")]
		[FreeFunction("PlayableGraphBindings::GetRootPlayableCount", HasExplicitThis = true, ThrowsException = true)]
		public int GetRootPlayableCount()
		{
			return 0;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x5982160", Offset = "0x5980D60", VA = "0x185982160")]
		[FreeFunction("PlayableGraphBindings::SynchronizeEvaluation", HasExplicitThis = true, ThrowsException = true)]
		internal void SynchronizeEvaluation(PlayableGraph playable)
		{
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x5981C90", Offset = "0x5980890", VA = "0x185981C90")]
		[FreeFunction("PlayableGraphBindings::CreatePlayableHandle", HasExplicitThis = true, ThrowsException = true)]
		internal PlayableHandle CreatePlayableHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000075A8 File Offset: 0x000057A8
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x5981CE0", Offset = "0x59808E0", VA = "0x185981CE0")]
		[FreeFunction("PlayableGraphBindings::CreateScriptOutputInternal", HasExplicitThis = true, ThrowsException = true)]
		internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
		{
			return default(bool);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x000075C0 File Offset: 0x000057C0
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x5981F80", Offset = "0x5980B80", VA = "0x185981F80")]
		[FreeFunction("PlayableGraphBindings::GetRootPlayableInternal", HasExplicitThis = true, ThrowsException = true)]
		internal PlayableHandle GetRootPlayableInternal(int index)
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x5982050", Offset = "0x5980C50", VA = "0x185982050")]
		[FreeFunction("PlayableGraphBindings::IsMatchFrameRateEnabled", HasExplicitThis = true, ThrowsException = true)]
		internal bool IsMatchFrameRateEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x5981E20", Offset = "0x5980A20", VA = "0x185981E20")]
		[FreeFunction("PlayableGraphBindings::GetFrameRate", HasExplicitThis = true, ThrowsException = true)]
		internal FrameRate GetFrameRate()
		{
			return default(FrameRate);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x5981BD0", Offset = "0x59807D0", VA = "0x185981BD0")]
		[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = true, ThrowsException = true)]
		private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
		{
			return default(bool);
		}

		// Token: 0x06000EDD RID: 3805
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x59820D0", Offset = "0x5980CD0", VA = "0x1859820D0")]
		[MethodImpl(4096)]
		private static extern bool IsValid_Injected(ref PlayableGraph _unity_self);

		// Token: 0x06000EDE RID: 3806
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x5982090", Offset = "0x5980C90", VA = "0x185982090")]
		[MethodImpl(4096)]
		private static extern bool IsPlaying_Injected(ref PlayableGraph _unity_self);

		// Token: 0x06000EDF RID: 3807
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x5981D40", Offset = "0x5980940", VA = "0x185981D40")]
		[MethodImpl(4096)]
		private static extern void Evaluate_Injected(ref PlayableGraph _unity_self, [DefaultValue("0")] float deltaTime);

		// Token: 0x06000EE0 RID: 3808
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x5981EB0", Offset = "0x5980AB0", VA = "0x185981EB0")]
		[MethodImpl(4096)]
		private static extern IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self);

		// Token: 0x06000EE1 RID: 3809
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x5981E70", Offset = "0x5980A70", VA = "0x185981E70")]
		[MethodImpl(4096)]
		private static extern int GetPlayableCount_Injected(ref PlayableGraph _unity_self);

		// Token: 0x06000EE2 RID: 3810
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x5981EF0", Offset = "0x5980AF0", VA = "0x185981EF0")]
		[MethodImpl(4096)]
		private static extern int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self);

		// Token: 0x06000EE3 RID: 3811
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x5982110", Offset = "0x5980D10", VA = "0x185982110")]
		[MethodImpl(4096)]
		private static extern void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, ref PlayableGraph playable);

		// Token: 0x06000EE4 RID: 3812
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x5981C40", Offset = "0x5980840", VA = "0x185981C40")]
		[MethodImpl(4096)]
		private static extern void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret);

		// Token: 0x06000EE5 RID: 3813
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x5981CE0", Offset = "0x59808E0", VA = "0x185981CE0")]
		[MethodImpl(4096)]
		private static extern bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle);

		// Token: 0x06000EE6 RID: 3814
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x5981F30", Offset = "0x5980B30", VA = "0x185981F30")]
		[MethodImpl(4096)]
		private static extern void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret);

		// Token: 0x06000EE7 RID: 3815
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x5982050", Offset = "0x5980C50", VA = "0x185982050")]
		[MethodImpl(4096)]
		private static extern bool IsMatchFrameRateEnabled_Injected(ref PlayableGraph _unity_self);

		// Token: 0x06000EE8 RID: 3816
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x5981DD0", Offset = "0x59809D0", VA = "0x185981DD0")]
		[MethodImpl(4096)]
		private static extern void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret);

		// Token: 0x06000EE9 RID: 3817
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x5981B60", Offset = "0x5980760", VA = "0x185981B60")]
		[MethodImpl(4096)]
		private static extern bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort);

		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x0")]
		internal IntPtr m_Handle;

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x8")]
		internal uint m_Version;
	}
}
