using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FAE RID: 24494
	[Token(Token = "0x2005FAE")]
	public class CharacterInfoRightSkillSpreadView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060236EA RID: 145130 RVA: 0x000C0E40 File Offset: 0x000BF040
		[Token(Token = "0x60236EA")]
		[Address(RVA = "0x1E09020", Offset = "0x1E07C20", VA = "0x181E09020")]
		public float GetAndRefreshHeight()
		{
			return 0f;
		}

		// Token: 0x060236EB RID: 145131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236EB")]
		[Address(RVA = "0x1E097B0", Offset = "0x1E083B0", VA = "0x181E097B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060236EC RID: 145132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236EC")]
		[Address(RVA = "0x1E09460", Offset = "0x1E08060", VA = "0x181E09460")]
		public void Render(CharacterInfoHolderBean.CharViewModel viewModel)
		{
		}

		// Token: 0x060236ED RID: 145133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60236ED")]
		[Address(RVA = "0x1E09670", Offset = "0x1E08270", VA = "0x181E09670")]
		private SkillItemViewModel _CurrentSelectViewModel()
		{
			return null;
		}

		// Token: 0x060236EE RID: 145134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236EE")]
		[Address(RVA = "0x1E09A40", Offset = "0x1E08640", VA = "0x181E09A40")]
		private void _RenderSkill()
		{
		}

		// Token: 0x060236EF RID: 145135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236EF")]
		[Address(RVA = "0x1E09FA0", Offset = "0x1E08BA0", VA = "0x181E09FA0")]
		private void _RenderSpOpPart()
		{
		}

		// Token: 0x060236F0 RID: 145136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236F0")]
		[Address(RVA = "0x1E09310", Offset = "0x1E07F10", VA = "0x181E09310")]
		public void OnToSkillLvlUp()
		{
		}

		// Token: 0x060236F1 RID: 145137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236F1")]
		[Address(RVA = "0x1E09380", Offset = "0x1E07F80", VA = "0x181E09380")]
		public void OnToSpOpTarget()
		{
		}

		// Token: 0x060236F2 RID: 145138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236F2")]
		[Address(RVA = "0x1E092A0", Offset = "0x1E07EA0", VA = "0x181E092A0")]
		public void OnToSkillDetail()
		{
		}

		// Token: 0x060236F3 RID: 145139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236F3")]
		[Address(RVA = "0x1E093F0", Offset = "0x1E07FF0", VA = "0x181E093F0")]
		public void OnToTrainingRoom()
		{
		}

		// Token: 0x060236F4 RID: 145140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236F4")]
		[Address(RVA = "0x1E091A0", Offset = "0x1E07DA0", VA = "0x181E091A0")]
		public void OnConfirmSkill()
		{
		}

		// Token: 0x060236F5 RID: 145141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236F5")]
		[Address(RVA = "0x1E099B0", Offset = "0x1E085B0", VA = "0x181E099B0")]
		private void _OnFocusSkill(string skillId)
		{
		}

		// Token: 0x060236F6 RID: 145142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236F6")]
		[Address(RVA = "0x1E09210", Offset = "0x1E07E10", VA = "0x181E09210")]
		public void OnNoTrainingClick()
		{
		}

		// Token: 0x060236F7 RID: 145143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236F7")]
		[Address(RVA = "0x1E0A0F0", Offset = "0x1E08CF0", VA = "0x181E0A0F0")]
		public CharacterInfoRightSkillSpreadView()
		{
		}

		// Token: 0x04030F7D RID: 200573
		[Token(Token = "0x4030F7D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _currentHeight;

		// Token: 0x04030F7E RID: 200574
		[Token(Token = "0x4030F7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _skillContent;

		// Token: 0x04030F7F RID: 200575
		[Token(Token = "0x4030F7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _ableToSelect;

		// Token: 0x04030F80 RID: 200576
		[Token(Token = "0x4030F80")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _alreadyIsSelect;

		// Token: 0x04030F81 RID: 200577
		[Token(Token = "0x4030F81")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _skillDetail;

		// Token: 0x04030F82 RID: 200578
		[Token(Token = "0x4030F82")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UISkillTagGroup _tagGroup;

		// Token: 0x04030F83 RID: 200579
		[Token(Token = "0x4030F83")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _skillRangeBtnContent;

		// Token: 0x04030F84 RID: 200580
		[Token(Token = "0x4030F84")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _skillLevel;

		// Token: 0x04030F85 RID: 200581
		[Token(Token = "0x4030F85")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _skillLevelPart;

		// Token: 0x04030F86 RID: 200582
		[Token(Token = "0x4030F86")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _specMaxPart;

		// Token: 0x04030F87 RID: 200583
		[Token(Token = "0x4030F87")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _maxPart;

		// Token: 0x04030F88 RID: 200584
		[Token(Token = "0x4030F88")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lvlupPart;

		// Token: 0x04030F89 RID: 200585
		[Token(Token = "0x4030F89")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _spOpLvlupPart;

		// Token: 0x04030F8A RID: 200586
		[Token(Token = "0x4030F8A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _trainPart;

		// Token: 0x04030F8B RID: 200587
		[Token(Token = "0x4030F8B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _trainFullPart;

		// Token: 0x04030F8C RID: 200588
		[Token(Token = "0x4030F8C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _noTrainPart;

		// Token: 0x04030F8D RID: 200589
		[Token(Token = "0x4030F8D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _targetImage;

		// Token: 0x04030F8E RID: 200590
		[Token(Token = "0x4030F8E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _targetText;

		// Token: 0x04030F8F RID: 200591
		[Token(Token = "0x4030F8F")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Action refreshHeightAction;

		// Token: 0x04030F90 RID: 200592
		[Token(Token = "0x4030F90")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UnityEvent _toTrainingRoom;

		// Token: 0x04030F91 RID: 200593
		[Token(Token = "0x4030F91")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UnityEvent _toLvlup;

		// Token: 0x04030F92 RID: 200594
		[Token(Token = "0x4030F92")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UnityEvent _toSpOpTarget;

		// Token: 0x04030F93 RID: 200595
		[Token(Token = "0x4030F93")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UnityEvent _toDetail;

		// Token: 0x04030F94 RID: 200596
		[Token(Token = "0x4030F94")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UnityEvent _onChangeSkill;

		// Token: 0x04030F95 RID: 200597
		[Token(Token = "0x4030F95")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIStringEvent _onFocusSkill;

		// Token: 0x04030F96 RID: 200598
		[Token(Token = "0x4030F96")]
		[FieldOffset(Offset = "0xE0")]
		private CharacterInfoRightSkillSpreadView.Adapter m_adapter;

		// Token: 0x04030F97 RID: 200599
		[Token(Token = "0x4030F97")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_isInited;

		// Token: 0x04030F98 RID: 200600
		[Token(Token = "0x4030F98")]
		[FieldOffset(Offset = "0xF0")]
		private string m_focusSkillId;

		// Token: 0x04030F99 RID: 200601
		[Token(Token = "0x4030F99")]
		[FieldOffset(Offset = "0xF8")]
		private SkillGroupViewModel m_skillGroupViewModel;

		// Token: 0x04030F9A RID: 200602
		[Token(Token = "0x4030F9A")]
		[FieldOffset(Offset = "0x100")]
		private SpecialOperatorInfoViewModel m_spOpModel;

		// Token: 0x04030F9B RID: 200603
		[Token(Token = "0x4030F9B")]
		[FieldOffset(Offset = "0x108")]
		private TextGenerator m_textGenerate;

		// Token: 0x04030F9C RID: 200604
		[Token(Token = "0x4030F9C")]
		[FieldOffset(Offset = "0x110")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04030F9D RID: 200605
		[Token(Token = "0x4030F9D")]
		[FieldOffset(Offset = "0x120")]
		private CommonSkillRangeButtonView m_skillRangeBtnView;

		// Token: 0x04030F9E RID: 200606
		[Token(Token = "0x4030F9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAndRefreshHeight;

		// Token: 0x04030F9F RID: 200607
		[Token(Token = "0x4030F9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030FA0 RID: 200608
		[Token(Token = "0x4030FA0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030FA1 RID: 200609
		[Token(Token = "0x4030FA1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CurrentSelectViewModel;

		// Token: 0x04030FA2 RID: 200610
		[Token(Token = "0x4030FA2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderSkill;

		// Token: 0x04030FA3 RID: 200611
		[Token(Token = "0x4030FA3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSpOpPart;

		// Token: 0x04030FA4 RID: 200612
		[Token(Token = "0x4030FA4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnToSkillLvlUp;

		// Token: 0x04030FA5 RID: 200613
		[Token(Token = "0x4030FA5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnToSpOpTarget;

		// Token: 0x04030FA6 RID: 200614
		[Token(Token = "0x4030FA6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnToSkillDetail;

		// Token: 0x04030FA7 RID: 200615
		[Token(Token = "0x4030FA7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnToTrainingRoom;

		// Token: 0x04030FA8 RID: 200616
		[Token(Token = "0x4030FA8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnConfirmSkill;

		// Token: 0x04030FA9 RID: 200617
		[Token(Token = "0x4030FA9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnFocusSkill;

		// Token: 0x04030FAA RID: 200618
		[Token(Token = "0x4030FAA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnNoTrainingClick;

		// Token: 0x04030FAB RID: 200619
		[Token(Token = "0x4030FAB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FAF RID: 24495
		[Token(Token = "0x2005FAF")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170053A2 RID: 21410
			// (get) Token: 0x060236F8 RID: 145144 RVA: 0x000C0E58 File Offset: 0x000BF058
			[Token(Token = "0x170053A2")]
			public override int count
			{
				[Token(Token = "0x60236F8")]
				[Address(RVA = "0x1E13400", Offset = "0x1E12000", VA = "0x181E13400", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060236F9 RID: 145145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60236F9")]
			[Address(RVA = "0x1E13010", Offset = "0x1E11C10", VA = "0x181E13010", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060236FA RID: 145146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60236FA")]
			[Address(RVA = "0x1E132D0", Offset = "0x1E11ED0", VA = "0x181E132D0")]
			public Adapter()
			{
			}

			// Token: 0x04030FAC RID: 200620
			[Token(Token = "0x4030FAC")]
			[FieldOffset(Offset = "0x20")]
			public SkillItemViewModel[] skillList;

			// Token: 0x04030FAD RID: 200621
			[Token(Token = "0x4030FAD")]
			[FieldOffset(Offset = "0x28")]
			public string selectSkillId;

			// Token: 0x04030FAE RID: 200622
			[Token(Token = "0x4030FAE")]
			[FieldOffset(Offset = "0x30")]
			public string focusSkillId;

			// Token: 0x04030FAF RID: 200623
			[Token(Token = "0x4030FAF")]
			[FieldOffset(Offset = "0x38")]
			public Action<string> onCacheSkillSelect;

			// Token: 0x04030FB0 RID: 200624
			[Token(Token = "0x4030FB0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030FB1 RID: 200625
			[Token(Token = "0x4030FB1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030FB2 RID: 200626
			[Token(Token = "0x4030FB2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
