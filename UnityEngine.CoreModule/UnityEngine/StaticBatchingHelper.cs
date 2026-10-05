using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshCombiner.h")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	internal struct StaticBatchingHelper
	{
		// Token: 0x0600057B RID: 1403
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x5941B70", Offset = "0x5940770", VA = "0x185941B70")]
		[FreeFunction("MeshScripting::CombineMeshVerticesForStaticBatching")]
		[MethodImpl(4096)]
		internal static extern Mesh InternalCombineVertices(MeshSubsetCombineUtility.MeshInstance[] meshes, string meshName);

		// Token: 0x0600057C RID: 1404
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x5941B20", Offset = "0x5940720", VA = "0x185941B20")]
		[FreeFunction("MeshScripting::CombineMeshIndicesForStaticBatching")]
		[MethodImpl(4096)]
		internal static extern void InternalCombineIndices(MeshSubsetCombineUtility.SubMeshInstance[] submeshes, Mesh combinedMesh);

		// Token: 0x0600057D RID: 1405
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x5941BC0", Offset = "0x59407C0", VA = "0x185941BC0")]
		[FreeFunction("IsMeshBatchable")]
		[MethodImpl(4096)]
		internal static extern bool IsMeshBatchable(Mesh mesh);
	}
}
