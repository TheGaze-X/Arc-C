using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071D7 RID: 29143
	[Token(Token = "0x20071D7")]
	public class Act5D0MileStoneResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x170061E4 RID: 25060
		// (get) Token: 0x06029580 RID: 169344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061E4")]
		public Sprite backImgOngoing
		{
			[Token(Token = "0x6029580")]
			[Address(RVA = "0x24A9C30", Offset = "0x24A8830", VA = "0x1824A9C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061E5 RID: 25061
		// (get) Token: 0x06029581 RID: 169345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061E5")]
		public Sprite backImgCanReward
		{
			[Token(Token = "0x6029581")]
			[Address(RVA = "0x24A9B70", Offset = "0x24A8770", VA = "0x1824A9B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061E6 RID: 25062
		// (get) Token: 0x06029582 RID: 169346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061E6")]
		public Sprite backImgEff
		{
			[Token(Token = "0x6029582")]
			[Address(RVA = "0x24A9BD0", Offset = "0x24A87D0", VA = "0x1824A9BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061E7 RID: 25063
		// (get) Token: 0x06029583 RID: 169347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061E7")]
		public Sprite imgComplete
		{
			[Token(Token = "0x6029583")]
			[Address(RVA = "0x24A9C90", Offset = "0x24A8890", VA = "0x1824A9C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061E8 RID: 25064
		// (get) Token: 0x06029584 RID: 169348 RVA: 0x000D5690 File Offset: 0x000D3890
		[Token(Token = "0x170061E8")]
		public Color indexColorOngoing
		{
			[Token(Token = "0x6029584")]
			[Address(RVA = "0x24A9D70", Offset = "0x24A8970", VA = "0x1824A9D70")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170061E9 RID: 25065
		// (get) Token: 0x06029585 RID: 169349 RVA: 0x000D56A8 File Offset: 0x000D38A8
		[Token(Token = "0x170061E9")]
		public Color itemColorOngoing
		{
			[Token(Token = "0x6029585")]
			[Address(RVA = "0x24A9E70", Offset = "0x24A8A70", VA = "0x1824A9E70")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170061EA RID: 25066
		// (get) Token: 0x06029586 RID: 169350 RVA: 0x000D56C0 File Offset: 0x000D38C0
		[Token(Token = "0x170061EA")]
		public Color indexColorCanReward
		{
			[Token(Token = "0x6029586")]
			[Address(RVA = "0x24A9CF0", Offset = "0x24A88F0", VA = "0x1824A9CF0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170061EB RID: 25067
		// (get) Token: 0x06029587 RID: 169351 RVA: 0x000D56D8 File Offset: 0x000D38D8
		[Token(Token = "0x170061EB")]
		public Color itemColorCanReward
		{
			[Token(Token = "0x6029587")]
			[Address(RVA = "0x24A9DF0", Offset = "0x24A89F0", VA = "0x1824A9DF0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x06029588 RID: 169352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029588")]
		[Address(RVA = "0x24A9B10", Offset = "0x24A8710", VA = "0x1824A9B10")]
		public Act5D0MileStoneResHolder()
		{
		}

		// Token: 0x0403B0C1 RID: 241857
		[Token(Token = "0x403B0C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _backImg_ongoing;

		// Token: 0x0403B0C2 RID: 241858
		[Token(Token = "0x403B0C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _backImg_can_reward;

		// Token: 0x0403B0C3 RID: 241859
		[Token(Token = "0x403B0C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _backImg_eff;

		// Token: 0x0403B0C4 RID: 241860
		[Token(Token = "0x403B0C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _imgComplete;

		// Token: 0x0403B0C5 RID: 241861
		[Token(Token = "0x403B0C5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _indexColor_ongoing;

		// Token: 0x0403B0C6 RID: 241862
		[Token(Token = "0x403B0C6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _itemColor_ongoing;

		// Token: 0x0403B0C7 RID: 241863
		[Token(Token = "0x403B0C7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _indexColor_canReward;

		// Token: 0x0403B0C8 RID: 241864
		[Token(Token = "0x403B0C8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _itemColor_canReward;

		// Token: 0x0403B0C9 RID: 241865
		[Token(Token = "0x403B0C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_backImgOngoing;

		// Token: 0x0403B0CA RID: 241866
		[Token(Token = "0x403B0CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_backImgCanReward;

		// Token: 0x0403B0CB RID: 241867
		[Token(Token = "0x403B0CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_backImgEff;

		// Token: 0x0403B0CC RID: 241868
		[Token(Token = "0x403B0CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_imgComplete;

		// Token: 0x0403B0CD RID: 241869
		[Token(Token = "0x403B0CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_indexColorOngoing;

		// Token: 0x0403B0CE RID: 241870
		[Token(Token = "0x403B0CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_itemColorOngoing;

		// Token: 0x0403B0CF RID: 241871
		[Token(Token = "0x403B0CF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_indexColorCanReward;

		// Token: 0x0403B0D0 RID: 241872
		[Token(Token = "0x403B0D0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_itemColorCanReward;

		// Token: 0x0403B0D1 RID: 241873
		[Token(Token = "0x403B0D1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
