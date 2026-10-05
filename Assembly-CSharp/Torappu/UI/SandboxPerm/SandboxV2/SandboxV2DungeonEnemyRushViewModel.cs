using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042DE RID: 17118
	[Token(Token = "0x20042DE")]
	public class SandboxV2DungeonEnemyRushViewModel : SandboxV2DungeonFloatViewModel
	{
		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x0601A541 RID: 107841 RVA: 0x000A1448 File Offset: 0x0009F648
		[Token(Token = "0x17003E71")]
		public bool completed
		{
			[Token(Token = "0x601A541")]
			[Address(RVA = "0x132C9A0", Offset = "0x132B5A0", VA = "0x18132C9A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x0601A542 RID: 107842 RVA: 0x000A1460 File Offset: 0x0009F660
		[Token(Token = "0x17003E72")]
		public float enemyRushRatio
		{
			[Token(Token = "0x601A542")]
			[Address(RVA = "0x132CA10", Offset = "0x132B610", VA = "0x18132CA10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601A543 RID: 107843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A543")]
		[Address(RVA = "0x132BFC0", Offset = "0x132ABC0", VA = "0x18132BFC0")]
		public void UpdateData(SandboxV2DungeonEnemyRushViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A544 RID: 107844 RVA: 0x000A1478 File Offset: 0x0009F678
		[Token(Token = "0x601A544")]
		[Address(RVA = "0x132BE20", Offset = "0x132AA20", VA = "0x18132BE20", Slot = "4")]
		public override int CompareDungeonFloat(SandboxV2DungeonFloatViewModel other)
		{
			return 0;
		}

		// Token: 0x0601A545 RID: 107845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A545")]
		[Address(RVA = "0x132C800", Offset = "0x132B400", VA = "0x18132C800")]
		public SandboxV2DungeonEnemyRushViewModel()
		{
		}

		// Token: 0x0601A546 RID: 107846 RVA: 0x000A1490 File Offset: 0x0009F690
		[Token(Token = "0x601A546")]
		[Address(RVA = "0x132BFB0", Offset = "0x132ABB0", VA = "0x18132BFB0")]
		private int <>xLuaBaseProxy_CompareDungeonFloat(SandboxV2DungeonFloatViewModel P0)
		{
			return 0;
		}

		// Token: 0x04021615 RID: 136725
		[Token(Token = "0x4021615")]
		[FieldOffset(Offset = "0x60")]
		public string enemyRushGroupKey;

		// Token: 0x04021616 RID: 136726
		[Token(Token = "0x4021616")]
		[FieldOffset(Offset = "0x68")]
		public ListDict<string, SandboxV2DropDetail> enemyRushDrop;

		// Token: 0x04021617 RID: 136727
		[Token(Token = "0x4021617")]
		[FieldOffset(Offset = "0x70")]
		public int totEnemyCount;

		// Token: 0x04021618 RID: 136728
		[Token(Token = "0x4021618")]
		[FieldOffset(Offset = "0x74")]
		public int currEnemyCount;

		// Token: 0x04021619 RID: 136729
		[Token(Token = "0x4021619")]
		[FieldOffset(Offset = "0x78")]
		public List<SandboxV2DungeonEnemyRushViewModel.Enemy> enemies;

		// Token: 0x0402161A RID: 136730
		[Token(Token = "0x402161A")]
		[FieldOffset(Offset = "0x80")]
		public List<SandboxV2DungeonEnemyRushViewModel.Boss> bosses;

		// Token: 0x0402161B RID: 136731
		[Token(Token = "0x402161B")]
		[FieldOffset(Offset = "0x88")]
		public SandboxV2EnemyRushType type;

		// Token: 0x0402161C RID: 136732
		[Token(Token = "0x402161C")]
		[FieldOffset(Offset = "0x8C")]
		public int typeSortId;

		// Token: 0x0402161D RID: 136733
		[Token(Token = "0x402161D")]
		[FieldOffset(Offset = "0x90")]
		public int remainDays;

		// Token: 0x0402161E RID: 136734
		[Token(Token = "0x402161E")]
		[FieldOffset(Offset = "0x94")]
		public int enemyState;

		// Token: 0x0402161F RID: 136735
		[Token(Token = "0x402161F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_completed;

		// Token: 0x04021620 RID: 136736
		[Token(Token = "0x4021620")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enemyRushRatio;

		// Token: 0x04021621 RID: 136737
		[Token(Token = "0x4021621")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04021622 RID: 136738
		[Token(Token = "0x4021622")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CompareDungeonFloat;

		// Token: 0x04021623 RID: 136739
		[Token(Token = "0x4021623")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042DF RID: 17119
		[Token(Token = "0x20042DF")]
		public struct UpdateParam
		{
			// Token: 0x04021624 RID: 136740
			[Token(Token = "0x4021624")]
			[FieldOffset(Offset = "0x0")]
			public string enemyRushId;

			// Token: 0x04021625 RID: 136741
			[Token(Token = "0x4021625")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2Data topicDetailData;

			// Token: 0x04021626 RID: 136742
			[Token(Token = "0x4021626")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.Dungeon playerDungeonData;

			// Token: 0x04021627 RID: 136743
			[Token(Token = "0x4021627")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.Dungeon.EnemyRush playerEnemyRushData;
		}

		// Token: 0x020042E0 RID: 17120
		[Token(Token = "0x20042E0")]
		public struct Enemy
		{
			// Token: 0x04021628 RID: 136744
			[Token(Token = "0x4021628")]
			[FieldOffset(Offset = "0x0")]
			public int enemyGroupIndex;

			// Token: 0x04021629 RID: 136745
			[Token(Token = "0x4021629")]
			[FieldOffset(Offset = "0x4")]
			public int curCount;

			// Token: 0x0402162A RID: 136746
			[Token(Token = "0x402162A")]
			[FieldOffset(Offset = "0x8")]
			public int totalCount;
		}

		// Token: 0x020042E1 RID: 17121
		[Token(Token = "0x20042E1")]
		public struct Boss
		{
			// Token: 0x0402162B RID: 136747
			[Token(Token = "0x402162B")]
			[FieldOffset(Offset = "0x0")]
			public string enemyId;

			// Token: 0x0402162C RID: 136748
			[Token(Token = "0x402162C")]
			[FieldOffset(Offset = "0x8")]
			public int hpRatio;

			// Token: 0x0402162D RID: 136749
			[Token(Token = "0x402162D")]
			[FieldOffset(Offset = "0xC")]
			public int modeIndex;
		}
	}
}
