using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002398 RID: 9112
	[Token(Token = "0x2002398")]
	[Obsolete("Use DynamicBuffTileFixed instead")]
	public class DynamicBuffTile : BuffTile
	{
		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x0600E714 RID: 59156 RVA: 0x000542A0 File Offset: 0x000524A0
		[Token(Token = "0x17001D03")]
		public virtual int modeIndex
		{
			[Token(Token = "0x600E714")]
			[Address(RVA = "0x5BA950", Offset = "0x5B9550", VA = "0x1805BA950", Slot = "48")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x0600E715 RID: 59157 RVA: 0x000542B8 File Offset: 0x000524B8
		[Token(Token = "0x17001D04")]
		protected override bool traceBuffUids
		{
			[Token(Token = "0x600E715")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x0600E716 RID: 59158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D05")]
		private BuffData[] dynamicBuffs
		{
			[Token(Token = "0x600E716")]
			[Address(RVA = "0x5C0F00", Offset = "0x5BFB00", VA = "0x1805C0F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x0600E717 RID: 59159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D06")]
		private string[] dynamicBuffEffects
		{
			[Token(Token = "0x600E717")]
			[Address(RVA = "0x5C0E70", Offset = "0x5BFA70", VA = "0x1805C0E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E718 RID: 59160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E718")]
		[Address(RVA = "0x5BFA40", Offset = "0x5BE640", VA = "0x1805BFA40", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E719 RID: 59161 RVA: 0x000542D0 File Offset: 0x000524D0
		[Token(Token = "0x600E719")]
		[Address(RVA = "0x5C0450", Offset = "0x5BF050", VA = "0x1805C0450")]
		public bool SwitchMode(Func<int, int> modifyIndexFunc)
		{
			return default(bool);
		}

		// Token: 0x0600E71A RID: 59162 RVA: 0x000542E8 File Offset: 0x000524E8
		[Token(Token = "0x600E71A")]
		[Address(RVA = "0x5C04C0", Offset = "0x5BF0C0", VA = "0x1805C04C0", Slot = "49")]
		public virtual bool SwitchMode(int modeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600E71B RID: 59163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E71B")]
		[Address(RVA = "0x5C03A0", Offset = "0x5BEFA0", VA = "0x1805C03A0")]
		public void ResetMode()
		{
		}

		// Token: 0x0600E71C RID: 59164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E71C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "50")]
		protected virtual void OnSwitchMode(int mode)
		{
		}

		// Token: 0x0600E71D RID: 59165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E71D")]
		[Address(RVA = "0x5C0980", Offset = "0x5BF580", VA = "0x1805C0980", Slot = "51")]
		protected virtual void _UpdateEffects()
		{
		}

		// Token: 0x0600E71E RID: 59166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E71E")]
		[Address(RVA = "0x5C0890", Offset = "0x5BF490", VA = "0x1805C0890")]
		private void _ClearEffects()
		{
		}

		// Token: 0x0600E71F RID: 59167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E71F")]
		[Address(RVA = "0x5C07B0", Offset = "0x5BF3B0", VA = "0x1805C07B0")]
		protected void _ApplyDynamicBuffs(Entity target, List<uint> buffUids)
		{
		}

		// Token: 0x0600E720 RID: 59168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E720")]
		[Address(RVA = "0x5BFCE0", Offset = "0x5BE8E0", VA = "0x1805BFCE0", Slot = "26")]
		protected override void OnCharacterEnter(Character newChar, Character oldChar)
		{
		}

		// Token: 0x0600E721 RID: 59169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E721")]
		[Address(RVA = "0x5BFE20", Offset = "0x5BEA20", VA = "0x1805BFE20", Slot = "27")]
		protected override void OnCharacterLeave(Character character)
		{
		}

		// Token: 0x0600E722 RID: 59170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E722")]
		[Address(RVA = "0x5C0200", Offset = "0x5BEE00", VA = "0x1805C0200", Slot = "28")]
		public override void OnRallyPointLikeReborn(Unit unit)
		{
		}

		// Token: 0x0600E723 RID: 59171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E723")]
		[Address(RVA = "0x5C0180", Offset = "0x5BED80", VA = "0x1805C0180", Slot = "29")]
		public override void OnRallyPointLikeFakeDeath(Unit unit)
		{
		}

		// Token: 0x0600E724 RID: 59172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E724")]
		[Address(RVA = "0x5BFF20", Offset = "0x5BEB20", VA = "0x1805BFF20", Slot = "31")]
		protected override void OnEnemyEnter(Enemy enemy)
		{
		}

		// Token: 0x0600E725 RID: 59173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E725")]
		[Address(RVA = "0x5C0090", Offset = "0x5BEC90", VA = "0x1805C0090", Slot = "32")]
		protected override void OnEnemyLeave(Enemy enemy)
		{
		}

		// Token: 0x0600E726 RID: 59174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E726")]
		[Address(RVA = "0x5BF920", Offset = "0x5BE520", VA = "0x1805BF920", Slot = "43")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600E727 RID: 59175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E727")]
		[Address(RVA = "0x5C0300", Offset = "0x5BEF00", VA = "0x1805C0300", Slot = "44")]
		protected override void PreloadBuffAssets()
		{
		}

		// Token: 0x0600E728 RID: 59176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E728")]
		[Address(RVA = "0x5C0C50", Offset = "0x5BF850", VA = "0x1805C0C50")]
		public DynamicBuffTile()
		{
		}

		// Token: 0x0400FE90 RID: 65168
		[Token(Token = "0x400FE90")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		protected int _modeIndex;

		// Token: 0x0400FE91 RID: 65169
		[Token(Token = "0x400FE91")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private DynamicBuffTile.TileBuffsAndEffectsPair[] _dynamicBuffs;

		// Token: 0x0400FE92 RID: 65170
		[Token(Token = "0x400FE92")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private bool _dontClearEffectOnCharacterEnter;

		// Token: 0x0400FE93 RID: 65171
		[Token(Token = "0x400FE93")]
		[FieldOffset(Offset = "0x1C1")]
		[SerializeField]
		protected bool _applyToEnemyWhenSwitchMode;

		// Token: 0x0400FE94 RID: 65172
		[Token(Token = "0x400FE94")]
		[FieldOffset(Offset = "0x1C2")]
		[SerializeField]
		private bool _updateEffectOnCharacterLeave;

		// Token: 0x0400FE95 RID: 65173
		[Token(Token = "0x400FE95")]
		[FieldOffset(Offset = "0x1C8")]
		protected readonly List<uint> m_charDynamicBuffUids;

		// Token: 0x0400FE96 RID: 65174
		[Token(Token = "0x400FE96")]
		[FieldOffset(Offset = "0x1D0")]
		protected Dictionary<ObjectPtr<Entity>, List<uint>> m_enemyDynamicBuffUids;

		// Token: 0x0400FE97 RID: 65175
		[Token(Token = "0x400FE97")]
		[FieldOffset(Offset = "0x1D8")]
		private int m_cachedOriginMode;

		// Token: 0x0400FE98 RID: 65176
		[Token(Token = "0x400FE98")]
		[FieldOffset(Offset = "0x1E0")]
		protected readonly List<Effect> m_currentTileEffects;

		// Token: 0x02002399 RID: 9113
		[Token(Token = "0x2002399")]
		[Serializable]
		private struct TileBuffsAndEffectsPair
		{
			// Token: 0x0400FE99 RID: 65177
			[Token(Token = "0x400FE99")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public BuffData[] buffs;

			// Token: 0x0400FE9A RID: 65178
			[Token(Token = "0x400FE9A")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string[] effects;
		}
	}
}
