using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
	[NativeHeader("Runtime/Jobs/JobSystem.h")]
	public static class JobsUtility
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x592C340", Offset = "0x592AF40", VA = "0x18592C340")]
		[RequiredByNativeCode]
		private static void InvokePanicFunction()
		{
		}

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x0")]
		internal static JobsUtility.PanicFunction_ PanicFunction;

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		public struct JobScheduleParameters
		{
			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x0")]
			public JobHandle Dependency;

			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x10")]
			public int ScheduleMode;

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x18")]
			public IntPtr ReflectionData;

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x20")]
			public IntPtr JobDataPtr;
		}

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600001E RID: 30
		[Token(Token = "0x2000013")]
		internal delegate void PanicFunction_();
	}
}
