using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
	public sealed class MeshFilter : Component
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[RequiredByNativeCode]
		private void DontStripMeshFilter()
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004E2 RID: 1250
		// (set) Token: 0x060004E3 RID: 1251
		[Token(Token = "0x17000134")]
		public extern Mesh sharedMesh { [Token(Token = "0x60004E2")] [Address(RVA = "0x5931D60", Offset = "0x5930960", VA = "0x185931D60")] [MethodImpl(4096)] get; [Token(Token = "0x60004E3")] [Address(RVA = "0x5931DF0", Offset = "0x59309F0", VA = "0x185931DF0")] [MethodImpl(4096)] set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004E4 RID: 1252
		// (set) Token: 0x060004E5 RID: 1253
		[Token(Token = "0x17000135")]
		public extern Mesh mesh { [Token(Token = "0x60004E4")] [Address(RVA = "0x5931D20", Offset = "0x5930920", VA = "0x185931D20")] [NativeName("GetInstantiatedMeshFromScript")] [MethodImpl(4096)] get; [Token(Token = "0x60004E5")] [Address(RVA = "0x5931DA0", Offset = "0x59309A0", VA = "0x185931DA0")] [NativeName("SetInstantiatedMesh")] [MethodImpl(4096)] set; }
	}
}
