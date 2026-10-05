using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C21 RID: 11297
	[Token(Token = "0x2002C21")]
	public class ProjectileMoveScaleBehaviour : ProjectileAuraAbility.ProjectileAuraBehaviour
	{
		// Token: 0x06013141 RID: 78145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013141")]
		[Address(RVA = "0xB20980", Offset = "0xB1F580", VA = "0x180B20980", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013142 RID: 78146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013142")]
		[Address(RVA = "0xB20760", Offset = "0xB1F360", VA = "0x180B20760", Slot = "17")]
		public override void OnProjectileEnter(Projectile projectile)
		{
		}

		// Token: 0x06013143 RID: 78147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013143")]
		[Address(RVA = "0xB20870", Offset = "0xB1F470", VA = "0x180B20870", Slot = "18")]
		public override void OnProjectileExit(Projectile projectile)
		{
		}

		// Token: 0x06013144 RID: 78148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013144")]
		[Address(RVA = "0xB20A70", Offset = "0xB1F670", VA = "0x180B20A70")]
		public ProjectileMoveScaleBehaviour()
		{
		}

		// Token: 0x06013145 RID: 78149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013145")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013146 RID: 78150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013146")]
		[Address(RVA = "0xB1A990", Offset = "0xB19590", VA = "0x180B1A990")]
		private void <>xLuaBaseProxy_OnProjectileEnter(Projectile P0)
		{
		}

		// Token: 0x06013147 RID: 78151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013147")]
		[Address(RVA = "0xB1A9A0", Offset = "0xB195A0", VA = "0x180B1A9A0")]
		private void <>xLuaBaseProxy_OnProjectileExit(Projectile P0)
		{
		}

		// Token: 0x040158B2 RID: 88242
		[Token(Token = "0x40158B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _moveScale;

		// Token: 0x040158B3 RID: 88243
		[Token(Token = "0x40158B3")]
		[FieldOffset(Offset = "0x28")]
		private FP m_moveScale;

		// Token: 0x040158B4 RID: 88244
		[Token(Token = "0x40158B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040158B5 RID: 88245
		[Token(Token = "0x40158B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileEnter;

		// Token: 0x040158B6 RID: 88246
		[Token(Token = "0x40158B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileExit;

		// Token: 0x040158B7 RID: 88247
		[Token(Token = "0x40158B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
