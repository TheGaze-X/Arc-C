using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040C6 RID: 16582
	[Token(Token = "0x20040C6")]
	public class SandboxV2AdminMainScienceLine : Image, IHotfixable
	{
		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x06019A60 RID: 105056 RVA: 0x0009EEC8 File Offset: 0x0009D0C8
		[Token(Token = "0x17003D33")]
		public override bool packIntoRuntimeAtlas
		{
			[Token(Token = "0x6019A60")]
			[Address(RVA = "0x1279930", Offset = "0x1278530", VA = "0x181279930", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06019A61 RID: 105057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A61")]
		[Address(RVA = "0x1278F80", Offset = "0x1277B80", VA = "0x181278F80")]
		public void SetPosition(Vector2 startPos, Vector2 endPos)
		{
		}

		// Token: 0x06019A62 RID: 105058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A62")]
		[Address(RVA = "0x1278EC0", Offset = "0x1277AC0", VA = "0x181278EC0", Slot = "62")]
		public override void SetClipRect(Rect clipRect, bool validRect)
		{
		}

		// Token: 0x06019A63 RID: 105059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A63")]
		[Address(RVA = "0x1278D80", Offset = "0x1277980", VA = "0x181278D80", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06019A64 RID: 105060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A64")]
		[Address(RVA = "0x12790E0", Offset = "0x1277CE0", VA = "0x1812790E0")]
		private void _DrawLine(VertexHelper vh, Vector2 startPos, Vector2 endPos)
		{
		}

		// Token: 0x06019A65 RID: 105061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A65")]
		[Address(RVA = "0x1279880", Offset = "0x1278480", VA = "0x181279880")]
		public SandboxV2AdminMainScienceLine()
		{
		}

		// Token: 0x06019A66 RID: 105062 RVA: 0x0009EEE0 File Offset: 0x0009D0E0
		[Token(Token = "0x6019A66")]
		[Address(RVA = "0xD742E0", Offset = "0xD72EE0", VA = "0x180D742E0")]
		private bool <>xLuaBaseProxy_get_packIntoRuntimeAtlas()
		{
			return default(bool);
		}

		// Token: 0x06019A67 RID: 105063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A67")]
		[Address(RVA = "0x12790C0", Offset = "0x1277CC0", VA = "0x1812790C0")]
		private void <>xLuaBaseProxy_SetClipRect(Rect P0, bool P1)
		{
		}

		// Token: 0x06019A68 RID: 105064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A68")]
		[Address(RVA = "0xD742D0", Offset = "0xD72ED0", VA = "0x180D742D0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x040200D9 RID: 131289
		[Token(Token = "0x40200D9")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Vector2 _startPos;

		// Token: 0x040200DA RID: 131290
		[Token(Token = "0x40200DA")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Vector2 _endPos;

		// Token: 0x040200DB RID: 131291
		[Token(Token = "0x40200DB")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private int _width;

		// Token: 0x040200DC RID: 131292
		[Token(Token = "0x40200DC")]
		[FieldOffset(Offset = "0x1A8")]
		private UIVertex[] m_vertexArray;

		// Token: 0x040200DD RID: 131293
		[Token(Token = "0x40200DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_packIntoRuntimeAtlas;

		// Token: 0x040200DE RID: 131294
		[Token(Token = "0x40200DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetPosition;

		// Token: 0x040200DF RID: 131295
		[Token(Token = "0x40200DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetClipRect;

		// Token: 0x040200E0 RID: 131296
		[Token(Token = "0x40200E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x040200E1 RID: 131297
		[Token(Token = "0x40200E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DrawLine;

		// Token: 0x040200E2 RID: 131298
		[Token(Token = "0x40200E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
