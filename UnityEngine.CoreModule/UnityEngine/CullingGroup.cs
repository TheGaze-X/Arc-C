using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
	[StructLayout(0)]
	public class CullingGroup
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5925600", Offset = "0x5924200", VA = "0x185925600")]
		[RequiredByNativeCode]
		private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
		}

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CullingGroup.StateChanged m_OnStateChanged;

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x0600017B RID: 379
		[Token(Token = "0x200005D")]
		public delegate void StateChanged(CullingGroupEvent sphere);
	}
}
