using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007743 RID: 30531
	[Token(Token = "0x2007743")]
	public class Act1VHalfIdleCharDepotCharSelectPlugin : TemplateCharSelectPluginBase
	{
		// Token: 0x0602AE3A RID: 175674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE3A")]
		[Address(RVA = "0x26ABD20", Offset = "0x26AA920", VA = "0x1826ABD20", Slot = "9")]
		public override void OnInitCharSelect(TemplateCharSelectController.InputParam inputParam, ITemplateCharSelectCtrlHost host)
		{
		}

		// Token: 0x0602AE3B RID: 175675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE3B")]
		[Address(RVA = "0x26AB7F0", Offset = "0x26AA3F0", VA = "0x1826AB7F0", Slot = "10")]
		public override void OnCharClick(int instId, string charId)
		{
		}

		// Token: 0x0602AE3C RID: 175676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE3C")]
		[Address(RVA = "0x26AB900", Offset = "0x26AA500", VA = "0x1826AB900", Slot = "12")]
		public override void OnConfirm(Action done)
		{
		}

		// Token: 0x0602AE3D RID: 175677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE3D")]
		[Address(RVA = "0x26AC020", Offset = "0x26AAC20", VA = "0x1826AC020")]
		public Act1VHalfIdleCharDepotCharSelectPlugin()
		{
		}

		// Token: 0x0602AE3E RID: 175678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE3E")]
		[Address(RVA = "0x26AC010", Offset = "0x26AAC10", VA = "0x1826AC010")]
		private void <>xLuaBaseProxy_OnInitCharSelect(TemplateCharSelectController.InputParam P0, ITemplateCharSelectCtrlHost P1)
		{
		}

		// Token: 0x0602AE3F RID: 175679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE3F")]
		[Address(RVA = "0x26ABFF0", Offset = "0x26AABF0", VA = "0x1826ABFF0")]
		private void <>xLuaBaseProxy_OnCharClick(int P0, string P1)
		{
		}

		// Token: 0x0602AE40 RID: 175680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE40")]
		[Address(RVA = "0x26AC000", Offset = "0x26AAC00", VA = "0x1826AC000")]
		private void <>xLuaBaseProxy_OnConfirm(Action P0)
		{
		}

		// Token: 0x0403DD6E RID: 253294
		[Token(Token = "0x403DD6E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, Act1VHalfIdleCharDepotCharSelectPlugin.CharDataCache> m_originCharDataCacheDict;

		// Token: 0x0403DD6F RID: 253295
		[Token(Token = "0x403DD6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInitCharSelect;

		// Token: 0x0403DD70 RID: 253296
		[Token(Token = "0x403DD70")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCharClick;

		// Token: 0x0403DD71 RID: 253297
		[Token(Token = "0x403DD71")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x0403DD72 RID: 253298
		[Token(Token = "0x403DD72")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007744 RID: 30532
		[Token(Token = "0x2007744")]
		public class CharDataCache : IHotfixable
		{
			// Token: 0x17006498 RID: 25752
			// (get) Token: 0x0602AE41 RID: 175681 RVA: 0x000DA5B0 File Offset: 0x000D87B0
			[Token(Token = "0x17006498")]
			public bool isEmpty
			{
				[Token(Token = "0x602AE41")]
				[Address(RVA = "0x26C2660", Offset = "0x26C1260", VA = "0x1826C2660")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AE42 RID: 175682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE42")]
			[Address(RVA = "0x26C2600", Offset = "0x26C1200", VA = "0x1826C2600")]
			public CharDataCache()
			{
			}

			// Token: 0x0403DD73 RID: 253299
			[Token(Token = "0x403DD73")]
			[FieldOffset(Offset = "0x10")]
			public string instId;

			// Token: 0x0403DD74 RID: 253300
			[Token(Token = "0x403DD74")]
			[FieldOffset(Offset = "0x18")]
			public string skillId;

			// Token: 0x0403DD75 RID: 253301
			[Token(Token = "0x403DD75")]
			[FieldOffset(Offset = "0x20")]
			public string equipId;

			// Token: 0x0403DD76 RID: 253302
			[Token(Token = "0x403DD76")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0403DD77 RID: 253303
			[Token(Token = "0x403DD77")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
