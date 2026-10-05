using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F12 RID: 28434
	[Token(Token = "0x2006F12")]
	public class ActMultiV3EntryPage : StateEnginePage
	{
		// Token: 0x17005F51 RID: 24401
		// (get) Token: 0x06028623 RID: 165411 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028624 RID: 165412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F51")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x6028623")]
			[Address(RVA = "0x23AEEE0", Offset = "0x23ADAE0", VA = "0x1823AEEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028624")]
			[Address(RVA = "0x23AF060", Offset = "0x23ADC60", VA = "0x1823AF060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F52 RID: 24402
		// (get) Token: 0x06028625 RID: 165413 RVA: 0x000D1B20 File Offset: 0x000CFD20
		[Token(Token = "0x17005F52")]
		public bool isStable
		{
			[Token(Token = "0x6028625")]
			[Address(RVA = "0x23AEF40", Offset = "0x23ADB40", VA = "0x1823AEF40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F53 RID: 24403
		// (get) Token: 0x06028626 RID: 165414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F53")]
		public string actId
		{
			[Token(Token = "0x6028626")]
			[Address(RVA = "0x23AEE00", Offset = "0x23ADA00", VA = "0x1823AEE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F54 RID: 24404
		// (get) Token: 0x06028627 RID: 165415 RVA: 0x000D1B38 File Offset: 0x000CFD38
		[Token(Token = "0x17005F54")]
		private ActMultiV3RouteTarget routeTarget
		{
			[Token(Token = "0x6028627")]
			[Address(RVA = "0x23AEFD0", Offset = "0x23ADBD0", VA = "0x1823AEFD0")]
			get
			{
				return ActMultiV3RouteTarget.NONE;
			}
		}

		// Token: 0x06028628 RID: 165416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028628")]
		[Address(RVA = "0x23AD860", Offset = "0x23AC460", VA = "0x1823AD860")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028629 RID: 165417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028629")]
		[Address(RVA = "0x23ACCE0", Offset = "0x23AB8E0", VA = "0x1823ACCE0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602862A RID: 165418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602862A")]
		[Address(RVA = "0x23AD1E0", Offset = "0x23ABDE0", VA = "0x1823AD1E0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602862B RID: 165419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602862B")]
		[Address(RVA = "0x23ACFB0", Offset = "0x23ABBB0", VA = "0x1823ACFB0", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0602862C RID: 165420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602862C")]
		[Address(RVA = "0x23AE480", Offset = "0x23AD080", VA = "0x1823AE480")]
		private void _ResetEntryStateShowStatus(ActMultiV3EntryState.ShowStatus showStatus)
		{
		}

		// Token: 0x0602862D RID: 165421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602862D")]
		[Address(RVA = "0x23AD960", Offset = "0x23AC560", VA = "0x1823AD960")]
		private void _OnGetInfoResponseBack()
		{
		}

		// Token: 0x0602862E RID: 165422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602862E")]
		[Address(RVA = "0x23ADAA0", Offset = "0x23AC6A0", VA = "0x1823ADAA0")]
		private void _OnGetInfoResponseForward()
		{
		}

		// Token: 0x0602862F RID: 165423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602862F")]
		[Address(RVA = "0x23AE830", Offset = "0x23AD430", VA = "0x1823AE830")]
		private void _SetCameraActive(bool active, ActMultiV3EntryPage.CameraActiveSrc src)
		{
		}

		// Token: 0x06028630 RID: 165424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028630")]
		[Address(RVA = "0x23AD7B0", Offset = "0x23AC3B0", VA = "0x1823AD7B0")]
		private void _DisplayPage(bool isShow)
		{
		}

		// Token: 0x06028631 RID: 165425 RVA: 0x000D1B50 File Offset: 0x000CFD50
		[Token(Token = "0x6028631")]
		[Address(RVA = "0x23AEB60", Offset = "0x23AD760", VA = "0x1823AEB60")]
		private bool _TryTriggerAVG()
		{
			return default(bool);
		}

		// Token: 0x06028632 RID: 165426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028632")]
		[Address(RVA = "0x23AEA20", Offset = "0x23AD620", VA = "0x1823AEA20")]
		private void _TriggerBGM()
		{
		}

		// Token: 0x06028633 RID: 165427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028633")]
		[Address(RVA = "0x23ACC10", Offset = "0x23AB810", VA = "0x1823ACC10", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06028634 RID: 165428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028634")]
		[Address(RVA = "0x23ACB30", Offset = "0x23AB730", VA = "0x1823ACB30", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x06028635 RID: 165429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028635")]
		[Address(RVA = "0x23AE5C0", Offset = "0x23AD1C0", VA = "0x1823AE5C0")]
		private void _SendGetInfoRequest(Action onProceed)
		{
		}

		// Token: 0x06028636 RID: 165430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028636")]
		[Address(RVA = "0x23AD650", Offset = "0x23AC250", VA = "0x1823AD650")]
		public void SetCameraActiveByStateTransition(bool active)
		{
		}

		// Token: 0x06028637 RID: 165431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028637")]
		[Address(RVA = "0x23ACF40", Offset = "0x23ABB40", VA = "0x1823ACF40", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06028638 RID: 165432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028638")]
		[Address(RVA = "0x23AE310", Offset = "0x23ACF10", VA = "0x1823AE310")]
		private void _ProcessDelayedAlerts()
		{
		}

		// Token: 0x06028639 RID: 165433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028639")]
		[Address(RVA = "0x23AD720", Offset = "0x23AC320", VA = "0x1823AD720")]
		private void _ClearProcessDelayedAlertsCoroutine()
		{
		}

		// Token: 0x0602863A RID: 165434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602863A")]
		[Address(RVA = "0x23AE900", Offset = "0x23AD500", VA = "0x1823AE900")]
		private void _StartProcessDelayedAlertsCoroutine()
		{
		}

		// Token: 0x0602863B RID: 165435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602863B")]
		[Address(RVA = "0x23AE260", Offset = "0x23ACE60", VA = "0x1823AE260")]
		private IEnumerator _ProcessDelayedAlertsCoroutine()
		{
			return null;
		}

		// Token: 0x0602863C RID: 165436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602863C")]
		[Address(RVA = "0x23AEDA0", Offset = "0x23AD9A0", VA = "0x1823AEDA0")]
		public ActMultiV3EntryPage()
		{
		}

		// Token: 0x06028641 RID: 165441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028641")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06028642 RID: 165442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028642")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06028643 RID: 165443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028643")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x06028644 RID: 165444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028644")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x06028645 RID: 165445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028645")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x06028646 RID: 165446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028646")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x040396D0 RID: 235216
		[Token(Token = "0x40396D0")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup _canvasMask;

		// Token: 0x040396D1 RID: 235217
		[Token(Token = "0x40396D1")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIAtlasImage _imgMask;

		// Token: 0x040396D2 RID: 235218
		[Token(Token = "0x40396D2")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Camera _worldCamera;

		// Token: 0x040396D3 RID: 235219
		[Token(Token = "0x40396D3")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private CanvasGroup _canvasUI;

		// Token: 0x040396D4 RID: 235220
		[Token(Token = "0x40396D4")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float _showDelay;

		// Token: 0x040396D5 RID: 235221
		[Token(Token = "0x40396D5")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private float _hideDelay;

		// Token: 0x040396D6 RID: 235222
		[Token(Token = "0x40396D6")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x040396D7 RID: 235223
		[Token(Token = "0x40396D7")]
		[FieldOffset(Offset = "0x120")]
		private bool m_inited;

		// Token: 0x040396D8 RID: 235224
		[Token(Token = "0x40396D8")]
		[FieldOffset(Offset = "0x128")]
		private FadeSwitchTween m_maskTween;

		// Token: 0x040396D9 RID: 235225
		[Token(Token = "0x40396D9")]
		[FieldOffset(Offset = "0x130")]
		private Tween m_delayTween;

		// Token: 0x040396DA RID: 235226
		[Token(Token = "0x40396DA")]
		[FieldOffset(Offset = "0x138")]
		private int m_cameraInactiveFlag;

		// Token: 0x040396DB RID: 235227
		[Token(Token = "0x40396DB")]
		[FieldOffset(Offset = "0x13C")]
		private bool m_infoUpdated;

		// Token: 0x040396DC RID: 235228
		[Token(Token = "0x40396DC")]
		[FieldOffset(Offset = "0x140")]
		private DataBundle m_savedInst;

		// Token: 0x040396DD RID: 235229
		[Token(Token = "0x40396DD")]
		[FieldOffset(Offset = "0x148")]
		private ActMultiV3EntryPage.Params m_param;

		// Token: 0x040396DE RID: 235230
		[Token(Token = "0x40396DE")]
		[FieldOffset(Offset = "0x150")]
		private Coroutine m_processDelayedAlertsCoroutine;

		// Token: 0x040396E0 RID: 235232
		[Token(Token = "0x40396E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x040396E1 RID: 235233
		[Token(Token = "0x40396E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_dialogMgr;

		// Token: 0x040396E2 RID: 235234
		[Token(Token = "0x40396E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isStable;

		// Token: 0x040396E3 RID: 235235
		[Token(Token = "0x40396E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x040396E4 RID: 235236
		[Token(Token = "0x40396E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_routeTarget;

		// Token: 0x040396E5 RID: 235237
		[Token(Token = "0x40396E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040396E6 RID: 235238
		[Token(Token = "0x40396E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040396E7 RID: 235239
		[Token(Token = "0x40396E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040396E8 RID: 235240
		[Token(Token = "0x40396E8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x040396E9 RID: 235241
		[Token(Token = "0x40396E9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResetEntryStateShowStatus;

		// Token: 0x040396EA RID: 235242
		[Token(Token = "0x40396EA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnGetInfoResponseBack;

		// Token: 0x040396EB RID: 235243
		[Token(Token = "0x40396EB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnGetInfoResponseForward;

		// Token: 0x040396EC RID: 235244
		[Token(Token = "0x40396EC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetCameraActive;

		// Token: 0x040396ED RID: 235245
		[Token(Token = "0x40396ED")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DisplayPage;

		// Token: 0x040396EE RID: 235246
		[Token(Token = "0x40396EE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryTriggerAVG;

		// Token: 0x040396EF RID: 235247
		[Token(Token = "0x40396EF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TriggerBGM;

		// Token: 0x040396F0 RID: 235248
		[Token(Token = "0x40396F0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x040396F1 RID: 235249
		[Token(Token = "0x40396F1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x040396F2 RID: 235250
		[Token(Token = "0x40396F2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SendGetInfoRequest;

		// Token: 0x040396F3 RID: 235251
		[Token(Token = "0x40396F3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetCameraActiveByStateTransition;

		// Token: 0x040396F4 RID: 235252
		[Token(Token = "0x40396F4")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040396F5 RID: 235253
		[Token(Token = "0x40396F5")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ProcessDelayedAlerts;

		// Token: 0x040396F6 RID: 235254
		[Token(Token = "0x40396F6")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ClearProcessDelayedAlertsCoroutine;

		// Token: 0x040396F7 RID: 235255
		[Token(Token = "0x40396F7")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__StartProcessDelayedAlertsCoroutine;

		// Token: 0x040396F8 RID: 235256
		[Token(Token = "0x40396F8")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ProcessDelayedAlertsCoroutine;

		// Token: 0x040396F9 RID: 235257
		[Token(Token = "0x40396F9")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F13 RID: 28435
		[Token(Token = "0x2006F13")]
		public class Params
		{
			// Token: 0x06028647 RID: 165447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028647")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x040396FA RID: 235258
			[Token(Token = "0x40396FA")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x02006F14 RID: 28436
		[Token(Token = "0x2006F14")]
		public enum CameraActiveSrc
		{
			// Token: 0x040396FC RID: 235260
			[Token(Token = "0x40396FC")]
			SRC_PAGE_SHOW,
			// Token: 0x040396FD RID: 235261
			[Token(Token = "0x40396FD")]
			SRC_STATE_TRANSITION
		}
	}
}
