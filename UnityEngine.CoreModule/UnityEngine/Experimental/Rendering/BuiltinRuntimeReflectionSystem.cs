using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
	internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable
	{
		// Token: 0x06000F99 RID: 3993 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x597AA40", Offset = "0x5979640", VA = "0x18597AA40", Slot = "4")]
		public bool TickRealtimeProbes()
		{
			return default(bool);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06000F9C RID: 3996
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x597AA40", Offset = "0x5979640", VA = "0x18597AA40")]
		[StaticAccessor("GetReflectionProbes()", Type = 0)]
		[MethodImpl(4096)]
		private static extern bool BuiltinUpdate();

		// Token: 0x06000F9D RID: 3997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x597AA70", Offset = "0x5979670", VA = "0x18597AA70")]
		[RequiredByNativeCode]
		private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New()
		{
			return null;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuiltinRuntimeReflectionSystem()
		{
		}
	}
}
