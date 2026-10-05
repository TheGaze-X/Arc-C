using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[MovedFrom("UnityEngine")]
	[StaticAccessor("NavMeshBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/NavMeshManager.h")]
	public static class NavMesh
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x59042C0", Offset = "0x5902EC0", VA = "0x1859042C0")]
		[RequiredByNativeCode]
		private static void Internal_CallOnNavMeshPreUpdate()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		public static NavMesh.OnNavMeshPreUpdate onPreUpdate;

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000003 RID: 3
		[Token(Token = "0x2000003")]
		public delegate void OnNavMeshPreUpdate();
	}
}
