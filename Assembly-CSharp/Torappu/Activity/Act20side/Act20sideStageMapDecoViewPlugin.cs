using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200765C RID: 30300
	[Token(Token = "0x200765C")]
	public class Act20sideStageMapDecoViewPlugin : StageSideStoryMapDecroViewPlugin, IHotfixable
	{
		// Token: 0x0602A9E6 RID: 174566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9E6")]
		[Address(RVA = "0x265AF70", Offset = "0x2659B70", VA = "0x18265AF70", Slot = "4")]
		public override void OnRefresh(StageSideStoryMapDecroViewPluginParams param)
		{
		}

		// Token: 0x0602A9E7 RID: 174567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9E7")]
		[Address(RVA = "0x265AE40", Offset = "0x2659A40", VA = "0x18265AE40")]
		public void OnCarClick()
		{
		}

		// Token: 0x0602A9E8 RID: 174568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9E8")]
		[Address(RVA = "0x265B060", Offset = "0x2659C60", VA = "0x18265B060")]
		public Act20sideStageMapDecoViewPlugin()
		{
		}

		// Token: 0x0403D60B RID: 251403
		[Token(Token = "0x403D60B")]
		[FieldOffset(Offset = "0x18")]
		private string m_cachedGroupId;

		// Token: 0x0403D60C RID: 251404
		[Token(Token = "0x403D60C")]
		[FieldOffset(Offset = "0x20")]
		private string m_cachedZoneId;

		// Token: 0x0403D60D RID: 251405
		[Token(Token = "0x403D60D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x0403D60E RID: 251406
		[Token(Token = "0x403D60E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCarClick;

		// Token: 0x0403D60F RID: 251407
		[Token(Token = "0x403D60F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
