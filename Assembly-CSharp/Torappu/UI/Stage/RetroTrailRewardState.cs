using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200687A RID: 26746
	[Token(Token = "0x200687A")]
	public class RetroTrailRewardState : PopupFadeState
	{
		// Token: 0x060264E2 RID: 156898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60264E2")]
		[Address(RVA = "0x215FF20", Offset = "0x215EB20", VA = "0x18215FF20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060264E3 RID: 156899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60264E3")]
		[Address(RVA = "0x2160430", Offset = "0x215F030", VA = "0x182160430")]
		public IEnumerator ReceiveItemsCoroutine(List<ItemGet> items)
		{
			return null;
		}

		// Token: 0x060264E4 RID: 156900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264E4")]
		[Address(RVA = "0x21601F0", Offset = "0x215EDF0", VA = "0x1821601F0")]
		public void OnTrailRewardGet(string i_rewardId)
		{
		}

		// Token: 0x060264E5 RID: 156901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264E5")]
		[Address(RVA = "0x2160660", Offset = "0x215F260", VA = "0x182160660")]
		public void ToCharacterPotentialState()
		{
		}

		// Token: 0x060264E6 RID: 156902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264E6")]
		[Address(RVA = "0x2160790", Offset = "0x215F390", VA = "0x182160790")]
		public void ToTrailRuleState()
		{
		}

		// Token: 0x060264E7 RID: 156903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60264E7")]
		[Address(RVA = "0x2160500", Offset = "0x215F100", VA = "0x182160500", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060264E8 RID: 156904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264E8")]
		[Address(RVA = "0x21609C0", Offset = "0x215F5C0", VA = "0x1821609C0")]
		private void _OnJumpToUpPotentialState(IStateBean stateBean)
		{
		}

		// Token: 0x060264E9 RID: 156905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264E9")]
		[Address(RVA = "0x2160B60", Offset = "0x215F760", VA = "0x182160B60")]
		private void _TopMenuProcessor(GameObject topMenuObj)
		{
		}

		// Token: 0x060264EA RID: 156906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264EA")]
		[Address(RVA = "0x215FF80", Offset = "0x215EB80", VA = "0x18215FF80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060264EB RID: 156907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264EB")]
		[Address(RVA = "0x2160100", Offset = "0x215ED00", VA = "0x182160100", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060264EC RID: 156908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264EC")]
		[Address(RVA = "0x2160C50", Offset = "0x215F850", VA = "0x182160C50")]
		public RetroTrailRewardState()
		{
		}

		// Token: 0x060264EF RID: 156911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60264EF")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060264F0 RID: 156912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264F0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060264F1 RID: 156913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264F1")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04035F65 RID: 221029
		[Token(Token = "0x4035F65")]
		[FieldOffset(Offset = "0x70")]
		private StageStateBean m_stateBean;

		// Token: 0x04035F66 RID: 221030
		[Token(Token = "0x4035F66")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RetroTrailRewardView _view;

		// Token: 0x04035F67 RID: 221031
		[Token(Token = "0x4035F67")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _instHolder;

		// Token: 0x04035F68 RID: 221032
		[Token(Token = "0x4035F68")]
		[FieldOffset(Offset = "0x88")]
		private SideStoryViewModel m_cacheViewModel;

		// Token: 0x04035F69 RID: 221033
		[Token(Token = "0x4035F69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035F6A RID: 221034
		[Token(Token = "0x4035F6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x04035F6B RID: 221035
		[Token(Token = "0x4035F6B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTrailRewardGet;

		// Token: 0x04035F6C RID: 221036
		[Token(Token = "0x4035F6C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToCharacterPotentialState;

		// Token: 0x04035F6D RID: 221037
		[Token(Token = "0x4035F6D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ToTrailRuleState;

		// Token: 0x04035F6E RID: 221038
		[Token(Token = "0x4035F6E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04035F6F RID: 221039
		[Token(Token = "0x4035F6F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnJumpToUpPotentialState;

		// Token: 0x04035F70 RID: 221040
		[Token(Token = "0x4035F70")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TopMenuProcessor;

		// Token: 0x04035F71 RID: 221041
		[Token(Token = "0x4035F71")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035F72 RID: 221042
		[Token(Token = "0x4035F72")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04035F73 RID: 221043
		[Token(Token = "0x4035F73")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
