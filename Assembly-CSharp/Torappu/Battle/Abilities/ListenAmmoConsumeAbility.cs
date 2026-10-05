using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B44 RID: 11076
	[Token(Token = "0x2002B44")]
	public class ListenAmmoConsumeAbility : PassiveBuffAbility
	{
		// Token: 0x0601297F RID: 76159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601297F")]
		[Address(RVA = "0xA89970", Offset = "0xA88570", VA = "0x180A89970", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012980 RID: 76160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012980")]
		[Address(RVA = "0xA89B00", Offset = "0xA88700", VA = "0x180A89B00", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012981 RID: 76161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012981")]
		[Address(RVA = "0xA89C40", Offset = "0xA88840", VA = "0x180A89C40")]
		private void _OnConsumeAmmo(object args)
		{
		}

		// Token: 0x06012982 RID: 76162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012982")]
		[Address(RVA = "0xA8A040", Offset = "0xA88C40", VA = "0x180A8A040")]
		public ListenAmmoConsumeAbility()
		{
		}

		// Token: 0x06012983 RID: 76163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012983")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012984 RID: 76164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012984")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0401500B RID: 86027
		[Token(Token = "0x401500B")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected BuffData[] _buffsToOwner;

		// Token: 0x0401500C RID: 86028
		[Token(Token = "0x401500C")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		protected BuffData[] _buffsToConsumer;

		// Token: 0x0401500D RID: 86029
		[Token(Token = "0x401500D")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected TargetValidator _targetValidator;

		// Token: 0x0401500E RID: 86030
		[Token(Token = "0x401500E")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected string _keyToStoreAmmoConsumeCnt;

		// Token: 0x0401500F RID: 86031
		[Token(Token = "0x401500F")]
		[FieldOffset(Offset = "0x138")]
		private List<uint> m_ownerBuffs;

		// Token: 0x04015010 RID: 86032
		[Token(Token = "0x4015010")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04015011 RID: 86033
		[Token(Token = "0x4015011")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04015012 RID: 86034
		[Token(Token = "0x4015012")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnConsumeAmmo;

		// Token: 0x04015013 RID: 86035
		[Token(Token = "0x4015013")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
