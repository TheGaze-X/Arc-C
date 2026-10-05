using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056D3 RID: 22227
	[Token(Token = "0x20056D3")]
	public class RL04FragmentListAdapter : LoopScrollAdapter<RL04FragmentListAdapter.ViewHolder, RL04FragmentItemGroupViewModel>, IHotfixable
	{
		// Token: 0x17004C60 RID: 19552
		// (get) Token: 0x06020991 RID: 133521 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020992 RID: 133522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C60")]
		public ILoadAsset loader
		{
			[Token(Token = "0x6020991")]
			[Address(RVA = "0x1ABE300", Offset = "0x1ABCF00", VA = "0x181ABE300")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020992")]
			[Address(RVA = "0x1ABE3C0", Offset = "0x1ABCFC0", VA = "0x181ABE3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C61 RID: 19553
		// (get) Token: 0x06020993 RID: 133523 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020994 RID: 133524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C61")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x6020993")]
			[Address(RVA = "0x1ABE360", Offset = "0x1ABCF60", VA = "0x181ABE360")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6020994")]
			[Address(RVA = "0x1ABE440", Offset = "0x1ABD040", VA = "0x181ABE440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020995 RID: 133525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020995")]
		[Address(RVA = "0x1ABDEB0", Offset = "0x1ABCAB0", VA = "0x181ABDEB0")]
		public void RenderFragmentList(RL04FragmentViewModel model)
		{
		}

		// Token: 0x06020996 RID: 133526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020996")]
		[Address(RVA = "0x1ABDE00", Offset = "0x1ABCA00", VA = "0x181ABDE00", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06020997 RID: 133527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020997")]
		[Address(RVA = "0x1ABE000", Offset = "0x1ABCC00", VA = "0x181ABE000", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, RL04FragmentListAdapter.ViewHolder holder, RL04FragmentItemGroupViewModel data)
		{
		}

		// Token: 0x06020998 RID: 133528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020998")]
		[Address(RVA = "0x1ABE290", Offset = "0x1ABCE90", VA = "0x181ABE290")]
		public RL04FragmentListAdapter()
		{
		}

		// Token: 0x0402C303 RID: 180995
		[Token(Token = "0x402C303")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0402C304 RID: 180996
		[Token(Token = "0x402C304")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedFocusSequence;

		// Token: 0x0402C305 RID: 180997
		[Token(Token = "0x402C305")]
		[FieldOffset(Offset = "0x64")]
		private RoguelikeFragmentDialogListType m_cachedListType;

		// Token: 0x0402C308 RID: 181000
		[Token(Token = "0x402C308")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0402C309 RID: 181001
		[Token(Token = "0x402C309")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0402C30A RID: 181002
		[Token(Token = "0x402C30A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0402C30B RID: 181003
		[Token(Token = "0x402C30B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0402C30C RID: 181004
		[Token(Token = "0x402C30C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderFragmentList;

		// Token: 0x0402C30D RID: 181005
		[Token(Token = "0x402C30D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402C30E RID: 181006
		[Token(Token = "0x402C30E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402C30F RID: 181007
		[Token(Token = "0x402C30F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056D4 RID: 22228
		[Token(Token = "0x20056D4")]
		public class ViewHolder
		{
			// Token: 0x06020999 RID: 133529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020999")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402C310 RID: 181008
			[Token(Token = "0x402C310")]
			[FieldOffset(Offset = "0x10")]
			public RL04FragmentGroupView view;
		}
	}
}
