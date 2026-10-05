using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200595C RID: 22876
	[Token(Token = "0x200595C")]
	public class CrisisV2MapStartNodeModel : CrisisV2MapNodeModel
	{
		// Token: 0x17004E4F RID: 20047
		// (get) Token: 0x0602159B RID: 136603 RVA: 0x000B99D0 File Offset: 0x000B7BD0
		[Token(Token = "0x17004E4F")]
		public override bool canStartFrom
		{
			[Token(Token = "0x602159B")]
			[Address(RVA = "0x1BB0C80", Offset = "0x1BAF880", VA = "0x181BB0C80", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E50 RID: 20048
		// (get) Token: 0x0602159C RID: 136604 RVA: 0x000B99E8 File Offset: 0x000B7BE8
		[Token(Token = "0x17004E50")]
		public override CrisisV2RoadPointStyle roadPointStyle
		{
			[Token(Token = "0x602159C")]
			[Address(RVA = "0x1BB0CE0", Offset = "0x1BAF8E0", VA = "0x181BB0CE0", Slot = "10")]
			get
			{
				return CrisisV2RoadPointStyle.NONE;
			}
		}

		// Token: 0x0602159D RID: 136605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602159D")]
		[Address(RVA = "0x1BB0BE0", Offset = "0x1BAF7E0", VA = "0x181BB0BE0")]
		public CrisisV2MapStartNodeModel()
		{
		}

		// Token: 0x0602159E RID: 136606 RVA: 0x000B9A00 File Offset: 0x000B7C00
		[Token(Token = "0x602159E")]
		[Address(RVA = "0x1BA4FE0", Offset = "0x1BA3BE0", VA = "0x181BA4FE0")]
		private bool <>xLuaBaseProxy_get_canStartFrom()
		{
			return default(bool);
		}

		// Token: 0x0602159F RID: 136607 RVA: 0x000B9A18 File Offset: 0x000B7C18
		[Token(Token = "0x602159F")]
		[Address(RVA = "0x1BA5420", Offset = "0x1BA4020", VA = "0x181BA5420")]
		private CrisisV2RoadPointStyle <>xLuaBaseProxy_get_roadPointStyle()
		{
			return CrisisV2RoadPointStyle.NONE;
		}

		// Token: 0x0402D793 RID: 186259
		[Token(Token = "0x402D793")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canStartFrom;

		// Token: 0x0402D794 RID: 186260
		[Token(Token = "0x402D794")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_roadPointStyle;

		// Token: 0x0402D795 RID: 186261
		[Token(Token = "0x402D795")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
