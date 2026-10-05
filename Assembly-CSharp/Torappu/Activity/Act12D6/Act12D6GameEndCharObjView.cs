using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Roguelike;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AE2 RID: 31458
	[Token(Token = "0x2007AE2")]
	public class Act12D6GameEndCharObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C0F7 RID: 180471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0F7")]
		[Address(RVA = "0x27ED430", Offset = "0x27EC030", VA = "0x1827ED430")]
		public void Render(RoguelikeCharCardViewModel viewModel)
		{
		}

		// Token: 0x0602C0F8 RID: 180472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0F8")]
		[Address(RVA = "0x27ED610", Offset = "0x27EC210", VA = "0x1827ED610")]
		public Act12D6GameEndCharObjView()
		{
		}

		// Token: 0x0403FD50 RID: 261456
		[Token(Token = "0x403FD50")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imagePotrait;

		// Token: 0x0403FD51 RID: 261457
		[Token(Token = "0x403FD51")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageEvolvePhase;

		// Token: 0x0403FD52 RID: 261458
		[Token(Token = "0x403FD52")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageUpgraded;

		// Token: 0x0403FD53 RID: 261459
		[Token(Token = "0x403FD53")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageFreeChar;

		// Token: 0x0403FD54 RID: 261460
		[Token(Token = "0x403FD54")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageNpcChar;

		// Token: 0x0403FD55 RID: 261461
		[Token(Token = "0x403FD55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FD56 RID: 261462
		[Token(Token = "0x403FD56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
