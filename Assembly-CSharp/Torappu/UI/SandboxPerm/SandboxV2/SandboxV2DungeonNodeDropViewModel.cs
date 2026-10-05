using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042B1 RID: 17073
	[Token(Token = "0x20042B1")]
	public class SandboxV2DungeonNodeDropViewModel : IHotfixable
	{
		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x0601A46F RID: 107631 RVA: 0x000A0AB8 File Offset: 0x0009ECB8
		[Token(Token = "0x17003E5A")]
		public bool IsEmpty
		{
			[Token(Token = "0x601A46F")]
			[Address(RVA = "0x1335290", Offset = "0x1333E90", VA = "0x181335290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A470 RID: 107632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A470")]
		[Address(RVA = "0x13347B0", Offset = "0x13333B0", VA = "0x1813347B0")]
		private void _MergeCollectDrop(SandboxV2Data topicData, List<PlayerSandboxV2.Dungeon.Collect> playerCollectList)
		{
		}

		// Token: 0x0601A471 RID: 107633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A471")]
		[Address(RVA = "0x1334CB0", Offset = "0x13338B0", VA = "0x181334CB0")]
		private void _MergeHuntDrop(SandboxV2Data topicData, List<PlayerSandboxV2.Dungeon.Hunt> playerHuntList)
		{
		}

		// Token: 0x0601A472 RID: 107634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A472")]
		[Address(RVA = "0x13345B0", Offset = "0x13331B0", VA = "0x1813345B0")]
		private void _MergeBaseDrop(SandboxV2Data topicData, string stageId)
		{
		}

		// Token: 0x0601A473 RID: 107635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A473")]
		[Address(RVA = "0x1334F30", Offset = "0x1333B30", VA = "0x181334F30")]
		private void _MergeSingleEntityDrop(SandboxV2Data topicData, PlayerSandboxV2.Dungeon.EntityStatus playerEntity)
		{
		}

		// Token: 0x0601A474 RID: 107636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A474")]
		[Address(RVA = "0x1334A10", Offset = "0x1333610", VA = "0x181334A10")]
		private void _MergeEntityDrop(SandboxV2Data topicData, PlayerSandboxV2.Dungeon.NodeStage playerStageData)
		{
		}

		// Token: 0x0601A475 RID: 107637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A475")]
		[Address(RVA = "0x1333930", Offset = "0x1332530", VA = "0x181333930")]
		public void UpdateBasicData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A476 RID: 107638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A476")]
		[Address(RVA = "0x1333B70", Offset = "0x1332770", VA = "0x181333B70")]
		public void UpdateData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A477 RID: 107639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A477")]
		[Address(RVA = "0x13337E0", Offset = "0x13323E0", VA = "0x1813337E0")]
		public static void MergeDrop(ListDict<string, SandboxV2DropDetail> targetDropList, SandboxV2DropDetail drop)
		{
		}

		// Token: 0x0601A478 RID: 107640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A478")]
		[Address(RVA = "0x1333490", Offset = "0x1332090", VA = "0x181333490")]
		public static void MergeDropList(ListDict<string, SandboxV2DropDetail> targetDropList, ListDict<string, SandboxV2DropDetail> srcDropList)
		{
		}

		// Token: 0x0601A479 RID: 107641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A479")]
		[Address(RVA = "0x1335120", Offset = "0x1333D20", VA = "0x181335120")]
		public SandboxV2DungeonNodeDropViewModel()
		{
		}

		// Token: 0x040214C1 RID: 136385
		[Token(Token = "0x40214C1")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<string, SandboxV2DropDetail> m_nodeDropList;

		// Token: 0x040214C2 RID: 136386
		[Token(Token = "0x40214C2")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<string> m_nodeDetailDropItems;

		// Token: 0x040214C3 RID: 136387
		[Token(Token = "0x40214C3")]
		[FieldOffset(Offset = "0x20")]
		public List<SandboxV2DropDetail> mapPreviewDropList;

		// Token: 0x040214C4 RID: 136388
		[Token(Token = "0x40214C4")]
		[FieldOffset(Offset = "0x28")]
		public List<SandboxV2DropDetail> detailPreviewDropList;

		// Token: 0x040214C5 RID: 136389
		[Token(Token = "0x40214C5")]
		[FieldOffset(Offset = "0x30")]
		public List<SandboxV2DropDetail> regularDropList;

		// Token: 0x040214C6 RID: 136390
		[Token(Token = "0x40214C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_IsEmpty;

		// Token: 0x040214C7 RID: 136391
		[Token(Token = "0x40214C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__MergeCollectDrop;

		// Token: 0x040214C8 RID: 136392
		[Token(Token = "0x40214C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MergeHuntDrop;

		// Token: 0x040214C9 RID: 136393
		[Token(Token = "0x40214C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__MergeBaseDrop;

		// Token: 0x040214CA RID: 136394
		[Token(Token = "0x40214CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__MergeSingleEntityDrop;

		// Token: 0x040214CB RID: 136395
		[Token(Token = "0x40214CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__MergeEntityDrop;

		// Token: 0x040214CC RID: 136396
		[Token(Token = "0x40214CC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateBasicData;

		// Token: 0x040214CD RID: 136397
		[Token(Token = "0x40214CD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040214CE RID: 136398
		[Token(Token = "0x40214CE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_MergeDrop;

		// Token: 0x040214CF RID: 136399
		[Token(Token = "0x40214CF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_MergeDropList;

		// Token: 0x040214D0 RID: 136400
		[Token(Token = "0x40214D0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
