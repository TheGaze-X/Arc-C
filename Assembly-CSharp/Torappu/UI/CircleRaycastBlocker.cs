using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200390A RID: 14602
	[Token(Token = "0x200390A")]
	[RequireComponent(typeof(RectTransform))]
	public class CircleRaycastBlocker : Graphic
	{
		// Token: 0x06017159 RID: 94553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017159")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
		public override void SetMaterialDirty()
		{
		}

		// Token: 0x0601715A RID: 94554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601715A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "30")]
		public override void SetVerticesDirty()
		{
		}

		// Token: 0x0601715B RID: 94555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601715B")]
		[Address(RVA = "0x513230", Offset = "0x511E30", VA = "0x180513230", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x0601715C RID: 94556 RVA: 0x00094CF8 File Offset: 0x00092EF8
		[Token(Token = "0x601715C")]
		[Address(RVA = "0xF6FB80", Offset = "0xF6E780", VA = "0x180F6FB80", Slot = "48")]
		public override bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x0601715D RID: 94557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601715D")]
		[Address(RVA = "0xF6FDF0", Offset = "0xF6E9F0", VA = "0x180F6FDF0")]
		public CircleRaycastBlocker()
		{
		}

		// Token: 0x0401BDB9 RID: 114105
		[Token(Token = "0x401BDB9")]
		private const bool IS_TEST_MODE = false;

		// Token: 0x0401BDBA RID: 114106
		[Token(Token = "0x401BDBA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _enableDisplay;
	}
}
