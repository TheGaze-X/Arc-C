using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A51 RID: 10833
	[Token(Token = "0x2002A51")]
	public class ConstructPlaceTrap : ConstructOp
	{
		// Token: 0x06011FAC RID: 73644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FAC")]
		[Address(RVA = "0x9FF930", Offset = "0x9FE530", VA = "0x1809FF930")]
		public ConstructPlaceTrap(GridPosition pos, SharedConsts.Direction dir, string buildingId, bool notExecute)
		{
		}

		// Token: 0x06011FAD RID: 73645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FAD")]
		[Address(RVA = "0x9FF560", Offset = "0x9FE160", VA = "0x1809FF560", Slot = "7")]
		public override void Execute()
		{
		}

		// Token: 0x06011FAE RID: 73646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FAE")]
		[Address(RVA = "0x9FF810", Offset = "0x9FE410", VA = "0x1809FF810", Slot = "8")]
		public override void Revert()
		{
		}

		// Token: 0x06011FAF RID: 73647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FAF")]
		[Address(RVA = "0x9FF630", Offset = "0x9FE230", VA = "0x1809FF630", Slot = "9")]
		public override JObject GetDataNullable()
		{
			return null;
		}

		// Token: 0x06011FB0 RID: 73648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FB0")]
		[Address(RVA = "0x9FF020", Offset = "0x9FDC20", VA = "0x1809FF020")]
		private void <>xLuaBaseProxy_Execute()
		{
		}

		// Token: 0x06011FB1 RID: 73649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FB1")]
		[Address(RVA = "0x9FF0E0", Offset = "0x9FDCE0", VA = "0x1809FF0E0")]
		private void <>xLuaBaseProxy_Revert()
		{
		}

		// Token: 0x06011FB2 RID: 73650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FB2")]
		[Address(RVA = "0x9FF080", Offset = "0x9FDC80", VA = "0x1809FF080")]
		private JObject <>xLuaBaseProxy_GetDataNullable()
		{
			return null;
		}

		// Token: 0x040144C8 RID: 83144
		[Token(Token = "0x40144C8")]
		[FieldOffset(Offset = "0x10")]
		private GridPosition m_pos;

		// Token: 0x040144C9 RID: 83145
		[Token(Token = "0x40144C9")]
		[FieldOffset(Offset = "0x18")]
		private SharedConsts.Direction m_dir;

		// Token: 0x040144CA RID: 83146
		[Token(Token = "0x40144CA")]
		[FieldOffset(Offset = "0x20")]
		private string m_buildingId;

		// Token: 0x040144CB RID: 83147
		[Token(Token = "0x40144CB")]
		[FieldOffset(Offset = "0x28")]
		private bool m_notExecute;

		// Token: 0x040144CC RID: 83148
		[Token(Token = "0x40144CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040144CD RID: 83149
		[Token(Token = "0x40144CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x040144CE RID: 83150
		[Token(Token = "0x40144CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Revert;

		// Token: 0x040144CF RID: 83151
		[Token(Token = "0x40144CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDataNullable;
	}
}
