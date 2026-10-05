using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074E2 RID: 29922
	[Token(Token = "0x20074E2")]
	public class RhineArcEntryRightTimelineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A2E3 RID: 172771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2E3")]
		[Address(RVA = "0x25D5580", Offset = "0x25D4180", VA = "0x1825D5580")]
		private void _RenderIfFirstTime(int count, RhineArcViewModel.Group groupViewModel)
		{
		}

		// Token: 0x0602A2E4 RID: 172772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2E4")]
		[Address(RVA = "0x25D52D0", Offset = "0x25D3ED0", VA = "0x1825D52D0")]
		public void Render(RhineArcViewModel.Group groupViewModel)
		{
		}

		// Token: 0x0602A2E5 RID: 172773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2E5")]
		[Address(RVA = "0x25D57C0", Offset = "0x25D43C0", VA = "0x1825D57C0")]
		public RhineArcEntryRightTimelineView()
		{
		}

		// Token: 0x0403C99F RID: 248223
		[Token(Token = "0x403C99F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backLine;

		// Token: 0x0403C9A0 RID: 248224
		[Token(Token = "0x403C9A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _availLine;

		// Token: 0x0403C9A1 RID: 248225
		[Token(Token = "0x403C9A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RhineArcTimelineItem _item;

		// Token: 0x0403C9A2 RID: 248226
		[Token(Token = "0x403C9A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403C9A3 RID: 248227
		[Token(Token = "0x403C9A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0403C9A4 RID: 248228
		[Token(Token = "0x403C9A4")]
		[FieldOffset(Offset = "0x40")]
		private List<RhineArcTimelineItem> m_itemList;

		// Token: 0x0403C9A5 RID: 248229
		[Token(Token = "0x403C9A5")]
		[FieldOffset(Offset = "0x48")]
		private bool m_renderFlag;

		// Token: 0x0403C9A6 RID: 248230
		[Token(Token = "0x403C9A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderIfFirstTime;

		// Token: 0x0403C9A7 RID: 248231
		[Token(Token = "0x403C9A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C9A8 RID: 248232
		[Token(Token = "0x403C9A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
