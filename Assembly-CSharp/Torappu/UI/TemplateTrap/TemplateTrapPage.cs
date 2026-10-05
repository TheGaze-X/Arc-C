using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D29 RID: 15657
	[Token(Token = "0x2003D29")]
	public class TemplateTrapPage : StateEnginePage
	{
		// Token: 0x06018684 RID: 99972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018684")]
		[Address(RVA = "0x10D1950", Offset = "0x10D0550", VA = "0x1810D1950", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06018685 RID: 99973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018685")]
		[Address(RVA = "0x10D1C30", Offset = "0x10D0830", VA = "0x1810D1C30")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x06018686 RID: 99974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018686")]
		[Address(RVA = "0x10D1CD0", Offset = "0x10D08D0", VA = "0x1810D1CD0")]
		public TemplateTrapPage()
		{
		}

		// Token: 0x06018688 RID: 99976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018688")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0401DDB2 RID: 122290
		[Token(Token = "0x401DDB2")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401DDB3 RID: 122291
		[Token(Token = "0x401DDB3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401DDB4 RID: 122292
		[Token(Token = "0x401DDB4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0401DDB5 RID: 122293
		[Token(Token = "0x401DDB5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D2A RID: 15658
		[Token(Token = "0x2003D2A")]
		public class Param
		{
			// Token: 0x06018689 RID: 99977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018689")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0401DDB6 RID: 122294
			[Token(Token = "0x401DDB6")]
			[FieldOffset(Offset = "0x10")]
			public bool isRetro;

			// Token: 0x0401DDB7 RID: 122295
			[Token(Token = "0x401DDB7")]
			[FieldOffset(Offset = "0x18")]
			public string groupId;

			// Token: 0x0401DDB8 RID: 122296
			[Token(Token = "0x401DDB8")]
			[FieldOffset(Offset = "0x20")]
			public string domainId;
		}
	}
}
