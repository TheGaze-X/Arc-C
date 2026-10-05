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
	public static class XRDevice
	{
		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5BA1B30", Offset = "0x5BA0730", VA = "0x185BA1B30")]
		[NativeName("DisableAutoVRCameraTracking")]
		[StaticAccessor("GetIVRDevice()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		[MethodImpl(4096)]
		public static extern void DisableAutoXRCameraTracking([NotNull("ArgumentNullException")] Camera camera, bool disabled);

		// Token: 0x0600000A RID: 10 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5BA1B80", Offset = "0x5BA0780", VA = "0x185BA1B80")]
		[RequiredByNativeCode]
		private static void InvokeDeviceLoaded(string loadedDeviceName)
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string> deviceLoaded;
	}
}
