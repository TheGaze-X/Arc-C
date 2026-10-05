using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AB0 RID: 10928
	[Token(Token = "0x2002AB0")]
	public class LrwzrdRangedAttack : RangedAttack
	{
		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x060122C9 RID: 74441 RVA: 0x0006F600 File Offset: 0x0006D800
		[Token(Token = "0x170027E2")]
		public bool hasExtraAction
		{
			[Token(Token = "0x60122C9")]
			[Address(RVA = "0xA3E6D0", Offset = "0xA3D2D0", VA = "0x180A3E6D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060122CA RID: 74442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122CA")]
		[Address(RVA = "0xA3DFE0", Offset = "0xA3CBE0", VA = "0x180A3DFE0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060122CB RID: 74443 RVA: 0x0006F618 File Offset: 0x0006D818
		[Token(Token = "0x60122CB")]
		[Address(RVA = "0xA3D820", Offset = "0xA3C420", VA = "0x180A3D820", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x060122CC RID: 74444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122CC")]
		[Address(RVA = "0xA3E1A0", Offset = "0xA3CDA0", VA = "0x180A3E1A0", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x060122CD RID: 74445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122CD")]
		[Address(RVA = "0xA3E370", Offset = "0xA3CF70", VA = "0x180A3E370")]
		private void _CreateProjectile(string projectileKey, FixedPosition start, FixedPosition target)
		{
		}

		// Token: 0x060122CE RID: 74446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122CE")]
		[Address(RVA = "0xA3E100", Offset = "0xA3CD00", VA = "0x180A3E100", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x060122CF RID: 74447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122CF")]
		[Address(RVA = "0xA3E620", Offset = "0xA3D220", VA = "0x180A3E620")]
		public LrwzrdRangedAttack()
		{
		}

		// Token: 0x060122D0 RID: 74448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122D0")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060122D1 RID: 74449 RVA: 0x0006F630 File Offset: 0x0006D830
		[Token(Token = "0x60122D1")]
		[Address(RVA = "0xA39D20", Offset = "0xA38920", VA = "0x180A39D20")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x060122D2 RID: 74450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122D2")]
		[Address(RVA = "0xA37180", Offset = "0xA35D80", VA = "0x180A37180")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x060122D3 RID: 74451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122D3")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x040148F4 RID: 84212
		[Token(Token = "0x40148F4")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		private string _rightProjectile;

		// Token: 0x040148F5 RID: 84213
		[Token(Token = "0x40148F5")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		private string _leftProjectile;

		// Token: 0x040148F6 RID: 84214
		[Token(Token = "0x40148F6")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		private string _upProjectile;

		// Token: 0x040148F7 RID: 84215
		[Token(Token = "0x40148F7")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		private string _downProjectile;

		// Token: 0x040148F8 RID: 84216
		[Token(Token = "0x40148F8")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		private bool _useOwnerDirection;

		// Token: 0x040148F9 RID: 84217
		[Token(Token = "0x40148F9")]
		[FieldOffset(Offset = "0x289")]
		[SerializeField]
		private bool _hasExtraAction;

		// Token: 0x040148FA RID: 84218
		[Token(Token = "0x40148FA")]
		[FieldOffset(Offset = "0x290")]
		[SerializeField]
		[Inspect("hasExtraAction")]
		private ActionArray _extraActions;

		// Token: 0x040148FB RID: 84219
		[Token(Token = "0x40148FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasExtraAction;

		// Token: 0x040148FC RID: 84220
		[Token(Token = "0x40148FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040148FD RID: 84221
		[Token(Token = "0x40148FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x040148FE RID: 84222
		[Token(Token = "0x40148FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x040148FF RID: 84223
		[Token(Token = "0x40148FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateProjectile;

		// Token: 0x04014900 RID: 84224
		[Token(Token = "0x4014900")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04014901 RID: 84225
		[Token(Token = "0x4014901")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
