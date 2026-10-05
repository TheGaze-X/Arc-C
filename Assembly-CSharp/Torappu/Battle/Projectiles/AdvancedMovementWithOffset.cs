using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029CB RID: 10699
	[Token(Token = "0x20029CB")]
	public class AdvancedMovementWithOffset : AdvancedMovement
	{
		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x06011BAB RID: 72619 RVA: 0x0006C9C0 File Offset: 0x0006ABC0
		[Token(Token = "0x1700271B")]
		public bool isValid
		{
			[Token(Token = "0x6011BAB")]
			[Address(RVA = "0x9937C0", Offset = "0x9923C0", VA = "0x1809937C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x06011BAC RID: 72620 RVA: 0x0006C9D8 File Offset: 0x0006ABD8
		[Token(Token = "0x1700271C")]
		private Vector3 planeNormal
		{
			[Token(Token = "0x6011BAC")]
			[Address(RVA = "0x9938C0", Offset = "0x9924C0", VA = "0x1809938C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06011BAD RID: 72621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BAD")]
		[Address(RVA = "0x993270", Offset = "0x991E70", VA = "0x180993270", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011BAE RID: 72622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BAE")]
		[Address(RVA = "0x993460", Offset = "0x992060", VA = "0x180993460", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011BAF RID: 72623 RVA: 0x0006C9F0 File Offset: 0x0006ABF0
		[Token(Token = "0x6011BAF")]
		[Address(RVA = "0x993120", Offset = "0x991D20", VA = "0x180993120", Slot = "23")]
		protected override Vector3 GetTraceTargetMapPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06011BB0 RID: 72624 RVA: 0x0006CA08 File Offset: 0x0006AC08
		[Token(Token = "0x6011BB0")]
		[Address(RVA = "0x992C40", Offset = "0x991840", VA = "0x180992C40")]
		public bool GetPerpendicularInPlane(Vector3 direction, out Vector3 perpendicular)
		{
			return default(bool);
		}

		// Token: 0x06011BB1 RID: 72625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BB1")]
		[Address(RVA = "0x993740", Offset = "0x992340", VA = "0x180993740")]
		public AdvancedMovementWithOffset()
		{
		}

		// Token: 0x06011BB3 RID: 72627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BB3")]
		[Address(RVA = "0x9936C0", Offset = "0x9922C0", VA = "0x1809936C0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011BB4 RID: 72628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BB4")]
		[Address(RVA = "0x9936D0", Offset = "0x9922D0", VA = "0x1809936D0")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011BB5 RID: 72629 RVA: 0x0006CA20 File Offset: 0x0006AC20
		[Token(Token = "0x6011BB5")]
		[Address(RVA = "0x993690", Offset = "0x992290", VA = "0x180993690")]
		private Vector3 <>xLuaBaseProxy_GetTraceTargetMapPosition()
		{
			return default(Vector3);
		}

		// Token: 0x04013E21 RID: 81441
		[Token(Token = "0x4013E21")]
		[FieldOffset(Offset = "0x140")]
		private bool m_hasOffset;

		// Token: 0x04013E22 RID: 81442
		[Token(Token = "0x4013E22")]
		[FieldOffset(Offset = "0x144")]
		private float m_offset;

		// Token: 0x04013E23 RID: 81443
		[Token(Token = "0x4013E23")]
		[FieldOffset(Offset = "0x148")]
		private Vector3 m_offset3;

		// Token: 0x04013E24 RID: 81444
		[Token(Token = "0x4013E24")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 m_planeNormal;

		// Token: 0x04013E25 RID: 81445
		[Token(Token = "0x4013E25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x04013E26 RID: 81446
		[Token(Token = "0x4013E26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_planeNormal;

		// Token: 0x04013E27 RID: 81447
		[Token(Token = "0x4013E27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013E28 RID: 81448
		[Token(Token = "0x4013E28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E29 RID: 81449
		[Token(Token = "0x4013E29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTraceTargetMapPosition;

		// Token: 0x04013E2A RID: 81450
		[Token(Token = "0x4013E2A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetPerpendicularInPlane;

		// Token: 0x04013E2B RID: 81451
		[Token(Token = "0x4013E2B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
