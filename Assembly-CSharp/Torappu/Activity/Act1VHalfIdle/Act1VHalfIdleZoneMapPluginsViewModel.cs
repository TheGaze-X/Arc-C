using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007819 RID: 30745
	[Token(Token = "0x2007819")]
	public class Act1VHalfIdleZoneMapPluginsViewModel : IHotfixable
	{
		// Token: 0x0602B1FF RID: 176639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1FF")]
		[Address(RVA = "0x26FF430", Offset = "0x26FE030", VA = "0x1826FF430")]
		public void LoadData(string actId, ListDict<string, StageViewModel> stageViewModels, [Optional] string forceFocusStageId)
		{
		}

		// Token: 0x0602B200 RID: 176640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B200")]
		[Address(RVA = "0x26FF200", Offset = "0x26FDE00", VA = "0x1826FF200")]
		public string FindStageIdToFocus(List<string> orderedStageId)
		{
			return null;
		}

		// Token: 0x0602B201 RID: 176641 RVA: 0x000DAEB0 File Offset: 0x000D90B0
		[Token(Token = "0x602B201")]
		[Address(RVA = "0x26FFB90", Offset = "0x26FE790", VA = "0x1826FFB90")]
		private bool _CheckIsMax(PlayerActivity.PlayerAct1VHalfIdleActivity.StageInfo stageInfo, Act1VHalfIdleStageProductionData stageProdData)
		{
			return default(bool);
		}

		// Token: 0x0602B202 RID: 176642 RVA: 0x000DAEC8 File Offset: 0x000D90C8
		[Token(Token = "0x602B202")]
		[Address(RVA = "0x26FFF80", Offset = "0x26FEB80", VA = "0x1826FFF80")]
		private bool _CheckStartTs(string stageId, out TimeSpan timeToStart)
		{
			return default(bool);
		}

		// Token: 0x0602B203 RID: 176643 RVA: 0x000DAEE0 File Offset: 0x000D90E0
		[Token(Token = "0x602B203")]
		[Address(RVA = "0x26FFDA0", Offset = "0x26FE9A0", VA = "0x1826FFDA0")]
		private bool _CheckPreposeStagePass(string stageId, out string preposeStageId)
		{
			return default(bool);
		}

		// Token: 0x0602B204 RID: 176644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B204")]
		[Address(RVA = "0x2700120", Offset = "0x26FED20", VA = "0x182700120")]
		public Act1VHalfIdleZoneMapPluginsViewModel()
		{
		}

		// Token: 0x0403E530 RID: 255280
		[Token(Token = "0x403E530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act1VHalfIdleZoneMapPluginsViewModel.StageMeta> stageMetas;

		// Token: 0x0403E531 RID: 255281
		[Token(Token = "0x403E531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HashSet<string> trackpointStages;

		// Token: 0x0403E532 RID: 255282
		[Token(Token = "0x403E532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403E533 RID: 255283
		[Token(Token = "0x403E533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_forceFocusStageId;

		// Token: 0x0403E534 RID: 255284
		[Token(Token = "0x403E534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<string> m_cachedHardStageIdSet;

		// Token: 0x0403E535 RID: 255285
		[Token(Token = "0x403E535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403E536 RID: 255286
		[Token(Token = "0x403E536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindStageIdToFocus;

		// Token: 0x0403E537 RID: 255287
		[Token(Token = "0x403E537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIsMax;

		// Token: 0x0403E538 RID: 255288
		[Token(Token = "0x403E538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckStartTs;

		// Token: 0x0403E539 RID: 255289
		[Token(Token = "0x403E539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckPreposeStagePass;

		// Token: 0x0403E53A RID: 255290
		[Token(Token = "0x403E53A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200781A RID: 30746
		[Token(Token = "0x200781A")]
		public class StageMeta
		{
			// Token: 0x0602B205 RID: 176645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B205")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StageMeta()
			{
			}

			// Token: 0x0403E53B RID: 255291
			[Token(Token = "0x403E53B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayerActivity.PlayerAct1VHalfIdleActivity.BossState bossState;

			// Token: 0x0403E53C RID: 255292
			[Token(Token = "0x403E53C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool isHard;

			// Token: 0x0403E53D RID: 255293
			[Token(Token = "0x403E53D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool isMax;

			// Token: 0x0403E53E RID: 255294
			[Token(Token = "0x403E53E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public bool isUnlocked;

			// Token: 0x0403E53F RID: 255295
			[Token(Token = "0x403E53F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
			public bool isPreposeStagePassed;

			// Token: 0x0403E540 RID: 255296
			[Token(Token = "0x403E540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool hasTrackPointOnEnterMap;

			// Token: 0x0403E541 RID: 255297
			[Token(Token = "0x403E541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string lockText;

			// Token: 0x0403E542 RID: 255298
			[Token(Token = "0x403E542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string lockToast;
		}
	}
}
