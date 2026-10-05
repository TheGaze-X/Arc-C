using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Services
{
	// Token: 0x0200037D RID: 893
	[Token(Token = "0x200037D")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class TrackingServices
	{
		// Token: 0x06001D37 RID: 7479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D37")]
		[Address(RVA = "0x4B910F0", Offset = "0x4B8FCF0", VA = "0x184B910F0")]
		internal static void NotifyMarshaledObject(object obj, ObjRef or)
		{
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D38")]
		[Address(RVA = "0x4B91480", Offset = "0x4B90080", VA = "0x184B91480")]
		internal static void NotifyUnmarshaledObject(object obj, ObjRef or)
		{
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D39")]
		[Address(RVA = "0x4B90D60", Offset = "0x4B8F960", VA = "0x184B90D60")]
		internal static void NotifyDisconnectedObject(object obj)
		{
		}

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Collections.ArrayList _handlers;
	}
}
