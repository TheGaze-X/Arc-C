using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020068B5 RID: 26805
	[Token(Token = "0x20068B5")]
	public class SeasonZoneGroupViewModel : ZoneGroupViewModel
	{
		// Token: 0x17005A99 RID: 23193
		// (get) Token: 0x0602666C RID: 157292 RVA: 0x000CAE00 File Offset: 0x000C9000
		// (set) Token: 0x0602666D RID: 157293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A99")]
		public int focusIndex
		{
			[Token(Token = "0x602666C")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602666D")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602666E RID: 157294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602666E")]
		[Address(RVA = "0x217CA80", Offset = "0x217B680", VA = "0x18217CA80")]
		public void InitData()
		{
		}

		// Token: 0x0602666F RID: 157295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602666F")]
		[Address(RVA = "0x217C980", Offset = "0x217B580", VA = "0x18217C980")]
		public void ApplyCrisisServerData(CrisisV2CacheServerData sharedData)
		{
		}

		// Token: 0x06026670 RID: 157296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026670")]
		[Address(RVA = "0x217D140", Offset = "0x217BD40", VA = "0x18217D140")]
		public void RefreshRecalRunePlayerData()
		{
		}

		// Token: 0x06026671 RID: 157297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026671")]
		[Address(RVA = "0x217D290", Offset = "0x217BE90", VA = "0x18217D290")]
		public SeasonZoneGroupViewModel()
		{
		}

		// Token: 0x04036179 RID: 221561
		[Token(Token = "0x4036179")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<string, StageZoneSeasonEntryViewModel> modelDict;
	}
}
