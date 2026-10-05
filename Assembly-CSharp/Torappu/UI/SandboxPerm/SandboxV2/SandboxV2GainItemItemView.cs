using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004304 RID: 17156
	[Token(Token = "0x2004304")]
	public class SandboxV2GainItemItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x0601A5BD RID: 107965 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A5BE RID: 107966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E8B")]
		public Action<int> onItemClicked
		{
			[Token(Token = "0x601A5BD")]
			[Address(RVA = "0x134B550", Offset = "0x134A150", VA = "0x18134B550")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A5BE")]
			[Address(RVA = "0x134B5B0", Offset = "0x134A1B0", VA = "0x18134B5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A5BF RID: 107967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5BF")]
		[Address(RVA = "0x134B160", Offset = "0x1349D60", VA = "0x18134B160")]
		public void Render(int position, UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x0601A5C0 RID: 107968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5C0")]
		[Address(RVA = "0x134B380", Offset = "0x1349F80", VA = "0x18134B380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A5C1 RID: 107969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5C1")]
		[Address(RVA = "0x134B4E0", Offset = "0x134A0E0", VA = "0x18134B4E0")]
		public SandboxV2GainItemItemView()
		{
		}

		// Token: 0x04021773 RID: 137075
		[Token(Token = "0x4021773")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x04021774 RID: 137076
		[Token(Token = "0x4021774")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x04021775 RID: 137077
		[Token(Token = "0x4021775")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _cardScale;

		// Token: 0x04021776 RID: 137078
		[Token(Token = "0x4021776")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_hasInited;

		// Token: 0x04021777 RID: 137079
		[Token(Token = "0x4021777")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x04021779 RID: 137081
		[Token(Token = "0x4021779")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0402177A RID: 137082
		[Token(Token = "0x402177A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0402177B RID: 137083
		[Token(Token = "0x402177B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402177C RID: 137084
		[Token(Token = "0x402177C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402177D RID: 137085
		[Token(Token = "0x402177D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
