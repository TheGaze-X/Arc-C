using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Stage;

namespace Torappu.UI.ActivityStage.Extern
{
	// Token: 0x02006D20 RID: 27936
	[Token(Token = "0x2006D20")]
	public abstract class ActivityStageBridge
	{
		// Token: 0x17005E41 RID: 24129
		// (get) Token: 0x06027D68 RID: 163176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E41")]
		public ActivityStageBridge.Core frameworkOnlyCore
		{
			[Token(Token = "0x6027D68")]
			[Address(RVA = "0x22F31F0", Offset = "0x22F1DF0", VA = "0x1822F31F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E42 RID: 24130
		// (get) Token: 0x06027D69 RID: 163177 RVA: 0x000CF9A8 File Offset: 0x000CDBA8
		[Token(Token = "0x17005E42")]
		public ActivityBasicInfo basicInfo
		{
			[Token(Token = "0x6027D69")]
			[Address(RVA = "0x22F30D0", Offset = "0x22F1CD0", VA = "0x1822F30D0")]
			get
			{
				return default(ActivityBasicInfo);
			}
		}

		// Token: 0x17005E43 RID: 24131
		// (get) Token: 0x06027D6A RID: 163178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E43")]
		public ActivityStageController controller
		{
			[Token(Token = "0x6027D6A")]
			[Address(RVA = "0x22F3150", Offset = "0x22F1D50", VA = "0x1822F3150")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027D6B RID: 163179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027D6B")]
		[Address(RVA = "0x22F2F70", Offset = "0x22F1B70", VA = "0x1822F2F70")]
		public List<ActivityZoneViewModel> LoadZones()
		{
			return null;
		}

		// Token: 0x17005E44 RID: 24132
		// (get) Token: 0x06027D6C RID: 163180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E44")]
		public string currentSelectedZone
		{
			[Token(Token = "0x6027D6C")]
			[Address(RVA = "0x22F3180", Offset = "0x22F1D80", VA = "0x1822F3180")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027D6D RID: 163181 RVA: 0x000CF9C0 File Offset: 0x000CDBC0
		[Token(Token = "0x6027D6D")]
		[Address(RVA = "0x22F2F20", Offset = "0x22F1B20", VA = "0x1822F2F20")]
		public bool FocusZone(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06027D6E RID: 163182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D6E")]
		[Address(RVA = "0x22F2EE0", Offset = "0x22F1AE0", VA = "0x1822F2EE0")]
		public void ExitActivity()
		{
		}

		// Token: 0x06027D6F RID: 163183 RVA: 0x000CF9D8 File Offset: 0x000CDBD8
		[Token(Token = "0x6027D6F")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
		public virtual bool CheckBeforeStartBattle(StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x06027D70 RID: 163184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D70")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void OnZoneSelected(string selectedZoneId)
		{
		}

		// Token: 0x06027D71 RID: 163185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D71")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ActivityStageBridge()
		{
		}

		// Token: 0x0403878A RID: 231306
		[Token(Token = "0x403878A")]
		public const float DEFAULT_TWEEN_DURATION = 0.23f;

		// Token: 0x0403878B RID: 231307
		[Token(Token = "0x403878B")]
		[FieldOffset(Offset = "0x10")]
		private ActivityStageBridge.Core m_core;

		// Token: 0x02006D21 RID: 27937
		[Token(Token = "0x2006D21")]
		public class Core
		{
			// Token: 0x06027D72 RID: 163186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027D72")]
			[Address(RVA = "0x22F84B0", Offset = "0x22F70B0", VA = "0x1822F84B0")]
			public Core(ActivityStageBridge closure)
			{
			}

			// Token: 0x17005E45 RID: 24133
			// (get) Token: 0x06027D73 RID: 163187 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027D74 RID: 163188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E45")]
			public Action<List<ActivityZoneViewModel>> getZonesDelegate
			{
				[Token(Token = "0x6027D73")]
				[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027D74")]
				[Address(RVA = "0x22F8A80", Offset = "0x22F7680", VA = "0x1822F8A80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005E46 RID: 24134
			// (get) Token: 0x06027D75 RID: 163189 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027D76 RID: 163190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E46")]
			public Func<string> getCurrentSelectedZoneDelegate
			{
				[Token(Token = "0x6027D75")]
				[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027D76")]
				[Address(RVA = "0x789450", Offset = "0x788050", VA = "0x180789450")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005E47 RID: 24135
			// (get) Token: 0x06027D77 RID: 163191 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027D78 RID: 163192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E47")]
			public Func<string, bool> focusZoneDelegate
			{
				[Token(Token = "0x6027D77")]
				[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027D78")]
				[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005E48 RID: 24136
			// (get) Token: 0x06027D79 RID: 163193 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027D7A RID: 163194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E48")]
			public Func<string, ZoneViewModel> findZoneDelegate
			{
				[Token(Token = "0x6027D79")]
				[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027D7A")]
				[Address(RVA = "0x22F8A60", Offset = "0x22F7660", VA = "0x1822F8A60")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005E49 RID: 24137
			// (get) Token: 0x06027D7B RID: 163195 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027D7C RID: 163196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E49")]
			public Action exitActDelegate
			{
				[Token(Token = "0x6027D7B")]
				[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027D7C")]
				[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005E4A RID: 24138
			// (get) Token: 0x06027D7D RID: 163197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005E4A")]
			public List<ActivityZoneViewModel> zones
			{
				[Token(Token = "0x6027D7D")]
				[Address(RVA = "0x22F8890", Offset = "0x22F7490", VA = "0x1822F8890")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005E4B RID: 24139
			// (get) Token: 0x06027D7E RID: 163198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005E4B")]
			public string currentSelectedZone
			{
				[Token(Token = "0x6027D7E")]
				[Address(RVA = "0x22F87D0", Offset = "0x22F73D0", VA = "0x1822F87D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06027D7F RID: 163199 RVA: 0x000CF9F0 File Offset: 0x000CDBF0
			[Token(Token = "0x6027D7F")]
			[Address(RVA = "0x22F73F0", Offset = "0x22F5FF0", VA = "0x1822F73F0")]
			public bool FocusZone(string targetZoneId)
			{
				return default(bool);
			}

			// Token: 0x06027D80 RID: 163200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027D80")]
			[Address(RVA = "0x22F7B40", Offset = "0x22F6740", VA = "0x1822F7B40")]
			public void NotifyZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x06027D81 RID: 163201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027D81")]
			[Address(RVA = "0x22F73D0", Offset = "0x22F5FD0", VA = "0x1822F73D0")]
			public void ExitActivity()
			{
			}

			// Token: 0x06027D82 RID: 163202 RVA: 0x000CFA08 File Offset: 0x000CDC08
			[Token(Token = "0x6027D82")]
			[Address(RVA = "0x22F7F40", Offset = "0x22F6B40", VA = "0x1822F7F40")]
			private bool _CheckIfRetroZoneUnlock(string retroZoneId)
			{
				return default(bool);
			}

			// Token: 0x0403878C RID: 231308
			[Token(Token = "0x403878C")]
			[FieldOffset(Offset = "0x10")]
			private List<ActivityZoneViewModel> m_zones;

			// Token: 0x0403878D RID: 231309
			[Token(Token = "0x403878D")]
			[FieldOffset(Offset = "0x18")]
			private ActivityStageBridge m_closure;

			// Token: 0x0403878E RID: 231310
			[Token(Token = "0x403878E")]
			[FieldOffset(Offset = "0x20")]
			public ActivityBasicInfo basicInfo;

			// Token: 0x0403878F RID: 231311
			[Token(Token = "0x403878F")]
			[FieldOffset(Offset = "0x98")]
			public ActivityStageController controller;
		}
	}
}
