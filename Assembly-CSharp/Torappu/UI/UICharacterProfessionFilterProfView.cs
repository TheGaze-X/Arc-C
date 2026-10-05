using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003518 RID: 13592
	[Token(Token = "0x2003518")]
	public class UICharacterProfessionFilterProfView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015ABD RID: 88765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ABD")]
		[Address(RVA = "0xE3F470", Offset = "0xE3E070", VA = "0x180E3F470")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015ABE RID: 88766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ABE")]
		[Address(RVA = "0xE3F220", Offset = "0xE3DE20", VA = "0x180E3F220")]
		public void Render(UICharacterProfessionFilterViewModel model, bool isFastMode)
		{
		}

		// Token: 0x06015ABF RID: 88767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ABF")]
		[Address(RVA = "0xE3F9F0", Offset = "0xE3E5F0", VA = "0x180E3F9F0")]
		private void _RenderCursor(UICharacterProfessionFilterViewModel model, bool isFastMode)
		{
		}

		// Token: 0x06015AC0 RID: 88768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AC0")]
		[Address(RVA = "0xE3F730", Offset = "0xE3E330", VA = "0x180E3F730")]
		private void _MoveCursor(RectTransform target, bool isFastMode, bool forceUpdate = false)
		{
		}

		// Token: 0x06015AC1 RID: 88769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AC1")]
		[Address(RVA = "0xE3F980", Offset = "0xE3E580", VA = "0x180E3F980")]
		private void _OnPostLayout()
		{
		}

		// Token: 0x06015AC2 RID: 88770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AC2")]
		[Address(RVA = "0xE3FBA0", Offset = "0xE3E7A0", VA = "0x180E3FBA0")]
		public UICharacterProfessionFilterProfView()
		{
		}

		// Token: 0x0401A015 RID: 106517
		[Token(Token = "0x401A015")]
		private const float MOVE_DURATION = 0.35f;

		// Token: 0x0401A016 RID: 106518
		[Token(Token = "0x401A016")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICharacterProfessionFilterProfItem _allItem;

		// Token: 0x0401A017 RID: 106519
		[Token(Token = "0x401A017")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401A018 RID: 106520
		[Token(Token = "0x401A018")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _cursorRect;

		// Token: 0x0401A019 RID: 106521
		[Token(Token = "0x401A019")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _cursorContainer;

		// Token: 0x0401A01A RID: 106522
		[Token(Token = "0x401A01A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _cursorBackCg;

		// Token: 0x0401A01B RID: 106523
		[Token(Token = "0x401A01B")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public ILoadAsset assetLoader;

		// Token: 0x0401A01C RID: 106524
		[Token(Token = "0x401A01C")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<ProfessionCategory, bool> onProfessionClick;

		// Token: 0x0401A01D RID: 106525
		[Token(Token = "0x401A01D")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401A01E RID: 106526
		[Token(Token = "0x401A01E")]
		[FieldOffset(Offset = "0x58")]
		private UICharacterProfessionFilterProfView.Adapter m_adapter;

		// Token: 0x0401A01F RID: 106527
		[Token(Token = "0x401A01F")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_moveTween;

		// Token: 0x0401A020 RID: 106528
		[Token(Token = "0x401A020")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_cursorSwitch;

		// Token: 0x0401A021 RID: 106529
		[Token(Token = "0x401A021")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform m_cachedCursorTarget;

		// Token: 0x0401A022 RID: 106530
		[Token(Token = "0x401A022")]
		[FieldOffset(Offset = "0x78")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x0401A023 RID: 106531
		[Token(Token = "0x401A023")]
		[FieldOffset(Offset = "0x80")]
		private UICharacterProfessionFilterViewModel m_cachedModel;

		// Token: 0x0401A024 RID: 106532
		[Token(Token = "0x401A024")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A025 RID: 106533
		[Token(Token = "0x401A025")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A026 RID: 106534
		[Token(Token = "0x401A026")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCursor;

		// Token: 0x0401A027 RID: 106535
		[Token(Token = "0x401A027")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__MoveCursor;

		// Token: 0x0401A028 RID: 106536
		[Token(Token = "0x401A028")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPostLayout;

		// Token: 0x0401A029 RID: 106537
		[Token(Token = "0x401A029")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003519 RID: 13593
		[Token(Token = "0x2003519")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06015AC3 RID: 88771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015AC3")]
			[Address(RVA = "0xE2BD70", Offset = "0xE2A970", VA = "0x180E2BD70")]
			public Adapter(UICharacterProfessionFilterProfView closure)
			{
			}

			// Token: 0x1700337E RID: 13182
			// (get) Token: 0x06015AC4 RID: 88772 RVA: 0x0008D648 File Offset: 0x0008B848
			[Token(Token = "0x1700337E")]
			public override int count
			{
				[Token(Token = "0x6015AC4")]
				[Address(RVA = "0xE2BEB0", Offset = "0xE2AAB0", VA = "0x180E2BEB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06015AC5 RID: 88773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015AC5")]
			[Address(RVA = "0xE2B830", Offset = "0xE2A430", VA = "0x180E2B830", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401A02A RID: 106538
			[Token(Token = "0x401A02A")]
			[FieldOffset(Offset = "0x20")]
			private UICharacterProfessionFilterProfView m_closure;

			// Token: 0x0401A02B RID: 106539
			[Token(Token = "0x401A02B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401A02C RID: 106540
			[Token(Token = "0x401A02C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401A02D RID: 106541
			[Token(Token = "0x401A02D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
