using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B6F RID: 27503
	[Token(Token = "0x2006B6F")]
	public class ArchiveEndbookDetailDataBinder : DataBinder<EndbookProperty>
	{
		// Token: 0x17005CDC RID: 23772
		// (get) Token: 0x060274C3 RID: 160963 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060274C4 RID: 160964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CDC")]
		public ActArchiveController controller
		{
			[Token(Token = "0x60274C3")]
			[Address(RVA = "0x227E350", Offset = "0x227CF50", VA = "0x18227E350")]
			private get
			{
				return null;
			}
			[Token(Token = "0x60274C4")]
			[Address(RVA = "0x227E3B0", Offset = "0x227CFB0", VA = "0x18227E3B0")]
			set
			{
			}
		}

		// Token: 0x060274C5 RID: 160965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274C5")]
		[Address(RVA = "0x227D2A0", Offset = "0x227BEA0", VA = "0x18227D2A0", Slot = "7")]
		public override void OnValueChanged(EndbookProperty property)
		{
		}

		// Token: 0x060274C6 RID: 160966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274C6")]
		[Address(RVA = "0x227DB20", Offset = "0x227C720", VA = "0x18227DB20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060274C7 RID: 160967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60274C7")]
		[Address(RVA = "0x227E140", Offset = "0x227CD40", VA = "0x18227E140")]
		private string _TryLoadTextAssets(string textId)
		{
			return null;
		}

		// Token: 0x060274C8 RID: 160968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274C8")]
		[Address(RVA = "0x227DCF0", Offset = "0x227C8F0", VA = "0x18227DCF0")]
		private void _OnStoryClicked(string storyId)
		{
		}

		// Token: 0x060274C9 RID: 160969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60274C9")]
		[Address(RVA = "0x227DA20", Offset = "0x227C620", VA = "0x18227DA20")]
		private DataBundle _ArchiveEndbookDetailToDataBundle()
		{
			return null;
		}

		// Token: 0x060274CA RID: 160970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274CA")]
		[Address(RVA = "0x227E020", Offset = "0x227CC20", VA = "0x18227E020")]
		private void _ResetScrollPosition()
		{
		}

		// Token: 0x060274CB RID: 160971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274CB")]
		[Address(RVA = "0x227D210", Offset = "0x227BE10", VA = "0x18227D210")]
		public void OnAvgClicked()
		{
		}

		// Token: 0x060274CC RID: 160972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274CC")]
		[Address(RVA = "0x227E2E0", Offset = "0x227CEE0", VA = "0x18227E2E0")]
		public ArchiveEndbookDetailDataBinder()
		{
		}

		// Token: 0x04037A44 RID: 227908
		[Token(Token = "0x4037A44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _detailCanvasGroup;

		// Token: 0x04037A45 RID: 227909
		[Token(Token = "0x4037A45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelDetail;

		// Token: 0x04037A46 RID: 227910
		[Token(Token = "0x4037A46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIDynImage _cgImg;

		// Token: 0x04037A47 RID: 227911
		[Token(Token = "0x4037A47")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelAvg;

		// Token: 0x04037A48 RID: 227912
		[Token(Token = "0x4037A48")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x04037A49 RID: 227913
		[Token(Token = "0x4037A49")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x04037A4A RID: 227914
		[Token(Token = "0x4037A4A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _endItemContent;

		// Token: 0x04037A4B RID: 227915
		[Token(Token = "0x4037A4B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _extendingPanel;

		// Token: 0x04037A4C RID: 227916
		[Token(Token = "0x4037A4C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _titleUp;

		// Token: 0x04037A4D RID: 227917
		[Token(Token = "0x4037A4D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _titleDown;

		// Token: 0x04037A4E RID: 227918
		[Token(Token = "0x4037A4E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04037A4F RID: 227919
		[Token(Token = "0x4037A4F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04037A50 RID: 227920
		[Token(Token = "0x4037A50")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _unlockDesc;

		// Token: 0x04037A51 RID: 227921
		[Token(Token = "0x4037A51")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ScrollRect _contentRect;

		// Token: 0x04037A52 RID: 227922
		[Token(Token = "0x4037A52")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _textRect;

		// Token: 0x04037A53 RID: 227923
		[Token(Token = "0x4037A53")]
		[FieldOffset(Offset = "0x98")]
		private ArchiveEndbookDetailDataBinder.EndbookDetailShowTween m_showTween;

		// Token: 0x04037A54 RID: 227924
		[Token(Token = "0x4037A54")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04037A55 RID: 227925
		[Token(Token = "0x4037A55")]
		[FieldOffset(Offset = "0xA8")]
		private ActArchiveController m_controller;

		// Token: 0x04037A56 RID: 227926
		[Token(Token = "0x4037A56")]
		[FieldOffset(Offset = "0xB0")]
		private ArchiveEndbookDetailDataBinder.EndbookDetailItemAdapter m_adapter;

		// Token: 0x04037A57 RID: 227927
		[Token(Token = "0x4037A57")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedEndId;

		// Token: 0x04037A58 RID: 227928
		[Token(Token = "0x4037A58")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedAvgId;

		// Token: 0x04037A59 RID: 227929
		[Token(Token = "0x4037A59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037A5A RID: 227930
		[Token(Token = "0x4037A5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037A5B RID: 227931
		[Token(Token = "0x4037A5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037A5C RID: 227932
		[Token(Token = "0x4037A5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037A5D RID: 227933
		[Token(Token = "0x4037A5D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryLoadTextAssets;

		// Token: 0x04037A5E RID: 227934
		[Token(Token = "0x4037A5E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnStoryClicked;

		// Token: 0x04037A5F RID: 227935
		[Token(Token = "0x4037A5F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ArchiveEndbookDetailToDataBundle;

		// Token: 0x04037A60 RID: 227936
		[Token(Token = "0x4037A60")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetScrollPosition;

		// Token: 0x04037A61 RID: 227937
		[Token(Token = "0x4037A61")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnAvgClicked;

		// Token: 0x04037A62 RID: 227938
		[Token(Token = "0x4037A62")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B70 RID: 27504
		[Token(Token = "0x2006B70")]
		public class EndbookDetailShowTween : UISwitchTween
		{
			// Token: 0x060274CD RID: 160973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274CD")]
			[Address(RVA = "0x22897A0", Offset = "0x22883A0", VA = "0x1822897A0")]
			public EndbookDetailShowTween(ArchiveEndbookDetailDataBinder closure)
			{
			}

			// Token: 0x060274CE RID: 160974 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60274CE")]
			[Address(RVA = "0x22895E0", Offset = "0x22881E0", VA = "0x1822895E0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060274CF RID: 160975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60274CF")]
			[Address(RVA = "0x22894E0", Offset = "0x22880E0", VA = "0x1822894E0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060274D0 RID: 160976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274D0")]
			[Address(RVA = "0x2289440", Offset = "0x2288040", VA = "0x182289440", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x060274D1 RID: 160977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274D1")]
			[Address(RVA = "0x22893A0", Offset = "0x2287FA0", VA = "0x1822893A0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x060274D2 RID: 160978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274D2")]
			[Address(RVA = "0x22896E0", Offset = "0x22882E0", VA = "0x1822896E0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060274D3 RID: 160979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274D3")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x060274D4 RID: 160980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274D4")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x060274D5 RID: 160981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274D5")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04037A63 RID: 227939
			[Token(Token = "0x4037A63")]
			private const float ANIM_DURATION = 0.15f;

			// Token: 0x04037A64 RID: 227940
			[Token(Token = "0x4037A64")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveEndbookDetailDataBinder m_closure;

			// Token: 0x04037A65 RID: 227941
			[Token(Token = "0x4037A65")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037A66 RID: 227942
			[Token(Token = "0x4037A66")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04037A67 RID: 227943
			[Token(Token = "0x4037A67")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04037A68 RID: 227944
			[Token(Token = "0x4037A68")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04037A69 RID: 227945
			[Token(Token = "0x4037A69")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04037A6A RID: 227946
			[Token(Token = "0x4037A6A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02006B71 RID: 27505
		[Token(Token = "0x2006B71")]
		public class EndbookDetailItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005CDD RID: 23773
			// (get) Token: 0x060274D6 RID: 160982 RVA: 0x000CDF98 File Offset: 0x000CC198
			[Token(Token = "0x17005CDD")]
			public override int count
			{
				[Token(Token = "0x60274D6")]
				[Address(RVA = "0x2289320", Offset = "0x2287F20", VA = "0x182289320", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060274D7 RID: 160983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60274D7")]
			[Address(RVA = "0x22890F0", Offset = "0x2287CF0", VA = "0x1822890F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060274D8 RID: 160984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60274D8")]
			[Address(RVA = "0x22892C0", Offset = "0x2287EC0", VA = "0x1822892C0")]
			public EndbookDetailItemAdapter()
			{
			}

			// Token: 0x04037A6B RID: 227947
			[Token(Token = "0x4037A6B")]
			[FieldOffset(Offset = "0x20")]
			public ArchiveEndbookEndModel viewModel;

			// Token: 0x04037A6C RID: 227948
			[Token(Token = "0x4037A6C")]
			[FieldOffset(Offset = "0x28")]
			public Action<int> onItemClicked;

			// Token: 0x04037A6D RID: 227949
			[Token(Token = "0x4037A6D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037A6E RID: 227950
			[Token(Token = "0x4037A6E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04037A6F RID: 227951
			[Token(Token = "0x4037A6F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
