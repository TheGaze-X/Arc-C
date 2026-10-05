using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029DC RID: 10716
	[Token(Token = "0x20029DC")]
	public class HoveringInPlaceMovement : BasicMovement
	{
		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x06011C4C RID: 72780 RVA: 0x0006CD08 File Offset: 0x0006AF08
		[Token(Token = "0x17002732")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011C4C")]
			[Address(RVA = "0x99D5A0", Offset = "0x99C1A0", VA = "0x18099D5A0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011C4D RID: 72781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C4D")]
		[Address(RVA = "0x99CE80", Offset = "0x99BA80", VA = "0x18099CE80", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011C4E RID: 72782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C4E")]
		[Address(RVA = "0x99CFE0", Offset = "0x99BBE0", VA = "0x18099CFE0", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011C4F RID: 72783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C4F")]
		[Address(RVA = "0x99D4D0", Offset = "0x99C0D0", VA = "0x18099D4D0")]
		public void SetInitState()
		{
		}

		// Token: 0x06011C50 RID: 72784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C50")]
		[Address(RVA = "0x99D530", Offset = "0x99C130", VA = "0x18099D530")]
		public HoveringInPlaceMovement()
		{
		}

		// Token: 0x06011C51 RID: 72785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C51")]
		[Address(RVA = "0x97EC30", Offset = "0x97D830", VA = "0x18097EC30")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011C52 RID: 72786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C52")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013EF8 RID: 81656
		[Token(Token = "0x4013EF8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _speed;

		// Token: 0x04013EF9 RID: 81657
		[Token(Token = "0x4013EF9")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _radius;

		// Token: 0x04013EFA RID: 81658
		[Token(Token = "0x4013EFA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _initKeepLastDirection;

		// Token: 0x04013EFB RID: 81659
		[Token(Token = "0x4013EFB")]
		private const float PI = 3.1415927f;

		// Token: 0x04013EFC RID: 81660
		[Token(Token = "0x4013EFC")]
		[FieldOffset(Offset = "0xB4")]
		private float m_moveSpeed;

		// Token: 0x04013EFD RID: 81661
		[Token(Token = "0x4013EFD")]
		[FieldOffset(Offset = "0xB8")]
		private float m_angularSpeed;

		// Token: 0x04013EFE RID: 81662
		[Token(Token = "0x4013EFE")]
		[FieldOffset(Offset = "0xBC")]
		private float m_radius;

		// Token: 0x04013EFF RID: 81663
		[Token(Token = "0x4013EFF")]
		[FieldOffset(Offset = "0xC0")]
		private float m_angleCircle;

		// Token: 0x04013F00 RID: 81664
		[Token(Token = "0x4013F00")]
		[FieldOffset(Offset = "0xC4")]
		private float m_angleSemiCircle;

		// Token: 0x04013F01 RID: 81665
		[Token(Token = "0x4013F01")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 m_initPosition;

		// Token: 0x04013F02 RID: 81666
		[Token(Token = "0x4013F02")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 m_circleCenter;

		// Token: 0x04013F03 RID: 81667
		[Token(Token = "0x4013F03")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 m_semicircleCenter;

		// Token: 0x04013F04 RID: 81668
		[Token(Token = "0x4013F04")]
		[FieldOffset(Offset = "0xEC")]
		private Vector3 m_previousPosition;

		// Token: 0x04013F05 RID: 81669
		[Token(Token = "0x4013F05")]
		[FieldOffset(Offset = "0xF8")]
		private Vector3 m_currentPosition;

		// Token: 0x04013F06 RID: 81670
		[Token(Token = "0x4013F06")]
		[FieldOffset(Offset = "0x104")]
		private bool m_inited;

		// Token: 0x04013F07 RID: 81671
		[Token(Token = "0x4013F07")]
		[FieldOffset(Offset = "0x108")]
		private HoveringInPlaceMovement.HoveringStage m_hoveringStage;

		// Token: 0x04013F08 RID: 81672
		[Token(Token = "0x4013F08")]
		[FieldOffset(Offset = "0x10C")]
		private float m_semicircleStageTime;

		// Token: 0x04013F09 RID: 81673
		[Token(Token = "0x4013F09")]
		[FieldOffset(Offset = "0x110")]
		private float m_curSpendTime;

		// Token: 0x04013F0A RID: 81674
		[Token(Token = "0x4013F0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013F0B RID: 81675
		[Token(Token = "0x4013F0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013F0C RID: 81676
		[Token(Token = "0x4013F0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013F0D RID: 81677
		[Token(Token = "0x4013F0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetInitState;

		// Token: 0x04013F0E RID: 81678
		[Token(Token = "0x4013F0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029DD RID: 10717
		[Token(Token = "0x20029DD")]
		public enum HoveringStage
		{
			// Token: 0x04013F10 RID: 81680
			[Token(Token = "0x4013F10")]
			SEMICIRCLE,
			// Token: 0x04013F11 RID: 81681
			[Token(Token = "0x4013F11")]
			CIRCLE
		}
	}
}
