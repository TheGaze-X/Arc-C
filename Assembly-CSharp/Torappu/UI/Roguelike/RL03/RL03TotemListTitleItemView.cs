using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200586F RID: 22639
	[Token(Token = "0x200586F")]
	public class RL03TotemListTitleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021103 RID: 135427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021103")]
		[Address(RVA = "0x1B6B800", Offset = "0x1B6A400", VA = "0x181B6B800")]
		public void Render(RL03TotemListTitleViewModel viewModel)
		{
		}

		// Token: 0x06021104 RID: 135428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021104")]
		[Address(RVA = "0x1B6B8A0", Offset = "0x1B6A4A0", VA = "0x181B6B8A0")]
		public RL03TotemListTitleItemView()
		{
		}

		// Token: 0x0402D004 RID: 184324
		[Token(Token = "0x402D004")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLocation;

		// Token: 0x0402D005 RID: 184325
		[Token(Token = "0x402D005")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEffect;

		// Token: 0x0402D006 RID: 184326
		[Token(Token = "0x402D006")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x0402D007 RID: 184327
		[Token(Token = "0x402D007")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D008 RID: 184328
		[Token(Token = "0x402D008")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005870 RID: 22640
		[Token(Token = "0x2005870")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL03TotemListTitleItemView>
		{
			// Token: 0x06021105 RID: 135429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021105")]
			[Address(RVA = "0x1B70520", Offset = "0x1B6F120", VA = "0x181B70520")]
			public VirtualView(RL03TotemListTitleItemView prefab, RL03TotemListTitleViewModel viewModel)
			{
			}

			// Token: 0x06021106 RID: 135430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021106")]
			[Address(RVA = "0x1B6FDA0", Offset = "0x1B6E9A0", VA = "0x181B6FDA0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06021107 RID: 135431 RVA: 0x000B8638 File Offset: 0x000B6838
			[Token(Token = "0x6021107")]
			[Address(RVA = "0x1B6FEF0", Offset = "0x1B6EAF0", VA = "0x181B6FEF0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06021108 RID: 135432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021108")]
			[Address(RVA = "0x1B70120", Offset = "0x1B6ED20", VA = "0x181B70120", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06021109 RID: 135433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021109")]
			[Address(RVA = "0x1B6FF60", Offset = "0x1B6EB60", VA = "0x181B6FF60", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0402D009 RID: 184329
			[Token(Token = "0x402D009")]
			[FieldOffset(Offset = "0x20")]
			private RL03TotemListTitleItemView m_prefab;

			// Token: 0x0402D00A RID: 184330
			[Token(Token = "0x402D00A")]
			[FieldOffset(Offset = "0x28")]
			private RL03TotemListTitleViewModel m_viewModel;

			// Token: 0x0402D00B RID: 184331
			[Token(Token = "0x402D00B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402D00C RID: 184332
			[Token(Token = "0x402D00C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402D00D RID: 184333
			[Token(Token = "0x402D00D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402D00E RID: 184334
			[Token(Token = "0x402D00E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402D00F RID: 184335
			[Token(Token = "0x402D00F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;
		}
	}
}
