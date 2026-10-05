using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DB6 RID: 19894
	[Token(Token = "0x2004DB6")]
	public class FriendRequestGridAdapter : RecycleLoopScrollAdapter<FriendListRequestItemHolder, FriendData>
	{
		// Token: 0x0601DBFB RID: 121851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DBFB")]
		[Address(RVA = "0x1753EB0", Offset = "0x1752AB0", VA = "0x181753EB0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601DBFC RID: 121852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBFC")]
		[Address(RVA = "0x1753D40", Offset = "0x1752940", VA = "0x181753D40", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x0601DBFD RID: 121853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBFD")]
		[Address(RVA = "0x1753DA0", Offset = "0x17529A0", VA = "0x181753DA0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, FriendListRequestItemHolder holder, FriendData data)
		{
		}

		// Token: 0x0601DBFE RID: 121854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBFE")]
		[Address(RVA = "0x1753FC0", Offset = "0x1752BC0", VA = "0x181753FC0")]
		public FriendRequestGridAdapter()
		{
		}

		// Token: 0x04027599 RID: 161177
		[Token(Token = "0x4027599")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _friendRequestItem;

		// Token: 0x0402759A RID: 161178
		[Token(Token = "0x402759A")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<FriendData, FriendDealEnum> DealAction;

		// Token: 0x0402759B RID: 161179
		[Token(Token = "0x402759B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402759C RID: 161180
		[Token(Token = "0x402759C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0402759D RID: 161181
		[Token(Token = "0x402759D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402759E RID: 161182
		[Token(Token = "0x402759E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
