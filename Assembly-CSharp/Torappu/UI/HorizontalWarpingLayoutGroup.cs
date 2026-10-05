using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038C3 RID: 14531
	[Token(Token = "0x20038C3")]
	public class HorizontalWarpingLayoutGroup : LayoutGroup, IHotfixable
	{
		// Token: 0x06016FC3 RID: 94147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FC3")]
		[Address(RVA = "0xF72890", Offset = "0xF71490", VA = "0x180F72890", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06016FC4 RID: 94148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FC4")]
		[Address(RVA = "0xF72AB0", Offset = "0xF716B0", VA = "0x180F72AB0", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x06016FC5 RID: 94149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FC5")]
		[Address(RVA = "0xF72FC0", Offset = "0xF71BC0", VA = "0x180F72FC0", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x06016FC6 RID: 94150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FC6")]
		[Address(RVA = "0xF73150", Offset = "0xF71D50", VA = "0x180F73150", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x06016FC7 RID: 94151 RVA: 0x00094338 File Offset: 0x00092538
		[Token(Token = "0x6016FC7")]
		[Address(RVA = "0xF73580", Offset = "0xF72180", VA = "0x180F73580")]
		private Vector2 _GetTrueOffsetOfChild(HorizontalWarpingLayoutGroup.ChildMeta meta)
		{
			return default(Vector2);
		}

		// Token: 0x06016FC8 RID: 94152 RVA: 0x00094350 File Offset: 0x00092550
		[Token(Token = "0x6016FC8")]
		[Address(RVA = "0xF73760", Offset = "0xF72360", VA = "0x180F73760")]
		private Vector2 _GetTrueOffsetOfRow(HorizontalWarpingLayoutGroup.RowMeta meta)
		{
			return default(Vector2);
		}

		// Token: 0x06016FC9 RID: 94153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FC9")]
		[Address(RVA = "0xF73CD0", Offset = "0xF728D0", VA = "0x180F73CD0")]
		public HorizontalWarpingLayoutGroup()
		{
		}

		// Token: 0x06016FCA RID: 94154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FCA")]
		[Address(RVA = "0xF73570", Offset = "0xF72170", VA = "0x180F73570")]
		private void <>xLuaBaseProxy_CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0401BBEF RID: 113647
		[Token(Token = "0x401BBEF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _fixedWidth;

		// Token: 0x0401BBF0 RID: 113648
		[Token(Token = "0x401BBF0")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Vector2 _spacing;

		// Token: 0x0401BBF1 RID: 113649
		[Token(Token = "0x401BBF1")]
		[FieldOffset(Offset = "0x64")]
		private Vector2 m_contentSizeMeta;

		// Token: 0x0401BBF2 RID: 113650
		[Token(Token = "0x401BBF2")]
		[FieldOffset(Offset = "0x70")]
		private readonly List<HorizontalWarpingLayoutGroup.RowMeta> m_rowMetas;

		// Token: 0x0401BBF3 RID: 113651
		[Token(Token = "0x401BBF3")]
		[FieldOffset(Offset = "0x78")]
		private readonly Dictionary<RectTransform, HorizontalWarpingLayoutGroup.ChildMeta> m_childMetas;

		// Token: 0x0401BBF4 RID: 113652
		[Token(Token = "0x401BBF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x0401BBF5 RID: 113653
		[Token(Token = "0x401BBF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x0401BBF6 RID: 113654
		[Token(Token = "0x401BBF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetLayoutHorizontal;

		// Token: 0x0401BBF7 RID: 113655
		[Token(Token = "0x401BBF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetLayoutVertical;

		// Token: 0x0401BBF8 RID: 113656
		[Token(Token = "0x401BBF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTrueOffsetOfChild;

		// Token: 0x0401BBF9 RID: 113657
		[Token(Token = "0x401BBF9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTrueOffsetOfRow;

		// Token: 0x0401BBFA RID: 113658
		[Token(Token = "0x401BBFA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038C4 RID: 14532
		[Token(Token = "0x20038C4")]
		private struct RowMeta
		{
			// Token: 0x0401BBFB RID: 113659
			[Token(Token = "0x401BBFB")]
			[FieldOffset(Offset = "0x0")]
			public float offsetY;

			// Token: 0x0401BBFC RID: 113660
			[Token(Token = "0x401BBFC")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 size;
		}

		// Token: 0x020038C5 RID: 14533
		[Token(Token = "0x20038C5")]
		private struct ChildMeta
		{
			// Token: 0x0401BBFD RID: 113661
			[Token(Token = "0x401BBFD")]
			[FieldOffset(Offset = "0x0")]
			public int rowIndex;

			// Token: 0x0401BBFE RID: 113662
			[Token(Token = "0x401BBFE")]
			[FieldOffset(Offset = "0x4")]
			public float offsetX;

			// Token: 0x0401BBFF RID: 113663
			[Token(Token = "0x401BBFF")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 size;
		}
	}
}
