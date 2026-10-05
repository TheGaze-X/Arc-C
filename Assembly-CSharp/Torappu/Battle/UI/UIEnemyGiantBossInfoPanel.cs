using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200330A RID: 13066
	[Token(Token = "0x200330A")]
	public class UIEnemyGiantBossInfoPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x06014C08 RID: 85000 RVA: 0x00088398 File Offset: 0x00086598
		// (set) Token: 0x06014C09 RID: 85001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003122")]
		public bool isAttached
		{
			[Token(Token = "0x6014C08")]
			[Address(RVA = "0xD2D7C0", Offset = "0xD2C3C0", VA = "0x180D2D7C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014C09")]
			[Address(RVA = "0xD2D880", Offset = "0xD2C480", VA = "0x180D2D880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x06014C0A RID: 85002 RVA: 0x000883B0 File Offset: 0x000865B0
		// (set) Token: 0x06014C0B RID: 85003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003123")]
		private protected bool isSkillCasting
		{
			[Token(Token = "0x6014C0A")]
			[Address(RVA = "0xD2D820", Offset = "0xD2C420", VA = "0x180D2D820")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6014C0B")]
			[Address(RVA = "0xD2D8F0", Offset = "0xD2C4F0", VA = "0x180D2D8F0")]
			private set
			{
			}
		}

		// Token: 0x06014C0C RID: 85004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C0C")]
		[Address(RVA = "0xD2AB40", Offset = "0xD29740", VA = "0x180D2AB40")]
		private void _LoadExtraInfoComponents()
		{
		}

		// Token: 0x06014C0D RID: 85005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C0D")]
		[Address(RVA = "0xD2B1F0", Offset = "0xD29DF0", VA = "0x180D2B1F0")]
		private void _SetSkillCastingInternal(bool value)
		{
		}

		// Token: 0x06014C0E RID: 85006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C0E")]
		[Address(RVA = "0xD2B140", Offset = "0xD29D40", VA = "0x180D2B140")]
		private void _SetLockedPosition(bool isLock)
		{
		}

		// Token: 0x06014C0F RID: 85007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C0F")]
		[Address(RVA = "0xD29B00", Offset = "0xD28700", VA = "0x180D29B00")]
		public void Attach(IUseGiantBossInfoPanel owner)
		{
		}

		// Token: 0x06014C10 RID: 85008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014C10")]
		[Address(RVA = "0xD2A770", Offset = "0xD29370", VA = "0x180D2A770")]
		private IEnumerator _DoAttach(IUseGiantBossInfoPanel owner)
		{
			return null;
		}

		// Token: 0x06014C11 RID: 85009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C11")]
		[Address(RVA = "0xD29F30", Offset = "0xD28B30", VA = "0x180D29F30")]
		public void Detach(IUseGiantBossInfoPanel owner)
		{
		}

		// Token: 0x06014C12 RID: 85010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C12")]
		[Address(RVA = "0xD2A840", Offset = "0xD29440", VA = "0x180D2A840")]
		private void _InitHitTween()
		{
		}

		// Token: 0x06014C13 RID: 85011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C13")]
		[Address(RVA = "0xD2A3D0", Offset = "0xD28FD0", VA = "0x180D2A3D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014C14 RID: 85012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C14")]
		[Address(RVA = "0xD2B320", Offset = "0xD29F20", VA = "0x180D2B320")]
		private void _StartExtraTween()
		{
		}

		// Token: 0x06014C15 RID: 85013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C15")]
		[Address(RVA = "0xD2C530", Offset = "0xD2B130", VA = "0x180D2C530")]
		private void _StartTweenAnim()
		{
		}

		// Token: 0x06014C16 RID: 85014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C16")]
		[Address(RVA = "0xD2BE90", Offset = "0xD2AA90", VA = "0x180D2BE90")]
		private void _StartPostTweenScaleX()
		{
		}

		// Token: 0x06014C17 RID: 85015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C17")]
		[Address(RVA = "0xD2B980", Offset = "0xD2A580", VA = "0x180D2B980")]
		private void _StartPostTweenImageAlpha()
		{
		}

		// Token: 0x06014C18 RID: 85016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C18")]
		[Address(RVA = "0xD2C090", Offset = "0xD2AC90", VA = "0x180D2C090")]
		private void _StartSpSliderTweenAnim()
		{
		}

		// Token: 0x06014C19 RID: 85017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C19")]
		[Address(RVA = "0xD2B550", Offset = "0xD2A150", VA = "0x180D2B550")]
		private void _StartHpSliderTweenAnim()
		{
		}

		// Token: 0x06014C1A RID: 85018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C1A")]
		[Address(RVA = "0xD29D80", Offset = "0xD28980", VA = "0x180D29D80")]
		private void Awake()
		{
		}

		// Token: 0x06014C1B RID: 85019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C1B")]
		[Address(RVA = "0xD2A670", Offset = "0xD29270", VA = "0x180D2A670")]
		private void Update()
		{
		}

		// Token: 0x06014C1C RID: 85020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C1C")]
		[Address(RVA = "0xD2D0E0", Offset = "0xD2BCE0", VA = "0x180D2D0E0")]
		private void _UpdateInternal(IUseGiantBossInfoPanel entity)
		{
		}

		// Token: 0x06014C1D RID: 85021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C1D")]
		[Address(RVA = "0xD2AFB0", Offset = "0xD29BB0", VA = "0x180D2AFB0")]
		private void _OnElementBreak(object arg)
		{
		}

		// Token: 0x06014C1E RID: 85022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C1E")]
		[Address(RVA = "0xD2CDA0", Offset = "0xD2B9A0", VA = "0x180D2CDA0")]
		private void _UpdateEp(IUseGiantBossInfoPanel owner)
		{
		}

		// Token: 0x06014C1F RID: 85023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C1F")]
		[Address(RVA = "0xD2B0C0", Offset = "0xD29CC0", VA = "0x180D2B0C0")]
		private void _OnTakeDamage(Unit owner)
		{
		}

		// Token: 0x06014C20 RID: 85024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C20")]
		[Address(RVA = "0xD2D5B0", Offset = "0xD2C1B0", VA = "0x180D2D5B0")]
		public UIEnemyGiantBossInfoPanel()
		{
		}

		// Token: 0x04018AE1 RID: 101089
		[Token(Token = "0x4018AE1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _scaleBody;

		// Token: 0x04018AE2 RID: 101090
		[Token(Token = "0x4018AE2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFollower _follower;

		// Token: 0x04018AE3 RID: 101091
		[Token(Token = "0x4018AE3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UITextSlider _hpSlider;

		// Token: 0x04018AE4 RID: 101092
		[Token(Token = "0x4018AE4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UITextSlider _exHpSlider;

		// Token: 0x04018AE5 RID: 101093
		[Token(Token = "0x4018AE5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIFollowEpSlider _epSlider;

		// Token: 0x04018AE6 RID: 101094
		[Token(Token = "0x4018AE6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _hitEffectImage;

		// Token: 0x04018AE7 RID: 101095
		[Token(Token = "0x4018AE7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _background;

		// Token: 0x04018AE8 RID: 101096
		[Token(Token = "0x4018AE8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _avatarParent;

		// Token: 0x04018AE9 RID: 101097
		[Token(Token = "0x4018AE9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _avatarImage;

		// Token: 0x04018AEA RID: 101098
		[Token(Token = "0x4018AEA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _smallAvatarImage;

		// Token: 0x04018AEB RID: 101099
		[Token(Token = "0x4018AEB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ExtraInfoComponents")]
		private List<UIEnemyGiantBossInfoPanel.GiantBossInfoPrefabs> _extraInfoType;

		// Token: 0x04018AEC RID: 101100
		[Token(Token = "0x4018AEC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("StartAnim")]
		private List<RectTransform> _scaleXTweenTrans;

		// Token: 0x04018AED RID: 101101
		[Token(Token = "0x4018AED")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("StartAnim")]
		private List<RectTransform> _postScaleXTweenTrans;

		// Token: 0x04018AEE RID: 101102
		[Token(Token = "0x4018AEE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("StartAnim")]
		private List<Image> _alphaTweenImages;

		// Token: 0x04018AEF RID: 101103
		[Token(Token = "0x4018AEF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("StartAnim")]
		private List<Image> _postAlphaTweenImages;

		// Token: 0x04018AF0 RID: 101104
		[Token(Token = "0x4018AF0")]
		[FieldOffset(Offset = "0x90")]
		private float m_scaleXTweenDuration;

		// Token: 0x04018AF1 RID: 101105
		[Token(Token = "0x4018AF1")]
		[FieldOffset(Offset = "0x94")]
		private float m_postScaleXTweenDuration;

		// Token: 0x04018AF2 RID: 101106
		[Token(Token = "0x4018AF2")]
		[FieldOffset(Offset = "0x98")]
		private bool m_postScaleXTweenStarted;

		// Token: 0x04018AF3 RID: 101107
		[Token(Token = "0x4018AF3")]
		[FieldOffset(Offset = "0x9C")]
		private float m_alphaTweenDuration;

		// Token: 0x04018AF4 RID: 101108
		[Token(Token = "0x4018AF4")]
		[FieldOffset(Offset = "0xA0")]
		private float m_postAlphaTweenDuration;

		// Token: 0x04018AF5 RID: 101109
		[Token(Token = "0x4018AF5")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_postAlphaTweenStarted;

		// Token: 0x04018AF6 RID: 101110
		[Token(Token = "0x4018AF6")]
		[FieldOffset(Offset = "0xA8")]
		private float m_spSliderAlphaTweenDuration;

		// Token: 0x04018AF7 RID: 101111
		[Token(Token = "0x4018AF7")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_showedSpSlider;

		// Token: 0x04018AF8 RID: 101112
		[Token(Token = "0x4018AF8")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_hitEffectTween;

		// Token: 0x04018AF9 RID: 101113
		[Token(Token = "0x4018AF9")]
		[FieldOffset(Offset = "0xB8")]
		private float m_hitEffectTweenDuration;

		// Token: 0x04018AFA RID: 101114
		[Token(Token = "0x4018AFA")]
		[FieldOffset(Offset = "0xC0")]
		private ObjectPtr<IUseGiantBossInfoPanel> m_owner;

		// Token: 0x04018AFB RID: 101115
		[Token(Token = "0x4018AFB")]
		[FieldOffset(Offset = "0xD0")]
		private ObjectPtr<Entity> m_ownerEntityPtr;

		// Token: 0x04018AFC RID: 101116
		[Token(Token = "0x4018AFC")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isSkillCasting;

		// Token: 0x04018AFD RID: 101117
		[Token(Token = "0x4018AFD")]
		[FieldOffset(Offset = "0xE8")]
		private CoroutineId m_coroutine;

		// Token: 0x04018AFE RID: 101118
		[Token(Token = "0x4018AFE")]
		[FieldOffset(Offset = "0xF8")]
		private RectTransform m_rectTransform;

		// Token: 0x04018AFF RID: 101119
		[Token(Token = "0x4018AFF")]
		[FieldOffset(Offset = "0x100")]
		private Vector2 m_originalPosition;

		// Token: 0x04018B00 RID: 101120
		[Token(Token = "0x4018B00")]
		[FieldOffset(Offset = "0x108")]
		private Vector2 m_originalAvatarPosition;

		// Token: 0x04018B01 RID: 101121
		[Token(Token = "0x4018B01")]
		[FieldOffset(Offset = "0x110")]
		private bool m_hideHpSlider;

		// Token: 0x04018B02 RID: 101122
		[Token(Token = "0x4018B02")]
		[FieldOffset(Offset = "0x111")]
		private bool m_hideSpSlider;

		// Token: 0x04018B03 RID: 101123
		[Token(Token = "0x4018B03")]
		[FieldOffset(Offset = "0x114")]
		private Color m_defaultHitImageColor;

		// Token: 0x04018B04 RID: 101124
		[Token(Token = "0x4018B04")]
		[FieldOffset(Offset = "0x124")]
		private BattleUIConst.GiantBossInfoType m_giantBossInfoType;

		// Token: 0x04018B05 RID: 101125
		[Token(Token = "0x4018B05")]
		[FieldOffset(Offset = "0x128")]
		private UITextSlider m_spSlider;

		// Token: 0x04018B06 RID: 101126
		[Token(Token = "0x4018B06")]
		[FieldOffset(Offset = "0x130")]
		private UITextSlider m_spBackSlider;

		// Token: 0x04018B07 RID: 101127
		[Token(Token = "0x4018B07")]
		[FieldOffset(Offset = "0x138")]
		private UITextSlider m_spCastSlider;

		// Token: 0x04018B08 RID: 101128
		[Token(Token = "0x4018B08")]
		[FieldOffset(Offset = "0x140")]
		private UIGiantEnemySpWarning m_enemySpWarning;

		// Token: 0x04018B0A RID: 101130
		[Token(Token = "0x4018B0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAttached;

		// Token: 0x04018B0B RID: 101131
		[Token(Token = "0x4018B0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isAttached;

		// Token: 0x04018B0C RID: 101132
		[Token(Token = "0x4018B0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isSkillCasting;

		// Token: 0x04018B0D RID: 101133
		[Token(Token = "0x4018B0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isSkillCasting;

		// Token: 0x04018B0E RID: 101134
		[Token(Token = "0x4018B0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadExtraInfoComponents;

		// Token: 0x04018B0F RID: 101135
		[Token(Token = "0x4018B0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetSkillCastingInternal;

		// Token: 0x04018B10 RID: 101136
		[Token(Token = "0x4018B10")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetLockedPosition;

		// Token: 0x04018B11 RID: 101137
		[Token(Token = "0x4018B11")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Attach;

		// Token: 0x04018B12 RID: 101138
		[Token(Token = "0x4018B12")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoAttach;

		// Token: 0x04018B13 RID: 101139
		[Token(Token = "0x4018B13")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Detach;

		// Token: 0x04018B14 RID: 101140
		[Token(Token = "0x4018B14")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitHitTween;

		// Token: 0x04018B15 RID: 101141
		[Token(Token = "0x4018B15")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018B16 RID: 101142
		[Token(Token = "0x4018B16")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StartExtraTween;

		// Token: 0x04018B17 RID: 101143
		[Token(Token = "0x4018B17")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__StartTweenAnim;

		// Token: 0x04018B18 RID: 101144
		[Token(Token = "0x4018B18")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__StartPostTweenScaleX;

		// Token: 0x04018B19 RID: 101145
		[Token(Token = "0x4018B19")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__StartPostTweenImageAlpha;

		// Token: 0x04018B1A RID: 101146
		[Token(Token = "0x4018B1A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__StartSpSliderTweenAnim;

		// Token: 0x04018B1B RID: 101147
		[Token(Token = "0x4018B1B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__StartHpSliderTweenAnim;

		// Token: 0x04018B1C RID: 101148
		[Token(Token = "0x4018B1C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018B1D RID: 101149
		[Token(Token = "0x4018B1D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018B1E RID: 101150
		[Token(Token = "0x4018B1E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateInternal;

		// Token: 0x04018B1F RID: 101151
		[Token(Token = "0x4018B1F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnElementBreak;

		// Token: 0x04018B20 RID: 101152
		[Token(Token = "0x4018B20")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateEp;

		// Token: 0x04018B21 RID: 101153
		[Token(Token = "0x4018B21")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnTakeDamage;

		// Token: 0x04018B22 RID: 101154
		[Token(Token = "0x4018B22")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200330B RID: 13067
		[Token(Token = "0x200330B")]
		[Serializable]
		private struct GiantBossInfoPrefabs
		{
			// Token: 0x04018B23 RID: 101155
			[Token(Token = "0x4018B23")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public GameObject enemySpWarning;

			// Token: 0x04018B24 RID: 101156
			[Token(Token = "0x4018B24")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public GameObject spSlider;

			// Token: 0x04018B25 RID: 101157
			[Token(Token = "0x4018B25")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public GameObject spCastSlider;
		}
	}
}
