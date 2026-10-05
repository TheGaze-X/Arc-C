using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004986 RID: 18822
	[Token(Token = "0x2004986")]
	public class MedalListNotGetItemView : MonoBehaviour, IHotfixable, MedalListItemHolder.IMedalListItem
	{
		// Token: 0x17004326 RID: 17190
		// (get) Token: 0x0601C5CA RID: 116170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004326")]
		protected AnimationWrapper animationWrapper
		{
			[Token(Token = "0x601C5CA")]
			[Address(RVA = "0x15D3E90", Offset = "0x15D2A90", VA = "0x1815D3E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C5CB RID: 116171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5CB")]
		[Address(RVA = "0x15D3050", Offset = "0x15D1C50", VA = "0x1815D3050")]
		public void OnClick()
		{
		}

		// Token: 0x0601C5CC RID: 116172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5CC")]
		[Address(RVA = "0x15D3210", Offset = "0x15D1E10", VA = "0x1815D3210", Slot = "4")]
		public void RenderView(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5CD RID: 116173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5CD")]
		[Address(RVA = "0x15D39B0", Offset = "0x15D25B0", VA = "0x1815D39B0")]
		private void _HideAnimation()
		{
		}

		// Token: 0x0601C5CE RID: 116174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5CE")]
		[Address(RVA = "0x15D3AD0", Offset = "0x15D26D0", VA = "0x1815D3AD0")]
		private void _ShowAnimation(string targetMedal)
		{
		}

		// Token: 0x0601C5CF RID: 116175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5CF")]
		[Address(RVA = "0x15D3A50", Offset = "0x15D2650", VA = "0x1815D3A50")]
		private void _ResetAnimation()
		{
		}

		// Token: 0x0601C5D0 RID: 116176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5D0")]
		[Address(RVA = "0x15D3CD0", Offset = "0x15D28D0", VA = "0x1815D3CD0")]
		private void _UpdateGetPart(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5D1 RID: 116177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5D1")]
		[Address(RVA = "0x15D3BE0", Offset = "0x15D27E0", VA = "0x1815D3BE0")]
		private void _UpdateDescPart(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5D2 RID: 116178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C5D2")]
		[Address(RVA = "0x15D36C0", Offset = "0x15D22C0", VA = "0x1815D36C0")]
		private static string _GenerateGetMethodDesc(MedalCommonViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0601C5D3 RID: 116179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5D3")]
		[Address(RVA = "0x15D3DD0", Offset = "0x15D29D0", VA = "0x1815D3DD0")]
		public MedalListNotGetItemView()
		{
		}

		// Token: 0x0402522A RID: 152106
		[Token(Token = "0x402522A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402522B RID: 152107
		[Token(Token = "0x402522B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402522C RID: 152108
		[Token(Token = "0x402522C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _haveRewardFlag;

		// Token: 0x0402522D RID: 152109
		[Token(Token = "0x402522D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("GetPart")]
		private GameObject _panelGetPart;

		// Token: 0x0402522E RID: 152110
		[Token(Token = "0x402522E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("GetPart")]
		private Text _getDesc;

		// Token: 0x0402522F RID: 152111
		[Token(Token = "0x402522F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("DescPart")]
		private GameObject _panelDescPart;

		// Token: 0x04025230 RID: 152112
		[Token(Token = "0x4025230")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("DescPart")]
		private Text _textDesc;

		// Token: 0x04025231 RID: 152113
		[Token(Token = "0x4025231")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04025232 RID: 152114
		[Token(Token = "0x4025232")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public UIStringEvent toTargetMedal;

		// Token: 0x04025233 RID: 152115
		[Token(Token = "0x4025233")]
		[FieldOffset(Offset = "0x60")]
		private MedalCommonViewModel m_viewModelCache;

		// Token: 0x04025234 RID: 152116
		[Token(Token = "0x4025234")]
		[FieldOffset(Offset = "0x68")]
		private MedalCommonViewModel.DisplayInfoCache m_displayCache;

		// Token: 0x04025235 RID: 152117
		[Token(Token = "0x4025235")]
		[NonSerialized]
		public const string HIDE_PARAM = "medal_hide";

		// Token: 0x04025236 RID: 152118
		[Token(Token = "0x4025236")]
		[NonSerialized]
		public const string SHOW_PARAM = "medal_show";

		// Token: 0x04025237 RID: 152119
		[Token(Token = "0x4025237")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animationWrapper;

		// Token: 0x04025238 RID: 152120
		[Token(Token = "0x4025238")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04025239 RID: 152121
		[Token(Token = "0x4025239")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402523A RID: 152122
		[Token(Token = "0x402523A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideAnimation;

		// Token: 0x0402523B RID: 152123
		[Token(Token = "0x402523B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowAnimation;

		// Token: 0x0402523C RID: 152124
		[Token(Token = "0x402523C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetAnimation;

		// Token: 0x0402523D RID: 152125
		[Token(Token = "0x402523D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateGetPart;

		// Token: 0x0402523E RID: 152126
		[Token(Token = "0x402523E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateDescPart;

		// Token: 0x0402523F RID: 152127
		[Token(Token = "0x402523F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateGetMethodDesc;

		// Token: 0x04025240 RID: 152128
		[Token(Token = "0x4025240")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
