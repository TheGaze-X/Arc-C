using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A54 RID: 10836
	[Token(Token = "0x2002A54")]
	public class ConstructUpgradeTrap : ConstructOp
	{
		// Token: 0x06011FC2 RID: 73666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FC2")]
		[Address(RVA = "0xA00EA0", Offset = "0x9FFAA0", VA = "0x180A00EA0")]
		public ConstructUpgradeTrap(GridPosition pos)
		{
		}

		// Token: 0x06011FC3 RID: 73667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FC3")]
		[Address(RVA = "0xA00610", Offset = "0x9FF210", VA = "0x180A00610", Slot = "7")]
		public override void Execute()
		{
		}

		// Token: 0x06011FC4 RID: 73668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FC4")]
		[Address(RVA = "0xA00A10", Offset = "0x9FF610", VA = "0x180A00A10", Slot = "8")]
		public override void Revert()
		{
		}

		// Token: 0x06011FC5 RID: 73669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FC5")]
		[Address(RVA = "0xA00880", Offset = "0x9FF480", VA = "0x180A00880", Slot = "9")]
		public override JObject GetDataNullable()
		{
			return null;
		}

		// Token: 0x06011FC6 RID: 73670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FC6")]
		[Address(RVA = "0xA00BE0", Offset = "0x9FF7E0", VA = "0x180A00BE0")]
		private void _SetMat(bool isRevert = false)
		{
		}

		// Token: 0x06011FC7 RID: 73671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FC7")]
		[Address(RVA = "0x9FF020", Offset = "0x9FDC20", VA = "0x1809FF020")]
		private void <>xLuaBaseProxy_Execute()
		{
		}

		// Token: 0x06011FC8 RID: 73672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FC8")]
		[Address(RVA = "0x9FF0E0", Offset = "0x9FDCE0", VA = "0x1809FF0E0")]
		private void <>xLuaBaseProxy_Revert()
		{
		}

		// Token: 0x06011FC9 RID: 73673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FC9")]
		[Address(RVA = "0x9FF080", Offset = "0x9FDC80", VA = "0x1809FF080")]
		private JObject <>xLuaBaseProxy_GetDataNullable()
		{
			return null;
		}

		// Token: 0x040144E3 RID: 83171
		[Token(Token = "0x40144E3")]
		[FieldOffset(Offset = "0x10")]
		private string m_buildingId;

		// Token: 0x040144E4 RID: 83172
		[Token(Token = "0x40144E4")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, int> m_costCache;

		// Token: 0x040144E5 RID: 83173
		[Token(Token = "0x40144E5")]
		[FieldOffset(Offset = "0x20")]
		private GridPosition m_pos;

		// Token: 0x040144E6 RID: 83174
		[Token(Token = "0x40144E6")]
		[FieldOffset(Offset = "0x28")]
		private SharedConsts.Direction m_dir;

		// Token: 0x040144E7 RID: 83175
		[Token(Token = "0x40144E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040144E8 RID: 83176
		[Token(Token = "0x40144E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x040144E9 RID: 83177
		[Token(Token = "0x40144E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Revert;

		// Token: 0x040144EA RID: 83178
		[Token(Token = "0x40144EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDataNullable;

		// Token: 0x040144EB RID: 83179
		[Token(Token = "0x40144EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetMat;
	}
}
