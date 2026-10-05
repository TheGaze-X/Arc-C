using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.CharWord;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003395 RID: 13205
	[Token(Token = "0x2003395")]
	public class VoicePlayer : IBattleModule, IHotfixable
	{
		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x060150E5 RID: 86245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003206")]
		private VoicePlayer.DefaultGamePlugin plugin
		{
			[Token(Token = "0x60150E5")]
			[Address(RVA = "0xD81690", Offset = "0xD80290", VA = "0x180D81690")]
			get
			{
				return null;
			}
		}

		// Token: 0x060150E6 RID: 86246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150E6")]
		[Address(RVA = "0xD7EB20", Offset = "0xD7D720", VA = "0x180D7EB20", Slot = "4")]
		public void OnGameReset(BattleController controller)
		{
		}

		// Token: 0x060150E7 RID: 86247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150E7")]
		[Address(RVA = "0xD7EEC0", Offset = "0xD7DAC0", VA = "0x180D7EEC0", Slot = "7")]
		public void OnGameStart()
		{
		}

		// Token: 0x060150E8 RID: 86248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150E8")]
		[Address(RVA = "0xD7E800", Offset = "0xD7D400", VA = "0x180D7E800", Slot = "5")]
		public void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x060150E9 RID: 86249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150E9")]
		[Address(RVA = "0xD7EAB0", Offset = "0xD7D6B0", VA = "0x180D7EAB0", Slot = "6")]
		public void OnGameReady()
		{
		}

		// Token: 0x060150EA RID: 86250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150EA")]
		[Address(RVA = "0xD7EA30", Offset = "0xD7D630", VA = "0x180D7EA30", Slot = "8")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x060150EB RID: 86251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150EB")]
		[Address(RVA = "0xD7FA40", Offset = "0xD7E640", VA = "0x180D7FA40")]
		private void _OnPreviewCursorSpawn(object arg)
		{
		}

		// Token: 0x060150EC RID: 86252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150EC")]
		[Address(RVA = "0xD80590", Offset = "0xD7F190", VA = "0x180D80590")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x060150ED RID: 86253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150ED")]
		[Address(RVA = "0xD7FF30", Offset = "0xD7EB30", VA = "0x180D7FF30")]
		private void _OnSkillCasted(object arg)
		{
		}

		// Token: 0x060150EE RID: 86254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150EE")]
		[Address(RVA = "0xD802A0", Offset = "0xD7EEA0", VA = "0x180D802A0")]
		private void _OnTileClicked(object arg)
		{
		}

		// Token: 0x060150EF RID: 86255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150EF")]
		[Address(RVA = "0xD7F8A0", Offset = "0xD7E4A0", VA = "0x180D7F8A0")]
		private void _OnCharacterAtkOrCbt(object arg)
		{
		}

		// Token: 0x060150F0 RID: 86256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150F0")]
		[Address(RVA = "0xD7F740", Offset = "0xD7E340", VA = "0x180D7F740")]
		private void _OnActivateInternalHiddenCard(object arg)
		{
		}

		// Token: 0x060150F1 RID: 86257 RVA: 0x0008A300 File Offset: 0x00088500
		[Token(Token = "0x60150F1")]
		[Address(RVA = "0xD7F1F0", Offset = "0xD7DDF0", VA = "0x180D7F1F0")]
		private bool _CheckDisableBattleStartVoice()
		{
			return default(bool);
		}

		// Token: 0x060150F2 RID: 86258 RVA: 0x0008A318 File Offset: 0x00088518
		[Token(Token = "0x60150F2")]
		[Address(RVA = "0xD807B0", Offset = "0xD7F3B0", VA = "0x180D807B0")]
		private VoiceManager.PlayResult _PlayVoice(BattleVoiceOption.BattleVoiceType voiceType)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x060150F3 RID: 86259 RVA: 0x0008A330 File Offset: 0x00088530
		[Token(Token = "0x60150F3")]
		[Address(RVA = "0xD808F0", Offset = "0xD7F4F0", VA = "0x180D808F0")]
		private VoiceManager.PlayResult _PlayVoice(BattleVoiceOption.BattleVoiceType voiceType, VoiceQuery vqOrEmpty, MapLayer mapLayer)
		{
			return default(VoiceManager.PlayResult);
		}

		// Token: 0x060150F4 RID: 86260 RVA: 0x0008A348 File Offset: 0x00088548
		[Token(Token = "0x60150F4")]
		[Address(RVA = "0xD7F2E0", Offset = "0xD7DEE0", VA = "0x180D7F2E0")]
		private int _FindCardDataIndex(string charIdOrNull)
		{
			return 0;
		}

		// Token: 0x060150F5 RID: 86261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60150F5")]
		[Address(RVA = "0xD7F420", Offset = "0xD7E020", VA = "0x180D7F420")]
		private BattleCharacterData _FindCardData(string charIdOrNull)
		{
			return null;
		}

		// Token: 0x060150F6 RID: 86262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150F6")]
		[Address(RVA = "0xD81240", Offset = "0xD7FE40", VA = "0x180D81240")]
		private void _RefreshCardDataList()
		{
		}

		// Token: 0x060150F7 RID: 86263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60150F7")]
		[Address(RVA = "0xD7F4F0", Offset = "0xD7E0F0", VA = "0x180D7F4F0")]
		private List<VoiceQuery> _LoadRandomVoiceList()
		{
			return null;
		}

		// Token: 0x060150F8 RID: 86264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150F8")]
		[Address(RVA = "0xD7EF60", Offset = "0xD7DB60", VA = "0x180D7EF60")]
		private void _AttachPlugin()
		{
		}

		// Token: 0x060150F9 RID: 86265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150F9")]
		[Address(RVA = "0xD81510", Offset = "0xD80110", VA = "0x180D81510")]
		public VoicePlayer()
		{
		}

		// Token: 0x0401910C RID: 102668
		[Token(Token = "0x401910C")]
		private const int BATTLE_VOICE_TYPES_NUM = 8;

		// Token: 0x0401910D RID: 102669
		[Token(Token = "0x401910D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CharWordShowType[] SKILL_CHARWORD_TYPES;

		// Token: 0x0401910E RID: 102670
		[Token(Token = "0x401910E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BattleVoiceOption.BattleVoiceType[] VOICE_TYPES_TO_SHARE_CD_WITH_ALL_OTHERS;

		// Token: 0x0401910F RID: 102671
		[Token(Token = "0x401910F")]
		[FieldOffset(Offset = "0x10")]
		private BattleVoiceData m_data;

		// Token: 0x04019110 RID: 102672
		[Token(Token = "0x4019110")]
		[FieldOffset(Offset = "0x18")]
		private BattleVoiceOption[] m_options;

		// Token: 0x04019111 RID: 102673
		[Token(Token = "0x4019111")]
		[FieldOffset(Offset = "0x20")]
		private List<BattleCharacterData> m_cardDataList;

		// Token: 0x04019112 RID: 102674
		[Token(Token = "0x4019112")]
		[FieldOffset(Offset = "0x28")]
		private BattleCharacterData m_lastVocalCharData;

		// Token: 0x04019113 RID: 102675
		[Token(Token = "0x4019113")]
		[FieldOffset(Offset = "0x30")]
		private float[] m_nextPlayableTime;

		// Token: 0x04019114 RID: 102676
		[Token(Token = "0x4019114")]
		[FieldOffset(Offset = "0x38")]
		private BattleVoiceOption m_lastPlayVoice;

		// Token: 0x04019115 RID: 102677
		[Token(Token = "0x4019115")]
		[FieldOffset(Offset = "0x50")]
		private List<VoiceQuery> m_randomVoiceCache;

		// Token: 0x04019116 RID: 102678
		[Token(Token = "0x4019116")]
		[FieldOffset(Offset = "0x58")]
		private bool m_encounterFirstEnemyFlag;

		// Token: 0x04019117 RID: 102679
		[Token(Token = "0x4019117")]
		[FieldOffset(Offset = "0x59")]
		private bool m_playPlaceVoiceForPredefined;

		// Token: 0x04019118 RID: 102680
		[Token(Token = "0x4019118")]
		[FieldOffset(Offset = "0x60")]
		private VoicePlayer.DefaultGamePlugin m_plugin;

		// Token: 0x04019119 RID: 102681
		[Token(Token = "0x4019119")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0401911A RID: 102682
		[Token(Token = "0x401911A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x0401911B RID: 102683
		[Token(Token = "0x401911B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0401911C RID: 102684
		[Token(Token = "0x401911C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0401911D RID: 102685
		[Token(Token = "0x401911D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0401911E RID: 102686
		[Token(Token = "0x401911E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0401911F RID: 102687
		[Token(Token = "0x401911F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnPreviewCursorSpawn;

		// Token: 0x04019120 RID: 102688
		[Token(Token = "0x4019120")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x04019121 RID: 102689
		[Token(Token = "0x4019121")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSkillCasted;

		// Token: 0x04019122 RID: 102690
		[Token(Token = "0x4019122")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnTileClicked;

		// Token: 0x04019123 RID: 102691
		[Token(Token = "0x4019123")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnCharacterAtkOrCbt;

		// Token: 0x04019124 RID: 102692
		[Token(Token = "0x4019124")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnActivateInternalHiddenCard;

		// Token: 0x04019125 RID: 102693
		[Token(Token = "0x4019125")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckDisableBattleStartVoice;

		// Token: 0x04019126 RID: 102694
		[Token(Token = "0x4019126")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__PlayVoice;

		// Token: 0x04019127 RID: 102695
		[Token(Token = "0x4019127")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1__PlayVoice;

		// Token: 0x04019128 RID: 102696
		[Token(Token = "0x4019128")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__FindCardDataIndex;

		// Token: 0x04019129 RID: 102697
		[Token(Token = "0x4019129")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__FindCardData;

		// Token: 0x0401912A RID: 102698
		[Token(Token = "0x401912A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RefreshCardDataList;

		// Token: 0x0401912B RID: 102699
		[Token(Token = "0x401912B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadRandomVoiceList;

		// Token: 0x0401912C RID: 102700
		[Token(Token = "0x401912C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__AttachPlugin;

		// Token: 0x0401912D RID: 102701
		[Token(Token = "0x401912D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003396 RID: 13206
		[Token(Token = "0x2003396")]
		public class DefaultGamePlugin : IHotfixable
		{
			// Token: 0x17003207 RID: 12807
			// (get) Token: 0x060150FB RID: 86267 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060150FC RID: 86268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003207")]
			private protected VoicePlayer voicePlayer
			{
				[Token(Token = "0x60150FB")]
				[Address(RVA = "0xD68470", Offset = "0xD67070", VA = "0x180D68470")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x60150FC")]
				[Address(RVA = "0xD684D0", Offset = "0xD670D0", VA = "0x180D684D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060150FD RID: 86269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60150FD")]
			[Address(RVA = "0xD68210", Offset = "0xD66E10", VA = "0x180D68210", Slot = "4")]
			public virtual void Init(VoicePlayer voicePlayer)
			{
			}

			// Token: 0x060150FE RID: 86270 RVA: 0x0008A360 File Offset: 0x00088560
			[Token(Token = "0x60150FE")]
			[Address(RVA = "0xD67A90", Offset = "0xD66690", VA = "0x180D67A90", Slot = "5")]
			public virtual bool HookPlayVoice(ref BattleVoiceOption.BattleVoiceType voiceType, ref VoiceQuery vq, ref MapLayer mapLayer, out VoiceManager.PlayResult result)
			{
				return default(bool);
			}

			// Token: 0x060150FF RID: 86271 RVA: 0x0008A378 File Offset: 0x00088578
			[Token(Token = "0x60150FF")]
			[Address(RVA = "0xD682C0", Offset = "0xD66EC0", VA = "0x180D682C0", Slot = "6")]
			protected virtual VoiceManager.PlayResult PlayVoice(BattleVoiceOption.BattleVoiceType voiceType, VoiceQuery vq, MapLayer mapLayer)
			{
				return default(VoiceManager.PlayResult);
			}

			// Token: 0x06015100 RID: 86272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015100")]
			[Address(RVA = "0xD68410", Offset = "0xD67010", VA = "0x180D68410")]
			public DefaultGamePlugin()
			{
			}

			// Token: 0x0401912F RID: 102703
			[Token(Token = "0x401912F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_voicePlayer;

			// Token: 0x04019130 RID: 102704
			[Token(Token = "0x4019130")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_voicePlayer;

			// Token: 0x04019131 RID: 102705
			[Token(Token = "0x4019131")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04019132 RID: 102706
			[Token(Token = "0x4019132")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_HookPlayVoice;

			// Token: 0x04019133 RID: 102707
			[Token(Token = "0x4019133")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_PlayVoice;

			// Token: 0x04019134 RID: 102708
			[Token(Token = "0x4019134")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
