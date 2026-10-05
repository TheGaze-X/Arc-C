using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200715A RID: 29018
	[Token(Token = "0x200715A")]
	public class Act9D0MissionSubState : PopupFadeState
	{
		// Token: 0x06029335 RID: 168757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029335")]
		[Address(RVA = "0x249C420", Offset = "0x249B020", VA = "0x18249C420", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029336 RID: 168758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029336")]
		[Address(RVA = "0x249C1C0", Offset = "0x249ADC0", VA = "0x18249C1C0")]
		public void EventOnMissionObjClicked(string missionId)
		{
		}

		// Token: 0x06029337 RID: 168759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029337")]
		[Address(RVA = "0x249C700", Offset = "0x249B300", VA = "0x18249C700")]
		public void OpenDetail(string missionId)
		{
		}

		// Token: 0x06029338 RID: 168760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029338")]
		[Address(RVA = "0x249C860", Offset = "0x249B460", VA = "0x18249C860", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029339 RID: 168761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029339")]
		[Address(RVA = "0x249CD10", Offset = "0x249B910", VA = "0x18249CD10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602933A RID: 168762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602933A")]
		[Address(RVA = "0x249C480", Offset = "0x249B080", VA = "0x18249C480", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602933B RID: 168763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602933B")]
		[Address(RVA = "0x249C620", Offset = "0x249B220", VA = "0x18249C620", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602933C RID: 168764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602933C")]
		[Address(RVA = "0x249CE00", Offset = "0x249BA00", VA = "0x18249CE00")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602933D RID: 168765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602933D")]
		[Address(RVA = "0x249CEB0", Offset = "0x249BAB0", VA = "0x18249CEB0")]
		public Act9D0MissionSubState()
		{
		}

		// Token: 0x06029341 RID: 168769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029341")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029342 RID: 168770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029342")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029343 RID: 168771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029343")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403AD33 RID: 240947
		[Token(Token = "0x403AD33")]
		[FieldOffset(Offset = "0x70")]
		private Act9D0MissionStateBean m_stateBean;

		// Token: 0x0403AD34 RID: 240948
		[Token(Token = "0x403AD34")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act9D0MissionSubView _view;

		// Token: 0x0403AD35 RID: 240949
		[Token(Token = "0x403AD35")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act9D0SubMissionView _subView;

		// Token: 0x0403AD36 RID: 240950
		[Token(Token = "0x403AD36")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403AD37 RID: 240951
		[Token(Token = "0x403AD37")]
		[FieldOffset(Offset = "0x90")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403AD38 RID: 240952
		[Token(Token = "0x403AD38")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x0403AD39 RID: 240953
		[Token(Token = "0x403AD39")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cacheId;

		// Token: 0x0403AD3A RID: 240954
		[Token(Token = "0x403AD3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403AD3B RID: 240955
		[Token(Token = "0x403AD3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnMissionObjClicked;

		// Token: 0x0403AD3C RID: 240956
		[Token(Token = "0x403AD3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenDetail;

		// Token: 0x0403AD3D RID: 240957
		[Token(Token = "0x403AD3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403AD3E RID: 240958
		[Token(Token = "0x403AD3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AD3F RID: 240959
		[Token(Token = "0x403AD3F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403AD40 RID: 240960
		[Token(Token = "0x403AD40")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403AD41 RID: 240961
		[Token(Token = "0x403AD41")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403AD42 RID: 240962
		[Token(Token = "0x403AD42")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
