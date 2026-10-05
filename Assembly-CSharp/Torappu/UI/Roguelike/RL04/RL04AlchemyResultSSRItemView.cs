using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200567C RID: 22140
	[Token(Token = "0x200567C")]
	public class RL04AlchemyResultSSRItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060207B8 RID: 133048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207B8")]
		[Address(RVA = "0x1A9C8F0", Offset = "0x1A9B4F0", VA = "0x181A9C8F0")]
		public void Render(RL04AlchemyResultSsrItemViewModel ssrRewardItemViewModel)
		{
		}

		// Token: 0x060207B9 RID: 133049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207B9")]
		[Address(RVA = "0x1A9C7F0", Offset = "0x1A9B3F0", VA = "0x181A9C7F0")]
		public void OnClaimBtnClick()
		{
		}

		// Token: 0x060207BA RID: 133050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207BA")]
		[Address(RVA = "0x1A9CAC0", Offset = "0x1A9B6C0", VA = "0x181A9CAC0")]
		public RL04AlchemyResultSSRItemView()
		{
		}

		// Token: 0x0402C028 RID: 180264
		[Token(Token = "0x402C028")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgSsrReward;

		// Token: 0x0402C029 RID: 180265
		[Token(Token = "0x402C029")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtSsrRewardName;

		// Token: 0x0402C02A RID: 180266
		[Token(Token = "0x402C02A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtSsrRewardDesc;

		// Token: 0x0402C02B RID: 180267
		[Token(Token = "0x402C02B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objMultiChoiceClaimBtn;

		// Token: 0x0402C02C RID: 180268
		[Token(Token = "0x402C02C")]
		[FieldOffset(Offset = "0x38")]
		private int m_index;

		// Token: 0x0402C02D RID: 180269
		[Token(Token = "0x402C02D")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_isMulti;

		// Token: 0x0402C02E RID: 180270
		[Token(Token = "0x402C02E")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402C02F RID: 180271
		[Token(Token = "0x402C02F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C030 RID: 180272
		[Token(Token = "0x402C030")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClaimBtnClick;

		// Token: 0x0402C031 RID: 180273
		[Token(Token = "0x402C031")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
