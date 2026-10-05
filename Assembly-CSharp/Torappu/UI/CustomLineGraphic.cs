using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003922 RID: 14626
	[Token(Token = "0x2003922")]
	public class CustomLineGraphic : MaskableGraphic, IHotfixable
	{
		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x060171E5 RID: 94693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003736")]
		public List<Vector2> pointPosList
		{
			[Token(Token = "0x60171E5")]
			[Address(RVA = "0xF848A0", Offset = "0xF834A0", VA = "0x180F848A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x060171E6 RID: 94694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003737")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60171E6")]
			[Address(RVA = "0xF847C0", Offset = "0xF833C0", VA = "0x180F847C0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x060171E7 RID: 94695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171E7")]
		[Address(RVA = "0xF84100", Offset = "0xF82D00", VA = "0x180F84100")]
		public void NotifyPointListChanged()
		{
		}

		// Token: 0x060171E8 RID: 94696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171E8")]
		[Address(RVA = "0xF84180", Offset = "0xF82D80", VA = "0x180F84180", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x060171E9 RID: 94697 RVA: 0x00094E30 File Offset: 0x00093030
		[Token(Token = "0x60171E9")]
		[Address(RVA = "0xF83EB0", Offset = "0xF82AB0", VA = "0x180F83EB0")]
		private UIVertex CreateUIVertex(Vector2 pos, Vector2 uv)
		{
			return default(UIVertex);
		}

		// Token: 0x060171EA RID: 94698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171EA")]
		[Address(RVA = "0xF84700", Offset = "0xF83300", VA = "0x180F84700")]
		public CustomLineGraphic()
		{
		}

		// Token: 0x060171EB RID: 94699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60171EB")]
		[Address(RVA = "0xDEFAF0", Offset = "0xDEE6F0", VA = "0x180DEFAF0")]
		private Texture <>xLuaBaseProxy_get_mainTexture()
		{
			return null;
		}

		// Token: 0x060171EC RID: 94700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171EC")]
		[Address(RVA = "0xDEFAD0", Offset = "0xDEE6D0", VA = "0x180DEFAD0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x0401BE8B RID: 114315
		[Token(Token = "0x401BE8B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _lineWidth;

		// Token: 0x0401BE8C RID: 114316
		[Token(Token = "0x401BE8C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Texture2D _texture;

		// Token: 0x0401BE8D RID: 114317
		[Token(Token = "0x401BE8D")]
		[FieldOffset(Offset = "0xF8")]
		private List<Vector2> m_pointPosList;

		// Token: 0x0401BE8E RID: 114318
		[Token(Token = "0x401BE8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pointPosList;

		// Token: 0x0401BE8F RID: 114319
		[Token(Token = "0x401BE8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_mainTexture;

		// Token: 0x0401BE90 RID: 114320
		[Token(Token = "0x401BE90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyPointListChanged;

		// Token: 0x0401BE91 RID: 114321
		[Token(Token = "0x401BE91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x0401BE92 RID: 114322
		[Token(Token = "0x401BE92")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateUIVertex;

		// Token: 0x0401BE93 RID: 114323
		[Token(Token = "0x401BE93")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
