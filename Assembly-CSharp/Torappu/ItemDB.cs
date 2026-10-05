using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005C9 RID: 1481
	[Token(Token = "0x20005C9")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/ItemTable")]
	[Serializable]
	public class ItemDB : ConstTable<InventoryData, ItemDB>
	{
		// Token: 0x0600614B RID: 24907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614B")]
		[Address(RVA = "0x1DEE340", Offset = "0x1DECF40", VA = "0x181DEE340", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600614C RID: 24908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC7")]
		public List<ItemType> specialTypesInItemRepo
		{
			[Token(Token = "0x600614C")]
			[Address(RVA = "0x1DEE5B0", Offset = "0x1DED1B0", VA = "0x181DEE5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x0002FA90 File Offset: 0x0002DC90
		[Token(Token = "0x600614D")]
		[Address(RVA = "0x1DEE3C0", Offset = "0x1DECFC0", VA = "0x181DEE3C0")]
		public bool TryGetPotentionItemId(int rarity, ProfessionCategory profession, out string itemId)
		{
			return default(bool);
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614E")]
		[Address(RVA = "0x1DEE540", Offset = "0x1DED140", VA = "0x181DEE540")]
		public ItemDB()
		{
		}

		// Token: 0x04002AE9 RID: 10985
		[Token(Token = "0x4002AE9")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private List<ItemType> m_specialTypesInItemRepo;

		// Token: 0x04002AEA RID: 10986
		[Token(Token = "0x4002AEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002AEB RID: 10987
		[Token(Token = "0x4002AEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_specialTypesInItemRepo;

		// Token: 0x04002AEC RID: 10988
		[Token(Token = "0x4002AEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetPotentionItemId;

		// Token: 0x04002AED RID: 10989
		[Token(Token = "0x4002AED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
