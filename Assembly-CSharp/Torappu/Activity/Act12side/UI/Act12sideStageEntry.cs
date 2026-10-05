using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A70 RID: 31344
	[Token(Token = "0x2007A70")]
	public class Act12sideStageEntry : ActivityStageSingleComponent
	{
		// Token: 0x0602BE77 RID: 179831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE77")]
		[Address(RVA = "0x27C7C30", Offset = "0x27C6830", VA = "0x1827C7C30", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602BE78 RID: 179832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE78")]
		[Address(RVA = "0x27C7A00", Offset = "0x27C6600", VA = "0x1827C7A00")]
		public void OnBtnReplicateClick()
		{
		}

		// Token: 0x0602BE79 RID: 179833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE79")]
		[Address(RVA = "0x27C7990", Offset = "0x27C6590", VA = "0x1827C7990")]
		public void OnBtnMilestoneClick()
		{
		}

		// Token: 0x0602BE7A RID: 179834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE7A")]
		[Address(RVA = "0x27C7840", Offset = "0x27C6440", VA = "0x1827C7840")]
		public void OnBtnCharmRepo()
		{
		}

		// Token: 0x0602BE7B RID: 179835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE7B")]
		[Address(RVA = "0x27C7920", Offset = "0x27C6520", VA = "0x1827C7920")]
		public void OnBtnMedalClick()
		{
		}

		// Token: 0x0602BE7C RID: 179836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE7C")]
		[Address(RVA = "0x27C7A70", Offset = "0x27C6670", VA = "0x1827C7A70")]
		public void OnBtnShopClick()
		{
		}

		// Token: 0x0602BE7D RID: 179837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE7D")]
		[Address(RVA = "0x27C78B0", Offset = "0x27C64B0", VA = "0x1827C78B0")]
		public void OnBtnFavorUpClick()
		{
		}

		// Token: 0x0602BE7E RID: 179838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE7E")]
		private void _AddTopToActStateEngine<T>() where T : State
		{
		}

		// Token: 0x0602BE7F RID: 179839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE7F")]
		[Address(RVA = "0x27C7D50", Offset = "0x27C6950", VA = "0x1827C7D50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BE80 RID: 179840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE80")]
		[Address(RVA = "0x27C8350", Offset = "0x27C6F50", VA = "0x1827C8350")]
		public Act12sideStageEntry()
		{
		}

		// Token: 0x0602BE82 RID: 179842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE82")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0403F93E RID: 260414
		[Token(Token = "0x403F93E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403F93F RID: 260415
		[Token(Token = "0x403F93F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act12sideEntryView _view;

		// Token: 0x0403F940 RID: 260416
		[Token(Token = "0x403F940")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act12sideEntryZoneGroupView _zoneGroupView;

		// Token: 0x0403F941 RID: 260417
		[Token(Token = "0x403F941")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _milestoneTrackPoint;

		// Token: 0x0403F942 RID: 260418
		[Token(Token = "0x403F942")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _charmRecycleTrackPoint;

		// Token: 0x0403F943 RID: 260419
		[Token(Token = "0x403F943")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _charmFirstGotTrackPoint;

		// Token: 0x0403F944 RID: 260420
		[Token(Token = "0x403F944")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonTrackPoint _honorShowcaseTrackPoint;

		// Token: 0x0403F945 RID: 260421
		[Token(Token = "0x403F945")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActivityEntryAnimManager _entryAnimManager;

		// Token: 0x0403F946 RID: 260422
		[Token(Token = "0x403F946")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ActivityCommonFavorUpEntryView _favorUpView;

		// Token: 0x0403F947 RID: 260423
		[Token(Token = "0x403F947")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0403F948 RID: 260424
		[Token(Token = "0x403F948")]
		[FieldOffset(Offset = "0x70")]
		private IActAnimContext m_enterAnimContext;

		// Token: 0x0403F949 RID: 260425
		[Token(Token = "0x403F949")]
		[FieldOffset(Offset = "0x78")]
		private IActAnimContext m_loopAnimContext;

		// Token: 0x0403F94A RID: 260426
		[Token(Token = "0x403F94A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403F94B RID: 260427
		[Token(Token = "0x403F94B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBtnReplicateClick;

		// Token: 0x0403F94C RID: 260428
		[Token(Token = "0x403F94C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnMilestoneClick;

		// Token: 0x0403F94D RID: 260429
		[Token(Token = "0x403F94D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnCharmRepo;

		// Token: 0x0403F94E RID: 260430
		[Token(Token = "0x403F94E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnMedalClick;

		// Token: 0x0403F94F RID: 260431
		[Token(Token = "0x403F94F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBtnShopClick;

		// Token: 0x0403F950 RID: 260432
		[Token(Token = "0x403F950")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnFavorUpClick;

		// Token: 0x0403F951 RID: 260433
		[Token(Token = "0x403F951")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AddTopToActStateEngine;

		// Token: 0x0403F952 RID: 260434
		[Token(Token = "0x403F952")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F953 RID: 260435
		[Token(Token = "0x403F953")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A71 RID: 31345
		[Token(Token = "0x2007A71")]
		private class Act12sideAnimContext : DefaultActAnimContext
		{
			// Token: 0x0602BE83 RID: 179843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BE83")]
			[Address(RVA = "0x27C20A0", Offset = "0x27C0CA0", VA = "0x1827C20A0")]
			public Act12sideAnimContext(string activityId, ActivityStageController actController)
			{
			}

			// Token: 0x0602BE84 RID: 179844 RVA: 0x000DDA48 File Offset: 0x000DBC48
			[Token(Token = "0x602BE84")]
			[Address(RVA = "0x27C1FD0", Offset = "0x27C0BD0", VA = "0x1827C1FD0", Slot = "6")]
			public override bool CanSkipAnim()
			{
				return default(bool);
			}

			// Token: 0x0602BE85 RID: 179845 RVA: 0x000DDA60 File Offset: 0x000DBC60
			[Token(Token = "0x602BE85")]
			[Address(RVA = "0x27C2040", Offset = "0x27C0C40", VA = "0x1827C2040")]
			private bool _IsBackFromBattle()
			{
				return default(bool);
			}

			// Token: 0x0403F954 RID: 260436
			[Token(Token = "0x403F954")]
			[FieldOffset(Offset = "0x18")]
			private ActivityStageController m_actController;
		}
	}
}
