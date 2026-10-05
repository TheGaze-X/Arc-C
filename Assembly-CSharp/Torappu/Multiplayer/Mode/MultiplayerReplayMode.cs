using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Multiplayer.Mode
{
	// Token: 0x020015D2 RID: 5586
	[Token(Token = "0x20015D2")]
	public class MultiplayerReplayMode : IMultiplayerMode, IHotfixable
	{
		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06007EB6 RID: 32438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F0D")]
		public string playerUID
		{
			[Token(Token = "0x6007EB6")]
			[Address(RVA = "0x2899B20", Offset = "0x2898720", VA = "0x182899B20", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06007EB7 RID: 32439 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007EB8 RID: 32440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F0E")]
		public TeamInfo teamInfo
		{
			[Token(Token = "0x6007EB7")]
			[Address(RVA = "0x2899B90", Offset = "0x2898790", VA = "0x182899B90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007EB8")]
			[Address(RVA = "0x2899D20", Offset = "0x2898920", VA = "0x182899D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06007EB9 RID: 32441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007EBA RID: 32442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F0F")]
		public BattleInfo battleInfo
		{
			[Token(Token = "0x6007EB9")]
			[Address(RVA = "0x2899930", Offset = "0x2898530", VA = "0x182899930", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007EBA")]
			[Address(RVA = "0x2899C00", Offset = "0x2898800", VA = "0x182899C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06007EBB RID: 32443 RVA: 0x00037E60 File Offset: 0x00036060
		[Token(Token = "0x17000F10")]
		public int ping
		{
			[Token(Token = "0x6007EBB")]
			[Address(RVA = "0x2899AB0", Offset = "0x28986B0", VA = "0x182899AB0", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06007EBC RID: 32444 RVA: 0x00037E78 File Offset: 0x00036078
		[Token(Token = "0x17000F11")]
		public DateTime currentTime
		{
			[Token(Token = "0x6007EBC")]
			[Address(RVA = "0x2899A10", Offset = "0x2898610", VA = "0x182899A10", Slot = "11")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06007EBD RID: 32445 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007EBE RID: 32446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F12")]
		public object cachedUserInfoForBattle
		{
			[Token(Token = "0x6007EBD")]
			[Address(RVA = "0x28999A0", Offset = "0x28985A0", VA = "0x1828999A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007EBE")]
			[Address(RVA = "0x2899C90", Offset = "0x2898890", VA = "0x182899C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EBF")]
		[Address(RVA = "0x28982A0", Offset = "0x2896EA0", VA = "0x1828982A0", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06007EC0 RID: 32448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007EC0")]
		[Address(RVA = "0x2898E00", Offset = "0x2897A00", VA = "0x182898E00")]
		private StepData _GetCurStep()
		{
			return null;
		}

		// Token: 0x06007EC1 RID: 32449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC1")]
		[Address(RVA = "0x2898320", Offset = "0x2896F20", VA = "0x182898320", Slot = "4")]
		public void Init(MultiplayerMgr mgr)
		{
		}

		// Token: 0x06007EC2 RID: 32450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC2")]
		[Address(RVA = "0x2898B80", Offset = "0x2897780", VA = "0x182898B80", Slot = "6")]
		public void Update()
		{
		}

		// Token: 0x06007EC3 RID: 32451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC3")]
		[Address(RVA = "0x2898660", Offset = "0x2897260", VA = "0x182898660")]
		public void Play(IMultiplayerBattleVideo video, string uid)
		{
		}

		// Token: 0x06007EC4 RID: 32452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC4")]
		[Address(RVA = "0x28984F0", Offset = "0x28970F0", VA = "0x1828984F0")]
		public void Play(string[] urls)
		{
		}

		// Token: 0x06007EC5 RID: 32453 RVA: 0x00037E90 File Offset: 0x00036090
		[Token(Token = "0x6007EC5")]
		[Address(RVA = "0x2898A30", Offset = "0x2897630", VA = "0x182898A30", Slot = "13")]
		public bool SendRequest(RequestType request, object param)
		{
			return default(bool);
		}

		// Token: 0x06007EC6 RID: 32454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC6")]
		[Address(RVA = "0x2898AF0", Offset = "0x28976F0", VA = "0x182898AF0")]
		public void TeamSetting(RoomConfigKey key, string value)
		{
		}

		// Token: 0x06007EC7 RID: 32455 RVA: 0x00037EA8 File Offset: 0x000360A8
		[Token(Token = "0x6007EC7")]
		[Address(RVA = "0x2898C50", Offset = "0x2897850", VA = "0x182898C50")]
		private bool _GameReady()
		{
			return default(bool);
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x00037EC0 File Offset: 0x000360C0
		[Token(Token = "0x6007EC8")]
		[Address(RVA = "0x2898CE0", Offset = "0x28978E0", VA = "0x182898CE0")]
		private bool _GameSettle(GameSettleParam settle)
		{
			return default(bool);
		}

		// Token: 0x06007EC9 RID: 32457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC9")]
		[Address(RVA = "0x2898F30", Offset = "0x2897B30", VA = "0x182898F30")]
		private void _Reset(bool exitReplay)
		{
		}

		// Token: 0x06007ECA RID: 32458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ECA")]
		[Address(RVA = "0x2899480", Offset = "0x2898080", VA = "0x182899480")]
		private void _TryPlayNext()
		{
		}

		// Token: 0x06007ECB RID: 32459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ECB")]
		[Address(RVA = "0x2899680", Offset = "0x2898280", VA = "0x182899680")]
		private void _VideoDownloaded(string url, string content)
		{
		}

		// Token: 0x06007ECC RID: 32460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ECC")]
		[Address(RVA = "0x28990A0", Offset = "0x2897CA0", VA = "0x1828990A0")]
		private void _SetLogUpload(string url)
		{
		}

		// Token: 0x06007ECD RID: 32461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ECD")]
		[Address(RVA = "0x28998B0", Offset = "0x28984B0", VA = "0x1828998B0")]
		public MultiplayerReplayMode()
		{
		}

		// Token: 0x04008058 RID: 32856
		[Token(Token = "0x4008058")]
		[FieldOffset(Offset = "0x10")]
		private MultiplayerMgr m_mgr;

		// Token: 0x04008059 RID: 32857
		[Token(Token = "0x4008059")]
		[FieldOffset(Offset = "0x18")]
		private Queue<string> m_waiteForPlay;

		// Token: 0x0400805A RID: 32858
		[Token(Token = "0x400805A")]
		[FieldOffset(Offset = "0x20")]
		private bool m_waitingTryNext;

		// Token: 0x0400805B RID: 32859
		[Token(Token = "0x400805B")]
		[FieldOffset(Offset = "0x28")]
		private IMultiplayerBattleVideo m_video;

		// Token: 0x0400805C RID: 32860
		[Token(Token = "0x400805C")]
		[FieldOffset(Offset = "0x30")]
		private string m_uid;

		// Token: 0x0400805D RID: 32861
		[Token(Token = "0x400805D")]
		[FieldOffset(Offset = "0x38")]
		private string m_vurl;

		// Token: 0x0400805E RID: 32862
		[Token(Token = "0x400805E")]
		[FieldOffset(Offset = "0x40")]
		private int m_curStep;

		// Token: 0x0400805F RID: 32863
		[Token(Token = "0x400805F")]
		[FieldOffset(Offset = "0x48")]
		private HttpUpload m_uploader;

		// Token: 0x04008062 RID: 32866
		[Token(Token = "0x4008062")]
		[FieldOffset(Offset = "0x60")]
		private RequestHandlers m_reqHandlers;

		// Token: 0x04008063 RID: 32867
		[Token(Token = "0x4008063")]
		[FieldOffset(Offset = "0x0")]
		public static float REPLAY_SPEED;

		// Token: 0x04008065 RID: 32869
		[Token(Token = "0x4008065")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_playerUID;

		// Token: 0x04008066 RID: 32870
		[Token(Token = "0x4008066")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04008067 RID: 32871
		[Token(Token = "0x4008067")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_teamInfo;

		// Token: 0x04008068 RID: 32872
		[Token(Token = "0x4008068")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04008069 RID: 32873
		[Token(Token = "0x4008069")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_battleInfo;

		// Token: 0x0400806A RID: 32874
		[Token(Token = "0x400806A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x0400806B RID: 32875
		[Token(Token = "0x400806B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x0400806C RID: 32876
		[Token(Token = "0x400806C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_cachedUserInfoForBattle;

		// Token: 0x0400806D RID: 32877
		[Token(Token = "0x400806D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_cachedUserInfoForBattle;

		// Token: 0x0400806E RID: 32878
		[Token(Token = "0x400806E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400806F RID: 32879
		[Token(Token = "0x400806F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetCurStep;

		// Token: 0x04008070 RID: 32880
		[Token(Token = "0x4008070")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04008071 RID: 32881
		[Token(Token = "0x4008071")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04008072 RID: 32882
		[Token(Token = "0x4008072")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04008073 RID: 32883
		[Token(Token = "0x4008073")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_Play;

		// Token: 0x04008074 RID: 32884
		[Token(Token = "0x4008074")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04008075 RID: 32885
		[Token(Token = "0x4008075")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TeamSetting;

		// Token: 0x04008076 RID: 32886
		[Token(Token = "0x4008076")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GameReady;

		// Token: 0x04008077 RID: 32887
		[Token(Token = "0x4008077")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GameSettle;

		// Token: 0x04008078 RID: 32888
		[Token(Token = "0x4008078")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x04008079 RID: 32889
		[Token(Token = "0x4008079")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TryPlayNext;

		// Token: 0x0400807A RID: 32890
		[Token(Token = "0x400807A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__VideoDownloaded;

		// Token: 0x0400807B RID: 32891
		[Token(Token = "0x400807B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SetLogUpload;

		// Token: 0x0400807C RID: 32892
		[Token(Token = "0x400807C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
