using System;
using Il2CppDummyDll;
using Torappu.Activity.Act1Lock.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078DA RID: 30938
	[Token(Token = "0x20078DA")]
	public class Act1LockBattleFinishCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B628 RID: 177704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B628")]
		[Address(RVA = "0x2754070", Offset = "0x2752C70", VA = "0x182754070")]
		public void Render(DefendCharModel viewModel)
		{
		}

		// Token: 0x0602B629 RID: 177705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B629")]
		[Address(RVA = "0x2754210", Offset = "0x2752E10", VA = "0x182754210")]
		public Act1LockBattleFinishCharView()
		{
		}

		// Token: 0x0403EBD5 RID: 256981
		[Token(Token = "0x403EBD5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1LockCharCardView _cardPrefab;

		// Token: 0x0403EBD6 RID: 256982
		[Token(Token = "0x403EBD6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cardContainer;

		// Token: 0x0403EBD7 RID: 256983
		[Token(Token = "0x403EBD7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageEvacuate;

		// Token: 0x0403EBD8 RID: 256984
		[Token(Token = "0x403EBD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageEnter;

		// Token: 0x0403EBD9 RID: 256985
		[Token(Token = "0x403EBD9")]
		[FieldOffset(Offset = "0x38")]
		private Act1LockCharCardView m_card;

		// Token: 0x0403EBDA RID: 256986
		[Token(Token = "0x403EBDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EBDB RID: 256987
		[Token(Token = "0x403EBDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
