using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BFD RID: 19453
	[Token(Token = "0x2004BFD")]
	public class HomeBackgroundListAdapter : RecycleLoopScrollAdapter<HomeBackgroundItemViewHolder, HomeBackgroundItemModel>
	{
		// Token: 0x0601D3AD RID: 119725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3AD")]
		[Address(RVA = "0x16C9310", Offset = "0x16C7F10", VA = "0x1816C9310", Slot = "13")]
		public override void UpdateView(int position, GameObject view, HomeBackgroundItemViewHolder holder, HomeBackgroundItemModel data)
		{
		}

		// Token: 0x0601D3AE RID: 119726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D3AE")]
		[Address(RVA = "0x16C9450", Offset = "0x16C8050", VA = "0x1816C9450", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601D3AF RID: 119727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3AF")]
		[Address(RVA = "0x16C9570", Offset = "0x16C8170", VA = "0x1816C9570")]
		public HomeBackgroundListAdapter()
		{
		}

		// Token: 0x0402667B RID: 157307
		[Token(Token = "0x402667B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private HomeBackgroundItemView _itemViewPrefab;

		// Token: 0x0402667C RID: 157308
		[Token(Token = "0x402667C")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> onSelectChanged;

		// Token: 0x0402667D RID: 157309
		[Token(Token = "0x402667D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402667E RID: 157310
		[Token(Token = "0x402667E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402667F RID: 157311
		[Token(Token = "0x402667F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
