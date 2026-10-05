using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public static class RuntimeAtlas
	{
		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		public enum ProcessStatus
		{
			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			Invalid,
			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			InsertWaiting,
			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			InsertDone
		}

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x200008E")]
		public enum ProcessFailureCause
		{
			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			NoFailure,
			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			FailureCauseImageHasNullMainTexture,
			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			FailureCauseImageHasNullSprite,
			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			FailureCauseSpriteHasNonQuadMesh,
			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			FailureCauseSpriteHasAssociatedAlphaSplitTexture,
			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			FailureCauseSpriteRectHasNoPadding,
			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			FailureCauseTextureWidthExceedLimit,
			// Token: 0x040002AF RID: 687
			[Token(Token = "0x40002AF")]
			FailureCauseTextureHeightExceedLimit,
			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			FailureCauseTextureFormatNotCompatible,
			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			FailureCauseTextureSizeNotAlignedForCopyTexture,
			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			FailureCauseAtlasTextureHasNoSpaceLeft
		}

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		public struct AtlasHandle
		{
			// Token: 0x060005A0 RID: 1440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x5B82B30", Offset = "0x5B81730", VA = "0x185B82B30")]
			public AtlasHandle(RuntimeAtlas.ProcessStatus status, RuntimeAtlas.ProcessFailureCause failureCause, int panelLevel, int atlasIndex, RectInt atlasRect, int textureId)
			{
			}

			// Token: 0x060005A1 RID: 1441 RVA: 0x00004248 File Offset: 0x00002448
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x5159F0", Offset = "0x5145F0", VA = "0x1805159F0")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x060005A2 RID: 1442 RVA: 0x00004260 File Offset: 0x00002460
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x5B82AC0", Offset = "0x5B816C0", VA = "0x185B82AC0")]
			public static RuntimeAtlas.AtlasHandle CreateInvalidHandle(RuntimeAtlas.ProcessFailureCause cause = RuntimeAtlas.ProcessFailureCause.NoFailure)
			{
				return default(RuntimeAtlas.AtlasHandle);
			}

			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			[FieldOffset(Offset = "0x0")]
			public RuntimeAtlas.ProcessStatus status;

			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			[FieldOffset(Offset = "0x4")]
			public RuntimeAtlas.ProcessFailureCause failureCause;

			// Token: 0x040002B5 RID: 693
			[Token(Token = "0x40002B5")]
			[FieldOffset(Offset = "0x8")]
			public int panelLevel;

			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			[FieldOffset(Offset = "0xC")]
			public int atlasIndex;

			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			[FieldOffset(Offset = "0x10")]
			public RectInt atlasRect;

			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			[FieldOffset(Offset = "0x20")]
			public int textureId;
		}
	}
}
