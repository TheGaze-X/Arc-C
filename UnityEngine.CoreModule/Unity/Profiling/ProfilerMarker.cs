using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Scripting;

namespace Unity.Profiling
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[UsedByNativeCode]
	public struct ProfilerMarker
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x59364C0", Offset = "0x59350C0", VA = "0x1859364C0")]
		[MethodImpl(256)]
		public ProfilerMarker(string name)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5936460", Offset = "0x5935060", VA = "0x185936460")]
		[MethodImpl(256)]
		public ProfilerMarker(ProfilerCategory category, string name)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x59363E0", Offset = "0x5934FE0", VA = "0x1859363E0")]
		[Pure]
		[Conditional("ENABLE_PROFILER")]
		[MethodImpl(256)]
		public void Begin()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x5936420", Offset = "0x5935020", VA = "0x185936420")]
		[Conditional("ENABLE_PROFILER")]
		[Pure]
		[MethodImpl(256)]
		public void End()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5936360", Offset = "0x5934F60", VA = "0x185936360")]
		[Pure]
		[MethodImpl(256)]
		public ProfilerMarker.AutoScope Auto()
		{
			return default(ProfilerMarker.AutoScope);
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[NonSerialized]
		internal readonly IntPtr m_Ptr;

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		[UsedByNativeCode]
		public struct AutoScope : IDisposable
		{
			// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x591FB10", Offset = "0x591E710", VA = "0x18591FB10")]
			[MethodImpl(256)]
			internal AutoScope(IntPtr markerPtr)
			{
			}

			// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x591FA90", Offset = "0x591E690", VA = "0x18591FA90", Slot = "4")]
			[MethodImpl(256)]
			public void Dispose()
			{
			}

			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x0")]
			[NativeDisableUnsafePtrRestriction]
			internal readonly IntPtr m_Ptr;
		}
	}
}
