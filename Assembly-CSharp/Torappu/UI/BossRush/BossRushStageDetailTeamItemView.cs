using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061D1 RID: 25041
	[Token(Token = "0x20061D1")]
	public class BossRushStageDetailTeamItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700553F RID: 21823
		// (get) Token: 0x06024221 RID: 148001 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024222 RID: 148002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700553F")]
		public Action<int> afterItemExpand
		{
			[Token(Token = "0x6024221")]
			[Address(RVA = "0x1EE0CE0", Offset = "0x1EDF8E0", VA = "0x181EE0CE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024222")]
			[Address(RVA = "0x1EE0E30", Offset = "0x1EDFA30", VA = "0x181EE0E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005540 RID: 21824
		// (get) Token: 0x06024223 RID: 148003 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024224 RID: 148004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005540")]
		public Action<string> onTeamClick
		{
			[Token(Token = "0x6024223")]
			[Address(RVA = "0x1EE0DD0", Offset = "0x1EDF9D0", VA = "0x181EE0DD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024224")]
			[Address(RVA = "0x1EE0EB0", Offset = "0x1EDFAB0", VA = "0x181EE0EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005541 RID: 21825
		// (get) Token: 0x06024225 RID: 148005 RVA: 0x000C3348 File Offset: 0x000C1548
		[Token(Token = "0x17005541")]
		public float itemWidth
		{
			[Token(Token = "0x6024225")]
			[Address(RVA = "0x1EE0D40", Offset = "0x1EDF940", VA = "0x181EE0D40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06024226 RID: 148006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024226")]
		[Address(RVA = "0x1EE0150", Offset = "0x1EDED50", VA = "0x181EE0150")]
		public void Render(int position, string selectTeamId, string actId, BossRushTeamModel teamModel, bool needRefresh)
		{
		}

		// Token: 0x06024227 RID: 148007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024227")]
		[Address(RVA = "0x1EE0060", Offset = "0x1EDEC60", VA = "0x181EE0060")]
		public void OnTeamCardClick()
		{
		}

		// Token: 0x06024228 RID: 148008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024228")]
		[Address(RVA = "0x1EE0A90", Offset = "0x1EDF690", VA = "0x181EE0A90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024229 RID: 148009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024229")]
		[Address(RVA = "0x1EE0C80", Offset = "0x1EDF880", VA = "0x181EE0C80")]
		public BossRushStageDetailTeamItemView()
		{
		}

		// Token: 0x040323C8 RID: 205768
		[Token(Token = "0x40323C8")]
		public const float TWEEN_DURATION = 0.2f;

		// Token: 0x040323C9 RID: 205769
		[Token(Token = "0x40323C9")]
		private const string TEXT_FORMAT_FREE_OPERATOR = "+{0}";

		// Token: 0x040323CA RID: 205770
		[Token(Token = "0x40323CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x040323CB RID: 205771
		[Token(Token = "0x40323CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _charCardContent;

		// Token: 0x040323CC RID: 205772
		[Token(Token = "0x40323CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _toggleSelect;

		// Token: 0x040323CD RID: 205773
		[Token(Token = "0x40323CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _toggleUnselect;

		// Token: 0x040323CE RID: 205774
		[Token(Token = "0x40323CE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgTeamIconUnselect;

		// Token: 0x040323CF RID: 205775
		[Token(Token = "0x40323CF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgTeamIconSelect;

		// Token: 0x040323D0 RID: 205776
		[Token(Token = "0x40323D0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textFreeNumUnselect;

		// Token: 0x040323D1 RID: 205777
		[Token(Token = "0x40323D1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textFreeNumSelect;

		// Token: 0x040323D2 RID: 205778
		[Token(Token = "0x40323D2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textFreeNumSelect2;

		// Token: 0x040323D3 RID: 205779
		[Token(Token = "0x40323D3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textTeamName;

		// Token: 0x040323D4 RID: 205780
		[Token(Token = "0x40323D4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage[] _charPortrait;

		// Token: 0x040323D5 RID: 205781
		[Token(Token = "0x40323D5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x040323D6 RID: 205782
		[Token(Token = "0x40323D6")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x040323D7 RID: 205783
		[Token(Token = "0x40323D7")]
		[FieldOffset(Offset = "0x88")]
		private BossRushStageDetailTeamItemView.Adapter m_adapter;

		// Token: 0x040323D8 RID: 205784
		[Token(Token = "0x40323D8")]
		[FieldOffset(Offset = "0x90")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x040323D9 RID: 205785
		[Token(Token = "0x40323D9")]
		[FieldOffset(Offset = "0x98")]
		private BossRushTeamModel m_cachedModel;

		// Token: 0x040323DC RID: 205788
		[Token(Token = "0x40323DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_afterItemExpand;

		// Token: 0x040323DD RID: 205789
		[Token(Token = "0x40323DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_afterItemExpand;

		// Token: 0x040323DE RID: 205790
		[Token(Token = "0x40323DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onTeamClick;

		// Token: 0x040323DF RID: 205791
		[Token(Token = "0x40323DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onTeamClick;

		// Token: 0x040323E0 RID: 205792
		[Token(Token = "0x40323E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_itemWidth;

		// Token: 0x040323E1 RID: 205793
		[Token(Token = "0x40323E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040323E2 RID: 205794
		[Token(Token = "0x40323E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTeamCardClick;

		// Token: 0x040323E3 RID: 205795
		[Token(Token = "0x40323E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040323E4 RID: 205796
		[Token(Token = "0x40323E4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061D2 RID: 25042
		[Token(Token = "0x20061D2")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602422A RID: 148010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602422A")]
			[Address(RVA = "0x1ECCFC0", Offset = "0x1ECBBC0", VA = "0x181ECCFC0")]
			public Adapter(BossRushStageDetailTeamItemView closure)
			{
			}

			// Token: 0x17005542 RID: 21826
			// (get) Token: 0x0602422B RID: 148011 RVA: 0x000C3360 File Offset: 0x000C1560
			[Token(Token = "0x17005542")]
			public override int count
			{
				[Token(Token = "0x602422B")]
				[Address(RVA = "0x1ECD0C0", Offset = "0x1ECBCC0", VA = "0x181ECD0C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602422C RID: 148012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602422C")]
			[Address(RVA = "0x1ECCC70", Offset = "0x1ECB870", VA = "0x181ECCC70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040323E5 RID: 205797
			[Token(Token = "0x40323E5")]
			[FieldOffset(Offset = "0x20")]
			private BossRushStageDetailTeamItemView m_closure;

			// Token: 0x040323E6 RID: 205798
			[Token(Token = "0x40323E6")]
			[FieldOffset(Offset = "0x28")]
			private int m_count;

			// Token: 0x040323E7 RID: 205799
			[Token(Token = "0x40323E7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040323E8 RID: 205800
			[Token(Token = "0x40323E8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040323E9 RID: 205801
			[Token(Token = "0x40323E9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
