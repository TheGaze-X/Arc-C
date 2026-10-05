using System;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029CF RID: 10703
	[Token(Token = "0x20029CF")]
	public class ArchookMovement : BasicMovement
	{
		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x06011BD1 RID: 72657 RVA: 0x0006CA80 File Offset: 0x0006AC80
		[Token(Token = "0x17002720")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011BD1")]
			[Address(RVA = "0x9965E0", Offset = "0x9951E0", VA = "0x1809965E0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011BD2 RID: 72658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BD2")]
		[Address(RVA = "0x995580", Offset = "0x994180", VA = "0x180995580", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011BD3 RID: 72659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BD3")]
		[Address(RVA = "0x9954C0", Offset = "0x9940C0", VA = "0x1809954C0", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011BD4 RID: 72660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BD4")]
		[Address(RVA = "0x995A00", Offset = "0x994600", VA = "0x180995A00", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011BD5 RID: 72661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BD5")]
		[Address(RVA = "0x9964F0", Offset = "0x9950F0", VA = "0x1809964F0")]
		private void _UpdateSpeed(float deltaTime)
		{
		}

		// Token: 0x06011BD6 RID: 72662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BD6")]
		[Address(RVA = "0x9960E0", Offset = "0x994CE0", VA = "0x1809960E0")]
		private void _ComeBack()
		{
		}

		// Token: 0x06011BD7 RID: 72663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BD7")]
		[Address(RVA = "0x996570", Offset = "0x995170", VA = "0x180996570")]
		public ArchookMovement()
		{
		}

		// Token: 0x06011BD8 RID: 72664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BD8")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011BD9 RID: 72665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BD9")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x06011BDA RID: 72666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BDA")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013E51 RID: 81489
		[Token(Token = "0x4013E51")]
		private const float FARTHEST_DISTANCE = 100f;

		// Token: 0x04013E52 RID: 81490
		[Token(Token = "0x4013E52")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _speed;

		// Token: 0x04013E53 RID: 81491
		[Token(Token = "0x4013E53")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _acceleration;

		// Token: 0x04013E54 RID: 81492
		[Token(Token = "0x4013E54")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _stayWhenReached;

		// Token: 0x04013E55 RID: 81493
		[Token(Token = "0x4013E55")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _needBack;

		// Token: 0x04013E56 RID: 81494
		[Token(Token = "0x4013E56")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _hitOffset;

		// Token: 0x04013E57 RID: 81495
		[Token(Token = "0x4013E57")]
		[FieldOffset(Offset = "0xB8")]
		private float m_speed;

		// Token: 0x04013E58 RID: 81496
		[Token(Token = "0x4013E58")]
		[FieldOffset(Offset = "0xBC")]
		private float m_offset;

		// Token: 0x04013E59 RID: 81497
		[Token(Token = "0x4013E59")]
		[FieldOffset(Offset = "0xC0")]
		private ArchookTraitAbility m_trait;

		// Token: 0x04013E5A RID: 81498
		[Token(Token = "0x4013E5A")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isBack;

		// Token: 0x04013E5B RID: 81499
		[Token(Token = "0x4013E5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013E5C RID: 81500
		[Token(Token = "0x4013E5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E5D RID: 81501
		[Token(Token = "0x4013E5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013E5E RID: 81502
		[Token(Token = "0x4013E5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013E5F RID: 81503
		[Token(Token = "0x4013E5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateSpeed;

		// Token: 0x04013E60 RID: 81504
		[Token(Token = "0x4013E60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ComeBack;

		// Token: 0x04013E61 RID: 81505
		[Token(Token = "0x4013E61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
