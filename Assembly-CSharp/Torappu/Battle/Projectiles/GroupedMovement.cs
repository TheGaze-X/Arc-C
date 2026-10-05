using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029DA RID: 10714
	[Token(Token = "0x20029DA")]
	public class GroupedMovement : BasicMovement
	{
		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x06011C29 RID: 72745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700272E")]
		public Projectile.Behaviour curMovement
		{
			[Token(Token = "0x6011C29")]
			[Address(RVA = "0x99BF60", Offset = "0x99AB60", VA = "0x18099BF60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x06011C2A RID: 72746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700272F")]
		public BasicMovement curBasicMovement
		{
			[Token(Token = "0x6011C2A")]
			[Address(RVA = "0x99BE70", Offset = "0x99AA70", VA = "0x18099BE70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x06011C2B RID: 72747 RVA: 0x0006CC78 File Offset: 0x0006AE78
		[Token(Token = "0x17002730")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011C2B")]
			[Address(RVA = "0x99C040", Offset = "0x99AC40", VA = "0x18099C040", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011C2C RID: 72748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C2C")]
		[Address(RVA = "0x99B2A0", Offset = "0x999EA0", VA = "0x18099B2A0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011C2D RID: 72749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C2D")]
		[Address(RVA = "0x99B7B0", Offset = "0x99A3B0", VA = "0x18099B7B0", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011C2E RID: 72750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C2E")]
		[Address(RVA = "0x99B750", Offset = "0x99A350", VA = "0x18099B750", Slot = "20")]
		protected override void OnInitPose()
		{
		}

		// Token: 0x06011C2F RID: 72751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C2F")]
		[Address(RVA = "0x99B240", Offset = "0x999E40", VA = "0x18099B240", Slot = "21")]
		protected override void DealReached()
		{
		}

		// Token: 0x06011C30 RID: 72752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C30")]
		[Address(RVA = "0x99B830", Offset = "0x99A430", VA = "0x18099B830", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011C31 RID: 72753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C31")]
		[Address(RVA = "0x99BA70", Offset = "0x99A670", VA = "0x18099BA70", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011C32 RID: 72754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C32")]
		[Address(RVA = "0x99BB60", Offset = "0x99A760", VA = "0x18099BB60", Slot = "24")]
		public override void SwitchTraceTarget(ILocatable newTarget)
		{
		}

		// Token: 0x06011C33 RID: 72755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C33")]
		[Address(RVA = "0x99B6A0", Offset = "0x99A2A0", VA = "0x18099B6A0", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011C34 RID: 72756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C34")]
		[Address(RVA = "0x99B990", Offset = "0x99A590", VA = "0x18099B990", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011C35 RID: 72757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C35")]
		[Address(RVA = "0x99BC70", Offset = "0x99A870", VA = "0x18099BC70")]
		private void _CalcMovementAdjustable()
		{
		}

		// Token: 0x06011C36 RID: 72758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C36")]
		[Address(RVA = "0x99BDB0", Offset = "0x99A9B0", VA = "0x18099BDB0")]
		public GroupedMovement()
		{
		}

		// Token: 0x06011C37 RID: 72759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C37")]
		[Address(RVA = "0x97EC30", Offset = "0x97D830", VA = "0x18097EC30")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011C38 RID: 72760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C38")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011C39 RID: 72761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C39")]
		[Address(RVA = "0x998A00", Offset = "0x997600", VA = "0x180998A00")]
		private void <>xLuaBaseProxy_OnInitPose()
		{
		}

		// Token: 0x06011C3A RID: 72762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C3A")]
		[Address(RVA = "0x998210", Offset = "0x996E10", VA = "0x180998210")]
		private void <>xLuaBaseProxy_DealReached()
		{
		}

		// Token: 0x06011C3B RID: 72763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C3B")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011C3C RID: 72764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C3C")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011C3D RID: 72765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C3D")]
		[Address(RVA = "0x99BC60", Offset = "0x99A860", VA = "0x18099BC60")]
		private void <>xLuaBaseProxy_SwitchTraceTarget(ILocatable P0)
		{
		}

		// Token: 0x06011C3E RID: 72766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C3E")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x06011C3F RID: 72767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C3F")]
		[Address(RVA = "0x9973C0", Offset = "0x995FC0", VA = "0x1809973C0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013ED6 RID: 81622
		[Token(Token = "0x4013ED6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<BasicMovement> _movements;

		// Token: 0x04013ED7 RID: 81623
		[Token(Token = "0x4013ED7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private MovementSwitchController _controller;

		// Token: 0x04013ED8 RID: 81624
		[Token(Token = "0x4013ED8")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_movementAdjustable;

		// Token: 0x04013ED9 RID: 81625
		[Token(Token = "0x4013ED9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curMovement;

		// Token: 0x04013EDA RID: 81626
		[Token(Token = "0x4013EDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_curBasicMovement;

		// Token: 0x04013EDB RID: 81627
		[Token(Token = "0x4013EDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013EDC RID: 81628
		[Token(Token = "0x4013EDC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013EDD RID: 81629
		[Token(Token = "0x4013EDD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013EDE RID: 81630
		[Token(Token = "0x4013EDE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInitPose;

		// Token: 0x04013EDF RID: 81631
		[Token(Token = "0x4013EDF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DealReached;

		// Token: 0x04013EE0 RID: 81632
		[Token(Token = "0x4013EE0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013EE1 RID: 81633
		[Token(Token = "0x4013EE1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013EE2 RID: 81634
		[Token(Token = "0x4013EE2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SwitchTraceTarget;

		// Token: 0x04013EE3 RID: 81635
		[Token(Token = "0x4013EE3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013EE4 RID: 81636
		[Token(Token = "0x4013EE4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013EE5 RID: 81637
		[Token(Token = "0x4013EE5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CalcMovementAdjustable;

		// Token: 0x04013EE6 RID: 81638
		[Token(Token = "0x4013EE6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
