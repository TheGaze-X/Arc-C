using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006971 RID: 26993
	[Token(Token = "0x2006971")]
	public class StagePreviewInfoHardPanel : StagePreviewInfoBasicPanel
	{
		// Token: 0x06026A09 RID: 158217 RVA: 0x000CBDC0 File Offset: 0x000C9FC0
		[Token(Token = "0x6026A09")]
		[Address(RVA = "0x21B3A50", Offset = "0x21B2650", VA = "0x1821B3A50", Slot = "6")]
		protected override bool OnZoneViewChanged(IStageSelectHandler zoneModel, StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06026A0A RID: 158218 RVA: 0x000CBDD8 File Offset: 0x000C9FD8
		[Token(Token = "0x6026A0A")]
		[Address(RVA = "0x21B3BA0", Offset = "0x21B27A0", VA = "0x1821B3BA0", Slot = "7")]
		protected override bool SelectStageViewModel(IStageSelectHandler zoneModel, out StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06026A0B RID: 158219 RVA: 0x000CBDF0 File Offset: 0x000C9FF0
		[Token(Token = "0x6026A0B")]
		[Address(RVA = "0x21B39B0", Offset = "0x21B25B0", VA = "0x1821B39B0", Slot = "8")]
		protected override bool CheckToShow(IStageSelectHandler zoneModel)
		{
			return default(bool);
		}

		// Token: 0x06026A0C RID: 158220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A0C")]
		[Address(RVA = "0x21B3CB0", Offset = "0x21B28B0", VA = "0x1821B3CB0")]
		public StagePreviewInfoHardPanel()
		{
		}

		// Token: 0x06026A0D RID: 158221 RVA: 0x000CBE08 File Offset: 0x000CA008
		[Token(Token = "0x6026A0D")]
		[Address(RVA = "0x214F1A0", Offset = "0x214DDA0", VA = "0x18214F1A0")]
		private bool <>xLuaBaseProxy_OnZoneViewChanged(IStageSelectHandler P0, StageViewModel P1)
		{
			return default(bool);
		}

		// Token: 0x0403685C RID: 223324
		[Token(Token = "0x403685C")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		protected StagePreviewRankView _rankView;

		// Token: 0x0403685D RID: 223325
		[Token(Token = "0x403685D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneViewChanged;

		// Token: 0x0403685E RID: 223326
		[Token(Token = "0x403685E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectStageViewModel;

		// Token: 0x0403685F RID: 223327
		[Token(Token = "0x403685F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckToShow;

		// Token: 0x04036860 RID: 223328
		[Token(Token = "0x4036860")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
