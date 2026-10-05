using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005283 RID: 21123
	[Token(Token = "0x2005283")]
	public class RoguelikeCurve : MaskableGraphic, IHotfixable
	{
		// Token: 0x17004908 RID: 18696
		// (get) Token: 0x0601F2A4 RID: 127652 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F2A5 RID: 127653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004908")]
		public RectTransform startNode
		{
			[Token(Token = "0x601F2A4")]
			[Address(RVA = "0x18E9030", Offset = "0x18E7C30", VA = "0x1818E9030")]
			get
			{
				return null;
			}
			[Token(Token = "0x601F2A5")]
			[Address(RVA = "0x18E9290", Offset = "0x18E7E90", VA = "0x1818E9290")]
			set
			{
			}
		}

		// Token: 0x17004909 RID: 18697
		// (get) Token: 0x0601F2A6 RID: 127654 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F2A7 RID: 127655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004909")]
		public RectTransform endNode
		{
			[Token(Token = "0x601F2A6")]
			[Address(RVA = "0x18E8F50", Offset = "0x18E7B50", VA = "0x1818E8F50")]
			get
			{
				return null;
			}
			[Token(Token = "0x601F2A7")]
			[Address(RVA = "0x18E9170", Offset = "0x18E7D70", VA = "0x1818E9170")]
			set
			{
			}
		}

		// Token: 0x1700490A RID: 18698
		// (get) Token: 0x0601F2A8 RID: 127656 RVA: 0x000B1108 File Offset: 0x000AF308
		// (set) Token: 0x0601F2A9 RID: 127657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700490A")]
		public bool useClipColor
		{
			[Token(Token = "0x601F2A8")]
			[Address(RVA = "0x18E9090", Offset = "0x18E7C90", VA = "0x1818E9090")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601F2A9")]
			[Address(RVA = "0x18E9330", Offset = "0x18E7F30", VA = "0x1818E9330")]
			set
			{
			}
		}

		// Token: 0x1700490B RID: 18699
		// (get) Token: 0x0601F2AA RID: 127658 RVA: 0x000B1120 File Offset: 0x000AF320
		// (set) Token: 0x0601F2AB RID: 127659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700490B")]
		public Color clipColor
		{
			[Token(Token = "0x601F2AA")]
			[Address(RVA = "0x18E8ED0", Offset = "0x18E7AD0", VA = "0x1818E8ED0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x601F2AB")]
			[Address(RVA = "0x18E90F0", Offset = "0x18E7CF0", VA = "0x1818E90F0")]
			set
			{
			}
		}

		// Token: 0x1700490C RID: 18700
		// (get) Token: 0x0601F2AC RID: 127660 RVA: 0x000B1138 File Offset: 0x000AF338
		// (set) Token: 0x0601F2AD RID: 127661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700490C")]
		public Color reflectColor
		{
			[Token(Token = "0x601F2AC")]
			[Address(RVA = "0x18E8FB0", Offset = "0x18E7BB0", VA = "0x1818E8FB0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x601F2AD")]
			[Address(RVA = "0x18E9210", Offset = "0x18E7E10", VA = "0x1818E9210")]
			set
			{
			}
		}

		// Token: 0x0601F2AE RID: 127662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2AE")]
		[Address(RVA = "0x18E6D40", Offset = "0x18E5940", VA = "0x1818E6D40", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x0601F2AF RID: 127663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2AF")]
		[Address(RVA = "0x18E82A0", Offset = "0x18E6EA0", VA = "0x1818E82A0")]
		private void _GenerateCurve()
		{
		}

		// Token: 0x0601F2B0 RID: 127664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2B0")]
		[Address(RVA = "0x18E8D70", Offset = "0x18E7970", VA = "0x1818E8D70")]
		public RoguelikeCurve()
		{
		}

		// Token: 0x0601F2B1 RID: 127665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F2B1")]
		[Address(RVA = "0xDEFAD0", Offset = "0xDEE6D0", VA = "0x180DEFAD0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x04029D26 RID: 171302
		[Token(Token = "0x4029D26")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform _startNode;

		// Token: 0x04029D27 RID: 171303
		[Token(Token = "0x4029D27")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _endNode;

		// Token: 0x04029D28 RID: 171304
		[Token(Token = "0x4029D28")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Vector2 _startPosOffset;

		// Token: 0x04029D29 RID: 171305
		[Token(Token = "0x4029D29")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Vector2 _endPosOffset;

		// Token: 0x04029D2A RID: 171306
		[Token(Token = "0x4029D2A")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private int _segment;

		// Token: 0x04029D2B RID: 171307
		[Token(Token = "0x4029D2B")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private float _width;

		// Token: 0x04029D2C RID: 171308
		[Token(Token = "0x4029D2C")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float _degreeX;

		// Token: 0x04029D2D RID: 171309
		[Token(Token = "0x4029D2D")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private float _degreeY;

		// Token: 0x04029D2E RID: 171310
		[Token(Token = "0x4029D2E")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _startRoundCorner;

		// Token: 0x04029D2F RID: 171311
		[Token(Token = "0x4029D2F")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _endRoundCorner;

		// Token: 0x04029D30 RID: 171312
		[Token(Token = "0x4029D30")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _useClipColor;

		// Token: 0x04029D31 RID: 171313
		[Token(Token = "0x4029D31")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _clipRatio;

		// Token: 0x04029D32 RID: 171314
		[Token(Token = "0x4029D32")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Color _clipColor;

		// Token: 0x04029D33 RID: 171315
		[Token(Token = "0x4029D33")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float _reflectOffsetY;

		// Token: 0x04029D34 RID: 171316
		[Token(Token = "0x4029D34")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private float _reflectWidthRatio;

		// Token: 0x04029D35 RID: 171317
		[Token(Token = "0x4029D35")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Color _reflectColor;

		// Token: 0x04029D36 RID: 171318
		[Token(Token = "0x4029D36")]
		[FieldOffset(Offset = "0x150")]
		private List<Vector3> m_vertices;

		// Token: 0x04029D37 RID: 171319
		[Token(Token = "0x4029D37")]
		[FieldOffset(Offset = "0x158")]
		private List<int> m_tris;

		// Token: 0x04029D38 RID: 171320
		[Token(Token = "0x4029D38")]
		[FieldOffset(Offset = "0x160")]
		private Vector3 m_startPos;

		// Token: 0x04029D39 RID: 171321
		[Token(Token = "0x4029D39")]
		[FieldOffset(Offset = "0x16C")]
		private Vector3 m_endPos;

		// Token: 0x04029D3A RID: 171322
		[Token(Token = "0x4029D3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_startNode;

		// Token: 0x04029D3B RID: 171323
		[Token(Token = "0x4029D3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_startNode;

		// Token: 0x04029D3C RID: 171324
		[Token(Token = "0x4029D3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_endNode;

		// Token: 0x04029D3D RID: 171325
		[Token(Token = "0x4029D3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_endNode;

		// Token: 0x04029D3E RID: 171326
		[Token(Token = "0x4029D3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_useClipColor;

		// Token: 0x04029D3F RID: 171327
		[Token(Token = "0x4029D3F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_useClipColor;

		// Token: 0x04029D40 RID: 171328
		[Token(Token = "0x4029D40")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_clipColor;

		// Token: 0x04029D41 RID: 171329
		[Token(Token = "0x4029D41")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_clipColor;

		// Token: 0x04029D42 RID: 171330
		[Token(Token = "0x4029D42")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_reflectColor;

		// Token: 0x04029D43 RID: 171331
		[Token(Token = "0x4029D43")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_reflectColor;

		// Token: 0x04029D44 RID: 171332
		[Token(Token = "0x4029D44")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x04029D45 RID: 171333
		[Token(Token = "0x4029D45")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenerateCurve;

		// Token: 0x04029D46 RID: 171334
		[Token(Token = "0x4029D46")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
