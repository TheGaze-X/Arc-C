using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A0D RID: 14861
	[Token(Token = "0x2003A0D")]
	public class UILineRenderer : Image, IHotfixable
	{
		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x06017740 RID: 96064 RVA: 0x000967E0 File Offset: 0x000949E0
		[Token(Token = "0x17003831")]
		public override bool packIntoRuntimeAtlas
		{
			[Token(Token = "0x6017740")]
			[Address(RVA = "0xFCD0B0", Offset = "0xFCBCB0", VA = "0x180FCD0B0", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06017741 RID: 96065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017741")]
		[Address(RVA = "0xFCC3F0", Offset = "0xFCAFF0", VA = "0x180FCC3F0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06017742 RID: 96066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017742")]
		[Address(RVA = "0xFCCAC0", Offset = "0xFCB6C0", VA = "0x180FCCAC0")]
		private void _CreateBottomAndTopPoints(Vector3 p, float progress, Vector3 direction, float thickness, VertexHelper vh)
		{
		}

		// Token: 0x06017743 RID: 96067 RVA: 0x000967F8 File Offset: 0x000949F8
		[Token(Token = "0x6017743")]
		[Address(RVA = "0xFCCF90", Offset = "0xFCBB90", VA = "0x180FCCF90")]
		private float _LookRotationV2(Vector2 direction)
		{
			return 0f;
		}

		// Token: 0x06017744 RID: 96068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017744")]
		[Address(RVA = "0xFCD020", Offset = "0xFCBC20", VA = "0x180FCD020")]
		public UILineRenderer()
		{
		}

		// Token: 0x06017745 RID: 96069 RVA: 0x00096810 File Offset: 0x00094A10
		[Token(Token = "0x6017745")]
		[Address(RVA = "0xD742E0", Offset = "0xD72EE0", VA = "0x180D742E0")]
		private bool <>xLuaBaseProxy_get_packIntoRuntimeAtlas()
		{
			return default(bool);
		}

		// Token: 0x06017746 RID: 96070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017746")]
		[Address(RVA = "0xD742D0", Offset = "0xD72ED0", VA = "0x180D742D0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x0401C549 RID: 116041
		[Token(Token = "0x401C549")]
		[FieldOffset(Offset = "0x190")]
		public Vector2[] points;

		// Token: 0x0401C54A RID: 116042
		[Token(Token = "0x401C54A")]
		[FieldOffset(Offset = "0x198")]
		public float thickness;

		// Token: 0x0401C54B RID: 116043
		[Token(Token = "0x401C54B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_packIntoRuntimeAtlas;

		// Token: 0x0401C54C RID: 116044
		[Token(Token = "0x401C54C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x0401C54D RID: 116045
		[Token(Token = "0x401C54D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CreateBottomAndTopPoints;

		// Token: 0x0401C54E RID: 116046
		[Token(Token = "0x401C54E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LookRotationV2;

		// Token: 0x0401C54F RID: 116047
		[Token(Token = "0x401C54F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
