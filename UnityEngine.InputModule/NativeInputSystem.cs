using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngineInternal.Input
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
	[NativeHeader("Modules/Input/Private/InputInternal.h")]
	internal class NativeInputSystem
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000001")]
		public static Action<int, string> onDeviceDiscovered
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x59BA830", Offset = "0x59B9430", VA = "0x1859BA830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x59BA8C0", Offset = "0x59B94C0", VA = "0x1859BA8C0")]
			set
			{
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x59BA4C0", Offset = "0x59B90C0", VA = "0x1859BA4C0")]
		[RequiredByNativeCode]
		internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x59BA5B0", Offset = "0x59B91B0", VA = "0x1859BA5B0")]
		[RequiredByNativeCode]
		internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x59BA530", Offset = "0x59B9130", VA = "0x1859BA530")]
		[RequiredByNativeCode]
		internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x59BA6D0", Offset = "0x59B92D0", VA = "0x1859BA6D0")]
		[RequiredByNativeCode]
		internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval)
		{
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x0600000A RID: 10
		[Token(Token = "0x17000002")]
		internal static extern bool hasDeviceDiscoveredCallback { [Token(Token = "0x600000A")] [Address(RVA = "0x59BA880", Offset = "0x59B9480", VA = "0x1859BA880")] [MethodImpl(4096)] set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11
		[Token(Token = "0x17000003")]
		[NativeProperty(IsThreadSafe = true)]
		public static extern double currentTime { [Token(Token = "0x600000B")] [Address(RVA = "0x59BA800", Offset = "0x59B9400", VA = "0x1859BA800")] [MethodImpl(4096)] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12
		[Token(Token = "0x17000004")]
		[NativeProperty(IsThreadSafe = true)]
		public static extern double currentTimeOffsetToRealtimeSinceStartup { [Token(Token = "0x600000C")] [Address(RVA = "0x59BA7D0", Offset = "0x59B93D0", VA = "0x1859BA7D0")] [MethodImpl(4096)] get; }

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x59BA430", Offset = "0x59B9030", VA = "0x1859BA430")]
		[FreeFunction("AllocateInputDeviceId")]
		[MethodImpl(4096)]
		public static extern int AllocateDeviceId();

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x59BA650", Offset = "0x59B9250", VA = "0x1859BA650")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern void QueueInputEvent(IntPtr inputEvent);

		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x59BA460", Offset = "0x59B9060", VA = "0x1859BA460")]
		[MethodImpl(4096)]
		public static extern long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes);

		// Token: 0x06000010 RID: 16
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x59BA690", Offset = "0x59B9290", VA = "0x1859BA690")]
		[MethodImpl(4096)]
		public static extern void SetPollingFrequency(float hertz);

		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x59BA760", Offset = "0x59B9360", VA = "0x1859BA760")]
		[MethodImpl(4096)]
		public static extern void Update(NativeInputUpdateType updateType);

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		public static NativeUpdateCallback onUpdate;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x8")]
		public static Action<NativeInputUpdateType> onBeforeUpdate;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		public static Func<NativeInputUpdateType, bool> onShouldRunUpdate;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		private static Action<int, string> s_OnDeviceDiscoveredCallback;
	}
}
