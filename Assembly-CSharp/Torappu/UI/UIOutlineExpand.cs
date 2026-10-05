using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003855 RID: 14421
	[Token(Token = "0x2003855")]
	[ExecuteAlways]
	public class UIOutlineExpand : BaseMeshEffect
	{
		// Token: 0x06016D81 RID: 93569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D81")]
		[Address(RVA = "0xF45420", Offset = "0xF44020", VA = "0x180F45420", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06016D82 RID: 93570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D82")]
		[Address(RVA = "0xF45500", Offset = "0xF44100", VA = "0x180F45500", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06016D83 RID: 93571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D83")]
		[Address(RVA = "0xF45630", Offset = "0xF44230", VA = "0x180F45630")]
		private void _ModifyShaderChannels()
		{
		}

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x06016D84 RID: 93572 RVA: 0x00093330 File Offset: 0x00091530
		[Token(Token = "0x1700369A")]
		private bool hasSetMaterial
		{
			[Token(Token = "0x6016D84")]
			[Address(RVA = "0xF46B70", Offset = "0xF45770", VA = "0x180F46B70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06016D85 RID: 93573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D85")]
		[Address(RVA = "0xF46320", Offset = "0xF44F20", VA = "0x180F46320")]
		private void _Refresh()
		{
		}

		// Token: 0x06016D86 RID: 93574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D86")]
		[Address(RVA = "0xF464F0", Offset = "0xF450F0", VA = "0x180F464F0")]
		private void _SaveCurrMatInfo()
		{
		}

		// Token: 0x06016D87 RID: 93575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D87")]
		[Address(RVA = "0xF45440", Offset = "0xF44040", VA = "0x180F45440", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		// Token: 0x06016D88 RID: 93576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D88")]
		[Address(RVA = "0xF457B0", Offset = "0xF443B0", VA = "0x180F457B0")]
		private void _ProcessVertices()
		{
		}

		// Token: 0x06016D89 RID: 93577 RVA: 0x00093348 File Offset: 0x00091548
		[Token(Token = "0x6016D89")]
		[Address(RVA = "0xF46590", Offset = "0xF45190", VA = "0x180F46590")]
		private static UIVertex _SetNewPosAndUV(UIVertex pVertex, int pOutLineWidth, Vector2 pPosCenter, Vector2 pTriangleX, Vector2 pTriangleY, Vector2 pUVX, Vector2 pUVY, Vector4 pUVOrigin)
		{
			return default(UIVertex);
		}

		// Token: 0x06016D8A RID: 93578 RVA: 0x00093360 File Offset: 0x00091560
		[Token(Token = "0x6016D8A")]
		[Address(RVA = "0xF45620", Offset = "0xF44220", VA = "0x180F45620")]
		private static float _Min(float pA, float pB, float pC)
		{
			return 0f;
		}

		// Token: 0x06016D8B RID: 93579 RVA: 0x00093378 File Offset: 0x00091578
		[Token(Token = "0x6016D8B")]
		[Address(RVA = "0xF45510", Offset = "0xF44110", VA = "0x180F45510")]
		private static float _Max(float pA, float pB, float pC)
		{
			return 0f;
		}

		// Token: 0x06016D8C RID: 93580 RVA: 0x00093390 File Offset: 0x00091590
		[Token(Token = "0x6016D8C")]
		[Address(RVA = "0xF455A0", Offset = "0xF441A0", VA = "0x180F455A0")]
		private static Vector2 _Min(Vector2 pA, Vector2 pB, Vector2 pC)
		{
			return default(Vector2);
		}

		// Token: 0x06016D8D RID: 93581 RVA: 0x000933A8 File Offset: 0x000915A8
		[Token(Token = "0x6016D8D")]
		[Address(RVA = "0xF45520", Offset = "0xF44120", VA = "0x180F45520")]
		private static Vector2 _Max(Vector2 pA, Vector2 pB, Vector2 pC)
		{
			return default(Vector2);
		}

		// Token: 0x06016D8E RID: 93582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D8E")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIOutlineExpand()
		{
		}

		// Token: 0x0401B8D3 RID: 112851
		[Token(Token = "0x401B8D3")]
		private const string KEYWORD_USE_SOLID_OUTLINE = "_USE_SOLID_OUTLINE";

		// Token: 0x0401B8D4 RID: 112852
		[Token(Token = "0x401B8D4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] OUTLINE_SHADERS;

		// Token: 0x0401B8D5 RID: 112853
		[Token(Token = "0x401B8D5")]
		[FieldOffset(Offset = "0x20")]
		[Range(1f, 5f)]
		private int m_outlineWidth;

		// Token: 0x0401B8D6 RID: 112854
		[Token(Token = "0x401B8D6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _useSolidOutline;

		// Token: 0x0401B8D7 RID: 112855
		[Token(Token = "0x401B8D7")]
		[FieldOffset(Offset = "0x28")]
		private Material m_currMat;

		// Token: 0x0401B8D8 RID: 112856
		[Token(Token = "0x401B8D8")]
		[FieldOffset(Offset = "0x30")]
		private string m_currShader;

		// Token: 0x0401B8D9 RID: 112857
		[Token(Token = "0x401B8D9")]
		[FieldOffset(Offset = "0x8")]
		private static List<UIVertex> m_VetexList;
	}
}
