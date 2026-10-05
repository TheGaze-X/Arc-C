using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004998 RID: 18840
	[Token(Token = "0x2004998")]
	public class MedalShowTypeFilterView : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000089 RID: 137
		// (add) Token: 0x0601C62F RID: 116271 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0601C630 RID: 116272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000089")]
		public event Action<MedalBarListShowType> onShowTypeClicked
		{
			[Token(Token = "0x601C62F")]
			[Address(RVA = "0x15EF9B0", Offset = "0x15EE5B0", VA = "0x1815EF9B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x601C630")]
			[Address(RVA = "0x15EFAB0", Offset = "0x15EE6B0", VA = "0x1815EFAB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0601C631 RID: 116273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C631")]
		[Address(RVA = "0x15EF680", Offset = "0x15EE280", VA = "0x1815EF680")]
		public void EventToShowTypeAll()
		{
		}

		// Token: 0x0601C632 RID: 116274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C632")]
		[Address(RVA = "0x15EF6E0", Offset = "0x15EE2E0", VA = "0x1815EF6E0")]
		public void EventToShowTypeAvail()
		{
		}

		// Token: 0x0601C633 RID: 116275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C633")]
		[Address(RVA = "0x15EF740", Offset = "0x15EE340", VA = "0x1815EF740")]
		public void EventToShowTypeNotAvail()
		{
		}

		// Token: 0x0601C634 RID: 116276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C634")]
		[Address(RVA = "0x15EF7A0", Offset = "0x15EE3A0", VA = "0x1815EF7A0")]
		public void Render(MedalBarListShowType showType)
		{
		}

		// Token: 0x0601C635 RID: 116277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C635")]
		[Address(RVA = "0x15EF8D0", Offset = "0x15EE4D0", VA = "0x1815EF8D0")]
		private void _OnShowTypeClicked(MedalBarListShowType showType)
		{
		}

		// Token: 0x0601C636 RID: 116278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C636")]
		[Address(RVA = "0x15EF950", Offset = "0x15EE550", VA = "0x1815EF950")]
		public MedalShowTypeFilterView()
		{
		}

		// Token: 0x040252DE RID: 152286
		[Token(Token = "0x40252DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<MedalBarListStateBtn> _filterBtns;

		// Token: 0x040252E0 RID: 152288
		[Token(Token = "0x40252E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_onShowTypeClicked;

		// Token: 0x040252E1 RID: 152289
		[Token(Token = "0x40252E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_onShowTypeClicked;

		// Token: 0x040252E2 RID: 152290
		[Token(Token = "0x40252E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventToShowTypeAll;

		// Token: 0x040252E3 RID: 152291
		[Token(Token = "0x40252E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventToShowTypeAvail;

		// Token: 0x040252E4 RID: 152292
		[Token(Token = "0x40252E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventToShowTypeNotAvail;

		// Token: 0x040252E5 RID: 152293
		[Token(Token = "0x40252E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040252E6 RID: 152294
		[Token(Token = "0x40252E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnShowTypeClicked;

		// Token: 0x040252E7 RID: 152295
		[Token(Token = "0x40252E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
