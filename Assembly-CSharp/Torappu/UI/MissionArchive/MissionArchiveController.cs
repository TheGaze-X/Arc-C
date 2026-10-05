using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x0200483F RID: 18495
	[Token(Token = "0x200483F")]
	public class MissionArchiveController : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x0601BEFD RID: 114429 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BEFE RID: 114430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004258")]
		public MissionArchivePage page
		{
			[Token(Token = "0x601BEFD")]
			[Address(RVA = "0x154FD80", Offset = "0x154E980", VA = "0x18154FD80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BEFE")]
			[Address(RVA = "0x154FE40", Offset = "0x154EA40", VA = "0x18154FE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x0601BEFF RID: 114431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004259")]
		public FadeSwitchTween contentSwitchTween
		{
			[Token(Token = "0x601BEFF")]
			[Address(RVA = "0x154FCC0", Offset = "0x154E8C0", VA = "0x18154FCC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x0601BF00 RID: 114432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700425A")]
		public FadeSwitchTween maskSwitchTween
		{
			[Token(Token = "0x601BF00")]
			[Address(RVA = "0x154FD20", Offset = "0x154E920", VA = "0x18154FD20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x0601BF01 RID: 114433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700425B")]
		public GameObject rtContentPrefab
		{
			[Token(Token = "0x601BF01")]
			[Address(RVA = "0x154FDE0", Offset = "0x154E9E0", VA = "0x18154FDE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BF02 RID: 114434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF02")]
		[Address(RVA = "0x154D6C0", Offset = "0x154C2C0", VA = "0x18154D6C0")]
		public void Init(string topicId, MissionArchiveExteriorPlayer exteriorPlayer)
		{
		}

		// Token: 0x0601BF03 RID: 114435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF03")]
		[Address(RVA = "0x154E620", Offset = "0x154D220", VA = "0x18154E620")]
		public void OnShow()
		{
		}

		// Token: 0x0601BF04 RID: 114436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF04")]
		[Address(RVA = "0x154E1C0", Offset = "0x154CDC0", VA = "0x18154E1C0")]
		public void OnBackEvent()
		{
		}

		// Token: 0x0601BF05 RID: 114437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF05")]
		[Address(RVA = "0x154F2B0", Offset = "0x154DEB0", VA = "0x18154F2B0")]
		private void _SelectNode(string nodeId)
		{
		}

		// Token: 0x0601BF06 RID: 114438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF06")]
		[Address(RVA = "0x154EDD0", Offset = "0x154D9D0", VA = "0x18154EDD0")]
		private void _PlayHiddenClips()
		{
		}

		// Token: 0x0601BF07 RID: 114439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF07")]
		[Address(RVA = "0x154F170", Offset = "0x154DD70", VA = "0x18154F170")]
		private void _Replay()
		{
		}

		// Token: 0x0601BF08 RID: 114440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF08")]
		[Address(RVA = "0x154EAB0", Offset = "0x154D6B0", VA = "0x18154EAB0")]
		private void _OnNodeRewardResponse(MissionArchiveService.IMissionArchiveClaimNodeRewardResponse response)
		{
		}

		// Token: 0x0601BF09 RID: 114441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF09")]
		[Address(RVA = "0x154F870", Offset = "0x154E470", VA = "0x18154F870")]
		private IEnumerator _ShowPlayNodeCoroutine(MissionArchiveService.IMissionArchiveClaimNodeRewardResponse response)
		{
			return null;
		}

		// Token: 0x0601BF0A RID: 114442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF0A")]
		[Address(RVA = "0x154F940", Offset = "0x154E540", VA = "0x18154F940")]
		private IEnumerator _ShowPlayNodeCoroutine()
		{
			return null;
		}

		// Token: 0x0601BF0B RID: 114443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF0B")]
		[Address(RVA = "0x154F7C0", Offset = "0x154E3C0", VA = "0x18154F7C0")]
		private IEnumerator _ShowPlayHiddenCoroutine()
		{
			return null;
		}

		// Token: 0x0601BF0C RID: 114444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF0C")]
		[Address(RVA = "0x154EA00", Offset = "0x154D600", VA = "0x18154EA00")]
		private IEnumerator _HidePlayCoroutine()
		{
			return null;
		}

		// Token: 0x0601BF0D RID: 114445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF0D")]
		[Address(RVA = "0x154EC90", Offset = "0x154D890", VA = "0x18154EC90")]
		private void _PlayBGM()
		{
		}

		// Token: 0x0601BF0E RID: 114446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF0E")]
		[Address(RVA = "0x154F0D0", Offset = "0x154DCD0", VA = "0x18154F0D0")]
		private void _RemoveBGM()
		{
		}

		// Token: 0x0601BF0F RID: 114447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF0F")]
		[Address(RVA = "0x154EFF0", Offset = "0x154DBF0", VA = "0x18154EFF0")]
		private void _PlayLoopFxForHiddenIfNeed()
		{
		}

		// Token: 0x0601BF10 RID: 114448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF10")]
		[Address(RVA = "0x154F9F0", Offset = "0x154E5F0", VA = "0x18154F9F0")]
		private void _StopLoopFxForHiddenIfNeed()
		{
		}

		// Token: 0x0601BF11 RID: 114449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF11")]
		[Address(RVA = "0x154FAA0", Offset = "0x154E6A0", VA = "0x18154FAA0")]
		public MissionArchiveController()
		{
		}

		// Token: 0x040246E3 RID: 149219
		[Token(Token = "0x40246E3")]
		private const float FADE_IN_DURATION = 0.12f;

		// Token: 0x040246E4 RID: 149220
		[Token(Token = "0x40246E4")]
		[FieldOffset(Offset = "0x18")]
		[Header("Ui Content")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040246E5 RID: 149221
		[Token(Token = "0x40246E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _entryAnimation;

		// Token: 0x040246E6 RID: 149222
		[Token(Token = "0x40246E6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MissionArchiveMainView _mainView;

		// Token: 0x040246E7 RID: 149223
		[Token(Token = "0x40246E7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MissionArchivePlayView _playView;

		// Token: 0x040246E8 RID: 149224
		[Token(Token = "0x40246E8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MissionArchiveHintView _hintView;

		// Token: 0x040246E9 RID: 149225
		[Token(Token = "0x40246E9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MissionArchiveDataServiceProxy _dataServiceProxy;

		// Token: 0x040246EA RID: 149226
		[Token(Token = "0x40246EA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _contentGroup;

		// Token: 0x040246EB RID: 149227
		[Token(Token = "0x40246EB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _maskGroup;

		// Token: 0x040246EC RID: 149228
		[Token(Token = "0x40246EC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonPageEffectHolder[] _effectHolders;

		// Token: 0x040246ED RID: 149229
		[Token(Token = "0x40246ED")]
		[FieldOffset(Offset = "0x68")]
		[Header("Rt Content")]
		[SerializeField]
		[Space(12f)]
		private GameObject _rtContentPrefab;

		// Token: 0x040246EE RID: 149230
		[Token(Token = "0x40246EE")]
		[FieldOffset(Offset = "0x70")]
		[Space(12f)]
		[Header("Audio Config")]
		public MissionArchiveController.AudioConfig _audioConfig;

		// Token: 0x040246EF RID: 149231
		[Token(Token = "0x40246EF")]
		[FieldOffset(Offset = "0x88")]
		private string m_topicId;

		// Token: 0x040246F0 RID: 149232
		[Token(Token = "0x40246F0")]
		[FieldOffset(Offset = "0x90")]
		private MissionArchiveViewProperty m_property;

		// Token: 0x040246F1 RID: 149233
		[Token(Token = "0x40246F1")]
		[FieldOffset(Offset = "0x98")]
		private UIAnimationTween.Builder m_entryTweenBuilder;

		// Token: 0x040246F2 RID: 149234
		[Token(Token = "0x40246F2")]
		[FieldOffset(Offset = "0xC0")]
		private UIAnimationTween m_entryTween;

		// Token: 0x040246F3 RID: 149235
		[Token(Token = "0x40246F3")]
		[FieldOffset(Offset = "0xC8")]
		private MissionArchivePlayer m_player;

		// Token: 0x040246F4 RID: 149236
		[Token(Token = "0x40246F4")]
		[FieldOffset(Offset = "0xD0")]
		private FadeSwitchTween m_contentSwitchTween;

		// Token: 0x040246F5 RID: 149237
		[Token(Token = "0x40246F5")]
		[FieldOffset(Offset = "0xD8")]
		private FadeSwitchTween m_maskSwitchTween;

		// Token: 0x040246F6 RID: 149238
		[Token(Token = "0x40246F6")]
		[FieldOffset(Offset = "0xE0")]
		private MissionArchiveNodeViewModel m_cachedSelectedNode;

		// Token: 0x040246F7 RID: 149239
		[Token(Token = "0x40246F7")]
		[FieldOffset(Offset = "0xE8")]
		private Coroutine m_switchCoroutine;

		// Token: 0x040246F8 RID: 149240
		[Token(Token = "0x40246F8")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_nodeSelectTween;

		// Token: 0x040246F9 RID: 149241
		[Token(Token = "0x40246F9")]
		[FieldOffset(Offset = "0xF8")]
		private Tween m_playShowTween;

		// Token: 0x040246FA RID: 149242
		[Token(Token = "0x40246FA")]
		[FieldOffset(Offset = "0x100")]
		private Tween m_playHideTween;

		// Token: 0x040246FB RID: 149243
		[Token(Token = "0x40246FB")]
		[FieldOffset(Offset = "0x108")]
		private bool m_freezeBack;

		// Token: 0x040246FC RID: 149244
		[Token(Token = "0x40246FC")]
		[FieldOffset(Offset = "0x110")]
		private long m_musicInstId;

		// Token: 0x040246FD RID: 149245
		[Token(Token = "0x40246FD")]
		[FieldOffset(Offset = "0x118")]
		private bool m_loopFxForHiddenPlayed;

		// Token: 0x040246FF RID: 149247
		[Token(Token = "0x40246FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04024700 RID: 149248
		[Token(Token = "0x4024700")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04024701 RID: 149249
		[Token(Token = "0x4024701")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_contentSwitchTween;

		// Token: 0x04024702 RID: 149250
		[Token(Token = "0x4024702")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_maskSwitchTween;

		// Token: 0x04024703 RID: 149251
		[Token(Token = "0x4024703")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rtContentPrefab;

		// Token: 0x04024704 RID: 149252
		[Token(Token = "0x4024704")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024705 RID: 149253
		[Token(Token = "0x4024705")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x04024706 RID: 149254
		[Token(Token = "0x4024706")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x04024707 RID: 149255
		[Token(Token = "0x4024707")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SelectNode;

		// Token: 0x04024708 RID: 149256
		[Token(Token = "0x4024708")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayHiddenClips;

		// Token: 0x04024709 RID: 149257
		[Token(Token = "0x4024709")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Replay;

		// Token: 0x0402470A RID: 149258
		[Token(Token = "0x402470A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnNodeRewardResponse;

		// Token: 0x0402470B RID: 149259
		[Token(Token = "0x402470B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShowPlayNodeCoroutine;

		// Token: 0x0402470C RID: 149260
		[Token(Token = "0x402470C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix1__ShowPlayNodeCoroutine;

		// Token: 0x0402470D RID: 149261
		[Token(Token = "0x402470D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ShowPlayHiddenCoroutine;

		// Token: 0x0402470E RID: 149262
		[Token(Token = "0x402470E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HidePlayCoroutine;

		// Token: 0x0402470F RID: 149263
		[Token(Token = "0x402470F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__PlayBGM;

		// Token: 0x04024710 RID: 149264
		[Token(Token = "0x4024710")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RemoveBGM;

		// Token: 0x04024711 RID: 149265
		[Token(Token = "0x4024711")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlayLoopFxForHiddenIfNeed;

		// Token: 0x04024712 RID: 149266
		[Token(Token = "0x4024712")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__StopLoopFxForHiddenIfNeed;

		// Token: 0x04024713 RID: 149267
		[Token(Token = "0x4024713")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004840 RID: 18496
		[Token(Token = "0x2004840")]
		[Serializable]
		public struct AudioConfig
		{
			// Token: 0x04024714 RID: 149268
			[Token(Token = "0x4024714")]
			[FieldOffset(Offset = "0x0")]
			public string loopFxForHidden;

			// Token: 0x04024715 RID: 149269
			[Token(Token = "0x4024715")]
			[FieldOffset(Offset = "0x8")]
			public string loopFxForHiddenCtrl;

			// Token: 0x04024716 RID: 149270
			[Token(Token = "0x4024716")]
			[FieldOffset(Offset = "0x10")]
			public string fxOnPlayEnd;
		}
	}
}
