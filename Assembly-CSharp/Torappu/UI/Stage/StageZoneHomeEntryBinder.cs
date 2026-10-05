using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067A6 RID: 26534
	[Token(Token = "0x20067A6")]
	public class StageZoneHomeEntryBinder : DataBinder<ZoneHomeEntryGroupProp>, IHotfixable
	{
		// Token: 0x17005A04 RID: 23044
		// (get) Token: 0x060260E3 RID: 155875 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060260E4 RID: 155876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A04")]
		public Action<ZoneHomeEntryItemModel> onEntryClicked
		{
			[Token(Token = "0x60260E3")]
			[Address(RVA = "0x211F590", Offset = "0x211E190", VA = "0x18211F590")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60260E4")]
			[Address(RVA = "0x211F5F0", Offset = "0x211E1F0", VA = "0x18211F5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060260E5 RID: 155877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260E5")]
		[Address(RVA = "0x211F250", Offset = "0x211DE50", VA = "0x18211F250", Slot = "7")]
		public override void OnValueChanged(ZoneHomeEntryGroupProp property)
		{
		}

		// Token: 0x060260E6 RID: 155878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260E6")]
		[Address(RVA = "0x211F400", Offset = "0x211E000", VA = "0x18211F400")]
		private void _OnEntryClicked(ZoneHomeEntryItemModel viewModel)
		{
		}

		// Token: 0x060260E7 RID: 155879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260E7")]
		[Address(RVA = "0x211F520", Offset = "0x211E120", VA = "0x18211F520")]
		public StageZoneHomeEntryBinder()
		{
		}

		// Token: 0x040358E5 RID: 219365
		[Token(Token = "0x40358E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageZoneHomeEntryLayout _entryLayout;

		// Token: 0x040358E7 RID: 219367
		[Token(Token = "0x40358E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEntryClicked;

		// Token: 0x040358E8 RID: 219368
		[Token(Token = "0x40358E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEntryClicked;

		// Token: 0x040358E9 RID: 219369
		[Token(Token = "0x40358E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040358EA RID: 219370
		[Token(Token = "0x40358EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnEntryClicked;

		// Token: 0x040358EB RID: 219371
		[Token(Token = "0x40358EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
