using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200592B RID: 22827
	[Token(Token = "0x200592B")]
	public class CrisisV2SettleRuneItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602140C RID: 136204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602140C")]
		[Address(RVA = "0x1B945A0", Offset = "0x1B931A0", VA = "0x181B945A0")]
		public void Render(CrisisV2SettleRuneItemViewModel viewModel, ILoadAsset loader, CrisisV2SettleViewType type)
		{
		}

		// Token: 0x0602140D RID: 136205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602140D")]
		[Address(RVA = "0x1B94870", Offset = "0x1B93470", VA = "0x181B94870")]
		public CrisisV2SettleRuneItemView()
		{
		}

		// Token: 0x0402D4EE RID: 185582
		[Token(Token = "0x402D4EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objNoInfo;

		// Token: 0x0402D4EF RID: 185583
		[Token(Token = "0x402D4EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objHasInfo;

		// Token: 0x0402D4F0 RID: 185584
		[Token(Token = "0x402D4F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtPoint;

		// Token: 0x0402D4F1 RID: 185585
		[Token(Token = "0x402D4F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgRune;

		// Token: 0x0402D4F2 RID: 185586
		[Token(Token = "0x402D4F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D4F3 RID: 185587
		[Token(Token = "0x402D4F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
