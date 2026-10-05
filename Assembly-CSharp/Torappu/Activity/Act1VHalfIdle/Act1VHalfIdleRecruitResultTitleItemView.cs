using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077EC RID: 30700
	[Token(Token = "0x20077EC")]
	public class Act1VHalfIdleRecruitResultTitleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B12C RID: 176428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B12C")]
		[Address(RVA = "0x26E0550", Offset = "0x26DF150", VA = "0x1826E0550")]
		private void _Render(Act1VHalfIdleRecruitResultTitleItemView.VirtualView virtualView)
		{
		}

		// Token: 0x0602B12D RID: 176429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B12D")]
		[Address(RVA = "0x26E0660", Offset = "0x26DF260", VA = "0x1826E0660")]
		public Act1VHalfIdleRecruitResultTitleItemView()
		{
		}

		// Token: 0x0403E3BC RID: 254908
		[Token(Token = "0x403E3BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _height;

		// Token: 0x0403E3BD RID: 254909
		[Token(Token = "0x403E3BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlFirstRecruit;

		// Token: 0x0403E3BE RID: 254910
		[Token(Token = "0x403E3BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlRefundRecruit;

		// Token: 0x0403E3BF RID: 254911
		[Token(Token = "0x403E3BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRefundNum;

		// Token: 0x0403E3C0 RID: 254912
		[Token(Token = "0x403E3C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403E3C1 RID: 254913
		[Token(Token = "0x403E3C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077ED RID: 30701
		[Token(Token = "0x20077ED")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<Act1VHalfIdleRecruitResultTitleItemView>
		{
			// Token: 0x0602B12E RID: 176430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B12E")]
			[Address(RVA = "0x26EDD80", Offset = "0x26EC980", VA = "0x1826EDD80", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0602B12F RID: 176431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B12F")]
			[Address(RVA = "0x26EE0B0", Offset = "0x26ECCB0", VA = "0x1826EE0B0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0602B130 RID: 176432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B130")]
			[Address(RVA = "0x26ED740", Offset = "0x26EC340", VA = "0x1826ED740", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0602B131 RID: 176433 RVA: 0x000DABF8 File Offset: 0x000D8DF8
			[Token(Token = "0x602B131")]
			[Address(RVA = "0x26EDA50", Offset = "0x26EC650", VA = "0x1826EDA50", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0602B132 RID: 176434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B132")]
			[Address(RVA = "0x26EE300", Offset = "0x26ECF00", VA = "0x1826EE300")]
			public VirtualView()
			{
			}

			// Token: 0x0403E3C2 RID: 254914
			[Token(Token = "0x403E3C2")]
			[FieldOffset(Offset = "0x20")]
			public bool isFirstRecruit;

			// Token: 0x0403E3C3 RID: 254915
			[Token(Token = "0x403E3C3")]
			[FieldOffset(Offset = "0x24")]
			public int refundItemCount;

			// Token: 0x0403E3C4 RID: 254916
			[Token(Token = "0x403E3C4")]
			[FieldOffset(Offset = "0x28")]
			public Act1VHalfIdleRecruitResultTitleItemView prefab;

			// Token: 0x0403E3C5 RID: 254917
			[Token(Token = "0x403E3C5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0403E3C6 RID: 254918
			[Token(Token = "0x403E3C6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0403E3C7 RID: 254919
			[Token(Token = "0x403E3C7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0403E3C8 RID: 254920
			[Token(Token = "0x403E3C8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403E3C9 RID: 254921
			[Token(Token = "0x403E3C9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
