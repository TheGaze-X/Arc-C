using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BE0 RID: 19424
	[Token(Token = "0x2004BE0")]
	public class HomeCheckInCommonRewardView : DataBinder<HomeCheckInProperty>, IHotfixable
	{
		// Token: 0x0601D31A RID: 119578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D31A")]
		[Address(RVA = "0x16C18E0", Offset = "0x16C04E0", VA = "0x1816C18E0", Slot = "7")]
		public override void OnValueChanged(HomeCheckInProperty property)
		{
		}

		// Token: 0x0601D31B RID: 119579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D31B")]
		[Address(RVA = "0x16C1AE0", Offset = "0x16C06E0", VA = "0x1816C1AE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D31C RID: 119580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D31C")]
		[Address(RVA = "0x16C1C30", Offset = "0x16C0830", VA = "0x1816C1C30")]
		private void _RenderDailyBonus(HomeCheckInViewModel model)
		{
		}

		// Token: 0x0601D31D RID: 119581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D31D")]
		[Address(RVA = "0x16C1F40", Offset = "0x16C0B40", VA = "0x1816C1F40")]
		private void _RenderNormalReward(HomeCheckInViewModel model)
		{
		}

		// Token: 0x0601D31E RID: 119582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D31E")]
		[Address(RVA = "0x16C2130", Offset = "0x16C0D30", VA = "0x1816C2130")]
		public HomeCheckInCommonRewardView()
		{
		}

		// Token: 0x04026546 RID: 156998
		[Token(Token = "0x4026546")]
		private const int COUNT_DOWN_LIMIT_DAYS = 3;

		// Token: 0x04026547 RID: 156999
		[Token(Token = "0x4026547")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelGradient;

		// Token: 0x04026548 RID: 157000
		[Token(Token = "0x4026548")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Daily Bonus")]
		private GameObject _panelDailyBonus;

		// Token: 0x04026549 RID: 157001
		[Token(Token = "0x4026549")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Daily Bonus")]
		private SimpleLayoutContent _dailyBonusContent;

		// Token: 0x0402654A RID: 157002
		[Token(Token = "0x402654A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Daily Bonus")]
		private GameObject _panelDailyBonusCountDown;

		// Token: 0x0402654B RID: 157003
		[Token(Token = "0x402654B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Daily Bonus")]
		private Text _textDailyBonusRemainTime;

		// Token: 0x0402654C RID: 157004
		[Token(Token = "0x402654C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Daily Bonus")]
		private Text _textDailyBonusTitle;

		// Token: 0x0402654D RID: 157005
		[Token(Token = "0x402654D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Normal Reward")]
		private SimpleLayoutContent _normalRewardContent;

		// Token: 0x0402654E RID: 157006
		[Token(Token = "0x402654E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Normal Reward")]
		private Text _textNormalRewardTitle;

		// Token: 0x0402654F RID: 157007
		[Token(Token = "0x402654F")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04026550 RID: 157008
		[Token(Token = "0x4026550")]
		[FieldOffset(Offset = "0x68")]
		private HomeCheckInCommonRewardView.Adapter m_dailyBonusAdapter;

		// Token: 0x04026551 RID: 157009
		[Token(Token = "0x4026551")]
		[FieldOffset(Offset = "0x70")]
		private HomeCheckInCommonRewardView.Adapter m_normalRewardAdapter;

		// Token: 0x04026552 RID: 157010
		[Token(Token = "0x4026552")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026553 RID: 157011
		[Token(Token = "0x4026553")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026554 RID: 157012
		[Token(Token = "0x4026554")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDailyBonus;

		// Token: 0x04026555 RID: 157013
		[Token(Token = "0x4026555")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderNormalReward;

		// Token: 0x04026556 RID: 157014
		[Token(Token = "0x4026556")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BE1 RID: 19425
		[Token(Token = "0x2004BE1")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x170044AA RID: 17578
			// (get) Token: 0x0601D31F RID: 119583 RVA: 0x000AAD90 File Offset: 0x000A8F90
			[Token(Token = "0x170044AA")]
			public override int count
			{
				[Token(Token = "0x601D31F")]
				[Address(RVA = "0x16B7420", Offset = "0x16B6020", VA = "0x1816B7420", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D320 RID: 119584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D320")]
			[Address(RVA = "0x16B6E00", Offset = "0x16B5A00", VA = "0x1816B6E00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601D321 RID: 119585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D321")]
			[Address(RVA = "0x16B7040", Offset = "0x16B5C40", VA = "0x1816B7040")]
			public Adapter()
			{
			}

			// Token: 0x04026557 RID: 157015
			[Token(Token = "0x4026557")]
			[FieldOffset(Offset = "0x20")]
			public IList<ItemBundle> dataList;

			// Token: 0x04026558 RID: 157016
			[Token(Token = "0x4026558")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026559 RID: 157017
			[Token(Token = "0x4026559")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402655A RID: 157018
			[Token(Token = "0x402655A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
