using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EDB RID: 24283
	[Token(Token = "0x2005EDB")]
	public class CharacterInfoSkillAllLevelUpState : PopupFadeState
	{
		// Token: 0x060232D8 RID: 144088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232D8")]
		[Address(RVA = "0x1DAF810", Offset = "0x1DAE410", VA = "0x181DAF810", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060232D9 RID: 144089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232D9")]
		[Address(RVA = "0x1DAFA20", Offset = "0x1DAE620", VA = "0x181DAFA20", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060232DA RID: 144090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232DA")]
		[Address(RVA = "0x1DAFB70", Offset = "0x1DAE770", VA = "0x181DAFB70")]
		public void OnStateChange()
		{
		}

		// Token: 0x060232DB RID: 144091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232DB")]
		[Address(RVA = "0x1DAFAA0", Offset = "0x1DAE6A0", VA = "0x181DAFAA0")]
		public void OnRouteToTarget()
		{
		}

		// Token: 0x060232DC RID: 144092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232DC")]
		[Address(RVA = "0x1DAF7B0", Offset = "0x1DAE3B0", VA = "0x181DAF7B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060232DD RID: 144093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232DD")]
		[Address(RVA = "0x1DAFC80", Offset = "0x1DAE880", VA = "0x181DAFC80")]
		public void OnUpgradeConfirmClick()
		{
		}

		// Token: 0x060232DE RID: 144094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232DE")]
		[Address(RVA = "0x1DB0220", Offset = "0x1DAEE20", VA = "0x181DB0220")]
		private void _UpdateRequirmentViews()
		{
		}

		// Token: 0x060232DF RID: 144095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232DF")]
		[Address(RVA = "0x1DB03A0", Offset = "0x1DAEFA0", VA = "0x181DB03A0")]
		public CharacterInfoSkillAllLevelUpState()
		{
		}

		// Token: 0x060232E1 RID: 144097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232E1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060232E2 RID: 144098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232E2")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040307A1 RID: 198561
		[Token(Token = "0x40307A1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CharacterInfoSelectSkillBean _stateBean;

		// Token: 0x040307A2 RID: 198562
		[Token(Token = "0x40307A2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CharacterSkillLvlUpGroupView _upGroup;

		// Token: 0x040307A3 RID: 198563
		[Token(Token = "0x40307A3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CharacterSkillLvlUpGroupView _downGroup;

		// Token: 0x040307A4 RID: 198564
		[Token(Token = "0x40307A4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CharacterInfoSpOpView _spOpView;

		// Token: 0x040307A5 RID: 198565
		[Token(Token = "0x40307A5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040307A6 RID: 198566
		[Token(Token = "0x40307A6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SimpleLayoutContent _layoutGroup;

		// Token: 0x040307A7 RID: 198567
		[Token(Token = "0x40307A7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _confirmText;

		// Token: 0x040307A8 RID: 198568
		[Token(Token = "0x40307A8")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_tagTipTweener;

		// Token: 0x040307A9 RID: 198569
		[Token(Token = "0x40307A9")]
		private const float TWEEN_DURATION = 0.23f;

		// Token: 0x040307AA RID: 198570
		[Token(Token = "0x40307AA")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_stateFlag;

		// Token: 0x040307AB RID: 198571
		[Token(Token = "0x40307AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040307AC RID: 198572
		[Token(Token = "0x40307AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040307AD RID: 198573
		[Token(Token = "0x40307AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateChange;

		// Token: 0x040307AE RID: 198574
		[Token(Token = "0x40307AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRouteToTarget;

		// Token: 0x040307AF RID: 198575
		[Token(Token = "0x40307AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040307B0 RID: 198576
		[Token(Token = "0x40307B0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnUpgradeConfirmClick;

		// Token: 0x040307B1 RID: 198577
		[Token(Token = "0x40307B1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateRequirmentViews;

		// Token: 0x040307B2 RID: 198578
		[Token(Token = "0x40307B2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EDC RID: 24284
		[Token(Token = "0x2005EDC")]
		public class RequirementAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060232E3 RID: 144099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60232E3")]
			[Address(RVA = "0x1DB9220", Offset = "0x1DB7E20", VA = "0x181DB9220")]
			public RequirementAdapter(CharacterInfoSkillAllLevelUpState closure)
			{
			}

			// Token: 0x1700533C RID: 21308
			// (get) Token: 0x060232E4 RID: 144100 RVA: 0x000C0108 File Offset: 0x000BE308
			[Token(Token = "0x1700533C")]
			public override int count
			{
				[Token(Token = "0x60232E4")]
				[Address(RVA = "0x1DB9350", Offset = "0x1DB7F50", VA = "0x181DB9350", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060232E5 RID: 144101 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60232E5")]
			[Address(RVA = "0x1DB8E00", Offset = "0x1DB7A00", VA = "0x181DB8E00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040307B3 RID: 198579
			[Token(Token = "0x40307B3")]
			[FieldOffset(Offset = "0x20")]
			private CharacterInfoSkillAllLevelUpState m_closure;

			// Token: 0x040307B4 RID: 198580
			[Token(Token = "0x40307B4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040307B5 RID: 198581
			[Token(Token = "0x40307B5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040307B6 RID: 198582
			[Token(Token = "0x40307B6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
