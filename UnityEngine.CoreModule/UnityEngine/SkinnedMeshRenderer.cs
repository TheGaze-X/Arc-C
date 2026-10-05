using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
	public class SkinnedMeshRenderer : Renderer
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004E6 RID: 1254
		// (set) Token: 0x060004E7 RID: 1255
		[Token(Token = "0x17000136")]
		public extern SkinQuality quality { [Token(Token = "0x60004E6")] [Address(RVA = "0x5941630", Offset = "0x5940230", VA = "0x185941630")] [MethodImpl(4096)] get; [Token(Token = "0x60004E7")] [Address(RVA = "0x5941850", Offset = "0x5940450", VA = "0x185941850")] [MethodImpl(4096)] set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004E8 RID: 1256
		// (set) Token: 0x060004E9 RID: 1257
		[Token(Token = "0x17000137")]
		public extern bool updateWhenOffscreen { [Token(Token = "0x60004E8")] [Address(RVA = "0x5941730", Offset = "0x5940330", VA = "0x185941730")] [MethodImpl(4096)] get; [Token(Token = "0x60004E9")] [Address(RVA = "0x5941980", Offset = "0x5940580", VA = "0x185941980")] [MethodImpl(4096)] set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004EA RID: 1258
		// (set) Token: 0x060004EB RID: 1259
		[Token(Token = "0x17000138")]
		public extern bool forceMatrixRecalculationPerRender { [Token(Token = "0x60004EA")] [Address(RVA = "0x59415F0", Offset = "0x59401F0", VA = "0x1859415F0")] [MethodImpl(4096)] get; [Token(Token = "0x60004EB")] [Address(RVA = "0x5941800", Offset = "0x5940400", VA = "0x185941800")] [MethodImpl(4096)] set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004EC RID: 1260
		// (set) Token: 0x060004ED RID: 1261
		[Token(Token = "0x17000139")]
		public extern Transform rootBone { [Token(Token = "0x60004EC")] [Address(RVA = "0x5941670", Offset = "0x5940270", VA = "0x185941670")] [MethodImpl(4096)] get; [Token(Token = "0x60004ED")] [Address(RVA = "0x5941890", Offset = "0x5940490", VA = "0x185941890")] [MethodImpl(4096)] set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004EE RID: 1262
		// (set) Token: 0x060004EF RID: 1263
		[Token(Token = "0x1700013A")]
		public extern Transform[] bones { [Token(Token = "0x60004EE")] [Address(RVA = "0x59415B0", Offset = "0x59401B0", VA = "0x1859415B0")] [MethodImpl(4096)] get; [Token(Token = "0x60004EF")] [Address(RVA = "0x59417B0", Offset = "0x59403B0", VA = "0x1859417B0")] [MethodImpl(4096)] set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004F0 RID: 1264
		// (set) Token: 0x060004F1 RID: 1265
		[Token(Token = "0x1700013B")]
		[NativeProperty("Mesh")]
		public extern Mesh sharedMesh { [Token(Token = "0x60004F0")] [Address(RVA = "0x59416B0", Offset = "0x59402B0", VA = "0x1859416B0")] [MethodImpl(4096)] get; [Token(Token = "0x60004F1")] [Address(RVA = "0x59418E0", Offset = "0x59404E0", VA = "0x1859418E0")] [MethodImpl(4096)] set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004F2 RID: 1266
		// (set) Token: 0x060004F3 RID: 1267
		[Token(Token = "0x1700013C")]
		[NativeProperty("SkinnedMeshMotionVectors")]
		public extern bool skinnedMotionVectors { [Token(Token = "0x60004F2")] [Address(RVA = "0x59416F0", Offset = "0x59402F0", VA = "0x1859416F0")] [MethodImpl(4096)] get; [Token(Token = "0x60004F3")] [Address(RVA = "0x5941930", Offset = "0x5940530", VA = "0x185941930")] [MethodImpl(4096)] set; }

		// Token: 0x060004F4 RID: 1268
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x5941320", Offset = "0x593FF20", VA = "0x185941320")]
		[MethodImpl(4096)]
		public extern float GetBlendShapeWeight(int index);

		// Token: 0x060004F5 RID: 1269
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x5941560", Offset = "0x5940160", VA = "0x185941560")]
		[MethodImpl(4096)]
		public extern void SetBlendShapeWeight(int index, float value);

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x5941270", Offset = "0x593FE70", VA = "0x185941270")]
		public void BakeMesh(Mesh mesh)
		{
		}

		// Token: 0x060004F7 RID: 1271
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x59412C0", Offset = "0x593FEC0", VA = "0x1859412C0")]
		[MethodImpl(4096)]
		public extern void BakeMesh([NotNull("NullExceptionObject")] Mesh mesh, bool useScale);

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x59414A0", Offset = "0x59400A0", VA = "0x1859414A0")]
		public GraphicsBuffer GetVertexBuffer()
		{
			return null;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x59413A0", Offset = "0x593FFA0", VA = "0x1859413A0")]
		public GraphicsBuffer GetPreviousVertexBuffer()
		{
			return null;
		}

		// Token: 0x060004FA RID: 1274
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x5941460", Offset = "0x5940060", VA = "0x185941460")]
		[FreeFunction(Name = "SkinnedMeshRendererScripting::GetVertexBufferPtr", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern GraphicsBuffer GetVertexBufferImpl();

		// Token: 0x060004FB RID: 1275
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x5941360", Offset = "0x593FF60", VA = "0x185941360")]
		[FreeFunction(Name = "SkinnedMeshRendererScripting::GetPreviousVertexBufferPtr", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern GraphicsBuffer GetPreviousVertexBufferImpl();

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004FC RID: 1276
		// (set) Token: 0x060004FD RID: 1277
		[Token(Token = "0x1700013D")]
		public extern GraphicsBuffer.Target vertexBufferTarget { [Token(Token = "0x60004FC")] [Address(RVA = "0x5941770", Offset = "0x5940370", VA = "0x185941770")] [MethodImpl(4096)] get; [Token(Token = "0x60004FD")] [Address(RVA = "0x59419D0", Offset = "0x59405D0", VA = "0x1859419D0")] [MethodImpl(4096)] set; }

		// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public SkinnedMeshRenderer()
		{
		}
	}
}
