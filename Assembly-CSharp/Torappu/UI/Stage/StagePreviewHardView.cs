using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006926 RID: 26918
	[Token(Token = "0x2006926")]
	public class StagePreviewHardView : StagePreviewInfoBasicPanel
	{
		// Token: 0x060268E1 RID: 157921 RVA: 0x000CBA48 File Offset: 0x000C9C48
		[Token(Token = "0x60268E1")]
		[Address(RVA = "0x21B0750", Offset = "0x21AF350", VA = "0x1821B0750", Slot = "6")]
		protected override bool OnZoneViewChanged(IStageSelectHandler zoneModel, StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x060268E2 RID: 157922 RVA: 0x000CBA60 File Offset: 0x000C9C60
		[Token(Token = "0x60268E2")]
		[Address(RVA = "0x21B08A0", Offset = "0x21AF4A0", VA = "0x1821B08A0", Slot = "7")]
		protected override bool SelectStageViewModel(IStageSelectHandler zoneModel, out StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x060268E3 RID: 157923 RVA: 0x000CBA78 File Offset: 0x000C9C78
		[Token(Token = "0x60268E3")]
		[Address(RVA = "0x21B06B0", Offset = "0x21AF2B0", VA = "0x1821B06B0", Slot = "8")]
		protected override bool CheckToShow(IStageSelectHandler zoneModel)
		{
			return default(bool);
		}

		// Token: 0x060268E4 RID: 157924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268E4")]
		[Address(RVA = "0x21B09B0", Offset = "0x21AF5B0", VA = "0x1821B09B0")]
		public StagePreviewHardView()
		{
		}

		// Token: 0x060268E5 RID: 157925 RVA: 0x000CBA90 File Offset: 0x000C9C90
		[Token(Token = "0x60268E5")]
		[Address(RVA = "0x214F1A0", Offset = "0x214DDA0", VA = "0x18214F1A0")]
		private bool <>xLuaBaseProxy_OnZoneViewChanged(IStageSelectHandler P0, StageViewModel P1)
		{
			return default(bool);
		}

		// Token: 0x0403660F RID: 222735
		[Token(Token = "0x403660F")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		protected StagePreviewRankView _rankView;

		// Token: 0x04036610 RID: 222736
		[Token(Token = "0x4036610")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneViewChanged;

		// Token: 0x04036611 RID: 222737
		[Token(Token = "0x4036611")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectStageViewModel;

		// Token: 0x04036612 RID: 222738
		[Token(Token = "0x4036612")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckToShow;

		// Token: 0x04036613 RID: 222739
		[Token(Token = "0x4036613")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
