using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046ED RID: 18157
	[Token(Token = "0x20046ED")]
	public class RecruitBuildConfigState : PopupFloatState
	{
		// Token: 0x0601B868 RID: 112744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B868")]
		[Address(RVA = "0x14DDC60", Offset = "0x14DC860", VA = "0x1814DDC60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601B869 RID: 112745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B869")]
		[Address(RVA = "0x14DDD90", Offset = "0x14DC990", VA = "0x1814DDD90", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601B86A RID: 112746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B86A")]
		[Address(RVA = "0x14DDC00", Offset = "0x14DC800", VA = "0x1814DDC00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601B86B RID: 112747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B86B")]
		[Address(RVA = "0x14DDE20", Offset = "0x14DCA20", VA = "0x1814DDE20", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601B86C RID: 112748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B86C")]
		[Address(RVA = "0x14DDB20", Offset = "0x14DC720", VA = "0x1814DDB20")]
		public void EventOnUpHourClick()
		{
		}

		// Token: 0x0601B86D RID: 112749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B86D")]
		[Address(RVA = "0x14DD450", Offset = "0x14DC050", VA = "0x1814DD450")]
		public void EventOnDownHourClick()
		{
		}

		// Token: 0x0601B86E RID: 112750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B86E")]
		[Address(RVA = "0x14DDB90", Offset = "0x14DC790", VA = "0x1814DDB90")]
		public void EventOnUpMinuteClick()
		{
		}

		// Token: 0x0601B86F RID: 112751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B86F")]
		[Address(RVA = "0x14DD4C0", Offset = "0x14DC0C0", VA = "0x1814DD4C0")]
		public void EventOnDownMinuteClick()
		{
		}

		// Token: 0x0601B870 RID: 112752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B870")]
		[Address(RVA = "0x14DD1B0", Offset = "0x14DBDB0", VA = "0x1814DD1B0")]
		public void EventOnConfirmClick()
		{
		}

		// Token: 0x0601B871 RID: 112753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B871")]
		[Address(RVA = "0x14DD530", Offset = "0x14DC130", VA = "0x1814DD530")]
		public void EventOnRefreshClick()
		{
		}

		// Token: 0x0601B872 RID: 112754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B872")]
		[Address(RVA = "0x14DD9A0", Offset = "0x14DC5A0", VA = "0x1814DD9A0")]
		public void EventOnSpreadDetail()
		{
		}

		// Token: 0x0601B873 RID: 112755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B873")]
		[Address(RVA = "0x14DDAA0", Offset = "0x14DC6A0", VA = "0x1814DDAA0")]
		public void EventOnUnSpreadDetail()
		{
		}

		// Token: 0x0601B874 RID: 112756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B874")]
		[Address(RVA = "0x14DD120", Offset = "0x14DBD20", VA = "0x1814DD120")]
		public void EventOnCancelClick()
		{
		}

		// Token: 0x0601B875 RID: 112757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B875")]
		[Address(RVA = "0x14DDA20", Offset = "0x14DC620", VA = "0x1814DDA20")]
		public void EventOnTagClick(int tagIndex)
		{
		}

		// Token: 0x0601B876 RID: 112758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B876")]
		[Address(RVA = "0x14DE000", Offset = "0x14DCC00", VA = "0x1814DE000")]
		private void _OnStartBuildSucceed(NormalGachaResponse response)
		{
		}

		// Token: 0x0601B877 RID: 112759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B877")]
		[Address(RVA = "0x14DE3E0", Offset = "0x14DCFE0", VA = "0x1814DE3E0")]
		private void _SendStartBuild()
		{
		}

		// Token: 0x0601B878 RID: 112760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B878")]
		[Address(RVA = "0x14DE0A0", Offset = "0x14DCCA0", VA = "0x1814DE0A0")]
		private void _RefreshTags()
		{
		}

		// Token: 0x0601B879 RID: 112761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B879")]
		[Address(RVA = "0x14DE5D0", Offset = "0x14DD1D0", VA = "0x1814DE5D0")]
		public RecruitBuildConfigState()
		{
		}

		// Token: 0x0601B87D RID: 112765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B87D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601B87E RID: 112766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B87E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601B87F RID: 112767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B87F")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04023A90 RID: 146064
		[Token(Token = "0x4023A90")]
		public const long MINUTE_MILLSEC_UNIT = 600000L;

		// Token: 0x04023A91 RID: 146065
		[Token(Token = "0x4023A91")]
		private const long HOUR_MILLSEC_UNIT = 3600000L;

		// Token: 0x04023A92 RID: 146066
		[Token(Token = "0x4023A92")]
		private const string ANIMATOR_PARAM = "SPREAD";

		// Token: 0x04023A93 RID: 146067
		[Token(Token = "0x4023A93")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RecruitBuildConfigStateBean _stateBean;

		// Token: 0x04023A94 RID: 146068
		[Token(Token = "0x4023A94")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Animator _spreadAnim;

		// Token: 0x04023A95 RID: 146069
		[Token(Token = "0x4023A95")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04023A96 RID: 146070
		[Token(Token = "0x4023A96")]
		[FieldOffset(Offset = "0x88")]
		private RefCountReference m_buildingContextRef;

		// Token: 0x04023A97 RID: 146071
		[Token(Token = "0x4023A97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04023A98 RID: 146072
		[Token(Token = "0x4023A98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04023A99 RID: 146073
		[Token(Token = "0x4023A99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04023A9A RID: 146074
		[Token(Token = "0x4023A9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04023A9B RID: 146075
		[Token(Token = "0x4023A9B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnUpHourClick;

		// Token: 0x04023A9C RID: 146076
		[Token(Token = "0x4023A9C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnDownHourClick;

		// Token: 0x04023A9D RID: 146077
		[Token(Token = "0x4023A9D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnUpMinuteClick;

		// Token: 0x04023A9E RID: 146078
		[Token(Token = "0x4023A9E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnDownMinuteClick;

		// Token: 0x04023A9F RID: 146079
		[Token(Token = "0x4023A9F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClick;

		// Token: 0x04023AA0 RID: 146080
		[Token(Token = "0x4023AA0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnRefreshClick;

		// Token: 0x04023AA1 RID: 146081
		[Token(Token = "0x4023AA1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnSpreadDetail;

		// Token: 0x04023AA2 RID: 146082
		[Token(Token = "0x4023AA2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnUnSpreadDetail;

		// Token: 0x04023AA3 RID: 146083
		[Token(Token = "0x4023AA3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnCancelClick;

		// Token: 0x04023AA4 RID: 146084
		[Token(Token = "0x4023AA4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnTagClick;

		// Token: 0x04023AA5 RID: 146085
		[Token(Token = "0x4023AA5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnStartBuildSucceed;

		// Token: 0x04023AA6 RID: 146086
		[Token(Token = "0x4023AA6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SendStartBuild;

		// Token: 0x04023AA7 RID: 146087
		[Token(Token = "0x4023AA7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshTags;

		// Token: 0x04023AA8 RID: 146088
		[Token(Token = "0x4023AA8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
