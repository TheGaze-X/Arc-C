using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066B0 RID: 26288
	[Token(Token = "0x20066B0")]
	public class HandBookCardViewModel : IHotfixable
	{
		// Token: 0x17005970 RID: 22896
		// (get) Token: 0x06025C1A RID: 154650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005970")]
		public string characterKey
		{
			[Token(Token = "0x6025C1A")]
			[Address(RVA = "0x20A1EF0", Offset = "0x20A0AF0", VA = "0x1820A1EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025C1B RID: 154651 RVA: 0x000C8E50 File Offset: 0x000C7050
		[Token(Token = "0x6025C1B")]
		[Address(RVA = "0x20A1A30", Offset = "0x20A0630", VA = "0x1820A1A30")]
		public ProfessionCategory GetProfession()
		{
			return ProfessionCategory.NONE;
		}

		// Token: 0x06025C1C RID: 154652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C1C")]
		[Address(RVA = "0x20A1DD0", Offset = "0x20A09D0", VA = "0x1820A1DD0")]
		public void SetNPCProfession(ProfessionCategory profession)
		{
		}

		// Token: 0x17005971 RID: 22897
		// (get) Token: 0x06025C1D RID: 154653 RVA: 0x000C8E68 File Offset: 0x000C7068
		// (set) Token: 0x06025C1E RID: 154654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005971")]
		public bool hasAudioInfo
		{
			[Token(Token = "0x6025C1D")]
			[Address(RVA = "0x20A1F50", Offset = "0x20A0B50", VA = "0x1820A1F50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025C1E")]
			[Address(RVA = "0x20A2110", Offset = "0x20A0D10", VA = "0x1820A2110")]
			set
			{
			}
		}

		// Token: 0x17005972 RID: 22898
		// (get) Token: 0x06025C1F RID: 154655 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025C20 RID: 154656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005972")]
		public string npcId
		{
			[Token(Token = "0x6025C1F")]
			[Address(RVA = "0x20A2020", Offset = "0x20A0C20", VA = "0x1820A2020")]
			get
			{
				return null;
			}
			[Token(Token = "0x6025C20")]
			[Address(RVA = "0x20A2200", Offset = "0x20A0E00", VA = "0x1820A2200")]
			set
			{
			}
		}

		// Token: 0x17005973 RID: 22899
		// (get) Token: 0x06025C21 RID: 154657 RVA: 0x000C8E80 File Offset: 0x000C7080
		// (set) Token: 0x06025C22 RID: 154658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005973")]
		public IllustNPCResType resType
		{
			[Token(Token = "0x6025C21")]
			[Address(RVA = "0x20A20A0", Offset = "0x20A0CA0", VA = "0x1820A20A0")]
			get
			{
				return IllustNPCResType.NONE;
			}
			[Token(Token = "0x6025C22")]
			[Address(RVA = "0x20A2280", Offset = "0x20A0E80", VA = "0x1820A2280")]
			set
			{
			}
		}

		// Token: 0x17005974 RID: 22900
		// (get) Token: 0x06025C23 RID: 154659 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025C24 RID: 154660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005974")]
		public Sprite logoSprite
		{
			[Token(Token = "0x6025C23")]
			[Address(RVA = "0x20A1FC0", Offset = "0x20A0BC0", VA = "0x1820A1FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025C24")]
			[Address(RVA = "0x20A2180", Offset = "0x20A0D80", VA = "0x1820A2180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06025C25 RID: 154661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C25")]
		[Address(RVA = "0x20A1C70", Offset = "0x20A0870", VA = "0x1820A1C70")]
		public void ReloadCharQuery()
		{
		}

		// Token: 0x06025C26 RID: 154662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C26")]
		[Address(RVA = "0x20A1B20", Offset = "0x20A0720", VA = "0x1820A1B20")]
		public void LoadNecessarySprites()
		{
		}

		// Token: 0x06025C27 RID: 154663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C27")]
		[Address(RVA = "0x20A1E40", Offset = "0x20A0A40", VA = "0x1820A1E40")]
		public HandBookCardViewModel()
		{
		}

		// Token: 0x04035124 RID: 217380
		[Token(Token = "0x4035124")]
		[FieldOffset(Offset = "0x10")]
		private ProfessionCategory m_npcProfession;

		// Token: 0x04035125 RID: 217381
		[Token(Token = "0x4035125")]
		[FieldOffset(Offset = "0x18")]
		public CharQuery charQuery;

		// Token: 0x04035126 RID: 217382
		[Token(Token = "0x4035126")]
		[FieldOffset(Offset = "0x30")]
		public string displayNumber;

		// Token: 0x04035127 RID: 217383
		[Token(Token = "0x4035127")]
		[FieldOffset(Offset = "0x38")]
		public HandBookRank showRank;

		// Token: 0x04035128 RID: 217384
		[Token(Token = "0x4035128")]
		[FieldOffset(Offset = "0x3C")]
		public bool getFlag;

		// Token: 0x04035129 RID: 217385
		[Token(Token = "0x4035129")]
		[FieldOffset(Offset = "0x3D")]
		public bool isNPC;

		// Token: 0x0403512A RID: 217386
		[Token(Token = "0x403512A")]
		[FieldOffset(Offset = "0x40")]
		public string npcIllustId;

		// Token: 0x0403512B RID: 217387
		[Token(Token = "0x403512B")]
		[FieldOffset(Offset = "0x48")]
		private bool m_npcHasAudioInfo;

		// Token: 0x0403512C RID: 217388
		[Token(Token = "0x403512C")]
		[FieldOffset(Offset = "0x50")]
		private string m_npcId;

		// Token: 0x0403512D RID: 217389
		[Token(Token = "0x403512D")]
		[FieldOffset(Offset = "0x58")]
		private IllustNPCResType m_resType;

		// Token: 0x0403512E RID: 217390
		[Token(Token = "0x403512E")]
		[FieldOffset(Offset = "0x5C")]
		public int getConnectFlag;

		// Token: 0x0403512F RID: 217391
		[Token(Token = "0x403512F")]
		[FieldOffset(Offset = "0x60")]
		public string nickName;

		// Token: 0x04035130 RID: 217392
		[Token(Token = "0x4035130")]
		[FieldOffset(Offset = "0x68")]
		public string realName;

		// Token: 0x04035131 RID: 217393
		[Token(Token = "0x4035131")]
		[FieldOffset(Offset = "0x70")]
		public int chrinstID;

		// Token: 0x04035132 RID: 217394
		[Token(Token = "0x4035132")]
		[FieldOffset(Offset = "0x74")]
		public float favorPercent;

		// Token: 0x04035133 RID: 217395
		[Token(Token = "0x4035133")]
		[FieldOffset(Offset = "0x78")]
		public string powerId;

		// Token: 0x04035134 RID: 217396
		[Token(Token = "0x4035134")]
		[FieldOffset(Offset = "0x80")]
		public EvolvePhase maxEvolvePhase;

		// Token: 0x04035135 RID: 217397
		[Token(Token = "0x4035135")]
		[FieldOffset(Offset = "0x84")]
		public int level;

		// Token: 0x04035137 RID: 217399
		[Token(Token = "0x4035137")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterKey;

		// Token: 0x04035138 RID: 217400
		[Token(Token = "0x4035138")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProfession;

		// Token: 0x04035139 RID: 217401
		[Token(Token = "0x4035139")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetNPCProfession;

		// Token: 0x0403513A RID: 217402
		[Token(Token = "0x403513A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasAudioInfo;

		// Token: 0x0403513B RID: 217403
		[Token(Token = "0x403513B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_hasAudioInfo;

		// Token: 0x0403513C RID: 217404
		[Token(Token = "0x403513C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_npcId;

		// Token: 0x0403513D RID: 217405
		[Token(Token = "0x403513D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_npcId;

		// Token: 0x0403513E RID: 217406
		[Token(Token = "0x403513E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_resType;

		// Token: 0x0403513F RID: 217407
		[Token(Token = "0x403513F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_resType;

		// Token: 0x04035140 RID: 217408
		[Token(Token = "0x4035140")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_logoSprite;

		// Token: 0x04035141 RID: 217409
		[Token(Token = "0x4035141")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_logoSprite;

		// Token: 0x04035142 RID: 217410
		[Token(Token = "0x4035142")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ReloadCharQuery;

		// Token: 0x04035143 RID: 217411
		[Token(Token = "0x4035143")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadNecessarySprites;

		// Token: 0x04035144 RID: 217412
		[Token(Token = "0x4035144")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020066B1 RID: 26289
		[Token(Token = "0x20066B1")]
		public enum ResFolder
		{
			// Token: 0x04035146 RID: 217414
			[Token(Token = "0x4035146")]
			NPC,
			// Token: 0x04035147 RID: 217415
			[Token(Token = "0x4035147")]
			CHAR
		}
	}
}
