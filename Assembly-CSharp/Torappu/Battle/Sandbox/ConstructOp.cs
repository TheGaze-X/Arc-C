using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A4F RID: 10831
	[Token(Token = "0x2002A4F")]
	public class ConstructOp : IConstructOp, IHotfixable
	{
		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x06011FA2 RID: 73634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002787")]
		protected SandboxV2Data dataTable
		{
			[Token(Token = "0x6011FA2")]
			[Address(RVA = "0x9FF360", Offset = "0x9FDF60", VA = "0x1809FF360")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011FA3 RID: 73635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FA3")]
		[Address(RVA = "0x9FF020", Offset = "0x9FDC20", VA = "0x1809FF020", Slot = "7")]
		public virtual void Execute()
		{
		}

		// Token: 0x06011FA4 RID: 73636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FA4")]
		[Address(RVA = "0x9FF0E0", Offset = "0x9FDCE0", VA = "0x1809FF0E0", Slot = "8")]
		public virtual void Revert()
		{
		}

		// Token: 0x06011FA5 RID: 73637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FA5")]
		[Address(RVA = "0x9FF080", Offset = "0x9FDC80", VA = "0x1809FF080", Slot = "9")]
		public virtual JObject GetDataNullable()
		{
			return null;
		}

		// Token: 0x06011FA6 RID: 73638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FA6")]
		[Address(RVA = "0x9FEEE0", Offset = "0x9FDAE0", VA = "0x1809FEEE0")]
		protected void ApplyGoldCost(Character character, int discount, bool isRevert = false)
		{
		}

		// Token: 0x06011FA7 RID: 73639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FA7")]
		[Address(RVA = "0x9FF140", Offset = "0x9FDD40", VA = "0x1809FF140")]
		public static void SetHp(Unit character, FP targetHPRatio)
		{
		}

		// Token: 0x06011FA8 RID: 73640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FA8")]
		[Address(RVA = "0x9FF300", Offset = "0x9FDF00", VA = "0x1809FF300")]
		public ConstructOp()
		{
		}

		// Token: 0x040144BF RID: 83135
		[Token(Token = "0x40144BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataTable;

		// Token: 0x040144C0 RID: 83136
		[Token(Token = "0x40144C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x040144C1 RID: 83137
		[Token(Token = "0x40144C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Revert;

		// Token: 0x040144C2 RID: 83138
		[Token(Token = "0x40144C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDataNullable;

		// Token: 0x040144C3 RID: 83139
		[Token(Token = "0x40144C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyGoldCost;

		// Token: 0x040144C4 RID: 83140
		[Token(Token = "0x40144C4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetHp;

		// Token: 0x040144C5 RID: 83141
		[Token(Token = "0x40144C5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
