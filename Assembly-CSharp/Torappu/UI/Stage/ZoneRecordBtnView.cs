using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068F5 RID: 26869
	[Token(Token = "0x20068F5")]
	public class ZoneRecordBtnView : StageAdditionalBtnView
	{
		// Token: 0x060267D5 RID: 157653 RVA: 0x000CB550 File Offset: 0x000C9750
		[Token(Token = "0x60267D5")]
		[Address(RVA = "0x21A5020", Offset = "0x21A3C20", VA = "0x1821A5020", Slot = "4")]
		public override bool OnUpdate(ZoneViewModel model)
		{
			return default(bool);
		}

		// Token: 0x060267D6 RID: 157654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60267D6")]
		[Address(RVA = "0x21A5220", Offset = "0x21A3E20", VA = "0x1821A5220")]
		private ZoneRecordBtnContentView _EnsureDynamicView(string zoneId)
		{
			return null;
		}

		// Token: 0x060267D7 RID: 157655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267D7")]
		[Address(RVA = "0x21A5520", Offset = "0x21A4120", VA = "0x1821A5520")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060267D8 RID: 157656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267D8")]
		[Address(RVA = "0x21A55B0", Offset = "0x21A41B0", VA = "0x1821A55B0")]
		public ZoneRecordBtnView()
		{
		}

		// Token: 0x040363A3 RID: 222115
		[Token(Token = "0x40363A3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICommonTrackPoint _recordRewardTrack;

		// Token: 0x040363A4 RID: 222116
		[Token(Token = "0x40363A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ZoneRecordBtnContentView _staticContentView;

		// Token: 0x040363A5 RID: 222117
		[Token(Token = "0x40363A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isDynamicContent;

		// Token: 0x040363A6 RID: 222118
		[Token(Token = "0x40363A6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _dynamicHolder;

		// Token: 0x040363A7 RID: 222119
		[Token(Token = "0x40363A7")]
		[FieldOffset(Offset = "0x38")]
		private TrackPointViewProperty m_recordRewardTrack;

		// Token: 0x040363A8 RID: 222120
		[Token(Token = "0x40363A8")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040363A9 RID: 222121
		[Token(Token = "0x40363A9")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x040363AA RID: 222122
		[Token(Token = "0x40363AA")]
		[FieldOffset(Offset = "0x58")]
		private string m_cacehdDynamicViewId;

		// Token: 0x040363AB RID: 222123
		[Token(Token = "0x40363AB")]
		[FieldOffset(Offset = "0x60")]
		private ZoneRecordBtnContentView m_dynamicView;

		// Token: 0x040363AC RID: 222124
		[Token(Token = "0x40363AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x040363AD RID: 222125
		[Token(Token = "0x40363AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureDynamicView;

		// Token: 0x040363AE RID: 222126
		[Token(Token = "0x40363AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040363AF RID: 222127
		[Token(Token = "0x40363AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
