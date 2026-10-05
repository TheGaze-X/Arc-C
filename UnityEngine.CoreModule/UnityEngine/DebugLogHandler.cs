using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	internal sealed class DebugLogHandler : ILogHandler
	{
		// Token: 0x060001C8 RID: 456
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x5925780", Offset = "0x5924380", VA = "0x185925780")]
		[ThreadAndSerializationSafe]
		[MethodImpl(4096)]
		internal static extern void Internal_Log(LogType level, LogOption options, string msg, Object obj);

		// Token: 0x060001C9 RID: 457
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x5925730", Offset = "0x5924330", VA = "0x185925730")]
		[ThreadAndSerializationSafe]
		[MethodImpl(4096)]
		internal static extern void Internal_LogException(Exception ex, Object obj);

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x5925880", Offset = "0x5924480", VA = "0x185925880", Slot = "4")]
		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x59258F0", Offset = "0x59244F0", VA = "0x1859258F0")]
		public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x59257E0", Offset = "0x59243E0", VA = "0x1859257E0", Slot = "5")]
		public void LogException(Exception exception, Object context)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DebugLogHandler()
		{
		}
	}
}
