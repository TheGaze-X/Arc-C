using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056FD RID: 22269
	[Token(Token = "0x20056FD")]
	public class RL04NodeUpgradeView : DataBinder<RL04NodeUpgradeProp>
	{
		// Token: 0x06020AA5 RID: 133797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AA5")]
		[Address(RVA = "0x1ACC8F0", Offset = "0x1ACB4F0", VA = "0x181ACC8F0", Slot = "7")]
		public override void OnValueChanged(RL04NodeUpgradeProp property)
		{
		}

		// Token: 0x06020AA6 RID: 133798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AA6")]
		[Address(RVA = "0x1ACCF50", Offset = "0x1ACBB50", VA = "0x181ACCF50")]
		private void _PlayEnterAnimIfNeed()
		{
		}

		// Token: 0x06020AA7 RID: 133799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AA7")]
		[Address(RVA = "0x1ACD4C0", Offset = "0x1ACC0C0", VA = "0x181ACD4C0")]
		private void _RenderView()
		{
		}

		// Token: 0x06020AA8 RID: 133800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020AA8")]
		[Address(RVA = "0x1ACCA70", Offset = "0x1ACB670", VA = "0x181ACCA70")]
		private List<int> _GenerateShowAnimIdxList()
		{
			return null;
		}

		// Token: 0x06020AA9 RID: 133801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AA9")]
		[Address(RVA = "0x1ACD120", Offset = "0x1ACBD20", VA = "0x181ACD120")]
		private void _RenderBtnConfirmPanel()
		{
		}

		// Token: 0x06020AAA RID: 133802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AAA")]
		[Address(RVA = "0x1ACCD00", Offset = "0x1ACB900", VA = "0x181ACCD00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020AAB RID: 133803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AAB")]
		[Address(RVA = "0x1ACC9F0", Offset = "0x1ACB5F0", VA = "0x181ACC9F0")]
		public void SetConfig(RL04NodeUpgradeConfig config)
		{
		}

		// Token: 0x06020AAC RID: 133804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AAC")]
		[Address(RVA = "0x1ACDB60", Offset = "0x1ACC760", VA = "0x181ACDB60")]
		public RL04NodeUpgradeView()
		{
		}

		// Token: 0x0402C518 RID: 181528
		[Token(Token = "0x402C518")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x0402C519 RID: 181529
		[Token(Token = "0x402C519")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL04NodeUpgradeMuralView _muralPrefab;

		// Token: 0x0402C51A RID: 181530
		[Token(Token = "0x402C51A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _muralContainer;

		// Token: 0x0402C51B RID: 181531
		[Token(Token = "0x402C51B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _muralPermCompleteDuration;

		// Token: 0x0402C51C RID: 181532
		[Token(Token = "0x402C51C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTypeName;

		// Token: 0x0402C51D RID: 181533
		[Token(Token = "0x402C51D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _permList;

		// Token: 0x0402C51E RID: 181534
		[Token(Token = "0x402C51E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _tempList;

		// Token: 0x0402C51F RID: 181535
		[Token(Token = "0x402C51F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _imgTempCaptionLine;

		// Token: 0x0402C520 RID: 181536
		[Token(Token = "0x402C520")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _imgTempCaptionIcon;

		// Token: 0x0402C521 RID: 181537
		[Token(Token = "0x402C521")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textTempCaption;

		// Token: 0x0402C522 RID: 181538
		[Token(Token = "0x402C522")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lockTempIconGo;

		// Token: 0x0402C523 RID: 181539
		[Token(Token = "0x402C523")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _todoTempIconGo;

		// Token: 0x0402C524 RID: 181540
		[Token(Token = "0x402C524")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _unlockTempIconGo;

		// Token: 0x0402C525 RID: 181541
		[Token(Token = "0x402C525")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _imgTempInfoLine;

		// Token: 0x0402C526 RID: 181542
		[Token(Token = "0x402C526")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _imgBtnConfirmBg;

		// Token: 0x0402C527 RID: 181543
		[Token(Token = "0x402C527")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _confirmToDoGo;

		// Token: 0x0402C528 RID: 181544
		[Token(Token = "0x402C528")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _confirmCompleteGo;

		// Token: 0x0402C529 RID: 181545
		[Token(Token = "0x402C529")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textBtnName;

		// Token: 0x0402C52A RID: 181546
		[Token(Token = "0x402C52A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _textItemCost;

		// Token: 0x0402C52B RID: 181547
		[Token(Token = "0x402C52B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _textItemCount;

		// Token: 0x0402C52C RID: 181548
		[Token(Token = "0x402C52C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0402C52D RID: 181549
		[Token(Token = "0x402C52D")]
		[FieldOffset(Offset = "0xD0")]
		private RL04NodeUpgradeConfig m_config;

		// Token: 0x0402C52E RID: 181550
		[Token(Token = "0x402C52E")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_hasInited;

		// Token: 0x0402C52F RID: 181551
		[Token(Token = "0x402C52F")]
		[FieldOffset(Offset = "0xE0")]
		private RL04NodeUpgradeView.PermListAdapter m_permListAdapter;

		// Token: 0x0402C530 RID: 181552
		[Token(Token = "0x402C530")]
		[FieldOffset(Offset = "0xE8")]
		private RL04NodeUpgradeView.TempListAdapter m_tempListAdapter;

		// Token: 0x0402C531 RID: 181553
		[Token(Token = "0x402C531")]
		[FieldOffset(Offset = "0xF0")]
		private RL04NodeUpgradeModel m_upgradeModel;

		// Token: 0x0402C532 RID: 181554
		[Token(Token = "0x402C532")]
		[FieldOffset(Offset = "0xF8")]
		private RL04NodeUpgradeMuralView m_muralView;

		// Token: 0x0402C533 RID: 181555
		[Token(Token = "0x402C533")]
		[FieldOffset(Offset = "0x100")]
		private int m_cacheEnterSeq;

		// Token: 0x0402C534 RID: 181556
		[Token(Token = "0x402C534")]
		[FieldOffset(Offset = "0x104")]
		private int m_cacheCompleteSeq;

		// Token: 0x0402C535 RID: 181557
		[Token(Token = "0x402C535")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<int, int> m_cacheMuralShowSeqNumDict;

		// Token: 0x0402C536 RID: 181558
		[Token(Token = "0x402C536")]
		[FieldOffset(Offset = "0x110")]
		private Tween m_enterTween;

		// Token: 0x0402C537 RID: 181559
		[Token(Token = "0x402C537")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402C538 RID: 181560
		[Token(Token = "0x402C538")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayEnterAnimIfNeed;

		// Token: 0x0402C539 RID: 181561
		[Token(Token = "0x402C539")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0402C53A RID: 181562
		[Token(Token = "0x402C53A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenerateShowAnimIdxList;

		// Token: 0x0402C53B RID: 181563
		[Token(Token = "0x402C53B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderBtnConfirmPanel;

		// Token: 0x0402C53C RID: 181564
		[Token(Token = "0x402C53C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C53D RID: 181565
		[Token(Token = "0x402C53D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetConfig;

		// Token: 0x0402C53E RID: 181566
		[Token(Token = "0x402C53E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056FE RID: 22270
		[Token(Token = "0x20056FE")]
		private class PermListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06020AAD RID: 133805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020AAD")]
			[Address(RVA = "0x1ABADE0", Offset = "0x1AB99E0", VA = "0x181ABADE0")]
			public PermListAdapter(RL04NodeUpgradeView closure)
			{
			}

			// Token: 0x17004C9E RID: 19614
			// (get) Token: 0x06020AAE RID: 133806 RVA: 0x000B6C28 File Offset: 0x000B4E28
			[Token(Token = "0x17004C9E")]
			public override int count
			{
				[Token(Token = "0x6020AAE")]
				[Address(RVA = "0x1ABAE60", Offset = "0x1AB9A60", VA = "0x181ABAE60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020AAF RID: 133807 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020AAF")]
			[Address(RVA = "0x1ABAA40", Offset = "0x1AB9640", VA = "0x181ABAA40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C53F RID: 181567
			[Token(Token = "0x402C53F")]
			[FieldOffset(Offset = "0x20")]
			private RL04NodeUpgradeView m_closure;

			// Token: 0x0402C540 RID: 181568
			[Token(Token = "0x402C540")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C541 RID: 181569
			[Token(Token = "0x402C541")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C542 RID: 181570
			[Token(Token = "0x402C542")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020056FF RID: 22271
		[Token(Token = "0x20056FF")]
		private class TempListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06020AB0 RID: 133808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020AB0")]
			[Address(RVA = "0x1ACF5C0", Offset = "0x1ACE1C0", VA = "0x181ACF5C0")]
			public TempListAdapter(RL04NodeUpgradeView closure)
			{
			}

			// Token: 0x17004C9F RID: 19615
			// (get) Token: 0x06020AB1 RID: 133809 RVA: 0x000B6C40 File Offset: 0x000B4E40
			[Token(Token = "0x17004C9F")]
			public override int count
			{
				[Token(Token = "0x6020AB1")]
				[Address(RVA = "0x1ACF640", Offset = "0x1ACE240", VA = "0x181ACF640", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020AB2 RID: 133810 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020AB2")]
			[Address(RVA = "0x1ACF3F0", Offset = "0x1ACDFF0", VA = "0x181ACF3F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C543 RID: 181571
			[Token(Token = "0x402C543")]
			[FieldOffset(Offset = "0x20")]
			private RL04NodeUpgradeView m_closure;

			// Token: 0x0402C544 RID: 181572
			[Token(Token = "0x402C544")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C545 RID: 181573
			[Token(Token = "0x402C545")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C546 RID: 181574
			[Token(Token = "0x402C546")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
