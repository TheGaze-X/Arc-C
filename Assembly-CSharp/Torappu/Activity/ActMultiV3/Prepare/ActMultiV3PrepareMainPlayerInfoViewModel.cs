using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Multiplayer;
using Torappu.Multiplayer.Servers;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007021 RID: 28705
	[Token(Token = "0x2007021")]
	public class ActMultiV3PrepareMainPlayerInfoViewModel : IHotfixable
	{
		// Token: 0x17006028 RID: 24616
		// (get) Token: 0x06028BC9 RID: 166857 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028BCA RID: 166858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006028")]
		public ActMultiV3PrepareMainPlayerInfoViewModel.PlayerViewModel partnerInfo
		{
			[Token(Token = "0x6028BC9")]
			[Address(RVA = "0x24064A0", Offset = "0x24050A0", VA = "0x1824064A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028BCA")]
			[Address(RVA = "0x2406710", Offset = "0x2405310", VA = "0x182406710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006029 RID: 24617
		// (get) Token: 0x06028BCB RID: 166859 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028BCC RID: 166860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006029")]
		public ActMultiV3PrepareMainPlayerInfoViewModel.PlayerViewModel selfInfo
		{
			[Token(Token = "0x6028BCB")]
			[Address(RVA = "0x2406500", Offset = "0x2405100", VA = "0x182406500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028BCC")]
			[Address(RVA = "0x2406790", Offset = "0x2405390", VA = "0x182406790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700602A RID: 24618
		// (get) Token: 0x06028BCD RID: 166861 RVA: 0x000D2CF0 File Offset: 0x000D0EF0
		// (set) Token: 0x06028BCE RID: 166862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700602A")]
		public ActMultiV3PrepareMainPlayerInfoViewModel.BusinessType businessType
		{
			[Token(Token = "0x6028BCD")]
			[Address(RVA = "0x2406380", Offset = "0x2404F80", VA = "0x182406380")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3PrepareMainPlayerInfoViewModel.BusinessType.STAGE_CHOOSE;
			}
			[Token(Token = "0x6028BCE")]
			[Address(RVA = "0x24065C0", Offset = "0x24051C0", VA = "0x1824065C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700602B RID: 24619
		// (get) Token: 0x06028BCF RID: 166863 RVA: 0x000D2D08 File Offset: 0x000D0F08
		// (set) Token: 0x06028BD0 RID: 166864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700602B")]
		public bool selfIsRoomOwner
		{
			[Token(Token = "0x6028BCF")]
			[Address(RVA = "0x2406560", Offset = "0x2405160", VA = "0x182406560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028BD0")]
			[Address(RVA = "0x2406810", Offset = "0x2405410", VA = "0x182406810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700602C RID: 24620
		// (get) Token: 0x06028BD1 RID: 166865 RVA: 0x000D2D20 File Offset: 0x000D0F20
		// (set) Token: 0x06028BD2 RID: 166866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700602C")]
		public bool enableChat
		{
			[Token(Token = "0x6028BD1")]
			[Address(RVA = "0x24063E0", Offset = "0x2404FE0", VA = "0x1824063E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028BD2")]
			[Address(RVA = "0x2406630", Offset = "0x2405230", VA = "0x182406630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700602D RID: 24621
		// (get) Token: 0x06028BD3 RID: 166867 RVA: 0x000D2D38 File Offset: 0x000D0F38
		// (set) Token: 0x06028BD4 RID: 166868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700602D")]
		public bool hasChatNew
		{
			[Token(Token = "0x6028BD3")]
			[Address(RVA = "0x2406440", Offset = "0x2405040", VA = "0x182406440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028BD4")]
			[Address(RVA = "0x24066A0", Offset = "0x24052A0", VA = "0x1824066A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028BD5 RID: 166869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BD5")]
		[Address(RVA = "0x2405DF0", Offset = "0x24049F0", VA = "0x182405DF0")]
		public void LoadStableData(string actId)
		{
		}

		// Token: 0x06028BD6 RID: 166870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BD6")]
		[Address(RVA = "0x2405FE0", Offset = "0x2404BE0", VA = "0x182405FE0")]
		public void UpdateData(ActMultiV3PrepareStepType curStep)
		{
		}

		// Token: 0x06028BD7 RID: 166871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BD7")]
		[Address(RVA = "0x2405F70", Offset = "0x2404B70", VA = "0x182405F70")]
		public void RefreshChatTrackPoint()
		{
		}

		// Token: 0x06028BD8 RID: 166872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BD8")]
		[Address(RVA = "0x2406320", Offset = "0x2404F20", VA = "0x182406320")]
		public ActMultiV3PrepareMainPlayerInfoViewModel()
		{
		}

		// Token: 0x0403A16C RID: 237932
		[Token(Token = "0x403A16C")]
		[FieldOffset(Offset = "0x28")]
		private string m_actId;

		// Token: 0x0403A16D RID: 237933
		[Token(Token = "0x403A16D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_partnerInfo;

		// Token: 0x0403A16E RID: 237934
		[Token(Token = "0x403A16E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_partnerInfo;

		// Token: 0x0403A16F RID: 237935
		[Token(Token = "0x403A16F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selfInfo;

		// Token: 0x0403A170 RID: 237936
		[Token(Token = "0x403A170")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selfInfo;

		// Token: 0x0403A171 RID: 237937
		[Token(Token = "0x403A171")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_businessType;

		// Token: 0x0403A172 RID: 237938
		[Token(Token = "0x403A172")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_businessType;

		// Token: 0x0403A173 RID: 237939
		[Token(Token = "0x403A173")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selfIsRoomOwner;

		// Token: 0x0403A174 RID: 237940
		[Token(Token = "0x403A174")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_selfIsRoomOwner;

		// Token: 0x0403A175 RID: 237941
		[Token(Token = "0x403A175")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_enableChat;

		// Token: 0x0403A176 RID: 237942
		[Token(Token = "0x403A176")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_enableChat;

		// Token: 0x0403A177 RID: 237943
		[Token(Token = "0x403A177")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_hasChatNew;

		// Token: 0x0403A178 RID: 237944
		[Token(Token = "0x403A178")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_hasChatNew;

		// Token: 0x0403A179 RID: 237945
		[Token(Token = "0x403A179")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadStableData;

		// Token: 0x0403A17A RID: 237946
		[Token(Token = "0x403A17A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403A17B RID: 237947
		[Token(Token = "0x403A17B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RefreshChatTrackPoint;

		// Token: 0x0403A17C RID: 237948
		[Token(Token = "0x403A17C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007022 RID: 28706
		[Token(Token = "0x2007022")]
		public enum BusinessType
		{
			// Token: 0x0403A17E RID: 237950
			[Token(Token = "0x403A17E")]
			STAGE_CHOOSE,
			// Token: 0x0403A17F RID: 237951
			[Token(Token = "0x403A17F")]
			CHAR_PICK
		}

		// Token: 0x02007023 RID: 28707
		[Token(Token = "0x2007023")]
		public class PlayerViewModel
		{
			// Token: 0x1700602E RID: 24622
			// (get) Token: 0x06028BD9 RID: 166873 RVA: 0x000D2D50 File Offset: 0x000D0F50
			// (set) Token: 0x06028BDA RID: 166874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700602E")]
			public bool isEmpty
			{
				[Token(Token = "0x6028BD9")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6028BDA")]
				[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700602F RID: 24623
			// (get) Token: 0x06028BDB RID: 166875 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06028BDC RID: 166876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700602F")]
			public string playerName
			{
				[Token(Token = "0x6028BDB")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6028BDC")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17006030 RID: 24624
			// (get) Token: 0x06028BDD RID: 166877 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06028BDE RID: 166878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006030")]
			public string playerTitle
			{
				[Token(Token = "0x6028BDD")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6028BDE")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17006031 RID: 24625
			// (get) Token: 0x06028BDF RID: 166879 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06028BE0 RID: 166880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006031")]
			public string playerLv
			{
				[Token(Token = "0x6028BDF")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6028BE0")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17006032 RID: 24626
			// (get) Token: 0x06028BE1 RID: 166881 RVA: 0x000D2D68 File Offset: 0x000D0F68
			// (set) Token: 0x06028BE2 RID: 166882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006032")]
			public PlayerAvatarQuery avatarQuery
			{
				[Token(Token = "0x6028BE1")]
				[Address(RVA = "0x2108C90", Offset = "0x2107890", VA = "0x182108C90")]
				[CompilerGenerated]
				get
				{
					return default(PlayerAvatarQuery);
				}
				[Token(Token = "0x6028BE2")]
				[Address(RVA = "0x2419860", Offset = "0x2418460", VA = "0x182419860")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17006033 RID: 24627
			// (get) Token: 0x06028BE3 RID: 166883 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06028BE4 RID: 166884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006033")]
			public string effectIconId
			{
				[Token(Token = "0x6028BE3")]
				[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6028BE4")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17006034 RID: 24628
			// (get) Token: 0x06028BE5 RID: 166885 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06028BE6 RID: 166886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006034")]
			public string effectId
			{
				[Token(Token = "0x6028BE5")]
				[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6028BE6")]
				[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17006035 RID: 24629
			// (get) Token: 0x06028BE7 RID: 166887 RVA: 0x000D2D80 File Offset: 0x000D0F80
			// (set) Token: 0x06028BE8 RID: 166888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006035")]
			public bool isPrepared
			{
				[Token(Token = "0x6028BE7")]
				[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6028BE8")]
				[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17006036 RID: 24630
			// (get) Token: 0x06028BE9 RID: 166889 RVA: 0x000D2D98 File Offset: 0x000D0F98
			// (set) Token: 0x06028BEA RID: 166890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006036")]
			public bool isOffline
			{
				[Token(Token = "0x6028BE9")]
				[Address(RVA = "0x2419850", Offset = "0x2418450", VA = "0x182419850")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6028BEA")]
				[Address(RVA = "0x2419880", Offset = "0x2418480", VA = "0x182419880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06028BEB RID: 166891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028BEB")]
			[Address(RVA = "0x2419830", Offset = "0x2418430", VA = "0x182419830")]
			public PlayerViewModel()
			{
			}

			// Token: 0x06028BEC RID: 166892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028BEC")]
			[Address(RVA = "0x2419580", Offset = "0x2418180", VA = "0x182419580")]
			public void LoadFromPlayerStatus(string actId, TeamProtocol.STPlayerStatus status, TeamInfo teamInfo, bool isOwner)
			{
			}
		}
	}
}
