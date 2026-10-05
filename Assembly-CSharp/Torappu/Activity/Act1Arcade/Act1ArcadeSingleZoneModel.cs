using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007982 RID: 31106
	[Token(Token = "0x2007982")]
	public class Act1ArcadeSingleZoneModel : IHotfixable
	{
		// Token: 0x1700665A RID: 26202
		// (get) Token: 0x0602BA37 RID: 178743 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BA38 RID: 178744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700665A")]
		public string actId
		{
			[Token(Token = "0x602BA37")]
			[Address(RVA = "0x2787770", Offset = "0x2786370", VA = "0x182787770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BA38")]
			[Address(RVA = "0x2787B30", Offset = "0x2786730", VA = "0x182787B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700665B RID: 26203
		// (get) Token: 0x0602BA39 RID: 178745 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BA3A RID: 178746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700665B")]
		public string zoneId
		{
			[Token(Token = "0x602BA39")]
			[Address(RVA = "0x2787A10", Offset = "0x2786610", VA = "0x182787A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BA3A")]
			[Address(RVA = "0x2787E80", Offset = "0x2786A80", VA = "0x182787E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700665C RID: 26204
		// (get) Token: 0x0602BA3B RID: 178747 RVA: 0x000DCB78 File Offset: 0x000DAD78
		// (set) Token: 0x0602BA3C RID: 178748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700665C")]
		public int sortId
		{
			[Token(Token = "0x602BA3B")]
			[Address(RVA = "0x27877D0", Offset = "0x27863D0", VA = "0x1827877D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602BA3C")]
			[Address(RVA = "0x2787BB0", Offset = "0x27867B0", VA = "0x182787BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700665D RID: 26205
		// (get) Token: 0x0602BA3D RID: 178749 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BA3E RID: 178750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700665D")]
		public string zoneEntryPicId
		{
			[Token(Token = "0x602BA3D")]
			[Address(RVA = "0x27879B0", Offset = "0x27865B0", VA = "0x1827879B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BA3E")]
			[Address(RVA = "0x2787E00", Offset = "0x2786A00", VA = "0x182787E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700665E RID: 26206
		// (get) Token: 0x0602BA3F RID: 178751 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BA40 RID: 178752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700665E")]
		public string stageInfoPrefabId
		{
			[Token(Token = "0x602BA3F")]
			[Address(RVA = "0x2787830", Offset = "0x2786430", VA = "0x182787830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BA40")]
			[Address(RVA = "0x2787C20", Offset = "0x2786820", VA = "0x182787C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700665F RID: 26207
		// (get) Token: 0x0602BA41 RID: 178753 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BA42 RID: 178754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700665F")]
		public List<string> stages
		{
			[Token(Token = "0x602BA41")]
			[Address(RVA = "0x2787890", Offset = "0x2786490", VA = "0x182787890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BA42")]
			[Address(RVA = "0x2787CA0", Offset = "0x27868A0", VA = "0x182787CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006660 RID: 26208
		// (get) Token: 0x0602BA43 RID: 178755 RVA: 0x000DCB90 File Offset: 0x000DAD90
		// (set) Token: 0x0602BA44 RID: 178756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006660")]
		public ActArcadeData.SubModeType subModeType
		{
			[Token(Token = "0x602BA43")]
			[Address(RVA = "0x27878F0", Offset = "0x27864F0", VA = "0x1827878F0")]
			[CompilerGenerated]
			get
			{
				return ActArcadeData.SubModeType.MINER;
			}
			[Token(Token = "0x602BA44")]
			[Address(RVA = "0x2787D20", Offset = "0x2786920", VA = "0x182787D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006661 RID: 26209
		// (get) Token: 0x0602BA45 RID: 178757 RVA: 0x000DCBA8 File Offset: 0x000DADA8
		// (set) Token: 0x0602BA46 RID: 178758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006661")]
		public Act1ArcadeSingleZoneModel.ZoneStatus zoneStatus
		{
			[Token(Token = "0x602BA45")]
			[Address(RVA = "0x2787AD0", Offset = "0x27866D0", VA = "0x182787AD0")]
			[CompilerGenerated]
			get
			{
				return Act1ArcadeSingleZoneModel.ZoneStatus.None;
			}
			[Token(Token = "0x602BA46")]
			[Address(RVA = "0x2787F70", Offset = "0x2786B70", VA = "0x182787F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006662 RID: 26210
		// (get) Token: 0x0602BA47 RID: 178759 RVA: 0x000DCBC0 File Offset: 0x000DADC0
		// (set) Token: 0x0602BA48 RID: 178760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006662")]
		public long zoneStartTs
		{
			[Token(Token = "0x602BA47")]
			[Address(RVA = "0x2787A70", Offset = "0x2786670", VA = "0x182787A70")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x602BA48")]
			[Address(RVA = "0x2787F00", Offset = "0x2786B00", VA = "0x182787F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006663 RID: 26211
		// (get) Token: 0x0602BA49 RID: 178761 RVA: 0x000DCBD8 File Offset: 0x000DADD8
		// (set) Token: 0x0602BA4A RID: 178762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006663")]
		public long zoneEndTs
		{
			[Token(Token = "0x602BA49")]
			[Address(RVA = "0x2787950", Offset = "0x2786550", VA = "0x182787950")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x602BA4A")]
			[Address(RVA = "0x2787D90", Offset = "0x2786990", VA = "0x182787D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602BA4B RID: 178763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA4B")]
		[Address(RVA = "0x2787110", Offset = "0x2785D10", VA = "0x182787110")]
		public void LoadData(string actId, ActArcadeData.ArcadeZoneAdditionalData zoneAdditionalData)
		{
		}

		// Token: 0x0602BA4C RID: 178764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA4C")]
		[Address(RVA = "0x2787450", Offset = "0x2786050", VA = "0x182787450")]
		private void _UpdateZoneStatus(string actId, string zoneId)
		{
		}

		// Token: 0x0602BA4D RID: 178765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA4D")]
		[Address(RVA = "0x2787710", Offset = "0x2786310", VA = "0x182787710")]
		public Act1ArcadeSingleZoneModel()
		{
		}

		// Token: 0x0403F206 RID: 258566
		[Token(Token = "0x403F206")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403F207 RID: 258567
		[Token(Token = "0x403F207")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403F208 RID: 258568
		[Token(Token = "0x403F208")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403F209 RID: 258569
		[Token(Token = "0x403F209")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_zoneId;

		// Token: 0x0403F20A RID: 258570
		[Token(Token = "0x403F20A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0403F20B RID: 258571
		[Token(Token = "0x403F20B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x0403F20C RID: 258572
		[Token(Token = "0x403F20C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_zoneEntryPicId;

		// Token: 0x0403F20D RID: 258573
		[Token(Token = "0x403F20D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_zoneEntryPicId;

		// Token: 0x0403F20E RID: 258574
		[Token(Token = "0x403F20E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_stageInfoPrefabId;

		// Token: 0x0403F20F RID: 258575
		[Token(Token = "0x403F20F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_stageInfoPrefabId;

		// Token: 0x0403F210 RID: 258576
		[Token(Token = "0x403F210")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_stages;

		// Token: 0x0403F211 RID: 258577
		[Token(Token = "0x403F211")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_stages;

		// Token: 0x0403F212 RID: 258578
		[Token(Token = "0x403F212")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_subModeType;

		// Token: 0x0403F213 RID: 258579
		[Token(Token = "0x403F213")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_subModeType;

		// Token: 0x0403F214 RID: 258580
		[Token(Token = "0x403F214")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_zoneStatus;

		// Token: 0x0403F215 RID: 258581
		[Token(Token = "0x403F215")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_zoneStatus;

		// Token: 0x0403F216 RID: 258582
		[Token(Token = "0x403F216")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_zoneStartTs;

		// Token: 0x0403F217 RID: 258583
		[Token(Token = "0x403F217")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_zoneStartTs;

		// Token: 0x0403F218 RID: 258584
		[Token(Token = "0x403F218")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_zoneEndTs;

		// Token: 0x0403F219 RID: 258585
		[Token(Token = "0x403F219")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_zoneEndTs;

		// Token: 0x0403F21A RID: 258586
		[Token(Token = "0x403F21A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F21B RID: 258587
		[Token(Token = "0x403F21B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__UpdateZoneStatus;

		// Token: 0x0403F21C RID: 258588
		[Token(Token = "0x403F21C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007983 RID: 31107
		[Token(Token = "0x2007983")]
		public enum ZoneStatus
		{
			// Token: 0x0403F21E RID: 258590
			[Token(Token = "0x403F21E")]
			None,
			// Token: 0x0403F21F RID: 258591
			[Token(Token = "0x403F21F")]
			Avail,
			// Token: 0x0403F220 RID: 258592
			[Token(Token = "0x403F220")]
			Locked,
			// Token: 0x0403F221 RID: 258593
			[Token(Token = "0x403F221")]
			Closed
		}
	}
}
