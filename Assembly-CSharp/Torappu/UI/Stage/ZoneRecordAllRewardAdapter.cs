using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069D8 RID: 27096
	[Token(Token = "0x20069D8")]
	public class ZoneRecordAllRewardAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17005B7C RID: 23420
		// (get) Token: 0x06026C2D RID: 158765 RVA: 0x000CC360 File Offset: 0x000CA560
		[Token(Token = "0x17005B7C")]
		public override int totalCount
		{
			[Token(Token = "0x6026C2D")]
			[Address(RVA = "0x21DBB20", Offset = "0x21DA720", VA = "0x1821DBB20", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06026C2E RID: 158766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C2E")]
		[Address(RVA = "0x21DB740", Offset = "0x21DA340", VA = "0x1821DB740", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x06026C2F RID: 158767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C2F")]
		[Address(RVA = "0x21DB9B0", Offset = "0x21DA5B0", VA = "0x1821DB9B0", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06026C30 RID: 158768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C30")]
		[Address(RVA = "0x21DBAC0", Offset = "0x21DA6C0", VA = "0x1821DBAC0")]
		public ZoneRecordAllRewardAdapter()
		{
		}

		// Token: 0x04036BF9 RID: 224249
		[Token(Token = "0x4036BF9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemObj;

		// Token: 0x04036BFA RID: 224250
		[Token(Token = "0x4036BFA")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public List<ZoneRecordViewModel> recordList;

		// Token: 0x04036BFB RID: 224251
		[Token(Token = "0x4036BFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x04036BFC RID: 224252
		[Token(Token = "0x4036BFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04036BFD RID: 224253
		[Token(Token = "0x4036BFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04036BFE RID: 224254
		[Token(Token = "0x4036BFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
