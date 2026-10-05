using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B8A RID: 15242
	[Token(Token = "0x2003B8A")]
	public class VoucherSkinPlugin : VoucherSkinBasePlugin
	{
		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x06017E36 RID: 97846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700390B")]
		public override string emptyText
		{
			[Token(Token = "0x6017E36")]
			[Address(RVA = "0x1027890", Offset = "0x1026490", VA = "0x181027890", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x06017E37 RID: 97847 RVA: 0x000988B0 File Offset: 0x00096AB0
		[Token(Token = "0x1700390C")]
		public override ItemType voucherType
		{
			[Token(Token = "0x6017E37")]
			[Address(RVA = "0x1027900", Offset = "0x1026500", VA = "0x181027900", Slot = "5")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x06017E38 RID: 97848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E38")]
		[Address(RVA = "0x10273D0", Offset = "0x1025FD0", VA = "0x1810273D0", Slot = "6")]
		public override void Render(VoucherSkinHomeViewModel model)
		{
		}

		// Token: 0x06017E39 RID: 97849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E39")]
		[Address(RVA = "0x1027310", Offset = "0x1025F10", VA = "0x181027310", Slot = "7")]
		public override string GetTitleText(VoucherSkinHomeViewModel model)
		{
			return null;
		}

		// Token: 0x06017E3A RID: 97850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E3A")]
		[Address(RVA = "0x10277F0", Offset = "0x10263F0", VA = "0x1810277F0")]
		public VoucherSkinPlugin()
		{
		}

		// Token: 0x0401CE0A RID: 118282
		[Token(Token = "0x401CE0A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _validTime;

		// Token: 0x0401CE0B RID: 118283
		[Token(Token = "0x401CE0B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _validTimeObject;

		// Token: 0x0401CE0C RID: 118284
		[Token(Token = "0x401CE0C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _ruleTitle;

		// Token: 0x0401CE0D RID: 118285
		[Token(Token = "0x401CE0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_emptyText;

		// Token: 0x0401CE0E RID: 118286
		[Token(Token = "0x401CE0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_voucherType;

		// Token: 0x0401CE0F RID: 118287
		[Token(Token = "0x401CE0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CE10 RID: 118288
		[Token(Token = "0x401CE10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTitleText;

		// Token: 0x0401CE11 RID: 118289
		[Token(Token = "0x401CE11")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
