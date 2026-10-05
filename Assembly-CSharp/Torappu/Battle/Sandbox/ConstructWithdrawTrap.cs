using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A53 RID: 10835
	[Token(Token = "0x2002A53")]
	public class ConstructWithdrawTrap : ConstructOp
	{
		// Token: 0x06011FBA RID: 73658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FBA")]
		[Address(RVA = "0xA01720", Offset = "0xA00320", VA = "0x180A01720")]
		public ConstructWithdrawTrap(Character character)
		{
		}

		// Token: 0x06011FBB RID: 73659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FBB")]
		[Address(RVA = "0xA00FB0", Offset = "0x9FFBB0", VA = "0x180A00FB0", Slot = "7")]
		public override void Execute()
		{
		}

		// Token: 0x06011FBC RID: 73660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FBC")]
		[Address(RVA = "0xA01300", Offset = "0x9FFF00", VA = "0x180A01300", Slot = "8")]
		public override void Revert()
		{
		}

		// Token: 0x06011FBD RID: 73661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FBD")]
		[Address(RVA = "0xA01170", Offset = "0x9FFD70", VA = "0x180A01170", Slot = "9")]
		public override JObject GetDataNullable()
		{
			return null;
		}

		// Token: 0x06011FBE RID: 73662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FBE")]
		[Address(RVA = "0xA013F0", Offset = "0x9FFFF0", VA = "0x180A013F0")]
		private void _SetMat(FP hpRatio, bool isRevert = false)
		{
		}

		// Token: 0x06011FBF RID: 73663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FBF")]
		[Address(RVA = "0x9FF020", Offset = "0x9FDC20", VA = "0x1809FF020")]
		private void <>xLuaBaseProxy_Execute()
		{
		}

		// Token: 0x06011FC0 RID: 73664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FC0")]
		[Address(RVA = "0x9FF0E0", Offset = "0x9FDCE0", VA = "0x1809FF0E0")]
		private void <>xLuaBaseProxy_Revert()
		{
		}

		// Token: 0x06011FC1 RID: 73665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FC1")]
		[Address(RVA = "0x9FF080", Offset = "0x9FDC80", VA = "0x1809FF080")]
		private JObject <>xLuaBaseProxy_GetDataNullable()
		{
			return null;
		}

		// Token: 0x040144DA RID: 83162
		[Token(Token = "0x40144DA")]
		[FieldOffset(Offset = "0x10")]
		private GridPosition m_pos;

		// Token: 0x040144DB RID: 83163
		[Token(Token = "0x40144DB")]
		[FieldOffset(Offset = "0x18")]
		private SharedConsts.Direction m_dir;

		// Token: 0x040144DC RID: 83164
		[Token(Token = "0x40144DC")]
		[FieldOffset(Offset = "0x20")]
		private string m_buildingId;

		// Token: 0x040144DD RID: 83165
		[Token(Token = "0x40144DD")]
		[FieldOffset(Offset = "0x28")]
		private FP m_cachedHpRatio;

		// Token: 0x040144DE RID: 83166
		[Token(Token = "0x40144DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040144DF RID: 83167
		[Token(Token = "0x40144DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x040144E0 RID: 83168
		[Token(Token = "0x40144E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Revert;

		// Token: 0x040144E1 RID: 83169
		[Token(Token = "0x40144E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDataNullable;

		// Token: 0x040144E2 RID: 83170
		[Token(Token = "0x40144E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetMat;
	}
}
