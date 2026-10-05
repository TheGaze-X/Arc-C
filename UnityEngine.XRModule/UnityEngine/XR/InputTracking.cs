using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[NativeConditional("ENABLE_VR")]
	[RequiredByNativeCode]
	[StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
	public static class InputTracking
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5BA27F0", Offset = "0x5BA13F0", VA = "0x185BA27F0")]
		[RequiredByNativeCode]
		private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> trackingAcquired;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<XRNodeState> trackingLost;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> nodeAdded;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> nodeRemoved;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		private enum TrackingStateEventType
		{
			// Token: 0x04000006 RID: 6
			[Token(Token = "0x4000006")]
			NodeAdded,
			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000007")]
			NodeRemoved,
			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			TrackingAcquired,
			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			TrackingLost
		}
	}
}
