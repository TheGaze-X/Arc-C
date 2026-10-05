using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C74 RID: 27764
	[Token(Token = "0x2006C74")]
	public class Act13sideZoneDescGroupViewModel
	{
		// Token: 0x17005DA6 RID: 23974
		// (get) Token: 0x06027A09 RID: 162313 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027A0A RID: 162314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005DA6")]
		public string selectedZoneId
		{
			[Token(Token = "0x6027A09")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027A0A")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005DA7 RID: 23975
		// (get) Token: 0x06027A0B RID: 162315 RVA: 0x000CEEC8 File Offset: 0x000CD0C8
		// (set) Token: 0x06027A0C RID: 162316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005DA7")]
		public Act13SideData.ActZoneClass selectedZoneClass
		{
			[Token(Token = "0x6027A0B")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return Act13SideData.ActZoneClass.NONE;
			}
			[Token(Token = "0x6027A0C")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005DA8 RID: 23976
		// (get) Token: 0x06027A0D RID: 162317 RVA: 0x000CEEE0 File Offset: 0x000CD0E0
		// (set) Token: 0x06027A0E RID: 162318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005DA8")]
		public bool isAllTimeOut
		{
			[Token(Token = "0x6027A0D")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6027A0E")]
			[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06027A0F RID: 162319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A0F")]
		[Address(RVA = "0x22BD140", Offset = "0x22BBD40", VA = "0x1822BD140")]
		public void LoadData(ActivityBasicInfo actBasicInfo, List<ActivityZoneViewModel> actZoneModels)
		{
		}

		// Token: 0x06027A10 RID: 162320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A10")]
		[Address(RVA = "0x22BD520", Offset = "0x22BC120", VA = "0x1822BD520")]
		public void SetSelectedZone(string activityId, string zoneId)
		{
		}

		// Token: 0x06027A11 RID: 162321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A11")]
		[Address(RVA = "0x22BD6F0", Offset = "0x22BC2F0", VA = "0x1822BD6F0")]
		private void _UpdateSelectedZoneClass()
		{
		}

		// Token: 0x06027A12 RID: 162322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A12")]
		[Address(RVA = "0x22BD7D0", Offset = "0x22BC3D0", VA = "0x1822BD7D0")]
		public Act13sideZoneDescGroupViewModel()
		{
		}

		// Token: 0x0403833B RID: 230203
		[Token(Token = "0x403833B")]
		[FieldOffset(Offset = "0x10")]
		public List<Act13sideZoneDescViewModel> zoneDescModelList;
	}
}
