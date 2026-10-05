using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079EB RID: 31211
	[Token(Token = "0x20079EB")]
	public class Act13sideEntryMissionButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602BC01 RID: 179201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC01")]
		[Address(RVA = "0x279C3C0", Offset = "0x279AFC0", VA = "0x18279C3C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BC02 RID: 179202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC02")]
		[Address(RVA = "0x279C1B0", Offset = "0x279ADB0", VA = "0x18279C1B0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602BC03 RID: 179203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC03")]
		[Address(RVA = "0x279C4A0", Offset = "0x279B0A0", VA = "0x18279C4A0")]
		public Act13sideEntryMissionButtonPlugin()
		{
		}

		// Token: 0x0403F4C0 RID: 259264
		[Token(Token = "0x403F4C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403F4C1 RID: 259265
		[Token(Token = "0x403F4C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _newTrackPoint;

		// Token: 0x0403F4C2 RID: 259266
		[Token(Token = "0x403F4C2")]
		[FieldOffset(Offset = "0x38")]
		private TrackPointViewProperty m_property;

		// Token: 0x0403F4C3 RID: 259267
		[Token(Token = "0x403F4C3")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403F4C4 RID: 259268
		[Token(Token = "0x403F4C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F4C5 RID: 259269
		[Token(Token = "0x403F4C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403F4C6 RID: 259270
		[Token(Token = "0x403F4C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
