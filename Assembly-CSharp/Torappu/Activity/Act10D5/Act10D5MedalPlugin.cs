using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B15 RID: 31509
	[Token(Token = "0x2007B15")]
	public class Act10D5MedalPlugin : ActivityStageSingleComponent
	{
		// Token: 0x0602C1BF RID: 180671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1BF")]
		[Address(RVA = "0x2806D90", Offset = "0x2805990", VA = "0x182806D90")]
		public void RefreshMedalPlugin(TemplateActivityMedalViewModel medalViewModel)
		{
		}

		// Token: 0x0602C1C0 RID: 180672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1C0")]
		[Address(RVA = "0x2806E90", Offset = "0x2805A90", VA = "0x182806E90")]
		private void _TryUpdateMedalPlugin(TemplateActivityMedalViewModel medalViewModel)
		{
		}

		// Token: 0x0602C1C1 RID: 180673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1C1")]
		[Address(RVA = "0x2806F60", Offset = "0x2805B60", VA = "0x182806F60")]
		public Act10D5MedalPlugin()
		{
		}

		// Token: 0x0403FF3D RID: 261949
		[Token(Token = "0x403FF3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateActivityEntryMedalPlugin _medalPlugin;

		// Token: 0x0403FF3E RID: 261950
		[Token(Token = "0x403FF3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshMedalPlugin;

		// Token: 0x0403FF3F RID: 261951
		[Token(Token = "0x403FF3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryUpdateMedalPlugin;

		// Token: 0x0403FF40 RID: 261952
		[Token(Token = "0x403FF40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
