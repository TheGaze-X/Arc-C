using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B0F RID: 31503
	[Token(Token = "0x2007B0F")]
	public class Act12D6RelicHandBookItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006752 RID: 26450
		// (get) Token: 0x0602C1AC RID: 180652 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C1AD RID: 180653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006752")]
		public UIStringEvent onRelicClicked
		{
			[Token(Token = "0x602C1AC")]
			[Address(RVA = "0x2811940", Offset = "0x2810540", VA = "0x182811940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C1AD")]
			[Address(RVA = "0x28119A0", Offset = "0x28105A0", VA = "0x1828119A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C1AE RID: 180654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1AE")]
		[Address(RVA = "0x2811670", Offset = "0x2810270", VA = "0x182811670")]
		public void Render(PlayerRelicHandBookData relicData, bool chosen)
		{
		}

		// Token: 0x0602C1AF RID: 180655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1AF")]
		[Address(RVA = "0x2811550", Offset = "0x2810150", VA = "0x182811550")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602C1B0 RID: 180656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1B0")]
		[Address(RVA = "0x28118D0", Offset = "0x28104D0", VA = "0x1828118D0")]
		public Act12D6RelicHandBookItemView()
		{
		}

		// Token: 0x0403FF13 RID: 261907
		[Token(Token = "0x403FF13")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgRelicIcon;

		// Token: 0x0403FF14 RID: 261908
		[Token(Token = "0x403FF14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageChosen;

		// Token: 0x0403FF15 RID: 261909
		[Token(Token = "0x403FF15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403FF16 RID: 261910
		[Token(Token = "0x403FF16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403FF17 RID: 261911
		[Token(Token = "0x403FF17")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _imageLock;

		// Token: 0x0403FF18 RID: 261912
		[Token(Token = "0x403FF18")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgRelicBg;

		// Token: 0x0403FF19 RID: 261913
		[Token(Token = "0x403FF19")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _lockedBgColor;

		// Token: 0x0403FF1A RID: 261914
		[Token(Token = "0x403FF1A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _unlockedBgColor;

		// Token: 0x0403FF1B RID: 261915
		[Token(Token = "0x403FF1B")]
		[FieldOffset(Offset = "0x68")]
		private string m_relicId;

		// Token: 0x0403FF1D RID: 261917
		[Token(Token = "0x403FF1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRelicClicked;

		// Token: 0x0403FF1E RID: 261918
		[Token(Token = "0x403FF1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRelicClicked;

		// Token: 0x0403FF1F RID: 261919
		[Token(Token = "0x403FF1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FF20 RID: 261920
		[Token(Token = "0x403FF20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403FF21 RID: 261921
		[Token(Token = "0x403FF21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
