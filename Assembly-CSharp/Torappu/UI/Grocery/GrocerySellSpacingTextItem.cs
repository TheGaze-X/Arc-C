using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D1D RID: 19741
	[Token(Token = "0x2004D1D")]
	public class GrocerySellSpacingTextItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D949 RID: 121161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D949")]
		[Address(RVA = "0x1732D70", Offset = "0x1731970", VA = "0x181732D70")]
		public void Render(int number)
		{
		}

		// Token: 0x0601D94A RID: 121162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D94A")]
		[Address(RVA = "0x1732FF0", Offset = "0x1731BF0", VA = "0x181732FF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D94B RID: 121163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D94B")]
		[Address(RVA = "0x1733110", Offset = "0x1731D10", VA = "0x181733110")]
		public GrocerySellSpacingTextItem()
		{
		}

		// Token: 0x040270FD RID: 159997
		[Token(Token = "0x40270FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040270FE RID: 159998
		[Token(Token = "0x40270FE")]
		[FieldOffset(Offset = "0x20")]
		private GrocerySellSpacingTextItem.Adapter m_adapter;

		// Token: 0x040270FF RID: 159999
		[Token(Token = "0x40270FF")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04027100 RID: 160000
		[Token(Token = "0x4027100")]
		[FieldOffset(Offset = "0x30")]
		private List<int> m_numberList;

		// Token: 0x04027101 RID: 160001
		[Token(Token = "0x4027101")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027102 RID: 160002
		[Token(Token = "0x4027102")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027103 RID: 160003
		[Token(Token = "0x4027103")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D1E RID: 19742
		[Token(Token = "0x2004D1E")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004579 RID: 17785
			// (get) Token: 0x0601D94C RID: 121164 RVA: 0x000AC068 File Offset: 0x000AA268
			[Token(Token = "0x17004579")]
			public override int count
			{
				[Token(Token = "0x601D94C")]
				[Address(RVA = "0x17242D0", Offset = "0x1722ED0", VA = "0x1817242D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D94D RID: 121165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D94D")]
			[Address(RVA = "0x1724160", Offset = "0x1722D60", VA = "0x181724160")]
			public Adapter(GrocerySellSpacingTextItem closure)
			{
			}

			// Token: 0x0601D94E RID: 121166 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D94E")]
			[Address(RVA = "0x1723EE0", Offset = "0x1722AE0", VA = "0x181723EE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04027104 RID: 160004
			[Token(Token = "0x4027104")]
			[FieldOffset(Offset = "0x20")]
			private GrocerySellSpacingTextItem m_closure;

			// Token: 0x04027105 RID: 160005
			[Token(Token = "0x4027105")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027106 RID: 160006
			[Token(Token = "0x4027106")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027107 RID: 160007
			[Token(Token = "0x4027107")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
