using System;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200026F RID: 623
	[Token(Token = "0x200026F")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	public struct BatchCullingContext
	{
		// Token: 0x06000E01 RID: 3585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x597A760", Offset = "0x5979360", VA = "0x18597A760")]
		internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane)
		{
		}

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0x0")]
		public readonly NativeArray<Plane> cullingPlanes;

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<BatchVisibility> batchVisibility;

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<int> visibleIndices;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x30")]
		public NativeArray<int> visibleIndicesY;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x40")]
		public readonly LODParameters lodParameters;

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x5C")]
		public readonly Matrix4x4 cullingMatrix;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x9C")]
		public readonly float nearPlane;
	}
}
