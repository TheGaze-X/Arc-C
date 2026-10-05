using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.TemplateMission;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006813 RID: 26643
	[Token(Token = "0x2006813")]
	public class StageMainlineRetroMapDecroView : StageSideStoryMapDecroViewBase, IHotfixable
	{
		// Token: 0x060262D0 RID: 156368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262D0")]
		[Address(RVA = "0x213C430", Offset = "0x213B030", VA = "0x18213C430", Slot = "4")]
		public override void OnRefresh(List<ZoneViewModel> viewModelList, ZoneViewModel selectViewModel)
		{
		}

		// Token: 0x060262D1 RID: 156369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262D1")]
		[Address(RVA = "0x213C2E0", Offset = "0x213AEE0", VA = "0x18213C2E0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060262D2 RID: 156370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262D2")]
		[Address(RVA = "0x213C570", Offset = "0x213B170", VA = "0x18213C570")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060262D3 RID: 156371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262D3")]
		[Address(RVA = "0x213C7F0", Offset = "0x213B3F0", VA = "0x18213C7F0")]
		public StageMainlineRetroMapDecroView()
		{
		}

		// Token: 0x04035C7B RID: 220283
		[Token(Token = "0x4035C7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _actMissionGroupId;

		// Token: 0x04035C7C RID: 220284
		[Token(Token = "0x4035C7C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _retroMissionGroupId;

		// Token: 0x04035C7D RID: 220285
		[Token(Token = "0x4035C7D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _permanentId;

		// Token: 0x04035C7E RID: 220286
		[Token(Token = "0x4035C7E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x04035C7F RID: 220287
		[Token(Token = "0x4035C7F")]
		[FieldOffset(Offset = "0x40")]
		private TemplateMissionViewModel m_viewModel;

		// Token: 0x04035C80 RID: 220288
		[Token(Token = "0x4035C80")]
		[FieldOffset(Offset = "0x48")]
		private TemplateMissionInputParam m_inputParam;

		// Token: 0x04035C81 RID: 220289
		[Token(Token = "0x4035C81")]
		[FieldOffset(Offset = "0x50")]
		private TrackPointViewProperty m_trackPoint;

		// Token: 0x04035C82 RID: 220290
		[Token(Token = "0x4035C82")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x04035C83 RID: 220291
		[Token(Token = "0x4035C83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x04035C84 RID: 220292
		[Token(Token = "0x4035C84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04035C85 RID: 220293
		[Token(Token = "0x4035C85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035C86 RID: 220294
		[Token(Token = "0x4035C86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006814 RID: 26644
		[Token(Token = "0x2006814")]
		public class StageMainlineRetroMissionTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x17005A45 RID: 23109
			// (get) Token: 0x060262D4 RID: 156372 RVA: 0x000CA4A0 File Offset: 0x000C86A0
			[Token(Token = "0x17005A45")]
			public bool isShow
			{
				[Token(Token = "0x60262D4")]
				[Address(RVA = "0x213CA40", Offset = "0x213B640", VA = "0x18213CA40", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060262D5 RID: 156373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60262D5")]
			[Address(RVA = "0x213C910", Offset = "0x213B510", VA = "0x18213C910", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x060262D6 RID: 156374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60262D6")]
			[Address(RVA = "0x213C9E0", Offset = "0x213B5E0", VA = "0x18213C9E0")]
			public StageMainlineRetroMissionTrackPointModel()
			{
			}

			// Token: 0x04035C87 RID: 220295
			[Token(Token = "0x4035C87")]
			[FieldOffset(Offset = "0x10")]
			private bool m_hasCanGetRewardMission;

			// Token: 0x04035C88 RID: 220296
			[Token(Token = "0x4035C88")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04035C89 RID: 220297
			[Token(Token = "0x4035C89")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04035C8A RID: 220298
			[Token(Token = "0x4035C8A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02006815 RID: 26645
			[Token(Token = "0x2006815")]
			public class Param
			{
				// Token: 0x060262D7 RID: 156375 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60262D7")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x04035C8B RID: 220299
				[Token(Token = "0x4035C8B")]
				[FieldOffset(Offset = "0x10")]
				public bool hasCanGetRewardMission;
			}
		}
	}
}
