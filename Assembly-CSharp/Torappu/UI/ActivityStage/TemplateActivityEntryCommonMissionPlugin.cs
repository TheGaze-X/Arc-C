using System;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C80 RID: 27776
	[Token(Token = "0x2006C80")]
	public class TemplateActivityEntryCommonMissionPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06027A32 RID: 162354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A32")]
		[Address(RVA = "0x22CC090", Offset = "0x22CAC90", VA = "0x1822CC090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027A33 RID: 162355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A33")]
		[Address(RVA = "0x22CBE50", Offset = "0x22CAA50", VA = "0x1822CBE50", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A34 RID: 162356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A34")]
		[Address(RVA = "0x22CBD90", Offset = "0x22CA990", VA = "0x1822CBD90")]
		public void OnMissionClick()
		{
		}

		// Token: 0x06027A35 RID: 162357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A35")]
		[Address(RVA = "0x22CC1B0", Offset = "0x22CADB0", VA = "0x1822CC1B0")]
		public TemplateActivityEntryCommonMissionPlugin()
		{
		}

		// Token: 0x04038373 RID: 230259
		[Token(Token = "0x4038373")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x04038374 RID: 230260
		[Token(Token = "0x4038374")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIActTrackPoint _actTrackPoint;

		// Token: 0x04038375 RID: 230261
		[Token(Token = "0x4038375")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04038376 RID: 230262
		[Token(Token = "0x4038376")]
		[FieldOffset(Offset = "0x40")]
		private TrackPointViewProperty m_trackPoint;

		// Token: 0x04038377 RID: 230263
		[Token(Token = "0x4038377")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038378 RID: 230264
		[Token(Token = "0x4038378")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038379 RID: 230265
		[Token(Token = "0x4038379")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMissionClick;

		// Token: 0x0403837A RID: 230266
		[Token(Token = "0x403837A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
