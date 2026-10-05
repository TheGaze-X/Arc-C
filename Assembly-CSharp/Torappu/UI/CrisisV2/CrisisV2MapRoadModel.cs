using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005971 RID: 22897
	[Token(Token = "0x2005971")]
	public class CrisisV2MapRoadModel : IHotfixable
	{
		// Token: 0x17004E93 RID: 20115
		// (get) Token: 0x0602164E RID: 136782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E93")]
		public string roadId
		{
			[Token(Token = "0x602164E")]
			[Address(RVA = "0x1BC8420", Offset = "0x1BC7020", VA = "0x181BC8420")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E94 RID: 20116
		// (get) Token: 0x0602164F RID: 136783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E94")]
		public CrisisV2MapRoadPointData startTargetData
		{
			[Token(Token = "0x602164F")]
			[Address(RVA = "0x1BC8480", Offset = "0x1BC7080", VA = "0x181BC8480")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E95 RID: 20117
		// (get) Token: 0x06021650 RID: 136784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E95")]
		public CrisisV2MapRoadPointData endTargetData
		{
			[Token(Token = "0x6021650")]
			[Address(RVA = "0x1BC83B0", Offset = "0x1BC6FB0", VA = "0x181BC83B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021651 RID: 136785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021651")]
		[Address(RVA = "0x1BC82B0", Offset = "0x1BC6EB0", VA = "0x181BC82B0")]
		public void Load(string roadId, CrisisV2MapRoadRelationData roadRelationData)
		{
		}

		// Token: 0x06021652 RID: 136786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021652")]
		[Address(RVA = "0x1BC8350", Offset = "0x1BC6F50", VA = "0x181BC8350")]
		public CrisisV2MapRoadModel()
		{
		}

		// Token: 0x0402D8AF RID: 186543
		[Token(Token = "0x402D8AF")]
		[FieldOffset(Offset = "0x10")]
		private string m_roadId;

		// Token: 0x0402D8B0 RID: 186544
		[Token(Token = "0x402D8B0")]
		[FieldOffset(Offset = "0x18")]
		private CrisisV2MapRoadRelationData m_relationData;

		// Token: 0x0402D8B1 RID: 186545
		[Token(Token = "0x402D8B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roadId;

		// Token: 0x0402D8B2 RID: 186546
		[Token(Token = "0x402D8B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_startTargetData;

		// Token: 0x0402D8B3 RID: 186547
		[Token(Token = "0x402D8B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_endTargetData;

		// Token: 0x0402D8B4 RID: 186548
		[Token(Token = "0x402D8B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402D8B5 RID: 186549
		[Token(Token = "0x402D8B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
