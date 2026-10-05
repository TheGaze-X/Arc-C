using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DEC RID: 19948
	[Token(Token = "0x2004DEC")]
	public class FriendNameCardMedalView : RecycleLoopScrollAdapter
	{
		// Token: 0x170045FD RID: 17917
		// (get) Token: 0x0601DD16 RID: 122134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170045FD")]
		protected UIPageListener pageListener
		{
			[Token(Token = "0x601DD16")]
			[Address(RVA = "0x1753BE0", Offset = "0x17527E0", VA = "0x181753BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170045FE RID: 17918
		// (get) Token: 0x0601DD17 RID: 122135 RVA: 0x000AC6F8 File Offset: 0x000AA8F8
		[Token(Token = "0x170045FE")]
		public override int totalCount
		{
			[Token(Token = "0x601DD17")]
			[Address(RVA = "0x1753CB0", Offset = "0x17528B0", VA = "0x181753CB0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601DD18 RID: 122136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD18")]
		[Address(RVA = "0x17536E0", Offset = "0x17522E0", VA = "0x1817536E0", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x0601DD19 RID: 122137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DD19")]
		[Address(RVA = "0x1753A50", Offset = "0x1752650", VA = "0x181753A50", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601DD1A RID: 122138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD1A")]
		[Address(RVA = "0x1753B80", Offset = "0x1752780", VA = "0x181753B80")]
		public FriendNameCardMedalView()
		{
		}

		// Token: 0x040277DD RID: 161757
		[Token(Token = "0x40277DD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FriendNameCardMedalItem _itemView;

		// Token: 0x040277DE RID: 161758
		[Token(Token = "0x40277DE")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public NameCardSelectViewModel viewModel;

		// Token: 0x040277DF RID: 161759
		[Token(Token = "0x40277DF")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public UINameCardEvent onClickEvent;

		// Token: 0x040277E0 RID: 161760
		[Token(Token = "0x40277E0")]
		[FieldOffset(Offset = "0x70")]
		private UIPageListener m_pageListener;

		// Token: 0x040277E1 RID: 161761
		[Token(Token = "0x40277E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pageListener;

		// Token: 0x040277E2 RID: 161762
		[Token(Token = "0x40277E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x040277E3 RID: 161763
		[Token(Token = "0x40277E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040277E4 RID: 161764
		[Token(Token = "0x40277E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040277E5 RID: 161765
		[Token(Token = "0x40277E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
