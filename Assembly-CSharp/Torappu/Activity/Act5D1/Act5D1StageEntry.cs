using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007225 RID: 29221
	[Token(Token = "0x2007225")]
	public class Act5D1StageEntry : ActivityStageSingleComponent, IHotfixable
	{
		// Token: 0x060296AE RID: 169646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296AE")]
		[Address(RVA = "0x24D26D0", Offset = "0x24D12D0", VA = "0x1824D26D0")]
		private void _InitTrack()
		{
		}

		// Token: 0x060296AF RID: 169647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296AF")]
		[Address(RVA = "0x24D2430", Offset = "0x24D1030", VA = "0x1824D2430")]
		public void OnBannedEveryButton()
		{
		}

		// Token: 0x060296B0 RID: 169648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B0")]
		[Address(RVA = "0x24D2580", Offset = "0x24D1180", VA = "0x1824D2580")]
		public void OnBannedStageButton()
		{
		}

		// Token: 0x060296B1 RID: 169649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B1")]
		[Address(RVA = "0x24D2760", Offset = "0x24D1360", VA = "0x1824D2760")]
		private void _RenderInfoWithData()
		{
		}

		// Token: 0x060296B2 RID: 169650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B2")]
		[Address(RVA = "0x24D22F0", Offset = "0x24D0EF0", VA = "0x1824D22F0")]
		public void InitData()
		{
		}

		// Token: 0x060296B3 RID: 169651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B3")]
		[Address(RVA = "0x24D2C30", Offset = "0x24D1830", VA = "0x1824D2C30")]
		public Act5D1StageEntry()
		{
		}

		// Token: 0x0403B262 RID: 242274
		[Token(Token = "0x403B262")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act5D1StageEntryButtonObj _periodObj;

		// Token: 0x0403B263 RID: 242275
		[Token(Token = "0x403B263")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act5D1StageEntryButtonObj _perpetualObj;

		// Token: 0x0403B264 RID: 242276
		[Token(Token = "0x403B264")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIActTrackPoint _missionTrackPoint;

		// Token: 0x0403B265 RID: 242277
		[Token(Token = "0x403B265")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _coinCount;

		// Token: 0x0403B266 RID: 242278
		[Token(Token = "0x403B266")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _coinName;

		// Token: 0x0403B267 RID: 242279
		[Token(Token = "0x403B267")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _periodTimeOutButton;

		// Token: 0x0403B268 RID: 242280
		[Token(Token = "0x403B268")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _perpetualOutButton;

		// Token: 0x0403B269 RID: 242281
		[Token(Token = "0x403B269")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _missionBtn;

		// Token: 0x0403B26A RID: 242282
		[Token(Token = "0x403B26A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _shopBtn;

		// Token: 0x0403B26B RID: 242283
		[Token(Token = "0x403B26B")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_missionTrackPoint;

		// Token: 0x0403B26C RID: 242284
		[Token(Token = "0x403B26C")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0403B26D RID: 242285
		[Token(Token = "0x403B26D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitTrack;

		// Token: 0x0403B26E RID: 242286
		[Token(Token = "0x403B26E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBannedEveryButton;

		// Token: 0x0403B26F RID: 242287
		[Token(Token = "0x403B26F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBannedStageButton;

		// Token: 0x0403B270 RID: 242288
		[Token(Token = "0x403B270")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderInfoWithData;

		// Token: 0x0403B271 RID: 242289
		[Token(Token = "0x403B271")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403B272 RID: 242290
		[Token(Token = "0x403B272")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
