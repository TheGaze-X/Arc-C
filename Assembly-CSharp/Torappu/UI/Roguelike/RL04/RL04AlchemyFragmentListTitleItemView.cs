using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005675 RID: 22133
	[Token(Token = "0x2005675")]
	public class RL04AlchemyFragmentListTitleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602079A RID: 133018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602079A")]
		[Address(RVA = "0x1A93F50", Offset = "0x1A92B50", VA = "0x181A93F50")]
		public void Render(RL04AlchemyAlchemyFragmentListItemTitleViewModel titleViewModel)
		{
		}

		// Token: 0x0602079B RID: 133019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602079B")]
		[Address(RVA = "0x1A94210", Offset = "0x1A92E10", VA = "0x181A94210")]
		public RL04AlchemyFragmentListTitleItemView()
		{
		}

		// Token: 0x0402BFD6 RID: 180182
		[Token(Token = "0x402BFD6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x0402BFD7 RID: 180183
		[Token(Token = "0x402BFD7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgTitleIcon;

		// Token: 0x0402BFD8 RID: 180184
		[Token(Token = "0x402BFD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtTitleName;

		// Token: 0x0402BFD9 RID: 180185
		[Token(Token = "0x402BFD9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtTitleDesc;

		// Token: 0x0402BFDA RID: 180186
		[Token(Token = "0x402BFDA")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402BFDB RID: 180187
		[Token(Token = "0x402BFDB")]
		private const string TYPE_ICON_ID_POSTFIX = "{0}_alchemy_list";

		// Token: 0x0402BFDC RID: 180188
		[Token(Token = "0x402BFDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BFDD RID: 180189
		[Token(Token = "0x402BFDD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005676 RID: 22134
		[Token(Token = "0x2005676")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL04AlchemyFragmentListTitleItemView>
		{
			// Token: 0x0602079C RID: 133020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602079C")]
			[Address(RVA = "0x1AA31F0", Offset = "0x1AA1DF0", VA = "0x181AA31F0")]
			public VirtualView(RL04AlchemyFragmentListTitleItemView prefab, RL04AlchemyAlchemyFragmentListItemTitleViewModel viewModel)
			{
			}

			// Token: 0x0602079D RID: 133021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602079D")]
			[Address(RVA = "0x1AA2AD0", Offset = "0x1AA16D0", VA = "0x181AA2AD0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0602079E RID: 133022 RVA: 0x000B6220 File Offset: 0x000B4420
			[Token(Token = "0x602079E")]
			[Address(RVA = "0x1AA2C20", Offset = "0x1AA1820", VA = "0x181AA2C20", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0602079F RID: 133023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602079F")]
			[Address(RVA = "0x1AA2F60", Offset = "0x1AA1B60", VA = "0x181AA2F60", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x060207A0 RID: 133024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207A0")]
			[Address(RVA = "0x1AA2ED0", Offset = "0x1AA1AD0", VA = "0x181AA2ED0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0402BFDE RID: 180190
			[Token(Token = "0x402BFDE")]
			[FieldOffset(Offset = "0x20")]
			private RL04AlchemyFragmentListTitleItemView m_prefab;

			// Token: 0x0402BFDF RID: 180191
			[Token(Token = "0x402BFDF")]
			[FieldOffset(Offset = "0x28")]
			private RL04AlchemyAlchemyFragmentListItemTitleViewModel m_viewModel;

			// Token: 0x0402BFE0 RID: 180192
			[Token(Token = "0x402BFE0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BFE1 RID: 180193
			[Token(Token = "0x402BFE1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402BFE2 RID: 180194
			[Token(Token = "0x402BFE2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402BFE3 RID: 180195
			[Token(Token = "0x402BFE3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402BFE4 RID: 180196
			[Token(Token = "0x402BFE4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;
		}
	}
}
