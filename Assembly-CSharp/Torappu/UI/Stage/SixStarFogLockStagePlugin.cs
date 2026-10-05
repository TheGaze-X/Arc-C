using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200684E RID: 26702
	[Token(Token = "0x200684E")]
	public class SixStarFogLockStagePlugin : StageButtonHolderPlugin
	{
		// Token: 0x0602638B RID: 156555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602638B")]
		[Address(RVA = "0x21488D0", Offset = "0x21474D0", VA = "0x1821488D0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602638C RID: 156556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602638C")]
		[Address(RVA = "0x2148C00", Offset = "0x2147800", VA = "0x182148C00", Slot = "5")]
		protected override void OnRenderStage(StageViewModel model)
		{
		}

		// Token: 0x0602638D RID: 156557 RVA: 0x000CA680 File Offset: 0x000C8880
		[Token(Token = "0x602638D")]
		[Address(RVA = "0x2148F50", Offset = "0x2147B50", VA = "0x182148F50")]
		private bool _TryHandleMainStageButtonOnMap(StageButtonOnMap stageButton)
		{
			return default(bool);
		}

		// Token: 0x0602638E RID: 156558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602638E")]
		[Address(RVA = "0x2149120", Offset = "0x2147D20", VA = "0x182149120")]
		public SixStarFogLockStagePlugin()
		{
		}

		// Token: 0x04035E01 RID: 220673
		[Token(Token = "0x4035E01")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_BUTTON_MASK;

		// Token: 0x04035E02 RID: 220674
		[Token(Token = "0x4035E02")]
		[FieldOffset(Offset = "0x28")]
		private StageFogInfo m_stageFogInfo;

		// Token: 0x04035E03 RID: 220675
		[Token(Token = "0x4035E03")]
		[FieldOffset(Offset = "0x30")]
		private StageFogOnButton m_panelFog;

		// Token: 0x04035E04 RID: 220676
		[Token(Token = "0x4035E04")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035E05 RID: 220677
		[Token(Token = "0x4035E05")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04035E06 RID: 220678
		[Token(Token = "0x4035E06")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRenderStage;

		// Token: 0x04035E07 RID: 220679
		[Token(Token = "0x4035E07")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryHandleMainStageButtonOnMap;

		// Token: 0x04035E08 RID: 220680
		[Token(Token = "0x4035E08")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
