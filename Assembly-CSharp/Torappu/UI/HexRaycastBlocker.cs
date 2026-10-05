using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003A0E RID: 14862
	[Token(Token = "0x2003A0E")]
	[RequireComponent(typeof(RectTransform))]
	public class HexRaycastBlocker : Graphic
	{
		// Token: 0x06017747 RID: 96071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017747")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
		public override void SetMaterialDirty()
		{
		}

		// Token: 0x06017748 RID: 96072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017748")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "30")]
		public override void SetVerticesDirty()
		{
		}

		// Token: 0x06017749 RID: 96073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017749")]
		[Address(RVA = "0x513230", Offset = "0x511E30", VA = "0x180513230", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x0601774A RID: 96074 RVA: 0x00096828 File Offset: 0x00094A28
		[Token(Token = "0x601774A")]
		[Address(RVA = "0xFC75A0", Offset = "0xFC61A0", VA = "0x180FC75A0", Slot = "48")]
		public override bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x0601774B RID: 96075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601774B")]
		[Address(RVA = "0xFC7800", Offset = "0xFC6400", VA = "0x180FC7800")]
		public HexRaycastBlocker()
		{
		}

		// Token: 0x0401C550 RID: 116048
		[Token(Token = "0x401C550")]
		private const bool IS_TEST_MODE = false;

		// Token: 0x0401C551 RID: 116049
		[Token(Token = "0x401C551")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _enableDisplay;
	}
}
