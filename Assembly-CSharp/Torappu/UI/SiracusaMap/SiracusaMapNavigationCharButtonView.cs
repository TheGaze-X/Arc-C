using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EF1 RID: 16113
	[Token(Token = "0x2003EF1")]
	public class SiracusaMapNavigationCharButtonView : SiracusaMapNavigationButtonBaseView
	{
		// Token: 0x0601900D RID: 102413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601900D")]
		[Address(RVA = "0x11B6610", Offset = "0x11B5210", VA = "0x1811B6610", Slot = "4")]
		public override void Render(SiracusaMapNavigationDetailViewModel viewModel)
		{
		}

		// Token: 0x0601900E RID: 102414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601900E")]
		[Address(RVA = "0x11B64B0", Offset = "0x11B50B0", VA = "0x1811B64B0")]
		public void OnEntryClick()
		{
		}

		// Token: 0x0601900F RID: 102415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601900F")]
		[Address(RVA = "0x11B6920", Offset = "0x11B5520", VA = "0x1811B6920")]
		public SiracusaMapNavigationCharButtonView()
		{
		}

		// Token: 0x06019010 RID: 102416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019010")]
		[Address(RVA = "0x11B6910", Offset = "0x11B5510", VA = "0x1811B6910")]
		private void <>xLuaBaseProxy_Render(SiracusaMapNavigationDetailViewModel P0)
		{
		}

		// Token: 0x0401EE6D RID: 126573
		[Token(Token = "0x401EE6D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _circle;

		// Token: 0x0401EE6E RID: 126574
		[Token(Token = "0x401EE6E")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedCharId;

		// Token: 0x0401EE6F RID: 126575
		[Token(Token = "0x401EE6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EE70 RID: 126576
		[Token(Token = "0x401EE70")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEntryClick;

		// Token: 0x0401EE71 RID: 126577
		[Token(Token = "0x401EE71")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
