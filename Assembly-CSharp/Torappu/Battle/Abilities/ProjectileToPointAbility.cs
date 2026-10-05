using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF4 RID: 10996
	[Token(Token = "0x2002AF4")]
	public class ProjectileToPointAbility : RangedAttack
	{
		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x060125CB RID: 75211 RVA: 0x00070710 File Offset: 0x0006E910
		[Token(Token = "0x17002844")]
		protected override bool emitToInputPosWhenTargetIsInvalid
		{
			[Token(Token = "0x60125CB")]
			[Address(RVA = "0xA742F0", Offset = "0xA72EF0", VA = "0x180A742F0", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060125CC RID: 75212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125CC")]
		[Address(RVA = "0xA73DF0", Offset = "0xA729F0", VA = "0x180A73DF0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060125CD RID: 75213 RVA: 0x00070728 File Offset: 0x0006E928
		[Token(Token = "0x60125CD")]
		[Address(RVA = "0xA73D30", Offset = "0xA72930", VA = "0x180A73D30", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x060125CE RID: 75214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125CE")]
		[Address(RVA = "0xA73FB0", Offset = "0xA72BB0", VA = "0x180A73FB0", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x060125CF RID: 75215 RVA: 0x00070740 File Offset: 0x0006E940
		[Token(Token = "0x60125CF")]
		[Address(RVA = "0xA74110", Offset = "0xA72D10", VA = "0x180A74110", Slot = "86")]
		protected override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x060125D0 RID: 75216 RVA: 0x00070758 File Offset: 0x0006E958
		[Token(Token = "0x60125D0")]
		[Address(RVA = "0xA73EF0", Offset = "0xA72AF0", VA = "0x180A73EF0", Slot = "70")]
		protected override Vector2 GetCastDirectlyMapPosition()
		{
			return default(Vector2);
		}

		// Token: 0x060125D1 RID: 75217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125D1")]
		[Address(RVA = "0xA74080", Offset = "0xA72C80", VA = "0x180A74080")]
		public void SetTargetPos(Vector2 pos)
		{
		}

		// Token: 0x060125D2 RID: 75218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125D2")]
		[Address(RVA = "0xA74240", Offset = "0xA72E40", VA = "0x180A74240")]
		public ProjectileToPointAbility()
		{
		}

		// Token: 0x060125D3 RID: 75219 RVA: 0x00070770 File Offset: 0x0006E970
		[Token(Token = "0x60125D3")]
		[Address(RVA = "0xA74100", Offset = "0xA72D00", VA = "0x180A74100")]
		private bool <>xLuaBaseProxy_get_emitToInputPosWhenTargetIsInvalid()
		{
			return default(bool);
		}

		// Token: 0x060125D4 RID: 75220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125D4")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060125D5 RID: 75221 RVA: 0x00070788 File Offset: 0x0006E988
		[Token(Token = "0x60125D5")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x060125D6 RID: 75222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125D6")]
		[Address(RVA = "0xA37180", Offset = "0xA35D80", VA = "0x180A37180")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x060125D7 RID: 75223 RVA: 0x000707A0 File Offset: 0x0006E9A0
		[Token(Token = "0x60125D7")]
		[Address(RVA = "0xA45000", Offset = "0xA43C00", VA = "0x180A45000")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x060125D8 RID: 75224 RVA: 0x000707B8 File Offset: 0x0006E9B8
		[Token(Token = "0x60125D8")]
		[Address(RVA = "0xA47C00", Offset = "0xA46800", VA = "0x180A47C00")]
		private Vector2 <>xLuaBaseProxy_GetCastDirectlyMapPosition()
		{
			return default(Vector2);
		}

		// Token: 0x04014C29 RID: 85033
		[Token(Token = "0x4014C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		protected Vector2 m_targetPos;

		// Token: 0x04014C2A RID: 85034
		[Token(Token = "0x4014C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_emitToInputPosWhenTargetIsInvalid;

		// Token: 0x04014C2B RID: 85035
		[Token(Token = "0x4014C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014C2C RID: 85036
		[Token(Token = "0x4014C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04014C2D RID: 85037
		[Token(Token = "0x4014C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014C2E RID: 85038
		[Token(Token = "0x4014C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x04014C2F RID: 85039
		[Token(Token = "0x4014C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCastDirectlyMapPosition;

		// Token: 0x04014C30 RID: 85040
		[Token(Token = "0x4014C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetTargetPos;

		// Token: 0x04014C31 RID: 85041
		[Token(Token = "0x4014C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
