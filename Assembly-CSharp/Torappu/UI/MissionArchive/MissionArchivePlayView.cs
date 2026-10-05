using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x02004852 RID: 18514
	[Token(Token = "0x2004852")]
	public class MissionArchivePlayView : DataBinder<MissionArchiveViewProperty>
	{
		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x0601BF83 RID: 114563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004273")]
		public Text subtitleText
		{
			[Token(Token = "0x601BF83")]
			[Address(RVA = "0x1552E50", Offset = "0x1551A50", VA = "0x181552E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x0601BF84 RID: 114564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004274")]
		public CanvasGroup subtitleGroup
		{
			[Token(Token = "0x601BF84")]
			[Address(RVA = "0x1552DF0", Offset = "0x15519F0", VA = "0x181552DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x0601BF85 RID: 114565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004275")]
		public List<CanvasGroup> playGroups
		{
			[Token(Token = "0x601BF85")]
			[Address(RVA = "0x1552CD0", Offset = "0x15518D0", VA = "0x181552CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x0601BF86 RID: 114566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004276")]
		public CanvasGroup hiddenPlayGroup
		{
			[Token(Token = "0x601BF86")]
			[Address(RVA = "0x1552C70", Offset = "0x1551870", VA = "0x181552C70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x0601BF87 RID: 114567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004277")]
		public CanvasGroup replayGroup
		{
			[Token(Token = "0x601BF87")]
			[Address(RVA = "0x1552D90", Offset = "0x1551990", VA = "0x181552D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x0601BF88 RID: 114568 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF89 RID: 114569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004278")]
		public Action replayEvent
		{
			[Token(Token = "0x601BF88")]
			[Address(RVA = "0x1552D30", Offset = "0x1551930", VA = "0x181552D30")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF89")]
			[Address(RVA = "0x1552EB0", Offset = "0x1551AB0", VA = "0x181552EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BF8A RID: 114570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF8A")]
		[Address(RVA = "0x1552280", Offset = "0x1550E80", VA = "0x181552280")]
		public void OnReplayEvent()
		{
		}

		// Token: 0x0601BF8B RID: 114571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF8B")]
		[Address(RVA = "0x1552390", Offset = "0x1550F90", VA = "0x181552390", Slot = "7")]
		public override void OnValueChanged(MissionArchiveViewProperty property)
		{
		}

		// Token: 0x0601BF8C RID: 114572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF8C")]
		[Address(RVA = "0x1552880", Offset = "0x1551480", VA = "0x181552880")]
		public void Reset()
		{
		}

		// Token: 0x0601BF8D RID: 114573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF8D")]
		[Address(RVA = "0x15521B0", Offset = "0x1550DB0", VA = "0x1815521B0")]
		public Tween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0601BF8E RID: 114574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF8E")]
		[Address(RVA = "0x1552090", Offset = "0x1550C90", VA = "0x181552090")]
		public Tween GenerateHideTween()
		{
			return null;
		}

		// Token: 0x0601BF8F RID: 114575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF8F")]
		[Address(RVA = "0x1552900", Offset = "0x1551500", VA = "0x181552900")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BF90 RID: 114576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF90")]
		[Address(RVA = "0x1552A20", Offset = "0x1551620", VA = "0x181552A20")]
		private Sprite _LoadNodeBkg(string topicId, string nodeId)
		{
			return null;
		}

		// Token: 0x0601BF91 RID: 114577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF91")]
		[Address(RVA = "0x1552B10", Offset = "0x1551710", VA = "0x181552B10")]
		private Sprite _LoadNodeLct(string topicId, string nodeId)
		{
			return null;
		}

		// Token: 0x0601BF92 RID: 114578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF92")]
		[Address(RVA = "0x1552C00", Offset = "0x1551800", VA = "0x181552C00")]
		public MissionArchivePlayView()
		{
		}

		// Token: 0x0402479C RID: 149404
		[Token(Token = "0x402479C")]
		private const string BKG_SPRITE_KEY_FORMAT = "bkg_{0}";

		// Token: 0x0402479D RID: 149405
		[Token(Token = "0x402479D")]
		private const string LCT_SPRITE_KEY_FORMAT = "lct_{0}";

		// Token: 0x0402479E RID: 149406
		[Token(Token = "0x402479E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bkgImage;

		// Token: 0x0402479F RID: 149407
		[Token(Token = "0x402479F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _lctImage;

		// Token: 0x040247A0 RID: 149408
		[Token(Token = "0x40247A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x040247A1 RID: 149409
		[Token(Token = "0x40247A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x040247A2 RID: 149410
		[Token(Token = "0x40247A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _entryAnimation;

		// Token: 0x040247A3 RID: 149411
		[Token(Token = "0x40247A3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _subtitleText;

		// Token: 0x040247A4 RID: 149412
		[Token(Token = "0x40247A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _subtitleGroup;

		// Token: 0x040247A5 RID: 149413
		[Token(Token = "0x40247A5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<CanvasGroup> _playGroups;

		// Token: 0x040247A6 RID: 149414
		[Token(Token = "0x40247A6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _hiddenPlayGroup;

		// Token: 0x040247A7 RID: 149415
		[Token(Token = "0x40247A7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _replayGroup;

		// Token: 0x040247A8 RID: 149416
		[Token(Token = "0x40247A8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] _normalPanels;

		// Token: 0x040247A9 RID: 149417
		[Token(Token = "0x40247A9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _hiddenPanels;

		// Token: 0x040247AA RID: 149418
		[Token(Token = "0x40247AA")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x040247AB RID: 149419
		[Token(Token = "0x40247AB")]
		[FieldOffset(Offset = "0x90")]
		private UIAnimationTween.Builder m_entryBuilder;

		// Token: 0x040247AC RID: 149420
		[Token(Token = "0x40247AC")]
		[FieldOffset(Offset = "0xB8")]
		private UIAnimationTween m_entryTween;

		// Token: 0x040247AD RID: 149421
		[Token(Token = "0x40247AD")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_finder;

		// Token: 0x040247AE RID: 149422
		[Token(Token = "0x40247AE")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cachedNoramlTopicId;

		// Token: 0x040247AF RID: 149423
		[Token(Token = "0x40247AF")]
		[FieldOffset(Offset = "0xD8")]
		private string m_cachedNormalNodeId;

		// Token: 0x040247B0 RID: 149424
		[Token(Token = "0x40247B0")]
		[FieldOffset(Offset = "0xE0")]
		private string m_cachedHiddenTopicId;

		// Token: 0x040247B2 RID: 149426
		[Token(Token = "0x40247B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_subtitleText;

		// Token: 0x040247B3 RID: 149427
		[Token(Token = "0x40247B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_subtitleGroup;

		// Token: 0x040247B4 RID: 149428
		[Token(Token = "0x40247B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_playGroups;

		// Token: 0x040247B5 RID: 149429
		[Token(Token = "0x40247B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hiddenPlayGroup;

		// Token: 0x040247B6 RID: 149430
		[Token(Token = "0x40247B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_replayGroup;

		// Token: 0x040247B7 RID: 149431
		[Token(Token = "0x40247B7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_replayEvent;

		// Token: 0x040247B8 RID: 149432
		[Token(Token = "0x40247B8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_replayEvent;

		// Token: 0x040247B9 RID: 149433
		[Token(Token = "0x40247B9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnReplayEvent;

		// Token: 0x040247BA RID: 149434
		[Token(Token = "0x40247BA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040247BB RID: 149435
		[Token(Token = "0x40247BB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040247BC RID: 149436
		[Token(Token = "0x40247BC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x040247BD RID: 149437
		[Token(Token = "0x40247BD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GenerateHideTween;

		// Token: 0x040247BE RID: 149438
		[Token(Token = "0x40247BE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040247BF RID: 149439
		[Token(Token = "0x40247BF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadNodeBkg;

		// Token: 0x040247C0 RID: 149440
		[Token(Token = "0x40247C0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadNodeLct;

		// Token: 0x040247C1 RID: 149441
		[Token(Token = "0x40247C1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
