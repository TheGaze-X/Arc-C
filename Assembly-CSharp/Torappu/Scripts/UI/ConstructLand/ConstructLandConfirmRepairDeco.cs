using System;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Scripts.UI.ConstructLand
{
	// Token: 0x020017AB RID: 6059
	[Token(Token = "0x20017AB")]
	public class ConstructLandConfirmRepairDeco : SandboxV2ConfirmDialogDecoViewBase
	{
		// Token: 0x06009911 RID: 39185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009911")]
		[Address(RVA = "0x313DA30", Offset = "0x313C630", VA = "0x18313DA30", Slot = "4")]
		public override void RenderDecoView(object param)
		{
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009912")]
		[Address(RVA = "0x313DC40", Offset = "0x313C840", VA = "0x18313DC40")]
		public ConstructLandConfirmRepairDeco()
		{
		}

		// Token: 0x04008F32 RID: 36658
		[Token(Token = "0x4008F32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _fromText;

		// Token: 0x04008F33 RID: 36659
		[Token(Token = "0x4008F33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _toText;

		// Token: 0x04008F34 RID: 36660
		[Token(Token = "0x4008F34")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04008F35 RID: 36661
		[Token(Token = "0x4008F35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderDecoView;

		// Token: 0x04008F36 RID: 36662
		[Token(Token = "0x4008F36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
