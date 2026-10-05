using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032DB RID: 13019
	[Token(Token = "0x20032DB")]
	public class LegionUICharacterMenuDetailItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x06014B32 RID: 84786 RVA: 0x00088020 File Offset: 0x00086220
		[Token(Token = "0x17003105")]
		public ProfessionCategory currentProfession
		{
			[Token(Token = "0x6014B32")]
			[Address(RVA = "0xD1A880", Offset = "0xD19480", VA = "0x180D1A880")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x06014B33 RID: 84787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B33")]
		[Address(RVA = "0xD19870", Offset = "0xD18470", VA = "0x180D19870")]
		private void Awake()
		{
		}

		// Token: 0x06014B34 RID: 84788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B34")]
		[Address(RVA = "0xD199C0", Offset = "0xD185C0", VA = "0x180D199C0")]
		public void SetData(int level, ProfessionCategory profession)
		{
		}

		// Token: 0x06014B35 RID: 84789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B35")]
		[Address(RVA = "0xD19770", Offset = "0xD18370", VA = "0x180D19770")]
		public void ApplyBgMaxLevel(bool showTween)
		{
		}

		// Token: 0x06014B36 RID: 84790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B36")]
		[Address(RVA = "0xD19E30", Offset = "0xD18A30", VA = "0x180D19E30")]
		public void ShowHighLight()
		{
		}

		// Token: 0x06014B37 RID: 84791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B37")]
		[Address(RVA = "0xD19FE0", Offset = "0xD18BE0", VA = "0x180D19FE0")]
		private void _ShowHighLightEffect()
		{
		}

		// Token: 0x06014B38 RID: 84792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B38")]
		[Address(RVA = "0xD19930", Offset = "0xD18530", VA = "0x180D19930")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014B39 RID: 84793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B39")]
		[Address(RVA = "0xD19ED0", Offset = "0xD18AD0", VA = "0x180D19ED0")]
		private void _SetProfessionIcon(Image professionImage, ProfessionCategory profession, LegionUICharacterMenuDetailItem.ProfessionSpritePair[] professionIcons)
		{
		}

		// Token: 0x06014B3A RID: 84794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B3A")]
		[Address(RVA = "0xD1A710", Offset = "0xD19310", VA = "0x180D1A710")]
		public LegionUICharacterMenuDetailItem()
		{
		}

		// Token: 0x04018936 RID: 100662
		[Token(Token = "0x4018936")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _bgPanel;

		// Token: 0x04018937 RID: 100663
		[Token(Token = "0x4018937")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _detailPanel;

		// Token: 0x04018938 RID: 100664
		[Token(Token = "0x4018938")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _levelLabel;

		// Token: 0x04018939 RID: 100665
		[Token(Token = "0x4018939")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _levelLabelHL;

		// Token: 0x0401893A RID: 100666
		[Token(Token = "0x401893A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x0401893B RID: 100667
		[Token(Token = "0x401893B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _highlightPanel;

		// Token: 0x0401893C RID: 100668
		[Token(Token = "0x401893C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _highLightImage;

		// Token: 0x0401893D RID: 100669
		[Token(Token = "0x401893D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _professionImage;

		// Token: 0x0401893E RID: 100670
		[Token(Token = "0x401893E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _backProfessionImage;

		// Token: 0x0401893F RID: 100671
		[Token(Token = "0x401893F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _backGroundImage;

		// Token: 0x04018940 RID: 100672
		[Token(Token = "0x4018940")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LegionUICharacterMenuDetailItem.ProfessionSpritePair[] _professionIcons;

		// Token: 0x04018941 RID: 100673
		[Token(Token = "0x4018941")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LegionUICharacterMenuDetailItem.ProfessionSpritePair[] _backProfessionIcons;

		// Token: 0x04018942 RID: 100674
		[Token(Token = "0x4018942")]
		[FieldOffset(Offset = "0x78")]
		private ProfessionCategory m_currentProfession;

		// Token: 0x04018943 RID: 100675
		[Token(Token = "0x4018943")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_hlEffectTween;

		// Token: 0x04018944 RID: 100676
		[Token(Token = "0x4018944")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_hlTextEffectTween;

		// Token: 0x04018945 RID: 100677
		[Token(Token = "0x4018945")]
		[FieldOffset(Offset = "0x90")]
		private Color m_defaultBgColor;

		// Token: 0x04018946 RID: 100678
		[Token(Token = "0x4018946")]
		[FieldOffset(Offset = "0xA0")]
		private Color m_maxLevelBgColor;

		// Token: 0x04018947 RID: 100679
		[Token(Token = "0x4018947")]
		[FieldOffset(Offset = "0xB0")]
		private readonly string TWEEN_BG_DEFAULT_COLOR;

		// Token: 0x04018948 RID: 100680
		[Token(Token = "0x4018948")]
		[FieldOffset(Offset = "0xB8")]
		private readonly string TWEEN_BG_MAX_LEVEL_COLOR;

		// Token: 0x04018949 RID: 100681
		[Token(Token = "0x4018949")]
		[FieldOffset(Offset = "0xC0")]
		private readonly float TWEEN_BG_MAX_LEVEL_DOCOLOR_DURATION;

		// Token: 0x0401894A RID: 100682
		[Token(Token = "0x401894A")]
		[FieldOffset(Offset = "0xC4")]
		private readonly float TWEEN_MAX_LEVEL_SHINING_ALPHA_START;

		// Token: 0x0401894B RID: 100683
		[Token(Token = "0x401894B")]
		[FieldOffset(Offset = "0xC8")]
		private readonly float TWEEN_MAX_LEVEL_SHINING_ALPHA_STEP1;

		// Token: 0x0401894C RID: 100684
		[Token(Token = "0x401894C")]
		[FieldOffset(Offset = "0xCC")]
		private readonly float TWEEN_MAX_LEVEL_SHINING_ALPHA_STEP1_DURATION;

		// Token: 0x0401894D RID: 100685
		[Token(Token = "0x401894D")]
		[FieldOffset(Offset = "0xD0")]
		private readonly float TWEEN_MAX_LEVEL_SHINING_ALPHA_STEP2;

		// Token: 0x0401894E RID: 100686
		[Token(Token = "0x401894E")]
		[FieldOffset(Offset = "0xD4")]
		private readonly float TWEEN_MAX_LEVEL_SHINING_ALPHA_STEP2_DURATION;

		// Token: 0x0401894F RID: 100687
		[Token(Token = "0x401894F")]
		[FieldOffset(Offset = "0xD8")]
		private readonly float TWEEN_MAX_LEVEL_TEXT_ALPHA_START;

		// Token: 0x04018950 RID: 100688
		[Token(Token = "0x4018950")]
		[FieldOffset(Offset = "0xDC")]
		private readonly float TWEEN_MAX_LEVEL_TEXT_ALPHA_STEP1;

		// Token: 0x04018951 RID: 100689
		[Token(Token = "0x4018951")]
		[FieldOffset(Offset = "0xE0")]
		private readonly float TWEEN_MAX_LEVEL_TEXT_ALPHA_STEP1_DURATION;

		// Token: 0x04018952 RID: 100690
		[Token(Token = "0x4018952")]
		[FieldOffset(Offset = "0xE4")]
		private readonly float TWEEN_MAX_LEVEL_TEXT_ALPHA_STEP2;

		// Token: 0x04018953 RID: 100691
		[Token(Token = "0x4018953")]
		[FieldOffset(Offset = "0xE8")]
		private readonly float TWEEN_MAX_LEVEL_TEXT_ALPHA_STEP2_DURATION;

		// Token: 0x04018954 RID: 100692
		[Token(Token = "0x4018954")]
		[FieldOffset(Offset = "0xEC")]
		private readonly float TWEEN_MAX_LEVEL_TEXT_ALPHA_STEP3;

		// Token: 0x04018955 RID: 100693
		[Token(Token = "0x4018955")]
		[FieldOffset(Offset = "0xF0")]
		private readonly float TWEEN_MAX_LEVEL_TEXT_ALPHA_STEP3_DURATION;

		// Token: 0x04018956 RID: 100694
		[Token(Token = "0x4018956")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentProfession;

		// Token: 0x04018957 RID: 100695
		[Token(Token = "0x4018957")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018958 RID: 100696
		[Token(Token = "0x4018958")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018959 RID: 100697
		[Token(Token = "0x4018959")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyBgMaxLevel;

		// Token: 0x0401895A RID: 100698
		[Token(Token = "0x401895A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowHighLight;

		// Token: 0x0401895B RID: 100699
		[Token(Token = "0x401895B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowHighLightEffect;

		// Token: 0x0401895C RID: 100700
		[Token(Token = "0x401895C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401895D RID: 100701
		[Token(Token = "0x401895D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetProfessionIcon;

		// Token: 0x0401895E RID: 100702
		[Token(Token = "0x401895E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032DC RID: 13020
		[Token(Token = "0x20032DC")]
		[Serializable]
		private struct ProfessionSpritePair
		{
			// Token: 0x0401895F RID: 100703
			[Token(Token = "0x401895F")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory profession;

			// Token: 0x04018960 RID: 100704
			[Token(Token = "0x4018960")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;
		}
	}
}
