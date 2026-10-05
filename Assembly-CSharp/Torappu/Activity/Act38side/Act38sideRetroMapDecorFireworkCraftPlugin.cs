using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x02007435 RID: 29749
	[Token(Token = "0x2007435")]
	public class Act38sideRetroMapDecorFireworkCraftPlugin : StageSideStoryMapDecroViewPlugin, IHotfixable
	{
		// Token: 0x06029FBF RID: 171967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FBF")]
		[Address(RVA = "0x25A8D40", Offset = "0x25A7940", VA = "0x1825A8D40", Slot = "4")]
		public override void OnRefresh(StageSideStoryMapDecroViewPluginParams param)
		{
		}

		// Token: 0x06029FC0 RID: 171968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FC0")]
		[Address(RVA = "0x25A8E60", Offset = "0x25A7A60", VA = "0x1825A8E60")]
		public Act38sideRetroMapDecorFireworkCraftPlugin()
		{
		}

		// Token: 0x0403C337 RID: 246583
		[Token(Token = "0x403C337")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act38sideMapDecorFireworkCraftPlugin _actCraftPlugin;

		// Token: 0x0403C338 RID: 246584
		[Token(Token = "0x403C338")]
		[FieldOffset(Offset = "0x20")]
		private Act38sideMapDecorFireworkCraftViewModel m_cachedCraftViewModel;

		// Token: 0x0403C339 RID: 246585
		[Token(Token = "0x403C339")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x0403C33A RID: 246586
		[Token(Token = "0x403C33A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
