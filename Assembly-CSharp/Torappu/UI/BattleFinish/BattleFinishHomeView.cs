using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006209 RID: 25097
	[Token(Token = "0x2006209")]
	public class BattleFinishHomeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024362 RID: 148322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024362")]
		[Address(RVA = "0x1F152C0", Offset = "0x1F13EC0", VA = "0x181F152C0")]
		public void Init(BattleFinishHomeView.Host host)
		{
		}

		// Token: 0x06024363 RID: 148323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024363")]
		[Address(RVA = "0x1F14EA0", Offset = "0x1F13AA0", VA = "0x181F14EA0")]
		public void DoShowEffect()
		{
		}

		// Token: 0x06024364 RID: 148324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024364")]
		[Address(RVA = "0x1F150A0", Offset = "0x1F13CA0", VA = "0x181F150A0")]
		public void EventOnViewClicked()
		{
		}

		// Token: 0x06024365 RID: 148325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024365")]
		[Address(RVA = "0x1F15B00", Offset = "0x1F14700", VA = "0x181F15B00")]
		private IEnumerator _FinishBattleActCoroutine()
		{
			return null;
		}

		// Token: 0x06024366 RID: 148326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024366")]
		[Address(RVA = "0x1F15C60", Offset = "0x1F14860", VA = "0x181F15C60")]
		private void _RenderDrop()
		{
		}

		// Token: 0x06024367 RID: 148327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024367")]
		[Address(RVA = "0x1F15BB0", Offset = "0x1F147B0", VA = "0x181F15BB0")]
		private IEnumerator _RenderDropCoroutine()
		{
			return null;
		}

		// Token: 0x06024368 RID: 148328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024368")]
		[Address(RVA = "0x1F15FF0", Offset = "0x1F14BF0", VA = "0x181F15FF0")]
		private void _TryToInitMetaDisplayView()
		{
		}

		// Token: 0x06024369 RID: 148329 RVA: 0x000C3738 File Offset: 0x000C1938
		[Token(Token = "0x6024369")]
		[Address(RVA = "0x1F16250", Offset = "0x1F14E50", VA = "0x181F16250")]
		private bool _TryToShowMetaDisplayView()
		{
			return default(bool);
		}

		// Token: 0x0602436A RID: 148330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602436A")]
		[Address(RVA = "0x1F16380", Offset = "0x1F14F80", VA = "0x181F16380")]
		public BattleFinishHomeView()
		{
		}

		// Token: 0x04032598 RID: 206232
		[Token(Token = "0x4032598")]
		private const float PASTTIME = 0.2f;

		// Token: 0x04032599 RID: 206233
		[Token(Token = "0x4032599")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIExpBar _playerExpBar;

		// Token: 0x0403259A RID: 206234
		[Token(Token = "0x403259A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISingleValueChangeBar _campaignFeeBar;

		// Token: 0x0403259B RID: 206235
		[Token(Token = "0x403259B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BattleFinishInfoView _battleInfoView;

		// Token: 0x0403259C RID: 206236
		[Token(Token = "0x403259C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _pryIntro;

		// Token: 0x0403259D RID: 206237
		[Token(Token = "0x403259D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BattleFinishDropInfoView _dropInfoView;

		// Token: 0x0403259E RID: 206238
		[Token(Token = "0x403259E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _pryDropRoot;

		// Token: 0x0403259F RID: 206239
		[Token(Token = "0x403259F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BattleFinishDropPryInfoView _pryDropViewPrefab;

		// Token: 0x040325A0 RID: 206240
		[Token(Token = "0x40325A0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BattleFinishIllustView _illustView;

		// Token: 0x040325A1 RID: 206241
		[Token(Token = "0x40325A1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Animator _favoutAnimator;

		// Token: 0x040325A2 RID: 206242
		[Token(Token = "0x40325A2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _metaViewContainer;

		// Token: 0x040325A3 RID: 206243
		[Token(Token = "0x40325A3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BattleFinishDropRewardFrameHolder _frameHolder;

		// Token: 0x040325A4 RID: 206244
		[Token(Token = "0x40325A4")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isShowingChar;

		// Token: 0x040325A5 RID: 206245
		[Token(Token = "0x40325A5")]
		[FieldOffset(Offset = "0x71")]
		private bool m_isLoadingAnimEnd;

		// Token: 0x040325A6 RID: 206246
		[Token(Token = "0x40325A6")]
		[FieldOffset(Offset = "0x74")]
		private float m_animEndTime;

		// Token: 0x040325A7 RID: 206247
		[Token(Token = "0x40325A7")]
		[FieldOffset(Offset = "0x78")]
		private UIExpBarController m_expBarController;

		// Token: 0x040325A8 RID: 206248
		[Token(Token = "0x40325A8")]
		[FieldOffset(Offset = "0x80")]
		private List<BattleFinishDropPryInfoView> m_pryDropViews;

		// Token: 0x040325A9 RID: 206249
		[Token(Token = "0x40325A9")]
		[FieldOffset(Offset = "0x88")]
		private BattleFinishMetaDisplayView m_metaDisplayView;

		// Token: 0x040325AA RID: 206250
		[Token(Token = "0x40325AA")]
		[FieldOffset(Offset = "0x90")]
		private BattleFinishHomeView.Host m_host;

		// Token: 0x040325AB RID: 206251
		[Token(Token = "0x40325AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040325AC RID: 206252
		[Token(Token = "0x40325AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoShowEffect;

		// Token: 0x040325AD RID: 206253
		[Token(Token = "0x40325AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnViewClicked;

		// Token: 0x040325AE RID: 206254
		[Token(Token = "0x40325AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FinishBattleActCoroutine;

		// Token: 0x040325AF RID: 206255
		[Token(Token = "0x40325AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderDrop;

		// Token: 0x040325B0 RID: 206256
		[Token(Token = "0x40325B0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderDropCoroutine;

		// Token: 0x040325B1 RID: 206257
		[Token(Token = "0x40325B1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryToInitMetaDisplayView;

		// Token: 0x040325B2 RID: 206258
		[Token(Token = "0x40325B2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryToShowMetaDisplayView;

		// Token: 0x040325B3 RID: 206259
		[Token(Token = "0x40325B3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200620A RID: 25098
		[Token(Token = "0x200620A")]
		public class Host
		{
			// Token: 0x0602436E RID: 148334 RVA: 0x000C3750 File Offset: 0x000C1950
			[Token(Token = "0x602436E")]
			[Address(RVA = "0x1F1BC40", Offset = "0x1F1A840", VA = "0x181F1BC40")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x0602436F RID: 148335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602436F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Host()
			{
			}

			// Token: 0x040325B4 RID: 206260
			[Token(Token = "0x40325B4")]
			[FieldOffset(Offset = "0x10")]
			public State state;

			// Token: 0x040325B5 RID: 206261
			[Token(Token = "0x40325B5")]
			[FieldOffset(Offset = "0x18")]
			public CommonBattleFinishModel battleFinishModel;
		}
	}
}
