using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B8B RID: 15243
	[Token(Token = "0x2003B8B")]
	public class VoucherSkinV2Plugin : VoucherSkinBasePlugin
	{
		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x06017E3B RID: 97851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700390D")]
		public override string emptyText
		{
			[Token(Token = "0x6017E3B")]
			[Address(RVA = "0x1027C00", Offset = "0x1026800", VA = "0x181027C00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x06017E3C RID: 97852 RVA: 0x000988C8 File Offset: 0x00096AC8
		[Token(Token = "0x1700390E")]
		public override ItemType voucherType
		{
			[Token(Token = "0x6017E3C")]
			[Address(RVA = "0x1027C70", Offset = "0x1026870", VA = "0x181027C70", Slot = "5")]
			get
			{
				return ItemType.NONE;
			}
		}

		// Token: 0x06017E3D RID: 97853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E3D")]
		[Address(RVA = "0x1027A20", Offset = "0x1026620", VA = "0x181027A20", Slot = "6")]
		public override void Render(VoucherSkinHomeViewModel model)
		{
		}

		// Token: 0x06017E3E RID: 97854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E3E")]
		[Address(RVA = "0x1027960", Offset = "0x1026560", VA = "0x181027960", Slot = "7")]
		public override string GetTitleText(VoucherSkinHomeViewModel model)
		{
			return null;
		}

		// Token: 0x06017E3F RID: 97855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E3F")]
		[Address(RVA = "0x1027B60", Offset = "0x1026760", VA = "0x181027B60")]
		public VoucherSkinV2Plugin()
		{
		}

		// Token: 0x0401CE12 RID: 118290
		[Token(Token = "0x401CE12")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _ruleTitle;

		// Token: 0x0401CE13 RID: 118291
		[Token(Token = "0x401CE13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_emptyText;

		// Token: 0x0401CE14 RID: 118292
		[Token(Token = "0x401CE14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_voucherType;

		// Token: 0x0401CE15 RID: 118293
		[Token(Token = "0x401CE15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CE16 RID: 118294
		[Token(Token = "0x401CE16")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTitleText;

		// Token: 0x0401CE17 RID: 118295
		[Token(Token = "0x401CE17")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
