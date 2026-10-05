using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B3A RID: 31546
	[Token(Token = "0x2007B3A")]
	public class Act10D5ZoneDescGroupViewModel
	{
		// Token: 0x17006774 RID: 26484
		// (get) Token: 0x0602C298 RID: 180888 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C299 RID: 180889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006774")]
		public string selectedZoneId
		{
			[Token(Token = "0x602C298")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C299")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006775 RID: 26485
		// (get) Token: 0x0602C29A RID: 180890 RVA: 0x000DE4C8 File Offset: 0x000DC6C8
		// (set) Token: 0x0602C29B RID: 180891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006775")]
		public bool isAllTimeout
		{
			[Token(Token = "0x602C29A")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C29B")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602C29C RID: 180892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C29C")]
		[Address(RVA = "0x280EB60", Offset = "0x280D760", VA = "0x18280EB60")]
		public void LoadData(ActivityBasicInfo actBasicInfo, List<ActivityZoneViewModel> actZoneModels)
		{
		}

		// Token: 0x0602C29D RID: 180893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C29D")]
		[Address(RVA = "0x280EEB0", Offset = "0x280DAB0", VA = "0x18280EEB0")]
		public void SetSelectedZone(string zoneId)
		{
		}

		// Token: 0x0602C29E RID: 180894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C29E")]
		[Address(RVA = "0x280F000", Offset = "0x280DC00", VA = "0x18280F000")]
		public Act10D5ZoneDescGroupViewModel()
		{
		}

		// Token: 0x0404005A RID: 262234
		[Token(Token = "0x404005A")]
		[FieldOffset(Offset = "0x10")]
		public List<Act10D5ZoneDescViewModel> zoneDescModelList;
	}
}
