using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003903 RID: 14595
	[Token(Token = "0x2003903")]
	public abstract class UISimpleRecycleLayoutItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017132 RID: 94514
		[Token(Token = "0x6017132")]
		public abstract string GetViewType();

		// Token: 0x06017133 RID: 94515
		[Token(Token = "0x6017133")]
		protected abstract void Render(UISimpleRecycleLayoutItemViewModel model, ValueBundle value, int index);

		// Token: 0x06017134 RID: 94516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017134")]
		[Address(RVA = "0xF7F220", Offset = "0xF7DE20", VA = "0x180F7F220")]
		protected UISimpleRecycleLayoutItemView()
		{
		}

		// Token: 0x0401BD8C RID: 114060
		[Token(Token = "0x401BD8C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x0401BD8D RID: 114061
		[Token(Token = "0x401BD8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003904 RID: 14596
		[Token(Token = "0x2003904")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<UISimpleRecycleLayoutItemView>
		{
			// Token: 0x06017135 RID: 94517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017135")]
			[Address(RVA = "0xF83540", Offset = "0xF82140", VA = "0x180F83540")]
			public VirtualView(UISimpleRecycleLayoutItemView prefab, UISimpleRecycleLayoutItemViewModel model, ValueBundle value, int index)
			{
			}

			// Token: 0x06017136 RID: 94518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017136")]
			[Address(RVA = "0xF82F60", Offset = "0xF81B60", VA = "0x180F82F60", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06017137 RID: 94519 RVA: 0x00094C68 File Offset: 0x00092E68
			[Token(Token = "0x6017137")]
			[Address(RVA = "0xF83040", Offset = "0xF81C40", VA = "0x180F83040", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06017138 RID: 94520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017138")]
			[Address(RVA = "0xF83330", Offset = "0xF81F30", VA = "0x180F83330", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06017139 RID: 94521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017139")]
			[Address(RVA = "0xF83220", Offset = "0xF81E20", VA = "0x180F83220", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0401BD8E RID: 114062
			[Token(Token = "0x401BD8E")]
			[FieldOffset(Offset = "0x20")]
			private UISimpleRecycleLayoutItemView m_prefab;

			// Token: 0x0401BD8F RID: 114063
			[Token(Token = "0x401BD8F")]
			[FieldOffset(Offset = "0x28")]
			private UISimpleRecycleLayoutItemViewModel m_viewModel;

			// Token: 0x0401BD90 RID: 114064
			[Token(Token = "0x401BD90")]
			[FieldOffset(Offset = "0x30")]
			private ValueBundle m_value;

			// Token: 0x0401BD91 RID: 114065
			[Token(Token = "0x401BD91")]
			[FieldOffset(Offset = "0x50")]
			private int m_index;

			// Token: 0x0401BD92 RID: 114066
			[Token(Token = "0x401BD92")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401BD93 RID: 114067
			[Token(Token = "0x401BD93")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401BD94 RID: 114068
			[Token(Token = "0x401BD94")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401BD95 RID: 114069
			[Token(Token = "0x401BD95")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0401BD96 RID: 114070
			[Token(Token = "0x401BD96")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;
		}
	}
}
