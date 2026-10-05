using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public class VertexHelper : IDisposable
	{
		// Token: 0x06000555 RID: 1365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VertexHelper()
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x5B82800", Offset = "0x5B81400", VA = "0x185B82800")]
		public VertexHelper(Mesh m)
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x5B82080", Offset = "0x5B80C80", VA = "0x185B82080")]
		private void InitializeListIfRequired()
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x5B81C30", Offset = "0x5B80830", VA = "0x185B81C30", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x5B81B40", Offset = "0x5B80740", VA = "0x185B81B40")]
		public void Clear()
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x1700016A")]
		public int currentVertCount
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x5B82A80", Offset = "0x5B81680", VA = "0x185B82A80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x1700016B")]
		public int currentIndexCount
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x5B82A40", Offset = "0x5B81640", VA = "0x185B82A40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x5B82260", Offset = "0x5B80E60", VA = "0x185B82260")]
		public void PopulateUIVertex(ref UIVertex vertex, int i)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x5B82420", Offset = "0x5B81020", VA = "0x185B82420")]
		public void SetUIVertex(UIVertex vertex, int i)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x5B81E90", Offset = "0x5B80A90", VA = "0x185B81E90")]
		public void FillMesh(Mesh mesh)
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x5B816F0", Offset = "0x5B802F0", VA = "0x185B816F0")]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent)
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x5B814D0", Offset = "0x5B800D0", VA = "0x185B814D0")]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent)
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x5B812D0", Offset = "0x5B7FED0", VA = "0x185B812D0")]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0)
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x5B81640", Offset = "0x5B80240", VA = "0x185B81640")]
		public void AddVert(UIVertex v)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x5B80DA0", Offset = "0x5B7F9A0", VA = "0x185B80DA0")]
		public void AddTriangle(int idx0, int idx1, int idx2)
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x5B80F10", Offset = "0x5B7FB10", VA = "0x185B80F10")]
		public void AddUIVertexQuad(UIVertex[] verts)
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x5B81190", Offset = "0x5B7FD90", VA = "0x185B81190")]
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x5B81250", Offset = "0x5B7FE50", VA = "0x185B81250")]
		public void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x5B82000", Offset = "0x5B80C00", VA = "0x185B82000")]
		public void GetUIVertexStream(List<UIVertex> stream)
		{
		}

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x10")]
		private List<Vector3> m_Positions;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x18")]
		private List<Color32> m_Colors;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x20")]
		private List<Vector4> m_Uv0S;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x28")]
		private List<Vector4> m_Uv1S;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x30")]
		private List<Vector4> m_Uv2S;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector4> m_Uv3S;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector3> m_Normals;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x48")]
		private List<Vector4> m_Tangents;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x50")]
		private List<int> m_Indices;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector4 s_DefaultTangent;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector3 s_DefaultNormal;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x58")]
		private bool m_ListsInitalized;
	}
}
