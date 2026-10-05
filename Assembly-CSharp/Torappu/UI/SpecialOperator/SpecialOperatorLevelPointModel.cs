using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E4C RID: 15948
	[Token(Token = "0x2003E4C")]
	public class SpecialOperatorLevelPointModel : SpecialOperatorDiagramPointModel
	{
		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x06018C84 RID: 101508 RVA: 0x0009BC58 File Offset: 0x00099E58
		// (set) Token: 0x06018C85 RID: 101509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B09")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6018C84")]
			[Address(RVA = "0x117B7C0", Offset = "0x117A3C0", VA = "0x18117B7C0")]
			[CompilerGenerated]
			get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x6018C85")]
			[Address(RVA = "0x117B8E0", Offset = "0x117A4E0", VA = "0x18117B8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x06018C86 RID: 101510 RVA: 0x0009BC70 File Offset: 0x00099E70
		// (set) Token: 0x06018C87 RID: 101511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B0A")]
		public int level
		{
			[Token(Token = "0x6018C86")]
			[Address(RVA = "0x117B820", Offset = "0x117A420", VA = "0x18117B820")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6018C87")]
			[Address(RVA = "0x117B950", Offset = "0x117A550", VA = "0x18117B950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x06018C88 RID: 101512 RVA: 0x0009BC88 File Offset: 0x00099E88
		[Token(Token = "0x17003B0B")]
		public override SpecialOperatorPointViewType pointViewType
		{
			[Token(Token = "0x6018C88")]
			[Address(RVA = "0x117B880", Offset = "0x117A480", VA = "0x18117B880", Slot = "6")]
			get
			{
				return SpecialOperatorPointViewType.NONE;
			}
		}

		// Token: 0x06018C89 RID: 101513 RVA: 0x0009BCA0 File Offset: 0x00099EA0
		[Token(Token = "0x6018C89")]
		[Address(RVA = "0x117B430", Offset = "0x117A030", VA = "0x18117B430", Slot = "10")]
		public override bool CalcUnlockStatus(string charId)
		{
			return default(bool);
		}

		// Token: 0x06018C8A RID: 101514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C8A")]
		[Address(RVA = "0x117B540", Offset = "0x117A140", VA = "0x18117B540", Slot = "4")]
		protected override void OnLoadData(SpecialOperatorDiagramData diagramData, SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018C8B RID: 101515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C8B")]
		[Address(RVA = "0x117B720", Offset = "0x117A320", VA = "0x18117B720")]
		public SpecialOperatorLevelPointModel()
		{
		}

		// Token: 0x06018C8C RID: 101516 RVA: 0x0009BCB8 File Offset: 0x00099EB8
		[Token(Token = "0x6018C8C")]
		[Address(RVA = "0x1179ED0", Offset = "0x1178AD0", VA = "0x181179ED0")]
		private bool <>xLuaBaseProxy_CalcUnlockStatus(string P0)
		{
			return default(bool);
		}

		// Token: 0x0401E753 RID: 124755
		[Token(Token = "0x401E753")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0401E754 RID: 124756
		[Token(Token = "0x401E754")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x0401E755 RID: 124757
		[Token(Token = "0x401E755")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0401E756 RID: 124758
		[Token(Token = "0x401E756")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x0401E757 RID: 124759
		[Token(Token = "0x401E757")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_pointViewType;

		// Token: 0x0401E758 RID: 124760
		[Token(Token = "0x401E758")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CalcUnlockStatus;

		// Token: 0x0401E759 RID: 124761
		[Token(Token = "0x401E759")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnLoadData;

		// Token: 0x0401E75A RID: 124762
		[Token(Token = "0x401E75A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
