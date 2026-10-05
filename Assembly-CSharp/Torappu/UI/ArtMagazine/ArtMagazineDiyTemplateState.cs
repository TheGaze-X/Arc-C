using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006563 RID: 25955
	[Token(Token = "0x2006563")]
	public class ArtMagazineDiyTemplateState : PopupFadeState, IHotfixable
	{
		// Token: 0x06025530 RID: 152880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025530")]
		[Address(RVA = "0x2052FE0", Offset = "0x2051BE0", VA = "0x182052FE0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025531 RID: 152881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025531")]
		[Address(RVA = "0x2053040", Offset = "0x2051C40", VA = "0x182053040", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025532 RID: 152882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025532")]
		[Address(RVA = "0x2053190", Offset = "0x2051D90", VA = "0x182053190", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06025533 RID: 152883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025533")]
		[Address(RVA = "0x20532C0", Offset = "0x2051EC0", VA = "0x1820532C0")]
		public ArtMagazineDiyTemplateState()
		{
		}

		// Token: 0x06025534 RID: 152884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025534")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025535 RID: 152885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025535")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x040345C8 RID: 214472
		[Token(Token = "0x40345C8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ArtMagazineDiyTemplateView _view;

		// Token: 0x040345C9 RID: 214473
		[Token(Token = "0x40345C9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ArtMagazineDiyPage.LeafViewDisplayOptions _displayOptions;

		// Token: 0x040345CA RID: 214474
		[Token(Token = "0x40345CA")]
		[FieldOffset(Offset = "0x88")]
		private ArtMagazineDiyTemplateStateBean m_stateBean;

		// Token: 0x040345CB RID: 214475
		[Token(Token = "0x40345CB")]
		[FieldOffset(Offset = "0x90")]
		private string m_leafId;

		// Token: 0x040345CC RID: 214476
		[Token(Token = "0x40345CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040345CD RID: 214477
		[Token(Token = "0x40345CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040345CE RID: 214478
		[Token(Token = "0x40345CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040345CF RID: 214479
		[Token(Token = "0x40345CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
