using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main10
{
	// Token: 0x02006A3D RID: 27197
	[Token(Token = "0x2006A3D")]
	public class Main10ZoneRecordController : ZoneRecordController
	{
		// Token: 0x06026DF9 RID: 159225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DF9")]
		[Address(RVA = "0x21ECC00", Offset = "0x21EB800", VA = "0x1821ECC00", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06026DFA RID: 159226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DFA")]
		[Address(RVA = "0x21ED4B0", Offset = "0x21EC0B0", VA = "0x1821ED4B0", Slot = "5")]
		public override void OnEnter(string zoneId)
		{
		}

		// Token: 0x06026DFB RID: 159227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DFB")]
		[Address(RVA = "0x21ED770", Offset = "0x21EC370", VA = "0x1821ED770", Slot = "6")]
		public override void OnResume(bool isFromStack)
		{
		}

		// Token: 0x06026DFC RID: 159228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DFC")]
		[Address(RVA = "0x21EDC20", Offset = "0x21EC820", VA = "0x1821EDC20")]
		private void _OnBtnBackClick()
		{
		}

		// Token: 0x06026DFD RID: 159229 RVA: 0x000CC8E8 File Offset: 0x000CAAE8
		[Token(Token = "0x6026DFD")]
		[Address(RVA = "0x21EE250", Offset = "0x21ECE50", VA = "0x1821EE250")]
		private bool _TryTrigUnlockAnim()
		{
			return default(bool);
		}

		// Token: 0x06026DFE RID: 159230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DFE")]
		[Address(RVA = "0x21EE000", Offset = "0x21ECC00", VA = "0x1821EE000")]
		private void _TryJumpToNewestNote()
		{
		}

		// Token: 0x06026DFF RID: 159231 RVA: 0x000CC900 File Offset: 0x000CAB00
		[Token(Token = "0x6026DFF")]
		[Address(RVA = "0x21EE1C0", Offset = "0x21ECDC0", VA = "0x1821EE1C0")]
		private bool _TryTrigGuid()
		{
			return default(bool);
		}

		// Token: 0x06026E00 RID: 159232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E00")]
		[Address(RVA = "0x21EDAD0", Offset = "0x21EC6D0", VA = "0x1821EDAD0")]
		private void _JumpToRecordPageByIdx(int idx)
		{
		}

		// Token: 0x06026E01 RID: 159233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E01")]
		[Address(RVA = "0x21EDEE0", Offset = "0x21ECAE0", VA = "0x1821EDEE0")]
		private void _OnRecordDetailClick(StageDiffGroup diff)
		{
		}

		// Token: 0x06026E02 RID: 159234 RVA: 0x000CC918 File Offset: 0x000CAB18
		[Token(Token = "0x6026E02")]
		[Address(RVA = "0x21ECAE0", Offset = "0x21EB6E0", VA = "0x1821ECAE0")]
		public int GetLatestRocordIdx()
		{
			return 0;
		}

		// Token: 0x06026E03 RID: 159235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E03")]
		[Address(RVA = "0x21EDCF0", Offset = "0x21EC8F0", VA = "0x1821EDCF0")]
		private void _OnGetReward(ZoneRecordRewardResponse resp)
		{
		}

		// Token: 0x06026E04 RID: 159236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E04")]
		[Address(RVA = "0x21EE3B0", Offset = "0x21ECFB0", VA = "0x1821EE3B0")]
		private void _UpdateRecordUnlockInfo(List<ItemGet> items, ZoneRecordUnlockData unlockData)
		{
		}

		// Token: 0x06026E05 RID: 159237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E05")]
		[Address(RVA = "0x21ED010", Offset = "0x21EBC10", VA = "0x1821ED010")]
		public void OnContentClick(string recordId)
		{
		}

		// Token: 0x06026E06 RID: 159238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E06")]
		[Address(RVA = "0x21ED390", Offset = "0x21EBF90", VA = "0x1821ED390")]
		public void OnDetailClose()
		{
		}

		// Token: 0x06026E07 RID: 159239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E07")]
		[Address(RVA = "0x21ECF80", Offset = "0x21EBB80", VA = "0x1821ECF80")]
		public void OnAllRewardClose()
		{
		}

		// Token: 0x06026E08 RID: 159240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E08")]
		[Address(RVA = "0x21ED200", Offset = "0x21EBE00", VA = "0x1821ED200")]
		public void OnCoverClick()
		{
		}

		// Token: 0x06026E09 RID: 159241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E09")]
		[Address(RVA = "0x21ED1A0", Offset = "0x21EBDA0", VA = "0x1821ED1A0")]
		public void OnCoverArrowClick()
		{
		}

		// Token: 0x06026E0A RID: 159242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E0A")]
		[Address(RVA = "0x21EC920", Offset = "0x21EB520", VA = "0x1821EC920")]
		public void EventOnNormalNoteClick()
		{
		}

		// Token: 0x06026E0B RID: 159243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E0B")]
		[Address(RVA = "0x21ECA80", Offset = "0x21EB680", VA = "0x1821ECA80")]
		public void EventOnToughNoteClick()
		{
		}

		// Token: 0x06026E0C RID: 159244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E0C")]
		[Address(RVA = "0x21EC6B0", Offset = "0x21EB2B0", VA = "0x1821EC6B0")]
		public void EventOnAllRewardClick()
		{
		}

		// Token: 0x06026E0D RID: 159245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E0D")]
		[Address(RVA = "0x21EC790", Offset = "0x21EB390", VA = "0x1821EC790")]
		public void EventOnHideTips()
		{
		}

		// Token: 0x06026E0E RID: 159246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E0E")]
		[Address(RVA = "0x21EC850", Offset = "0x21EB450", VA = "0x1821EC850")]
		public void EventOnNextNote()
		{
		}

		// Token: 0x06026E0F RID: 159247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E0F")]
		[Address(RVA = "0x21EC980", Offset = "0x21EB580", VA = "0x1821EC980")]
		public void EventOnPrevNote()
		{
		}

		// Token: 0x06026E10 RID: 159248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E10")]
		[Address(RVA = "0x21ED990", Offset = "0x21EC590", VA = "0x1821ED990")]
		public void SendGetRecordReward()
		{
		}

		// Token: 0x06026E11 RID: 159249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E11")]
		[Address(RVA = "0x21EE4D0", Offset = "0x21ED0D0", VA = "0x1821EE4D0")]
		public Main10ZoneRecordController()
		{
		}

		// Token: 0x06026E12 RID: 159250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E12")]
		[Address(RVA = "0x21EDAA0", Offset = "0x21EC6A0", VA = "0x1821EDAA0")]
		private void <>xLuaBaseProxy_Init()
		{
		}

		// Token: 0x06026E13 RID: 159251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E13")]
		[Address(RVA = "0x21EDAB0", Offset = "0x21EC6B0", VA = "0x1821EDAB0")]
		private void <>xLuaBaseProxy_OnEnter(string P0)
		{
		}

		// Token: 0x06026E14 RID: 159252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E14")]
		[Address(RVA = "0x21EDAC0", Offset = "0x21EC6C0", VA = "0x1821EDAC0")]
		private void <>xLuaBaseProxy_OnResume(bool P0)
		{
		}

		// Token: 0x04036F85 RID: 225157
		[Token(Token = "0x4036F85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04036F86 RID: 225158
		[Token(Token = "0x4036F86")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Main10ZoneRecordCommonView _commonView;

		// Token: 0x04036F87 RID: 225159
		[Token(Token = "0x4036F87")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Main10ZoneRecordDetailView _detailView;

		// Token: 0x04036F88 RID: 225160
		[Token(Token = "0x4036F88")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Main10ZoneRecordAllRewardView _rewardsView;

		// Token: 0x04036F89 RID: 225161
		[Token(Token = "0x4036F89")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIBlurFloatPanel _panelReward;

		// Token: 0x04036F8A RID: 225162
		[Token(Token = "0x4036F8A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIBlurFloatPanel _panelDetail;

		// Token: 0x04036F8B RID: 225163
		[Token(Token = "0x4036F8B")]
		[FieldOffset(Offset = "0x58")]
		private Main10ZoneRecordViewProperty m_recordProperty;

		// Token: 0x04036F8C RID: 225164
		[Token(Token = "0x4036F8C")]
		[FieldOffset(Offset = "0x60")]
		private ZoneRecordGroupData m_cachedGroupData;

		// Token: 0x04036F8D RID: 225165
		[Token(Token = "0x4036F8D")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedRewardKey;

		// Token: 0x04036F8E RID: 225166
		[Token(Token = "0x4036F8E")]
		private const string FIRST_UNLOCK_CACHE_KEY = "record_first_unlockd_{0}";

		// Token: 0x04036F8F RID: 225167
		[Token(Token = "0x4036F8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04036F90 RID: 225168
		[Token(Token = "0x4036F90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036F91 RID: 225169
		[Token(Token = "0x4036F91")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04036F92 RID: 225170
		[Token(Token = "0x4036F92")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBtnBackClick;

		// Token: 0x04036F93 RID: 225171
		[Token(Token = "0x4036F93")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryTrigUnlockAnim;

		// Token: 0x04036F94 RID: 225172
		[Token(Token = "0x4036F94")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryJumpToNewestNote;

		// Token: 0x04036F95 RID: 225173
		[Token(Token = "0x4036F95")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryTrigGuid;

		// Token: 0x04036F96 RID: 225174
		[Token(Token = "0x4036F96")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__JumpToRecordPageByIdx;

		// Token: 0x04036F97 RID: 225175
		[Token(Token = "0x4036F97")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnRecordDetailClick;

		// Token: 0x04036F98 RID: 225176
		[Token(Token = "0x4036F98")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetLatestRocordIdx;

		// Token: 0x04036F99 RID: 225177
		[Token(Token = "0x4036F99")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnGetReward;

		// Token: 0x04036F9A RID: 225178
		[Token(Token = "0x4036F9A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateRecordUnlockInfo;

		// Token: 0x04036F9B RID: 225179
		[Token(Token = "0x4036F9B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnContentClick;

		// Token: 0x04036F9C RID: 225180
		[Token(Token = "0x4036F9C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnDetailClose;

		// Token: 0x04036F9D RID: 225181
		[Token(Token = "0x4036F9D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnAllRewardClose;

		// Token: 0x04036F9E RID: 225182
		[Token(Token = "0x4036F9E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnCoverClick;

		// Token: 0x04036F9F RID: 225183
		[Token(Token = "0x4036F9F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnCoverArrowClick;

		// Token: 0x04036FA0 RID: 225184
		[Token(Token = "0x4036FA0")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnNormalNoteClick;

		// Token: 0x04036FA1 RID: 225185
		[Token(Token = "0x4036FA1")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnToughNoteClick;

		// Token: 0x04036FA2 RID: 225186
		[Token(Token = "0x4036FA2")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnAllRewardClick;

		// Token: 0x04036FA3 RID: 225187
		[Token(Token = "0x4036FA3")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnHideTips;

		// Token: 0x04036FA4 RID: 225188
		[Token(Token = "0x4036FA4")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnNextNote;

		// Token: 0x04036FA5 RID: 225189
		[Token(Token = "0x4036FA5")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnPrevNote;

		// Token: 0x04036FA6 RID: 225190
		[Token(Token = "0x4036FA6")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SendGetRecordReward;

		// Token: 0x04036FA7 RID: 225191
		[Token(Token = "0x4036FA7")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
