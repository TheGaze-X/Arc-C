using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	internal static class NativeEventCalls
	{
		// Token: 0x06001367 RID: 4967 RVA: 0x0000EE98 File Offset: 0x0000D098
		[Token(Token = "0x6001367")]
		[Address(RVA = "0x4ADF270", Offset = "0x4ADDE70", VA = "0x184ADF270")]
		public static System.IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode)
		{
			return 0;
		}

		// Token: 0x06001368 RID: 4968
		[Token(Token = "0x6001368")]
		[Address(RVA = "0x4ADF260", Offset = "0x4ADDE60", VA = "0x184ADF260")]
		[MethodImpl(4096)]
		private unsafe static extern System.IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode);

		// Token: 0x06001369 RID: 4969 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x4ADF3D0", Offset = "0x4ADDFD0", VA = "0x184ADF3D0")]
		public static bool SetEvent(Microsoft.Win32.SafeHandles.SafeWaitHandle handle)
		{
			return default(bool);
		}

		// Token: 0x0600136A RID: 4970
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x4ADF3C0", Offset = "0x4ADDFC0", VA = "0x184ADF3C0")]
		[MethodImpl(4096)]
		private static extern bool SetEvent_internal(System.IntPtr handle);

		// Token: 0x0600136B RID: 4971 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x4ADF2F0", Offset = "0x4ADDEF0", VA = "0x184ADF2F0")]
		public static bool ResetEvent(Microsoft.Win32.SafeHandles.SafeWaitHandle handle)
		{
			return default(bool);
		}

		// Token: 0x0600136C RID: 4972
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x4ADF2E0", Offset = "0x4ADDEE0", VA = "0x184ADF2E0")]
		[MethodImpl(4096)]
		private static extern bool ResetEvent_internal(System.IntPtr handle);

		// Token: 0x0600136D RID: 4973
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x4ADF250", Offset = "0x4ADDE50", VA = "0x184ADF250")]
		[MethodImpl(4096)]
		public static extern void CloseEvent_internal(System.IntPtr handle);
	}
}
