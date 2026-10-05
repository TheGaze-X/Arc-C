using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CB9 RID: 27833
	[Token(Token = "0x2006CB9")]
	public class TemplateActivitySingleComponent : ActivityStageSingleComponent
	{
		// Token: 0x06027B6E RID: 162670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B6E")]
		[Address(RVA = "0x22E7DF0", Offset = "0x22E69F0", VA = "0x1822E7DF0", Slot = "7")]
		protected override void OnControllerBinded()
		{
		}

		// Token: 0x06027B6F RID: 162671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B6F")]
		[Address(RVA = "0x22E8020", Offset = "0x22E6C20", VA = "0x1822E8020")]
		public void RefreshBinder()
		{
		}

		// Token: 0x06027B70 RID: 162672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B70")]
		[Address(RVA = "0x22E7CA0", Offset = "0x22E68A0", VA = "0x1822E7CA0")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x06027B71 RID: 162673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B71")]
		[Address(RVA = "0x22E8210", Offset = "0x22E6E10", VA = "0x1822E8210")]
		public TemplateActivitySingleComponent()
		{
		}

		// Token: 0x06027B72 RID: 162674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B72")]
		[Address(RVA = "0x22E8200", Offset = "0x22E6E00", VA = "0x1822E8200")]
		private void <>xLuaBaseProxy_OnControllerBinded()
		{
		}

		// Token: 0x040384FA RID: 230650
		[Token(Token = "0x40384FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<TemplateActivityCommonPlugin> _pluginList;

		// Token: 0x040384FB RID: 230651
		[Token(Token = "0x40384FB")]
		[FieldOffset(Offset = "0x28")]
		protected TemplateActivityController templateController;

		// Token: 0x040384FC RID: 230652
		[Token(Token = "0x40384FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnControllerBinded;

		// Token: 0x040384FD RID: 230653
		[Token(Token = "0x40384FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshBinder;

		// Token: 0x040384FE RID: 230654
		[Token(Token = "0x40384FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x040384FF RID: 230655
		[Token(Token = "0x40384FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
