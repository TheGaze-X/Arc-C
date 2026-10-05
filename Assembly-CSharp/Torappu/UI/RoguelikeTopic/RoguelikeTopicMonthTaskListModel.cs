using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044EC RID: 17644
	[Token(Token = "0x20044EC")]
	public class RoguelikeTopicMonthTaskListModel : IHotfixable
	{
		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x0601AEF5 RID: 110325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FEA")]
		public string topicId
		{
			[Token(Token = "0x601AEF5")]
			[Address(RVA = "0x142A3F0", Offset = "0x1428FF0", VA = "0x18142A3F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x0601AEF6 RID: 110326 RVA: 0x000A3A40 File Offset: 0x000A1C40
		[Token(Token = "0x17003FEB")]
		public bool isFinalUpdate
		{
			[Token(Token = "0x601AEF6")]
			[Address(RVA = "0x142A330", Offset = "0x1428F30", VA = "0x18142A330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x0601AEF7 RID: 110327 RVA: 0x000A3A58 File Offset: 0x000A1C58
		[Token(Token = "0x17003FEC")]
		public bool canRefresh
		{
			[Token(Token = "0x601AEF7")]
			[Address(RVA = "0x142A2D0", Offset = "0x1428ED0", VA = "0x18142A2D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x0601AEF8 RID: 110328 RVA: 0x000A3A70 File Offset: 0x000A1C70
		[Token(Token = "0x17003FED")]
		public bool showRefreshCount
		{
			[Token(Token = "0x601AEF8")]
			[Address(RVA = "0x142A390", Offset = "0x1428F90", VA = "0x18142A390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x0601AEF9 RID: 110329 RVA: 0x000A3A88 File Offset: 0x000A1C88
		[Token(Token = "0x17003FEE")]
		public TimeSpan updateCountDown
		{
			[Token(Token = "0x601AEF9")]
			[Address(RVA = "0x142A450", Offset = "0x1429050", VA = "0x18142A450")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x0601AEFA RID: 110330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FEF")]
		public string bpItemName
		{
			[Token(Token = "0x601AEFA")]
			[Address(RVA = "0x142A210", Offset = "0x1428E10", VA = "0x18142A210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003FF0 RID: 16368
		// (get) Token: 0x0601AEFB RID: 110331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FF0")]
		public Sprite bpItemSprite
		{
			[Token(Token = "0x601AEFB")]
			[Address(RVA = "0x142A270", Offset = "0x1428E70", VA = "0x18142A270")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AEFC RID: 110332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEFC")]
		[Address(RVA = "0x14295D0", Offset = "0x14281D0", VA = "0x1814295D0")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601AEFD RID: 110333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEFD")]
		[Address(RVA = "0x1429A40", Offset = "0x1428640", VA = "0x181429A40")]
		public void LoadData(string topicId, IList<PlayerRoguelikeV2.OuterData.Mission.MissionItem> missions, int currBp)
		{
		}

		// Token: 0x0601AEFE RID: 110334 RVA: 0x000A3AA0 File Offset: 0x000A1CA0
		[Token(Token = "0x601AEFE")]
		[Address(RVA = "0x1429D60", Offset = "0x1428960", VA = "0x181429D60")]
		private long _GetFullStoredTime(string topicId)
		{
			return 0L;
		}

		// Token: 0x0601AEFF RID: 110335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEFF")]
		[Address(RVA = "0x1429E40", Offset = "0x1428A40", VA = "0x181429E40")]
		private void _UpdateTopicData()
		{
		}

		// Token: 0x0601AF00 RID: 110336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF00")]
		[Address(RVA = "0x142A110", Offset = "0x1428D10", VA = "0x18142A110")]
		public RoguelikeTopicMonthTaskListModel()
		{
		}

		// Token: 0x040228C4 RID: 141508
		[Token(Token = "0x40228C4")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeTopicMonthTaskModel> taskModelList;

		// Token: 0x040228C5 RID: 141509
		[Token(Token = "0x40228C5")]
		[FieldOffset(Offset = "0x18")]
		public int refreshCount;

		// Token: 0x040228C6 RID: 141510
		[Token(Token = "0x40228C6")]
		[FieldOffset(Offset = "0x20")]
		private string m_topicId;

		// Token: 0x040228C7 RID: 141511
		[Token(Token = "0x40228C7")]
		[FieldOffset(Offset = "0x28")]
		private string m_bpItemName;

		// Token: 0x040228C8 RID: 141512
		[Token(Token = "0x40228C8")]
		[FieldOffset(Offset = "0x30")]
		private Sprite m_bpItemSprite;

		// Token: 0x040228C9 RID: 141513
		[Token(Token = "0x40228C9")]
		[FieldOffset(Offset = "0x38")]
		private long m_nextUpdateTime;

		// Token: 0x040228CA RID: 141514
		[Token(Token = "0x40228CA")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isFinalUpdate;

		// Token: 0x040228CB RID: 141515
		[Token(Token = "0x40228CB")]
		[FieldOffset(Offset = "0x41")]
		private bool m_showRefreshCount;

		// Token: 0x040228CC RID: 141516
		[Token(Token = "0x40228CC")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, RoguelikeTopicMonthMission> m_monthTaskDict;

		// Token: 0x040228CD RID: 141517
		[Token(Token = "0x40228CD")]
		[FieldOffset(Offset = "0x50")]
		private List<RoguelikeTopicUpdate> m_updateList;

		// Token: 0x040228CE RID: 141518
		[Token(Token = "0x40228CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040228CF RID: 141519
		[Token(Token = "0x40228CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isFinalUpdate;

		// Token: 0x040228D0 RID: 141520
		[Token(Token = "0x40228D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_canRefresh;

		// Token: 0x040228D1 RID: 141521
		[Token(Token = "0x40228D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_showRefreshCount;

		// Token: 0x040228D2 RID: 141522
		[Token(Token = "0x40228D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_updateCountDown;

		// Token: 0x040228D3 RID: 141523
		[Token(Token = "0x40228D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_bpItemName;

		// Token: 0x040228D4 RID: 141524
		[Token(Token = "0x40228D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bpItemSprite;

		// Token: 0x040228D5 RID: 141525
		[Token(Token = "0x40228D5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040228D6 RID: 141526
		[Token(Token = "0x40228D6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x040228D7 RID: 141527
		[Token(Token = "0x40228D7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetFullStoredTime;

		// Token: 0x040228D8 RID: 141528
		[Token(Token = "0x40228D8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateTopicData;

		// Token: 0x040228D9 RID: 141529
		[Token(Token = "0x40228D9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
