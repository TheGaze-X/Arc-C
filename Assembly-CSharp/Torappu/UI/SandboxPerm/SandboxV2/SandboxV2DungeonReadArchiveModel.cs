using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041B7 RID: 16823
	[Token(Token = "0x20041B7")]
	public class SandboxV2DungeonReadArchiveModel : IHotfixable
	{
		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x06019F0E RID: 106254 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019F0F RID: 106255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DC8")]
		public string topicId
		{
			[Token(Token = "0x6019F0E")]
			[Address(RVA = "0x12E15D0", Offset = "0x12E01D0", VA = "0x1812E15D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019F0F")]
			[Address(RVA = "0x12E1870", Offset = "0x12E0470", VA = "0x1812E1870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x06019F10 RID: 106256 RVA: 0x0009FCA8 File Offset: 0x0009DEA8
		// (set) Token: 0x06019F11 RID: 106257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DC9")]
		public int curSelectingDay
		{
			[Token(Token = "0x6019F10")]
			[Address(RVA = "0x12E13F0", Offset = "0x12DFFF0", VA = "0x1812E13F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019F11")]
			[Address(RVA = "0x12E1630", Offset = "0x12E0230", VA = "0x1812E1630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x06019F12 RID: 106258 RVA: 0x0009FCC0 File Offset: 0x0009DEC0
		// (set) Token: 0x06019F13 RID: 106259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DCA")]
		public int savesCount
		{
			[Token(Token = "0x6019F12")]
			[Address(RVA = "0x12E14B0", Offset = "0x12E00B0", VA = "0x1812E14B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019F13")]
			[Address(RVA = "0x12E1710", Offset = "0x12E0310", VA = "0x1812E1710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x06019F14 RID: 106260 RVA: 0x0009FCD8 File Offset: 0x0009DED8
		// (set) Token: 0x06019F15 RID: 106261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DCB")]
		public int selectIndex
		{
			[Token(Token = "0x6019F14")]
			[Address(RVA = "0x12E1510", Offset = "0x12E0110", VA = "0x1812E1510")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019F15")]
			[Address(RVA = "0x12E1780", Offset = "0x12E0380", VA = "0x1812E1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x06019F16 RID: 106262 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019F17 RID: 106263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DCC")]
		public string surviveDayTxt
		{
			[Token(Token = "0x6019F16")]
			[Address(RVA = "0x12E1570", Offset = "0x12E0170", VA = "0x1812E1570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019F17")]
			[Address(RVA = "0x12E17F0", Offset = "0x12E03F0", VA = "0x1812E17F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x06019F18 RID: 106264 RVA: 0x0009FCF0 File Offset: 0x0009DEF0
		// (set) Token: 0x06019F19 RID: 106265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DCD")]
		public SandboxV2DungeonReadArchiveType readArchiveType
		{
			[Token(Token = "0x6019F18")]
			[Address(RVA = "0x12E1450", Offset = "0x12E0050", VA = "0x1812E1450")]
			[CompilerGenerated]
			get
			{
				return SandboxV2DungeonReadArchiveType.NONE;
			}
			[Token(Token = "0x6019F19")]
			[Address(RVA = "0x12E16A0", Offset = "0x12E02A0", VA = "0x1812E16A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x06019F1A RID: 106266 RVA: 0x0009FD08 File Offset: 0x0009DF08
		[Token(Token = "0x17003DCE")]
		public SandboxV2DungeonReadArchiveCurDayInfoItemData curDayInfoItemData
		{
			[Token(Token = "0x6019F1A")]
			[Address(RVA = "0x12E1370", Offset = "0x12DFF70", VA = "0x1812E1370")]
			get
			{
				return default(SandboxV2DungeonReadArchiveCurDayInfoItemData);
			}
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x06019F1B RID: 106267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DCF")]
		public List<SandboxV2DungeonReadArchiveItemModel> archiveItems
		{
			[Token(Token = "0x6019F1B")]
			[Address(RVA = "0x12E1310", Offset = "0x12DFF10", VA = "0x1812E1310")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019F1C RID: 106268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F1C")]
		[Address(RVA = "0x12E0890", Offset = "0x12DF490", VA = "0x1812E0890")]
		public void LoadData(string topic, SandboxV2DungeonReadArchiveType type)
		{
		}

		// Token: 0x06019F1D RID: 106269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F1D")]
		[Address(RVA = "0x12E0D30", Offset = "0x12DF930", VA = "0x1812E0D30")]
		public void SelectDay(int day)
		{
		}

		// Token: 0x06019F1E RID: 106270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F1E")]
		[Address(RVA = "0x12E0EC0", Offset = "0x12DFAC0", VA = "0x1812E0EC0")]
		public void UnSelectDay()
		{
		}

		// Token: 0x06019F1F RID: 106271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F1F")]
		[Address(RVA = "0x12E1100", Offset = "0x12DFD00", VA = "0x1812E1100")]
		private void _RefreshSelectType(int day)
		{
		}

		// Token: 0x06019F20 RID: 106272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F20")]
		[Address(RVA = "0x12E0FC0", Offset = "0x12DFBC0", VA = "0x1812E0FC0")]
		private void _AddArchiveItemModel(PlayerSandboxV2.Save save, SandboxV2GameConst gameConst)
		{
		}

		// Token: 0x06019F21 RID: 106273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F21")]
		[Address(RVA = "0x12E1250", Offset = "0x12DFE50", VA = "0x1812E1250")]
		public SandboxV2DungeonReadArchiveModel()
		{
		}

		// Token: 0x04020A9E RID: 133790
		[Token(Token = "0x4020A9E")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2DungeonReadArchiveCurDayInfoItemData m_curDayInfoItemData;

		// Token: 0x04020A9F RID: 133791
		[Token(Token = "0x4020A9F")]
		[FieldOffset(Offset = "0x50")]
		private List<SandboxV2DungeonReadArchiveItemModel> m_archiveItems;

		// Token: 0x04020AA0 RID: 133792
		[Token(Token = "0x4020AA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04020AA1 RID: 133793
		[Token(Token = "0x4020AA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04020AA2 RID: 133794
		[Token(Token = "0x4020AA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_curSelectingDay;

		// Token: 0x04020AA3 RID: 133795
		[Token(Token = "0x4020AA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_curSelectingDay;

		// Token: 0x04020AA4 RID: 133796
		[Token(Token = "0x4020AA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_savesCount;

		// Token: 0x04020AA5 RID: 133797
		[Token(Token = "0x4020AA5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_savesCount;

		// Token: 0x04020AA6 RID: 133798
		[Token(Token = "0x4020AA6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectIndex;

		// Token: 0x04020AA7 RID: 133799
		[Token(Token = "0x4020AA7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_selectIndex;

		// Token: 0x04020AA8 RID: 133800
		[Token(Token = "0x4020AA8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_surviveDayTxt;

		// Token: 0x04020AA9 RID: 133801
		[Token(Token = "0x4020AA9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_surviveDayTxt;

		// Token: 0x04020AAA RID: 133802
		[Token(Token = "0x4020AAA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_readArchiveType;

		// Token: 0x04020AAB RID: 133803
		[Token(Token = "0x4020AAB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_readArchiveType;

		// Token: 0x04020AAC RID: 133804
		[Token(Token = "0x4020AAC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_curDayInfoItemData;

		// Token: 0x04020AAD RID: 133805
		[Token(Token = "0x4020AAD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_archiveItems;

		// Token: 0x04020AAE RID: 133806
		[Token(Token = "0x4020AAE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04020AAF RID: 133807
		[Token(Token = "0x4020AAF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SelectDay;

		// Token: 0x04020AB0 RID: 133808
		[Token(Token = "0x4020AB0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UnSelectDay;

		// Token: 0x04020AB1 RID: 133809
		[Token(Token = "0x4020AB1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RefreshSelectType;

		// Token: 0x04020AB2 RID: 133810
		[Token(Token = "0x4020AB2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__AddArchiveItemModel;

		// Token: 0x04020AB3 RID: 133811
		[Token(Token = "0x4020AB3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
