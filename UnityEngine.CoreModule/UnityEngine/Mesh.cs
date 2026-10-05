using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[RequiredByNativeCode]
	public sealed class Mesh : Object
	{
		// Token: 0x06000505 RID: 1285
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x5933330", Offset = "0x5931F30", VA = "0x185933330")]
		[FreeFunction("MeshScripting::CreateMesh")]
		[MethodImpl(4096)]
		private static extern void Internal_Create([Writable] Mesh mono);

		// Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x5935310", Offset = "0x5933F10", VA = "0x185935310")]
		[RequiredByNativeCode]
		public Mesh()
		{
		}

		// Token: 0x06000507 RID: 1287
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x5932590", Offset = "0x5931190", VA = "0x185932590")]
		[FreeFunction("MeshScripting::MeshFromInstanceId")]
		[MethodImpl(4096)]
		internal static extern Mesh FromInstanceID(int id);

		// Token: 0x06000508 RID: 1288
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x5933110", Offset = "0x5931D10", VA = "0x185933110")]
		[FreeFunction(Name = "MeshScripting::GetVertexAttributesCount", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern int GetVertexAttributeCountImpl();

		// Token: 0x06000509 RID: 1289 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x59331A0", Offset = "0x5931DA0", VA = "0x1859331A0")]
		[FreeFunction(Name = "MeshScripting::GetVertexAttributeByIndex", HasExplicitThis = true, ThrowsException = true)]
		public VertexAttributeDescriptor GetVertexAttribute(int index)
		{
			return default(VertexAttributeDescriptor);
		}

		// Token: 0x0600050A RID: 1290
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x5932B00", Offset = "0x5931700", VA = "0x185932B00")]
		[FreeFunction(Name = "MeshScripting::GetTrianglesCount", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern uint GetTrianglesCountImpl(int submesh);

		// Token: 0x0600050B RID: 1291
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x5932B40", Offset = "0x5931740", VA = "0x185932B40")]
		[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern int[] GetTrianglesImpl(int submesh, bool applyBaseVertex);

		// Token: 0x0600050C RID: 1292
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x5932790", Offset = "0x5931390", VA = "0x185932790")]
		[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern int[] GetIndicesImpl(int submesh, bool applyBaseVertex);

		// Token: 0x0600050D RID: 1293
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x5933E70", Offset = "0x5932A70", VA = "0x185933E70")]
		[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);

		// Token: 0x0600050E RID: 1294
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x5932BA0", Offset = "0x59317A0", VA = "0x185932BA0")]
		[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void GetTrianglesNonAllocImpl([Out] int[] values, int submesh, bool applyBaseVertex);

		// Token: 0x0600050F RID: 1295
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x5933420", Offset = "0x5932020", VA = "0x185933420")]
		[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void PrintErrorCantAccessChannel(VertexAttribute ch);

		// Token: 0x06000510 RID: 1296
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x59332F0", Offset = "0x5931EF0", VA = "0x1859332F0")]
		[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern bool HasVertexAttribute(VertexAttribute attr);

		// Token: 0x06000511 RID: 1297
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x5933AB0", Offset = "0x59326B0", VA = "0x185933AB0")]
		[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags);

		// Token: 0x06000512 RID: 1298
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x59325D0", Offset = "0x59311D0", VA = "0x1859325D0")]
		[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim);

		// Token: 0x06000513 RID: 1299
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x5932630", Offset = "0x5931230", VA = "0x185932630")]
		[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values);

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000514 RID: 1300
		[Token(Token = "0x17000140")]
		internal extern bool canAccess { [Token(Token = "0x6000514")] [Address(RVA = "0x5935430", Offset = "0x5934030", VA = "0x185935430")] [NativeMethod("CanAccessFromScript")] [MethodImpl(4096)] get; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000515 RID: 1301
		[Token(Token = "0x17000141")]
		public extern int vertexCount { [Token(Token = "0x6000515")] [Address(RVA = "0x5935660", Offset = "0x5934260", VA = "0x185935660")] [NativeMethod("GetVertexCount")] [MethodImpl(4096)] get; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000516 RID: 1302
		// (set) Token: 0x06000517 RID: 1303
		[Token(Token = "0x17000142")]
		public extern int subMeshCount { [Token(Token = "0x6000516")] [Address(RVA = "0x5935500", Offset = "0x5934100", VA = "0x185935500")] [NativeMethod(Name = "GetSubMeshCount")] [MethodImpl(4096)] get; [Token(Token = "0x6000517")] [Address(RVA = "0x59358B0", Offset = "0x59344B0", VA = "0x1859358B0")] [FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = true)] [MethodImpl(4096)] set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00003480 File Offset: 0x00001680
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000143")]
		public Bounds bounds
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x59353D0", Offset = "0x5933FD0", VA = "0x1859353D0")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x5935730", Offset = "0x5934330", VA = "0x185935730")]
			set
			{
			}
		}

		// Token: 0x0600051A RID: 1306
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x5932350", Offset = "0x5930F50", VA = "0x185932350")]
		[NativeMethod("Clear")]
		[MethodImpl(4096)]
		private extern void ClearImpl(bool keepVertexLayout);

		// Token: 0x0600051B RID: 1307
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x59334E0", Offset = "0x59320E0", VA = "0x1859334E0")]
		[NativeMethod("RecalculateBounds")]
		[MethodImpl(4096)]
		private extern void RecalculateBoundsImpl(MeshUpdateFlags flags);

		// Token: 0x0600051C RID: 1308
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x59336D0", Offset = "0x59322D0", VA = "0x1859336D0")]
		[NativeMethod("RecalculateNormals")]
		[MethodImpl(4096)]
		private extern void RecalculateNormalsImpl(MeshUpdateFlags flags);

		// Token: 0x0600051D RID: 1309
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x59338C0", Offset = "0x59324C0", VA = "0x1859338C0")]
		[NativeMethod("RecalculateTangents")]
		[MethodImpl(4096)]
		private extern void RecalculateTangentsImpl(MeshUpdateFlags flags);

		// Token: 0x0600051E RID: 1310
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x5933370", Offset = "0x5931F70", VA = "0x185933370")]
		[NativeMethod("MarkDynamic")]
		[MethodImpl(4096)]
		private extern void MarkDynamicImpl();

		// Token: 0x0600051F RID: 1311
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x5935250", Offset = "0x5933E50", VA = "0x185935250")]
		[NativeMethod("UploadMeshData")]
		[MethodImpl(4096)]
		private extern void UploadMeshDataImpl(bool markNoLongerReadable);

		// Token: 0x06000520 RID: 1312
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x59323E0", Offset = "0x5930FE0", VA = "0x1859323E0")]
		[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = true, ThrowsException = true, HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);

		// Token: 0x06000521 RID: 1313 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x5932FA0", Offset = "0x5931BA0", VA = "0x185932FA0")]
		internal static VertexAttribute GetUVChannel(int uvIndex)
		{
			return VertexAttribute.Position;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x59324D0", Offset = "0x59310D0", VA = "0x1859324D0")]
		internal static int DefaultDimensionForChannel(VertexAttribute channel)
		{
			return 0;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000523")]
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim)
		{
			return null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000524")]
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel)
		{
			return null;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x5934280", Offset = "0x5932E80", VA = "0x185934280")]
		private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000526")]
		private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000527")]
		private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000528")]
		private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000529")]
		private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052A")]
		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim)
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052B")]
		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType)
		{
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000144")]
		public Vector3[] vertices
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x59356A0", Offset = "0x59342A0", VA = "0x1859356A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x5935B60", Offset = "0x5934760", VA = "0x185935B60")]
			set
			{
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000145")]
		public Vector3[] normals
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x59354C0", Offset = "0x59340C0", VA = "0x1859354C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x5935850", Offset = "0x5934450", VA = "0x185935850")]
			set
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000146")]
		public Vector4[] tangents
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x5935540", Offset = "0x5934140", VA = "0x185935540")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x59358F0", Offset = "0x59344F0", VA = "0x1859358F0")]
			set
			{
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000147")]
		public Vector2[] uv
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x5935620", Offset = "0x5934220", VA = "0x185935620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x5935B00", Offset = "0x5934700", VA = "0x185935B00")]
			set
			{
			}
		}

		// Token: 0x17000148 RID: 328
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000148")]
		public Vector2[] uv2
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x5935A40", Offset = "0x5934640", VA = "0x185935A40")]
			set
			{
			}
		}

		// Token: 0x17000149 RID: 329
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000149")]
		public Vector2[] uv3
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x5935AA0", Offset = "0x59346A0", VA = "0x185935AA0")]
			set
			{
			}
		}

		// Token: 0x1700014A RID: 330
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014A")]
		public Color[] colors
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x59357F0", Offset = "0x59343F0", VA = "0x1859357F0")]
			set
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014B")]
		public Color32[] colors32
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x5935470", Offset = "0x5934070", VA = "0x185935470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x5935780", Offset = "0x5934380", VA = "0x185935780")]
			set
			{
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x5933200", Offset = "0x5931E00", VA = "0x185933200")]
		public void GetVertices(List<Vector3> vertices)
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x59351B0", Offset = "0x5933DB0", VA = "0x1859351B0")]
		public void SetVertices(List<Vector3> inVertices)
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x5935130", Offset = "0x5933D30", VA = "0x185935130")]
		[ExcludeFromDocs]
		public void SetVertices(List<Vector3> inVertices, int start, int length)
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x59350B0", Offset = "0x5933CB0", VA = "0x1859350B0")]
		public void SetVertices(List<Vector3> inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x5932920", Offset = "0x5931520", VA = "0x185932920")]
		public void GetNormals(List<Vector3> normals)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x59341E0", Offset = "0x5932DE0", VA = "0x1859341E0")]
		public void SetNormals(List<Vector3> inNormals)
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x5934160", Offset = "0x5932D60", VA = "0x185934160")]
		[ExcludeFromDocs]
		public void SetNormals(List<Vector3> inNormals, int start, int length)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x59340E0", Offset = "0x5932CE0", VA = "0x1859340E0")]
		public void SetNormals(List<Vector3> inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x5932A10", Offset = "0x5931610", VA = "0x185932A10")]
		public void GetTangents(List<Vector4> tangents)
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x5934600", Offset = "0x5933200", VA = "0x185934600")]
		public void SetTangents(List<Vector4> inTangents)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x5934720", Offset = "0x5933320", VA = "0x185934720")]
		[ExcludeFromDocs]
		public void SetTangents(List<Vector4> inTangents, int start, int length)
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x59346A0", Offset = "0x59332A0", VA = "0x1859346A0")]
		public void SetTangents(List<Vector4> inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x5933DD0", Offset = "0x59329D0", VA = "0x185933DD0")]
		public void SetColors(List<Color> inColors)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x5933BA0", Offset = "0x59327A0", VA = "0x185933BA0")]
		[ExcludeFromDocs]
		public void SetColors(List<Color> inColors, int start, int length)
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x5933CC0", Offset = "0x59328C0", VA = "0x185933CC0")]
		public void SetColors(List<Color> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x5932690", Offset = "0x5931290", VA = "0x185932690")]
		public void GetColors(List<Color32> colors)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x5933C20", Offset = "0x5932820", VA = "0x185933C20")]
		public void SetColors(List<Color32> inColors)
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x5933D40", Offset = "0x5932940", VA = "0x185933D40")]
		[ExcludeFromDocs]
		public void SetColors(List<Color32> inColors, int start, int length)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x5933B10", Offset = "0x5932710", VA = "0x185933B10")]
		public void SetColors(List<Color32> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054C")]
		private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x5934DA0", Offset = "0x59339A0", VA = "0x185934DA0")]
		public void SetUVs(int channel, List<Vector2> uvs)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x5934F70", Offset = "0x5933B70", VA = "0x185934F70")]
		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x5934EE0", Offset = "0x5933AE0", VA = "0x185934EE0")]
		[ExcludeFromDocs]
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length)
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x5935020", Offset = "0x5933C20", VA = "0x185935020")]
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x5934E50", Offset = "0x5933A50", VA = "0x185934E50")]
		[ExcludeFromDocs]
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length)
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x5934D10", Offset = "0x5933910", VA = "0x185934D10")]
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000553")]
		private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x59330A0", Offset = "0x5931CA0", VA = "0x1859330A0")]
		public void GetUVs(int channel, List<Vector2> uvs)
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x5933030", Offset = "0x5931C30", VA = "0x185933030")]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x1700014C")]
		public int vertexAttributeCount
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x5933110", Offset = "0x5931D10", VA = "0x185933110")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x5933460", Offset = "0x5932060", VA = "0x185933460")]
		private void PrintErrorCantAccessIndices()
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x5931F80", Offset = "0x5930B80", VA = "0x185931F80")]
		private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			return default(bool);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x5931F70", Offset = "0x5930B70", VA = "0x185931F70")]
		private bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			return default(bool);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x5931F60", Offset = "0x5930B60", VA = "0x185931F60")]
		private bool CheckCanAccessSubmeshIndices(int submesh)
		{
			return default(bool);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014D")]
		public int[] triangles
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x5935580", Offset = "0x5934180", VA = "0x185935580")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x5935950", Offset = "0x5934550", VA = "0x185935950")]
			set
			{
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x5932DE0", Offset = "0x59319E0", VA = "0x185932DE0")]
		public void GetTriangles(List<int> triangles, int submesh)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x5932C10", Offset = "0x5931810", VA = "0x185932C10")]
		public void GetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool applyBaseVertex)
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x59327F0", Offset = "0x59313F0", VA = "0x1859327F0")]
		[ExcludeFromDocs]
		public int[] GetIndices(int submesh)
		{
			return null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x5932880", Offset = "0x5931480", VA = "0x185932880")]
		public int[] GetIndices(int submesh, [DefaultValue("true")] bool applyBaseVertex)
		{
			return null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x59320C0", Offset = "0x5930CC0", VA = "0x1859320C0")]
		private void CheckIndicesArrayRange(int valuesLength, int start, int length)
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x59347A0", Offset = "0x59333A0", VA = "0x1859347A0")]
		private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x5934940", Offset = "0x5933540", VA = "0x185934940")]
		[ExcludeFromDocs]
		public void SetTriangles(int[] triangles, int submesh, bool calculateBounds)
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x59349E0", Offset = "0x59335E0", VA = "0x1859349E0")]
		public void SetTriangles(int[] triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x5934C70", Offset = "0x5933870", VA = "0x185934C70")]
		public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x5934B80", Offset = "0x5933780", VA = "0x185934B80")]
		[ExcludeFromDocs]
		public void SetTriangles(List<int> triangles, int submesh)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x5934A90", Offset = "0x5933690", VA = "0x185934A90")]
		public void SetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x5934860", Offset = "0x5933460", VA = "0x185934860")]
		public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x5933FB0", Offset = "0x5932BB0", VA = "0x185933FB0")]
		[ExcludeFromDocs]
		public void SetIndices(int[] indices, MeshTopology topology, int submesh)
		{
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x59340B0", Offset = "0x5932CB0", VA = "0x1859340B0")]
		[ExcludeFromDocs]
		public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x5933FD0", Offset = "0x5932BD0", VA = "0x185933FD0")]
		public void SetIndices(int[] indices, MeshTopology topology, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x5933EE0", Offset = "0x5932AE0", VA = "0x185933EE0")]
		public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x5932350", Offset = "0x5930F50", VA = "0x185932350")]
		public void Clear([DefaultValue("true")] bool keepVertexLayout)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x59323A0", Offset = "0x5930FA0", VA = "0x1859323A0")]
		[ExcludeFromDocs]
		public void Clear()
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x5933520", Offset = "0x5932120", VA = "0x185933520")]
		[ExcludeFromDocs]
		public void RecalculateBounds()
		{
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x5933710", Offset = "0x5932310", VA = "0x185933710")]
		[ExcludeFromDocs]
		public void RecalculateNormals()
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x5933900", Offset = "0x5932500", VA = "0x185933900")]
		[ExcludeFromDocs]
		public void RecalculateTangents()
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x59335F0", Offset = "0x59321F0", VA = "0x1859335F0")]
		public void RecalculateBounds([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x59337E0", Offset = "0x59323E0", VA = "0x1859337E0")]
		public void RecalculateNormals([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x59339D0", Offset = "0x59325D0", VA = "0x1859339D0")]
		public void RecalculateTangents([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x59333B0", Offset = "0x5931FB0", VA = "0x1859333B0")]
		public void MarkDynamic()
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x59352A0", Offset = "0x5933EA0", VA = "0x1859352A0")]
		public void UploadMeshData(bool markNoLongerReadable)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x5932460", Offset = "0x5931060", VA = "0x185932460")]
		[ExcludeFromDocs]
		public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices)
		{
		}

		// Token: 0x06000578 RID: 1400
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x5933150", Offset = "0x5931D50", VA = "0x185933150")]
		[MethodImpl(4096)]
		private extern void GetVertexAttribute_Injected(int index, out VertexAttributeDescriptor ret);

		// Token: 0x06000579 RID: 1401
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x5935380", Offset = "0x5933F80", VA = "0x185935380")]
		[MethodImpl(4096)]
		private extern void get_bounds_Injected(out Bounds ret);

		// Token: 0x0600057A RID: 1402
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x59356E0", Offset = "0x59342E0", VA = "0x1859356E0")]
		[MethodImpl(4096)]
		private extern void set_bounds_Injected(ref Bounds value);

		// Token: 0x020000B8 RID: 184
		[Token(Token = "0x20000B8")]
		[StaticAccessor("MeshDataBindings", StaticAccessorType.DoubleColon)]
		[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
		public struct MeshData
		{
			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[NativeDisableUnsafePtrRestriction]
			internal IntPtr m_Ptr;
		}
	}
}
