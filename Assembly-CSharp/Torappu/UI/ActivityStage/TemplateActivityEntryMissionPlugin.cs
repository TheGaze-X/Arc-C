using System;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C85 RID: 27781
	[Token(Token = "0x2006C85")]
	public class TemplateActivityEntryMissionPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06027A3F RID: 162367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A3F")]
		[Address(RVA = "0x22CD280", Offset = "0x22CBE80", VA = "0x1822CD280")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027A40 RID: 162368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A40")]
		[Address(RVA = "0x22CD030", Offset = "0x22CBC30", VA = "0x1822CD030", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A41 RID: 162369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A41")]
		[Address(RVA = "0x22CCF70", Offset = "0x22CBB70", VA = "0x1822CCF70")]
		public void OnMissionClick()
		{
		}

		// Token: 0x06027A42 RID: 162370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A42")]
		[Address(RVA = "0x22CD3A0", Offset = "0x22CBFA0", VA = "0x1822CD3A0")]
		public TemplateActivityEntryMissionPlugin()
		{
		}

		// Token: 0x0403838C RID: 230284
		[Token(Token = "0x403838C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403838D RID: 230285
		[Token(Token = "0x403838D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIActTrackPoint _actTrackPoint;

		// Token: 0x0403838E RID: 230286
		[Token(Token = "0x403838E")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0403838F RID: 230287
		[Token(Token = "0x403838F")]
		[FieldOffset(Offset = "0x40")]
		private TrackPointViewProperty m_trackPoint;

		// Token: 0x04038390 RID: 230288
		[Token(Token = "0x4038390")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038391 RID: 230289
		[Token(Token = "0x4038391")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038392 RID: 230290
		[Token(Token = "0x4038392")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMissionClick;

		// Token: 0x04038393 RID: 230291
		[Token(Token = "0x4038393")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
