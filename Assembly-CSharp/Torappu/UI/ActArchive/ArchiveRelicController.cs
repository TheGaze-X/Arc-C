using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C04 RID: 27652
	[Token(Token = "0x2006C04")]
	public class ArchiveRelicController : ActArchiveController
	{
		// Token: 0x17005D2D RID: 23853
		// (get) Token: 0x060277BD RID: 161725 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060277BE RID: 161726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D2D")]
		public Action<ActArchiveType, string> onRelicItemClicked
		{
			[Token(Token = "0x60277BD")]
			[Address(RVA = "0x22ADD00", Offset = "0x22AC900", VA = "0x1822ADD00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60277BE")]
			[Address(RVA = "0x22ADE40", Offset = "0x22ACA40", VA = "0x1822ADE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D2E RID: 23854
		// (get) Token: 0x060277BF RID: 161727 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060277C0 RID: 161728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D2E")]
		public Action<FilterRule> onFilterMethodClicked
		{
			[Token(Token = "0x60277BF")]
			[Address(RVA = "0x22ADCA0", Offset = "0x22AC8A0", VA = "0x1822ADCA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60277C0")]
			[Address(RVA = "0x22ADDC0", Offset = "0x22AC9C0", VA = "0x1822ADDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D2F RID: 23855
		// (get) Token: 0x060277C1 RID: 161729 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060277C2 RID: 161730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D2F")]
		public Action<int> onSwitchDifficultyClicked
		{
			[Token(Token = "0x60277C1")]
			[Address(RVA = "0x22ADD60", Offset = "0x22AC960", VA = "0x1822ADD60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60277C2")]
			[Address(RVA = "0x22ADEC0", Offset = "0x22ACAC0", VA = "0x1822ADEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060277C3 RID: 161731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277C3")]
		[Address(RVA = "0x22AD900", Offset = "0x22AC500", VA = "0x1822AD900", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x060277C4 RID: 161732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60277C4")]
		[Address(RVA = "0x22AD590", Offset = "0x22AC190", VA = "0x1822AD590")]
		public List<DataBinder<RelicProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x060277C5 RID: 161733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277C5")]
		[Address(RVA = "0x22AD7E0", Offset = "0x22AC3E0", VA = "0x1822AD7E0")]
		public void OnFilterMethodClick(FilterRule rule)
		{
		}

		// Token: 0x060277C6 RID: 161734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277C6")]
		[Address(RVA = "0x22ADB30", Offset = "0x22AC730", VA = "0x1822ADB30")]
		public void OnSwitchForwardClicked()
		{
		}

		// Token: 0x060277C7 RID: 161735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277C7")]
		[Address(RVA = "0x22ADA20", Offset = "0x22AC620", VA = "0x1822ADA20")]
		public void OnSwitchBackwardClicked()
		{
		}

		// Token: 0x060277C8 RID: 161736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277C8")]
		[Address(RVA = "0x22AD6C0", Offset = "0x22AC2C0", VA = "0x1822AD6C0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060277C9 RID: 161737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277C9")]
		[Address(RVA = "0x22ADC40", Offset = "0x22AC840", VA = "0x1822ADC40")]
		public ArchiveRelicController()
		{
		}

		// Token: 0x060277CA RID: 161738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277CA")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x060277CB RID: 161739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277CB")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x04037F60 RID: 229216
		[Token(Token = "0x4037F60")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveRelicListDataBinder _relicDataBinder;

		// Token: 0x04037F61 RID: 229217
		[Token(Token = "0x4037F61")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04037F65 RID: 229221
		[Token(Token = "0x4037F65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRelicItemClicked;

		// Token: 0x04037F66 RID: 229222
		[Token(Token = "0x4037F66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRelicItemClicked;

		// Token: 0x04037F67 RID: 229223
		[Token(Token = "0x4037F67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onFilterMethodClicked;

		// Token: 0x04037F68 RID: 229224
		[Token(Token = "0x4037F68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onFilterMethodClicked;

		// Token: 0x04037F69 RID: 229225
		[Token(Token = "0x4037F69")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onSwitchDifficultyClicked;

		// Token: 0x04037F6A RID: 229226
		[Token(Token = "0x4037F6A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onSwitchDifficultyClicked;

		// Token: 0x04037F6B RID: 229227
		[Token(Token = "0x4037F6B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037F6C RID: 229228
		[Token(Token = "0x4037F6C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037F6D RID: 229229
		[Token(Token = "0x4037F6D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFilterMethodClick;

		// Token: 0x04037F6E RID: 229230
		[Token(Token = "0x4037F6E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnSwitchForwardClicked;

		// Token: 0x04037F6F RID: 229231
		[Token(Token = "0x4037F6F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnSwitchBackwardClicked;

		// Token: 0x04037F70 RID: 229232
		[Token(Token = "0x4037F70")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037F71 RID: 229233
		[Token(Token = "0x4037F71")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
