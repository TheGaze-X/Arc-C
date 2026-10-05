using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019FA RID: 6650
	[Token(Token = "0x20019FA")]
	public class DIYSortMethodModel : IHotfixable
	{
		// Token: 0x0600A6CB RID: 42699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6CB")]
		[Address(RVA = "0x321D130", Offset = "0x321BD30", VA = "0x18321D130")]
		public DIYSortMethodModel()
		{
		}

		// Token: 0x04009EDF RID: 40671
		[Token(Token = "0x4009EDF")]
		[FieldOffset(Offset = "0x10")]
		public BuildingData.DiySortType diySortType;

		// Token: 0x04009EE0 RID: 40672
		[Token(Token = "0x4009EE0")]
		[FieldOffset(Offset = "0x18")]
		public string methodName;

		// Token: 0x04009EE1 RID: 40673
		[Token(Token = "0x4009EE1")]
		[FieldOffset(Offset = "0x20")]
		public int methodIndex;

		// Token: 0x04009EE2 RID: 40674
		[Token(Token = "0x4009EE2")]
		[FieldOffset(Offset = "0x24")]
		public BuildingData.DiyUISortOrder sortOrder;

		// Token: 0x04009EE3 RID: 40675
		[Token(Token = "0x4009EE3")]
		[FieldOffset(Offset = "0x28")]
		public BuildingData.DiyUISortOrder defaultSortOrder;

		// Token: 0x04009EE4 RID: 40676
		[Token(Token = "0x4009EE4")]
		[FieldOffset(Offset = "0x30")]
		public List<string> sortTemplates;

		// Token: 0x04009EE5 RID: 40677
		[Token(Token = "0x4009EE5")]
		[FieldOffset(Offset = "0x38")]
		public string stableSequence;

		// Token: 0x04009EE6 RID: 40678
		[Token(Token = "0x4009EE6")]
		[FieldOffset(Offset = "0x40")]
		public BuildingData.DiyUISortOrder stableSequenceOrder;

		// Token: 0x04009EE7 RID: 40679
		[Token(Token = "0x4009EE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
