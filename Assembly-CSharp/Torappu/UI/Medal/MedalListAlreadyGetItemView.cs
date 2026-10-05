using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200497F RID: 18815
	[Token(Token = "0x200497F")]
	public class MedalListAlreadyGetItemView : MonoBehaviour, IHotfixable, MedalListItemHolder.IMedalListItem
	{
		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x0601C5AB RID: 116139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004323")]
		protected AnimationWrapper animationWrapper
		{
			[Token(Token = "0x601C5AB")]
			[Address(RVA = "0x15D0840", Offset = "0x15CF440", VA = "0x1815D0840")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C5AC RID: 116140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5AC")]
		[Address(RVA = "0x15D0230", Offset = "0x15CEE30", VA = "0x1815D0230", Slot = "4")]
		public void RenderView(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5AD RID: 116141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5AD")]
		[Address(RVA = "0x15D0070", Offset = "0x15CEC70", VA = "0x1815D0070")]
		public void OnClick()
		{
		}

		// Token: 0x0601C5AE RID: 116142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5AE")]
		[Address(RVA = "0x15D05B0", Offset = "0x15CF1B0", VA = "0x1815D05B0")]
		private void _HideAnimation()
		{
		}

		// Token: 0x0601C5AF RID: 116143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5AF")]
		[Address(RVA = "0x15D06D0", Offset = "0x15CF2D0", VA = "0x1815D06D0")]
		private void _ShowAnimation(string targetMedal)
		{
		}

		// Token: 0x0601C5B0 RID: 116144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5B0")]
		[Address(RVA = "0x15D0650", Offset = "0x15CF250", VA = "0x1815D0650")]
		private void _ResetAnimation()
		{
		}

		// Token: 0x0601C5B1 RID: 116145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5B1")]
		[Address(RVA = "0x15D07E0", Offset = "0x15CF3E0", VA = "0x1815D07E0")]
		public MedalListAlreadyGetItemView()
		{
		}

		// Token: 0x040251D5 RID: 152021
		[Token(Token = "0x40251D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040251D6 RID: 152022
		[Token(Token = "0x40251D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _getTime;

		// Token: 0x040251D7 RID: 152023
		[Token(Token = "0x40251D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x040251D8 RID: 152024
		[Token(Token = "0x40251D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _description;

		// Token: 0x040251D9 RID: 152025
		[Token(Token = "0x40251D9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x040251DA RID: 152026
		[Token(Token = "0x40251DA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _advancedIcon;

		// Token: 0x040251DB RID: 152027
		[Token(Token = "0x40251DB")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public UIStringEvent toTargetMedal;

		// Token: 0x040251DC RID: 152028
		[Token(Token = "0x40251DC")]
		[FieldOffset(Offset = "0x50")]
		private MedalCommonViewModel m_viewModelCache;

		// Token: 0x040251DD RID: 152029
		[Token(Token = "0x40251DD")]
		public const string HIDE_PARAM = "medal_hide";

		// Token: 0x040251DE RID: 152030
		[Token(Token = "0x40251DE")]
		public const string SHOW_PARAM = "medal_show";

		// Token: 0x040251DF RID: 152031
		[Token(Token = "0x40251DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animationWrapper;

		// Token: 0x040251E0 RID: 152032
		[Token(Token = "0x40251E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040251E1 RID: 152033
		[Token(Token = "0x40251E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040251E2 RID: 152034
		[Token(Token = "0x40251E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideAnimation;

		// Token: 0x040251E3 RID: 152035
		[Token(Token = "0x40251E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowAnimation;

		// Token: 0x040251E4 RID: 152036
		[Token(Token = "0x40251E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetAnimation;

		// Token: 0x040251E5 RID: 152037
		[Token(Token = "0x40251E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
