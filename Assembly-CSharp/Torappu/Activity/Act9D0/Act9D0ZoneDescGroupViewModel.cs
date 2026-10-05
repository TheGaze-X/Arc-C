using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200718A RID: 29066
	[Token(Token = "0x200718A")]
	public class Act9D0ZoneDescGroupViewModel
	{
		// Token: 0x170061A8 RID: 25000
		// (get) Token: 0x06029414 RID: 168980 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029415 RID: 168981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061A8")]
		public string selectedZoneId
		{
			[Token(Token = "0x6029414")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6029415")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061A9 RID: 25001
		// (get) Token: 0x06029416 RID: 168982 RVA: 0x000D4E68 File Offset: 0x000D3068
		// (set) Token: 0x06029417 RID: 168983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061A9")]
		public bool isAllTimeout
		{
			[Token(Token = "0x6029416")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6029417")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06029418 RID: 168984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029418")]
		[Address(RVA = "0x24A5D60", Offset = "0x24A4960", VA = "0x1824A5D60")]
		public void LoadData(ActivityBasicInfo actBasicInfo, List<ActivityZoneViewModel> actZoneModels)
		{
		}

		// Token: 0x06029419 RID: 168985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029419")]
		[Address(RVA = "0x24A60D0", Offset = "0x24A4CD0", VA = "0x1824A60D0")]
		public void SetSelectedZone(string zoneId)
		{
		}

		// Token: 0x0602941A RID: 168986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602941A")]
		[Address(RVA = "0x24A61C0", Offset = "0x24A4DC0", VA = "0x1824A61C0")]
		public Act9D0ZoneDescGroupViewModel()
		{
		}

		// Token: 0x0403AEC7 RID: 241351
		[Token(Token = "0x403AEC7")]
		[FieldOffset(Offset = "0x10")]
		public List<Act9D0ZoneDescViewModel> zoneDescModelList;
	}
}
