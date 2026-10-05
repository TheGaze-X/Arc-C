using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B58 RID: 11096
	[Token(Token = "0x2002B58")]
	public class BlockedToggleChecker : ToggleablePassiveBuffAbility.Checker, IBuffSource
	{
		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x060129FD RID: 76285 RVA: 0x00072180 File Offset: 0x00070380
		[Token(Token = "0x1700290A")]
		private bool hasBlockeeBuff
		{
			[Token(Token = "0x60129FD")]
			[Address(RVA = "0xA9EF00", Offset = "0xA9DB00", VA = "0x180A9EF00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060129FE RID: 76286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129FE")]
		[Address(RVA = "0xA9D670", Offset = "0xA9C270", VA = "0x180A9D670", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x060129FF RID: 76287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129FF")]
		[Address(RVA = "0xA9DB50", Offset = "0xA9C750", VA = "0x180A9DB50", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A00 RID: 76288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A00")]
		[Address(RVA = "0xA9D730", Offset = "0xA9C330", VA = "0x180A9D730", Slot = "7")]
		public override void OnAttached()
		{
		}

		// Token: 0x06012A01 RID: 76289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A01")]
		[Address(RVA = "0xA9D9B0", Offset = "0xA9C5B0", VA = "0x180A9D9B0", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x06012A02 RID: 76290 RVA: 0x00072198 File Offset: 0x00070398
		[Token(Token = "0x6012A02")]
		[Address(RVA = "0xA9D580", Offset = "0xA9C180", VA = "0x180A9D580", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A03 RID: 76291 RVA: 0x000721B0 File Offset: 0x000703B0
		[Token(Token = "0x6012A03")]
		[Address(RVA = "0xA9DC20", Offset = "0xA9C820", VA = "0x180A9DC20")]
		private bool _CheckCondition(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x06012A04 RID: 76292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A04")]
		[Address(RVA = "0xA9E010", Offset = "0xA9CC10", VA = "0x180A9E010")]
		private void _OnRallyPointBlockeeChanged(object arg)
		{
		}

		// Token: 0x06012A05 RID: 76293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A05")]
		[Address(RVA = "0xA9DFA0", Offset = "0xA9CBA0", VA = "0x180A9DFA0")]
		private void _OnBlockeeChanged(object arg)
		{
		}

		// Token: 0x06012A06 RID: 76294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A06")]
		[Address(RVA = "0xA9E1C0", Offset = "0xA9CDC0", VA = "0x180A9E1C0")]
		private void _UpdateBlockeeBuffs()
		{
		}

		// Token: 0x06012A07 RID: 76295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A07")]
		[Address(RVA = "0xA9E310", Offset = "0xA9CF10", VA = "0x180A9E310")]
		private void _UpdateCharacterBlockeeBuffs()
		{
		}

		// Token: 0x06012A08 RID: 76296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A08")]
		[Address(RVA = "0xA9E940", Offset = "0xA9D540", VA = "0x180A9E940")]
		private void _UpdateEnemyBlockeeBuffs()
		{
		}

		// Token: 0x06012A09 RID: 76297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A09")]
		[Address(RVA = "0xA9DDD0", Offset = "0xA9C9D0", VA = "0x180A9DDD0")]
		private void _ClearBlockeeBuffs()
		{
		}

		// Token: 0x06012A0A RID: 76298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A0A")]
		[Address(RVA = "0xA9D5E0", Offset = "0xA9C1E0", VA = "0x180A9D5E0", Slot = "10")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012A0B RID: 76299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A0B")]
		[Address(RVA = "0xA9EE30", Offset = "0xA9DA30", VA = "0x180A9EE30")]
		public BlockedToggleChecker()
		{
		}

		// Token: 0x06012A0C RID: 76300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A0C")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012A0D RID: 76301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A0D")]
		[Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012A0E RID: 76302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A0E")]
		[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x040150BF RID: 86207
		[Token(Token = "0x40150BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _blockMinCnt;

		// Token: 0x040150C0 RID: 86208
		[Token(Token = "0x40150C0")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _blockMaxCnt;

		// Token: 0x040150C1 RID: 86209
		[Token(Token = "0x40150C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useBlockAsMin;

		// Token: 0x040150C2 RID: 86210
		[Token(Token = "0x40150C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuffData[] _buffsToBlockee;

		// Token: 0x040150C3 RID: 86211
		[Token(Token = "0x40150C3")]
		[FieldOffset(Offset = "0x38")]
		private int m_blockMaxCnt;

		// Token: 0x040150C4 RID: 86212
		[Token(Token = "0x40150C4")]
		[FieldOffset(Offset = "0x3C")]
		private int m_blockMinCnt;

		// Token: 0x040150C5 RID: 86213
		[Token(Token = "0x40150C5")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<ObjectPtr<Entity>, uint[]> m_blockeeBuffList;

		// Token: 0x040150C6 RID: 86214
		[Token(Token = "0x40150C6")]
		[FieldOffset(Offset = "0x48")]
		private Unit m_unit;

		// Token: 0x040150C7 RID: 86215
		[Token(Token = "0x40150C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasBlockeeBuff;

		// Token: 0x040150C8 RID: 86216
		[Token(Token = "0x40150C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040150C9 RID: 86217
		[Token(Token = "0x40150C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040150CA RID: 86218
		[Token(Token = "0x40150CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040150CB RID: 86219
		[Token(Token = "0x40150CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040150CC RID: 86220
		[Token(Token = "0x40150CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x040150CD RID: 86221
		[Token(Token = "0x40150CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x040150CE RID: 86222
		[Token(Token = "0x40150CE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnRallyPointBlockeeChanged;

		// Token: 0x040150CF RID: 86223
		[Token(Token = "0x40150CF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBlockeeChanged;

		// Token: 0x040150D0 RID: 86224
		[Token(Token = "0x40150D0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateBlockeeBuffs;

		// Token: 0x040150D1 RID: 86225
		[Token(Token = "0x40150D1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateCharacterBlockeeBuffs;

		// Token: 0x040150D2 RID: 86226
		[Token(Token = "0x40150D2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateEnemyBlockeeBuffs;

		// Token: 0x040150D3 RID: 86227
		[Token(Token = "0x40150D3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClearBlockeeBuffs;

		// Token: 0x040150D4 RID: 86228
		[Token(Token = "0x40150D4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040150D5 RID: 86229
		[Token(Token = "0x40150D5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
