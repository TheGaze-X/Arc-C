using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F48 RID: 16200
	[Token(Token = "0x2003F48")]
	public class SiracusaOperaFrameView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601926C RID: 103020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601926C")]
		[Address(RVA = "0x11DC260", Offset = "0x11DAE60", VA = "0x1811DC260")]
		public void Render(SiracusaOperaFrameViewModel viewModel, bool isSelected, bool needRefesh)
		{
		}

		// Token: 0x0601926D RID: 103021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601926D")]
		[Address(RVA = "0x11DC140", Offset = "0x11DAD40", VA = "0x1811DC140")]
		public Sprite LoadSiracusaAvatar(string operaId)
		{
			return null;
		}

		// Token: 0x0601926E RID: 103022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601926E")]
		[Address(RVA = "0x11DC1D0", Offset = "0x11DADD0", VA = "0x1811DC1D0")]
		public void OnClick()
		{
		}

		// Token: 0x0601926F RID: 103023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601926F")]
		[Address(RVA = "0x11DCB30", Offset = "0x11DB730", VA = "0x1811DCB30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019270 RID: 103024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019270")]
		[Address(RVA = "0x11DCD10", Offset = "0x11DB910", VA = "0x1811DCD10")]
		public SiracusaOperaFrameView()
		{
		}

		// Token: 0x0401F2A2 RID: 127650
		[Token(Token = "0x401F2A2")]
		public const float TWEEN_DURATION = 0.6f;

		// Token: 0x0401F2A3 RID: 127651
		[Token(Token = "0x401F2A3")]
		private const string NUM_SPRITE_ID = "opera_num_{0}";

		// Token: 0x0401F2A4 RID: 127652
		[Token(Token = "0x401F2A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x0401F2A5 RID: 127653
		[Token(Token = "0x401F2A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _clickBtn;

		// Token: 0x0401F2A6 RID: 127654
		[Token(Token = "0x401F2A6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _titleMain;

		// Token: 0x0401F2A7 RID: 127655
		[Token(Token = "0x401F2A7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _titleSub;

		// Token: 0x0401F2A8 RID: 127656
		[Token(Token = "0x401F2A8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _scoreText;

		// Token: 0x0401F2A9 RID: 127657
		[Token(Token = "0x401F2A9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _numImg;

		// Token: 0x0401F2AA RID: 127658
		[Token(Token = "0x401F2AA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasObject _atlasObj;

		// Token: 0x0401F2AB RID: 127659
		[Token(Token = "0x401F2AB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Active")]
		private GameObject _activePart;

		// Token: 0x0401F2AC RID: 127660
		[Token(Token = "0x401F2AC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Pass")]
		private GameObject _passPart;

		// Token: 0x0401F2AD RID: 127661
		[Token(Token = "0x401F2AD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Pass")]
		private Text _passText;

		// Token: 0x0401F2AE RID: 127662
		[Token(Token = "0x401F2AE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Pass")]
		private Text _passTimeText;

		// Token: 0x0401F2AF RID: 127663
		[Token(Token = "0x401F2AF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("future")]
		private GameObject _futurePart;

		// Token: 0x0401F2B0 RID: 127664
		[Token(Token = "0x401F2B0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("future")]
		private Text _futureTimeText;

		// Token: 0x0401F2B1 RID: 127665
		[Token(Token = "0x401F2B1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("future")]
		private Text _futureText;

		// Token: 0x0401F2B2 RID: 127666
		[Token(Token = "0x401F2B2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _backSprite;

		// Token: 0x0401F2B3 RID: 127667
		[Token(Token = "0x401F2B3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _addCount;

		// Token: 0x0401F2B4 RID: 127668
		[Token(Token = "0x401F2B4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _admireCount;

		// Token: 0x0401F2B5 RID: 127669
		[Token(Token = "0x401F2B5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _admirePart;

		// Token: 0x0401F2B6 RID: 127670
		[Token(Token = "0x401F2B6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _unableMask;

		// Token: 0x0401F2B7 RID: 127671
		[Token(Token = "0x401F2B7")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _unopenText;

		// Token: 0x0401F2B8 RID: 127672
		[Token(Token = "0x401F2B8")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private SimpleLayoutContent _headIconContent;

		// Token: 0x0401F2B9 RID: 127673
		[Token(Token = "0x401F2B9")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform _commentContainer;

		// Token: 0x0401F2BA RID: 127674
		[Token(Token = "0x401F2BA")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public UIIntEvent onClickFocus;

		// Token: 0x0401F2BB RID: 127675
		[Token(Token = "0x401F2BB")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		public UIPage page;

		// Token: 0x0401F2BC RID: 127676
		[Token(Token = "0x401F2BC")]
		[FieldOffset(Offset = "0xE0")]
		private SiracusaOperaFrameView.Adapter m_adapter;

		// Token: 0x0401F2BD RID: 127677
		[Token(Token = "0x401F2BD")]
		[FieldOffset(Offset = "0xE8")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0401F2BE RID: 127678
		[Token(Token = "0x401F2BE")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isInited;

		// Token: 0x0401F2BF RID: 127679
		[Token(Token = "0x401F2BF")]
		[FieldOffset(Offset = "0xF8")]
		private SiracusaOperaFrameViewModel m_cacheViewModel;

		// Token: 0x0401F2C0 RID: 127680
		[Token(Token = "0x401F2C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F2C1 RID: 127681
		[Token(Token = "0x401F2C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadSiracusaAvatar;

		// Token: 0x0401F2C2 RID: 127682
		[Token(Token = "0x401F2C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401F2C3 RID: 127683
		[Token(Token = "0x401F2C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F2C4 RID: 127684
		[Token(Token = "0x401F2C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F49 RID: 16201
		[Token(Token = "0x2003F49")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003C26 RID: 15398
			// (get) Token: 0x06019271 RID: 103025 RVA: 0x0009D1A0 File Offset: 0x0009B3A0
			[Token(Token = "0x17003C26")]
			public override int count
			{
				[Token(Token = "0x6019271")]
				[Address(RVA = "0x11C5230", Offset = "0x11C3E30", VA = "0x1811C5230", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019272 RID: 103026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019272")]
			[Address(RVA = "0x11C4370", Offset = "0x11C2F70", VA = "0x1811C4370", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019273 RID: 103027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019273")]
			[Address(RVA = "0x11C4F40", Offset = "0x11C3B40", VA = "0x1811C4F40")]
			public Adapter()
			{
			}

			// Token: 0x0401F2C5 RID: 127685
			[Token(Token = "0x401F2C5")]
			[FieldOffset(Offset = "0x20")]
			public List<SiracusaOperaFrameViewModel.HeadIcon> headIconList;

			// Token: 0x0401F2C6 RID: 127686
			[Token(Token = "0x401F2C6")]
			[FieldOffset(Offset = "0x28")]
			public UIPage page;

			// Token: 0x0401F2C7 RID: 127687
			[Token(Token = "0x401F2C7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F2C8 RID: 127688
			[Token(Token = "0x401F2C8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401F2C9 RID: 127689
			[Token(Token = "0x401F2C9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
