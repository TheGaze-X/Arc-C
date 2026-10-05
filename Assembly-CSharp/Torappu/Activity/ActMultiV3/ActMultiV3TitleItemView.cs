using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F6D RID: 28525
	[Token(Token = "0x2006F6D")]
	public class ActMultiV3TitleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287F6 RID: 165878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287F6")]
		[Address(RVA = "0x23D0E70", Offset = "0x23CFA70", VA = "0x1823D0E70")]
		public void Render(ActMultiV3TitleItemView.Param param, bool isSelected)
		{
		}

		// Token: 0x060287F7 RID: 165879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287F7")]
		[Address(RVA = "0x23D0D50", Offset = "0x23CF950", VA = "0x1823D0D50")]
		public void OnClickItem()
		{
		}

		// Token: 0x060287F8 RID: 165880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287F8")]
		[Address(RVA = "0x23D1090", Offset = "0x23CFC90", VA = "0x1823D1090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287F9 RID: 165881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287F9")]
		[Address(RVA = "0x23D1160", Offset = "0x23CFD60", VA = "0x1823D1160")]
		public ActMultiV3TitleItemView()
		{
		}

		// Token: 0x04039A43 RID: 236099
		[Token(Token = "0x4039A43")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04039A44 RID: 236100
		[Token(Token = "0x4039A44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedGo;

		// Token: 0x04039A45 RID: 236101
		[Token(Token = "0x4039A45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _trackpointHolder;

		// Token: 0x04039A46 RID: 236102
		[Token(Token = "0x4039A46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newTrackPoint;

		// Token: 0x04039A47 RID: 236103
		[Token(Token = "0x4039A47")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x04039A48 RID: 236104
		[Token(Token = "0x4039A48")]
		[FieldOffset(Offset = "0x3C")]
		private int m_cachedPageIndex;

		// Token: 0x04039A49 RID: 236105
		[Token(Token = "0x4039A49")]
		[FieldOffset(Offset = "0x40")]
		private bool m_cachedIsBack;

		// Token: 0x04039A4A RID: 236106
		[Token(Token = "0x4039A4A")]
		[FieldOffset(Offset = "0x41")]
		private bool m_cachedSelected;

		// Token: 0x04039A4B RID: 236107
		[Token(Token = "0x4039A4B")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039A4C RID: 236108
		[Token(Token = "0x4039A4C")]
		[FieldOffset(Offset = "0x58")]
		private GameObject m_newTrackObj;

		// Token: 0x04039A4D RID: 236109
		[Token(Token = "0x4039A4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039A4E RID: 236110
		[Token(Token = "0x4039A4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickItem;

		// Token: 0x04039A4F RID: 236111
		[Token(Token = "0x4039A4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039A50 RID: 236112
		[Token(Token = "0x4039A50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F6E RID: 28526
		[Token(Token = "0x2006F6E")]
		public struct Param
		{
			// Token: 0x04039A51 RID: 236113
			[Token(Token = "0x4039A51")]
			[FieldOffset(Offset = "0x0")]
			public ActMultiV3TitleItemView prefab;

			// Token: 0x04039A52 RID: 236114
			[Token(Token = "0x4039A52")]
			[FieldOffset(Offset = "0x8")]
			public ActMultiV3TitleViewModel titleModel;

			// Token: 0x04039A53 RID: 236115
			[Token(Token = "0x4039A53")]
			[FieldOffset(Offset = "0x10")]
			public int pageIndex;
		}

		// Token: 0x02006F6F RID: 28527
		[Token(Token = "0x2006F6F")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<ActMultiV3TitleItemView>
		{
			// Token: 0x17005F75 RID: 24437
			// (get) Token: 0x060287FA RID: 165882 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005F75")]
			public ActMultiV3TitleViewModel titleModel
			{
				[Token(Token = "0x60287FA")]
				[Address(RVA = "0x23D3A50", Offset = "0x23D2650", VA = "0x1823D3A50")]
				get
				{
					return null;
				}
			}

			// Token: 0x060287FB RID: 165883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287FB")]
			[Address(RVA = "0x23D39A0", Offset = "0x23D25A0", VA = "0x1823D39A0")]
			public VirtualView(ActMultiV3TitleItemView.Param param)
			{
			}

			// Token: 0x060287FC RID: 165884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287FC")]
			[Address(RVA = "0x23D3890", Offset = "0x23D2490", VA = "0x1823D3890")]
			public void UpdateFocusPage(int focusPage)
			{
			}

			// Token: 0x060287FD RID: 165885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287FD")]
			[Address(RVA = "0x23D3790", Offset = "0x23D2390", VA = "0x1823D3790", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x060287FE RID: 165886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287FE")]
			[Address(RVA = "0x23D3830", Offset = "0x23D2430", VA = "0x1823D3830", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x060287FF RID: 165887 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60287FF")]
			[Address(RVA = "0x23D3690", Offset = "0x23D2290", VA = "0x1823D3690", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06028800 RID: 165888 RVA: 0x000D1E38 File Offset: 0x000D0038
			[Token(Token = "0x6028800")]
			[Address(RVA = "0x23D3700", Offset = "0x23D2300", VA = "0x1823D3700", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x04039A54 RID: 236116
			[Token(Token = "0x4039A54")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3TitleItemView.Param m_param;

			// Token: 0x04039A55 RID: 236117
			[Token(Token = "0x4039A55")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_titleModel;

			// Token: 0x04039A56 RID: 236118
			[Token(Token = "0x4039A56")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039A57 RID: 236119
			[Token(Token = "0x4039A57")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateFocusPage;

			// Token: 0x04039A58 RID: 236120
			[Token(Token = "0x4039A58")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04039A59 RID: 236121
			[Token(Token = "0x4039A59")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04039A5A RID: 236122
			[Token(Token = "0x4039A5A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04039A5B RID: 236123
			[Token(Token = "0x4039A5B")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
