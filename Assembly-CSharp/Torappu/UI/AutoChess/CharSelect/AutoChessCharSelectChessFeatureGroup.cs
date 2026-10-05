using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063B3 RID: 25523
	[Token(Token = "0x20063B3")]
	public class AutoChessCharSelectChessFeatureGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024CC1 RID: 150721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CC1")]
		[Address(RVA = "0x1F9ADC0", Offset = "0x1F999C0", VA = "0x181F9ADC0")]
		public void Render(AutoChessCharSelectChessFeatureGroupModel model)
		{
		}

		// Token: 0x06024CC2 RID: 150722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CC2")]
		[Address(RVA = "0x1F9B620", Offset = "0x1F9A220", VA = "0x181F9B620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024CC3 RID: 150723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CC3")]
		[Address(RVA = "0x1F9B7A0", Offset = "0x1F9A3A0", VA = "0x181F9B7A0")]
		private void _RenderGarrison(AutoChessShopCharChessGarrisonModel model)
		{
		}

		// Token: 0x06024CC4 RID: 150724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CC4")]
		[Address(RVA = "0x1F9B900", Offset = "0x1F9A500", VA = "0x181F9B900")]
		private void _ResetIfNeed(string chessId, FloatType floatType)
		{
		}

		// Token: 0x06024CC5 RID: 150725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CC5")]
		[Address(RVA = "0x1F9AD00", Offset = "0x1F99900", VA = "0x181F9AD00")]
		public void RegisterTutorialGO(AVGController avgController)
		{
		}

		// Token: 0x06024CC6 RID: 150726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024CC6")]
		[Address(RVA = "0x1F9AC60", Offset = "0x1F99860", VA = "0x181F9AC60")]
		public Tweener FocusChessFeatureGarrison()
		{
			return null;
		}

		// Token: 0x06024CC7 RID: 150727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024CC7")]
		[Address(RVA = "0x1F9ABC0", Offset = "0x1F997C0", VA = "0x181F9ABC0")]
		public Tweener FocusChessFeatureBond()
		{
			return null;
		}

		// Token: 0x06024CC8 RID: 150728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024CC8")]
		[Address(RVA = "0x1F9B310", Offset = "0x1F99F10", VA = "0x181F9B310")]
		private Tweener _GenerateFocusTween(RectTransform target)
		{
			return null;
		}

		// Token: 0x06024CC9 RID: 150729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024CC9")]
		[Address(RVA = "0x1F9BA90", Offset = "0x1F9A690", VA = "0x181F9BA90")]
		public AutoChessCharSelectChessFeatureGroup()
		{
		}

		// Token: 0x040336F0 RID: 210672
		[Token(Token = "0x40336F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _garrisonGroup;

		// Token: 0x040336F1 RID: 210673
		[Token(Token = "0x40336F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _garrisonTypeImage;

		// Token: 0x040336F2 RID: 210674
		[Token(Token = "0x40336F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _garrisonTypeDescText;

		// Token: 0x040336F3 RID: 210675
		[Token(Token = "0x40336F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _garrisonDescText;

		// Token: 0x040336F4 RID: 210676
		[Token(Token = "0x40336F4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _bondGroup;

		// Token: 0x040336F5 RID: 210677
		[Token(Token = "0x40336F5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _bondContent;

		// Token: 0x040336F6 RID: 210678
		[Token(Token = "0x40336F6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _contentScroll;

		// Token: 0x040336F7 RID: 210679
		[Token(Token = "0x40336F7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UILayoutDimensionListener _contentDimensionListener;

		// Token: 0x040336F8 RID: 210680
		[Token(Token = "0x40336F8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VerticalLayoutGroup _contentLayout;

		// Token: 0x040336F9 RID: 210681
		[Token(Token = "0x40336F9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _normalPadding;

		// Token: 0x040336FA RID: 210682
		[Token(Token = "0x40336FA")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int _smallFloatPadding;

		// Token: 0x040336FB RID: 210683
		[Token(Token = "0x40336FB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _largeFloatPadding;

		// Token: 0x040336FC RID: 210684
		[Token(Token = "0x40336FC")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_hasInited;

		// Token: 0x040336FD RID: 210685
		[Token(Token = "0x40336FD")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_finder;

		// Token: 0x040336FE RID: 210686
		[Token(Token = "0x40336FE")]
		[FieldOffset(Offset = "0x80")]
		private ILoadAsset m_loader;

		// Token: 0x040336FF RID: 210687
		[Token(Token = "0x40336FF")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessCharSelectChessFeatureGroup.BondAdapter m_adapter;

		// Token: 0x04033700 RID: 210688
		[Token(Token = "0x4033700")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedChessId;

		// Token: 0x04033701 RID: 210689
		[Token(Token = "0x4033701")]
		private const float TUTORIAL_FOCUS_DURATION = 0.12f;

		// Token: 0x04033702 RID: 210690
		[Token(Token = "0x4033702")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033703 RID: 210691
		[Token(Token = "0x4033703")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033704 RID: 210692
		[Token(Token = "0x4033704")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderGarrison;

		// Token: 0x04033705 RID: 210693
		[Token(Token = "0x4033705")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResetIfNeed;

		// Token: 0x04033706 RID: 210694
		[Token(Token = "0x4033706")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x04033707 RID: 210695
		[Token(Token = "0x4033707")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FocusChessFeatureGarrison;

		// Token: 0x04033708 RID: 210696
		[Token(Token = "0x4033708")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FocusChessFeatureBond;

		// Token: 0x04033709 RID: 210697
		[Token(Token = "0x4033709")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateFocusTween;

		// Token: 0x0403370A RID: 210698
		[Token(Token = "0x403370A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020063B4 RID: 25524
		[Token(Token = "0x20063B4")]
		private class BondAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170056DE RID: 22238
			// (get) Token: 0x06024CCA RID: 150730 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06024CCB RID: 150731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170056DE")]
			public IList<AutoChessShopCharChessBondModel> dataSource
			{
				[Token(Token = "0x6024CCA")]
				[Address(RVA = "0x1FAC8C0", Offset = "0x1FAB4C0", VA = "0x181FAC8C0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6024CCB")]
				[Address(RVA = "0x1FAC920", Offset = "0x1FAB520", VA = "0x181FAC920")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170056DF RID: 22239
			// (get) Token: 0x06024CCC RID: 150732 RVA: 0x000C5838 File Offset: 0x000C3A38
			[Token(Token = "0x170056DF")]
			public override int count
			{
				[Token(Token = "0x6024CCC")]
				[Address(RVA = "0x1FAC800", Offset = "0x1FAB400", VA = "0x181FAC800", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024CCD RID: 150733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024CCD")]
			[Address(RVA = "0x1FAC780", Offset = "0x1FAB380", VA = "0x181FAC780")]
			public BondAdapter(ILoadAsset loader)
			{
			}

			// Token: 0x06024CCE RID: 150734 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024CCE")]
			[Address(RVA = "0x1FAC360", Offset = "0x1FAAF60", VA = "0x181FAC360", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403370B RID: 210699
			[Token(Token = "0x403370B")]
			[FieldOffset(Offset = "0x20")]
			private ILoadAsset m_loader;

			// Token: 0x0403370D RID: 210701
			[Token(Token = "0x403370D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSource;

			// Token: 0x0403370E RID: 210702
			[Token(Token = "0x403370E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSource;

			// Token: 0x0403370F RID: 210703
			[Token(Token = "0x403370F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033710 RID: 210704
			[Token(Token = "0x4033710")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033711 RID: 210705
			[Token(Token = "0x4033711")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020063B5 RID: 25525
		[Token(Token = "0x20063B5")]
		private class ResetScrollAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x170056E0 RID: 22240
			// (get) Token: 0x06024CCF RID: 150735 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06024CD0 RID: 150736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170056E0")]
			public ScrollRect scrollRect
			{
				[Token(Token = "0x6024CCF")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6024CD0")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06024CD1 RID: 150737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024CD1")]
			[Address(RVA = "0x1FACF90", Offset = "0x1FABB90", VA = "0x181FACF90", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x06024CD2 RID: 150738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024CD2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ResetScrollAction()
			{
			}
		}
	}
}
