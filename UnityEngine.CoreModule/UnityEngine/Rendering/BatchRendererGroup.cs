using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Math/Matrix4x4.h")]
	[StructLayout(0)]
	public class BatchRendererGroup
	{
		// Token: 0x06000E02 RID: 3586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x597A7E0", Offset = "0x59793E0", VA = "0x18597A7E0")]
		[RequiredByNativeCode]
		private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters)
		{
		}

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr m_GroupHandle;

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BatchRendererGroup.OnPerformCulling m_PerformCulling;

		// Token: 0x02000272 RID: 626
		// (Invoke) Token: 0x06000E04 RID: 3588
		[Token(Token = "0x2000272")]
		public delegate JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext);
	}
}
