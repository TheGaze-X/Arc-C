using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A52 RID: 27218
	[Token(Token = "0x2006A52")]
	public class StageMixStoryActOtherLineView : StageMixStoryLocationItem<StageStorylineStorySetLocationViewModel>
	{
		// Token: 0x06026E64 RID: 159332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E64")]
		[Address(RVA = "0x221E260", Offset = "0x221CE60", VA = "0x18221E260")]
		public void OnClickEvent()
		{
		}

		// Token: 0x06026E65 RID: 159333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E65")]
		[Address(RVA = "0x221E450", Offset = "0x221D050", VA = "0x18221E450", Slot = "4")]
		public override void OnSetInfo(StageStorylineStorySetLocationViewModel storySetLocation)
		{
		}

		// Token: 0x06026E66 RID: 159334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E66")]
		[Address(RVA = "0x221E790", Offset = "0x221D390", VA = "0x18221E790")]
		private void _Render(StageStorylineStorySetLocationViewModel storySetLocation)
		{
		}

		// Token: 0x06026E67 RID: 159335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E67")]
		[Address(RVA = "0x221EBA0", Offset = "0x221D7A0", VA = "0x18221EBA0")]
		private void _SetEffectStatus(StageStorylineStorySetLocationViewModel storySetLocation)
		{
		}

		// Token: 0x06026E68 RID: 159336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E68")]
		[Address(RVA = "0x221E5E0", Offset = "0x221D1E0", VA = "0x18221E5E0")]
		private void _RenderTitleOrClassified(StageStorylineStorySetLocationViewModel storySetLocation, StageStorylineStorySetViewModel storySet)
		{
		}

		// Token: 0x06026E69 RID: 159337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E69")]
		[Address(RVA = "0x221E4F0", Offset = "0x221D0F0", VA = "0x18221E4F0")]
		private void _RenderStorylineAbbr(StageStorylineViewModel storyline)
		{
		}

		// Token: 0x06026E6A RID: 159338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E6A")]
		[Address(RVA = "0x221EC80", Offset = "0x221D880", VA = "0x18221EC80")]
		public StageMixStoryActOtherLineView()
		{
		}

		// Token: 0x04037031 RID: 225329
		[Token(Token = "0x4037031")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _inPanel;

		// Token: 0x04037032 RID: 225330
		[Token(Token = "0x4037032")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _outPanel;

		// Token: 0x04037033 RID: 225331
		[Token(Token = "0x4037033")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _classifiedPanel;

		// Token: 0x04037034 RID: 225332
		[Token(Token = "0x4037034")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x04037035 RID: 225333
		[Token(Token = "0x4037035")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _mainlinePanel;

		// Token: 0x04037036 RID: 225334
		[Token(Token = "0x4037036")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _otherPanel;

		// Token: 0x04037037 RID: 225335
		[Token(Token = "0x4037037")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _storylineAbbrImage;

		// Token: 0x04037038 RID: 225336
		[Token(Token = "0x4037038")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIDynImage _storySetTitleImage;

		// Token: 0x04037039 RID: 225337
		[Token(Token = "0x4037039")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _width;

		// Token: 0x0403703A RID: 225338
		[Token(Token = "0x403703A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _followingSpacing;

		// Token: 0x0403703B RID: 225339
		[Token(Token = "0x403703B")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_finder;

		// Token: 0x0403703C RID: 225340
		[Token(Token = "0x403703C")]
		[FieldOffset(Offset = "0x78")]
		private StageStorylineStorySetLocationViewModel m_cachedModel;

		// Token: 0x0403703D RID: 225341
		[Token(Token = "0x403703D")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedAbbrImageId;

		// Token: 0x0403703E RID: 225342
		[Token(Token = "0x403703E")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedTitleImageId;

		// Token: 0x0403703F RID: 225343
		[Token(Token = "0x403703F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x04037040 RID: 225344
		[Token(Token = "0x4037040")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSetInfo;

		// Token: 0x04037041 RID: 225345
		[Token(Token = "0x4037041")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04037042 RID: 225346
		[Token(Token = "0x4037042")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetEffectStatus;

		// Token: 0x04037043 RID: 225347
		[Token(Token = "0x4037043")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderTitleOrClassified;

		// Token: 0x04037044 RID: 225348
		[Token(Token = "0x4037044")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderStorylineAbbr;

		// Token: 0x04037045 RID: 225349
		[Token(Token = "0x4037045")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A53 RID: 27219
		[Token(Token = "0x2006A53")]
		public class VirtualView : StageMixStoryLocationVirtualView<StageMixStoryActOtherLineView, StageStorylineStorySetLocationViewModel>, UIRecycleLayoutAdapter.ICustomSpacing
		{
			// Token: 0x17005BB9 RID: 23481
			// (get) Token: 0x06026E6B RID: 159339 RVA: 0x000CC9F0 File Offset: 0x000CABF0
			// (set) Token: 0x06026E6C RID: 159340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005BB9")]
			public bool following
			{
				[Token(Token = "0x6026E6B")]
				[Address(RVA = "0x2230C50", Offset = "0x222F850", VA = "0x182230C50")]
				[CompilerGenerated]
				private get
				{
					return default(bool);
				}
				[Token(Token = "0x6026E6C")]
				[Address(RVA = "0x2230CB0", Offset = "0x222F8B0", VA = "0x182230CB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06026E6D RID: 159341 RVA: 0x000CCA08 File Offset: 0x000CAC08
			[Token(Token = "0x6026E6D")]
			[Address(RVA = "0x2230800", Offset = "0x222F400", VA = "0x182230800", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06026E6E RID: 159342 RVA: 0x000CCA20 File Offset: 0x000CAC20
			[Token(Token = "0x6026E6E")]
			[Address(RVA = "0x22304A0", Offset = "0x222F0A0", VA = "0x1822304A0", Slot = "14")]
			public float GetCustomSpacing()
			{
				return 0f;
			}

			// Token: 0x06026E6F RID: 159343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026E6F")]
			[Address(RVA = "0x2230A90", Offset = "0x222F690", VA = "0x182230A90")]
			public VirtualView()
			{
			}

			// Token: 0x04037047 RID: 225351
			[Token(Token = "0x4037047")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_following;

			// Token: 0x04037048 RID: 225352
			[Token(Token = "0x4037048")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_following;

			// Token: 0x04037049 RID: 225353
			[Token(Token = "0x4037049")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403704A RID: 225354
			[Token(Token = "0x403704A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetCustomSpacing;

			// Token: 0x0403704B RID: 225355
			[Token(Token = "0x403704B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
