using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C25 RID: 19493
	[Token(Token = "0x2004C25")]
	public class HomeThemeListAdapter : RecycleLoopScrollAdapter<HomeThemeItemViewHolder, HomeThemeItemModel>
	{
		// Token: 0x0601D46F RID: 119919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D46F")]
		[Address(RVA = "0x16DABD0", Offset = "0x16D97D0", VA = "0x1816DABD0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, HomeThemeItemViewHolder holder, HomeThemeItemModel data)
		{
		}

		// Token: 0x0601D470 RID: 119920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D470")]
		[Address(RVA = "0x16DAD60", Offset = "0x16D9960", VA = "0x1816DAD60", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601D471 RID: 119921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D471")]
		[Address(RVA = "0x16DAE80", Offset = "0x16D9A80", VA = "0x1816DAE80")]
		public HomeThemeListAdapter()
		{
		}

		// Token: 0x0402681E RID: 157726
		[Token(Token = "0x402681E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private HomeThemeItemView _itemViewPrefab;

		// Token: 0x0402681F RID: 157727
		[Token(Token = "0x402681F")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> onSelectChanged;

		// Token: 0x04026820 RID: 157728
		[Token(Token = "0x4026820")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04026821 RID: 157729
		[Token(Token = "0x4026821")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04026822 RID: 157730
		[Token(Token = "0x4026822")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
