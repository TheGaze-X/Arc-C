using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E5E RID: 15966
	[Token(Token = "0x2003E5E")]
	public class SpecialOperatorPage : StateEnginePage
	{
		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x06018D44 RID: 101700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B48")]
		public string charId
		{
			[Token(Token = "0x6018D44")]
			[Address(RVA = "0x117CA70", Offset = "0x117B670", VA = "0x18117CA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x06018D45 RID: 101701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B49")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x6018D45")]
			[Address(RVA = "0x117CAD0", Offset = "0x117B6D0", VA = "0x18117CAD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018D46 RID: 101702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D46")]
		[Address(RVA = "0x117C5C0", Offset = "0x117B1C0", VA = "0x18117C5C0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06018D47 RID: 101703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D47")]
		[Address(RVA = "0x117C750", Offset = "0x117B350", VA = "0x18117C750", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x06018D48 RID: 101704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D48")]
		[Address(RVA = "0x117C960", Offset = "0x117B560", VA = "0x18117C960")]
		private void _OnClosePage()
		{
		}

		// Token: 0x06018D49 RID: 101705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D49")]
		[Address(RVA = "0x117CA10", Offset = "0x117B610", VA = "0x18117CA10")]
		public SpecialOperatorPage()
		{
		}

		// Token: 0x06018D4B RID: 101707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D4B")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06018D4C RID: 101708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D4C")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x0401E87E RID: 125054
		[Token(Token = "0x401E87E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401E87F RID: 125055
		[Token(Token = "0x401E87F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0401E880 RID: 125056
		[Token(Token = "0x401E880")]
		[FieldOffset(Offset = "0x100")]
		private string m_charId;

		// Token: 0x0401E881 RID: 125057
		[Token(Token = "0x401E881")]
		[FieldOffset(Offset = "0x108")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x0401E882 RID: 125058
		[Token(Token = "0x401E882")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x0401E883 RID: 125059
		[Token(Token = "0x401E883")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x0401E884 RID: 125060
		[Token(Token = "0x401E884")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401E885 RID: 125061
		[Token(Token = "0x401E885")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x0401E886 RID: 125062
		[Token(Token = "0x401E886")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnClosePage;

		// Token: 0x0401E887 RID: 125063
		[Token(Token = "0x401E887")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E5F RID: 15967
		[Token(Token = "0x2003E5F")]
		public class Params
		{
			// Token: 0x06018D4D RID: 101709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018D4D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0401E888 RID: 125064
			[Token(Token = "0x401E888")]
			[FieldOffset(Offset = "0x10")]
			public string charId;
		}
	}
}
