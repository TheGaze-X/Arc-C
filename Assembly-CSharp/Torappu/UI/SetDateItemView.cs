using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039B2 RID: 14770
	[Token(Token = "0x20039B2")]
	public class SetDateItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601757C RID: 95612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601757C")]
		[Address(RVA = "0xFB64E0", Offset = "0xFB50E0", VA = "0x180FB64E0")]
		public void Render(SetDateItemView.Param param, bool selected)
		{
		}

		// Token: 0x0601757D RID: 95613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601757D")]
		[Address(RVA = "0xFB6470", Offset = "0xFB5070", VA = "0x180FB6470")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0601757E RID: 95614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601757E")]
		[Address(RVA = "0xFB6660", Offset = "0xFB5260", VA = "0x180FB6660")]
		public SetDateItemView()
		{
		}

		// Token: 0x0401C2E7 RID: 115431
		[Token(Token = "0x401C2E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _selectColor;

		// Token: 0x0401C2E8 RID: 115432
		[Token(Token = "0x401C2E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _unselectColor;

		// Token: 0x0401C2E9 RID: 115433
		[Token(Token = "0x401C2E9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _showText;

		// Token: 0x0401C2EA RID: 115434
		[Token(Token = "0x401C2EA")]
		[FieldOffset(Offset = "0x40")]
		private int m_pageIndex;

		// Token: 0x0401C2EB RID: 115435
		[Token(Token = "0x401C2EB")]
		[FieldOffset(Offset = "0x48")]
		private Action<int> m_onItemClicked;

		// Token: 0x0401C2EC RID: 115436
		[Token(Token = "0x401C2EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401C2ED RID: 115437
		[Token(Token = "0x401C2ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0401C2EE RID: 115438
		[Token(Token = "0x401C2EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039B3 RID: 14771
		[Token(Token = "0x20039B3")]
		public struct Param
		{
			// Token: 0x0401C2EF RID: 115439
			[Token(Token = "0x401C2EF")]
			[FieldOffset(Offset = "0x0")]
			public SetDateItemView prefab;

			// Token: 0x0401C2F0 RID: 115440
			[Token(Token = "0x401C2F0")]
			[FieldOffset(Offset = "0x8")]
			public int pageIndex;

			// Token: 0x0401C2F1 RID: 115441
			[Token(Token = "0x401C2F1")]
			[FieldOffset(Offset = "0x10")]
			public Action<int> onItemClicked;

			// Token: 0x0401C2F2 RID: 115442
			[Token(Token = "0x401C2F2")]
			[FieldOffset(Offset = "0x18")]
			public int date;
		}

		// Token: 0x020039B4 RID: 14772
		[Token(Token = "0x20039B4")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<SetDateItemView>
		{
			// Token: 0x0601757F RID: 95615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601757F")]
			[Address(RVA = "0xFC6710", Offset = "0xFC5310", VA = "0x180FC6710")]
			public VirtualView(SetDateItemView.Param param)
			{
			}

			// Token: 0x06017580 RID: 95616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017580")]
			[Address(RVA = "0xFC6610", Offset = "0xFC5210", VA = "0x180FC6610")]
			public void UpdateSelection(int selectIdx)
			{
			}

			// Token: 0x06017581 RID: 95617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017581")]
			[Address(RVA = "0xFC6500", Offset = "0xFC5100", VA = "0x180FC6500", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06017582 RID: 95618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017582")]
			[Address(RVA = "0xFC65B0", Offset = "0xFC51B0", VA = "0x180FC65B0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06017583 RID: 95619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017583")]
			[Address(RVA = "0xFC6400", Offset = "0xFC5000", VA = "0x180FC6400", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06017584 RID: 95620 RVA: 0x000961B0 File Offset: 0x000943B0
			[Token(Token = "0x6017584")]
			[Address(RVA = "0xFC6470", Offset = "0xFC5070", VA = "0x180FC6470", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0401C2F3 RID: 115443
			[Token(Token = "0x401C2F3")]
			[FieldOffset(Offset = "0x20")]
			private SetDateItemView.Param m_param;

			// Token: 0x0401C2F4 RID: 115444
			[Token(Token = "0x401C2F4")]
			[FieldOffset(Offset = "0x40")]
			private int m_selectPage;

			// Token: 0x0401C2F5 RID: 115445
			[Token(Token = "0x401C2F5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C2F6 RID: 115446
			[Token(Token = "0x401C2F6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateSelection;

			// Token: 0x0401C2F7 RID: 115447
			[Token(Token = "0x401C2F7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0401C2F8 RID: 115448
			[Token(Token = "0x401C2F8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0401C2F9 RID: 115449
			[Token(Token = "0x401C2F9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401C2FA RID: 115450
			[Token(Token = "0x401C2FA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
