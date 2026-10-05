using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E44 RID: 15940
	[Token(Token = "0x2003E44")]
	public abstract class SpecialOperatorBoardLvlupModel : IHotfixable, IComparable<SpecialOperatorBoardLvlupModel>
	{
		// Token: 0x06018C33 RID: 101427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C33")]
		[Address(RVA = "0x116D970", Offset = "0x116C570", VA = "0x18116D970", Slot = "5")]
		public virtual void InitData(string charId, SpecialOperatorDetailTabData tabData, SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018C34 RID: 101428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C34")]
		[Address(RVA = "0x116BFF0", Offset = "0x116ABF0", VA = "0x18116BFF0", Slot = "6")]
		public virtual void RefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018C35 RID: 101429
		[Token(Token = "0x6018C35")]
		public abstract bool TryGetNodeModel(string nodeId, out SpecialOperatorBoardNodeBase nodeModel);

		// Token: 0x06018C36 RID: 101430 RVA: 0x0009B970 File Offset: 0x00099B70
		[Token(Token = "0x6018C36")]
		[Address(RVA = "0x116D8E0", Offset = "0x116C4E0", VA = "0x18116D8E0", Slot = "4")]
		public int CompareTo(SpecialOperatorBoardLvlupModel model)
		{
			return 0;
		}

		// Token: 0x06018C37 RID: 101431 RVA: 0x0009B988 File Offset: 0x00099B88
		[Token(Token = "0x6018C37")]
		[Address(RVA = "0x116C050", Offset = "0x116AC50", VA = "0x18116C050", Slot = "8")]
		public virtual bool TryFindFocusPos(out float targetPos)
		{
			return default(bool);
		}

		// Token: 0x06018C38 RID: 101432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C38")]
		[Address(RVA = "0x116DA30", Offset = "0x116C630", VA = "0x18116DA30")]
		protected SpecialOperatorBoardLvlupModel()
		{
		}

		// Token: 0x0401E6FD RID: 124669
		[Token(Token = "0x401E6FD")]
		[FieldOffset(Offset = "0x10")]
		private int m_sortId;

		// Token: 0x0401E6FE RID: 124670
		[Token(Token = "0x401E6FE")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x0401E6FF RID: 124671
		[Token(Token = "0x401E6FF")]
		[FieldOffset(Offset = "0x20")]
		public SpecialOperatorDetailNodeType nodeType;

		// Token: 0x0401E700 RID: 124672
		[Token(Token = "0x401E700")]
		[FieldOffset(Offset = "0x28")]
		public string tabName;

		// Token: 0x0401E701 RID: 124673
		[Token(Token = "0x401E701")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401E702 RID: 124674
		[Token(Token = "0x401E702")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401E703 RID: 124675
		[Token(Token = "0x401E703")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0401E704 RID: 124676
		[Token(Token = "0x401E704")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryFindFocusPos;

		// Token: 0x0401E705 RID: 124677
		[Token(Token = "0x401E705")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
