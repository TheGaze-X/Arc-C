using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CommonFriendAssist
{
	// Token: 0x02005BC8 RID: 23496
	[Token(Token = "0x2005BC8")]
	public class CommonFriendAssistStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004FBA RID: 20410
		// (get) Token: 0x06022126 RID: 139558 RVA: 0x000BC478 File Offset: 0x000BA678
		// (set) Token: 0x06022127 RID: 139559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FBA")]
		public bool chooseAssistSuc
		{
			[Token(Token = "0x6022126")]
			[Address(RVA = "0x1C8BED0", Offset = "0x1C8AAD0", VA = "0x181C8BED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022127")]
			[Address(RVA = "0x1C8BFB0", Offset = "0x1C8ABB0", VA = "0x181C8BFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FBB RID: 20411
		// (get) Token: 0x06022128 RID: 139560 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022129 RID: 139561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FBB")]
		public ICommonFriendAssistPlugin plugin
		{
			[Token(Token = "0x6022128")]
			[Address(RVA = "0x1C8BF40", Offset = "0x1C8AB40", VA = "0x181C8BF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022129")]
			[Address(RVA = "0x1C8C040", Offset = "0x1C8AC40", VA = "0x181C8C040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602212A RID: 139562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602212A")]
		[Address(RVA = "0x1C8B9A0", Offset = "0x1C8A5A0", VA = "0x181C8B9A0")]
		public void SetPlugin(ICommonFriendAssistPlugin aPlugin)
		{
		}

		// Token: 0x0602212B RID: 139563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602212B")]
		[Address(RVA = "0x1C8B8D0", Offset = "0x1C8A4D0", VA = "0x181C8B8D0")]
		public void SetAssistSuc(bool suc)
		{
		}

		// Token: 0x0602212C RID: 139564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602212C")]
		[Address(RVA = "0x1C8BDD0", Offset = "0x1C8A9D0", VA = "0x181C8BDD0")]
		public CommonFriendAssistStateBean()
		{
		}

		// Token: 0x0402EBCB RID: 191435
		[Token(Token = "0x402EBCB")]
		[FieldOffset(Offset = "0x0")]
		public static List<ProfessionCategory> PROFESSION_LIST;

		// Token: 0x0402EBCC RID: 191436
		[Token(Token = "0x402EBCC")]
		[FieldOffset(Offset = "0x10")]
		public CommonFriendAssistViewModelProperty property;

		// Token: 0x0402EBCF RID: 191439
		[Token(Token = "0x402EBCF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_chooseAssistSuc;

		// Token: 0x0402EBD0 RID: 191440
		[Token(Token = "0x402EBD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_chooseAssistSuc;

		// Token: 0x0402EBD1 RID: 191441
		[Token(Token = "0x402EBD1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0402EBD2 RID: 191442
		[Token(Token = "0x402EBD2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_plugin;

		// Token: 0x0402EBD3 RID: 191443
		[Token(Token = "0x402EBD3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetPlugin;

		// Token: 0x0402EBD4 RID: 191444
		[Token(Token = "0x402EBD4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetAssistSuc;

		// Token: 0x0402EBD5 RID: 191445
		[Token(Token = "0x402EBD5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
