using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066EB RID: 26347
	[Token(Token = "0x20066EB")]
	public class HandBooSpriteTest : MaskableGraphic
	{
		// Token: 0x06025D0A RID: 154890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D0A")]
		[Address(RVA = "0x20B6F60", Offset = "0x20B5B60", VA = "0x1820B6F60", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06025D0B RID: 154891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D0B")]
		[Address(RVA = "0x20B7690", Offset = "0x20B6290", VA = "0x1820B7690")]
		public HandBooSpriteTest()
		{
		}

		// Token: 0x04035287 RID: 217735
		[Token(Token = "0x4035287")]
		[FieldOffset(Offset = "0xE8")]
		public Color pointColor;

		// Token: 0x04035288 RID: 217736
		[Token(Token = "0x4035288")]
		[FieldOffset(Offset = "0xF8")]
		public float length;

		// Token: 0x04035289 RID: 217737
		[Token(Token = "0x4035289")]
		[FieldOffset(Offset = "0xFC")]
		public Vector3 initPoint;

		// Token: 0x0403528A RID: 217738
		[Token(Token = "0x403528A")]
		[FieldOffset(Offset = "0x108")]
		public float maxLength;
	}
}
