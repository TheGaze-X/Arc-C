using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AA2 RID: 31394
	[Token(Token = "0x2007AA2")]
	public class Act12sideZoneDescGroupViewModel
	{
		// Token: 0x17006716 RID: 26390
		// (get) Token: 0x0602BFAB RID: 180139 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BFAC RID: 180140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006716")]
		public string selectedZoneId
		{
			[Token(Token = "0x602BFAB")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BFAC")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006717 RID: 26391
		// (get) Token: 0x0602BFAD RID: 180141 RVA: 0x000DDD60 File Offset: 0x000DBF60
		// (set) Token: 0x0602BFAE RID: 180142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006717")]
		public Act12SideData.ActZoneClass selectedZoneClass
		{
			[Token(Token = "0x602BFAD")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return Act12SideData.ActZoneClass.NONE;
			}
			[Token(Token = "0x602BFAE")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006718 RID: 26392
		// (get) Token: 0x0602BFAF RID: 180143 RVA: 0x000DDD78 File Offset: 0x000DBF78
		// (set) Token: 0x0602BFB0 RID: 180144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006718")]
		public bool isAllTimeOut
		{
			[Token(Token = "0x602BFAF")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602BFB0")]
			[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602BFB1 RID: 180145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFB1")]
		[Address(RVA = "0x27E2D00", Offset = "0x27E1900", VA = "0x1827E2D00")]
		public void LoadData(ActivityBasicInfo actBasicInfo, List<ActivityZoneViewModel> actZoneModels)
		{
		}

		// Token: 0x0602BFB2 RID: 180146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFB2")]
		[Address(RVA = "0x27E3100", Offset = "0x27E1D00", VA = "0x1827E3100")]
		public void SetSelectedZone(string activityId, string zoneId)
		{
		}

		// Token: 0x0602BFB3 RID: 180147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFB3")]
		[Address(RVA = "0x27E32E0", Offset = "0x27E1EE0", VA = "0x1827E32E0")]
		private void _UpdateSelectedZoneClass()
		{
		}

		// Token: 0x0602BFB4 RID: 180148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFB4")]
		[Address(RVA = "0x27E33C0", Offset = "0x27E1FC0", VA = "0x1827E33C0")]
		public Act12sideZoneDescGroupViewModel()
		{
		}

		// Token: 0x0403FB44 RID: 260932
		[Token(Token = "0x403FB44")]
		[FieldOffset(Offset = "0x10")]
		public List<Act12sideZoneDescViewModel> zoneDescModelList;
	}
}
