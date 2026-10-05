using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200455A RID: 17754
	[Token(Token = "0x200455A")]
	public class RoguelikeTopicState : State
	{
		// Token: 0x0601B0B1 RID: 110769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0B1")]
		[Address(RVA = "0x143EB30", Offset = "0x143D730", VA = "0x18143EB30", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601B0B2 RID: 110770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B0B2")]
		[Address(RVA = "0x143EE20", Offset = "0x143DA20", VA = "0x18143EE20", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601B0B3 RID: 110771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B0B3")]
		[Address(RVA = "0x143E980", Offset = "0x143D580", VA = "0x18143E980", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601B0B4 RID: 110772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B0B4")]
		[Address(RVA = "0x143EC40", Offset = "0x143D840", VA = "0x18143EC40")]
		public Coroutine PageOnlyStartShowEffect(bool useFastMode)
		{
			return null;
		}

		// Token: 0x0601B0B5 RID: 110773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0B5")]
		[Address(RVA = "0x143EBC0", Offset = "0x143D7C0", VA = "0x18143EBC0")]
		public void PageOnlyDisposeEffects()
		{
		}

		// Token: 0x0601B0B6 RID: 110774 RVA: 0x000A3F38 File Offset: 0x000A2138
		[Token(Token = "0x601B0B6")]
		[Address(RVA = "0x143E9E0", Offset = "0x143D5E0", VA = "0x18143E9E0")]
		public RoguelikeTopicEntry.DisplayParentConfig GetDisplayParentConfig(bool useFastMode)
		{
			return default(RoguelikeTopicEntry.DisplayParentConfig);
		}

		// Token: 0x0601B0B7 RID: 110775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0B7")]
		[Address(RVA = "0x143FD00", Offset = "0x143E900", VA = "0x18143FD00")]
		private void _JumpToMedalGroupState(IStateBean rawStateBean)
		{
		}

		// Token: 0x0601B0B8 RID: 110776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B0B8")]
		[Address(RVA = "0x143F900", Offset = "0x143E500", VA = "0x18143F900")]
		private string _GetMedalGroupId()
		{
			return null;
		}

		// Token: 0x0601B0B9 RID: 110777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0B9")]
		[Address(RVA = "0x143F3B0", Offset = "0x143DFB0", VA = "0x18143F3B0")]
		private void _CreateGame(RoguelikeTopicMode gameMode, int grade, string predefine)
		{
		}

		// Token: 0x0601B0BA RID: 110778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0BA")]
		[Address(RVA = "0x143EF80", Offset = "0x143DB80", VA = "0x18143EF80")]
		private void _CloseGame()
		{
		}

		// Token: 0x0601B0BB RID: 110779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0BB")]
		[Address(RVA = "0x1440580", Offset = "0x143F180", VA = "0x181440580")]
		private void _SendCloseGameRequest()
		{
		}

		// Token: 0x0601B0BC RID: 110780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0BC")]
		[Address(RVA = "0x143F2A0", Offset = "0x143DEA0", VA = "0x18143F2A0")]
		private void _ContinueGame()
		{
		}

		// Token: 0x0601B0BD RID: 110781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B0BD")]
		[Address(RVA = "0x143F710", Offset = "0x143E310", VA = "0x18143F710")]
		private string _GetCurEnableActivityIdWithMode(RoguelikeTopicMode mode)
		{
			return null;
		}

		// Token: 0x0601B0BE RID: 110782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0BE")]
		[Address(RVA = "0x14403F0", Offset = "0x143EFF0", VA = "0x1814403F0")]
		private void _OnSwitchMonthSquadListClicked(int delta)
		{
		}

		// Token: 0x0601B0BF RID: 110783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0BF")]
		[Address(RVA = "0x14401A0", Offset = "0x143EDA0", VA = "0x1814401A0")]
		private void _OnSwitchChallenge(string challengeId)
		{
		}

		// Token: 0x0601B0C0 RID: 110784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0C0")]
		[Address(RVA = "0x1440130", Offset = "0x143ED30", VA = "0x181440130")]
		private void _OnOpenWebAnnounce()
		{
		}

		// Token: 0x0601B0C1 RID: 110785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0C1")]
		[Address(RVA = "0x14400C0", Offset = "0x143ECC0", VA = "0x1814400C0")]
		private void _OnOpenRogueActivity()
		{
		}

		// Token: 0x0601B0C2 RID: 110786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0C2")]
		private void _OpenTopicFloatState<Type>() where Type : State
		{
		}

		// Token: 0x0601B0C3 RID: 110787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0C3")]
		[Address(RVA = "0x143FDF0", Offset = "0x143E9F0", VA = "0x18143FDF0")]
		private void _LoadData()
		{
		}

		// Token: 0x0601B0C4 RID: 110788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0C4")]
		[Address(RVA = "0x143F990", Offset = "0x143E590", VA = "0x18143F990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B0C5 RID: 110789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0C5")]
		[Address(RVA = "0x1440900", Offset = "0x143F500", VA = "0x181440900")]
		public RoguelikeTopicState()
		{
		}

		// Token: 0x0601B0C6 RID: 110790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0C6")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601B0C7 RID: 110791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B0C7")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04022C06 RID: 142342
		[Token(Token = "0x4022C06")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _entryContainer;

		// Token: 0x04022C07 RID: 142343
		[Token(Token = "0x4022C07")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04022C08 RID: 142344
		[Token(Token = "0x4022C08")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeTopicState.Bridge m_bridge;

		// Token: 0x04022C09 RID: 142345
		[Token(Token = "0x4022C09")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTopicEntry m_entryView;

		// Token: 0x04022C0A RID: 142346
		[Token(Token = "0x4022C0A")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeTopicBasicData m_topicBasicData;

		// Token: 0x04022C0B RID: 142347
		[Token(Token = "0x4022C0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04022C0C RID: 142348
		[Token(Token = "0x4022C0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04022C0D RID: 142349
		[Token(Token = "0x4022C0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022C0E RID: 142350
		[Token(Token = "0x4022C0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PageOnlyStartShowEffect;

		// Token: 0x04022C0F RID: 142351
		[Token(Token = "0x4022C0F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PageOnlyDisposeEffects;

		// Token: 0x04022C10 RID: 142352
		[Token(Token = "0x4022C10")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDisplayParentConfig;

		// Token: 0x04022C11 RID: 142353
		[Token(Token = "0x4022C11")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__JumpToMedalGroupState;

		// Token: 0x04022C12 RID: 142354
		[Token(Token = "0x4022C12")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetMedalGroupId;

		// Token: 0x04022C13 RID: 142355
		[Token(Token = "0x4022C13")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateGame;

		// Token: 0x04022C14 RID: 142356
		[Token(Token = "0x4022C14")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CloseGame;

		// Token: 0x04022C15 RID: 142357
		[Token(Token = "0x4022C15")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SendCloseGameRequest;

		// Token: 0x04022C16 RID: 142358
		[Token(Token = "0x4022C16")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ContinueGame;

		// Token: 0x04022C17 RID: 142359
		[Token(Token = "0x4022C17")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetCurEnableActivityIdWithMode;

		// Token: 0x04022C18 RID: 142360
		[Token(Token = "0x4022C18")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSwitchMonthSquadListClicked;

		// Token: 0x04022C19 RID: 142361
		[Token(Token = "0x4022C19")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnSwitchChallenge;

		// Token: 0x04022C1A RID: 142362
		[Token(Token = "0x4022C1A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnOpenWebAnnounce;

		// Token: 0x04022C1B RID: 142363
		[Token(Token = "0x4022C1B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnOpenRogueActivity;

		// Token: 0x04022C1C RID: 142364
		[Token(Token = "0x4022C1C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OpenTopicFloatState;

		// Token: 0x04022C1D RID: 142365
		[Token(Token = "0x4022C1D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x04022C1E RID: 142366
		[Token(Token = "0x4022C1E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022C1F RID: 142367
		[Token(Token = "0x4022C1F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200455B RID: 17755
		[Token(Token = "0x200455B")]
		public class Bridge : IHotfixable
		{
			// Token: 0x0601B0C8 RID: 110792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0C8")]
			[Address(RVA = "0x142EAE0", Offset = "0x142D6E0", VA = "0x18142EAE0")]
			public Bridge(RoguelikeTopicState state, RoguelikeTopicController controller)
			{
			}

			// Token: 0x0601B0C9 RID: 110793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0C9")]
			[Address(RVA = "0x142DA70", Offset = "0x142C670", VA = "0x18142DA70")]
			public void CreateGame(RoguelikeTopicMode gameMode, int grade, string predefine)
			{
			}

			// Token: 0x0601B0CA RID: 110794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0CA")]
			[Address(RVA = "0x142D8B0", Offset = "0x142C4B0", VA = "0x18142D8B0")]
			public void CloseGame()
			{
			}

			// Token: 0x0601B0CB RID: 110795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0CB")]
			[Address(RVA = "0x142D920", Offset = "0x142C520", VA = "0x18142D920")]
			public void ContinueGame()
			{
			}

			// Token: 0x0601B0CC RID: 110796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0CC")]
			[Address(RVA = "0x142DF80", Offset = "0x142CB80", VA = "0x18142DF80")]
			public void OpenBattlePass()
			{
			}

			// Token: 0x0601B0CD RID: 110797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0CD")]
			[Address(RVA = "0x142E1A0", Offset = "0x142CDA0", VA = "0x18142E1A0")]
			public void OpenMonthSquadRewardDetail()
			{
			}

			// Token: 0x0601B0CE RID: 110798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0CE")]
			[Address(RVA = "0x142E000", Offset = "0x142CC00", VA = "0x18142E000")]
			public void OpenChallengeModeDetail()
			{
			}

			// Token: 0x0601B0CF RID: 110799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0CF")]
			[Address(RVA = "0x142E080", Offset = "0x142CC80", VA = "0x18142E080")]
			public void OpenDifficultyDetail()
			{
			}

			// Token: 0x0601B0D0 RID: 110800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D0")]
			[Address(RVA = "0x142E220", Offset = "0x142CE20", VA = "0x18142E220")]
			public void OpenMonthTask()
			{
			}

			// Token: 0x0601B0D1 RID: 110801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D1")]
			[Address(RVA = "0x142E2A0", Offset = "0x142CEA0", VA = "0x18142E2A0")]
			public void OpenOuterBuff()
			{
			}

			// Token: 0x0601B0D2 RID: 110802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D2")]
			[Address(RVA = "0x142E810", Offset = "0x142D410", VA = "0x18142E810")]
			public void OpenTopicBank()
			{
			}

			// Token: 0x0601B0D3 RID: 110803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D3")]
			[Address(RVA = "0x142E100", Offset = "0x142CD00", VA = "0x18142E100")]
			public void OpenMedalGroup()
			{
			}

			// Token: 0x0601B0D4 RID: 110804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D4")]
			[Address(RVA = "0x142E910", Offset = "0x142D510", VA = "0x18142E910")]
			public void SwitchMonthSquadListItem(int indexDelta)
			{
			}

			// Token: 0x0601B0D5 RID: 110805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D5")]
			[Address(RVA = "0x142E890", Offset = "0x142D490", VA = "0x18142E890")]
			public void SwitchChallenge(string challengeId)
			{
			}

			// Token: 0x0601B0D6 RID: 110806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D6")]
			[Address(RVA = "0x142E5D0", Offset = "0x142D1D0", VA = "0x18142E5D0")]
			public void OpenTopicActArchive()
			{
			}

			// Token: 0x0601B0D7 RID: 110807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D7")]
			[Address(RVA = "0x142E3E0", Offset = "0x142CFE0", VA = "0x18142E3E0")]
			public void OpenTopicActArchive(ActArchiveType itemType)
			{
			}

			// Token: 0x0601B0D8 RID: 110808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D8")]
			[Address(RVA = "0x142E760", Offset = "0x142D360", VA = "0x18142E760")]
			public void OpenTopicAnnounce()
			{
			}

			// Token: 0x0601B0D9 RID: 110809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0D9")]
			[Address(RVA = "0x142E320", Offset = "0x142CF20", VA = "0x18142E320")]
			public void OpenRogueActivity()
			{
			}

			// Token: 0x0601B0DA RID: 110810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B0DA")]
			[Address(RVA = "0x142DBD0", Offset = "0x142C7D0", VA = "0x18142DBD0")]
			public void NotifyChangeGameMode(RoguelikeTopicModeViewType viewType)
			{
			}

			// Token: 0x0601B0DB RID: 110811 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B0DB")]
			[Address(RVA = "0x142DB20", Offset = "0x142C720", VA = "0x18142DB20")]
			public string GetTopicId()
			{
				return null;
			}

			// Token: 0x17004052 RID: 16466
			// (get) Token: 0x0601B0DC RID: 110812 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B0DD RID: 110813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004052")]
			public string bgmIdAlias
			{
				[Token(Token = "0x601B0DC")]
				[Address(RVA = "0x142EC80", Offset = "0x142D880", VA = "0x18142EC80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601B0DD")]
				[Address(RVA = "0x142EDA0", Offset = "0x142D9A0", VA = "0x18142EDA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004053 RID: 16467
			// (get) Token: 0x0601B0DE RID: 110814 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B0DF RID: 110815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004053")]
			public RoguelikeTopicPage page
			{
				[Token(Token = "0x601B0DE")]
				[Address(RVA = "0x142ED40", Offset = "0x142D940", VA = "0x18142ED40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601B0DF")]
				[Address(RVA = "0x142EE20", Offset = "0x142DA20", VA = "0x18142EE20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004054 RID: 16468
			// (get) Token: 0x0601B0E0 RID: 110816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004054")]
			public RoguelikeTopicController controller
			{
				[Token(Token = "0x601B0E0")]
				[Address(RVA = "0x142ECE0", Offset = "0x142D8E0", VA = "0x18142ECE0")]
				get
				{
					return null;
				}
			}

			// Token: 0x04022C20 RID: 142368
			[Token(Token = "0x4022C20")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeTopicState m_state;

			// Token: 0x04022C21 RID: 142369
			[Token(Token = "0x4022C21")]
			[FieldOffset(Offset = "0x18")]
			private RoguelikeTopicController m_controller;

			// Token: 0x04022C24 RID: 142372
			[Token(Token = "0x4022C24")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022C25 RID: 142373
			[Token(Token = "0x4022C25")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateGame;

			// Token: 0x04022C26 RID: 142374
			[Token(Token = "0x4022C26")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CloseGame;

			// Token: 0x04022C27 RID: 142375
			[Token(Token = "0x4022C27")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ContinueGame;

			// Token: 0x04022C28 RID: 142376
			[Token(Token = "0x4022C28")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OpenBattlePass;

			// Token: 0x04022C29 RID: 142377
			[Token(Token = "0x4022C29")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OpenMonthSquadRewardDetail;

			// Token: 0x04022C2A RID: 142378
			[Token(Token = "0x4022C2A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OpenChallengeModeDetail;

			// Token: 0x04022C2B RID: 142379
			[Token(Token = "0x4022C2B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OpenDifficultyDetail;

			// Token: 0x04022C2C RID: 142380
			[Token(Token = "0x4022C2C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OpenMonthTask;

			// Token: 0x04022C2D RID: 142381
			[Token(Token = "0x4022C2D")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OpenOuterBuff;

			// Token: 0x04022C2E RID: 142382
			[Token(Token = "0x4022C2E")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OpenTopicBank;

			// Token: 0x04022C2F RID: 142383
			[Token(Token = "0x4022C2F")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OpenMedalGroup;

			// Token: 0x04022C30 RID: 142384
			[Token(Token = "0x4022C30")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_SwitchMonthSquadListItem;

			// Token: 0x04022C31 RID: 142385
			[Token(Token = "0x4022C31")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_SwitchChallenge;

			// Token: 0x04022C32 RID: 142386
			[Token(Token = "0x4022C32")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_OpenTopicActArchive;

			// Token: 0x04022C33 RID: 142387
			[Token(Token = "0x4022C33")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix1_OpenTopicActArchive;

			// Token: 0x04022C34 RID: 142388
			[Token(Token = "0x4022C34")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OpenTopicAnnounce;

			// Token: 0x04022C35 RID: 142389
			[Token(Token = "0x4022C35")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_OpenRogueActivity;

			// Token: 0x04022C36 RID: 142390
			[Token(Token = "0x4022C36")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_NotifyChangeGameMode;

			// Token: 0x04022C37 RID: 142391
			[Token(Token = "0x4022C37")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_GetTopicId;

			// Token: 0x04022C38 RID: 142392
			[Token(Token = "0x4022C38")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_bgmIdAlias;

			// Token: 0x04022C39 RID: 142393
			[Token(Token = "0x4022C39")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_set_bgmIdAlias;

			// Token: 0x04022C3A RID: 142394
			[Token(Token = "0x4022C3A")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_get_page;

			// Token: 0x04022C3B RID: 142395
			[Token(Token = "0x4022C3B")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_set_page;

			// Token: 0x04022C3C RID: 142396
			[Token(Token = "0x4022C3C")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_get_controller;
		}
	}
}
