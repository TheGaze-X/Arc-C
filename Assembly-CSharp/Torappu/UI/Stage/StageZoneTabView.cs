using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069C0 RID: 27072
	[Token(Token = "0x20069C0")]
	public class StageZoneTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026BD2 RID: 158674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BD2")]
		[Address(RVA = "0x21D99B0", Offset = "0x21D85B0", VA = "0x1821D99B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026BD3 RID: 158675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BD3")]
		[Address(RVA = "0x21D91B0", Offset = "0x21D7DB0", VA = "0x1821D91B0")]
		public void OnClick()
		{
		}

		// Token: 0x06026BD4 RID: 158676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BD4")]
		[Address(RVA = "0x21D9410", Offset = "0x21D8010", VA = "0x1821D9410")]
		public void Render(StageZoneTabViewModel viewModel, bool isBlack = false)
		{
		}

		// Token: 0x06026BD5 RID: 158677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BD5")]
		[Address(RVA = "0x21D9CE0", Offset = "0x21D88E0", VA = "0x1821D9CE0")]
		private void _TweenAlpha(float pos)
		{
		}

		// Token: 0x06026BD6 RID: 158678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BD6")]
		[Address(RVA = "0x21D9A90", Offset = "0x21D8690", VA = "0x1821D9A90")]
		private void _RenderTimelyDrop()
		{
		}

		// Token: 0x06026BD7 RID: 158679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BD7")]
		[Address(RVA = "0x21D9D80", Offset = "0x21D8980", VA = "0x1821D9D80")]
		public StageZoneTabView()
		{
		}

		// Token: 0x04036B37 RID: 224055
		[Token(Token = "0x4036B37")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _pic;

		// Token: 0x04036B38 RID: 224056
		[Token(Token = "0x4036B38")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _onShowAnim;

		// Token: 0x04036B39 RID: 224057
		[Token(Token = "0x4036B39")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04036B3A RID: 224058
		[Token(Token = "0x4036B3A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _timelyDropContainer;

		// Token: 0x04036B3B RID: 224059
		[Token(Token = "0x4036B3B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x04036B3C RID: 224060
		[Token(Token = "0x4036B3C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StageZoneTabView.IPlugin _plugin;

		// Token: 0x04036B3D RID: 224061
		[Token(Token = "0x4036B3D")]
		[FieldOffset(Offset = "0x48")]
		private float m_tweenPos;

		// Token: 0x04036B3E RID: 224062
		[Token(Token = "0x4036B3E")]
		[FieldOffset(Offset = "0x4C")]
		private ZoneViewType m_type;

		// Token: 0x04036B3F RID: 224063
		[Token(Token = "0x4036B3F")]
		[FieldOffset(Offset = "0x50")]
		private StageZoneTabViewModel m_viewModel;

		// Token: 0x04036B40 RID: 224064
		[Token(Token = "0x4036B40")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_cacheTween;

		// Token: 0x04036B41 RID: 224065
		[Token(Token = "0x4036B41")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_cacheColorTween;

		// Token: 0x04036B42 RID: 224066
		[Token(Token = "0x4036B42")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_timelyObj;

		// Token: 0x04036B43 RID: 224067
		[Token(Token = "0x4036B43")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedDropId;

		// Token: 0x04036B44 RID: 224068
		[Token(Token = "0x4036B44")]
		[FieldOffset(Offset = "0x78")]
		private TrackPointViewProperty m_property;

		// Token: 0x04036B45 RID: 224069
		[Token(Token = "0x4036B45")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04036B46 RID: 224070
		[Token(Token = "0x4036B46")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action<ZoneViewType> onClickEvent;

		// Token: 0x04036B47 RID: 224071
		[Token(Token = "0x4036B47")]
		private const string ON_SHOW_PARAM = "onShow";

		// Token: 0x04036B48 RID: 224072
		[Token(Token = "0x4036B48")]
		private const string BLACK_UNSELECT = "313131CC";

		// Token: 0x04036B49 RID: 224073
		[Token(Token = "0x4036B49")]
		private const string BLACK_SELECT = "ffffff33";

		// Token: 0x04036B4A RID: 224074
		[Token(Token = "0x4036B4A")]
		private const string WHITE_UNSELECT = "ffffffCC";

		// Token: 0x04036B4B RID: 224075
		[Token(Token = "0x4036B4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036B4C RID: 224076
		[Token(Token = "0x4036B4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04036B4D RID: 224077
		[Token(Token = "0x4036B4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036B4E RID: 224078
		[Token(Token = "0x4036B4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TweenAlpha;

		// Token: 0x04036B4F RID: 224079
		[Token(Token = "0x4036B4F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderTimelyDrop;

		// Token: 0x04036B50 RID: 224080
		[Token(Token = "0x4036B50")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069C1 RID: 27073
		[Token(Token = "0x20069C1")]
		[Serializable]
		public abstract class IPlugin : MonoBehaviour
		{
			// Token: 0x06026BDA RID: 158682
			[Token(Token = "0x6026BDA")]
			public abstract void RefreshTargetImg(StageZoneTabViewModel viewModel, bool isBlack, ref Image pic, out bool needFadeColor);

			// Token: 0x06026BDB RID: 158683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026BDB")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			protected IPlugin()
			{
			}
		}
	}
}
