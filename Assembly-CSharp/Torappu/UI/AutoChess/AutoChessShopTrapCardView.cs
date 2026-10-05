using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006382 RID: 25474
	[Token(Token = "0x2006382")]
	public class AutoChessShopTrapCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024BF5 RID: 150517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BF5")]
		[Address(RVA = "0x1FA37A0", Offset = "0x1FA23A0", VA = "0x181FA37A0")]
		public void Render(AutoChessShopTrapCardViewModel trapCardViewModel)
		{
		}

		// Token: 0x06024BF6 RID: 150518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BF6")]
		[Address(RVA = "0x1FA36A0", Offset = "0x1FA22A0", VA = "0x181FA36A0")]
		public void OnItemClick()
		{
		}

		// Token: 0x06024BF7 RID: 150519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BF7")]
		[Address(RVA = "0x1FA3980", Offset = "0x1FA2580", VA = "0x181FA3980")]
		public AutoChessShopTrapCardView()
		{
		}

		// Token: 0x04033562 RID: 210274
		[Token(Token = "0x4033562")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgItemIcon;

		// Token: 0x04033563 RID: 210275
		[Token(Token = "0x4033563")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtItemName;

		// Token: 0x04033564 RID: 210276
		[Token(Token = "0x4033564")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtItemDesc;

		// Token: 0x04033565 RID: 210277
		[Token(Token = "0x4033565")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgChessLevel;

		// Token: 0x04033566 RID: 210278
		[Token(Token = "0x4033566")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedChessId;

		// Token: 0x04033567 RID: 210279
		[Token(Token = "0x4033567")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_finder;

		// Token: 0x04033568 RID: 210280
		[Token(Token = "0x4033568")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04033569 RID: 210281
		[Token(Token = "0x4033569")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403356A RID: 210282
		[Token(Token = "0x403356A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403356B RID: 210283
		[Token(Token = "0x403356B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
