using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BA1 RID: 11169
	[Token(Token = "0x2002BA1")]
	public class LegionModeAbility : EmptyAbility
	{
		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x06012D49 RID: 77129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002990")]
		public List<LegionModeAbility.BuffPair> buffPairs
		{
			[Token(Token = "0x6012D49")]
			[Address(RVA = "0xABE180", Offset = "0xABCD80", VA = "0x180ABE180")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x06012D4A RID: 77130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002991")]
		protected GameModeFactory.LegionGameMode.LegionModeSettings gameSettings
		{
			[Token(Token = "0x6012D4A")]
			[Address(RVA = "0xABE590", Offset = "0xABD190", VA = "0x180ABE590")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x06012D4B RID: 77131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002992")]
		protected GameModeFactory.LegionGameMode gameMode
		{
			[Token(Token = "0x6012D4B")]
			[Address(RVA = "0xABE400", Offset = "0xABD000", VA = "0x180ABE400")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012D4C RID: 77132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D4C")]
		[Address(RVA = "0xABDA40", Offset = "0xABC640", VA = "0x180ABDA40", Slot = "96")]
		protected virtual void UpdateBlackboard()
		{
		}

		// Token: 0x06012D4D RID: 77133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D4D")]
		[Address(RVA = "0xABD960", Offset = "0xABC560", VA = "0x180ABD960", Slot = "97")]
		public virtual void RefreshLegionBuff()
		{
		}

		// Token: 0x06012D4E RID: 77134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D4E")]
		[Address(RVA = "0xABDAC0", Offset = "0xABC6C0", VA = "0x180ABDAC0")]
		private void _RefreshBlackBoardWithRawMulti()
		{
		}

		// Token: 0x06012D4F RID: 77135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D4F")]
		[Address(RVA = "0xABE070", Offset = "0xABCC70", VA = "0x180ABE070")]
		public LegionModeAbility()
		{
		}

		// Token: 0x040153FB RID: 87035
		[Token(Token = "0x40153FB")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private List<LegionModeAbility.BuffPair> _buffPairs;

		// Token: 0x040153FC RID: 87036
		[Token(Token = "0x40153FC")]
		[FieldOffset(Offset = "0x118")]
		private List<LegionModeAbility.BuffPair> m_usedBuffPairs;

		// Token: 0x040153FD RID: 87037
		[Token(Token = "0x40153FD")]
		[FieldOffset(Offset = "0x120")]
		private GameModeFactory.LegionGameMode.LegionModeSettings m_gameSettings;

		// Token: 0x040153FE RID: 87038
		[Token(Token = "0x40153FE")]
		[FieldOffset(Offset = "0x128")]
		private GameModeFactory.LegionGameMode m_gameMode;

		// Token: 0x040153FF RID: 87039
		[Token(Token = "0x40153FF")]
		[FieldOffset(Offset = "0x0")]
		private static string RAW_MULTI_ATTRIBUTE_SUFFIX;

		// Token: 0x04015400 RID: 87040
		[Token(Token = "0x4015400")]
		[FieldOffset(Offset = "0x130")]
		private Blackboard m_rawMultiBlackboard;

		// Token: 0x04015401 RID: 87041
		[Token(Token = "0x4015401")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_buffPairs;

		// Token: 0x04015402 RID: 87042
		[Token(Token = "0x4015402")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gameSettings;

		// Token: 0x04015403 RID: 87043
		[Token(Token = "0x4015403")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x04015404 RID: 87044
		[Token(Token = "0x4015404")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateBlackboard;

		// Token: 0x04015405 RID: 87045
		[Token(Token = "0x4015405")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshLegionBuff;

		// Token: 0x04015406 RID: 87046
		[Token(Token = "0x4015406")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshBlackBoardWithRawMulti;

		// Token: 0x04015407 RID: 87047
		[Token(Token = "0x4015407")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BA2 RID: 11170
		[Token(Token = "0x2002BA2")]
		[Serializable]
		public class BuffPair
		{
			// Token: 0x17002993 RID: 10643
			// (get) Token: 0x06012D51 RID: 77137 RVA: 0x000735F0 File Offset: 0x000717F0
			// (set) Token: 0x06012D52 RID: 77138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002993")]
			public int level
			{
				[Token(Token = "0x6012D51")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6012D52")]
				[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06012D53 RID: 77139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012D53")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuffPair()
			{
			}

			// Token: 0x04015408 RID: 87048
			[Token(Token = "0x4015408")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x04015409 RID: 87049
			[Token(Token = "0x4015409")]
			[FieldOffset(Offset = "0x18")]
			public ProfessionCategory professionKey;

			// Token: 0x0401540A RID: 87050
			[Token(Token = "0x401540A")]
			[FieldOffset(Offset = "0x1C")]
			public int part;

			// Token: 0x0401540B RID: 87051
			[Token(Token = "0x401540B")]
			[FieldOffset(Offset = "0x20")]
			public BuffData[] buffs;
		}
	}
}
