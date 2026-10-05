using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046EB RID: 18155
	[Token(Token = "0x20046EB")]
	public class RecruitPage : StateEnginePage
	{
		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x0601B854 RID: 112724 RVA: 0x000A56F0 File Offset: 0x000A38F0
		[Token(Token = "0x1700418F")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x601B854")]
			[Address(RVA = "0x14E1D60", Offset = "0x14E0960", VA = "0x1814E1D60", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x0601B855 RID: 112725 RVA: 0x000A5708 File Offset: 0x000A3908
		// (set) Token: 0x0601B856 RID: 112726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004190")]
		public bool isBanToast
		{
			[Token(Token = "0x601B855")]
			[Address(RVA = "0x14E1DC0", Offset = "0x14E09C0", VA = "0x1814E1DC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601B856")]
			[Address(RVA = "0x14E1E20", Offset = "0x14E0A20", VA = "0x1814E1E20")]
			set
			{
			}
		}

		// Token: 0x0601B857 RID: 112727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B857")]
		[Address(RVA = "0x14E1640", Offset = "0x14E0240", VA = "0x1814E1640")]
		private void Start()
		{
		}

		// Token: 0x0601B858 RID: 112728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B858")]
		[Address(RVA = "0x14E0C90", Offset = "0x14DF890", VA = "0x1814E0C90", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601B859 RID: 112729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B859")]
		[Address(RVA = "0x14E0BB0", Offset = "0x14DF7B0", VA = "0x1814E0BB0", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0601B85A RID: 112730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B85A")]
		[Address(RVA = "0x14E0E50", Offset = "0x14DFA50", VA = "0x1814E0E50")]
		public void ShowGachaEffect(GachaResult gachaResult, bool isAdvanced, bool isSkippable)
		{
		}

		// Token: 0x0601B85B RID: 112731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B85B")]
		[Address(RVA = "0x14E11D0", Offset = "0x14DFDD0", VA = "0x1814E11D0")]
		public void ShowTenGachaEffect(GachaResult[] gachaResultList, bool isAdvanced, bool isSkippable)
		{
		}

		// Token: 0x0601B85C RID: 112732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B85C")]
		[Address(RVA = "0x14E1B40", Offset = "0x14E0740", VA = "0x1814E1B40")]
		private void _ShowError(bool isAdvanced)
		{
		}

		// Token: 0x0601B85D RID: 112733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B85D")]
		[Address(RVA = "0x14E19C0", Offset = "0x14E05C0", VA = "0x1814E19C0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x0601B85E RID: 112734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B85E")]
		[Address(RVA = "0x14E1C20", Offset = "0x14E0820", VA = "0x1814E1C20")]
		private void _UpdateStatusWhenBackToRecruit(RecruitPage.Param param, UIPageTransContext transContext)
		{
		}

		// Token: 0x0601B85F RID: 112735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B85F")]
		[Address(RVA = "0x14E1D00", Offset = "0x14E0900", VA = "0x1814E1D00")]
		public RecruitPage()
		{
		}

		// Token: 0x0601B864 RID: 112740 RVA: 0x000A5720 File Offset: 0x000A3920
		[Token(Token = "0x601B864")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x0601B865 RID: 112741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B865")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0601B866 RID: 112742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B866")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x04023A7A RID: 146042
		[Token(Token = "0x4023A7A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Tooltip("The original parent of all managed states")]
		private Transform _originTransform;

		// Token: 0x04023A7B RID: 146043
		[Token(Token = "0x4023A7B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x04023A7C RID: 146044
		[Token(Token = "0x4023A7C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RecruitStateBean _stateBean;

		// Token: 0x04023A7D RID: 146045
		[Token(Token = "0x4023A7D")]
		[FieldOffset(Offset = "0x108")]
		private Action m_stateSwitchCallback;

		// Token: 0x04023A7E RID: 146046
		[Token(Token = "0x4023A7E")]
		[FieldOffset(Offset = "0x110")]
		private Vector2 m_fromContentPos;

		// Token: 0x04023A7F RID: 146047
		[Token(Token = "0x4023A7F")]
		[FieldOffset(Offset = "0x118")]
		private RefCountReference m_buildingContextRef;

		// Token: 0x04023A80 RID: 146048
		[Token(Token = "0x4023A80")]
		[FieldOffset(Offset = "0x120")]
		private bool m_isBanToast;

		// Token: 0x04023A81 RID: 146049
		[Token(Token = "0x4023A81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x04023A82 RID: 146050
		[Token(Token = "0x4023A82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isBanToast;

		// Token: 0x04023A83 RID: 146051
		[Token(Token = "0x4023A83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isBanToast;

		// Token: 0x04023A84 RID: 146052
		[Token(Token = "0x4023A84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04023A85 RID: 146053
		[Token(Token = "0x4023A85")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04023A86 RID: 146054
		[Token(Token = "0x4023A86")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x04023A87 RID: 146055
		[Token(Token = "0x4023A87")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowGachaEffect;

		// Token: 0x04023A88 RID: 146056
		[Token(Token = "0x4023A88")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ShowTenGachaEffect;

		// Token: 0x04023A89 RID: 146057
		[Token(Token = "0x4023A89")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowError;

		// Token: 0x04023A8A RID: 146058
		[Token(Token = "0x4023A8A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x04023A8B RID: 146059
		[Token(Token = "0x4023A8B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateStatusWhenBackToRecruit;

		// Token: 0x04023A8C RID: 146060
		[Token(Token = "0x4023A8C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020046EC RID: 18156
		[Token(Token = "0x20046EC")]
		public class Param
		{
			// Token: 0x0601B867 RID: 112743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B867")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04023A8D RID: 146061
			[Token(Token = "0x4023A8D")]
			[FieldOffset(Offset = "0x10")]
			public bool isNormal;

			// Token: 0x04023A8E RID: 146062
			[Token(Token = "0x4023A8E")]
			[FieldOffset(Offset = "0x18")]
			public string targetGachaPool;

			// Token: 0x04023A8F RID: 146063
			[Token(Token = "0x4023A8F")]
			[FieldOffset(Offset = "0x20")]
			public bool triggerResetToDefault;
		}
	}
}
