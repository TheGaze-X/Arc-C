using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D40 RID: 23872
	[Token(Token = "0x2005D40")]
	public class ClimbTowerInitCurseDisplayView : DataBinder<ClimbTowerInitCurseDisplayProp>
	{
		// Token: 0x0602291F RID: 141599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602291F")]
		[Address(RVA = "0x1D18BD0", Offset = "0x1D177D0", VA = "0x181D18BD0", Slot = "7")]
		public override void OnValueChanged(ClimbTowerInitCurseDisplayProp property)
		{
		}

		// Token: 0x06022920 RID: 141600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022920")]
		[Address(RVA = "0x1D18E10", Offset = "0x1D17A10", VA = "0x181D18E10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022921 RID: 141601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022921")]
		[Address(RVA = "0x1D18FB0", Offset = "0x1D17BB0", VA = "0x181D18FB0")]
		public ClimbTowerInitCurseDisplayView()
		{
		}

		// Token: 0x0402F83A RID: 194618
		[Token(Token = "0x402F83A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _stepList;

		// Token: 0x0402F83B RID: 194619
		[Token(Token = "0x402F83B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _curseCardList;

		// Token: 0x0402F83C RID: 194620
		[Token(Token = "0x402F83C")]
		private const int TOTAL_STEP_COUNT = 4;

		// Token: 0x0402F83D RID: 194621
		[Token(Token = "0x402F83D")]
		private const int CURRENT_STEP_VAL = 1;

		// Token: 0x0402F83E RID: 194622
		[Token(Token = "0x402F83E")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0402F83F RID: 194623
		[Token(Token = "0x402F83F")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerInitStepListAdapter m_stepAdapter;

		// Token: 0x0402F840 RID: 194624
		[Token(Token = "0x402F840")]
		[FieldOffset(Offset = "0x40")]
		private ClimbTowerInitCurseDisplayView.CurseCardListAdapter m_cardListAdapter;

		// Token: 0x0402F841 RID: 194625
		[Token(Token = "0x402F841")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerInitCurseDisplayModel m_displayModel;

		// Token: 0x0402F842 RID: 194626
		[Token(Token = "0x402F842")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F843 RID: 194627
		[Token(Token = "0x402F843")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F844 RID: 194628
		[Token(Token = "0x402F844")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D41 RID: 23873
		[Token(Token = "0x2005D41")]
		private class CurseCardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06022922 RID: 141602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022922")]
			[Address(RVA = "0x1D2E170", Offset = "0x1D2CD70", VA = "0x181D2E170")]
			public CurseCardListAdapter(ClimbTowerInitCurseDisplayView closure)
			{
			}

			// Token: 0x17005159 RID: 20825
			// (get) Token: 0x06022923 RID: 141603 RVA: 0x000BDDB0 File Offset: 0x000BBFB0
			[Token(Token = "0x17005159")]
			public override int count
			{
				[Token(Token = "0x6022923")]
				[Address(RVA = "0x1D2E1F0", Offset = "0x1D2CDF0", VA = "0x181D2E1F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022924 RID: 141604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022924")]
			[Address(RVA = "0x1D2DF90", Offset = "0x1D2CB90", VA = "0x181D2DF90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F845 RID: 194629
			[Token(Token = "0x402F845")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerInitCurseDisplayView m_closure;

			// Token: 0x0402F846 RID: 194630
			[Token(Token = "0x402F846")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F847 RID: 194631
			[Token(Token = "0x402F847")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F848 RID: 194632
			[Token(Token = "0x402F848")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
