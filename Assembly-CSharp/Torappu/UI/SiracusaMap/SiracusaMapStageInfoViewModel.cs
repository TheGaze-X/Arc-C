using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F99 RID: 16281
	[Token(Token = "0x2003F99")]
	public class SiracusaMapStageInfoViewModel : ISiracusaMapStageInfoModel, IHotfixable
	{
		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0601940C RID: 103436 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601940D RID: 103437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C4D")]
		public StageViewModel normalStage
		{
			[Token(Token = "0x601940C")]
			[Address(RVA = "0x11F3CF0", Offset = "0x11F28F0", VA = "0x1811F3CF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601940D")]
			[Address(RVA = "0x11F3F30", Offset = "0x11F2B30", VA = "0x1811F3F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0601940E RID: 103438 RVA: 0x0009D5D8 File Offset: 0x0009B7D8
		// (set) Token: 0x0601940F RID: 103439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C4E")]
		public int rankNum
		{
			[Token(Token = "0x601940E")]
			[Address(RVA = "0x11F3DB0", Offset = "0x11F29B0", VA = "0x1811F3DB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601940F")]
			[Address(RVA = "0x11F4030", Offset = "0x11F2C30", VA = "0x1811F4030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x06019410 RID: 103440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C4F")]
		public string stageId
		{
			[Token(Token = "0x6019410")]
			[Address(RVA = "0x11F3E10", Offset = "0x11F2A10", VA = "0x1811F3E10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x06019411 RID: 103441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019412 RID: 103442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C50")]
		public string pointId
		{
			[Token(Token = "0x6019411")]
			[Address(RVA = "0x11F3D50", Offset = "0x11F2950", VA = "0x1811F3D50", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019412")]
			[Address(RVA = "0x11F3FB0", Offset = "0x11F2BB0", VA = "0x1811F3FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x06019413 RID: 103443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C51")]
		public StageViewModel normalStageModel
		{
			[Token(Token = "0x6019413")]
			[Address(RVA = "0x11F3C60", Offset = "0x11F2860", VA = "0x1811F3C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019414 RID: 103444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019414")]
		[Address(RVA = "0x11F3C00", Offset = "0x11F2800", VA = "0x1811F3C00")]
		public SiracusaMapStageInfoViewModel()
		{
		}

		// Token: 0x0401F57F RID: 128383
		[Token(Token = "0x401F57F")]
		[FieldOffset(Offset = "0x18")]
		public StageViewModel hardStage;

		// Token: 0x0401F580 RID: 128384
		[Token(Token = "0x401F580")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0401F583 RID: 128387
		[Token(Token = "0x401F583")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_normalStage;

		// Token: 0x0401F584 RID: 128388
		[Token(Token = "0x401F584")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_normalStage;

		// Token: 0x0401F585 RID: 128389
		[Token(Token = "0x401F585")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rankNum;

		// Token: 0x0401F586 RID: 128390
		[Token(Token = "0x401F586")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_rankNum;

		// Token: 0x0401F587 RID: 128391
		[Token(Token = "0x401F587")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0401F588 RID: 128392
		[Token(Token = "0x401F588")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_pointId;

		// Token: 0x0401F589 RID: 128393
		[Token(Token = "0x401F589")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_pointId;

		// Token: 0x0401F58A RID: 128394
		[Token(Token = "0x401F58A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_normalStageModel;

		// Token: 0x0401F58B RID: 128395
		[Token(Token = "0x401F58B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
