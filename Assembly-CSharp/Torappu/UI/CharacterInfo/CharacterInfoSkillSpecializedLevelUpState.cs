using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EDE RID: 24286
	[Token(Token = "0x2005EDE")]
	public class CharacterInfoSkillSpecializedLevelUpState : State
	{
		// Token: 0x060232E9 RID: 144105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232E9")]
		[Address(RVA = "0x1DB04A0", Offset = "0x1DAF0A0", VA = "0x181DB04A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060232EA RID: 144106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232EA")]
		[Address(RVA = "0x1DB0A90", Offset = "0x1DAF690", VA = "0x181DB0A90")]
		public void OnUpgradeConfirmClick()
		{
		}

		// Token: 0x060232EB RID: 144107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232EB")]
		[Address(RVA = "0x1DB0500", Offset = "0x1DAF100", VA = "0x181DB0500", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060232EC RID: 144108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232EC")]
		[Address(RVA = "0x1DB0970", Offset = "0x1DAF570", VA = "0x181DB0970", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060232ED RID: 144109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232ED")]
		[Address(RVA = "0x1DB0410", Offset = "0x1DAF010", VA = "0x181DB0410")]
		public void EventOnExitSelectSkill()
		{
		}

		// Token: 0x060232EE RID: 144110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232EE")]
		[Address(RVA = "0x1DB0E10", Offset = "0x1DAFA10", VA = "0x181DB0E10")]
		private IEnumerator UpdateLayout(RectTransform rect)
		{
			return null;
		}

		// Token: 0x060232EF RID: 144111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232EF")]
		[Address(RVA = "0x1DB0EC0", Offset = "0x1DAFAC0", VA = "0x181DB0EC0")]
		public CharacterInfoSkillSpecializedLevelUpState()
		{
		}

		// Token: 0x060232F1 RID: 144113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232F1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060232F2 RID: 144114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232F2")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040307B9 RID: 198585
		[Token(Token = "0x40307B9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CharacterInfoSelectSkillBean _stateBean;

		// Token: 0x040307BA RID: 198586
		[Token(Token = "0x40307BA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterInfoSkillLevelUpSpecializedView _nowLevel;

		// Token: 0x040307BB RID: 198587
		[Token(Token = "0x40307BB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterInfoSkillLevelUpSpecializedView _upLevel;

		// Token: 0x040307BC RID: 198588
		[Token(Token = "0x40307BC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x040307BD RID: 198589
		[Token(Token = "0x40307BD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _hourText;

		// Token: 0x040307BE RID: 198590
		[Token(Token = "0x40307BE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _specialLvl;

		// Token: 0x040307BF RID: 198591
		[Token(Token = "0x40307BF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _specialLvlGlow;

		// Token: 0x040307C0 RID: 198592
		[Token(Token = "0x40307C0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _layoutGroup;

		// Token: 0x040307C1 RID: 198593
		[Token(Token = "0x40307C1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _grid;

		// Token: 0x040307C2 RID: 198594
		[Token(Token = "0x40307C2")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_tagTipTweener;

		// Token: 0x040307C3 RID: 198595
		[Token(Token = "0x40307C3")]
		private const float TWEEN_DURATION = 0.23f;

		// Token: 0x040307C4 RID: 198596
		[Token(Token = "0x40307C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040307C5 RID: 198597
		[Token(Token = "0x40307C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpgradeConfirmClick;

		// Token: 0x040307C6 RID: 198598
		[Token(Token = "0x40307C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040307C7 RID: 198599
		[Token(Token = "0x40307C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040307C8 RID: 198600
		[Token(Token = "0x40307C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnExitSelectSkill;

		// Token: 0x040307C9 RID: 198601
		[Token(Token = "0x40307C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateLayout;

		// Token: 0x040307CA RID: 198602
		[Token(Token = "0x40307CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EDF RID: 24287
		[Token(Token = "0x2005EDF")]
		public class RequirementAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060232F3 RID: 144115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60232F3")]
			[Address(RVA = "0x1DB9120", Offset = "0x1DB7D20", VA = "0x181DB9120")]
			public RequirementAdapter(CharacterInfoSkillSpecializedLevelUpState closure)
			{
			}

			// Token: 0x1700533D RID: 21309
			// (get) Token: 0x060232F4 RID: 144116 RVA: 0x000C0120 File Offset: 0x000BE320
			[Token(Token = "0x1700533D")]
			public override int count
			{
				[Token(Token = "0x60232F4")]
				[Address(RVA = "0x1DB92A0", Offset = "0x1DB7EA0", VA = "0x181DB92A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060232F5 RID: 144117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60232F5")]
			[Address(RVA = "0x1DB8F90", Offset = "0x1DB7B90", VA = "0x181DB8F90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040307CB RID: 198603
			[Token(Token = "0x40307CB")]
			[FieldOffset(Offset = "0x20")]
			private CharacterInfoSkillSpecializedLevelUpState m_closure;

			// Token: 0x040307CC RID: 198604
			[Token(Token = "0x40307CC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040307CD RID: 198605
			[Token(Token = "0x40307CD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040307CE RID: 198606
			[Token(Token = "0x40307CE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
