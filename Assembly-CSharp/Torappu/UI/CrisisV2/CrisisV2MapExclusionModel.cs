using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200596F RID: 22895
	[Token(Token = "0x200596F")]
	public class CrisisV2MapExclusionModel : IHotfixable
	{
		// Token: 0x17004E84 RID: 20100
		// (get) Token: 0x06021639 RID: 136761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E84")]
		public string defaultSlotId
		{
			[Token(Token = "0x6021639")]
			[Address(RVA = "0x1BC7E60", Offset = "0x1BC6A60", VA = "0x181BC7E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E85 RID: 20101
		// (get) Token: 0x0602163A RID: 136762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E85")]
		public List<string> nodeList
		{
			[Token(Token = "0x602163A")]
			[Address(RVA = "0x1BC7ED0", Offset = "0x1BC6AD0", VA = "0x181BC7ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602163B RID: 136763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602163B")]
		[Address(RVA = "0x1BC7BC0", Offset = "0x1BC67C0", VA = "0x181BC7BC0")]
		public void Load(string exclusionId, CrisisV2ExclusionData exclusionData, CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x0602163C RID: 136764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602163C")]
		[Address(RVA = "0x1BC7DB0", Offset = "0x1BC69B0", VA = "0x181BC7DB0")]
		public CrisisV2MapExclusionModel()
		{
		}

		// Token: 0x0402D893 RID: 186515
		[Token(Token = "0x402D893")]
		[FieldOffset(Offset = "0x10")]
		private List<string> m_nodeList;

		// Token: 0x0402D894 RID: 186516
		[Token(Token = "0x402D894")]
		[FieldOffset(Offset = "0x18")]
		private string m_exclusionId;

		// Token: 0x0402D895 RID: 186517
		[Token(Token = "0x402D895")]
		[FieldOffset(Offset = "0x20")]
		private CrisisV2ExclusionData m_exclusionData;

		// Token: 0x0402D896 RID: 186518
		[Token(Token = "0x402D896")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_defaultSlotId;

		// Token: 0x0402D897 RID: 186519
		[Token(Token = "0x402D897")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_nodeList;

		// Token: 0x0402D898 RID: 186520
		[Token(Token = "0x402D898")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402D899 RID: 186521
		[Token(Token = "0x402D899")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
