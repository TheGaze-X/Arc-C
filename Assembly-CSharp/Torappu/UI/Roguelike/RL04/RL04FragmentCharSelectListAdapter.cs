using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056BF RID: 22207
	[Token(Token = "0x20056BF")]
	public class RL04FragmentCharSelectListAdapter : LoopScrollAdapter<RL04FragmentCharSelectListAdapter.ViewHolder, RL04FragmentCharSelectDialog.RL04FragmentCharViewModel>
	{
		// Token: 0x17004C52 RID: 19538
		// (get) Token: 0x0602091D RID: 133405 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602091E RID: 133406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C52")]
		public List<int> selectedChar
		{
			[Token(Token = "0x602091D")]
			[Address(RVA = "0x1AAA100", Offset = "0x1AA8D00", VA = "0x181AAA100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602091E")]
			[Address(RVA = "0x1AAA1E0", Offset = "0x1AA8DE0", VA = "0x181AAA1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C53 RID: 19539
		// (get) Token: 0x0602091F RID: 133407 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020920 RID: 133408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C53")]
		public Action<int> onCardClicked
		{
			[Token(Token = "0x602091F")]
			[Address(RVA = "0x1AAA0A0", Offset = "0x1AA8CA0", VA = "0x181AAA0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020920")]
			[Address(RVA = "0x1AAA160", Offset = "0x1AA8D60", VA = "0x181AAA160")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020921 RID: 133409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020921")]
		[Address(RVA = "0x1AA9C50", Offset = "0x1AA8850", VA = "0x181AA9C50", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RL04FragmentCharSelectListAdapter.ViewHolder holder, RL04FragmentCharSelectDialog.RL04FragmentCharViewModel data)
		{
		}

		// Token: 0x06020922 RID: 133410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020922")]
		[Address(RVA = "0x1AA9BA0", Offset = "0x1AA87A0", VA = "0x181AA9BA0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06020923 RID: 133411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020923")]
		[Address(RVA = "0x1AAA030", Offset = "0x1AA8C30", VA = "0x181AAA030")]
		public RL04FragmentCharSelectListAdapter()
		{
		}

		// Token: 0x0402C21A RID: 180762
		[Token(Token = "0x402C21A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _viewPrefab;

		// Token: 0x0402C21D RID: 180765
		[Token(Token = "0x402C21D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedChar;

		// Token: 0x0402C21E RID: 180766
		[Token(Token = "0x402C21E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedChar;

		// Token: 0x0402C21F RID: 180767
		[Token(Token = "0x402C21F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCardClicked;

		// Token: 0x0402C220 RID: 180768
		[Token(Token = "0x402C220")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCardClicked;

		// Token: 0x0402C221 RID: 180769
		[Token(Token = "0x402C221")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402C222 RID: 180770
		[Token(Token = "0x402C222")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402C223 RID: 180771
		[Token(Token = "0x402C223")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056C0 RID: 22208
		[Token(Token = "0x20056C0")]
		public class ViewHolder
		{
			// Token: 0x06020924 RID: 133412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020924")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402C224 RID: 180772
			[Token(Token = "0x402C224")]
			[FieldOffset(Offset = "0x10")]
			public RL04FragmentCharCardView view;
		}
	}
}
