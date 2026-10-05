using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F37 RID: 24375
	[Token(Token = "0x2005F37")]
	public class CharacterSlideControl : MonoBehaviour, IHotfixable, IWheelListener, IScrollHandler, IEventSystemHandler
	{
		// Token: 0x060234C5 RID: 144581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234C5")]
		[Address(RVA = "0x1DDE410", Offset = "0x1DDD010", VA = "0x181DDE410")]
		private void OnEnable()
		{
		}

		// Token: 0x060234C6 RID: 144582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234C6")]
		[Address(RVA = "0x1DDE5E0", Offset = "0x1DDD1E0", VA = "0x181DDE5E0")]
		public void OnMouseDown()
		{
		}

		// Token: 0x060234C7 RID: 144583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234C7")]
		[Address(RVA = "0x1DDE680", Offset = "0x1DDD280", VA = "0x181DDE680")]
		public void OnMouseUp()
		{
		}

		// Token: 0x060234C8 RID: 144584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60234C8")]
		[Address(RVA = "0x1DDEB80", Offset = "0x1DDD780", VA = "0x181DDEB80")]
		private IEnumerator TweenToTarget(float currentPos, int toTarget, float toPos)
		{
			return null;
		}

		// Token: 0x060234C9 RID: 144585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234C9")]
		[Address(RVA = "0x1DDEC70", Offset = "0x1DDD870", VA = "0x181DDEC70")]
		private void Update()
		{
		}

		// Token: 0x060234CA RID: 144586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234CA")]
		[Address(RVA = "0x1DDE270", Offset = "0x1DDCE70", VA = "0x181DDE270")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x060234CB RID: 144587 RVA: 0x000C07F8 File Offset: 0x000BE9F8
		[Token(Token = "0x60234CB")]
		[Address(RVA = "0x1DDE3B0", Offset = "0x1DDCFB0", VA = "0x181DDE3B0", Slot = "4")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x060234CC RID: 144588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234CC")]
		[Address(RVA = "0x1DDE960", Offset = "0x1DDD560", VA = "0x181DDE960")]
		public void OnPosChange(Vector2 delta)
		{
		}

		// Token: 0x060234CD RID: 144589 RVA: 0x000C0810 File Offset: 0x000BEA10
		[Token(Token = "0x60234CD")]
		[Address(RVA = "0x1DDEAF0", Offset = "0x1DDD6F0", VA = "0x181DDEAF0", Slot = "5")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x060234CE RID: 144590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234CE")]
		[Address(RVA = "0x1DDEA70", Offset = "0x1DDD670", VA = "0x181DDEA70", Slot = "6")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x060234CF RID: 144591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234CF")]
		[Address(RVA = "0x1DDED20", Offset = "0x1DDD920", VA = "0x181DDED20")]
		public CharacterSlideControl()
		{
		}

		// Token: 0x04030AF9 RID: 199417
		[Token(Token = "0x4030AF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIIntBoolEvent _onMove;

		// Token: 0x04030AFA RID: 199418
		[Token(Token = "0x4030AFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIIntEvent _onRelease;

		// Token: 0x04030AFB RID: 199419
		[Token(Token = "0x4030AFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIIntEvent _onEndDrag;

		// Token: 0x04030AFC RID: 199420
		[Token(Token = "0x4030AFC")]
		[FieldOffset(Offset = "0x30")]
		private int m_cache;

		// Token: 0x04030AFD RID: 199421
		[Token(Token = "0x4030AFD")]
		[FieldOffset(Offset = "0x34")]
		private bool m_OnDrag;

		// Token: 0x04030AFE RID: 199422
		[Token(Token = "0x4030AFE")]
		[FieldOffset(Offset = "0x35")]
		private bool m_OnTween;

		// Token: 0x04030AFF RID: 199423
		[Token(Token = "0x4030AFF")]
		[FieldOffset(Offset = "0x38")]
		private ScrollWheelHandler m_wheelHandler;

		// Token: 0x04030B00 RID: 199424
		[Token(Token = "0x4030B00")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine m_currentCor;

		// Token: 0x04030B01 RID: 199425
		[Token(Token = "0x4030B01")]
		[FieldOffset(Offset = "0x48")]
		private DateTime m_time;

		// Token: 0x04030B02 RID: 199426
		[Token(Token = "0x4030B02")]
		private const int MOUSEDELTAMAX = 500;

		// Token: 0x04030B03 RID: 199427
		[Token(Token = "0x4030B03")]
		private const float DELTATHEROTIME = 500f;

		// Token: 0x04030B04 RID: 199428
		[Token(Token = "0x4030B04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04030B05 RID: 199429
		[Token(Token = "0x4030B05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMouseDown;

		// Token: 0x04030B06 RID: 199430
		[Token(Token = "0x4030B06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMouseUp;

		// Token: 0x04030B07 RID: 199431
		[Token(Token = "0x4030B07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TweenToTarget;

		// Token: 0x04030B08 RID: 199432
		[Token(Token = "0x4030B08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04030B09 RID: 199433
		[Token(Token = "0x4030B09")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x04030B0A RID: 199434
		[Token(Token = "0x4030B0A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x04030B0B RID: 199435
		[Token(Token = "0x4030B0B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPosChange;

		// Token: 0x04030B0C RID: 199436
		[Token(Token = "0x4030B0C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x04030B0D RID: 199437
		[Token(Token = "0x4030B0D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x04030B0E RID: 199438
		[Token(Token = "0x4030B0E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
