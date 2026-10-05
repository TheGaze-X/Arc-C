using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200384E RID: 14414
	[Token(Token = "0x200384E")]
	[ExecuteInEditMode]
	public class UIGradientGraphic : MaskableGraphic, IHotfixable
	{
		// Token: 0x06016D5F RID: 93535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D5F")]
		[Address(RVA = "0xF3FC80", Offset = "0xF3E880", VA = "0x180F3FC80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06016D60 RID: 93536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D60")]
		[Address(RVA = "0xF3FCE0", Offset = "0xF3E8E0", VA = "0x180F3FCE0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06016D61 RID: 93537 RVA: 0x000932B8 File Offset: 0x000914B8
		[Token(Token = "0x6016D61")]
		[Address(RVA = "0xF41CC0", Offset = "0xF408C0", VA = "0x180F41CC0")]
		private Vector2 _GetPost(float x, float y, float xP, float yP)
		{
			return default(Vector2);
		}

		// Token: 0x06016D62 RID: 93538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D62")]
		[Address(RVA = "0xF3FA60", Offset = "0xF3E660", VA = "0x180F3FA60")]
		private void DrawVerticalColoredTape(VertexHelper vh)
		{
		}

		// Token: 0x06016D63 RID: 93539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D63")]
		[Address(RVA = "0xF41580", Offset = "0xF40180", VA = "0x180F41580")]
		private void _DrawVerticalColoredTapeByPoint(VertexHelper vh)
		{
		}

		// Token: 0x06016D64 RID: 93540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D64")]
		[Address(RVA = "0xF40DA0", Offset = "0xF3F9A0", VA = "0x180F40DA0")]
		private void _DrawVerticalColoredTapeByGradient(VertexHelper vh)
		{
		}

		// Token: 0x06016D65 RID: 93541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D65")]
		[Address(RVA = "0xF3F9D0", Offset = "0xF3E5D0", VA = "0x180F3F9D0")]
		private void DrawHorizontalColoredTape(VertexHelper vh)
		{
		}

		// Token: 0x06016D66 RID: 93542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D66")]
		[Address(RVA = "0xF40660", Offset = "0xF3F260", VA = "0x180F40660")]
		private void _DrawHorizontalColoredTapeByPoint(VertexHelper vh)
		{
		}

		// Token: 0x06016D67 RID: 93543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D67")]
		[Address(RVA = "0xF3FE80", Offset = "0xF3EA80", VA = "0x180F3FE80")]
		private void _DrawHorizontalColoredTapeByGradient(VertexHelper vh)
		{
		}

		// Token: 0x06016D68 RID: 93544 RVA: 0x000932D0 File Offset: 0x000914D0
		[Token(Token = "0x6016D68")]
		[Address(RVA = "0xF3FAF0", Offset = "0xF3E6F0", VA = "0x180F3FAF0")]
		public UIVertex GetUIVertex(Vector2 point, Color color0)
		{
			return default(UIVertex);
		}

		// Token: 0x06016D69 RID: 93545 RVA: 0x000932E8 File Offset: 0x000914E8
		[Token(Token = "0x6016D69")]
		[Address(RVA = "0xF41DF0", Offset = "0xF409F0", VA = "0x180F41DF0")]
		private bool _UseGradient()
		{
			return default(bool);
		}

		// Token: 0x06016D6A RID: 93546 RVA: 0x00093300 File Offset: 0x00091500
		[Token(Token = "0x6016D6A")]
		[Address(RVA = "0xF41D90", Offset = "0xF40990", VA = "0x180F41D90")]
		private bool _UseColorPoint()
		{
			return default(bool);
		}

		// Token: 0x06016D6B RID: 93547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D6B")]
		[Address(RVA = "0xF41E50", Offset = "0xF40A50", VA = "0x180F41E50")]
		public UIGradientGraphic()
		{
		}

		// Token: 0x06016D6C RID: 93548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D6C")]
		[Address(RVA = "0xDEFAC0", Offset = "0xDEE6C0", VA = "0x180DEFAC0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06016D6D RID: 93549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D6D")]
		[Address(RVA = "0xDEFAD0", Offset = "0xDEE6D0", VA = "0x180DEFAD0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x0401B89F RID: 112799
		[Token(Token = "0x401B89F")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool _useGradient;

		// Token: 0x0401B8A0 RID: 112800
		[Token(Token = "0x401B8A0")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private UIGradientGraphic.DrawDirection _tapeDirection;

		// Token: 0x0401B8A1 RID: 112801
		[Token(Token = "0x401B8A1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Inspect("_UseColorPoint")]
		private List<UIGradientGraphic.ColorPoint> _colorPoints;

		// Token: 0x0401B8A2 RID: 112802
		[Token(Token = "0x401B8A2")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Inspect("_UseGradient")]
		private Gradient _gradient;

		// Token: 0x0401B8A3 RID: 112803
		[Token(Token = "0x401B8A3")]
		[FieldOffset(Offset = "0x100")]
		private Vector2 m_rectSize;

		// Token: 0x0401B8A4 RID: 112804
		[Token(Token = "0x401B8A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401B8A5 RID: 112805
		[Token(Token = "0x401B8A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x0401B8A6 RID: 112806
		[Token(Token = "0x401B8A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPost;

		// Token: 0x0401B8A7 RID: 112807
		[Token(Token = "0x401B8A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DrawVerticalColoredTape;

		// Token: 0x0401B8A8 RID: 112808
		[Token(Token = "0x401B8A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DrawVerticalColoredTapeByPoint;

		// Token: 0x0401B8A9 RID: 112809
		[Token(Token = "0x401B8A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DrawVerticalColoredTapeByGradient;

		// Token: 0x0401B8AA RID: 112810
		[Token(Token = "0x401B8AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DrawHorizontalColoredTape;

		// Token: 0x0401B8AB RID: 112811
		[Token(Token = "0x401B8AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DrawHorizontalColoredTapeByPoint;

		// Token: 0x0401B8AC RID: 112812
		[Token(Token = "0x401B8AC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DrawHorizontalColoredTapeByGradient;

		// Token: 0x0401B8AD RID: 112813
		[Token(Token = "0x401B8AD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetUIVertex;

		// Token: 0x0401B8AE RID: 112814
		[Token(Token = "0x401B8AE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UseGradient;

		// Token: 0x0401B8AF RID: 112815
		[Token(Token = "0x401B8AF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UseColorPoint;

		// Token: 0x0401B8B0 RID: 112816
		[Token(Token = "0x401B8B0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200384F RID: 14415
		[Token(Token = "0x200384F")]
		public enum DrawDirection
		{
			// Token: 0x0401B8B2 RID: 112818
			[Token(Token = "0x401B8B2")]
			Vertical,
			// Token: 0x0401B8B3 RID: 112819
			[Token(Token = "0x401B8B3")]
			Horizontal
		}

		// Token: 0x02003850 RID: 14416
		[Token(Token = "0x2003850")]
		[Serializable]
		public class ColorPoint
		{
			// Token: 0x06016D6E RID: 93550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016D6E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ColorPoint()
			{
			}

			// Token: 0x0401B8B4 RID: 112820
			[Token(Token = "0x401B8B4")]
			[FieldOffset(Offset = "0x10")]
			public Color color;

			// Token: 0x0401B8B5 RID: 112821
			[Token(Token = "0x401B8B5")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("0 - left/bottom, 1 - right/head")]
			public float point;
		}
	}
}
