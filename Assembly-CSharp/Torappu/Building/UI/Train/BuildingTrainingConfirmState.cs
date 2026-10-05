using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C0A RID: 7178
	[Token(Token = "0x2001C0A")]
	public class BuildingTrainingConfirmState : State
	{
		// Token: 0x0600B300 RID: 45824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B300")]
		[Address(RVA = "0x32DD080", Offset = "0x32DBC80", VA = "0x1832DD080", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B301 RID: 45825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B301")]
		[Address(RVA = "0x32DD0E0", Offset = "0x32DBCE0", VA = "0x1832DD0E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B302 RID: 45826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B302")]
		[Address(RVA = "0x32DD140", Offset = "0x32DBD40", VA = "0x1832DD140", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B303 RID: 45827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B303")]
		[Address(RVA = "0x32DD6C0", Offset = "0x32DC2C0", VA = "0x1832DD6C0")]
		private void _UpdateView()
		{
		}

		// Token: 0x0600B304 RID: 45828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B304")]
		[Address(RVA = "0x32DD600", Offset = "0x32DC200", VA = "0x1832DD600")]
		private void _OnBackToCurState()
		{
		}

		// Token: 0x0600B305 RID: 45829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B305")]
		[Address(RVA = "0x32DCFF0", Offset = "0x32DBBF0", VA = "0x1832DCFF0")]
		public void EventOnExitSelectSkill()
		{
		}

		// Token: 0x0600B306 RID: 45830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B306")]
		[Address(RVA = "0x32DD260", Offset = "0x32DBE60", VA = "0x1832DD260")]
		public void OnUpgradeConfirmClick()
		{
		}

		// Token: 0x0600B307 RID: 45831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B307")]
		[Address(RVA = "0x32DDC30", Offset = "0x32DC830", VA = "0x1832DDC30")]
		public BuildingTrainingConfirmState()
		{
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B309")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B30A RID: 45834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B30A")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0400AE12 RID: 44562
		[Token(Token = "0x400AE12")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingTrainingStateBean _stateBean;

		// Token: 0x0400AE13 RID: 44563
		[Token(Token = "0x400AE13")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterInfoSkillLevelUpSpecializedView _nowLevel;

		// Token: 0x0400AE14 RID: 44564
		[Token(Token = "0x400AE14")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterInfoSkillLevelUpSpecializedView _upLevel;

		// Token: 0x0400AE15 RID: 44565
		[Token(Token = "0x400AE15")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x0400AE16 RID: 44566
		[Token(Token = "0x400AE16")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _hourText;

		// Token: 0x0400AE17 RID: 44567
		[Token(Token = "0x400AE17")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _specialLvl;

		// Token: 0x0400AE18 RID: 44568
		[Token(Token = "0x400AE18")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _specialLvlGlow;

		// Token: 0x0400AE19 RID: 44569
		[Token(Token = "0x400AE19")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _layoutGroup;

		// Token: 0x0400AE1A RID: 44570
		[Token(Token = "0x400AE1A")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_tagTipTweener;

		// Token: 0x0400AE1B RID: 44571
		[Token(Token = "0x400AE1B")]
		private const float TWEEN_DURATION = 0.23f;

		// Token: 0x0400AE1C RID: 44572
		[Token(Token = "0x400AE1C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400AE1D RID: 44573
		[Token(Token = "0x400AE1D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400AE1E RID: 44574
		[Token(Token = "0x400AE1E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400AE1F RID: 44575
		[Token(Token = "0x400AE1F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0400AE20 RID: 44576
		[Token(Token = "0x400AE20")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBackToCurState;

		// Token: 0x0400AE21 RID: 44577
		[Token(Token = "0x400AE21")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnExitSelectSkill;

		// Token: 0x0400AE22 RID: 44578
		[Token(Token = "0x400AE22")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnUpgradeConfirmClick;

		// Token: 0x0400AE23 RID: 44579
		[Token(Token = "0x400AE23")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C0B RID: 7179
		[Token(Token = "0x2001C0B")]
		public class RequirementAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B30B RID: 45835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B30B")]
			[Address(RVA = "0x32E54C0", Offset = "0x32E40C0", VA = "0x1832E54C0")]
			public RequirementAdapter(BuildingTrainingConfirmState closure)
			{
			}

			// Token: 0x17001582 RID: 5506
			// (get) Token: 0x0600B30C RID: 45836 RVA: 0x000441D8 File Offset: 0x000423D8
			[Token(Token = "0x17001582")]
			public override int count
			{
				[Token(Token = "0x600B30C")]
				[Address(RVA = "0x32E5540", Offset = "0x32E4140", VA = "0x1832E5540", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B30D RID: 45837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B30D")]
			[Address(RVA = "0x32E52E0", Offset = "0x32E3EE0", VA = "0x1832E52E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400AE24 RID: 44580
			[Token(Token = "0x400AE24")]
			[FieldOffset(Offset = "0x20")]
			private BuildingTrainingConfirmState m_closure;

			// Token: 0x0400AE25 RID: 44581
			[Token(Token = "0x400AE25")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400AE26 RID: 44582
			[Token(Token = "0x400AE26")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400AE27 RID: 44583
			[Token(Token = "0x400AE27")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
