using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
	public class MeshRenderer : Renderer
	{
		// Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[RequiredByNativeCode]
		private void DontStripMeshRenderer()
		{
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000500 RID: 1280
		// (set) Token: 0x06000501 RID: 1281
		[Token(Token = "0x1700013E")]
		public extern Mesh additionalVertexStreams { [Token(Token = "0x6000500")] [Address(RVA = "0x5931E40", Offset = "0x5930A40", VA = "0x185931E40")] [MethodImpl(4096)] get; [Token(Token = "0x6000501")] [Address(RVA = "0x5931EC0", Offset = "0x5930AC0", VA = "0x185931EC0")] [MethodImpl(4096)] set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000502 RID: 1282
		// (set) Token: 0x06000503 RID: 1283
		[Token(Token = "0x1700013F")]
		public extern Mesh enlightenVertexStream { [Token(Token = "0x6000502")] [Address(RVA = "0x5931E80", Offset = "0x5930A80", VA = "0x185931E80")] [MethodImpl(4096)] get; [Token(Token = "0x6000503")] [Address(RVA = "0x5931F10", Offset = "0x5930B10", VA = "0x185931F10")] [MethodImpl(4096)] set; }

		// Token: 0x06000504 RID: 1284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public MeshRenderer()
		{
		}
	}
}
