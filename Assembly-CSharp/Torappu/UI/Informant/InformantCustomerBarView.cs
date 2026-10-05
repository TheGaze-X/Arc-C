using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049F8 RID: 18936
	[Token(Token = "0x20049F8")]
	public class InformantCustomerBarView : DataBinder<InformantCustomerBarProperty>, IHotfixable
	{
		// Token: 0x0601C81E RID: 116766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C81E")]
		[Address(RVA = "0x15F5410", Offset = "0x15F4010", VA = "0x1815F5410", Slot = "7")]
		public override void OnValueChanged(InformantCustomerBarProperty property)
		{
		}

		// Token: 0x0601C81F RID: 116767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C81F")]
		[Address(RVA = "0x15F55F0", Offset = "0x15F41F0", VA = "0x1815F55F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C820 RID: 116768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C820")]
		[Address(RVA = "0x15F5710", Offset = "0x15F4310", VA = "0x1815F5710")]
		public InformantCustomerBarView()
		{
		}

		// Token: 0x040255A6 RID: 152998
		[Token(Token = "0x40255A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040255A7 RID: 152999
		[Token(Token = "0x40255A7")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x040255A8 RID: 153000
		[Token(Token = "0x40255A8")]
		[FieldOffset(Offset = "0x30")]
		private InformantCustomerBarView.Adapter m_adapter;

		// Token: 0x040255A9 RID: 153001
		[Token(Token = "0x40255A9")]
		[FieldOffset(Offset = "0x38")]
		private List<bool> m_cachedCustomerList;

		// Token: 0x040255AA RID: 153002
		[Token(Token = "0x40255AA")]
		[FieldOffset(Offset = "0x40")]
		private int m_cachedIndex;

		// Token: 0x040255AB RID: 153003
		[Token(Token = "0x40255AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040255AC RID: 153004
		[Token(Token = "0x40255AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040255AD RID: 153005
		[Token(Token = "0x40255AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020049F9 RID: 18937
		[Token(Token = "0x20049F9")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601C821 RID: 116769 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C821")]
			[Address(RVA = "0x15F2B80", Offset = "0x15F1780", VA = "0x1815F2B80")]
			public Adapter(InformantCustomerBarView closure)
			{
			}

			// Token: 0x1700436D RID: 17261
			// (get) Token: 0x0601C822 RID: 116770 RVA: 0x000A8930 File Offset: 0x000A6B30
			[Token(Token = "0x1700436D")]
			public override int count
			{
				[Token(Token = "0x601C822")]
				[Address(RVA = "0x15F2C00", Offset = "0x15F1800", VA = "0x1815F2C00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C823 RID: 116771 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C823")]
			[Address(RVA = "0x15F29C0", Offset = "0x15F15C0", VA = "0x1815F29C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040255AE RID: 153006
			[Token(Token = "0x40255AE")]
			[FieldOffset(Offset = "0x20")]
			private InformantCustomerBarView m_closure;

			// Token: 0x040255AF RID: 153007
			[Token(Token = "0x40255AF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040255B0 RID: 153008
			[Token(Token = "0x40255B0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040255B1 RID: 153009
			[Token(Token = "0x40255B1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
