using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DE8 RID: 28136
	[Token(Token = "0x2006DE8")]
	public class ActVecBreakV2OffenseBattleFinishAnimationView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060280FB RID: 164091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280FB")]
		[Address(RVA = "0x234FE80", Offset = "0x234EA80", VA = "0x18234FE80")]
		public void Render(ActVecBreakV2OffenseBattleFinishViewModel model)
		{
		}

		// Token: 0x060280FC RID: 164092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280FC")]
		[Address(RVA = "0x234FD50", Offset = "0x234E950", VA = "0x18234FD50")]
		public void PlayEnterAnim()
		{
		}

		// Token: 0x060280FD RID: 164093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280FD")]
		[Address(RVA = "0x234FDD0", Offset = "0x234E9D0", VA = "0x18234FDD0")]
		public IEnumerator PlayNextAnimCoroutine()
		{
			return null;
		}

		// Token: 0x060280FE RID: 164094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280FE")]
		[Address(RVA = "0x234FCE0", Offset = "0x234E8E0", VA = "0x18234FCE0")]
		public void OnNextClick()
		{
		}

		// Token: 0x060280FF RID: 164095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280FF")]
		[Address(RVA = "0x234FC70", Offset = "0x234E870", VA = "0x18234FC70")]
		public void OnCloseClick()
		{
		}

		// Token: 0x06028100 RID: 164096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028100")]
		[Address(RVA = "0x2350AC0", Offset = "0x234F6C0", VA = "0x182350AC0")]
		private void _RenderEnterPanel()
		{
		}

		// Token: 0x06028101 RID: 164097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028101")]
		[Address(RVA = "0x2350D50", Offset = "0x234F950", VA = "0x182350D50")]
		private void _RenderNormalEnterPanel()
		{
		}

		// Token: 0x06028102 RID: 164098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028102")]
		[Address(RVA = "0x2350BC0", Offset = "0x234F7C0", VA = "0x182350BC0")]
		private void _RenderHardEnterPanel()
		{
		}

		// Token: 0x06028103 RID: 164099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028103")]
		[Address(RVA = "0x2350980", Offset = "0x234F580", VA = "0x182350980")]
		private void _RenderCharacters()
		{
		}

		// Token: 0x06028104 RID: 164100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028104")]
		[Address(RVA = "0x2350C60", Offset = "0x234F860", VA = "0x182350C60")]
		private void _RenderMilestone()
		{
		}

		// Token: 0x06028105 RID: 164101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028105")]
		[Address(RVA = "0x2350530", Offset = "0x234F130", VA = "0x182350530")]
		private void _NotifyHardZoneUnlock()
		{
		}

		// Token: 0x06028106 RID: 164102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028106")]
		[Address(RVA = "0x23506B0", Offset = "0x234F2B0", VA = "0x1823506B0")]
		private void _PlayCharVoice()
		{
		}

		// Token: 0x06028107 RID: 164103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028107")]
		[Address(RVA = "0x23505B0", Offset = "0x234F1B0", VA = "0x1823505B0")]
		private Tween _PlayAnim(UIAnimationLocation animLocation)
		{
			return null;
		}

		// Token: 0x06028108 RID: 164104 RVA: 0x000D0980 File Offset: 0x000CEB80
		[Token(Token = "0x6028108")]
		[Address(RVA = "0x2350410", Offset = "0x234F010", VA = "0x182350410")]
		private int _MilestoneTweenGetter()
		{
			return 0;
		}

		// Token: 0x06028109 RID: 164105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028109")]
		[Address(RVA = "0x2350470", Offset = "0x234F070", VA = "0x182350470")]
		private void _MilestoneTweenSetter(int value)
		{
		}

		// Token: 0x0602810A RID: 164106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602810A")]
		[Address(RVA = "0x2350790", Offset = "0x234F390", VA = "0x182350790")]
		private void _PlayMilestoneTween()
		{
		}

		// Token: 0x0602810B RID: 164107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602810B")]
		[Address(RVA = "0x23502E0", Offset = "0x234EEE0", VA = "0x1823502E0")]
		private void _ClearPlayingTween()
		{
		}

		// Token: 0x0602810C RID: 164108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602810C")]
		[Address(RVA = "0x2350FF0", Offset = "0x234FBF0", VA = "0x182350FF0")]
		public ActVecBreakV2OffenseBattleFinishAnimationView()
		{
		}

		// Token: 0x04038D30 RID: 232752
		[Token(Token = "0x4038D30")]
		private const float NEXT_ANIM_CHAR_VOICE_INTERVAL = 0.5f;

		// Token: 0x04038D31 RID: 232753
		[Token(Token = "0x4038D31")]
		private const float NEXT_ANIM_SHOW_NOTIFY_INTERVAL = 1f;

		// Token: 0x04038D32 RID: 232754
		[Token(Token = "0x4038D32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _normalStageLevelText;

		// Token: 0x04038D33 RID: 232755
		[Token(Token = "0x4038D33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _finalStageLevelText;

		// Token: 0x04038D34 RID: 232756
		[Token(Token = "0x4038D34")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _hardStageOrderImg;

		// Token: 0x04038D35 RID: 232757
		[Token(Token = "0x4038D35")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActVecBreakV2OffenseBattleFinishBuffListPanel _buffListPanel;

		// Token: 0x04038D36 RID: 232758
		[Token(Token = "0x4038D36")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActVecBreakV2OffenseBattleFinishStageInfoPanel _stageInfoPanel;

		// Token: 0x04038D37 RID: 232759
		[Token(Token = "0x4038D37")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ActVecBreakV2OffenseBattleFinishCharCardHolder[] _charCardHolders;

		// Token: 0x04038D38 RID: 232760
		[Token(Token = "0x4038D38")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ActVecBreakV2OffenseBattleFinishCharCardHolder _assistCharCardHolder;

		// Token: 0x04038D39 RID: 232761
		[Token(Token = "0x4038D39")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActVecBreakV2BattleFinishMilestoneView _milestoneView;

		// Token: 0x04038D3A RID: 232762
		[Token(Token = "0x4038D3A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _msTweenDelay;

		// Token: 0x04038D3B RID: 232763
		[Token(Token = "0x4038D3B")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _msTweenDuration;

		// Token: 0x04038D3C RID: 232764
		[Token(Token = "0x4038D3C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject[] _normalGos;

		// Token: 0x04038D3D RID: 232765
		[Token(Token = "0x4038D3D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] _finalGos;

		// Token: 0x04038D3E RID: 232766
		[Token(Token = "0x4038D3E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04038D3F RID: 232767
		[Token(Token = "0x4038D3F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _nextAnim;

		// Token: 0x04038D40 RID: 232768
		[Token(Token = "0x4038D40")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action onNextClick;

		// Token: 0x04038D41 RID: 232769
		[Token(Token = "0x4038D41")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action onCloseClick;

		// Token: 0x04038D42 RID: 232770
		[Token(Token = "0x4038D42")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_animTween;

		// Token: 0x04038D43 RID: 232771
		[Token(Token = "0x4038D43")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_nextTween;

		// Token: 0x04038D44 RID: 232772
		[Token(Token = "0x4038D44")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_milestoneTween;

		// Token: 0x04038D45 RID: 232773
		[Token(Token = "0x4038D45")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedMilestonePoint;

		// Token: 0x04038D46 RID: 232774
		[Token(Token = "0x4038D46")]
		[FieldOffset(Offset = "0xC0")]
		private ActVecBreakV2OffenseBattleFinishViewModel m_cachedModel;

		// Token: 0x04038D47 RID: 232775
		[Token(Token = "0x4038D47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038D48 RID: 232776
		[Token(Token = "0x4038D48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x04038D49 RID: 232777
		[Token(Token = "0x4038D49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayNextAnimCoroutine;

		// Token: 0x04038D4A RID: 232778
		[Token(Token = "0x4038D4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnNextClick;

		// Token: 0x04038D4B RID: 232779
		[Token(Token = "0x4038D4B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCloseClick;

		// Token: 0x04038D4C RID: 232780
		[Token(Token = "0x4038D4C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderEnterPanel;

		// Token: 0x04038D4D RID: 232781
		[Token(Token = "0x4038D4D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderNormalEnterPanel;

		// Token: 0x04038D4E RID: 232782
		[Token(Token = "0x4038D4E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderHardEnterPanel;

		// Token: 0x04038D4F RID: 232783
		[Token(Token = "0x4038D4F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderCharacters;

		// Token: 0x04038D50 RID: 232784
		[Token(Token = "0x4038D50")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderMilestone;

		// Token: 0x04038D51 RID: 232785
		[Token(Token = "0x4038D51")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__NotifyHardZoneUnlock;

		// Token: 0x04038D52 RID: 232786
		[Token(Token = "0x4038D52")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayCharVoice;

		// Token: 0x04038D53 RID: 232787
		[Token(Token = "0x4038D53")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x04038D54 RID: 232788
		[Token(Token = "0x4038D54")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__MilestoneTweenGetter;

		// Token: 0x04038D55 RID: 232789
		[Token(Token = "0x4038D55")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__MilestoneTweenSetter;

		// Token: 0x04038D56 RID: 232790
		[Token(Token = "0x4038D56")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__PlayMilestoneTween;

		// Token: 0x04038D57 RID: 232791
		[Token(Token = "0x4038D57")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearPlayingTween;

		// Token: 0x04038D58 RID: 232792
		[Token(Token = "0x4038D58")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
