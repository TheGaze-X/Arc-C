using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037AF RID: 14255
	[Token(Token = "0x20037AF")]
	public class UIMusicManager : SingletonInScene<UIMusicManager>, IHotfixable, IDisposable
	{
		// Token: 0x060169BB RID: 92603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169BB")]
		[Address(RVA = "0xF01E40", Offset = "0xF00A40", VA = "0x180F01E40")]
		private UIMusicManager()
		{
		}

		// Token: 0x060169BC RID: 92604 RVA: 0x00091F50 File Offset: 0x00090150
		[Token(Token = "0x60169BC")]
		[Address(RVA = "0xF00900", Offset = "0xEFF500", VA = "0x180F00900")]
		private int _BlockMusicChanges(UnityEngine.Object blockRef)
		{
			return 0;
		}

		// Token: 0x060169BD RID: 92605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169BD")]
		[Address(RVA = "0xF01440", Offset = "0xF00040", VA = "0x180F01440")]
		private void _ReleaseMusicBlocker(int id)
		{
		}

		// Token: 0x060169BE RID: 92606 RVA: 0x00091F68 File Offset: 0x00090168
		[Token(Token = "0x60169BE")]
		[Address(RVA = "0xF01190", Offset = "0xEFFD90", VA = "0x180F01190")]
		private bool _IsMusicChangable()
		{
			return default(bool);
		}

		// Token: 0x060169BF RID: 92607 RVA: 0x00091F80 File Offset: 0x00090180
		[Token(Token = "0x60169BF")]
		[Address(RVA = "0xF00AC0", Offset = "0xEFF6C0", VA = "0x180F00AC0")]
		private bool _CheckIfToClearMusic()
		{
			return default(bool);
		}

		// Token: 0x060169C0 RID: 92608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169C0")]
		[Address(RVA = "0xEFF800", Offset = "0xEFE400", VA = "0x180EFF800")]
		public static void AddClearMusicChunk(int instId)
		{
		}

		// Token: 0x060169C1 RID: 92609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169C1")]
		[Address(RVA = "0xF000C0", Offset = "0xEFECC0", VA = "0x180F000C0")]
		public static void RemoveClearMusicChunk(int instId)
		{
		}

		// Token: 0x060169C2 RID: 92610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169C2")]
		[Address(RVA = "0xF005A0", Offset = "0xEFF1A0", VA = "0x180F005A0")]
		private void _AddClearMusicChunk(int instId)
		{
		}

		// Token: 0x060169C3 RID: 92611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169C3")]
		[Address(RVA = "0xF01620", Offset = "0xF00220", VA = "0x180F01620")]
		private void _RemoveClearMusicChunk(int instId)
		{
		}

		// Token: 0x060169C4 RID: 92612 RVA: 0x00091F98 File Offset: 0x00090198
		[Token(Token = "0x60169C4")]
		[Address(RVA = "0xEFFC20", Offset = "0xEFE820", VA = "0x180EFFC20")]
		public static long GetInstanceIdByAlias(string alias)
		{
			return 0L;
		}

		// Token: 0x060169C5 RID: 92613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169C5")]
		[Address(RVA = "0xEFFB90", Offset = "0xEFE790", VA = "0x180EFFB90", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060169C6 RID: 92614 RVA: 0x00091FB0 File Offset: 0x000901B0
		[Token(Token = "0x60169C6")]
		[Address(RVA = "0xF00350", Offset = "0xEFEF50", VA = "0x180F00350")]
		public static bool TestMusicSignal(UIMusicManager.ChunkConfig config)
		{
			return default(bool);
		}

		// Token: 0x060169C7 RID: 92615 RVA: 0x00091FC8 File Offset: 0x000901C8
		[Token(Token = "0x60169C7")]
		[Address(RVA = "0xEFF930", Offset = "0xEFE530", VA = "0x180EFF930")]
		public static int BlockMusicChanges(UnityEngine.Object blockRef)
		{
			return 0;
		}

		// Token: 0x060169C8 RID: 92616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169C8")]
		[Address(RVA = "0xF00020", Offset = "0xEFEC20", VA = "0x180F00020")]
		public static void ReleaseMusicChangeBlocker(int id)
		{
		}

		// Token: 0x060169C9 RID: 92617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169C9")]
		[Address(RVA = "0xEFFED0", Offset = "0xEFEAD0", VA = "0x180EFFED0")]
		public static void ModifyMusicChunk(long chunkId, UIMusicManager.ChunkConfig config, bool allowRepeatChunk = false)
		{
		}

		// Token: 0x060169CA RID: 92618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169CA")]
		[Address(RVA = "0xEFFD80", Offset = "0xEFE980", VA = "0x180EFFD80")]
		public static void ModifyMusicChunkById(long chunkId, string musicId, bool allowRepeatChunk = false)
		{
		}

		// Token: 0x060169CB RID: 92619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169CB")]
		[Address(RVA = "0xF01220", Offset = "0xEFFE20", VA = "0x180F01220")]
		private static void _RegisterMusicChunk(long chunkId, UIMusicManager.IMusicChunk musicChunk, bool isReplace)
		{
		}

		// Token: 0x060169CC RID: 92620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169CC")]
		[Address(RVA = "0xF01B10", Offset = "0xF00710", VA = "0x180F01B10")]
		private static void _UnRegisterMusicChunk(long chunkId, bool isClear)
		{
		}

		// Token: 0x060169CD RID: 92621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169CD")]
		[Address(RVA = "0xF00C20", Offset = "0xEFF820", VA = "0x180F00C20")]
		private static void _InitialAddMusicChunkAtTop(long targetChunkId, UIMusicManager.IMusicChunk musicChunk)
		{
		}

		// Token: 0x060169CE RID: 92622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169CE")]
		[Address(RVA = "0xF00D60", Offset = "0xEFF960", VA = "0x180F00D60")]
		private static void _InitialAddNotRepeatChunk(long targetChunkId, UIMusicManager.IMusicChunk musicChunk)
		{
		}

		// Token: 0x060169CF RID: 92623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169CF")]
		[Address(RVA = "0xF00EE0", Offset = "0xEFFAE0", VA = "0x180F00EE0")]
		private static void _InitialRemoveMusicChunkById(long targetChunkId, bool removeAllMatch)
		{
		}

		// Token: 0x060169D0 RID: 92624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169D0")]
		[Address(RVA = "0xF001F0", Offset = "0xEFEDF0", VA = "0x180F001F0")]
		public static void RemoveMusicChunk(long instId, UIMusicManager.RemoveChunkType removeChunkType = UIMusicManager.RemoveChunkType.REMOVE_ALL_MATCH)
		{
		}

		// Token: 0x060169D1 RID: 92625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169D1")]
		[Address(RVA = "0xF00290", Offset = "0xEFEE90", VA = "0x180F00290")]
		public static void SyncPlayingMusic()
		{
		}

		// Token: 0x060169D2 RID: 92626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169D2")]
		[Address(RVA = "0xF016D0", Offset = "0xF002D0", VA = "0x180F016D0")]
		private void _SyncPlayingMusicImpl()
		{
		}

		// Token: 0x060169D3 RID: 92627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169D3")]
		[Address(RVA = "0xF00650", Offset = "0xEFF250", VA = "0x180F00650")]
		private void _ApplyEffect(long chunkID, UIMusicManager.IMusicEffect effect)
		{
		}

		// Token: 0x060169D4 RID: 92628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169D4")]
		[Address(RVA = "0xF00B60", Offset = "0xEFF760", VA = "0x180F00B60")]
		private static string _ConvertToAudioModule(UIMusicManager.PlayModuleType type)
		{
			return null;
		}

		// Token: 0x060169D5 RID: 92629 RVA: 0x00091FE0 File Offset: 0x000901E0
		[Token(Token = "0x60169D5")]
		[Address(RVA = "0xF00440", Offset = "0xEFF040", VA = "0x180F00440")]
		public static bool TryGetMusicParamInfo(UIMusicManager.MusicParam param, out string name, out float defaultVal)
		{
			return default(bool);
		}

		// Token: 0x0401B408 RID: 111624
		[Token(Token = "0x401B408")]
		[FieldOffset(Offset = "0x0")]
		private static readonly UIMusicManager.ChunkConfig CLEAR_MUSIC_CHUNK;

		// Token: 0x0401B409 RID: 111625
		[Token(Token = "0x401B409")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<int, UIMusicManager.ChangeBlocker> m_changeBlockers;

		// Token: 0x0401B40A RID: 111626
		[Token(Token = "0x401B40A")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasPendingMusicChanges;

		// Token: 0x0401B40B RID: 111627
		[Token(Token = "0x401B40B")]
		[FieldOffset(Offset = "0x28")]
		private ListSet<int> m_clearMusicRequests;

		// Token: 0x0401B40C RID: 111628
		[Token(Token = "0x401B40C")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<string, long> s_alias2InstanceIdDict;

		// Token: 0x0401B40D RID: 111629
		[Token(Token = "0x401B40D")]
		[FieldOffset(Offset = "0x30")]
		private static long s_instanceId;

		// Token: 0x0401B40E RID: 111630
		[Token(Token = "0x401B40E")]
		[FieldOffset(Offset = "0x30")]
		private List<long> m_chunkIds;

		// Token: 0x0401B40F RID: 111631
		[Token(Token = "0x401B40F")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, UIMusicManager.MusicChunkHolder> m_chunkHolderDict;

		// Token: 0x0401B410 RID: 111632
		[Token(Token = "0x401B410")]
		[FieldOffset(Offset = "0x40")]
		private UIMusicManager.MixerParamMgr m_mixerParamMgr;

		// Token: 0x0401B411 RID: 111633
		[Token(Token = "0x401B411")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B412 RID: 111634
		[Token(Token = "0x401B412")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__BlockMusicChanges;

		// Token: 0x0401B413 RID: 111635
		[Token(Token = "0x401B413")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ReleaseMusicBlocker;

		// Token: 0x0401B414 RID: 111636
		[Token(Token = "0x401B414")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__IsMusicChangable;

		// Token: 0x0401B415 RID: 111637
		[Token(Token = "0x401B415")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckIfToClearMusic;

		// Token: 0x0401B416 RID: 111638
		[Token(Token = "0x401B416")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_AddClearMusicChunk;

		// Token: 0x0401B417 RID: 111639
		[Token(Token = "0x401B417")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RemoveClearMusicChunk;

		// Token: 0x0401B418 RID: 111640
		[Token(Token = "0x401B418")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__AddClearMusicChunk;

		// Token: 0x0401B419 RID: 111641
		[Token(Token = "0x401B419")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RemoveClearMusicChunk;

		// Token: 0x0401B41A RID: 111642
		[Token(Token = "0x401B41A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetInstanceIdByAlias;

		// Token: 0x0401B41B RID: 111643
		[Token(Token = "0x401B41B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401B41C RID: 111644
		[Token(Token = "0x401B41C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_TestMusicSignal;

		// Token: 0x0401B41D RID: 111645
		[Token(Token = "0x401B41D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_BlockMusicChanges;

		// Token: 0x0401B41E RID: 111646
		[Token(Token = "0x401B41E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ReleaseMusicChangeBlocker;

		// Token: 0x0401B41F RID: 111647
		[Token(Token = "0x401B41F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ModifyMusicChunk;

		// Token: 0x0401B420 RID: 111648
		[Token(Token = "0x401B420")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ModifyMusicChunkById;

		// Token: 0x0401B421 RID: 111649
		[Token(Token = "0x401B421")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RegisterMusicChunk;

		// Token: 0x0401B422 RID: 111650
		[Token(Token = "0x401B422")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UnRegisterMusicChunk;

		// Token: 0x0401B423 RID: 111651
		[Token(Token = "0x401B423")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__InitialAddMusicChunkAtTop;

		// Token: 0x0401B424 RID: 111652
		[Token(Token = "0x401B424")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__InitialAddNotRepeatChunk;

		// Token: 0x0401B425 RID: 111653
		[Token(Token = "0x401B425")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__InitialRemoveMusicChunkById;

		// Token: 0x0401B426 RID: 111654
		[Token(Token = "0x401B426")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RemoveMusicChunk;

		// Token: 0x0401B427 RID: 111655
		[Token(Token = "0x401B427")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_SyncPlayingMusic;

		// Token: 0x0401B428 RID: 111656
		[Token(Token = "0x401B428")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__SyncPlayingMusicImpl;

		// Token: 0x0401B429 RID: 111657
		[Token(Token = "0x401B429")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ApplyEffect;

		// Token: 0x0401B42A RID: 111658
		[Token(Token = "0x401B42A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__ConvertToAudioModule;

		// Token: 0x0401B42B RID: 111659
		[Token(Token = "0x401B42B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_TryGetMusicParamInfo;

		// Token: 0x020037B0 RID: 14256
		[Token(Token = "0x20037B0")]
		public enum PlayModuleType
		{
			// Token: 0x0401B42D RID: 111661
			[Token(Token = "0x401B42D")]
			MODULE_SYS,
			// Token: 0x0401B42E RID: 111662
			[Token(Token = "0x401B42E")]
			MODULE_BATTLE,
			// Token: 0x0401B42F RID: 111663
			[Token(Token = "0x401B42F")]
			MODULE_UI
		}

		// Token: 0x020037B1 RID: 14257
		[Token(Token = "0x20037B1")]
		public interface IMusicChunk
		{
			// Token: 0x060169D7 RID: 92631
			[Token(Token = "0x60169D7")]
			string CreateEventName();

			// Token: 0x060169D8 RID: 92632
			[Token(Token = "0x60169D8")]
			UIMusicManager.IMusicEffect GetEffect();
		}

		// Token: 0x020037B2 RID: 14258
		[Token(Token = "0x20037B2")]
		private class MusicChunkHolder
		{
			// Token: 0x060169D9 RID: 92633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169D9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MusicChunkHolder()
			{
			}

			// Token: 0x0401B430 RID: 111664
			[Token(Token = "0x401B430")]
			[FieldOffset(Offset = "0x10")]
			public long chunkId;

			// Token: 0x0401B431 RID: 111665
			[Token(Token = "0x401B431")]
			[FieldOffset(Offset = "0x18")]
			public int chunkRemainCount;

			// Token: 0x0401B432 RID: 111666
			[Token(Token = "0x401B432")]
			[FieldOffset(Offset = "0x20")]
			public UIMusicManager.IMusicChunk musicChunk;
		}

		// Token: 0x020037B3 RID: 14259
		[Token(Token = "0x20037B3")]
		public enum RemoveChunkType
		{
			// Token: 0x0401B434 RID: 111668
			[Token(Token = "0x401B434")]
			REMOVE_TOP,
			// Token: 0x0401B435 RID: 111669
			[Token(Token = "0x401B435")]
			REMOVE_FIRST_MATCH,
			// Token: 0x0401B436 RID: 111670
			[Token(Token = "0x401B436")]
			REMOVE_ALL_MATCH
		}

		// Token: 0x020037B4 RID: 14260
		[Token(Token = "0x20037B4")]
		private struct InternalMusicChunk : UIMusicManager.IMusicChunk
		{
			// Token: 0x060169DA RID: 92634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60169DA")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550", Slot = "4")]
			public string CreateEventName()
			{
				return null;
			}

			// Token: 0x060169DB RID: 92635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60169DB")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			public UIMusicManager.IMusicEffect GetEffect()
			{
				return null;
			}

			// Token: 0x0401B437 RID: 111671
			[Token(Token = "0x401B437")]
			[FieldOffset(Offset = "0x0")]
			public string eventName;
		}

		// Token: 0x020037B5 RID: 14261
		[Token(Token = "0x20037B5")]
		public struct ChunkConfig : UIMusicManager.IMusicChunk
		{
			// Token: 0x1700361D RID: 13853
			// (get) Token: 0x060169DC RID: 92636 RVA: 0x00091FF8 File Offset: 0x000901F8
			[Token(Token = "0x1700361D")]
			public bool isEmpty
			{
				[Token(Token = "0x60169DC")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060169DD RID: 92637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60169DD")]
			[Address(RVA = "0xEF2BC0", Offset = "0xEF17C0", VA = "0x180EF2BC0", Slot = "4")]
			public string CreateEventName()
			{
				return null;
			}

			// Token: 0x060169DE RID: 92638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60169DE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
			public UIMusicManager.IMusicEffect GetEffect()
			{
				return null;
			}

			// Token: 0x0401B438 RID: 111672
			[Token(Token = "0x401B438")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMusicManager.ChunkConfig EMPTY;

			// Token: 0x0401B439 RID: 111673
			[Token(Token = "0x401B439")]
			[FieldOffset(Offset = "0x0")]
			private bool m_isEmpty;

			// Token: 0x0401B43A RID: 111674
			[Token(Token = "0x401B43A")]
			[FieldOffset(Offset = "0x8")]
			public string signal;

			// Token: 0x0401B43B RID: 111675
			[Token(Token = "0x401B43B")]
			[FieldOffset(Offset = "0x10")]
			public string subSignal;

			// Token: 0x0401B43C RID: 111676
			[Token(Token = "0x401B43C")]
			[FieldOffset(Offset = "0x18")]
			public UIMusicManager.PlayModuleType playModule;

			// Token: 0x0401B43D RID: 111677
			[Token(Token = "0x401B43D")]
			[FieldOffset(Offset = "0x20")]
			public UIMusicManager.IMusicEffect effect;
		}

		// Token: 0x020037B6 RID: 14262
		[Token(Token = "0x20037B6")]
		private struct ChangeBlocker
		{
			// Token: 0x0401B43E RID: 111678
			[Token(Token = "0x401B43E")]
			[FieldOffset(Offset = "0x0")]
			public UnityEngine.Object refObj;

			// Token: 0x0401B43F RID: 111679
			[Token(Token = "0x401B43F")]
			[FieldOffset(Offset = "0x8")]
			public int id;
		}

		// Token: 0x020037B7 RID: 14263
		[Token(Token = "0x20037B7")]
		public enum MusicParam
		{
			// Token: 0x0401B441 RID: 111681
			[Token(Token = "0x401B441")]
			NONE,
			// Token: 0x0401B442 RID: 111682
			[Token(Token = "0x401B442")]
			LOWPASS_CUTOFF,
			// Token: 0x0401B443 RID: 111683
			[Token(Token = "0x401B443")]
			LOWPASS_RESONANCE
		}

		// Token: 0x020037B8 RID: 14264
		[Token(Token = "0x20037B8")]
		private class MixerParamMgr : IDisposable
		{
			// Token: 0x1700361E RID: 13854
			// (get) Token: 0x060169E0 RID: 92640 RVA: 0x00092010 File Offset: 0x00090210
			// (set) Token: 0x060169E1 RID: 92641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700361E")]
			public long chunkID
			{
				[Token(Token = "0x60169E0")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x60169E1")]
				[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060169E2 RID: 92642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169E2")]
			[Address(RVA = "0xEFA430", Offset = "0xEF9030", VA = "0x180EFA430")]
			public void EffectOnly_Modify(UIMusicManager.MusicParam param, float value)
			{
			}

			// Token: 0x060169E3 RID: 92643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169E3")]
			[Address(RVA = "0xEFA840", Offset = "0xEF9440", VA = "0x180EFA840")]
			public void SetCurrentChunk(long targetChunk)
			{
			}

			// Token: 0x060169E4 RID: 92644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169E4")]
			[Address(RVA = "0xEFA400", Offset = "0xEF9000", VA = "0x180EFA400")]
			public void ClearAll()
			{
			}

			// Token: 0x060169E5 RID: 92645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169E5")]
			[Address(RVA = "0xEFA420", Offset = "0xEF9020", VA = "0x180EFA420", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060169E6 RID: 92646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169E6")]
			[Address(RVA = "0xEFA860", Offset = "0xEF9460", VA = "0x180EFA860")]
			private void _ClearAllModification()
			{
			}

			// Token: 0x060169E7 RID: 92647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169E7")]
			[Address(RVA = "0xEFAA20", Offset = "0xEF9620", VA = "0x180EFAA20")]
			public MixerParamMgr()
			{
			}

			// Token: 0x0401B444 RID: 111684
			[Token(Token = "0x401B444")]
			[FieldOffset(Offset = "0x10")]
			private LocalGenericPool<UIMusicManager.MixerParamMgr.Modification> m_modificationPool;

			// Token: 0x0401B445 RID: 111685
			[Token(Token = "0x401B445")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isDisposed;

			// Token: 0x0401B447 RID: 111687
			[Token(Token = "0x401B447")]
			[FieldOffset(Offset = "0x28")]
			private List<UIMusicManager.MixerParamMgr.Modification> m_modifications;

			// Token: 0x020037B9 RID: 14265
			[Token(Token = "0x20037B9")]
			private class Modification
			{
				// Token: 0x060169E8 RID: 92648 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60169E8")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Modification()
				{
				}

				// Token: 0x0401B448 RID: 111688
				[Token(Token = "0x401B448")]
				[FieldOffset(Offset = "0x10")]
				public UIMusicManager.MusicParam param;

				// Token: 0x0401B449 RID: 111689
				[Token(Token = "0x401B449")]
				[FieldOffset(Offset = "0x18")]
				public string name;

				// Token: 0x0401B44A RID: 111690
				[Token(Token = "0x401B44A")]
				[FieldOffset(Offset = "0x20")]
				public float defaultValue;

				// Token: 0x0401B44B RID: 111691
				[Token(Token = "0x401B44B")]
				[FieldOffset(Offset = "0x24")]
				public float value;
			}
		}

		// Token: 0x020037BA RID: 14266
		[Token(Token = "0x20037BA")]
		public interface IMusicEffect
		{
			// Token: 0x060169E9 RID: 92649
			[Token(Token = "0x60169E9")]
			void Apply(long chunkID);
		}

		// Token: 0x020037BB RID: 14267
		[Token(Token = "0x20037BB")]
		public abstract class MusicEffect : UIMusicManager.IMusicEffect
		{
			// Token: 0x060169EA RID: 92650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169EA")]
			[Address(RVA = "0xEFAB60", Offset = "0xEF9760", VA = "0x180EFAB60")]
			public void SetMixerParamMgr(object mgr)
			{
			}

			// Token: 0x060169EB RID: 92651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169EB")]
			[Address(RVA = "0xEFAB00", Offset = "0xEF9700", VA = "0x180EFAB00", Slot = "4")]
			public void Apply(long chunkID)
			{
			}

			// Token: 0x060169EC RID: 92652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169EC")]
			[Address(RVA = "0xEFAC70", Offset = "0xEF9870", VA = "0x180EFAC70")]
			protected void SetMixerParam(UIMusicManager.MusicParam param, float value)
			{
			}

			// Token: 0x060169ED RID: 92653
			[Token(Token = "0x60169ED")]
			protected abstract void OnApply();

			// Token: 0x060169EE RID: 92654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169EE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected MusicEffect()
			{
			}

			// Token: 0x0401B44C RID: 111692
			[Token(Token = "0x401B44C")]
			[FieldOffset(Offset = "0x10")]
			private UIMusicManager.MixerParamMgr m_mixerParamMgr;
		}

		// Token: 0x020037BC RID: 14268
		[Token(Token = "0x20037BC")]
		public class LowpassEffect : UIMusicManager.MusicEffect
		{
			// Token: 0x060169EF RID: 92655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169EF")]
			[Address(RVA = "0xEF9F00", Offset = "0xEF8B00", VA = "0x180EF9F00", Slot = "5")]
			protected override void OnApply()
			{
			}

			// Token: 0x060169F0 RID: 92656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169F0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LowpassEffect()
			{
			}

			// Token: 0x0401B44D RID: 111693
			[Token(Token = "0x401B44D")]
			[FieldOffset(Offset = "0x18")]
			public float cutoff;

			// Token: 0x0401B44E RID: 111694
			[Token(Token = "0x401B44E")]
			[FieldOffset(Offset = "0x1C")]
			public float resonance;
		}
	}
}
