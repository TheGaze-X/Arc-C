using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029D3 RID: 10707
	[Token(Token = "0x20029D3")]
	public class BouncedWithParacurveMovement : BouncedAdvancedMovement
	{
		// Token: 0x06011BFE RID: 72702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BFE")]
		[Address(RVA = "0x998510", Offset = "0x997110", VA = "0x180998510", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011BFF RID: 72703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BFF")]
		[Address(RVA = "0x998490", Offset = "0x997090", VA = "0x180998490", Slot = "20")]
		protected override void OnInitPose()
		{
		}

		// Token: 0x06011C00 RID: 72704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C00")]
		[Address(RVA = "0x998810", Offset = "0x997410", VA = "0x180998810", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011C01 RID: 72705 RVA: 0x0006CB40 File Offset: 0x0006AD40
		[Token(Token = "0x6011C01")]
		[Address(RVA = "0x998A30", Offset = "0x997630", VA = "0x180998A30")]
		private Vector3 _CalculateNextPosition(float deltaTime, bool forceToResetDir)
		{
			return default(Vector3);
		}

		// Token: 0x06011C02 RID: 72706 RVA: 0x0006CB58 File Offset: 0x0006AD58
		[Token(Token = "0x6011C02")]
		[Address(RVA = "0x998360", Offset = "0x996F60", VA = "0x180998360", Slot = "22")]
		protected override bool DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011C03 RID: 72707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C03")]
		[Address(RVA = "0x998F70", Offset = "0x997B70", VA = "0x180998F70")]
		public BouncedWithParacurveMovement()
		{
		}

		// Token: 0x06011C04 RID: 72708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C04")]
		[Address(RVA = "0x998A10", Offset = "0x997610", VA = "0x180998A10")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011C05 RID: 72709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C05")]
		[Address(RVA = "0x998A00", Offset = "0x997600", VA = "0x180998A00")]
		private void <>xLuaBaseProxy_OnInitPose()
		{
		}

		// Token: 0x06011C06 RID: 72710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C06")]
		[Address(RVA = "0x998A20", Offset = "0x997620", VA = "0x180998A20")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011C07 RID: 72711 RVA: 0x0006CB70 File Offset: 0x0006AD70
		[Token(Token = "0x6011C07")]
		[Address(RVA = "0x9989F0", Offset = "0x9975F0", VA = "0x1809989F0")]
		private bool <>xLuaBaseProxy_DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x04013E94 RID: 81556
		[Token(Token = "0x4013E94")]
		private const float MIN_FULL_HEIGHT = 0f;

		// Token: 0x04013E95 RID: 81557
		[Token(Token = "0x4013E95")]
		private const float DIRECTION_ZERO_TOLERANCE = 0.01f;

		// Token: 0x04013E96 RID: 81558
		[Token(Token = "0x4013E96")]
		private const float TOO_CLOSE_THRESHOLD = 0.05f;

		// Token: 0x04013E97 RID: 81559
		[Token(Token = "0x4013E97")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private float _raiseHeight;

		// Token: 0x04013E98 RID: 81560
		[Token(Token = "0x4013E98")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private bool _fixBaseOnTick;

		// Token: 0x04013E99 RID: 81561
		[Token(Token = "0x4013E99")]
		[FieldOffset(Offset = "0x158")]
		private float m_gravity;

		// Token: 0x04013E9A RID: 81562
		[Token(Token = "0x4013E9A")]
		[FieldOffset(Offset = "0x15C")]
		private float m_velocityN;

		// Token: 0x04013E9B RID: 81563
		[Token(Token = "0x4013E9B")]
		[FieldOffset(Offset = "0x160")]
		private bool m_reachedTop;

		// Token: 0x04013E9C RID: 81564
		[Token(Token = "0x4013E9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E9D RID: 81565
		[Token(Token = "0x4013E9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInitPose;

		// Token: 0x04013E9E RID: 81566
		[Token(Token = "0x4013E9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013E9F RID: 81567
		[Token(Token = "0x4013E9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalculateNextPosition;

		// Token: 0x04013EA0 RID: 81568
		[Token(Token = "0x4013EA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoCheckReachedInternal;

		// Token: 0x04013EA1 RID: 81569
		[Token(Token = "0x4013EA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
