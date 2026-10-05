using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200475C RID: 18268
	[Token(Token = "0x200475C")]
	public abstract class RecruitGachaItemViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x0601BA8C RID: 113292
		[Token(Token = "0x170041C0")]
		public abstract string gachaPoolId { [Token(Token = "0x601BA8C")] get; }

		// Token: 0x0601BA8D RID: 113293
		[Token(Token = "0x601BA8D")]
		protected abstract void OnRefreshData();

		// Token: 0x0601BA8E RID: 113294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA8E")]
		[Address(RVA = "0x1500FF0", Offset = "0x14FFBF0", VA = "0x181500FF0")]
		private void _InvokePluginMethod(Action<RecruitGachaItemPlugin> action)
		{
		}

		// Token: 0x0601BA8F RID: 113295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA8F")]
		[Address(RVA = "0x1501170", Offset = "0x14FFD70", VA = "0x181501170")]
		private void _PluginRefreshData(RecruitGachaItemPlugin plugin)
		{
		}

		// Token: 0x0601BA90 RID: 113296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA90")]
		[Address(RVA = "0x15006A0", Offset = "0x14FF2A0", VA = "0x1815006A0", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0601BA91 RID: 113297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA91")]
		[Address(RVA = "0x1500430", Offset = "0x14FF030", VA = "0x181500430")]
		public void ApplyDrag(float state)
		{
		}

		// Token: 0x0601BA92 RID: 113298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA92")]
		[Address(RVA = "0x1500640", Offset = "0x14FF240", VA = "0x181500640", Slot = "7")]
		public virtual void OnDirectEnter()
		{
		}

		// Token: 0x0601BA93 RID: 113299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA93")]
		[Address(RVA = "0x1500AD0", Offset = "0x14FF6D0", VA = "0x181500AD0")]
		public void PlayInitEffect()
		{
		}

		// Token: 0x0601BA94 RID: 113300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA94")]
		[Address(RVA = "0x1500B40", Offset = "0x14FF740", VA = "0x181500B40")]
		public void RefreshData()
		{
		}

		// Token: 0x0601BA95 RID: 113301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA95")]
		[Address(RVA = "0x1500A40", Offset = "0x14FF640", VA = "0x181500A40")]
		public void OpenDetail()
		{
		}

		// Token: 0x0601BA96 RID: 113302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA96")]
		[Address(RVA = "0x15009B0", Offset = "0x14FF5B0", VA = "0x1815009B0")]
		public void OpenDetailAndScroll()
		{
		}

		// Token: 0x0601BA97 RID: 113303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA97")]
		[Address(RVA = "0x15004B0", Offset = "0x14FF0B0", VA = "0x1815004B0")]
		public void CloseDetail()
		{
		}

		// Token: 0x0601BA98 RID: 113304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA98")]
		[Address(RVA = "0x1500810", Offset = "0x14FF410", VA = "0x181500810")]
		public void OnRecruitOnce()
		{
		}

		// Token: 0x0601BA99 RID: 113305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA99")]
		[Address(RVA = "0x15008E0", Offset = "0x14FF4E0", VA = "0x1815008E0")]
		public void OnRecruitTen()
		{
		}

		// Token: 0x0601BA9A RID: 113306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA9A")]
		[Address(RVA = "0x1500740", Offset = "0x14FF340", VA = "0x181500740")]
		public void OnRecruitFree()
		{
		}

		// Token: 0x0601BA9B RID: 113307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BA9B")]
		[Address(RVA = "0x1500E90", Offset = "0x14FFA90", VA = "0x181500E90")]
		private RectTransform _GetMotionBkg()
		{
			return null;
		}

		// Token: 0x0601BA9C RID: 113308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA9C")]
		[Address(RVA = "0x1500530", Offset = "0x14FF130", VA = "0x181500530")]
		protected void InitMotionPlayer(int index)
		{
		}

		// Token: 0x0601BA9D RID: 113309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA9D")]
		[Address(RVA = "0x1500D60", Offset = "0x14FF960", VA = "0x181500D60")]
		protected void ShowDetailByPoolId(string poolId, bool needScroll = false)
		{
		}

		// Token: 0x0601BA9E RID: 113310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA9E")]
		[Address(RVA = "0x1501260", Offset = "0x14FFE60", VA = "0x181501260")]
		protected RecruitGachaItemViewBase()
		{
		}

		// Token: 0x04023EA8 RID: 147112
		[Token(Token = "0x4023EA8")]
		private const string FLAG_BOOL = "onFlag";

		// Token: 0x04023EA9 RID: 147113
		[Token(Token = "0x4023EA9")]
		private const string DEFAULT_BKG_NAME = "back_image";

		// Token: 0x04023EAA RID: 147114
		[Token(Token = "0x4023EAA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator _animatorController;

		// Token: 0x04023EAB RID: 147115
		[Token(Token = "0x4023EAB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _background;

		// Token: 0x04023EAC RID: 147116
		[Token(Token = "0x4023EAC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<RecruitImage> _imageDict;

		// Token: 0x04023EAD RID: 147117
		[Token(Token = "0x4023EAD")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public UIStringEvent onClick;

		// Token: 0x04023EAE RID: 147118
		[Token(Token = "0x4023EAE")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public UIStringEvent onTenClick;

		// Token: 0x04023EAF RID: 147119
		[Token(Token = "0x4023EAF")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public UIStringEvent onRecruitFreeClick;

		// Token: 0x04023EB0 RID: 147120
		[Token(Token = "0x4023EB0")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public UIStringBoolEvent onDetailShow;

		// Token: 0x04023EB1 RID: 147121
		[Token(Token = "0x4023EB1")]
		[FieldOffset(Offset = "0x50")]
		private RecruitGachaItemViewBase.MotionPlayer m_motionPlayer;

		// Token: 0x04023EB2 RID: 147122
		[Token(Token = "0x4023EB2")]
		[FieldOffset(Offset = "0x58")]
		private List<RecruitGachaItemPlugin> m_plugins;

		// Token: 0x04023EB3 RID: 147123
		[Token(Token = "0x4023EB3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InvokePluginMethod;

		// Token: 0x04023EB4 RID: 147124
		[Token(Token = "0x4023EB4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PluginRefreshData;

		// Token: 0x04023EB5 RID: 147125
		[Token(Token = "0x4023EB5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04023EB6 RID: 147126
		[Token(Token = "0x4023EB6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDrag;

		// Token: 0x04023EB7 RID: 147127
		[Token(Token = "0x4023EB7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDirectEnter;

		// Token: 0x04023EB8 RID: 147128
		[Token(Token = "0x4023EB8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayInitEffect;

		// Token: 0x04023EB9 RID: 147129
		[Token(Token = "0x4023EB9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04023EBA RID: 147130
		[Token(Token = "0x4023EBA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OpenDetail;

		// Token: 0x04023EBB RID: 147131
		[Token(Token = "0x4023EBB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OpenDetailAndScroll;

		// Token: 0x04023EBC RID: 147132
		[Token(Token = "0x4023EBC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CloseDetail;

		// Token: 0x04023EBD RID: 147133
		[Token(Token = "0x4023EBD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnRecruitOnce;

		// Token: 0x04023EBE RID: 147134
		[Token(Token = "0x4023EBE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnRecruitTen;

		// Token: 0x04023EBF RID: 147135
		[Token(Token = "0x4023EBF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnRecruitFree;

		// Token: 0x04023EC0 RID: 147136
		[Token(Token = "0x4023EC0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetMotionBkg;

		// Token: 0x04023EC1 RID: 147137
		[Token(Token = "0x4023EC1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_InitMotionPlayer;

		// Token: 0x04023EC2 RID: 147138
		[Token(Token = "0x4023EC2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ShowDetailByPoolId;

		// Token: 0x04023EC3 RID: 147139
		[Token(Token = "0x4023EC3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200475D RID: 18269
		[Token(Token = "0x200475D")]
		protected class MotionPlayer : IHotfixable
		{
			// Token: 0x0601BA9F RID: 113311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BA9F")]
			[Address(RVA = "0x14F33D0", Offset = "0x14F1FD0", VA = "0x1814F33D0")]
			public void Init(int index, RecruitGachaItemViewBase closure)
			{
			}

			// Token: 0x0601BAA0 RID: 113312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAA0")]
			[Address(RVA = "0x14F34F0", Offset = "0x14F20F0", VA = "0x1814F34F0")]
			public void OnDragStateChanged(float state)
			{
			}

			// Token: 0x0601BAA1 RID: 113313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAA1")]
			[Address(RVA = "0x14F36F0", Offset = "0x14F22F0", VA = "0x1814F36F0")]
			public void PlayerInitialMotionEffect()
			{
			}

			// Token: 0x0601BAA2 RID: 113314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAA2")]
			[Address(RVA = "0x14F3B70", Offset = "0x14F2770", VA = "0x1814F3B70")]
			private void _ApplyDragImageBias(float bias)
			{
			}

			// Token: 0x0601BAA3 RID: 113315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAA3")]
			[Address(RVA = "0x14F3D00", Offset = "0x14F2900", VA = "0x1814F3D00")]
			private void _ApplyEffectImageBias(float bias)
			{
			}

			// Token: 0x0601BAA4 RID: 113316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAA4")]
			[Address(RVA = "0x14F3490", Offset = "0x14F2090", VA = "0x1814F3490")]
			public void OnDisable()
			{
			}

			// Token: 0x0601BAA5 RID: 113317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAA5")]
			[Address(RVA = "0x14F3ED0", Offset = "0x14F2AD0", VA = "0x1814F3ED0")]
			private void _CancelPrevMotionEffects(bool resetToTarget)
			{
			}

			// Token: 0x0601BAA6 RID: 113318 RVA: 0x000A5C60 File Offset: 0x000A3E60
			[Token(Token = "0x601BAA6")]
			[Address(RVA = "0x14F43D0", Offset = "0x14F2FD0", VA = "0x1814F43D0")]
			private bool _IsEffectTweening()
			{
				return default(bool);
			}

			// Token: 0x0601BAA7 RID: 113319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAA7")]
			[Address(RVA = "0x14F3FF0", Offset = "0x14F2BF0", VA = "0x1814F3FF0")]
			private void _InitMotionList(RecruitGachaItemViewBase closure)
			{
			}

			// Token: 0x0601BAA8 RID: 113320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAA8")]
			[Address(RVA = "0x14F4500", Offset = "0x14F3100", VA = "0x1814F4500")]
			public MotionPlayer()
			{
			}

			// Token: 0x04023EC4 RID: 147140
			[Token(Token = "0x4023EC4")]
			private const float INIT_EFFECT_DELAY = 0.18f;

			// Token: 0x04023EC5 RID: 147141
			[Token(Token = "0x4023EC5")]
			private const float INIT_EFFECT_MOVE_DUR = 1.8f;

			// Token: 0x04023EC6 RID: 147142
			[Token(Token = "0x4023EC6")]
			private const float INIT_EFFECT_FADE_DUR = 0.3f;

			// Token: 0x04023EC7 RID: 147143
			[Token(Token = "0x4023EC7")]
			private const float INIT_EFFECT_BIAS = -0.1f;

			// Token: 0x04023EC8 RID: 147144
			[Token(Token = "0x4023EC8")]
			private const float INIT_EFFECT_BASE_DELTA = -300f;

			// Token: 0x04023EC9 RID: 147145
			[Token(Token = "0x4023EC9")]
			private const float INIT_EFFECT_MOVE_SCALE = 0.75f;

			// Token: 0x04023ECA RID: 147146
			[Token(Token = "0x4023ECA")]
			[FieldOffset(Offset = "0x10")]
			private List<RecruitImage> m_images;

			// Token: 0x04023ECB RID: 147147
			[Token(Token = "0x4023ECB")]
			[FieldOffset(Offset = "0x18")]
			private RecruitImage m_bkg;

			// Token: 0x04023ECC RID: 147148
			[Token(Token = "0x4023ECC")]
			[FieldOffset(Offset = "0x20")]
			private int m_index;

			// Token: 0x04023ECD RID: 147149
			[Token(Token = "0x4023ECD")]
			[FieldOffset(Offset = "0x28")]
			private List<Tween> m_tweens;

			// Token: 0x04023ECE RID: 147150
			[Token(Token = "0x4023ECE")]
			[FieldOffset(Offset = "0x30")]
			private GameObject m_gameObject;

			// Token: 0x04023ECF RID: 147151
			[Token(Token = "0x4023ECF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04023ED0 RID: 147152
			[Token(Token = "0x4023ED0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnDragStateChanged;

			// Token: 0x04023ED1 RID: 147153
			[Token(Token = "0x4023ED1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_PlayerInitialMotionEffect;

			// Token: 0x04023ED2 RID: 147154
			[Token(Token = "0x4023ED2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__ApplyDragImageBias;

			// Token: 0x04023ED3 RID: 147155
			[Token(Token = "0x4023ED3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__ApplyEffectImageBias;

			// Token: 0x04023ED4 RID: 147156
			[Token(Token = "0x4023ED4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnDisable;

			// Token: 0x04023ED5 RID: 147157
			[Token(Token = "0x4023ED5")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__CancelPrevMotionEffects;

			// Token: 0x04023ED6 RID: 147158
			[Token(Token = "0x4023ED6")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__IsEffectTweening;

			// Token: 0x04023ED7 RID: 147159
			[Token(Token = "0x4023ED7")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__InitMotionList;

			// Token: 0x04023ED8 RID: 147160
			[Token(Token = "0x4023ED8")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
