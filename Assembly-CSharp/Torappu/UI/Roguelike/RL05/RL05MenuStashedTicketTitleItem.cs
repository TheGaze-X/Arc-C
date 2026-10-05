using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055EB RID: 21995
	[Token(Token = "0x20055EB")]
	public class RL05MenuStashedTicketTitleItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602049F RID: 132255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602049F")]
		[Address(RVA = "0x1A673B0", Offset = "0x1A65FB0", VA = "0x181A673B0")]
		private void Render(int count, int maxCount)
		{
		}

		// Token: 0x060204A0 RID: 132256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204A0")]
		[Address(RVA = "0x1A674E0", Offset = "0x1A660E0", VA = "0x181A674E0")]
		public RL05MenuStashedTicketTitleItem()
		{
		}

		// Token: 0x0402BB16 RID: 178966
		[Token(Token = "0x402BB16")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtCount;

		// Token: 0x0402BB17 RID: 178967
		[Token(Token = "0x402BB17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtMaxCount;

		// Token: 0x0402BB18 RID: 178968
		[Token(Token = "0x402BB18")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x0402BB19 RID: 178969
		[Token(Token = "0x402BB19")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0402BB1A RID: 178970
		[Token(Token = "0x402BB1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _paddingHeight;

		// Token: 0x0402BB1B RID: 178971
		[Token(Token = "0x402BB1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BB1C RID: 178972
		[Token(Token = "0x402BB1C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055EC RID: 21996
		[Token(Token = "0x20055EC")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL05MenuStashedTicketTitleItem>
		{
			// Token: 0x060204A1 RID: 132257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60204A1")]
			[Address(RVA = "0x1A744A0", Offset = "0x1A730A0", VA = "0x181A744A0")]
			public VirtualView(RL05MenuStashedTicketTitleItem prefab, int count, int maxCount)
			{
			}

			// Token: 0x060204A2 RID: 132258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60204A2")]
			[Address(RVA = "0x1A73FA0", Offset = "0x1A72BA0", VA = "0x181A73FA0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x060204A3 RID: 132259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60204A3")]
			[Address(RVA = "0x1A74150", Offset = "0x1A72D50", VA = "0x181A74150", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x060204A4 RID: 132260 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60204A4")]
			[Address(RVA = "0x1A736F0", Offset = "0x1A722F0", VA = "0x181A736F0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060204A5 RID: 132261 RVA: 0x000B5380 File Offset: 0x000B3580
			[Token(Token = "0x60204A5")]
			[Address(RVA = "0x1A73A90", Offset = "0x1A72690", VA = "0x181A73A90", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x060204A6 RID: 132262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60204A6")]
			[Address(RVA = "0x1A74210", Offset = "0x1A72E10", VA = "0x181A74210")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0402BB1D RID: 178973
			[Token(Token = "0x402BB1D")]
			[FieldOffset(Offset = "0x20")]
			private RL05MenuStashedTicketTitleItem m_prefab;

			// Token: 0x0402BB1E RID: 178974
			[Token(Token = "0x402BB1E")]
			[FieldOffset(Offset = "0x28")]
			private int m_count;

			// Token: 0x0402BB1F RID: 178975
			[Token(Token = "0x402BB1F")]
			[FieldOffset(Offset = "0x2C")]
			private int m_maxCount;

			// Token: 0x0402BB20 RID: 178976
			[Token(Token = "0x402BB20")]
			[FieldOffset(Offset = "0x30")]
			private TextGenerator m_textGenerator;

			// Token: 0x0402BB21 RID: 178977
			[Token(Token = "0x402BB21")]
			[FieldOffset(Offset = "0x38")]
			private TextGenerationSettings m_textSettings;

			// Token: 0x0402BB22 RID: 178978
			[Token(Token = "0x402BB22")]
			[FieldOffset(Offset = "0x98")]
			private bool m_isInited;

			// Token: 0x0402BB23 RID: 178979
			[Token(Token = "0x402BB23")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BB24 RID: 178980
			[Token(Token = "0x402BB24")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402BB25 RID: 178981
			[Token(Token = "0x402BB25")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402BB26 RID: 178982
			[Token(Token = "0x402BB26")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402BB27 RID: 178983
			[Token(Token = "0x402BB27")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402BB28 RID: 178984
			[Token(Token = "0x402BB28")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__InitIfNot;
		}
	}
}
