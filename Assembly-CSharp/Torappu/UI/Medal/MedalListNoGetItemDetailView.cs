using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004984 RID: 18820
	[Token(Token = "0x2004984")]
	public class MedalListNoGetItemDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004325 RID: 17189
		// (get) Token: 0x0601C5BF RID: 116159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004325")]
		protected AnimationWrapper animationWrapper
		{
			[Token(Token = "0x601C5BF")]
			[Address(RVA = "0x15D2FF0", Offset = "0x15D1BF0", VA = "0x1815D2FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C5C0 RID: 116160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5C0")]
		[Address(RVA = "0x15D2DA0", Offset = "0x15D19A0", VA = "0x1815D2DA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C5C1 RID: 116161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5C1")]
		[Address(RVA = "0x15D22B0", Offset = "0x15D0EB0", VA = "0x1815D22B0")]
		public void RenderView(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5C2 RID: 116162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5C2")]
		[Address(RVA = "0x15D2A70", Offset = "0x15D1670", VA = "0x1815D2A70")]
		public void SetToLargeCommon()
		{
		}

		// Token: 0x0601C5C3 RID: 116163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5C3")]
		[Address(RVA = "0x15D1EC0", Offset = "0x15D0AC0", VA = "0x1815D1EC0")]
		public void ApplyAnimation()
		{
		}

		// Token: 0x0601C5C4 RID: 116164 RVA: 0x000A7FB8 File Offset: 0x000A61B8
		[Token(Token = "0x601C5C4")]
		[Address(RVA = "0x15D2170", Offset = "0x15D0D70", VA = "0x1815D2170")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x0601C5C5 RID: 116165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5C5")]
		[Address(RVA = "0x15D2B30", Offset = "0x15D1730", VA = "0x1815D2B30")]
		public void StopAnimation()
		{
		}

		// Token: 0x0601C5C6 RID: 116166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C5C6")]
		[Address(RVA = "0x15D2C70", Offset = "0x15D1870", VA = "0x1815D2C70")]
		private static string _GenerateGetMethodDesc(MedalCommonViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0601C5C7 RID: 116167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5C7")]
		[Address(RVA = "0x15D2F90", Offset = "0x15D1B90", VA = "0x1815D2F90")]
		public MedalListNoGetItemDetailView()
		{
		}

		// Token: 0x04025209 RID: 152073
		[Token(Token = "0x4025209")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402520A RID: 152074
		[Token(Token = "0x402520A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _getDesc;

		// Token: 0x0402520B RID: 152075
		[Token(Token = "0x402520B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402520C RID: 152076
		[Token(Token = "0x402520C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _preObj;

		// Token: 0x0402520D RID: 152077
		[Token(Token = "0x402520D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402520E RID: 152078
		[Token(Token = "0x402520E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _preObjList;

		// Token: 0x0402520F RID: 152079
		[Token(Token = "0x402520F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _haveRewardFlag;

		// Token: 0x04025210 RID: 152080
		[Token(Token = "0x4025210")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04025211 RID: 152081
		[Token(Token = "0x4025211")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _scaler;

		// Token: 0x04025212 RID: 152082
		[Token(Token = "0x4025212")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _rewardPart;

		// Token: 0x04025213 RID: 152083
		[Token(Token = "0x4025213")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04025214 RID: 152084
		[Token(Token = "0x4025214")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04025215 RID: 152085
		[Token(Token = "0x4025215")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MedalAdvanceCommonView _advancedView;

		// Token: 0x04025216 RID: 152086
		[Token(Token = "0x4025216")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _advancedIcon;

		// Token: 0x04025217 RID: 152087
		[Token(Token = "0x4025217")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public UIStringEvent toTargetMedal;

		// Token: 0x04025218 RID: 152088
		[Token(Token = "0x4025218")]
		[FieldOffset(Offset = "0x90")]
		private MedalCommonViewModel m_viewModelCache;

		// Token: 0x04025219 RID: 152089
		[Token(Token = "0x4025219")]
		[FieldOffset(Offset = "0x98")]
		private MedalLittleAdapter m_adapter;

		// Token: 0x0402521A RID: 152090
		[Token(Token = "0x402521A")]
		[FieldOffset(Offset = "0xA0")]
		private UIItemCard m_itemCard;

		// Token: 0x0402521B RID: 152091
		[Token(Token = "0x402521B")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0402521C RID: 152092
		[Token(Token = "0x402521C")]
		private const string ANIMATION_PARAM_DOWN = "enlarge_already_get_down";

		// Token: 0x0402521D RID: 152093
		[Token(Token = "0x402521D")]
		private const string ANIMATION_PARAM_UP = "enlarge_already_get_up";

		// Token: 0x0402521E RID: 152094
		[Token(Token = "0x402521E")]
		private const string LARGE_COMMON = "large_common";

		// Token: 0x0402521F RID: 152095
		[Token(Token = "0x402521F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animationWrapper;

		// Token: 0x04025220 RID: 152096
		[Token(Token = "0x4025220")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025221 RID: 152097
		[Token(Token = "0x4025221")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04025222 RID: 152098
		[Token(Token = "0x4025222")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetToLargeCommon;

		// Token: 0x04025223 RID: 152099
		[Token(Token = "0x4025223")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyAnimation;

		// Token: 0x04025224 RID: 152100
		[Token(Token = "0x4025224")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsPlaying;

		// Token: 0x04025225 RID: 152101
		[Token(Token = "0x4025225")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StopAnimation;

		// Token: 0x04025226 RID: 152102
		[Token(Token = "0x4025226")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateGetMethodDesc;

		// Token: 0x04025227 RID: 152103
		[Token(Token = "0x4025227")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
