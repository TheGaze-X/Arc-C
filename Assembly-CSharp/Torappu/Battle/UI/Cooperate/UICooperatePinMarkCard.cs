using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x0200341B RID: 13339
	[Token(Token = "0x200341B")]
	public class UICooperatePinMarkCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x06015509 RID: 87305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003280")]
		private GameModeFactory.CooperateGameMode mode
		{
			[Token(Token = "0x6015509")]
			[Address(RVA = "0xDDA500", Offset = "0xDD9100", VA = "0x180DDA500")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0601550A RID: 87306 RVA: 0x0008B3F8 File Offset: 0x000895F8
		// (set) Token: 0x0601550B RID: 87307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003281")]
		public int currentPointerId
		{
			[Token(Token = "0x601550A")]
			[Address(RVA = "0xDDA4A0", Offset = "0xDD90A0", VA = "0x180DDA4A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601550B")]
			[Address(RVA = "0xDDA610", Offset = "0xDD9210", VA = "0x180DDA610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601550C RID: 87308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601550C")]
		[Address(RVA = "0xDD8500", Offset = "0xDD7100", VA = "0x180DD8500")]
		public void OnDrag(BaseEventData eventData)
		{
		}

		// Token: 0x0601550D RID: 87309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601550D")]
		[Address(RVA = "0xDD8370", Offset = "0xDD6F70", VA = "0x180DD8370")]
		public void OnBeginDrag(BaseEventData eventData)
		{
		}

		// Token: 0x0601550E RID: 87310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601550E")]
		[Address(RVA = "0xDD8620", Offset = "0xDD7220", VA = "0x180DD8620")]
		public void OnEndDrag(BaseEventData eventData)
		{
		}

		// Token: 0x0601550F RID: 87311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601550F")]
		[Address(RVA = "0xDD7B60", Offset = "0xDD6760", VA = "0x180DD7B60")]
		public Transform CreateDummy()
		{
			return null;
		}

		// Token: 0x06015510 RID: 87312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015510")]
		[Address(RVA = "0xDD8160", Offset = "0xDD6D60", VA = "0x180DD8160")]
		public void DestroyDummy()
		{
		}

		// Token: 0x06015511 RID: 87313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015511")]
		[Address(RVA = "0xDD8860", Offset = "0xDD7460", VA = "0x180DD8860")]
		public void OnInit()
		{
		}

		// Token: 0x06015512 RID: 87314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015512")]
		[Address(RVA = "0xDD8760", Offset = "0xDD7360", VA = "0x180DD8760")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x06015513 RID: 87315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015513")]
		[Address(RVA = "0xDD9C80", Offset = "0xDD8880", VA = "0x180DD9C80")]
		private void _UpdateData(FP deltaTime)
		{
		}

		// Token: 0x06015514 RID: 87316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015514")]
		[Address(RVA = "0xDD9A40", Offset = "0xDD8640", VA = "0x180DD9A40")]
		public void _UpdateCooldown(FP deltaTime)
		{
		}

		// Token: 0x06015515 RID: 87317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015515")]
		[Address(RVA = "0xDD98D0", Offset = "0xDD84D0", VA = "0x180DD98D0")]
		private void _SetCooldownState(bool isInCooldown)
		{
		}

		// Token: 0x06015516 RID: 87318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015516")]
		[Address(RVA = "0xDD8CE0", Offset = "0xDD78E0", VA = "0x180DD8CE0")]
		public void OnReceivePinMark(object arg)
		{
		}

		// Token: 0x06015517 RID: 87319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015517")]
		[Address(RVA = "0xDD8BC0", Offset = "0xDD77C0", VA = "0x180DD8BC0")]
		public void OnReceiveBoatPinMark(object arg)
		{
		}

		// Token: 0x06015518 RID: 87320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015518")]
		[Address(RVA = "0xDD97C0", Offset = "0xDD83C0", VA = "0x180DD97C0")]
		private PeriodicTimer _NewPinMarkTimer()
		{
			return null;
		}

		// Token: 0x06015519 RID: 87321 RVA: 0x0008B410 File Offset: 0x00089610
		[Token(Token = "0x6015519")]
		[Address(RVA = "0xDD81E0", Offset = "0xDD6DE0", VA = "0x180DD81E0")]
		public bool OnBeforeCreateEffect()
		{
			return default(bool);
		}

		// Token: 0x0601551A RID: 87322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601551A")]
		[Address(RVA = "0xDD7BE0", Offset = "0xDD67E0", VA = "0x180DD7BE0")]
		public void CreateEffectMySide(Tile tile, int type)
		{
		}

		// Token: 0x0601551B RID: 87323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601551B")]
		[Address(RVA = "0xDD93B0", Offset = "0xDD7FB0", VA = "0x180DD93B0")]
		public void PlayCardTween()
		{
		}

		// Token: 0x0601551C RID: 87324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601551C")]
		[Address(RVA = "0xDD95B0", Offset = "0xDD81B0", VA = "0x180DD95B0")]
		public void SetTweenMark()
		{
		}

		// Token: 0x0601551D RID: 87325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601551D")]
		[Address(RVA = "0xDDA260", Offset = "0xDD8E60", VA = "0x180DDA260")]
		public UICooperatePinMarkCard()
		{
		}

		// Token: 0x040197BE RID: 104382
		[Token(Token = "0x40197BE")]
		private const string COOL_DOWN_FORMAT = "{0}s";

		// Token: 0x040197BF RID: 104383
		[Token(Token = "0x40197BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _dummy;

		// Token: 0x040197C0 RID: 104384
		[Token(Token = "0x40197C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040197C1 RID: 104385
		[Token(Token = "0x40197C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private NonDrawingGraphic _pinMarkCollider;

		// Token: 0x040197C2 RID: 104386
		[Token(Token = "0x40197C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICooperateFortressEdgePanel _fortressEdgePanel;

		// Token: 0x040197C3 RID: 104387
		[Token(Token = "0x40197C3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _buttonWrapper;

		// Token: 0x040197C4 RID: 104388
		[Token(Token = "0x40197C4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("CoolDown")]
		private RectTransform _inCooldown;

		// Token: 0x040197C5 RID: 104389
		[Token(Token = "0x40197C5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("CoolDown")]
		private Text _inCooldownText;

		// Token: 0x040197C6 RID: 104390
		[Token(Token = "0x40197C6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("CoolDown")]
		private RectTransform _inMark;

		// Token: 0x040197C7 RID: 104391
		[Token(Token = "0x40197C7")]
		[FieldOffset(Offset = "0x60")]
		private float m_interval;

		// Token: 0x040197C8 RID: 104392
		[Token(Token = "0x40197C8")]
		[FieldOffset(Offset = "0x64")]
		private int m_intervalTime;

		// Token: 0x040197C9 RID: 104393
		[Token(Token = "0x40197C9")]
		[FieldOffset(Offset = "0x68")]
		private float m_cooldown;

		// Token: 0x040197CA RID: 104394
		[Token(Token = "0x40197CA")]
		[FieldOffset(Offset = "0x70")]
		private PeriodicTimer m_intervalTimer;

		// Token: 0x040197CB RID: 104395
		[Token(Token = "0x40197CB")]
		[FieldOffset(Offset = "0x78")]
		private PeriodicTimer m_cooldownTimer;

		// Token: 0x040197CC RID: 104396
		[Token(Token = "0x40197CC")]
		[FieldOffset(Offset = "0x80")]
		private int m_curTime;

		// Token: 0x040197CD RID: 104397
		[Token(Token = "0x40197CD")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_animTween;

		// Token: 0x040197CE RID: 104398
		[Token(Token = "0x40197CE")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isCooldown;

		// Token: 0x040197CF RID: 104399
		[Token(Token = "0x40197CF")]
		[FieldOffset(Offset = "0x98")]
		private readonly List<PeriodicTimer> m_reusablePinTimerList;

		// Token: 0x040197D0 RID: 104400
		[Token(Token = "0x40197D0")]
		[FieldOffset(Offset = "0xA0")]
		private readonly List<PeriodicTimer> m_pinTimerList;

		// Token: 0x040197D1 RID: 104401
		[Token(Token = "0x40197D1")]
		[FieldOffset(Offset = "0xA8")]
		private readonly ListDict<GridPosition, Effect> m_pinEffectList;

		// Token: 0x040197D2 RID: 104402
		[Token(Token = "0x40197D2")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<PeriodicTimer> m_othersPinTimerList;

		// Token: 0x040197D3 RID: 104403
		[Token(Token = "0x40197D3")]
		[FieldOffset(Offset = "0xB8")]
		private readonly ListDict<GridPosition, Effect> m_othersPinEffectList;

		// Token: 0x040197D4 RID: 104404
		[Token(Token = "0x40197D4")]
		[FieldOffset(Offset = "0xC0")]
		private readonly ListDict<PeriodicTimer, int> m_othersPinOuter;

		// Token: 0x040197D5 RID: 104405
		[Token(Token = "0x40197D5")]
		[FieldOffset(Offset = "0xC8")]
		private readonly ListDict<PeriodicTimer, int> m_othersPinOuterEnemy;

		// Token: 0x040197D7 RID: 104407
		[Token(Token = "0x40197D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mode;

		// Token: 0x040197D8 RID: 104408
		[Token(Token = "0x40197D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentPointerId;

		// Token: 0x040197D9 RID: 104409
		[Token(Token = "0x40197D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_currentPointerId;

		// Token: 0x040197DA RID: 104410
		[Token(Token = "0x40197DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x040197DB RID: 104411
		[Token(Token = "0x40197DB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x040197DC RID: 104412
		[Token(Token = "0x40197DC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x040197DD RID: 104413
		[Token(Token = "0x40197DD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateDummy;

		// Token: 0x040197DE RID: 104414
		[Token(Token = "0x40197DE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DestroyDummy;

		// Token: 0x040197DF RID: 104415
		[Token(Token = "0x40197DF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040197E0 RID: 104416
		[Token(Token = "0x40197E0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x040197E1 RID: 104417
		[Token(Token = "0x40197E1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x040197E2 RID: 104418
		[Token(Token = "0x40197E2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateCooldown;

		// Token: 0x040197E3 RID: 104419
		[Token(Token = "0x40197E3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetCooldownState;

		// Token: 0x040197E4 RID: 104420
		[Token(Token = "0x40197E4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnReceivePinMark;

		// Token: 0x040197E5 RID: 104421
		[Token(Token = "0x40197E5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnReceiveBoatPinMark;

		// Token: 0x040197E6 RID: 104422
		[Token(Token = "0x40197E6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__NewPinMarkTimer;

		// Token: 0x040197E7 RID: 104423
		[Token(Token = "0x40197E7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBeforeCreateEffect;

		// Token: 0x040197E8 RID: 104424
		[Token(Token = "0x40197E8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CreateEffectMySide;

		// Token: 0x040197E9 RID: 104425
		[Token(Token = "0x40197E9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_PlayCardTween;

		// Token: 0x040197EA RID: 104426
		[Token(Token = "0x40197EA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetTweenMark;

		// Token: 0x040197EB RID: 104427
		[Token(Token = "0x40197EB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
