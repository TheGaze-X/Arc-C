using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077C3 RID: 30659
	[Token(Token = "0x20077C3")]
	public class Act1VHalfIdleDirectGachaSelectCharSingleCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B08D RID: 176269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B08D")]
		[Address(RVA = "0x26D88F0", Offset = "0x26D74F0", VA = "0x1826D88F0")]
		public void Render(Act1VHalfIdleDirectGachaSelectDialog.GachaSelectCharViewModel viewModel, string selectedCharId)
		{
		}

		// Token: 0x0602B08E RID: 176270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B08E")]
		[Address(RVA = "0x26D8800", Offset = "0x26D7400", VA = "0x1826D8800")]
		public void OnCharBtnClicked()
		{
		}

		// Token: 0x0602B08F RID: 176271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B08F")]
		[Address(RVA = "0x26D8A80", Offset = "0x26D7680", VA = "0x1826D8A80")]
		public Act1VHalfIdleDirectGachaSelectCharSingleCharView()
		{
		}

		// Token: 0x0403E255 RID: 254549
		[Token(Token = "0x403E255")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgCharAvatar;

		// Token: 0x0403E256 RID: 254550
		[Token(Token = "0x403E256")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0403E257 RID: 254551
		[Token(Token = "0x403E257")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlSelected;

		// Token: 0x0403E258 RID: 254552
		[Token(Token = "0x403E258")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlGained;

		// Token: 0x0403E259 RID: 254553
		[Token(Token = "0x403E259")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasRaycast;

		// Token: 0x0403E25A RID: 254554
		[Token(Token = "0x403E25A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlDisabled;

		// Token: 0x0403E25B RID: 254555
		[Token(Token = "0x403E25B")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedCharId;

		// Token: 0x0403E25C RID: 254556
		[Token(Token = "0x403E25C")]
		[FieldOffset(Offset = "0x50")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0403E25D RID: 254557
		[Token(Token = "0x403E25D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E25E RID: 254558
		[Token(Token = "0x403E25E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCharBtnClicked;

		// Token: 0x0403E25F RID: 254559
		[Token(Token = "0x403E25F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
