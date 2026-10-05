using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002569 RID: 9577
	[Token(Token = "0x2002569")]
	public class HunterBulletTrigger : SelectorTrigger
	{
		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x0600F728 RID: 63272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002069")]
		private Ability traitAbility
		{
			[Token(Token = "0x600F728")]
			[Address(RVA = "0x70EF20", Offset = "0x70DB20", VA = "0x18070EF20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F729 RID: 63273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F729")]
		[Address(RVA = "0x70EA80", Offset = "0x70D680", VA = "0x18070EA80", Slot = "12")]
		public override void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F72A RID: 63274 RVA: 0x0005C430 File Offset: 0x0005A630
		[Token(Token = "0x600F72A")]
		[Address(RVA = "0x70EB30", Offset = "0x70D730", VA = "0x18070EB30", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F72B RID: 63275 RVA: 0x0005C448 File Offset: 0x0005A648
		[Token(Token = "0x600F72B")]
		[Address(RVA = "0x70EBC0", Offset = "0x70D7C0", VA = "0x18070EBC0")]
		private bool _CheckValid()
		{
			return default(bool);
		}

		// Token: 0x0600F72C RID: 63276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F72C")]
		[Address(RVA = "0x70EEC0", Offset = "0x70DAC0", VA = "0x18070EEC0")]
		public HunterBulletTrigger()
		{
		}

		// Token: 0x0600F72D RID: 63277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F72D")]
		[Address(RVA = "0x6F1EB0", Offset = "0x6F0AB0", VA = "0x1806F1EB0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1)
		{
		}

		// Token: 0x0600F72E RID: 63278 RVA: 0x0005C460 File Offset: 0x0005A660
		[Token(Token = "0x600F72E")]
		[Address(RVA = "0x6F1EC0", Offset = "0x6F0AC0", VA = "0x1806F1EC0")]
		private bool <>xLuaBaseProxy_Search(bool P0)
		{
			return default(bool);
		}

		// Token: 0x0401128E RID: 70286
		[Token(Token = "0x401128E")]
		private const string RELOAD_FLAG = "RELOAD_FLAG";

		// Token: 0x0401128F RID: 70287
		[Token(Token = "0x401128F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<HunterBulletTrigger.HunterBulletType> _triggerValidType;

		// Token: 0x04011290 RID: 70288
		[Token(Token = "0x4011290")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _checkReloadFlag;

		// Token: 0x04011291 RID: 70289
		[Token(Token = "0x4011291")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private int _reloadFlag;

		// Token: 0x04011292 RID: 70290
		[Token(Token = "0x4011292")]
		[FieldOffset(Offset = "0x60")]
		private Ability m_traitAbility;

		// Token: 0x04011293 RID: 70291
		[Token(Token = "0x4011293")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_traitAbility;

		// Token: 0x04011294 RID: 70292
		[Token(Token = "0x4011294")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011295 RID: 70293
		[Token(Token = "0x4011295")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x04011296 RID: 70294
		[Token(Token = "0x4011296")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckValid;

		// Token: 0x04011297 RID: 70295
		[Token(Token = "0x4011297")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200256A RID: 9578
		[Token(Token = "0x200256A")]
		public enum HunterBulletType
		{
			// Token: 0x04011299 RID: 70297
			[Token(Token = "0x4011299")]
			FULL,
			// Token: 0x0401129A RID: 70298
			[Token(Token = "0x401129A")]
			HAS_BULLET_BUT_NOT_FULL,
			// Token: 0x0401129B RID: 70299
			[Token(Token = "0x401129B")]
			ZERO
		}
	}
}
