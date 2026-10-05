using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E4B RID: 15947
	[Token(Token = "0x2003E4B")]
	public class SpecialOperatorElitePointModel : SpecialOperatorDiagramPointModel
	{
		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x06018C7D RID: 101501 RVA: 0x0009BBF8 File Offset: 0x00099DF8
		// (set) Token: 0x06018C7E RID: 101502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B07")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6018C7D")]
			[Address(RVA = "0x117A8E0", Offset = "0x11794E0", VA = "0x18117A8E0")]
			[CompilerGenerated]
			get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x6018C7E")]
			[Address(RVA = "0x117A9A0", Offset = "0x11795A0", VA = "0x18117A9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x06018C7F RID: 101503 RVA: 0x0009BC10 File Offset: 0x00099E10
		[Token(Token = "0x17003B08")]
		public override SpecialOperatorPointViewType pointViewType
		{
			[Token(Token = "0x6018C7F")]
			[Address(RVA = "0x117A940", Offset = "0x1179540", VA = "0x18117A940", Slot = "6")]
			get
			{
				return SpecialOperatorPointViewType.NONE;
			}
		}

		// Token: 0x06018C80 RID: 101504 RVA: 0x0009BC28 File Offset: 0x00099E28
		[Token(Token = "0x6018C80")]
		[Address(RVA = "0x117A600", Offset = "0x1179200", VA = "0x18117A600", Slot = "10")]
		public override bool CalcUnlockStatus(string charId)
		{
			return default(bool);
		}

		// Token: 0x06018C81 RID: 101505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C81")]
		[Address(RVA = "0x117A6C0", Offset = "0x11792C0", VA = "0x18117A6C0", Slot = "4")]
		protected override void OnLoadData(SpecialOperatorDiagramData diagramData, SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018C82 RID: 101506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C82")]
		[Address(RVA = "0x117A840", Offset = "0x1179440", VA = "0x18117A840")]
		public SpecialOperatorElitePointModel()
		{
		}

		// Token: 0x06018C83 RID: 101507 RVA: 0x0009BC40 File Offset: 0x00099E40
		[Token(Token = "0x6018C83")]
		[Address(RVA = "0x1179ED0", Offset = "0x1178AD0", VA = "0x181179ED0")]
		private bool <>xLuaBaseProxy_CalcUnlockStatus(string P0)
		{
			return default(bool);
		}

		// Token: 0x0401E74B RID: 124747
		[Token(Token = "0x401E74B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0401E74C RID: 124748
		[Token(Token = "0x401E74C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x0401E74D RID: 124749
		[Token(Token = "0x401E74D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_pointViewType;

		// Token: 0x0401E74E RID: 124750
		[Token(Token = "0x401E74E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalcUnlockStatus;

		// Token: 0x0401E74F RID: 124751
		[Token(Token = "0x401E74F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnLoadData;

		// Token: 0x0401E750 RID: 124752
		[Token(Token = "0x401E750")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
