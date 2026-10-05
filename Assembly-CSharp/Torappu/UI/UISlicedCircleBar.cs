using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A33 RID: 14899
	[Token(Token = "0x2003A33")]
	public class UISlicedCircleBar : Image, IHotfixable
	{
		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0601783A RID: 96314 RVA: 0x00096E28 File Offset: 0x00095028
		[Token(Token = "0x17003853")]
		public override bool packIntoRuntimeAtlas
		{
			[Token(Token = "0x601783A")]
			[Address(RVA = "0xFD4EF0", Offset = "0xFD3AF0", VA = "0x180FD4EF0", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003854 RID: 14420
		// (set) Token: 0x0601783B RID: 96315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003854")]
		public float startAngle
		{
			[Token(Token = "0x601783B")]
			[Address(RVA = "0xFD4FF0", Offset = "0xFD3BF0", VA = "0x180FD4FF0")]
			set
			{
			}
		}

		// Token: 0x17003855 RID: 14421
		// (set) Token: 0x0601783C RID: 96316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003855")]
		public float angleSpan
		{
			[Token(Token = "0x601783C")]
			[Address(RVA = "0xFD4F50", Offset = "0xFD3B50", VA = "0x180FD4F50")]
			set
			{
			}
		}

		// Token: 0x0601783D RID: 96317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601783D")]
		[Address(RVA = "0xFD4930", Offset = "0xFD3530", VA = "0x180FD4930")]
		private void _AddVertex(VertexHelper vh, Vector2 pos, Vector2 uv, ref int vertexIndex)
		{
		}

		// Token: 0x0601783E RID: 96318 RVA: 0x00096E40 File Offset: 0x00095040
		[Token(Token = "0x601783E")]
		[Address(RVA = "0xFD4DA0", Offset = "0xFD39A0", VA = "0x180FD4DA0")]
		private Vector2 _GetVertexPos(float angleOffset, float radius)
		{
			return default(Vector2);
		}

		// Token: 0x0601783F RID: 96319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601783F")]
		[Address(RVA = "0xFD4AF0", Offset = "0xFD36F0", VA = "0x180FD4AF0")]
		private void _GetRadialVertexUV(int section, float angle, out float radius, out Vector2 uv)
		{
		}

		// Token: 0x06017840 RID: 96320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017840")]
		[Address(RVA = "0xFD3E50", Offset = "0xFD2A50", VA = "0x180FD3E50", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x06017841 RID: 96321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017841")]
		[Address(RVA = "0xFD4E70", Offset = "0xFD3A70", VA = "0x180FD4E70")]
		public UISlicedCircleBar()
		{
		}

		// Token: 0x06017842 RID: 96322 RVA: 0x00096E58 File Offset: 0x00095058
		[Token(Token = "0x6017842")]
		[Address(RVA = "0xD742E0", Offset = "0xD72EE0", VA = "0x180D742E0")]
		private bool <>xLuaBaseProxy_get_packIntoRuntimeAtlas()
		{
			return default(bool);
		}

		// Token: 0x06017843 RID: 96323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017843")]
		[Address(RVA = "0xD742D0", Offset = "0xD72ED0", VA = "0x180D742D0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x0401C658 RID: 116312
		[Token(Token = "0x401C658")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private float _startAngle;

		// Token: 0x0401C659 RID: 116313
		[Token(Token = "0x401C659")]
		[FieldOffset(Offset = "0x194")]
		[SerializeField]
		private float _angleSpan;

		// Token: 0x0401C65A RID: 116314
		[Token(Token = "0x401C65A")]
		[FieldOffset(Offset = "0x198")]
		private float m_radius;

		// Token: 0x0401C65B RID: 116315
		[Token(Token = "0x401C65B")]
		[FieldOffset(Offset = "0x19C")]
		private bool m_antiClockwise;

		// Token: 0x0401C65C RID: 116316
		[Token(Token = "0x401C65C")]
		[FieldOffset(Offset = "0x1A0")]
		private float m_borderUV;

		// Token: 0x0401C65D RID: 116317
		[Token(Token = "0x401C65D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_packIntoRuntimeAtlas;

		// Token: 0x0401C65E RID: 116318
		[Token(Token = "0x401C65E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_startAngle;

		// Token: 0x0401C65F RID: 116319
		[Token(Token = "0x401C65F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_angleSpan;

		// Token: 0x0401C660 RID: 116320
		[Token(Token = "0x401C660")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AddVertex;

		// Token: 0x0401C661 RID: 116321
		[Token(Token = "0x401C661")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetVertexPos;

		// Token: 0x0401C662 RID: 116322
		[Token(Token = "0x401C662")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetRadialVertexUV;

		// Token: 0x0401C663 RID: 116323
		[Token(Token = "0x401C663")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x0401C664 RID: 116324
		[Token(Token = "0x401C664")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
