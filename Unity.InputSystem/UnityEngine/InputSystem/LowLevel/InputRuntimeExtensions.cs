using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	internal static class InputRuntimeExtensions
	{
		// Token: 0x060010BF RID: 4287 RVA: 0x00008B08 File Offset: 0x00006D08
		[Token(Token = "0x60010BF")]
		public static long DeviceCommand<TCommand>(this IInputRuntime runtime, int deviceId, ref TCommand command) where TCommand : struct, IInputDeviceCommandInfo
		{
			return 0L;
		}
	}
}
