using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004248 RID: 16968
	[Token(Token = "0x2004248")]
	public class SandboxV2EventView : DataBinder<SandboxV2EventProperty>
	{
		// Token: 0x0601A274 RID: 107124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A274")]
		[Address(RVA = "0x13065D0", Offset = "0x13051D0", VA = "0x1813065D0", Slot = "7")]
		public override void OnValueChanged(SandboxV2EventProperty property)
		{
		}

		// Token: 0x0601A275 RID: 107125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A275")]
		[Address(RVA = "0x1307580", Offset = "0x1306180", VA = "0x181307580")]
		private void _PlayAnim()
		{
		}

		// Token: 0x0601A276 RID: 107126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A276")]
		[Address(RVA = "0x13076D0", Offset = "0x13062D0", VA = "0x1813076D0")]
		private void _RenderImmediately(bool isSameScene)
		{
		}

		// Token: 0x0601A277 RID: 107127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A277")]
		[Address(RVA = "0x1306E90", Offset = "0x1305A90", VA = "0x181306E90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A278 RID: 107128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A278")]
		[Address(RVA = "0x1306DE0", Offset = "0x13059E0", VA = "0x181306DE0")]
		private IEnumerator _AnimCoroutine()
		{
			return null;
		}

		// Token: 0x0601A279 RID: 107129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A279")]
		[Address(RVA = "0x1307120", Offset = "0x1305D20", VA = "0x181307120")]
		private void _LoadIcon(string topicId, string iconId, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601A27A RID: 107130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A27A")]
		[Address(RVA = "0x1307200", Offset = "0x1305E00", VA = "0x181307200")]
		private void _LoadNodeTypeIcon(string topicId, string nodeIconId, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601A27B RID: 107131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A27B")]
		[Address(RVA = "0x13072E0", Offset = "0x1305EE0", VA = "0x1813072E0")]
		private void _OnPostLayout()
		{
		}

		// Token: 0x0601A27C RID: 107132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A27C")]
		[Address(RVA = "0x1306450", Offset = "0x1305050", VA = "0x181306450")]
		public void OnBackGroundPress()
		{
		}

		// Token: 0x0601A27D RID: 107133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A27D")]
		[Address(RVA = "0x1307B80", Offset = "0x1306780", VA = "0x181307B80")]
		private IEnumerator _TutorialOnly_TryRaiseAVGSignal()
		{
			return null;
		}

		// Token: 0x0601A27E RID: 107134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A27E")]
		[Address(RVA = "0x13078C0", Offset = "0x13064C0", VA = "0x1813078C0")]
		private void _TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x0601A27F RID: 107135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A27F")]
		[Address(RVA = "0x1307C30", Offset = "0x1306830", VA = "0x181307C30")]
		public SandboxV2EventView()
		{
		}

		// Token: 0x040210AF RID: 135343
		[Token(Token = "0x40210AF")]
		private const float BOTTOM_TWEEN_DURATION = 0.6f;

		// Token: 0x040210B0 RID: 135344
		[Token(Token = "0x40210B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040210B1 RID: 135345
		[Token(Token = "0x40210B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _nodeIcon;

		// Token: 0x040210B2 RID: 135346
		[Token(Token = "0x40210B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _title;

		// Token: 0x040210B3 RID: 135347
		[Token(Token = "0x40210B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2EventTypeWriter _textWriter;

		// Token: 0x040210B4 RID: 135348
		[Token(Token = "0x40210B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040210B5 RID: 135349
		[Token(Token = "0x40210B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _textLight;

		// Token: 0x040210B6 RID: 135350
		[Token(Token = "0x40210B6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _textDark;

		// Token: 0x040210B7 RID: 135351
		[Token(Token = "0x40210B7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _choiceTitle;

		// Token: 0x040210B8 RID: 135352
		[Token(Token = "0x40210B8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _choiceDesc;

		// Token: 0x040210B9 RID: 135353
		[Token(Token = "0x40210B9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelChoiceDesc;

		// Token: 0x040210BA RID: 135354
		[Token(Token = "0x40210BA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UILayoutDimensionListener _contentDimensionListener;

		// Token: 0x040210BB RID: 135355
		[Token(Token = "0x40210BB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _choiceContent;

		// Token: 0x040210BC RID: 135356
		[Token(Token = "0x40210BC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040210BD RID: 135357
		[Token(Token = "0x40210BD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _exitAnim;

		// Token: 0x040210BE RID: 135358
		[Token(Token = "0x40210BE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ScrollRect _tutorialScrollRectRight;

		// Token: 0x040210BF RID: 135359
		[Token(Token = "0x40210BF")]
		[FieldOffset(Offset = "0xB8")]
		private int m_animSeq;

		// Token: 0x040210C0 RID: 135360
		[Token(Token = "0x40210C0")]
		[FieldOffset(Offset = "0xBC")]
		private int m_enterSeq;

		// Token: 0x040210C1 RID: 135361
		[Token(Token = "0x40210C1")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x040210C2 RID: 135362
		[Token(Token = "0x40210C2")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_playAnim;

		// Token: 0x040210C3 RID: 135363
		[Token(Token = "0x40210C3")]
		[FieldOffset(Offset = "0xC2")]
		private bool m_isEnter;

		// Token: 0x040210C4 RID: 135364
		[Token(Token = "0x40210C4")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_bottomTween;

		// Token: 0x040210C5 RID: 135365
		[Token(Token = "0x40210C5")]
		[FieldOffset(Offset = "0xD0")]
		private SandboxV2EventView.Adapter m_adapter;

		// Token: 0x040210C6 RID: 135366
		[Token(Token = "0x40210C6")]
		[FieldOffset(Offset = "0xD8")]
		private string m_cachedNodeId;

		// Token: 0x040210C7 RID: 135367
		[Token(Token = "0x40210C7")]
		[FieldOffset(Offset = "0xE0")]
		private string m_cachedEventId;

		// Token: 0x040210C8 RID: 135368
		[Token(Token = "0x40210C8")]
		[FieldOffset(Offset = "0xE8")]
		private string m_cachedSceneId;

		// Token: 0x040210C9 RID: 135369
		[Token(Token = "0x40210C9")]
		[FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040210CA RID: 135370
		[Token(Token = "0x40210CA")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040210CB RID: 135371
		[Token(Token = "0x40210CB")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine m_animCoroutine;

		// Token: 0x040210CC RID: 135372
		[Token(Token = "0x40210CC")]
		[FieldOffset(Offset = "0x118")]
		private SandboxV2EventView.AnimEnterTween m_enterTween;

		// Token: 0x040210CD RID: 135373
		[Token(Token = "0x40210CD")]
		[FieldOffset(Offset = "0x120")]
		private SandboxV2EventViewModel m_cachedViewModel;

		// Token: 0x040210CE RID: 135374
		[Token(Token = "0x40210CE")]
		[FieldOffset(Offset = "0x128")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x040210CF RID: 135375
		[Token(Token = "0x40210CF")]
		[FieldOffset(Offset = "0x130")]
		private bool m_isLocked;

		// Token: 0x040210D0 RID: 135376
		[Token(Token = "0x40210D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040210D1 RID: 135377
		[Token(Token = "0x40210D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x040210D2 RID: 135378
		[Token(Token = "0x40210D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderImmediately;

		// Token: 0x040210D3 RID: 135379
		[Token(Token = "0x40210D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040210D4 RID: 135380
		[Token(Token = "0x40210D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AnimCoroutine;

		// Token: 0x040210D5 RID: 135381
		[Token(Token = "0x40210D5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadIcon;

		// Token: 0x040210D6 RID: 135382
		[Token(Token = "0x40210D6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadNodeTypeIcon;

		// Token: 0x040210D7 RID: 135383
		[Token(Token = "0x40210D7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnPostLayout;

		// Token: 0x040210D8 RID: 135384
		[Token(Token = "0x40210D8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBackGroundPress;

		// Token: 0x040210D9 RID: 135385
		[Token(Token = "0x40210D9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRaiseAVGSignal;

		// Token: 0x040210DA RID: 135386
		[Token(Token = "0x40210DA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RegisterTutorialGo;

		// Token: 0x040210DB RID: 135387
		[Token(Token = "0x40210DB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004249 RID: 16969
		[Token(Token = "0x2004249")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A281 RID: 107137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A281")]
			[Address(RVA = "0x12FD140", Offset = "0x12FBD40", VA = "0x1812FD140")]
			public Adapter(SandboxV2EventView closure)
			{
			}

			// Token: 0x17003E2A RID: 15914
			// (get) Token: 0x0601A282 RID: 107138 RVA: 0x000A0668 File Offset: 0x0009E868
			[Token(Token = "0x17003E2A")]
			public override int count
			{
				[Token(Token = "0x601A282")]
				[Address(RVA = "0x12FD520", Offset = "0x12FC120", VA = "0x1812FD520", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A283 RID: 107139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A283")]
			[Address(RVA = "0x12FBFE0", Offset = "0x12FABE0", VA = "0x1812FBFE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601A284 RID: 107140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A284")]
			[Address(RVA = "0x12FCD90", Offset = "0x12FB990", VA = "0x1812FCD90")]
			public void TutorialOnly_RegisterTutorialGo()
			{
			}

			// Token: 0x040210DC RID: 135388
			[Token(Token = "0x40210DC")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2EventView m_closure;

			// Token: 0x040210DD RID: 135389
			[Token(Token = "0x40210DD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040210DE RID: 135390
			[Token(Token = "0x40210DE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040210DF RID: 135391
			[Token(Token = "0x40210DF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040210E0 RID: 135392
			[Token(Token = "0x40210E0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;
		}

		// Token: 0x0200424A RID: 16970
		[Token(Token = "0x200424A")]
		private class AnimEnterTween : UISwitchTween
		{
			// Token: 0x0601A285 RID: 107141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A285")]
			[Address(RVA = "0x12FDB00", Offset = "0x12FC700", VA = "0x1812FDB00")]
			public AnimEnterTween(SandboxV2EventView closure)
			{
			}

			// Token: 0x0601A286 RID: 107142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A286")]
			[Address(RVA = "0x12FD8D0", Offset = "0x12FC4D0", VA = "0x1812FD8D0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601A287 RID: 107143 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A287")]
			[Address(RVA = "0x12FD770", Offset = "0x12FC370", VA = "0x1812FD770", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601A288 RID: 107144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A288")]
			[Address(RVA = "0x12FDA30", Offset = "0x12FC630", VA = "0x1812FDA30", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601A289 RID: 107145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A289")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040210E1 RID: 135393
			[Token(Token = "0x40210E1")]
			[FieldOffset(Offset = "0x48")]
			private SandboxV2EventView m_closure;

			// Token: 0x040210E2 RID: 135394
			[Token(Token = "0x40210E2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040210E3 RID: 135395
			[Token(Token = "0x40210E3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040210E4 RID: 135396
			[Token(Token = "0x40210E4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040210E5 RID: 135397
			[Token(Token = "0x40210E5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
