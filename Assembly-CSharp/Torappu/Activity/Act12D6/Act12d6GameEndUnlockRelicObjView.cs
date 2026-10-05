using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AEE RID: 31470
	[Token(Token = "0x2007AEE")]
	public class Act12d6GameEndUnlockRelicObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C12A RID: 180522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C12A")]
		[Address(RVA = "0x27FE3D0", Offset = "0x27FCFD0", VA = "0x1827FE3D0")]
		public void Render(RoguelikeRelicViewModel viewModel)
		{
		}

		// Token: 0x0602C12B RID: 180523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C12B")]
		[Address(RVA = "0x27FE480", Offset = "0x27FD080", VA = "0x1827FE480")]
		public Act12d6GameEndUnlockRelicObjView()
		{
		}

		// Token: 0x0403FDCC RID: 261580
		[Token(Token = "0x403FDCC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0403FDCD RID: 261581
		[Token(Token = "0x403FDCD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403FDCE RID: 261582
		[Token(Token = "0x403FDCE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textUnlockCond;

		// Token: 0x0403FDCF RID: 261583
		[Token(Token = "0x403FDCF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FDD0 RID: 261584
		[Token(Token = "0x403FDD0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
