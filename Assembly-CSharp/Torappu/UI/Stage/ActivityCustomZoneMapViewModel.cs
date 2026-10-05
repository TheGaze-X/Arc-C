using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068A4 RID: 26788
	[Token(Token = "0x20068A4")]
	public class ActivityCustomZoneMapViewModel : IStageSelectHandler, IHotfixable
	{
		// Token: 0x17005A91 RID: 23185
		// (get) Token: 0x06026648 RID: 157256 RVA: 0x000CACF8 File Offset: 0x000C8EF8
		[Token(Token = "0x17005A91")]
		public SpecialStageType stageSelectedType
		{
			[Token(Token = "0x6026648")]
			[Address(RVA = "0x21771A0", Offset = "0x2175DA0", VA = "0x1821771A0", Slot = "4")]
			get
			{
				return SpecialStageType.NORMAL;
			}
		}

		// Token: 0x06026649 RID: 157257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026649")]
		[Address(RVA = "0x2176E30", Offset = "0x2175A30", VA = "0x182176E30", Slot = "5")]
		public StageViewModel FindNormalStageFromSpecialStage(string notNormalStageId, SpecialStageType sourceStageType)
		{
			return null;
		}

		// Token: 0x0602664A RID: 157258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602664A")]
		[Address(RVA = "0x2176EC0", Offset = "0x2175AC0", VA = "0x182176EC0", Slot = "6")]
		public StageViewModel FindSpecialStageFromNormal(string normalStageId, SpecialStageType targetStageType)
		{
			return null;
		}

		// Token: 0x0602664B RID: 157259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602664B")]
		[Address(RVA = "0x2176F50", Offset = "0x2175B50", VA = "0x182176F50", Slot = "7")]
		public StageViewModel GetStageByType(SpecialStageType stageType)
		{
			return null;
		}

		// Token: 0x17005A92 RID: 23186
		// (get) Token: 0x0602664C RID: 157260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A92")]
		public StageViewModel selectedStage
		{
			[Token(Token = "0x602664C")]
			[Address(RVA = "0x2177120", Offset = "0x2175D20", VA = "0x182177120", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602664D RID: 157261 RVA: 0x000CAD10 File Offset: 0x000C8F10
		[Token(Token = "0x602664D")]
		[Address(RVA = "0x2176FC0", Offset = "0x2175BC0", VA = "0x182176FC0")]
		public bool IsStageSelected(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602664E RID: 157262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602664E")]
		[Address(RVA = "0x2177070", Offset = "0x2175C70", VA = "0x182177070")]
		public ActivityCustomZoneMapViewModel()
		{
		}

		// Token: 0x04036107 RID: 221447
		[Token(Token = "0x4036107")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04036108 RID: 221448
		[Token(Token = "0x4036108")]
		[FieldOffset(Offset = "0x18")]
		public string zoneId;

		// Token: 0x04036109 RID: 221449
		[Token(Token = "0x4036109")]
		[FieldOffset(Offset = "0x20")]
		public string zoneMapHolderPrefabPath;

		// Token: 0x0403610A RID: 221450
		[Token(Token = "0x403610A")]
		[FieldOffset(Offset = "0x28")]
		public string zoneMapPrefabPath;

		// Token: 0x0403610B RID: 221451
		[Token(Token = "0x403610B")]
		[FieldOffset(Offset = "0x30")]
		public string stagePreviewHolderPrefabPath;

		// Token: 0x0403610C RID: 221452
		[Token(Token = "0x403610C")]
		[FieldOffset(Offset = "0x38")]
		public string stagePreviewPrefabPath;

		// Token: 0x0403610D RID: 221453
		[Token(Token = "0x403610D")]
		[FieldOffset(Offset = "0x40")]
		public ListDict<string, StageViewModel> stages;

		// Token: 0x0403610E RID: 221454
		[Token(Token = "0x403610E")]
		[FieldOffset(Offset = "0x48")]
		public string selectingStageId;

		// Token: 0x0403610F RID: 221455
		[Token(Token = "0x403610F")]
		[FieldOffset(Offset = "0x50")]
		public object actMeta;

		// Token: 0x04036110 RID: 221456
		[Token(Token = "0x4036110")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageSelectedType;

		// Token: 0x04036111 RID: 221457
		[Token(Token = "0x4036111")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindNormalStageFromSpecialStage;

		// Token: 0x04036112 RID: 221458
		[Token(Token = "0x4036112")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindSpecialStageFromNormal;

		// Token: 0x04036113 RID: 221459
		[Token(Token = "0x4036113")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStageByType;

		// Token: 0x04036114 RID: 221460
		[Token(Token = "0x4036114")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedStage;

		// Token: 0x04036115 RID: 221461
		[Token(Token = "0x4036115")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsStageSelected;

		// Token: 0x04036116 RID: 221462
		[Token(Token = "0x4036116")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
