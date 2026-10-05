using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BB2 RID: 27570
	[Token(Token = "0x2006BB2")]
	public class ArchiveMusicListDataBinder : DataBinder<MusicProperty>
	{
		// Token: 0x17005CF6 RID: 23798
		// (get) Token: 0x060275ED RID: 161261 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060275EE RID: 161262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CF6")]
		public ActArchiveController controller
		{
			[Token(Token = "0x60275ED")]
			[Address(RVA = "0x2293E20", Offset = "0x2292A20", VA = "0x182293E20")]
			private get
			{
				return null;
			}
			[Token(Token = "0x60275EE")]
			[Address(RVA = "0x2293EE0", Offset = "0x2292AE0", VA = "0x182293EE0")]
			set
			{
			}
		}

		// Token: 0x17005CF7 RID: 23799
		// (get) Token: 0x060275EF RID: 161263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CF7")]
		public ArchiveMusicModel model
		{
			[Token(Token = "0x60275EF")]
			[Address(RVA = "0x2293E80", Offset = "0x2292A80", VA = "0x182293E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060275F0 RID: 161264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275F0")]
		[Address(RVA = "0x22929D0", Offset = "0x22915D0", VA = "0x1822929D0", Slot = "7")]
		public override void OnValueChanged(MusicProperty property)
		{
		}

		// Token: 0x060275F1 RID: 161265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275F1")]
		[Address(RVA = "0x2293110", Offset = "0x2291D10", VA = "0x182293110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060275F2 RID: 161266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275F2")]
		[Address(RVA = "0x2293580", Offset = "0x2292180", VA = "0x182293580")]
		private void _ResetPosition()
		{
		}

		// Token: 0x060275F3 RID: 161267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275F3")]
		[Address(RVA = "0x2293360", Offset = "0x2291F60", VA = "0x182293360")]
		private void _RefreshHomeMusicId()
		{
		}

		// Token: 0x060275F4 RID: 161268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275F4")]
		[Address(RVA = "0x22933E0", Offset = "0x2291FE0", VA = "0x1822933E0")]
		private void _RefreshSelectedMusicId()
		{
		}

		// Token: 0x060275F5 RID: 161269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275F5")]
		[Address(RVA = "0x2293090", Offset = "0x2291C90", VA = "0x182293090")]
		private void _BeforeSwitchAnim()
		{
		}

		// Token: 0x060275F6 RID: 161270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275F6")]
		[Address(RVA = "0x2292FB0", Offset = "0x2291BB0", VA = "0x182292FB0")]
		private void _AfterSwitchAnim()
		{
		}

		// Token: 0x060275F7 RID: 161271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275F7")]
		[Address(RVA = "0x2293950", Offset = "0x2292550", VA = "0x182293950")]
		private void _ShowMusicItem(MusicItemModel model)
		{
		}

		// Token: 0x060275F8 RID: 161272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275F8")]
		[Address(RVA = "0x2293AE0", Offset = "0x22926E0", VA = "0x182293AE0")]
		private void _SwitchItemCard(int cardNeedToHide, int cardNeedToShow, MusicItemModel newModel)
		{
		}

		// Token: 0x060275F9 RID: 161273 RVA: 0x000CE3A0 File Offset: 0x000CC5A0
		[Token(Token = "0x60275F9")]
		[Address(RVA = "0x2293030", Offset = "0x2291C30", VA = "0x182293030")]
		private long _BGMInstId()
		{
			return 0L;
		}

		// Token: 0x060275FA RID: 161274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275FA")]
		[Address(RVA = "0x2292DE0", Offset = "0x22919E0", VA = "0x182292DE0")]
		public void RefreshBGM()
		{
		}

		// Token: 0x060275FB RID: 161275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275FB")]
		[Address(RVA = "0x2292810", Offset = "0x2291410", VA = "0x182292810")]
		public void ClearBGM()
		{
		}

		// Token: 0x060275FC RID: 161276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275FC")]
		[Address(RVA = "0x22928F0", Offset = "0x22914F0", VA = "0x1822928F0")]
		public IEnumerator FocusOnSelectedItem(bool fastMode, float duration)
		{
			return null;
		}

		// Token: 0x060275FD RID: 161277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275FD")]
		[Address(RVA = "0x2293D60", Offset = "0x2292960", VA = "0x182293D60")]
		public ArchiveMusicListDataBinder()
		{
		}

		// Token: 0x04037C69 RID: 228457
		[Token(Token = "0x4037C69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoFocusScrollView _scrollView;

		// Token: 0x04037C6A RID: 228458
		[Token(Token = "0x4037C6A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04037C6B RID: 228459
		[Token(Token = "0x4037C6B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _imgListItemTitleNormal;

		// Token: 0x04037C6C RID: 228460
		[Token(Token = "0x4037C6C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ArchiveMusicCardItemView> _cardViewList;

		// Token: 0x04037C6D RID: 228461
		[Token(Token = "0x4037C6D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveMusicListDataBinder.MusicDiscView _musicDiscView;

		// Token: 0x04037C6E RID: 228462
		[Token(Token = "0x4037C6E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArchiveMusicListDataBinder.MusicHomeThemeDiscRightView _musicHomeThemeDiscRightView;

		// Token: 0x04037C6F RID: 228463
		[Token(Token = "0x4037C6F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArchiveMusicListDataBinder.MusicHomeThemeButtonView _musicHomeThemeButtonView;

		// Token: 0x04037C70 RID: 228464
		[Token(Token = "0x4037C70")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x04037C71 RID: 228465
		[Token(Token = "0x4037C71")]
		[FieldOffset(Offset = "0x5C")]
		private int m_currCardIndex;

		// Token: 0x04037C72 RID: 228466
		[Token(Token = "0x4037C72")]
		[FieldOffset(Offset = "0x60")]
		private ArchiveMusicListDataBinder.ArchiveMusicListAdapter m_listAdapter;

		// Token: 0x04037C73 RID: 228467
		[Token(Token = "0x4037C73")]
		[FieldOffset(Offset = "0x68")]
		private ActArchiveController m_controller;

		// Token: 0x04037C74 RID: 228468
		[Token(Token = "0x4037C74")]
		[FieldOffset(Offset = "0x70")]
		private ArchiveMusicModel m_cachedModel;

		// Token: 0x04037C75 RID: 228469
		[Token(Token = "0x4037C75")]
		[FieldOffset(Offset = "0x78")]
		private MusicItemModel m_pendingModel;

		// Token: 0x04037C76 RID: 228470
		[Token(Token = "0x4037C76")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedSelectedMusicId;

		// Token: 0x04037C77 RID: 228471
		[Token(Token = "0x4037C77")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedHomeMusicId;

		// Token: 0x04037C78 RID: 228472
		[Token(Token = "0x4037C78")]
		[FieldOffset(Offset = "0x90")]
		private Sequence m_sequence;

		// Token: 0x04037C79 RID: 228473
		[Token(Token = "0x4037C79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037C7A RID: 228474
		[Token(Token = "0x4037C7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037C7B RID: 228475
		[Token(Token = "0x4037C7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_model;

		// Token: 0x04037C7C RID: 228476
		[Token(Token = "0x4037C7C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037C7D RID: 228477
		[Token(Token = "0x4037C7D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037C7E RID: 228478
		[Token(Token = "0x4037C7E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetPosition;

		// Token: 0x04037C7F RID: 228479
		[Token(Token = "0x4037C7F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshHomeMusicId;

		// Token: 0x04037C80 RID: 228480
		[Token(Token = "0x4037C80")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshSelectedMusicId;

		// Token: 0x04037C81 RID: 228481
		[Token(Token = "0x4037C81")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__BeforeSwitchAnim;

		// Token: 0x04037C82 RID: 228482
		[Token(Token = "0x4037C82")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AfterSwitchAnim;

		// Token: 0x04037C83 RID: 228483
		[Token(Token = "0x4037C83")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowMusicItem;

		// Token: 0x04037C84 RID: 228484
		[Token(Token = "0x4037C84")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SwitchItemCard;

		// Token: 0x04037C85 RID: 228485
		[Token(Token = "0x4037C85")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__BGMInstId;

		// Token: 0x04037C86 RID: 228486
		[Token(Token = "0x4037C86")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshBGM;

		// Token: 0x04037C87 RID: 228487
		[Token(Token = "0x4037C87")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ClearBGM;

		// Token: 0x04037C88 RID: 228488
		[Token(Token = "0x4037C88")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_FocusOnSelectedItem;

		// Token: 0x04037C89 RID: 228489
		[Token(Token = "0x4037C89")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BB3 RID: 27571
		[Token(Token = "0x2006BB3")]
		public class ArchiveMusicListAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x17005CF8 RID: 23800
			// (get) Token: 0x060275FF RID: 161279 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027600 RID: 161280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005CF8")]
			public ListDict<string, MusicItemModel> dataSet
			{
				[Token(Token = "0x60275FF")]
				[Address(RVA = "0x2292730", Offset = "0x2291330", VA = "0x182292730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027600")]
				[Address(RVA = "0x2292790", Offset = "0x2291390", VA = "0x182292790")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005CF9 RID: 23801
			// (get) Token: 0x06027601 RID: 161281 RVA: 0x000CE3B8 File Offset: 0x000CC5B8
			[Token(Token = "0x17005CF9")]
			public override int count
			{
				[Token(Token = "0x6027601")]
				[Address(RVA = "0x2292670", Offset = "0x2291270", VA = "0x182292670", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027602 RID: 161282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027602")]
			[Address(RVA = "0x22925F0", Offset = "0x22911F0", VA = "0x1822925F0")]
			public ArchiveMusicListAdapter(ArchiveMusicListDataBinder closure)
			{
			}

			// Token: 0x06027603 RID: 161283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027603")]
			[Address(RVA = "0x2292330", Offset = "0x2290F30", VA = "0x182292330", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037C8A RID: 228490
			[Token(Token = "0x4037C8A")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveMusicListDataBinder m_closure;

			// Token: 0x04037C8C RID: 228492
			[Token(Token = "0x4037C8C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04037C8D RID: 228493
			[Token(Token = "0x4037C8D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04037C8E RID: 228494
			[Token(Token = "0x4037C8E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037C8F RID: 228495
			[Token(Token = "0x4037C8F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037C90 RID: 228496
			[Token(Token = "0x4037C90")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006BB4 RID: 27572
		[Token(Token = "0x2006BB4")]
		[Serializable]
		private class MusicDiscView : IHotfixable
		{
			// Token: 0x17005CFA RID: 23802
			// (get) Token: 0x06027604 RID: 161284 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027605 RID: 161285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005CFA")]
			public ArchiveMusicListDataBinder closure
			{
				[Token(Token = "0x6027604")]
				[Address(RVA = "0x22A3A20", Offset = "0x22A2620", VA = "0x1822A3A20")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027605")]
				[Address(RVA = "0x22A3A80", Offset = "0x22A2680", VA = "0x1822A3A80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06027606 RID: 161286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027606")]
			[Address(RVA = "0x22A3710", Offset = "0x22A2310", VA = "0x1822A3710")]
			private Sprite _LoadDiscCoverSprite(MusicItemModel newModel)
			{
				return null;
			}

			// Token: 0x06027607 RID: 161287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027607")]
			[Address(RVA = "0x22A2FA0", Offset = "0x22A1BA0", VA = "0x1822A2FA0")]
			public Sequence GetAnimSequence(MusicItemModel newModel)
			{
				return null;
			}

			// Token: 0x06027608 RID: 161288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027608")]
			[Address(RVA = "0x22A34A0", Offset = "0x22A20A0", VA = "0x1822A34A0")]
			public void ToggleRotationAnim(bool start)
			{
			}

			// Token: 0x06027609 RID: 161289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027609")]
			[Address(RVA = "0x22A3330", Offset = "0x22A1F30", VA = "0x1822A3330")]
			public void ResetPosition()
			{
			}

			// Token: 0x0602760A RID: 161290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602760A")]
			[Address(RVA = "0x22A32A0", Offset = "0x22A1EA0", VA = "0x1822A32A0")]
			public void Render(MusicItemModel newModel)
			{
			}

			// Token: 0x0602760B RID: 161291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602760B")]
			[Address(RVA = "0x22A39C0", Offset = "0x22A25C0", VA = "0x1822A39C0")]
			public MusicDiscView()
			{
			}

			// Token: 0x04037C91 RID: 228497
			[Token(Token = "0x4037C91")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private RectTransform _transformDisc;

			// Token: 0x04037C92 RID: 228498
			[Token(Token = "0x4037C92")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private CanvasGroup _canvasDisc;

			// Token: 0x04037C93 RID: 228499
			[Token(Token = "0x4037C93")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image _imgDiscCover;

			// Token: 0x04037C94 RID: 228500
			[Token(Token = "0x4037C94")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RectTransform _transformDiscCover;

			// Token: 0x04037C95 RID: 228501
			[Token(Token = "0x4037C95")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private float _scaleDisc;

			// Token: 0x04037C96 RID: 228502
			[Token(Token = "0x4037C96")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private float _transDuration;

			// Token: 0x04037C97 RID: 228503
			[Token(Token = "0x4037C97")]
			[FieldOffset(Offset = "0x38")]
			private Tween m_rotationSeq;

			// Token: 0x04037C99 RID: 228505
			[Token(Token = "0x4037C99")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_closure;

			// Token: 0x04037C9A RID: 228506
			[Token(Token = "0x4037C9A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_closure;

			// Token: 0x04037C9B RID: 228507
			[Token(Token = "0x4037C9B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__LoadDiscCoverSprite;

			// Token: 0x04037C9C RID: 228508
			[Token(Token = "0x4037C9C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetAnimSequence;

			// Token: 0x04037C9D RID: 228509
			[Token(Token = "0x4037C9D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ToggleRotationAnim;

			// Token: 0x04037C9E RID: 228510
			[Token(Token = "0x4037C9E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetPosition;

			// Token: 0x04037C9F RID: 228511
			[Token(Token = "0x4037C9F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04037CA0 RID: 228512
			[Token(Token = "0x4037CA0")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006BB6 RID: 27574
		[Token(Token = "0x2006BB6")]
		[Serializable]
		private class MusicHomeThemeDiscRightView : IHotfixable
		{
			// Token: 0x17005CFB RID: 23803
			// (get) Token: 0x0602760E RID: 161294 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602760F RID: 161295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005CFB")]
			public ArchiveMusicListDataBinder closure
			{
				[Token(Token = "0x602760E")]
				[Address(RVA = "0x22A4B80", Offset = "0x22A3780", VA = "0x1822A4B80")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602760F")]
				[Address(RVA = "0x22A4BE0", Offset = "0x22A37E0", VA = "0x1822A4BE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06027610 RID: 161296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027610")]
			[Address(RVA = "0x22A4A90", Offset = "0x22A3690", VA = "0x1822A4A90")]
			private void _KillIfNecessary(ref Sequence seq)
			{
			}

			// Token: 0x06027611 RID: 161297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027611")]
			[Address(RVA = "0x22A4430", Offset = "0x22A3030", VA = "0x1822A4430")]
			public void BeforeSwitchAnim()
			{
			}

			// Token: 0x06027612 RID: 161298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027612")]
			[Address(RVA = "0x22A4190", Offset = "0x22A2D90", VA = "0x1822A4190")]
			public void AfterSwitchAnim()
			{
			}

			// Token: 0x06027613 RID: 161299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027613")]
			[Address(RVA = "0x22A45F0", Offset = "0x22A31F0", VA = "0x1822A45F0")]
			public void OnHomeThemeChanged()
			{
			}

			// Token: 0x06027614 RID: 161300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027614")]
			[Address(RVA = "0x22A4860", Offset = "0x22A3460", VA = "0x1822A4860")]
			public void ResetPosition()
			{
			}

			// Token: 0x06027615 RID: 161301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027615")]
			[Address(RVA = "0x22A4B20", Offset = "0x22A3720", VA = "0x1822A4B20")]
			public MusicHomeThemeDiscRightView()
			{
			}

			// Token: 0x04037CA3 RID: 228515
			[Token(Token = "0x4037CA3")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private RectTransform _transformDiscRight;

			// Token: 0x04037CA4 RID: 228516
			[Token(Token = "0x4037CA4")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _discRightDefaultX;

			// Token: 0x04037CA5 RID: 228517
			[Token(Token = "0x4037CA5")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int _discRightTargetX;

			// Token: 0x04037CA6 RID: 228518
			[Token(Token = "0x4037CA6")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _transDuration;

			// Token: 0x04037CA8 RID: 228520
			[Token(Token = "0x4037CA8")]
			[FieldOffset(Offset = "0x30")]
			private Sequence m_seqOut;

			// Token: 0x04037CA9 RID: 228521
			[Token(Token = "0x4037CA9")]
			[FieldOffset(Offset = "0x38")]
			private Sequence m_seqIn;

			// Token: 0x04037CAA RID: 228522
			[Token(Token = "0x4037CAA")]
			[FieldOffset(Offset = "0x40")]
			private Sequence m_seqToggle;

			// Token: 0x04037CAB RID: 228523
			[Token(Token = "0x4037CAB")]
			[FieldOffset(Offset = "0x48")]
			private bool m_isSwitching;

			// Token: 0x04037CAC RID: 228524
			[Token(Token = "0x4037CAC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_closure;

			// Token: 0x04037CAD RID: 228525
			[Token(Token = "0x4037CAD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_closure;

			// Token: 0x04037CAE RID: 228526
			[Token(Token = "0x4037CAE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__KillIfNecessary;

			// Token: 0x04037CAF RID: 228527
			[Token(Token = "0x4037CAF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeSwitchAnim;

			// Token: 0x04037CB0 RID: 228528
			[Token(Token = "0x4037CB0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterSwitchAnim;

			// Token: 0x04037CB1 RID: 228529
			[Token(Token = "0x4037CB1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnHomeThemeChanged;

			// Token: 0x04037CB2 RID: 228530
			[Token(Token = "0x4037CB2")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ResetPosition;

			// Token: 0x04037CB3 RID: 228531
			[Token(Token = "0x4037CB3")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006BB7 RID: 27575
		[Token(Token = "0x2006BB7")]
		[Serializable]
		private class MusicHomeThemeButtonView : IHotfixable
		{
			// Token: 0x17005CFC RID: 23804
			// (get) Token: 0x06027619 RID: 161305 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602761A RID: 161306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005CFC")]
			public ArchiveMusicListDataBinder closure
			{
				[Token(Token = "0x6027619")]
				[Address(RVA = "0x22A40B0", Offset = "0x22A2CB0", VA = "0x1822A40B0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602761A")]
				[Address(RVA = "0x22A4110", Offset = "0x22A2D10", VA = "0x1822A4110")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0602761B RID: 161307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602761B")]
			[Address(RVA = "0x22A3E30", Offset = "0x22A2A30", VA = "0x1822A3E30")]
			public void RefreshHomeThemeButton()
			{
			}

			// Token: 0x0602761C RID: 161308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602761C")]
			[Address(RVA = "0x22A3B00", Offset = "0x22A2700", VA = "0x1822A3B00")]
			public void OnHomeThemeChanged()
			{
			}

			// Token: 0x0602761D RID: 161309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602761D")]
			[Address(RVA = "0x22A3E90", Offset = "0x22A2A90", VA = "0x1822A3E90")]
			public void ResetPosition()
			{
			}

			// Token: 0x0602761E RID: 161310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602761E")]
			[Address(RVA = "0x22A4050", Offset = "0x22A2C50", VA = "0x1822A4050")]
			public MusicHomeThemeButtonView()
			{
			}

			// Token: 0x04037CB4 RID: 228532
			[Token(Token = "0x4037CB4")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private CanvasGroup _canvasSet;

			// Token: 0x04037CB5 RID: 228533
			[Token(Token = "0x4037CB5")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private CanvasGroup _canvasUnset;

			// Token: 0x04037CB6 RID: 228534
			[Token(Token = "0x4037CB6")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _transDuration;

			// Token: 0x04037CB8 RID: 228536
			[Token(Token = "0x4037CB8")]
			[FieldOffset(Offset = "0x30")]
			private Sequence m_seq;

			// Token: 0x04037CB9 RID: 228537
			[Token(Token = "0x4037CB9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_closure;

			// Token: 0x04037CBA RID: 228538
			[Token(Token = "0x4037CBA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_closure;

			// Token: 0x04037CBB RID: 228539
			[Token(Token = "0x4037CBB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RefreshHomeThemeButton;

			// Token: 0x04037CBC RID: 228540
			[Token(Token = "0x4037CBC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnHomeThemeChanged;

			// Token: 0x04037CBD RID: 228541
			[Token(Token = "0x4037CBD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ResetPosition;

			// Token: 0x04037CBE RID: 228542
			[Token(Token = "0x4037CBE")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
