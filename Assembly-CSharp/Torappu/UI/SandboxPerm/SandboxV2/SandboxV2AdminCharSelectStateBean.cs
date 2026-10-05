using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004050 RID: 16464
	[Token(Token = "0x2004050")]
	public class SandboxV2AdminCharSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06019775 RID: 104309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019775")]
		[Address(RVA = "0x122B470", Offset = "0x122A070", VA = "0x18122B470")]
		public void OnCharSelect(int index)
		{
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x06019776 RID: 104310 RVA: 0x0009E268 File Offset: 0x0009C468
		// (set) Token: 0x06019777 RID: 104311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C99")]
		public SandboxV2AdminCharSelectStateBean.OpenOption openOption
		{
			[Token(Token = "0x6019776")]
			[Address(RVA = "0x122C6E0", Offset = "0x122B2E0", VA = "0x18122C6E0")]
			[CompilerGenerated]
			get
			{
				return default(SandboxV2AdminCharSelectStateBean.OpenOption);
			}
			[Token(Token = "0x6019777")]
			[Address(RVA = "0x122C7B0", Offset = "0x122B3B0", VA = "0x18122C7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06019778 RID: 104312 RVA: 0x0009E280 File Offset: 0x0009C480
		[Token(Token = "0x6019778")]
		[Address(RVA = "0x122AE60", Offset = "0x1229A60", VA = "0x18122AE60")]
		public SandboxV2AdminCharSelectStateBean.OutPut GenOutPut()
		{
			return default(SandboxV2AdminCharSelectStateBean.OutPut);
		}

		// Token: 0x06019779 RID: 104313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019779")]
		[Address(RVA = "0x122BB40", Offset = "0x122A740", VA = "0x18122BB40")]
		public void SetOption(SandboxV2AdminCharSelectStateBean.OpenOption option)
		{
		}

		// Token: 0x0601977A RID: 104314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601977A")]
		[Address(RVA = "0x122B950", Offset = "0x122A550", VA = "0x18122B950")]
		public void SetAttrSelect(int attrEnum)
		{
		}

		// Token: 0x0601977B RID: 104315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601977B")]
		[Address(RVA = "0x122B660", Offset = "0x122A260", VA = "0x18122B660")]
		public void RefreshWithPlayerData()
		{
		}

		// Token: 0x0601977C RID: 104316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601977C")]
		[Address(RVA = "0x122C330", Offset = "0x122AF30", VA = "0x18122C330")]
		private void _RefreshCurrentSelectPlayerData()
		{
		}

		// Token: 0x0601977D RID: 104317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601977D")]
		[Address(RVA = "0x122C410", Offset = "0x122B010", VA = "0x18122C410")]
		private void _RefreshExpeditionDataIfNeed()
		{
		}

		// Token: 0x0601977E RID: 104318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601977E")]
		[Address(RVA = "0x122C4C0", Offset = "0x122B0C0", VA = "0x18122C4C0")]
		private void _RefreshLogisticsDataIfNeed()
		{
		}

		// Token: 0x0601977F RID: 104319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601977F")]
		[Address(RVA = "0x122BF00", Offset = "0x122AB00", VA = "0x18122BF00")]
		public void SetSelectSkill(string skillIndex)
		{
		}

		// Token: 0x06019780 RID: 104320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019780")]
		[Address(RVA = "0x122BA10", Offset = "0x122A610", VA = "0x18122BA10")]
		public void SetEquipId(string equipId)
		{
		}

		// Token: 0x06019781 RID: 104321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019781")]
		[Address(RVA = "0x122C030", Offset = "0x122AC30", VA = "0x18122C030")]
		public void SetShuffleProfPanelState(bool state)
		{
		}

		// Token: 0x06019782 RID: 104322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019782")]
		[Address(RVA = "0x122C1B0", Offset = "0x122ADB0", VA = "0x18122C1B0")]
		public void SetShuffleStatePanelState(bool state)
		{
		}

		// Token: 0x06019783 RID: 104323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019783")]
		[Address(RVA = "0x122C270", Offset = "0x122AE70", VA = "0x18122C270")]
		public void SetShuffleState(int status)
		{
		}

		// Token: 0x06019784 RID: 104324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019784")]
		[Address(RVA = "0x122C0F0", Offset = "0x122ACF0", VA = "0x18122C0F0")]
		public void SetShuffleProf(int status)
		{
		}

		// Token: 0x06019785 RID: 104325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019785")]
		[Address(RVA = "0x122B200", Offset = "0x1229E00", VA = "0x18122B200")]
		public void OnCharClear()
		{
		}

		// Token: 0x06019786 RID: 104326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019786")]
		[Address(RVA = "0x122B5A0", Offset = "0x122A1A0", VA = "0x18122B5A0")]
		public void OnSwitchPopViewFlag(bool isShow)
		{
		}

		// Token: 0x06019787 RID: 104327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019787")]
		[Address(RVA = "0x122C5F0", Offset = "0x122B1F0", VA = "0x18122C5F0")]
		public SandboxV2AdminCharSelectStateBean()
		{
		}

		// Token: 0x0401FBB0 RID: 129968
		[Token(Token = "0x401FBB0")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2SelectPluginLogic logic;

		// Token: 0x0401FBB1 RID: 129969
		[Token(Token = "0x401FBB1")]
		[FieldOffset(Offset = "0x18")]
		public bool ensureFlag;

		// Token: 0x0401FBB3 RID: 129971
		[Token(Token = "0x401FBB3")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public SandboxV2CharListProperty property;

		// Token: 0x0401FBB4 RID: 129972
		[Token(Token = "0x401FBB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCharSelect;

		// Token: 0x0401FBB5 RID: 129973
		[Token(Token = "0x401FBB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_openOption;

		// Token: 0x0401FBB6 RID: 129974
		[Token(Token = "0x401FBB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_openOption;

		// Token: 0x0401FBB7 RID: 129975
		[Token(Token = "0x401FBB7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenOutPut;

		// Token: 0x0401FBB8 RID: 129976
		[Token(Token = "0x401FBB8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetOption;

		// Token: 0x0401FBB9 RID: 129977
		[Token(Token = "0x401FBB9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetAttrSelect;

		// Token: 0x0401FBBA RID: 129978
		[Token(Token = "0x401FBBA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshWithPlayerData;

		// Token: 0x0401FBBB RID: 129979
		[Token(Token = "0x401FBBB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshCurrentSelectPlayerData;

		// Token: 0x0401FBBC RID: 129980
		[Token(Token = "0x401FBBC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshExpeditionDataIfNeed;

		// Token: 0x0401FBBD RID: 129981
		[Token(Token = "0x401FBBD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshLogisticsDataIfNeed;

		// Token: 0x0401FBBE RID: 129982
		[Token(Token = "0x401FBBE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetSelectSkill;

		// Token: 0x0401FBBF RID: 129983
		[Token(Token = "0x401FBBF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetEquipId;

		// Token: 0x0401FBC0 RID: 129984
		[Token(Token = "0x401FBC0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetShuffleProfPanelState;

		// Token: 0x0401FBC1 RID: 129985
		[Token(Token = "0x401FBC1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetShuffleStatePanelState;

		// Token: 0x0401FBC2 RID: 129986
		[Token(Token = "0x401FBC2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetShuffleState;

		// Token: 0x0401FBC3 RID: 129987
		[Token(Token = "0x401FBC3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetShuffleProf;

		// Token: 0x0401FBC4 RID: 129988
		[Token(Token = "0x401FBC4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnCharClear;

		// Token: 0x0401FBC5 RID: 129989
		[Token(Token = "0x401FBC5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnSwitchPopViewFlag;

		// Token: 0x0401FBC6 RID: 129990
		[Token(Token = "0x401FBC6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004051 RID: 16465
		[Token(Token = "0x2004051")]
		public struct ExpeditionOption
		{
			// Token: 0x0401FBC7 RID: 129991
			[Token(Token = "0x401FBC7")]
			[FieldOffset(Offset = "0x0")]
			public string expeditionId;

			// Token: 0x0401FBC8 RID: 129992
			[Token(Token = "0x401FBC8")]
			[FieldOffset(Offset = "0x8")]
			public string nodeId;

			// Token: 0x0401FBC9 RID: 129993
			[Token(Token = "0x401FBC9")]
			[FieldOffset(Offset = "0x10")]
			public string eventId;

			// Token: 0x0401FBCA RID: 129994
			[Token(Token = "0x401FBCA")]
			[FieldOffset(Offset = "0x18")]
			public string choiceId;
		}

		// Token: 0x02004052 RID: 16466
		[Token(Token = "0x2004052")]
		public struct OpenOption
		{
			// Token: 0x0401FBCB RID: 129995
			[Token(Token = "0x401FBCB")]
			[FieldOffset(Offset = "0x0")]
			public int editIndex;

			// Token: 0x0401FBCC RID: 129996
			[Token(Token = "0x401FBCC")]
			[FieldOffset(Offset = "0x8")]
			public string topicId;

			// Token: 0x0401FBCD RID: 129997
			[Token(Token = "0x401FBCD")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2AdminCharSelectStateMode mode;

			// Token: 0x0401FBCE RID: 129998
			[Token(Token = "0x401FBCE")]
			[FieldOffset(Offset = "0x14")]
			public int selectCount;

			// Token: 0x0401FBCF RID: 129999
			[Token(Token = "0x401FBCF")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, SandboxV2CharSquad> alreadySelectList;

			// Token: 0x0401FBD0 RID: 130000
			[Token(Token = "0x401FBD0")]
			[FieldOffset(Offset = "0x20")]
			public List<int> blackList;

			// Token: 0x0401FBD1 RID: 130001
			[Token(Token = "0x401FBD1")]
			[FieldOffset(Offset = "0x28")]
			public Action onEnsure;

			// Token: 0x0401FBD2 RID: 130002
			[Token(Token = "0x401FBD2")]
			[FieldOffset(Offset = "0x30")]
			public SandboxV2AdminCharSelectStateBean.ExpeditionOption expeditionOption;

			// Token: 0x0401FBD3 RID: 130003
			[Token(Token = "0x401FBD3")]
			[FieldOffset(Offset = "0x50")]
			public int focusPos;

			// Token: 0x0401FBD4 RID: 130004
			[Token(Token = "0x401FBD4")]
			[FieldOffset(Offset = "0x54")]
			public bool dontNeedBtnFilterStatus;
		}

		// Token: 0x02004053 RID: 16467
		[Token(Token = "0x2004053")]
		public struct OutPut
		{
			// Token: 0x0401FBD5 RID: 130005
			[Token(Token = "0x401FBD5")]
			[FieldOffset(Offset = "0x0")]
			public bool isEnsure;

			// Token: 0x0401FBD6 RID: 130006
			[Token(Token = "0x401FBD6")]
			[FieldOffset(Offset = "0x8")]
			public List<SandboxV2CharSquad> selectCharList;
		}
	}
}
