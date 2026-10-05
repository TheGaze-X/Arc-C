using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200259F RID: 9631
	[Token(Token = "0x200259F")]
	public class BObjectFollowerEnemy : Enemy
	{
		// Token: 0x1700208A RID: 8330
		// (set) Token: 0x0600F83C RID: 63548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700208A")]
		public ObjectPtr<BObject> hostObject
		{
			[Token(Token = "0x600F83C")]
			[Address(RVA = "0x6F0340", Offset = "0x6EEF40", VA = "0x1806F0340")]
			set
			{
			}
		}

		// Token: 0x0600F83D RID: 63549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F83D")]
		[Address(RVA = "0x6EFFB0", Offset = "0x6EEBB0", VA = "0x1806EFFB0", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600F83E RID: 63550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F83E")]
		[Address(RVA = "0x6EFE50", Offset = "0x6EEA50", VA = "0x1806EFE50", Slot = "119")]
		protected override void OnFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600F83F RID: 63551 RVA: 0x0005CEE0 File Offset: 0x0005B0E0
		[Token(Token = "0x600F83F")]
		[Address(RVA = "0x6F0060", Offset = "0x6EEC60", VA = "0x1806F0060", Slot = "217")]
		protected override Vector2 _MoveByRoute(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600F840 RID: 63552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F840")]
		[Address(RVA = "0x6F02C0", Offset = "0x6EEEC0", VA = "0x1806F02C0")]
		public BObjectFollowerEnemy()
		{
		}

		// Token: 0x0600F841 RID: 63553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F841")]
		[Address(RVA = "0x6099C0", Offset = "0x6085C0", VA = "0x1806099C0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600F842 RID: 63554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F842")]
		[Address(RVA = "0x6F0040", Offset = "0x6EEC40", VA = "0x1806F0040")]
		private void <>xLuaBaseProxy_OnFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600F843 RID: 63555 RVA: 0x0005CEF8 File Offset: 0x0005B0F8
		[Token(Token = "0x600F843")]
		[Address(RVA = "0x6F0050", Offset = "0x6EEC50", VA = "0x1806F0050")]
		private Vector2 <>xLuaBaseProxy__MoveByRoute(float P0, out bool P1)
		{
			return default(Vector2);
		}

		// Token: 0x040113D9 RID: 70617
		[Token(Token = "0x40113D9")]
		[FieldOffset(Offset = "0x528")]
		[SerializeField]
		private BObjectFollowerEnemy.BObjectType _bObjectType;

		// Token: 0x040113DA RID: 70618
		[Token(Token = "0x40113DA")]
		[FieldOffset(Offset = "0x530")]
		private ObjectPtr<BObject> m_hostObjectPtr;

		// Token: 0x040113DB RID: 70619
		[Token(Token = "0x40113DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_hostObject;

		// Token: 0x040113DC RID: 70620
		[Token(Token = "0x40113DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x040113DD RID: 70621
		[Token(Token = "0x40113DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040113DE RID: 70622
		[Token(Token = "0x40113DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__MoveByRoute;

		// Token: 0x040113DF RID: 70623
		[Token(Token = "0x40113DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020025A0 RID: 9632
		[Token(Token = "0x20025A0")]
		public enum BObjectType
		{
			// Token: 0x040113E1 RID: 70625
			[Token(Token = "0x40113E1")]
			PROJECTILE,
			// Token: 0x040113E2 RID: 70626
			[Token(Token = "0x40113E2")]
			ENEMY
		}
	}
}
