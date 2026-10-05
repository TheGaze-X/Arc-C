using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200527C RID: 21116
	[Token(Token = "0x200527C")]
	public class RoguelikeFocusRollNodePlugin : RoguelikeFocusPlugin
	{
		// Token: 0x0601F289 RID: 127625 RVA: 0x000B10A8 File Offset: 0x000AF2A8
		[Token(Token = "0x601F289")]
		[Address(RVA = "0x18ECA50", Offset = "0x18EB650", VA = "0x1818ECA50", Slot = "4")]
		public override bool Render(RoguelikeFocusViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601F28A RID: 127626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F28A")]
		[Address(RVA = "0x18ECB90", Offset = "0x18EB790", VA = "0x1818ECB90")]
		public RoguelikeFocusRollNodePlugin()
		{
		}

		// Token: 0x04029CEF RID: 171247
		[Token(Token = "0x4029CEF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelRoll;

		// Token: 0x04029CF0 RID: 171248
		[Token(Token = "0x4029CF0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNoCount;

		// Token: 0x04029CF1 RID: 171249
		[Token(Token = "0x4029CF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029CF2 RID: 171250
		[Token(Token = "0x4029CF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
