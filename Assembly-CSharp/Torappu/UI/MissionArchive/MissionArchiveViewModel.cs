using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x0200485D RID: 18525
	[Token(Token = "0x200485D")]
	public class MissionArchiveViewModel : IHotfixable
	{
		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x0601BFA7 RID: 114599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700427C")]
		public string topicId
		{
			[Token(Token = "0x601BFA7")]
			[Address(RVA = "0x1556790", Offset = "0x1555390", VA = "0x181556790")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x0601BFA8 RID: 114600 RVA: 0x000A6BF0 File Offset: 0x000A4DF0
		[Token(Token = "0x1700427D")]
		public bool hiddenUnlocked
		{
			[Token(Token = "0x601BFA8")]
			[Address(RVA = "0x1556610", Offset = "0x1555210", VA = "0x181556610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x0601BFA9 RID: 114601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700427E")]
		public Dictionary<string, MissionArchiveNodeViewModel> nodes
		{
			[Token(Token = "0x601BFA9")]
			[Address(RVA = "0x1556670", Offset = "0x1555270", VA = "0x181556670")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x0601BFAA RID: 114602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700427F")]
		public List<MissionArchiveVoiceClipViewModel> hiddenClips
		{
			[Token(Token = "0x601BFAA")]
			[Address(RVA = "0x15565B0", Offset = "0x15551B0", VA = "0x1815565B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x0601BFAB RID: 114603 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BFAC RID: 114604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004280")]
		public MissionArchiveNodeViewModel selectedNode
		{
			[Token(Token = "0x601BFAB")]
			[Address(RVA = "0x1556730", Offset = "0x1555330", VA = "0x181556730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601BFAC")]
			[Address(RVA = "0x1556860", Offset = "0x1555460", VA = "0x181556860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x0601BFAD RID: 114605 RVA: 0x000A6C08 File Offset: 0x000A4E08
		// (set) Token: 0x0601BFAE RID: 114606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004281")]
		public MissionArchiveVoicePlayState playState
		{
			[Token(Token = "0x601BFAD")]
			[Address(RVA = "0x15566D0", Offset = "0x15552D0", VA = "0x1815566D0")]
			[CompilerGenerated]
			get
			{
				return MissionArchiveVoicePlayState.NONE;
			}
			[Token(Token = "0x601BFAE")]
			[Address(RVA = "0x15567F0", Offset = "0x15553F0", VA = "0x1815567F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BFAF RID: 114607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFAF")]
		[Address(RVA = "0x1555480", Offset = "0x1554080", VA = "0x181555480")]
		public void LoadData(string topicId, MissionArchiveDataServiceProxy dataServiceProxy)
		{
		}

		// Token: 0x0601BFB0 RID: 114608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFB0")]
		[Address(RVA = "0x1555880", Offset = "0x1554480", VA = "0x181555880")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0601BFB1 RID: 114609 RVA: 0x000A6C20 File Offset: 0x000A4E20
		[Token(Token = "0x601BFB1")]
		[Address(RVA = "0x1555B30", Offset = "0x1554730", VA = "0x181555B30")]
		public bool SelectNode(string nodeId, out MissionArchiveNodeViewModel toSelect)
		{
			return default(bool);
		}

		// Token: 0x0601BFB2 RID: 114610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFB2")]
		[Address(RVA = "0x1555310", Offset = "0x1553F10", VA = "0x181555310")]
		public void DeselectNode()
		{
		}

		// Token: 0x0601BFB3 RID: 114611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BFB3")]
		[Address(RVA = "0x1556190", Offset = "0x1554D90", VA = "0x181556190")]
		private MissionArchiveNodeViewModel _LoadNode(PlayerMissionArchive playerData, MissionArchiveNodeData nodeData)
		{
			return null;
		}

		// Token: 0x0601BFB4 RID: 114612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BFB4")]
		[Address(RVA = "0x1555E50", Offset = "0x1554A50", VA = "0x181555E50")]
		private MissionArchiveVoiceClipViewModel _LoadClip(MissionArchiveVoiceClipData clipData)
		{
			return null;
		}

		// Token: 0x0601BFB5 RID: 114613 RVA: 0x000A6C38 File Offset: 0x000A4E38
		[Token(Token = "0x601BFB5")]
		[Address(RVA = "0x15560B0", Offset = "0x1554CB0", VA = "0x1815560B0")]
		private MissionArchiveNodeState _LoadNodeState(PlayerMissionArchive playerData, string nodeId)
		{
			return MissionArchiveNodeState.LOCKED;
		}

		// Token: 0x0601BFB6 RID: 114614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BFB6")]
		[Address(RVA = "0x1555D00", Offset = "0x1554900", VA = "0x181555D00")]
		private static string _GetRealWordKey(string charId)
		{
			return null;
		}

		// Token: 0x0601BFB7 RID: 114615 RVA: 0x000A6C50 File Offset: 0x000A4E50
		[Token(Token = "0x601BFB7")]
		[Address(RVA = "0x1555C70", Offset = "0x1554870", VA = "0x181555C70")]
		private static int _ClipComparison(MissionArchiveVoiceClipViewModel x, MissionArchiveVoiceClipViewModel y)
		{
			return 0;
		}

		// Token: 0x0601BFB8 RID: 114616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFB8")]
		[Address(RVA = "0x15564A0", Offset = "0x15550A0", VA = "0x1815564A0")]
		public MissionArchiveViewModel()
		{
		}

		// Token: 0x040247E3 RID: 149475
		[Token(Token = "0x40247E3")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, MissionArchiveNodeViewModel> m_nodes;

		// Token: 0x040247E4 RID: 149476
		[Token(Token = "0x40247E4")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<MissionArchiveVoiceClipViewModel> m_hiddenClips;

		// Token: 0x040247E5 RID: 149477
		[Token(Token = "0x40247E5")]
		[FieldOffset(Offset = "0x20")]
		private string m_topicId;

		// Token: 0x040247E6 RID: 149478
		[Token(Token = "0x40247E6")]
		[FieldOffset(Offset = "0x28")]
		private MissionArchiveDataServiceProxy m_dataServiceProxy;

		// Token: 0x040247E7 RID: 149479
		[Token(Token = "0x40247E7")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hiddenUnlokced;

		// Token: 0x040247EA RID: 149482
		[Token(Token = "0x40247EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040247EB RID: 149483
		[Token(Token = "0x40247EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hiddenUnlocked;

		// Token: 0x040247EC RID: 149484
		[Token(Token = "0x40247EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_nodes;

		// Token: 0x040247ED RID: 149485
		[Token(Token = "0x40247ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hiddenClips;

		// Token: 0x040247EE RID: 149486
		[Token(Token = "0x40247EE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedNode;

		// Token: 0x040247EF RID: 149487
		[Token(Token = "0x40247EF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selectedNode;

		// Token: 0x040247F0 RID: 149488
		[Token(Token = "0x40247F0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_playState;

		// Token: 0x040247F1 RID: 149489
		[Token(Token = "0x40247F1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_playState;

		// Token: 0x040247F2 RID: 149490
		[Token(Token = "0x40247F2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040247F3 RID: 149491
		[Token(Token = "0x40247F3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x040247F4 RID: 149492
		[Token(Token = "0x40247F4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SelectNode;

		// Token: 0x040247F5 RID: 149493
		[Token(Token = "0x40247F5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DeselectNode;

		// Token: 0x040247F6 RID: 149494
		[Token(Token = "0x40247F6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadNode;

		// Token: 0x040247F7 RID: 149495
		[Token(Token = "0x40247F7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadClip;

		// Token: 0x040247F8 RID: 149496
		[Token(Token = "0x40247F8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadNodeState;

		// Token: 0x040247F9 RID: 149497
		[Token(Token = "0x40247F9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetRealWordKey;

		// Token: 0x040247FA RID: 149498
		[Token(Token = "0x40247FA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClipComparison;

		// Token: 0x040247FB RID: 149499
		[Token(Token = "0x40247FB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
