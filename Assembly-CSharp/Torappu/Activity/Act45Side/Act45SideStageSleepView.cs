using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072D0 RID: 29392
	[Token(Token = "0x20072D0")]
	public class Act45SideStageSleepView : Act45SideStageBaseView
	{
		// Token: 0x0602999E RID: 170398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602999E")]
		[Address(RVA = "0x24FD7E0", Offset = "0x24FC3E0", VA = "0x1824FD7E0", Slot = "4")]
		public override void Render(bool isActive, Act45SideLiveViewModel viewModel)
		{
		}

		// Token: 0x0602999F RID: 170399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602999F")]
		[Address(RVA = "0x24FD9D0", Offset = "0x24FC5D0", VA = "0x1824FD9D0", Slot = "8")]
		protected override void _SetUpIfNot(Act45SideLiveViewModel viewModel)
		{
		}

		// Token: 0x060299A0 RID: 170400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299A0")]
		[Address(RVA = "0x24FD940", Offset = "0x24FC540", VA = "0x1824FD940", Slot = "7")]
		protected override void _PlayCurtainOutAudio()
		{
		}

		// Token: 0x060299A1 RID: 170401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299A1")]
		[Address(RVA = "0x24FDCF0", Offset = "0x24FC8F0", VA = "0x1824FDCF0")]
		public Act45SideStageSleepView()
		{
		}

		// Token: 0x060299A2 RID: 170402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299A2")]
		[Address(RVA = "0x24FD930", Offset = "0x24FC530", VA = "0x1824FD930")]
		private void <>xLuaBaseProxy_Render(bool P0, Act45SideLiveViewModel P1)
		{
		}

		// Token: 0x060299A3 RID: 170403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299A3")]
		[Address(RVA = "0x24FD460", Offset = "0x24FC060", VA = "0x1824FD460")]
		private void <>xLuaBaseProxy__SetUpIfNot(Act45SideLiveViewModel P0)
		{
		}

		// Token: 0x060299A4 RID: 170404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299A4")]
		[Address(RVA = "0x24FCEB0", Offset = "0x24FBAB0", VA = "0x1824FCEB0")]
		private void <>xLuaBaseProxy__PlayCurtainOutAudio()
		{
		}

		// Token: 0x0403B7F9 RID: 243705
		[Token(Token = "0x403B7F9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act45SideStageSleepView.SleepChar[] _chars;

		// Token: 0x0403B7FA RID: 243706
		[Token(Token = "0x403B7FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B7FB RID: 243707
		[Token(Token = "0x403B7FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetUpIfNot;

		// Token: 0x0403B7FC RID: 243708
		[Token(Token = "0x403B7FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayCurtainOutAudio;

		// Token: 0x0403B7FD RID: 243709
		[Token(Token = "0x403B7FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072D1 RID: 29393
		[Token(Token = "0x20072D1")]
		[Serializable]
		private class SleepChar
		{
			// Token: 0x060299A5 RID: 170405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60299A5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SleepChar()
			{
			}

			// Token: 0x0403B7FE RID: 243710
			[Token(Token = "0x403B7FE")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0403B7FF RID: 243711
			[Token(Token = "0x403B7FF")]
			[FieldOffset(Offset = "0x18")]
			public GameObject charLight;

			// Token: 0x0403B800 RID: 243712
			[Token(Token = "0x403B800")]
			[FieldOffset(Offset = "0x20")]
			public Act45SideSleepCharCardView card;

			// Token: 0x0403B801 RID: 243713
			[Token(Token = "0x403B801")]
			[FieldOffset(Offset = "0x28")]
			public TwoStateToggle toggle;
		}
	}
}
