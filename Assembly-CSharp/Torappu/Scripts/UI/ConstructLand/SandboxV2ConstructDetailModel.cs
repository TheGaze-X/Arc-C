using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;

namespace Torappu.Scripts.UI.ConstructLand
{
	// Token: 0x020017A7 RID: 6055
	[Token(Token = "0x20017A7")]
	public class SandboxV2ConstructDetailModel : ISandboxV2BuildingDetail
	{
		// Token: 0x060098FC RID: 39164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098FC")]
		[Address(RVA = "0x3149070", Offset = "0x3147C70", VA = "0x183149070")]
		public void SetUI(bool isHide, SandboxV2ConstructDetailModel.HideUIReasonMask reasonMask)
		{
		}

		// Token: 0x060098FD RID: 39165 RVA: 0x0003B898 File Offset: 0x00039A98
		[Token(Token = "0x60098FD")]
		[Address(RVA = "0x3148470", Offset = "0x3147070", VA = "0x183148470", Slot = "4")]
		public bool IsConstructTipSelected(SandboxV2ConstructTipType tipType)
		{
			return default(bool);
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x0003B8B0 File Offset: 0x00039AB0
		[Token(Token = "0x60098FE")]
		[Address(RVA = "0x31483F0", Offset = "0x3146FF0", VA = "0x1831483F0", Slot = "5")]
		public int GetConstructTipCount(SandboxV2ConstructTipType tipType)
		{
			return 0;
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098FF")]
		[Address(RVA = "0x31484A0", Offset = "0x31470A0", VA = "0x1831484A0", Slot = "6")]
		public IEnumerable<SandboxV2DungeonBuildingTrapInfo> IterBuildingTrapInfo()
		{
			return null;
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x0003B8C8 File Offset: 0x00039AC8
		[Token(Token = "0x6009900")]
		[Address(RVA = "0x3148420", Offset = "0x3147020", VA = "0x183148420", Slot = "7")]
		public bool IsBuildingDetailEmpty()
		{
			return default(bool);
		}

		// Token: 0x06009901 RID: 39169 RVA: 0x0003B8E0 File Offset: 0x00039AE0
		[Token(Token = "0x6009901")]
		[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "8")]
		public SandboxV2NodeType GetNodeType()
		{
			return SandboxV2NodeType.NONE;
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009902")]
		[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "9")]
		public string GetNodeTypeName()
		{
			return null;
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009903")]
		[Address(RVA = "0x3148520", Offset = "0x3147120", VA = "0x183148520")]
		public void LoadData()
		{
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009904")]
		[Address(RVA = "0x3149090", Offset = "0x3147C90", VA = "0x183149090")]
		public SandboxV2ConstructDetailModel()
		{
		}

		// Token: 0x04008F19 RID: 36633
		[Token(Token = "0x4008F19")]
		[FieldOffset(Offset = "0x10")]
		public int hideUI;

		// Token: 0x04008F1A RID: 36634
		[Token(Token = "0x4008F1A")]
		[FieldOffset(Offset = "0x18")]
		public int[] tipsSum;

		// Token: 0x04008F1B RID: 36635
		[Token(Token = "0x4008F1B")]
		[FieldOffset(Offset = "0x20")]
		public bool isDetailOn;

		// Token: 0x04008F1C RID: 36636
		[Token(Token = "0x4008F1C")]
		[FieldOffset(Offset = "0x28")]
		public bool[] tipsOnClicked;

		// Token: 0x04008F1D RID: 36637
		[Token(Token = "0x4008F1D")]
		[FieldOffset(Offset = "0x30")]
		public int currentGoldCnt;

		// Token: 0x04008F1E RID: 36638
		[Token(Token = "0x4008F1E")]
		[FieldOffset(Offset = "0x34")]
		public int goldRequired;

		// Token: 0x04008F1F RID: 36639
		[Token(Token = "0x4008F1F")]
		[FieldOffset(Offset = "0x38")]
		public SandboxV2NodeType nodeType;

		// Token: 0x04008F20 RID: 36640
		[Token(Token = "0x4008F20")]
		[FieldOffset(Offset = "0x40")]
		public string nodeTypeName;

		// Token: 0x04008F21 RID: 36641
		[Token(Token = "0x4008F21")]
		[FieldOffset(Offset = "0x48")]
		public string topicId;

		// Token: 0x04008F22 RID: 36642
		[Token(Token = "0x4008F22")]
		[FieldOffset(Offset = "0x50")]
		public string nodeId;

		// Token: 0x04008F23 RID: 36643
		[Token(Token = "0x4008F23")]
		[FieldOffset(Offset = "0x58")]
		public ListDict<string, SandboxV2DungeonBuildingTrapInfo> buildingDic;

		// Token: 0x04008F24 RID: 36644
		[Token(Token = "0x4008F24")]
		[FieldOffset(Offset = "0x60")]
		private List<SandboxV2ConstructTipType> m_buildingTipCache;

		// Token: 0x04008F25 RID: 36645
		[Token(Token = "0x4008F25")]
		[FieldOffset(Offset = "0x68")]
		private ListDict<string, int> m_upgradeCache;

		// Token: 0x020017A8 RID: 6056
		[Token(Token = "0x20017A8")]
		public enum HideUIReasonMask
		{
			// Token: 0x04008F27 RID: 36647
			[Token(Token = "0x4008F27")]
			NONE,
			// Token: 0x04008F28 RID: 36648
			[Token(Token = "0x4008F28")]
			IN_HIDE_STATE,
			// Token: 0x04008F29 RID: 36649
			[Token(Token = "0x4008F29")]
			PRESSED_HIDE_UI,
			// Token: 0x04008F2A RID: 36650
			[Token(Token = "0x4008F2A")]
			GAME_NOT_READY
		}
	}
}
