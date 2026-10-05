using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200422C RID: 16940
	[Token(Token = "0x200422C")]
	public class SandboxV2EnemyRushTrackerViewModel : IHotfixable
	{
		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x0601A204 RID: 107012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E1C")]
		public string topicId
		{
			[Token(Token = "0x601A204")]
			[Address(RVA = "0x1304CB0", Offset = "0x13038B0", VA = "0x181304CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x0601A205 RID: 107013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E1D")]
		public ListDict<string, SandboxV2TrackerEnemyRushViewModel> enemyRushViewModels
		{
			[Token(Token = "0x601A205")]
			[Address(RVA = "0x1304BF0", Offset = "0x13037F0", VA = "0x181304BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x0601A206 RID: 107014 RVA: 0x000A0530 File Offset: 0x0009E730
		[Token(Token = "0x17003E1E")]
		public int enterSeq
		{
			[Token(Token = "0x601A206")]
			[Address(RVA = "0x1304C50", Offset = "0x1303850", VA = "0x181304C50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601A207 RID: 107015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A207")]
		[Address(RVA = "0x1304830", Offset = "0x1303430", VA = "0x181304830")]
		public void LoadData(string topicId, List<SandboxV2DungeonEnemyRushViewModel> erFloatList)
		{
		}

		// Token: 0x0601A208 RID: 107016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A208")]
		[Address(RVA = "0x1304770", Offset = "0x1303370", VA = "0x181304770")]
		public string GetSelectedNodeId()
		{
			return null;
		}

		// Token: 0x0601A209 RID: 107017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A209")]
		[Address(RVA = "0x1304AE0", Offset = "0x13036E0", VA = "0x181304AE0")]
		public void NotifyEnterSeq()
		{
		}

		// Token: 0x0601A20A RID: 107018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A20A")]
		[Address(RVA = "0x1304B40", Offset = "0x1303740", VA = "0x181304B40")]
		public SandboxV2EnemyRushTrackerViewModel()
		{
		}

		// Token: 0x04020FB4 RID: 135092
		[Token(Token = "0x4020FB4")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x04020FB5 RID: 135093
		[Token(Token = "0x4020FB5")]
		[FieldOffset(Offset = "0x18")]
		private int m_enterSeq;

		// Token: 0x04020FB6 RID: 135094
		[Token(Token = "0x4020FB6")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, SandboxV2TrackerEnemyRushViewModel> m_enemyRushViewModels;

		// Token: 0x04020FB7 RID: 135095
		[Token(Token = "0x4020FB7")]
		[FieldOffset(Offset = "0x28")]
		public string selectedId;

		// Token: 0x04020FB8 RID: 135096
		[Token(Token = "0x4020FB8")]
		[FieldOffset(Offset = "0x30")]
		public string confirmedNodeId;

		// Token: 0x04020FB9 RID: 135097
		[Token(Token = "0x4020FB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04020FBA RID: 135098
		[Token(Token = "0x4020FBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enemyRushViewModels;

		// Token: 0x04020FBB RID: 135099
		[Token(Token = "0x4020FBB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enterSeq;

		// Token: 0x04020FBC RID: 135100
		[Token(Token = "0x4020FBC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04020FBD RID: 135101
		[Token(Token = "0x4020FBD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSelectedNodeId;

		// Token: 0x04020FBE RID: 135102
		[Token(Token = "0x4020FBE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyEnterSeq;

		// Token: 0x04020FBF RID: 135103
		[Token(Token = "0x4020FBF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
