using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act27side
{
	// Token: 0x020074BC RID: 29884
	[Token(Token = "0x20074BC")]
	public class Act27sideMistStagePlugin : SimpleActivityStageButtonOnMapPlugin, IHotfixable
	{
		// Token: 0x0602A255 RID: 172629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A255")]
		[Address(RVA = "0x25D1DB0", Offset = "0x25D09B0", VA = "0x1825D1DB0", Slot = "4")]
		public override void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x0602A256 RID: 172630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A256")]
		[Address(RVA = "0x25D2020", Offset = "0x25D0C20", VA = "0x1825D2020")]
		public Act27sideMistStagePlugin()
		{
		}

		// Token: 0x0403C8B9 RID: 247993
		[Token(Token = "0x403C8B9")]
		private const string MIST_TARGET_FORMAT = "/{0}";

		// Token: 0x0403C8BA RID: 247994
		[Token(Token = "0x403C8BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _mistCountText;

		// Token: 0x0403C8BB RID: 247995
		[Token(Token = "0x403C8BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _mistTargetText;

		// Token: 0x0403C8BC RID: 247996
		[Token(Token = "0x403C8BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x0403C8BD RID: 247997
		[Token(Token = "0x403C8BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
