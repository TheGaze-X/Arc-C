using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200592D RID: 22829
	[Token(Token = "0x200592D")]
	public class CrisisV2SettleRuneListAdapter : LoopScrollAdapter<CrisisV2SettleRuneItemViewHolder, CrisisV2SettleRuneItemViewModel>
	{
		// Token: 0x17004E02 RID: 19970
		// (get) Token: 0x0602140F RID: 136207 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021410 RID: 136208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E02")]
		public ILoadAsset loader
		{
			[Token(Token = "0x602140F")]
			[Address(RVA = "0x1B94BC0", Offset = "0x1B937C0", VA = "0x181B94BC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6021410")]
			[Address(RVA = "0x1B94C80", Offset = "0x1B93880", VA = "0x181B94C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004E03 RID: 19971
		// (get) Token: 0x06021411 RID: 136209 RVA: 0x000B9238 File Offset: 0x000B7438
		// (set) Token: 0x06021412 RID: 136210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E03")]
		public CrisisV2SettleViewType type
		{
			[Token(Token = "0x6021411")]
			[Address(RVA = "0x1B94C20", Offset = "0x1B93820", VA = "0x181B94C20")]
			[CompilerGenerated]
			private get
			{
				return CrisisV2SettleViewType.BATTLE_FINISH;
			}
			[Token(Token = "0x6021412")]
			[Address(RVA = "0x1B94D00", Offset = "0x1B93900", VA = "0x181B94D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06021413 RID: 136211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021413")]
		[Address(RVA = "0x1B94990", Offset = "0x1B93590", VA = "0x181B94990", Slot = "13")]
		public override void UpdateView(int position, GameObject view, CrisisV2SettleRuneItemViewHolder holder, CrisisV2SettleRuneItemViewModel data)
		{
		}

		// Token: 0x06021414 RID: 136212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021414")]
		[Address(RVA = "0x1B948D0", Offset = "0x1B934D0", VA = "0x181B948D0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06021415 RID: 136213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021415")]
		[Address(RVA = "0x1B94B50", Offset = "0x1B93750", VA = "0x181B94B50")]
		public CrisisV2SettleRuneListAdapter()
		{
		}

		// Token: 0x0402D4F6 RID: 185590
		[Token(Token = "0x402D4F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CrisisV2SettleRuneItemView _itemViewPrefab;

		// Token: 0x0402D4F9 RID: 185593
		[Token(Token = "0x402D4F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0402D4FA RID: 185594
		[Token(Token = "0x402D4FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0402D4FB RID: 185595
		[Token(Token = "0x402D4FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0402D4FC RID: 185596
		[Token(Token = "0x402D4FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_type;

		// Token: 0x0402D4FD RID: 185597
		[Token(Token = "0x402D4FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402D4FE RID: 185598
		[Token(Token = "0x402D4FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402D4FF RID: 185599
		[Token(Token = "0x402D4FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
