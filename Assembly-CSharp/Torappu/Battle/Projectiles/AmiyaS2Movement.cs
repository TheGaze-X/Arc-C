using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029CE RID: 10702
	[Token(Token = "0x20029CE")]
	public class AmiyaS2Movement : BasicMovement
	{
		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x06011BC7 RID: 72647 RVA: 0x0006CA68 File Offset: 0x0006AC68
		[Token(Token = "0x1700271F")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011BC7")]
			[Address(RVA = "0x995460", Offset = "0x994060", VA = "0x180995460", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011BC8 RID: 72648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BC8")]
		[Address(RVA = "0x994B10", Offset = "0x993710", VA = "0x180994B10", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011BC9 RID: 72649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BC9")]
		[Address(RVA = "0x995000", Offset = "0x993C00", VA = "0x180995000", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011BCA RID: 72650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BCA")]
		[Address(RVA = "0x995330", Offset = "0x993F30", VA = "0x180995330")]
		private void _UpdateBodyAnimation()
		{
		}

		// Token: 0x06011BCB RID: 72651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BCB")]
		[Address(RVA = "0x9953D0", Offset = "0x993FD0", VA = "0x1809953D0")]
		public AmiyaS2Movement()
		{
		}

		// Token: 0x06011BCF RID: 72655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BCF")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011BD0 RID: 72656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BD0")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013E41 RID: 81473
		[Token(Token = "0x4013E41")]
		private const float MIN_FULL_HEIGHT = 0f;

		// Token: 0x04013E42 RID: 81474
		[Token(Token = "0x4013E42")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Detail")]
		private float _startDistance;

		// Token: 0x04013E43 RID: 81475
		[Token(Token = "0x4013E43")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Group("Detail")]
		private float _zOffset;

		// Token: 0x04013E44 RID: 81476
		[Token(Token = "0x4013E44")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Detail")]
		private float _startDuration;

		// Token: 0x04013E45 RID: 81477
		[Token(Token = "0x4013E45")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Group("Detail")]
		private float _time;

		// Token: 0x04013E46 RID: 81478
		[Token(Token = "0x4013E46")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Detail")]
		private float _yAnimateOffset;

		// Token: 0x04013E47 RID: 81479
		[Token(Token = "0x4013E47")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[Group("Detail")]
		private float _yAnimateSpeed;

		// Token: 0x04013E48 RID: 81480
		[Token(Token = "0x4013E48")]
		[FieldOffset(Offset = "0xC0")]
		private float m_velocityN;

		// Token: 0x04013E49 RID: 81481
		[Token(Token = "0x4013E49")]
		[FieldOffset(Offset = "0xC4")]
		private float m_remainingTime;

		// Token: 0x04013E4A RID: 81482
		[Token(Token = "0x4013E4A")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_startPhaseFinished;

		// Token: 0x04013E4B RID: 81483
		[Token(Token = "0x4013E4B")]
		[FieldOffset(Offset = "0xCC")]
		private float m_sinOffset;

		// Token: 0x04013E4C RID: 81484
		[Token(Token = "0x4013E4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013E4D RID: 81485
		[Token(Token = "0x4013E4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E4E RID: 81486
		[Token(Token = "0x4013E4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013E4F RID: 81487
		[Token(Token = "0x4013E4F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateBodyAnimation;

		// Token: 0x04013E50 RID: 81488
		[Token(Token = "0x4013E50")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
