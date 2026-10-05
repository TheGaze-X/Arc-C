using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CEA RID: 23786
	[Token(Token = "0x2005CEA")]
	public class ClimbTowerBuffSelectView : DataBinder<TacticalBuffGroupProp>
	{
		// Token: 0x170050FE RID: 20734
		// (get) Token: 0x06022703 RID: 141059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022704 RID: 141060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050FE")]
		public Action<ProfessionCategory> onBuffToggle
		{
			[Token(Token = "0x6022703")]
			[Address(RVA = "0x1CD0210", Offset = "0x1CCEE10", VA = "0x181CD0210")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022704")]
			[Address(RVA = "0x1CD0270", Offset = "0x1CCEE70", VA = "0x181CD0270")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022705 RID: 141061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022705")]
		[Address(RVA = "0x1CCFB70", Offset = "0x1CCE770", VA = "0x181CCFB70", Slot = "7")]
		public override void OnValueChanged(TacticalBuffGroupProp property)
		{
		}

		// Token: 0x06022706 RID: 141062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022706")]
		[Address(RVA = "0x1CD0020", Offset = "0x1CCEC20", VA = "0x181CD0020")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022707 RID: 141063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022707")]
		[Address(RVA = "0x1CCFEA0", Offset = "0x1CCEAA0", VA = "0x181CCFEA0")]
		public void UpdatePlan(bool isPlanFree)
		{
		}

		// Token: 0x06022708 RID: 141064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022708")]
		[Address(RVA = "0x1CD01A0", Offset = "0x1CCEDA0", VA = "0x181CD01A0")]
		public ClimbTowerBuffSelectView()
		{
		}

		// Token: 0x0402F54E RID: 193870
		[Token(Token = "0x402F54E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _stepList;

		// Token: 0x0402F54F RID: 193871
		[Token(Token = "0x402F54F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _buffList;

		// Token: 0x0402F550 RID: 193872
		[Token(Token = "0x402F550")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _logoPlan;

		// Token: 0x0402F551 RID: 193873
		[Token(Token = "0x402F551")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _logoAtlas;

		// Token: 0x0402F552 RID: 193874
		[Token(Token = "0x402F552")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textPlan;

		// Token: 0x0402F553 RID: 193875
		[Token(Token = "0x402F553")]
		public const string LOGO_PLAN_PREFERRED_NAME = "logo_plan_preferred";

		// Token: 0x0402F554 RID: 193876
		[Token(Token = "0x402F554")]
		public const string LOGO_PLAN_FREE_NAME = "logo_plan_free";

		// Token: 0x0402F555 RID: 193877
		[Token(Token = "0x402F555")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0402F556 RID: 193878
		[Token(Token = "0x402F556")]
		[FieldOffset(Offset = "0x50")]
		private ClimbTowerInitStepListAdapter m_stepAdapter;

		// Token: 0x0402F557 RID: 193879
		[Token(Token = "0x402F557")]
		[FieldOffset(Offset = "0x58")]
		private ClimbTowerBuffSelectView.Adapter m_adapter;

		// Token: 0x0402F558 RID: 193880
		[Token(Token = "0x402F558")]
		[FieldOffset(Offset = "0x60")]
		private TacticalBuffGroupModel m_buffGroupModel;

		// Token: 0x0402F55A RID: 193882
		[Token(Token = "0x402F55A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBuffToggle;

		// Token: 0x0402F55B RID: 193883
		[Token(Token = "0x402F55B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBuffToggle;

		// Token: 0x0402F55C RID: 193884
		[Token(Token = "0x402F55C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F55D RID: 193885
		[Token(Token = "0x402F55D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F55E RID: 193886
		[Token(Token = "0x402F55E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlan;

		// Token: 0x0402F55F RID: 193887
		[Token(Token = "0x402F55F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CEB RID: 23787
		[Token(Token = "0x2005CEB")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06022709 RID: 141065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022709")]
			[Address(RVA = "0x1CCC310", Offset = "0x1CCAF10", VA = "0x181CCC310")]
			public Adapter(ClimbTowerBuffSelectView closure)
			{
			}

			// Token: 0x170050FF RID: 20735
			// (get) Token: 0x0602270A RID: 141066 RVA: 0x000BD720 File Offset: 0x000BB920
			[Token(Token = "0x170050FF")]
			public override int count
			{
				[Token(Token = "0x602270A")]
				[Address(RVA = "0x1CCC770", Offset = "0x1CCB370", VA = "0x181CCC770", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602270B RID: 141067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602270B")]
			[Address(RVA = "0x1CCBC20", Offset = "0x1CCA820", VA = "0x181CCBC20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F560 RID: 193888
			[Token(Token = "0x402F560")]
			private const int TUTORIAL_ITEM_INDEX = 0;

			// Token: 0x0402F561 RID: 193889
			[Token(Token = "0x402F561")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerBuffSelectView m_closure;

			// Token: 0x0402F562 RID: 193890
			[Token(Token = "0x402F562")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F563 RID: 193891
			[Token(Token = "0x402F563")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F564 RID: 193892
			[Token(Token = "0x402F564")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
