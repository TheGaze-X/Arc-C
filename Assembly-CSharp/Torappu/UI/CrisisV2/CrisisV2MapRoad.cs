using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059B8 RID: 22968
	[Token(Token = "0x20059B8")]
	public class CrisisV2MapRoad : MaskableGraphic, IHotfixable
	{
		// Token: 0x17004EB3 RID: 20147
		// (get) Token: 0x060217A6 RID: 137126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004EB3")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60217A6")]
			[Address(RVA = "0x1BD8DA0", Offset = "0x1BD79A0", VA = "0x181BD8DA0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x060217A7 RID: 137127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217A7")]
		[Address(RVA = "0x1BD7310", Offset = "0x1BD5F10", VA = "0x181BD7310")]
		public void ClearRoadData()
		{
		}

		// Token: 0x060217A8 RID: 137128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217A8")]
		[Address(RVA = "0x1BD7630", Offset = "0x1BD6230", VA = "0x181BD7630")]
		public void SetRoadData(Vector2 srcPos, Vector2 dstPos, List<CrisisV2MapRoadInflectionData> cornerPosList, float width)
		{
		}

		// Token: 0x060217A9 RID: 137129 RVA: 0x000BA648 File Offset: 0x000B8848
		[Token(Token = "0x60217A9")]
		[Address(RVA = "0x1BD8950", Offset = "0x1BD7550", VA = "0x181BD8950")]
		public float _GetRadianOfVec(Vector2 vec)
		{
			return 0f;
		}

		// Token: 0x060217AA RID: 137130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217AA")]
		[Address(RVA = "0x1BD73E0", Offset = "0x1BD5FE0", VA = "0x181BD73E0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x060217AB RID: 137131 RVA: 0x000BA660 File Offset: 0x000B8860
		[Token(Token = "0x60217AB")]
		[Address(RVA = "0x1BD8300", Offset = "0x1BD6F00", VA = "0x181BD8300")]
		private int _DrawLine(VertexHelper vh, Vector2 p1, Vector2 p2, int vertIndex)
		{
			return 0;
		}

		// Token: 0x060217AC RID: 137132 RVA: 0x000BA678 File Offset: 0x000B8878
		[Token(Token = "0x60217AC")]
		[Address(RVA = "0x1BD7BA0", Offset = "0x1BD67A0", VA = "0x181BD7BA0")]
		private int _DrawArc(VertexHelper vh, CrisisV2MapRoad.ArcData arcData, int vertIndex)
		{
			return 0;
		}

		// Token: 0x060217AD RID: 137133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217AD")]
		[Address(RVA = "0x1BD8C70", Offset = "0x1BD7870", VA = "0x181BD8C70")]
		public CrisisV2MapRoad()
		{
		}

		// Token: 0x060217AF RID: 137135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217AF")]
		[Address(RVA = "0xDEFAF0", Offset = "0xDEE6F0", VA = "0x180DEFAF0")]
		private Texture <>xLuaBaseProxy_get_mainTexture()
		{
			return null;
		}

		// Token: 0x060217B0 RID: 137136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217B0")]
		[Address(RVA = "0xDEFAD0", Offset = "0xDEE6D0", VA = "0x180DEFAD0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x0402DBAB RID: 187307
		[Token(Token = "0x402DBAB")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _segmentPerUnit;

		// Token: 0x0402DBAC RID: 187308
		[Token(Token = "0x402DBAC")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Texture2D _texture;

		// Token: 0x0402DBAD RID: 187309
		[Token(Token = "0x402DBAD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 s_innerUV;

		// Token: 0x0402DBAE RID: 187310
		[Token(Token = "0x402DBAE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 s_outerUV;

		// Token: 0x0402DBAF RID: 187311
		[Token(Token = "0x402DBAF")]
		[FieldOffset(Offset = "0xF8")]
		private List<Vector2> m_linePosList;

		// Token: 0x0402DBB0 RID: 187312
		[Token(Token = "0x402DBB0")]
		[FieldOffset(Offset = "0x100")]
		private List<CrisisV2MapRoad.ArcData> m_arcList;

		// Token: 0x0402DBB1 RID: 187313
		[Token(Token = "0x402DBB1")]
		[FieldOffset(Offset = "0x108")]
		private float m_lineWidth;

		// Token: 0x0402DBB2 RID: 187314
		[Token(Token = "0x402DBB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mainTexture;

		// Token: 0x0402DBB3 RID: 187315
		[Token(Token = "0x402DBB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClearRoadData;

		// Token: 0x0402DBB4 RID: 187316
		[Token(Token = "0x402DBB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetRoadData;

		// Token: 0x0402DBB5 RID: 187317
		[Token(Token = "0x402DBB5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetRadianOfVec;

		// Token: 0x0402DBB6 RID: 187318
		[Token(Token = "0x402DBB6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x0402DBB7 RID: 187319
		[Token(Token = "0x402DBB7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DrawLine;

		// Token: 0x0402DBB8 RID: 187320
		[Token(Token = "0x402DBB8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DrawArc;

		// Token: 0x0402DBB9 RID: 187321
		[Token(Token = "0x402DBB9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020059B9 RID: 22969
		[Token(Token = "0x20059B9")]
		private struct ArcData
		{
			// Token: 0x0402DBBA RID: 187322
			[Token(Token = "0x402DBBA")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 center;

			// Token: 0x0402DBBB RID: 187323
			[Token(Token = "0x402DBBB")]
			[FieldOffset(Offset = "0x8")]
			public float radius;

			// Token: 0x0402DBBC RID: 187324
			[Token(Token = "0x402DBBC")]
			[FieldOffset(Offset = "0xC")]
			public float startRadian;

			// Token: 0x0402DBBD RID: 187325
			[Token(Token = "0x402DBBD")]
			[FieldOffset(Offset = "0x10")]
			public float endRadian;
		}
	}
}
