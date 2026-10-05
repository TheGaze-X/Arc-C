using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007659 RID: 30297
	[Token(Token = "0x2007659")]
	public class Act20sideRecycleCompAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17006437 RID: 25655
		// (get) Token: 0x0602A9DB RID: 174555 RVA: 0x000D9470 File Offset: 0x000D7670
		[Token(Token = "0x17006437")]
		public override int totalCount
		{
			[Token(Token = "0x602A9DB")]
			[Address(RVA = "0x2658F60", Offset = "0x2657B60", VA = "0x182658F60", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602A9DC RID: 174556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9DC")]
		[Address(RVA = "0x2658C40", Offset = "0x2657840", VA = "0x182658C40", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x0602A9DD RID: 174557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A9DD")]
		[Address(RVA = "0x2658D90", Offset = "0x2657990", VA = "0x182658D90", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602A9DE RID: 174558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9DE")]
		[Address(RVA = "0x2658EB0", Offset = "0x2657AB0", VA = "0x182658EB0")]
		public Act20sideRecycleCompAdapter()
		{
		}

		// Token: 0x0403D5F2 RID: 251378
		[Token(Token = "0x403D5F2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0403D5F3 RID: 251379
		[Token(Token = "0x403D5F3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIStringEvent _onCompSelect;

		// Token: 0x0403D5F4 RID: 251380
		[Token(Token = "0x403D5F4")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public List<CartCompViewModel> viewModelList;

		// Token: 0x0403D5F5 RID: 251381
		[Token(Token = "0x403D5F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0403D5F6 RID: 251382
		[Token(Token = "0x403D5F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403D5F7 RID: 251383
		[Token(Token = "0x403D5F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403D5F8 RID: 251384
		[Token(Token = "0x403D5F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
