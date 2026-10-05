using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B5F RID: 23391
	[Token(Token = "0x2005B5F")]
	public class SkinShopListAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17004F72 RID: 20338
		// (get) Token: 0x06021F3C RID: 139068 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021F3D RID: 139069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F72")]
		public ExposureTracker exposureTracker
		{
			[Token(Token = "0x6021F3C")]
			[Address(RVA = "0x1C7BCA0", Offset = "0x1C7A8A0", VA = "0x181C7BCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021F3D")]
			[Address(RVA = "0x1C7BD80", Offset = "0x1C7A980", VA = "0x181C7BD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004F73 RID: 20339
		// (get) Token: 0x06021F3E RID: 139070 RVA: 0x000BBEC0 File Offset: 0x000BA0C0
		[Token(Token = "0x17004F73")]
		public override int totalCount
		{
			[Token(Token = "0x6021F3E")]
			[Address(RVA = "0x1C7BD00", Offset = "0x1C7A900", VA = "0x181C7BD00", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021F3F RID: 139071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021F3F")]
		[Address(RVA = "0x1C7BB30", Offset = "0x1C7A730", VA = "0x181C7BB30", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06021F40 RID: 139072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F40")]
		[Address(RVA = "0x1C7B910", Offset = "0x1C7A510", VA = "0x181C7B910", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x06021F41 RID: 139073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F41")]
		[Address(RVA = "0x1C7BC40", Offset = "0x1C7A840", VA = "0x181C7BC40")]
		public SkinShopListAdapter()
		{
		}

		// Token: 0x0402E82F RID: 190511
		[Token(Token = "0x402E82F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _skinShopItem;

		// Token: 0x0402E830 RID: 190512
		[Token(Token = "0x402E830")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public List<ISkinShopItemViewModel> list;

		// Token: 0x0402E831 RID: 190513
		[Token(Token = "0x402E831")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public bool initFlag;

		// Token: 0x0402E833 RID: 190515
		[Token(Token = "0x402E833")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_exposureTracker;

		// Token: 0x0402E834 RID: 190516
		[Token(Token = "0x402E834")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_exposureTracker;

		// Token: 0x0402E835 RID: 190517
		[Token(Token = "0x402E835")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0402E836 RID: 190518
		[Token(Token = "0x402E836")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402E837 RID: 190519
		[Token(Token = "0x402E837")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402E838 RID: 190520
		[Token(Token = "0x402E838")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
