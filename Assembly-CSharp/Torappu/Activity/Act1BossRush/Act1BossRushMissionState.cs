using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070CC RID: 28876
	[Token(Token = "0x20070CC")]
	public class Act1BossRushMissionState : PopupFadeState, IBaseActStateHolder, IHotfixable
	{
		// Token: 0x0602908D RID: 168077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602908D")]
		[Address(RVA = "0x246B8F0", Offset = "0x246A4F0", VA = "0x18246B8F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602908E RID: 168078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602908E")]
		[Address(RVA = "0x246B890", Offset = "0x246A490", VA = "0x18246B890", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602908F RID: 168079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602908F")]
		[Address(RVA = "0x246BB30", Offset = "0x246A730", VA = "0x18246BB30")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x06029090 RID: 168080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029090")]
		[Address(RVA = "0x246B600", Offset = "0x246A200", VA = "0x18246B600", Slot = "31")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x06029091 RID: 168081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029091")]
		[Address(RVA = "0x246BC50", Offset = "0x246A850", VA = "0x18246BC50")]
		public Act1BossRushMissionState()
		{
		}

		// Token: 0x06029093 RID: 168083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029093")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403A952 RID: 239954
		[Token(Token = "0x403A952")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1BossRushMissionInfoHolder _infoHolder;

		// Token: 0x0403A953 RID: 239955
		[Token(Token = "0x403A953")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TemplateActivityMissionHolder _holder;

		// Token: 0x0403A954 RID: 239956
		[Token(Token = "0x403A954")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403A955 RID: 239957
		[Token(Token = "0x403A955")]
		[FieldOffset(Offset = "0x88")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403A956 RID: 239958
		[Token(Token = "0x403A956")]
		[FieldOffset(Offset = "0x90")]
		private TemplateActivityController m_cacheController;

		// Token: 0x0403A957 RID: 239959
		[Token(Token = "0x403A957")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A958 RID: 239960
		[Token(Token = "0x403A958")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403A959 RID: 239961
		[Token(Token = "0x403A959")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403A95A RID: 239962
		[Token(Token = "0x403A95A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x0403A95B RID: 239963
		[Token(Token = "0x403A95B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
