using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055E9 RID: 21993
	[Token(Token = "0x20055E9")]
	public class RL05MenuStashedTicketItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020497 RID: 132247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020497")]
		[Address(RVA = "0x1A662E0", Offset = "0x1A64EE0", VA = "0x181A662E0")]
		public void Render(RL05MenuStashedTicketItemViewModel viewModel)
		{
		}

		// Token: 0x06020498 RID: 132248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020498")]
		[Address(RVA = "0x1A66490", Offset = "0x1A65090", VA = "0x181A66490")]
		public RL05MenuStashedTicketItem()
		{
		}

		// Token: 0x0402BB04 RID: 178948
		[Token(Token = "0x402BB04")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402BB05 RID: 178949
		[Token(Token = "0x402BB05")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtTitle;

		// Token: 0x0402BB06 RID: 178950
		[Token(Token = "0x402BB06")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x0402BB07 RID: 178951
		[Token(Token = "0x402BB07")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0402BB08 RID: 178952
		[Token(Token = "0x402BB08")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _paddingHeight;

		// Token: 0x0402BB09 RID: 178953
		[Token(Token = "0x402BB09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BB0A RID: 178954
		[Token(Token = "0x402BB0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055EA RID: 21994
		[Token(Token = "0x20055EA")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL05MenuStashedTicketItem>
		{
			// Token: 0x06020499 RID: 132249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020499")]
			[Address(RVA = "0x1A743F0", Offset = "0x1A72FF0", VA = "0x181A743F0")]
			public VirtualView(RL05MenuStashedTicketItem prefab, RL05MenuStashedTicketItemViewModel viewModel)
			{
			}

			// Token: 0x0602049A RID: 132250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602049A")]
			[Address(RVA = "0x1A73D80", Offset = "0x1A72980", VA = "0x181A73D80", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0602049B RID: 132251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602049B")]
			[Address(RVA = "0x1A741B0", Offset = "0x1A72DB0", VA = "0x181A741B0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0602049C RID: 132252 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602049C")]
			[Address(RVA = "0x1A73760", Offset = "0x1A72360", VA = "0x181A73760", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0602049D RID: 132253 RVA: 0x000B5368 File Offset: 0x000B3568
			[Token(Token = "0x602049D")]
			[Address(RVA = "0x1A737D0", Offset = "0x1A723D0", VA = "0x181A737D0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0602049E RID: 132254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602049E")]
			[Address(RVA = "0x1A74300", Offset = "0x1A72F00", VA = "0x181A74300")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0402BB0B RID: 178955
			[Token(Token = "0x402BB0B")]
			[FieldOffset(Offset = "0x20")]
			private RL05MenuStashedTicketItem m_prefab;

			// Token: 0x0402BB0C RID: 178956
			[Token(Token = "0x402BB0C")]
			[FieldOffset(Offset = "0x28")]
			private RL05MenuStashedTicketItemViewModel m_viewModel;

			// Token: 0x0402BB0D RID: 178957
			[Token(Token = "0x402BB0D")]
			[FieldOffset(Offset = "0x30")]
			private TextGenerator m_textGenerator;

			// Token: 0x0402BB0E RID: 178958
			[Token(Token = "0x402BB0E")]
			[FieldOffset(Offset = "0x38")]
			private TextGenerationSettings m_textSettings;

			// Token: 0x0402BB0F RID: 178959
			[Token(Token = "0x402BB0F")]
			[FieldOffset(Offset = "0x98")]
			private bool m_isInited;

			// Token: 0x0402BB10 RID: 178960
			[Token(Token = "0x402BB10")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BB11 RID: 178961
			[Token(Token = "0x402BB11")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402BB12 RID: 178962
			[Token(Token = "0x402BB12")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402BB13 RID: 178963
			[Token(Token = "0x402BB13")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402BB14 RID: 178964
			[Token(Token = "0x402BB14")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402BB15 RID: 178965
			[Token(Token = "0x402BB15")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__InitIfNot;
		}
	}
}
