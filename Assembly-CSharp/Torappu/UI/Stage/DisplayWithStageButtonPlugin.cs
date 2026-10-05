using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006907 RID: 26887
	[Token(Token = "0x2006907")]
	public class DisplayWithStageButtonPlugin : StageButtonHolderPlugin
	{
		// Token: 0x0602682A RID: 157738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602682A")]
		[Address(RVA = "0x2191200", Offset = "0x218FE00", VA = "0x182191200", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602682B RID: 157739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602682B")]
		[Address(RVA = "0x2191260", Offset = "0x218FE60", VA = "0x182191260", Slot = "5")]
		protected override void OnRenderStage(StageViewModel model)
		{
		}

		// Token: 0x0602682C RID: 157740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602682C")]
		[Address(RVA = "0x2191300", Offset = "0x218FF00", VA = "0x182191300")]
		public DisplayWithStageButtonPlugin()
		{
		}

		// Token: 0x04036476 RID: 222326
		[Token(Token = "0x4036476")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04036477 RID: 222327
		[Token(Token = "0x4036477")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelPlugin;

		// Token: 0x04036478 RID: 222328
		[Token(Token = "0x4036478")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04036479 RID: 222329
		[Token(Token = "0x4036479")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderStage;

		// Token: 0x0403647A RID: 222330
		[Token(Token = "0x403647A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
