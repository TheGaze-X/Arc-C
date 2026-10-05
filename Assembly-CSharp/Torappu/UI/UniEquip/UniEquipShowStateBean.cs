using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C45 RID: 15429
	[Token(Token = "0x2003C45")]
	public class UniEquipShowStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060181EC RID: 98796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181EC")]
		[Address(RVA = "0x109C050", Offset = "0x109AC50", VA = "0x18109C050")]
		public void LoadData(UniEquipData uniEquipData, string subProfessionId, bool isUnlockShow = false)
		{
		}

		// Token: 0x060181ED RID: 98797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181ED")]
		[Address(RVA = "0x109C100", Offset = "0x109AD00", VA = "0x18109C100")]
		public UniEquipShowStateBean()
		{
		}

		// Token: 0x0401D4EC RID: 120044
		[Token(Token = "0x401D4EC")]
		[FieldOffset(Offset = "0x10")]
		public UniEquipData uniEquipData;

		// Token: 0x0401D4ED RID: 120045
		[Token(Token = "0x401D4ED")]
		[FieldOffset(Offset = "0x18")]
		public string subProfessionId;

		// Token: 0x0401D4EE RID: 120046
		[Token(Token = "0x401D4EE")]
		[FieldOffset(Offset = "0x20")]
		public bool isUnlockShow;

		// Token: 0x0401D4EF RID: 120047
		[Token(Token = "0x401D4EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D4F0 RID: 120048
		[Token(Token = "0x401D4F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
