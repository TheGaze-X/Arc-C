using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041C1 RID: 16833
	[Token(Token = "0x20041C1")]
	public class SandboxV2DungeonMonthModel : IHotfixable
	{
		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x06019F37 RID: 106295 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019F38 RID: 106296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DD0")]
		public string topic
		{
			[Token(Token = "0x6019F37")]
			[Address(RVA = "0x12DB530", Offset = "0x12DA130", VA = "0x1812DB530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019F38")]
			[Address(RVA = "0x12DB8B0", Offset = "0x12DA4B0", VA = "0x1812DB8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x06019F39 RID: 106297 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019F3A RID: 106298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DD1")]
		public List<SandboxV2DungeonMonthModel.RushModel> allRushes
		{
			[Token(Token = "0x6019F39")]
			[Address(RVA = "0x12DB240", Offset = "0x12D9E40", VA = "0x1812DB240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019F3A")]
			[Address(RVA = "0x12DB660", Offset = "0x12DA260", VA = "0x1812DB660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x06019F3B RID: 106299 RVA: 0x0009FD20 File Offset: 0x0009DF20
		// (set) Token: 0x06019F3C RID: 106300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DD2")]
		public int activeRushIdx
		{
			[Token(Token = "0x6019F3B")]
			[Address(RVA = "0x12DB1E0", Offset = "0x12D9DE0", VA = "0x1812DB1E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019F3C")]
			[Address(RVA = "0x12DB5F0", Offset = "0x12DA1F0", VA = "0x1812DB5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x06019F3D RID: 106301 RVA: 0x0009FD38 File Offset: 0x0009DF38
		// (set) Token: 0x06019F3E RID: 106302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DD3")]
		public int selectedRushIdx
		{
			[Token(Token = "0x6019F3D")]
			[Address(RVA = "0x12DB4D0", Offset = "0x12DA0D0", VA = "0x1812DB4D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019F3E")]
			[Address(RVA = "0x12DB840", Offset = "0x12DA440", VA = "0x1812DB840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x06019F3F RID: 106303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DD4")]
		public SandboxV2DungeonMonthModel.RushModel selectdRush
		{
			[Token(Token = "0x6019F3F")]
			[Address(RVA = "0x12DB3C0", Offset = "0x12D9FC0", VA = "0x1812DB3C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x06019F40 RID: 106304 RVA: 0x0009FD50 File Offset: 0x0009DF50
		// (set) Token: 0x06019F41 RID: 106305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DD5")]
		public TimeSpan remainTime
		{
			[Token(Token = "0x6019F40")]
			[Address(RVA = "0x12DB360", Offset = "0x12D9F60", VA = "0x1812DB360")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6019F41")]
			[Address(RVA = "0x12DB7D0", Offset = "0x12DA3D0", VA = "0x1812DB7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x06019F42 RID: 106306 RVA: 0x0009FD68 File Offset: 0x0009DF68
		// (set) Token: 0x06019F43 RID: 106307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DD6")]
		public SandboxV2DungeonMonthModel.UpdateStatus updateStatus
		{
			[Token(Token = "0x6019F42")]
			[Address(RVA = "0x12DB590", Offset = "0x12DA190", VA = "0x1812DB590")]
			[CompilerGenerated]
			get
			{
				return SandboxV2DungeonMonthModel.UpdateStatus.NORMAL;
			}
			[Token(Token = "0x6019F43")]
			[Address(RVA = "0x12DB930", Offset = "0x12DA530", VA = "0x1812DB930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x06019F44 RID: 106308 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019F45 RID: 106309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DD7")]
		public string desc
		{
			[Token(Token = "0x6019F44")]
			[Address(RVA = "0x12DB2A0", Offset = "0x12D9EA0", VA = "0x1812DB2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019F45")]
			[Address(RVA = "0x12DB6E0", Offset = "0x12DA2E0", VA = "0x1812DB6E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x06019F46 RID: 106310 RVA: 0x0009FD80 File Offset: 0x0009DF80
		// (set) Token: 0x06019F47 RID: 106311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DD8")]
		public float portableHomeHpRatio
		{
			[Token(Token = "0x6019F46")]
			[Address(RVA = "0x12DB300", Offset = "0x12D9F00", VA = "0x1812DB300")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6019F47")]
			[Address(RVA = "0x12DB760", Offset = "0x12DA360", VA = "0x1812DB760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06019F48 RID: 106312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F48")]
		[Address(RVA = "0x12DA1A0", Offset = "0x12D8DA0", VA = "0x1812DA1A0")]
		public void Load(string topicId, SandboxV2DungeonHomePortableNodeViewModel portableHomeModel)
		{
		}

		// Token: 0x06019F49 RID: 106313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F49")]
		[Address(RVA = "0x12D9C70", Offset = "0x12D8870", VA = "0x1812D9C70")]
		public List<string> LoadEnemyIdListByRushGroup(string rushGroupKey)
		{
			return null;
		}

		// Token: 0x06019F4A RID: 106314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F4A")]
		[Address(RVA = "0x12DAB90", Offset = "0x12D9790", VA = "0x1812DAB90")]
		public void NextRush()
		{
		}

		// Token: 0x06019F4B RID: 106315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F4B")]
		[Address(RVA = "0x12DABF0", Offset = "0x12D97F0", VA = "0x1812DABF0")]
		public void PrevRush()
		{
		}

		// Token: 0x06019F4C RID: 106316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F4C")]
		[Address(RVA = "0x12DAD70", Offset = "0x12D9970", VA = "0x1812DAD70")]
		public void TryToSelectRushById(string rushId)
		{
		}

		// Token: 0x06019F4D RID: 106317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F4D")]
		[Address(RVA = "0x12DAC50", Offset = "0x12D9850", VA = "0x1812DAC50")]
		public void TryToSelectCurrentMonthRush()
		{
		}

		// Token: 0x06019F4E RID: 106318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F4E")]
		[Address(RVA = "0x12DB0B0", Offset = "0x12D9CB0", VA = "0x1812DB0B0")]
		private void _SelectByOffset(int offset)
		{
		}

		// Token: 0x06019F4F RID: 106319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F4F")]
		[Address(RVA = "0x12DAF10", Offset = "0x12D9B10", VA = "0x1812DAF10")]
		private void _SelectByIndex(int index)
		{
		}

		// Token: 0x06019F50 RID: 106320 RVA: 0x0009FD98 File Offset: 0x0009DF98
		[Token(Token = "0x6019F50")]
		[Address(RVA = "0x12D9860", Offset = "0x12D8460", VA = "0x1812D9860")]
		public static SandboxV2DungeonMonthBrief CalculateMonthBrief(PlayerSandboxV2 playerData, SandboxV2Data dataBase)
		{
			return default(SandboxV2DungeonMonthBrief);
		}

		// Token: 0x06019F51 RID: 106321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F51")]
		[Address(RVA = "0x12DB180", Offset = "0x12D9D80", VA = "0x1812DB180")]
		public SandboxV2DungeonMonthModel()
		{
		}

		// Token: 0x04020AF0 RID: 133872
		[Token(Token = "0x4020AF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topic;

		// Token: 0x04020AF1 RID: 133873
		[Token(Token = "0x4020AF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topic;

		// Token: 0x04020AF2 RID: 133874
		[Token(Token = "0x4020AF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_allRushes;

		// Token: 0x04020AF3 RID: 133875
		[Token(Token = "0x4020AF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_allRushes;

		// Token: 0x04020AF4 RID: 133876
		[Token(Token = "0x4020AF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_activeRushIdx;

		// Token: 0x04020AF5 RID: 133877
		[Token(Token = "0x4020AF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_activeRushIdx;

		// Token: 0x04020AF6 RID: 133878
		[Token(Token = "0x4020AF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectedRushIdx;

		// Token: 0x04020AF7 RID: 133879
		[Token(Token = "0x4020AF7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_selectedRushIdx;

		// Token: 0x04020AF8 RID: 133880
		[Token(Token = "0x4020AF8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectdRush;

		// Token: 0x04020AF9 RID: 133881
		[Token(Token = "0x4020AF9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_remainTime;

		// Token: 0x04020AFA RID: 133882
		[Token(Token = "0x4020AFA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_remainTime;

		// Token: 0x04020AFB RID: 133883
		[Token(Token = "0x4020AFB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_updateStatus;

		// Token: 0x04020AFC RID: 133884
		[Token(Token = "0x4020AFC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_updateStatus;

		// Token: 0x04020AFD RID: 133885
		[Token(Token = "0x4020AFD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x04020AFE RID: 133886
		[Token(Token = "0x4020AFE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x04020AFF RID: 133887
		[Token(Token = "0x4020AFF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_portableHomeHpRatio;

		// Token: 0x04020B00 RID: 133888
		[Token(Token = "0x4020B00")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_portableHomeHpRatio;

		// Token: 0x04020B01 RID: 133889
		[Token(Token = "0x4020B01")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04020B02 RID: 133890
		[Token(Token = "0x4020B02")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadEnemyIdListByRushGroup;

		// Token: 0x04020B03 RID: 133891
		[Token(Token = "0x4020B03")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_NextRush;

		// Token: 0x04020B04 RID: 133892
		[Token(Token = "0x4020B04")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_PrevRush;

		// Token: 0x04020B05 RID: 133893
		[Token(Token = "0x4020B05")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryToSelectRushById;

		// Token: 0x04020B06 RID: 133894
		[Token(Token = "0x4020B06")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_TryToSelectCurrentMonthRush;

		// Token: 0x04020B07 RID: 133895
		[Token(Token = "0x4020B07")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SelectByOffset;

		// Token: 0x04020B08 RID: 133896
		[Token(Token = "0x4020B08")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__SelectByIndex;

		// Token: 0x04020B09 RID: 133897
		[Token(Token = "0x4020B09")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CalculateMonthBrief;

		// Token: 0x04020B0A RID: 133898
		[Token(Token = "0x4020B0A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041C2 RID: 16834
		[Token(Token = "0x20041C2")]
		public class RushModel
		{
			// Token: 0x06019F52 RID: 106322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019F52")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RushModel()
			{
			}

			// Token: 0x04020B0B RID: 133899
			[Token(Token = "0x4020B0B")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2MonthRushData db;

			// Token: 0x04020B0C RID: 133900
			[Token(Token = "0x4020B0C")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2WeatherData weatherDB;

			// Token: 0x04020B0D RID: 133901
			[Token(Token = "0x4020B0D")]
			[FieldOffset(Offset = "0x20")]
			public bool complete;

			// Token: 0x04020B0E RID: 133902
			[Token(Token = "0x4020B0E")]
			[FieldOffset(Offset = "0x28")]
			public List<UIItemViewModel> rewardList;
		}

		// Token: 0x020041C3 RID: 16835
		[Token(Token = "0x20041C3")]
		public enum UpdateStatus
		{
			// Token: 0x04020B10 RID: 133904
			[Token(Token = "0x4020B10")]
			NORMAL,
			// Token: 0x04020B11 RID: 133905
			[Token(Token = "0x4020B11")]
			LAST,
			// Token: 0x04020B12 RID: 133906
			[Token(Token = "0x4020B12")]
			COMPLETE
		}
	}
}
