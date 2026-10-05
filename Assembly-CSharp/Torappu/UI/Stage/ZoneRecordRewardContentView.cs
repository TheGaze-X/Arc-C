using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069CE RID: 27086
	[Token(Token = "0x20069CE")]
	public class ZoneRecordRewardContentView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B78 RID: 23416
		// (get) Token: 0x06026C07 RID: 158727 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026C08 RID: 158728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B78")]
		public Action onClaimAllClick
		{
			[Token(Token = "0x6026C07")]
			[Address(RVA = "0x21E35A0", Offset = "0x21E21A0", VA = "0x1821E35A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026C08")]
			[Address(RVA = "0x21E3600", Offset = "0x21E2200", VA = "0x1821E3600")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026C09 RID: 158729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C09")]
		[Address(RVA = "0x21E30A0", Offset = "0x21E1CA0", VA = "0x1821E30A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026C0A RID: 158730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C0A")]
		[Address(RVA = "0x21E2F10", Offset = "0x21E1B10", VA = "0x1821E2F10")]
		private void _FoldAllRewards(bool fold, bool directlyShowList = false)
		{
		}

		// Token: 0x06026C0B RID: 158731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C0B")]
		[Address(RVA = "0x21E2FE0", Offset = "0x21E1BE0", VA = "0x1821E2FE0")]
		private void _FoldRewardsList(bool fold, bool directly = false)
		{
		}

		// Token: 0x06026C0C RID: 158732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C0C")]
		[Address(RVA = "0x21E3250", Offset = "0x21E1E50", VA = "0x1821E3250")]
		private void _LoadBgIcon(string zoneId)
		{
		}

		// Token: 0x06026C0D RID: 158733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C0D")]
		[Address(RVA = "0x21E29D0", Offset = "0x21E15D0", VA = "0x1821E29D0")]
		public void Render(ZoneRecordGroupViewModel groupViewModel)
		{
		}

		// Token: 0x06026C0E RID: 158734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C0E")]
		[Address(RVA = "0x21E2E50", Offset = "0x21E1A50", VA = "0x1821E2E50")]
		public void ResetContentViewBeforeClose()
		{
		}

		// Token: 0x06026C0F RID: 158735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C0F")]
		[Address(RVA = "0x21E2800", Offset = "0x21E1400", VA = "0x1821E2800")]
		public void EventOnClaimAllClick()
		{
		}

		// Token: 0x06026C10 RID: 158736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C10")]
		[Address(RVA = "0x21E28F0", Offset = "0x21E14F0", VA = "0x1821E28F0")]
		public void EventOnFoldRewardBtnClick()
		{
		}

		// Token: 0x06026C11 RID: 158737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C11")]
		[Address(RVA = "0x21E2960", Offset = "0x21E1560", VA = "0x1821E2960")]
		public void EventOnUnfoldRewardBtnClick()
		{
		}

		// Token: 0x06026C12 RID: 158738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C12")]
		[Address(RVA = "0x21E3540", Offset = "0x21E2140", VA = "0x1821E3540")]
		public ZoneRecordRewardContentView()
		{
		}

		// Token: 0x04036BAD RID: 224173
		[Token(Token = "0x4036BAD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objRewardClaimAll;

		// Token: 0x04036BAE RID: 224174
		[Token(Token = "0x4036BAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _diffRewardLayout;

		// Token: 0x04036BAF RID: 224175
		[Token(Token = "0x4036BAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objRewardTitle;

		// Token: 0x04036BB0 RID: 224176
		[Token(Token = "0x4036BB0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objRewardAllClaimed;

		// Token: 0x04036BB1 RID: 224177
		[Token(Token = "0x4036BB1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasRewardAllFold;

		// Token: 0x04036BB2 RID: 224178
		[Token(Token = "0x4036BB2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasRewardAllUnfold;

		// Token: 0x04036BB3 RID: 224179
		[Token(Token = "0x4036BB3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasRewardsList;

		// Token: 0x04036BB4 RID: 224180
		[Token(Token = "0x4036BB4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasRewardListMask;

		// Token: 0x04036BB5 RID: 224181
		[Token(Token = "0x4036BB5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _iconBg;

		// Token: 0x04036BB6 RID: 224182
		[Token(Token = "0x4036BB6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _iconRewardBg;

		// Token: 0x04036BB7 RID: 224183
		[Token(Token = "0x4036BB7")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04036BB8 RID: 224184
		[Token(Token = "0x4036BB8")]
		[FieldOffset(Offset = "0x70")]
		private ZoneRecordDiffRewardItemAdapter m_rewardListAdapter;

		// Token: 0x04036BB9 RID: 224185
		[Token(Token = "0x4036BB9")]
		[FieldOffset(Offset = "0x78")]
		private ZoneRecordRewardContentView.RewardFoldSwitchTween m_foldTween;

		// Token: 0x04036BBA RID: 224186
		[Token(Token = "0x4036BBA")]
		[FieldOffset(Offset = "0x80")]
		private ZoneRecordRewardContentView.RewardFoldSwitchTween m_unfoldTween;

		// Token: 0x04036BBB RID: 224187
		[Token(Token = "0x4036BBB")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_rewadsListTween;

		// Token: 0x04036BBC RID: 224188
		[Token(Token = "0x4036BBC")]
		private const float FOLD_ALPHA_DURATION = 0.16f;

		// Token: 0x04036BBD RID: 224189
		[Token(Token = "0x4036BBD")]
		[FieldOffset(Offset = "0x90")]
		private bool m_consumeClaimFlag;

		// Token: 0x04036BBE RID: 224190
		[Token(Token = "0x4036BBE")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedZoneId;

		// Token: 0x04036BBF RID: 224191
		[Token(Token = "0x4036BBF")]
		private const float ALL_CLAIMED_LIST_TOP_ALPHA = 0.6f;

		// Token: 0x04036BC1 RID: 224193
		[Token(Token = "0x4036BC1")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public ZoneRecordController controller;

		// Token: 0x04036BC2 RID: 224194
		[Token(Token = "0x4036BC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClaimAllClick;

		// Token: 0x04036BC3 RID: 224195
		[Token(Token = "0x4036BC3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClaimAllClick;

		// Token: 0x04036BC4 RID: 224196
		[Token(Token = "0x4036BC4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036BC5 RID: 224197
		[Token(Token = "0x4036BC5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FoldAllRewards;

		// Token: 0x04036BC6 RID: 224198
		[Token(Token = "0x4036BC6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FoldRewardsList;

		// Token: 0x04036BC7 RID: 224199
		[Token(Token = "0x4036BC7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadBgIcon;

		// Token: 0x04036BC8 RID: 224200
		[Token(Token = "0x4036BC8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036BC9 RID: 224201
		[Token(Token = "0x4036BC9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetContentViewBeforeClose;

		// Token: 0x04036BCA RID: 224202
		[Token(Token = "0x4036BCA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnClaimAllClick;

		// Token: 0x04036BCB RID: 224203
		[Token(Token = "0x4036BCB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnFoldRewardBtnClick;

		// Token: 0x04036BCC RID: 224204
		[Token(Token = "0x4036BCC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnUnfoldRewardBtnClick;

		// Token: 0x04036BCD RID: 224205
		[Token(Token = "0x4036BCD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069CF RID: 27087
		[Token(Token = "0x20069CF")]
		[Obsolete("Use FadeSwitchTween.Builder.ControlRaycastAndKeepActive instead.")]
		private class RewardFoldSwitchTween : FadeSwitchTween
		{
			// Token: 0x06026C13 RID: 158739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026C13")]
			[Address(RVA = "0x21D6FF0", Offset = "0x21D5BF0", VA = "0x1821D6FF0")]
			public RewardFoldSwitchTween(CanvasGroup alphaHandler, float duration, bool ignoreTimeScale = true)
			{
			}

			// Token: 0x06026C14 RID: 158740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026C14")]
			[Address(RVA = "0x167AE30", Offset = "0x1679A30", VA = "0x18167AE30", Slot = "20")]
			protected override void SetObjectActive(CanvasGroup alphaHandler, bool isActive)
			{
			}
		}
	}
}
