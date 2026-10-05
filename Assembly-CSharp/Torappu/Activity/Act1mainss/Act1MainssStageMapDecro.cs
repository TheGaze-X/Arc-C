using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007845 RID: 30789
	[Token(Token = "0x2007845")]
	public class Act1MainssStageMapDecro : MainMapDecroView
	{
		// Token: 0x0602B2ED RID: 176877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2ED")]
		[Address(RVA = "0x26F2220", Offset = "0x26F0E20", VA = "0x1826F2220")]
		public void EventOnShopClicked()
		{
		}

		// Token: 0x0602B2EE RID: 176878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2EE")]
		[Address(RVA = "0x26F23C0", Offset = "0x26F0FC0", VA = "0x1826F23C0", Slot = "4")]
		public override void Render(string actId, ZoneViewModel viewModel)
		{
		}

		// Token: 0x0602B2EF RID: 176879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2EF")]
		[Address(RVA = "0x26F2560", Offset = "0x26F1160", VA = "0x1826F2560")]
		public Act1MainssStageMapDecro()
		{
		}

		// Token: 0x0403E6C1 RID: 255681
		[Token(Token = "0x403E6C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _coinText;

		// Token: 0x0403E6C2 RID: 255682
		[Token(Token = "0x403E6C2")]
		[FieldOffset(Offset = "0x20")]
		private string m_actId;

		// Token: 0x0403E6C3 RID: 255683
		[Token(Token = "0x403E6C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnShopClicked;

		// Token: 0x0403E6C4 RID: 255684
		[Token(Token = "0x403E6C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E6C5 RID: 255685
		[Token(Token = "0x403E6C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
