using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200654B RID: 25931
	[Token(Token = "0x200654B")]
	public class ArtMagazineDiyLeafCharIllustHolder : ArtMagazineLeafCharIllustHolderBase
	{
		// Token: 0x0602547C RID: 152700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602547C")]
		[Address(RVA = "0x204AD10", Offset = "0x2049910", VA = "0x18204AD10", Slot = "4")]
		protected override void LoadCharSkin(CharUISkinStruct charSkin)
		{
		}

		// Token: 0x0602547D RID: 152701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602547D")]
		[Address(RVA = "0x204B080", Offset = "0x2049C80", VA = "0x18204B080", Slot = "5")]
		public override void Render(ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x0602547E RID: 152702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602547E")]
		[Address(RVA = "0x204B3B0", Offset = "0x2049FB0", VA = "0x18204B3B0")]
		public ArtMagazineDiyLeafCharIllustHolder()
		{
		}

		// Token: 0x0602547F RID: 152703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602547F")]
		[Address(RVA = "0x204B370", Offset = "0x2049F70", VA = "0x18204B370")]
		private void <>xLuaBaseProxy_LoadCharSkin(CharUISkinStruct P0)
		{
		}

		// Token: 0x06025480 RID: 152704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025480")]
		[Address(RVA = "0x204B3A0", Offset = "0x2049FA0", VA = "0x18204B3A0")]
		private void <>xLuaBaseProxy_Render(ArtMagazineLeafViewModelBase P0)
		{
		}

		// Token: 0x040344E5 RID: 214245
		[Token(Token = "0x40344E5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040344E6 RID: 214246
		[Token(Token = "0x40344E6")]
		[FieldOffset(Offset = "0x60")]
		private ArtMagazineDiyLeafCharIllustHolder.LeafCharSkinWrapper m_charSkinWrapper;

		// Token: 0x040344E7 RID: 214247
		[Token(Token = "0x40344E7")]
		[FieldOffset(Offset = "0x68")]
		private float m_scaleMin;

		// Token: 0x040344E8 RID: 214248
		[Token(Token = "0x40344E8")]
		[FieldOffset(Offset = "0x6C")]
		private float m_scaleMax;

		// Token: 0x040344E9 RID: 214249
		[Token(Token = "0x40344E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCharSkin;

		// Token: 0x040344EA RID: 214250
		[Token(Token = "0x40344EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040344EB RID: 214251
		[Token(Token = "0x40344EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200654C RID: 25932
		[Token(Token = "0x200654C")]
		public class LeafCharSkinWrapper : DragAndPinchWithTargetContext.IDragAndPinchTarget, IHotfixable
		{
			// Token: 0x06025481 RID: 152705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025481")]
			[Address(RVA = "0x2054DC0", Offset = "0x20539C0", VA = "0x182054DC0")]
			public LeafCharSkinWrapper(ArtMagazineDiyLeafCharIllustHolder closure)
			{
			}

			// Token: 0x06025482 RID: 152706 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025482")]
			[Address(RVA = "0x2054CD0", Offset = "0x20538D0", VA = "0x182054CD0")]
			private RectTransform _GetValidRectTransform()
			{
				return null;
			}

			// Token: 0x17005809 RID: 22537
			// (get) Token: 0x06025483 RID: 152707 RVA: 0x000C7500 File Offset: 0x000C5700
			// (set) Token: 0x06025484 RID: 152708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005809")]
			public Vector2 anchoredPosition
			{
				[Token(Token = "0x6025483")]
				[Address(RVA = "0x2054E40", Offset = "0x2053A40", VA = "0x182054E40", Slot = "5")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6025484")]
				[Address(RVA = "0x2055540", Offset = "0x2054140", VA = "0x182055540", Slot = "6")]
				set
				{
				}
			}

			// Token: 0x1700580A RID: 22538
			// (get) Token: 0x06025485 RID: 152709 RVA: 0x000C7518 File Offset: 0x000C5718
			// (set) Token: 0x06025486 RID: 152710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700580A")]
			public float scale
			{
				[Token(Token = "0x6025485")]
				[Address(RVA = "0x20551C0", Offset = "0x2053DC0", VA = "0x1820551C0", Slot = "7")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6025486")]
				[Address(RVA = "0x2055800", Offset = "0x2054400", VA = "0x182055800", Slot = "8")]
				set
				{
				}
			}

			// Token: 0x1700580B RID: 22539
			// (get) Token: 0x06025487 RID: 152711 RVA: 0x000C7530 File Offset: 0x000C5730
			// (set) Token: 0x06025488 RID: 152712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700580B")]
			public Vector2 standardSizeDelta
			{
				[Token(Token = "0x6025487")]
				[Address(RVA = "0x20554D0", Offset = "0x20540D0", VA = "0x1820554D0", Slot = "4")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6025488")]
				[Address(RVA = "0x20559C0", Offset = "0x20545C0", VA = "0x1820559C0")]
				set
				{
				}
			}

			// Token: 0x1700580C RID: 22540
			// (get) Token: 0x06025489 RID: 152713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700580C")]
			public string key
			{
				[Token(Token = "0x6025489")]
				[Address(RVA = "0x2054F60", Offset = "0x2053B60", VA = "0x182054F60", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700580D RID: 22541
			// (get) Token: 0x0602548A RID: 152714 RVA: 0x000C7548 File Offset: 0x000C5748
			[Token(Token = "0x1700580D")]
			public Vector2 posForEditDisplay
			{
				[Token(Token = "0x602548A")]
				[Address(RVA = "0x2054FD0", Offset = "0x2053BD0", VA = "0x182054FD0")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x1700580E RID: 22542
			// (get) Token: 0x0602548B RID: 152715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700580E")]
			public UICharacterIllust charIllustForEditDisplay
			{
				[Token(Token = "0x602548B")]
				[Address(RVA = "0x2054EF0", Offset = "0x2053AF0", VA = "0x182054EF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700580F RID: 22543
			// (get) Token: 0x0602548C RID: 152716 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700580F")]
			public ArtMagazineDiyLeafViewModel.SkinLayoutData skinLayoutData
			{
				[Token(Token = "0x602548C")]
				[Address(RVA = "0x20552A0", Offset = "0x2053EA0", VA = "0x1820552A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005810 RID: 22544
			// (set) Token: 0x0602548D RID: 152717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005810")]
			public float normalizedSize
			{
				[Token(Token = "0x602548D")]
				[Address(RVA = "0x2055660", Offset = "0x2054260", VA = "0x182055660")]
				set
				{
				}
			}

			// Token: 0x040344EC RID: 214252
			[Token(Token = "0x40344EC")]
			[FieldOffset(Offset = "0x10")]
			private ArtMagazineDiyLeafCharIllustHolder m_closure;

			// Token: 0x040344ED RID: 214253
			[Token(Token = "0x40344ED")]
			[FieldOffset(Offset = "0x18")]
			private Vector2 m_standardSizeDelta;

			// Token: 0x040344EE RID: 214254
			[Token(Token = "0x40344EE")]
			[FieldOffset(Offset = "0x20")]
			public ArtMagazineLeafCharViewModel charViewModel;

			// Token: 0x040344EF RID: 214255
			[Token(Token = "0x40344EF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040344F0 RID: 214256
			[Token(Token = "0x40344F0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__GetValidRectTransform;

			// Token: 0x040344F1 RID: 214257
			[Token(Token = "0x40344F1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_anchoredPosition;

			// Token: 0x040344F2 RID: 214258
			[Token(Token = "0x40344F2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_anchoredPosition;

			// Token: 0x040344F3 RID: 214259
			[Token(Token = "0x40344F3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_scale;

			// Token: 0x040344F4 RID: 214260
			[Token(Token = "0x40344F4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_scale;

			// Token: 0x040344F5 RID: 214261
			[Token(Token = "0x40344F5")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_standardSizeDelta;

			// Token: 0x040344F6 RID: 214262
			[Token(Token = "0x40344F6")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_standardSizeDelta;

			// Token: 0x040344F7 RID: 214263
			[Token(Token = "0x40344F7")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_key;

			// Token: 0x040344F8 RID: 214264
			[Token(Token = "0x40344F8")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_posForEditDisplay;

			// Token: 0x040344F9 RID: 214265
			[Token(Token = "0x40344F9")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_charIllustForEditDisplay;

			// Token: 0x040344FA RID: 214266
			[Token(Token = "0x40344FA")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_skinLayoutData;

			// Token: 0x040344FB RID: 214267
			[Token(Token = "0x40344FB")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_set_normalizedSize;
		}
	}
}
