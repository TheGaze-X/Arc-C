using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DB9 RID: 19897
	[Token(Token = "0x2004DB9")]
	public class FriendSearchGridAdapter : RecycleLoopScrollAdapter<FriendListSearchItemHolder, KeyValuePair<FriendData, FriendStatus>>
	{
		// Token: 0x0601DC03 RID: 121859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC03")]
		[Address(RVA = "0x17546D0", Offset = "0x17532D0", VA = "0x1817546D0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, FriendListSearchItemHolder holder, KeyValuePair<FriendData, FriendStatus> data)
		{
		}

		// Token: 0x0601DC04 RID: 121860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC04")]
		[Address(RVA = "0x1754670", Offset = "0x1753270", VA = "0x181754670", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x0601DC05 RID: 121861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DC05")]
		[Address(RVA = "0x17548C0", Offset = "0x17534C0", VA = "0x1817548C0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601DC06 RID: 121862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC06")]
		[Address(RVA = "0x17549D0", Offset = "0x17535D0", VA = "0x1817549D0")]
		public FriendSearchGridAdapter()
		{
		}

		// Token: 0x040275A9 RID: 161193
		[Token(Token = "0x40275A9")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<FriendData> DealAction;

		// Token: 0x040275AA RID: 161194
		[Token(Token = "0x40275AA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _friendItem;

		// Token: 0x040275AB RID: 161195
		[Token(Token = "0x40275AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040275AC RID: 161196
		[Token(Token = "0x40275AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x040275AD RID: 161197
		[Token(Token = "0x40275AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040275AE RID: 161198
		[Token(Token = "0x40275AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
