using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042D3 RID: 17107
	[Token(Token = "0x20042D3")]
	public class SandboxV2DungeonHomePortableNodeViewModel : SandboxV2DungeonConstructNodeViewModel
	{
		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x0601A528 RID: 107816 RVA: 0x000A1370 File Offset: 0x0009F570
		// (set) Token: 0x0601A529 RID: 107817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E70")]
		public SandboxV2DungeonMonthBrief monthBriefInfo
		{
			[Token(Token = "0x601A528")]
			[Address(RVA = "0x132E720", Offset = "0x132D320", VA = "0x18132E720")]
			[CompilerGenerated]
			get
			{
				return default(SandboxV2DungeonMonthBrief);
			}
			[Token(Token = "0x601A529")]
			[Address(RVA = "0x132E7A0", Offset = "0x132D3A0", VA = "0x18132E7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601A52A RID: 107818 RVA: 0x000A1388 File Offset: 0x0009F588
		[Token(Token = "0x601A52A")]
		[Address(RVA = "0x132E2D0", Offset = "0x132CED0", VA = "0x18132E2D0", Slot = "7")]
		protected override bool CanSelectWhenEmergency()
		{
			return default(bool);
		}

		// Token: 0x0601A52B RID: 107819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A52B")]
		[Address(RVA = "0x132E3A0", Offset = "0x132CFA0", VA = "0x18132E3A0", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A52C RID: 107820 RVA: 0x000A13A0 File Offset: 0x0009F5A0
		[Token(Token = "0x601A52C")]
		[Address(RVA = "0x132E330", Offset = "0x132CF30", VA = "0x18132E330", Slot = "21")]
		protected override bool SupportBuildingTrapType(SandboxV2TrapItemType buildingTrapType)
		{
			return default(bool);
		}

		// Token: 0x0601A52D RID: 107821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A52D")]
		[Address(RVA = "0x132E6C0", Offset = "0x132D2C0", VA = "0x18132E6C0")]
		public SandboxV2DungeonHomePortableNodeViewModel()
		{
		}

		// Token: 0x0601A52E RID: 107822 RVA: 0x000A13B8 File Offset: 0x0009F5B8
		[Token(Token = "0x601A52E")]
		[Address(RVA = "0x132DF50", Offset = "0x132CB50", VA = "0x18132DF50")]
		private bool <>xLuaBaseProxy_CanSelectWhenEmergency()
		{
			return default(bool);
		}

		// Token: 0x0601A52F RID: 107823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A52F")]
		[Address(RVA = "0x132A1F0", Offset = "0x1328DF0", VA = "0x18132A1F0")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x040215C9 RID: 136649
		[Token(Token = "0x40215C9")]
		private const float PORTABLE_SEVERELY_DAMAGED_THRESHOLD = 0.25f;

		// Token: 0x040215CB RID: 136651
		[Token(Token = "0x40215CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_monthBriefInfo;

		// Token: 0x040215CC RID: 136652
		[Token(Token = "0x40215CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_monthBriefInfo;

		// Token: 0x040215CD RID: 136653
		[Token(Token = "0x40215CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CanSelectWhenEmergency;

		// Token: 0x040215CE RID: 136654
		[Token(Token = "0x40215CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x040215CF RID: 136655
		[Token(Token = "0x40215CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SupportBuildingTrapType;

		// Token: 0x040215D0 RID: 136656
		[Token(Token = "0x40215D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
