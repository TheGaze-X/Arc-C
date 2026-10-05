using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200753A RID: 30010
	[Token(Token = "0x200753A")]
	public class RhineBattlePerformanceItemModel : IHotfixable
	{
		// Token: 0x0602A46D RID: 173165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A46D")]
		[Address(RVA = "0x25EE300", Offset = "0x25ECF00", VA = "0x1825EE300")]
		public void LoadData(Act25SideData.BattlePerformanceData itemData, string groupId)
		{
		}

		// Token: 0x0602A46E RID: 173166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A46E")]
		[Address(RVA = "0x25EE430", Offset = "0x25ED030", VA = "0x1825EE430")]
		public RhineBattlePerformanceItemModel()
		{
		}

		// Token: 0x0403CC9B RID: 248987
		[Token(Token = "0x403CC9B")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x0403CC9C RID: 248988
		[Token(Token = "0x403CC9C")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0403CC9D RID: 248989
		[Token(Token = "0x403CC9D")]
		[FieldOffset(Offset = "0x20")]
		public string itemName;

		// Token: 0x0403CC9E RID: 248990
		[Token(Token = "0x403CC9E")]
		[FieldOffset(Offset = "0x28")]
		public string itemDesc;

		// Token: 0x0403CC9F RID: 248991
		[Token(Token = "0x403CC9F")]
		[FieldOffset(Offset = "0x30")]
		public string itemIconId;

		// Token: 0x0403CCA0 RID: 248992
		[Token(Token = "0x403CCA0")]
		[FieldOffset(Offset = "0x38")]
		public bool isNew;

		// Token: 0x0403CCA1 RID: 248993
		[Token(Token = "0x403CCA1")]
		[FieldOffset(Offset = "0x39")]
		public bool isUnlock;

		// Token: 0x0403CCA2 RID: 248994
		[Token(Token = "0x403CCA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CCA3 RID: 248995
		[Token(Token = "0x403CCA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
