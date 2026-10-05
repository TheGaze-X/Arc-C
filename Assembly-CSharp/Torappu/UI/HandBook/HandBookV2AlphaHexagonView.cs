using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066F3 RID: 26355
	[Token(Token = "0x20066F3")]
	public class HandBookV2AlphaHexagonView : MaskableGraphic, IHotfixable
	{
		// Token: 0x06025D43 RID: 154947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D43")]
		[Address(RVA = "0x20BE950", Offset = "0x20BD550", VA = "0x1820BE950", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06025D44 RID: 154948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D44")]
		[Address(RVA = "0x20BEF90", Offset = "0x20BDB90", VA = "0x1820BEF90")]
		public HandBookV2AlphaHexagonView()
		{
		}

		// Token: 0x06025D45 RID: 154949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D45")]
		[Address(RVA = "0xDEFAD0", Offset = "0xDEE6D0", VA = "0x180DEFAD0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x040352C8 RID: 217800
		[Token(Token = "0x40352C8")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public Color pointColor;

		// Token: 0x040352C9 RID: 217801
		[Token(Token = "0x40352C9")]
		[FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		public float backgroudAlpha;

		// Token: 0x040352CA RID: 217802
		[Token(Token = "0x40352CA")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[FormerlySerializedAs("length")]
		private float _length;

		// Token: 0x040352CB RID: 217803
		[Token(Token = "0x40352CB")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[FormerlySerializedAs("initPoint")]
		private Vector3 _initPoint;

		// Token: 0x040352CC RID: 217804
		[Token(Token = "0x40352CC")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		[FormerlySerializedAs("pointColor")]
		private float _maxLength;

		// Token: 0x040352CD RID: 217805
		[Token(Token = "0x40352CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x040352CE RID: 217806
		[Token(Token = "0x40352CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
