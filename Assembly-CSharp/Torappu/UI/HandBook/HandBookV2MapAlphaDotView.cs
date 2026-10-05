using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066F4 RID: 26356
	[Token(Token = "0x20066F4")]
	public class HandBookV2MapAlphaDotView : MaskableGraphic, IHotfixable
	{
		// Token: 0x06025D46 RID: 154950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D46")]
		[Address(RVA = "0x20C35F0", Offset = "0x20C21F0", VA = "0x1820C35F0")]
		public void Render(HexagonDirection direction)
		{
		}

		// Token: 0x06025D47 RID: 154951 RVA: 0x000C92D0 File Offset: 0x000C74D0
		[Token(Token = "0x6025D47")]
		[Address(RVA = "0x20C3660", Offset = "0x20C2260", VA = "0x1820C3660")]
		private Color _GetColor(int i, Color color1, Color color2, Color color3)
		{
			return default(Color);
		}

		// Token: 0x06025D48 RID: 154952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D48")]
		[Address(RVA = "0x20C21A0", Offset = "0x20C0DA0", VA = "0x1820C21A0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06025D49 RID: 154953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D49")]
		[Address(RVA = "0x20C37B0", Offset = "0x20C23B0", VA = "0x1820C37B0")]
		public HandBookV2MapAlphaDotView()
		{
		}

		// Token: 0x06025D4A RID: 154954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D4A")]
		[Address(RVA = "0xDEFAD0", Offset = "0xDEE6D0", VA = "0x180DEFAD0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x040352CF RID: 217807
		[Token(Token = "0x40352CF")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public float backgroudAlpha;

		// Token: 0x040352D0 RID: 217808
		[Token(Token = "0x40352D0")]
		[FieldOffset(Offset = "0xEC")]
		public Color pointColor;

		// Token: 0x040352D1 RID: 217809
		[Token(Token = "0x40352D1")]
		[FieldOffset(Offset = "0xFC")]
		public Color pointColor2;

		// Token: 0x040352D2 RID: 217810
		[Token(Token = "0x40352D2")]
		[FieldOffset(Offset = "0x10C")]
		public float length;

		// Token: 0x040352D3 RID: 217811
		[Token(Token = "0x40352D3")]
		[FieldOffset(Offset = "0x110")]
		public Vector3 initPoint;

		// Token: 0x040352D4 RID: 217812
		[Token(Token = "0x40352D4")]
		[FieldOffset(Offset = "0x11C")]
		public float maxLength;

		// Token: 0x040352D5 RID: 217813
		[Token(Token = "0x40352D5")]
		[FieldOffset(Offset = "0x120")]
		private HexagonDirection m_direction;

		// Token: 0x040352D6 RID: 217814
		[Token(Token = "0x40352D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040352D7 RID: 217815
		[Token(Token = "0x40352D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetColor;

		// Token: 0x040352D8 RID: 217816
		[Token(Token = "0x40352D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x040352D9 RID: 217817
		[Token(Token = "0x40352D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
