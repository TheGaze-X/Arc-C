using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DC0 RID: 19904
	[Token(Token = "0x2004DC0")]
	public class NameCardV2ShareAssistCharStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DC18 RID: 121880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DC18")]
		[Address(RVA = "0x175CF60", Offset = "0x175BB60", VA = "0x18175CF60", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DC19 RID: 121881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC19")]
		[Address(RVA = "0x175D120", Offset = "0x175BD20", VA = "0x18175D120")]
		public NameCardV2ShareAssistCharStartLayoutElement()
		{
		}

		// Token: 0x040275E7 RID: 161255
		[Token(Token = "0x40275E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _charEmpty;

		// Token: 0x040275E8 RID: 161256
		[Token(Token = "0x40275E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _charObject;

		// Token: 0x040275E9 RID: 161257
		[Token(Token = "0x40275E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _charEliteIcon;

		// Token: 0x040275EA RID: 161258
		[Token(Token = "0x40275EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _charSpecMaxPart;

		// Token: 0x040275EB RID: 161259
		[Token(Token = "0x40275EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x040275EC RID: 161260
		[Token(Token = "0x40275EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _charLevel;

		// Token: 0x040275ED RID: 161261
		[Token(Token = "0x40275ED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _charPotentialIcon;

		// Token: 0x040275EE RID: 161262
		[Token(Token = "0x40275EE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _charSkillIcon;

		// Token: 0x040275EF RID: 161263
		[Token(Token = "0x40275EF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _charEquipIcon;

		// Token: 0x040275F0 RID: 161264
		[Token(Token = "0x40275F0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _charHaveEquipObject;

		// Token: 0x040275F1 RID: 161265
		[Token(Token = "0x40275F1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _charNoEquipObject;

		// Token: 0x040275F2 RID: 161266
		[Token(Token = "0x40275F2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private NameCardV2AssistCharItem _view;

		// Token: 0x040275F3 RID: 161267
		[Token(Token = "0x40275F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x040275F4 RID: 161268
		[Token(Token = "0x40275F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DC1 RID: 19905
		[Token(Token = "0x2004DC1")]
		public class NameCardV2ShareAssistCharModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DC1A RID: 121882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC1A")]
			[Address(RVA = "0x175C030", Offset = "0x175AC30", VA = "0x18175C030")]
			public void InitCollector(NameCardV2ShareAssistCharStartLayoutElement closure)
			{
			}

			// Token: 0x170045B7 RID: 17847
			// (get) Token: 0x0601DC1B RID: 121883 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC1C RID: 121884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045B7")]
			public CrossAppShareObjectActiveModel charEmptyModel
			{
				[Token(Token = "0x601DC1B")]
				[Address(RVA = "0x175C170", Offset = "0x175AD70", VA = "0x18175C170")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC1C")]
				[Address(RVA = "0x175C5B0", Offset = "0x175B1B0", VA = "0x18175C5B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045B8 RID: 17848
			// (get) Token: 0x0601DC1D RID: 121885 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC1E RID: 121886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045B8")]
			public CrossAppShareObjectActiveModel charObjectModel
			{
				[Token(Token = "0x601DC1D")]
				[Address(RVA = "0x175C350", Offset = "0x175AF50", VA = "0x18175C350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC1E")]
				[Address(RVA = "0x175C830", Offset = "0x175B430", VA = "0x18175C830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045B9 RID: 17849
			// (get) Token: 0x0601DC1F RID: 121887 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC20 RID: 121888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045B9")]
			public CrossAppShareImageModel charEliteIconModel
			{
				[Token(Token = "0x601DC1F")]
				[Address(RVA = "0x175C110", Offset = "0x175AD10", VA = "0x18175C110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC20")]
				[Address(RVA = "0x175C530", Offset = "0x175B130", VA = "0x18175C530")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045BA RID: 17850
			// (get) Token: 0x0601DC21 RID: 121889 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC22 RID: 121890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045BA")]
			public CrossAppShareObjectActiveModel charSpecMaxPartModel
			{
				[Token(Token = "0x601DC21")]
				[Address(RVA = "0x175C4D0", Offset = "0x175B0D0", VA = "0x18175C4D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC22")]
				[Address(RVA = "0x175CA30", Offset = "0x175B630", VA = "0x18175CA30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045BB RID: 17851
			// (get) Token: 0x0601DC23 RID: 121891 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC24 RID: 121892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045BB")]
			public CrossAppShareUIAtlasImageModel charPortraitModel
			{
				[Token(Token = "0x601DC23")]
				[Address(RVA = "0x175C3B0", Offset = "0x175AFB0", VA = "0x18175C3B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC24")]
				[Address(RVA = "0x175C8B0", Offset = "0x175B4B0", VA = "0x18175C8B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045BC RID: 17852
			// (get) Token: 0x0601DC25 RID: 121893 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC26 RID: 121894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045BC")]
			public CrossAppShareTextModel charLevelModel
			{
				[Token(Token = "0x601DC25")]
				[Address(RVA = "0x175C290", Offset = "0x175AE90", VA = "0x18175C290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC26")]
				[Address(RVA = "0x175C730", Offset = "0x175B330", VA = "0x18175C730")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045BD RID: 17853
			// (get) Token: 0x0601DC27 RID: 121895 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC28 RID: 121896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045BD")]
			public CrossAppShareImageModel charPotentialIconModel
			{
				[Token(Token = "0x601DC27")]
				[Address(RVA = "0x175C410", Offset = "0x175B010", VA = "0x18175C410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC28")]
				[Address(RVA = "0x175C930", Offset = "0x175B530", VA = "0x18175C930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045BE RID: 17854
			// (get) Token: 0x0601DC29 RID: 121897 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC2A RID: 121898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045BE")]
			public CrossAppShareImageModel charSkillIconModel
			{
				[Token(Token = "0x601DC29")]
				[Address(RVA = "0x175C470", Offset = "0x175B070", VA = "0x18175C470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC2A")]
				[Address(RVA = "0x175C9B0", Offset = "0x175B5B0", VA = "0x18175C9B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045BF RID: 17855
			// (get) Token: 0x0601DC2B RID: 121899 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC2C RID: 121900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045BF")]
			public CrossAppShareImageModel charEquipIconModel
			{
				[Token(Token = "0x601DC2B")]
				[Address(RVA = "0x175C1D0", Offset = "0x175ADD0", VA = "0x18175C1D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC2C")]
				[Address(RVA = "0x175C630", Offset = "0x175B230", VA = "0x18175C630")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045C0 RID: 17856
			// (get) Token: 0x0601DC2D RID: 121901 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC2E RID: 121902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C0")]
			public CrossAppShareObjectActiveModel charHaveEquipObjectModel
			{
				[Token(Token = "0x601DC2D")]
				[Address(RVA = "0x175C230", Offset = "0x175AE30", VA = "0x18175C230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC2E")]
				[Address(RVA = "0x175C6B0", Offset = "0x175B2B0", VA = "0x18175C6B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045C1 RID: 17857
			// (get) Token: 0x0601DC2F RID: 121903 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC30 RID: 121904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C1")]
			public CrossAppShareObjectActiveModel charNoEquipObjectModel
			{
				[Token(Token = "0x601DC2F")]
				[Address(RVA = "0x175C2F0", Offset = "0x175AEF0", VA = "0x18175C2F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC30")]
				[Address(RVA = "0x175C7B0", Offset = "0x175B3B0", VA = "0x18175C7B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DC31 RID: 121905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC31")]
			[Address(RVA = "0x175B5D0", Offset = "0x175A1D0", VA = "0x18175B5D0", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DC32 RID: 121906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC32")]
			[Address(RVA = "0x175C0B0", Offset = "0x175ACB0", VA = "0x18175C0B0")]
			public NameCardV2ShareAssistCharModelCollector()
			{
			}

			// Token: 0x040275F5 RID: 161269
			[Token(Token = "0x40275F5")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareAssistCharStartLayoutElement m_closure;

			// Token: 0x040275F6 RID: 161270
			[Token(Token = "0x40275F6")]
			[FieldOffset(Offset = "0x30")]
			public bool isShow;

			// Token: 0x04027602 RID: 161282
			[Token(Token = "0x4027602")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x04027603 RID: 161283
			[Token(Token = "0x4027603")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_charEmptyModel;

			// Token: 0x04027604 RID: 161284
			[Token(Token = "0x4027604")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_charEmptyModel;

			// Token: 0x04027605 RID: 161285
			[Token(Token = "0x4027605")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_charObjectModel;

			// Token: 0x04027606 RID: 161286
			[Token(Token = "0x4027606")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_charObjectModel;

			// Token: 0x04027607 RID: 161287
			[Token(Token = "0x4027607")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_charEliteIconModel;

			// Token: 0x04027608 RID: 161288
			[Token(Token = "0x4027608")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_charEliteIconModel;

			// Token: 0x04027609 RID: 161289
			[Token(Token = "0x4027609")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_charSpecMaxPartModel;

			// Token: 0x0402760A RID: 161290
			[Token(Token = "0x402760A")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_set_charSpecMaxPartModel;

			// Token: 0x0402760B RID: 161291
			[Token(Token = "0x402760B")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_charPortraitModel;

			// Token: 0x0402760C RID: 161292
			[Token(Token = "0x402760C")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_set_charPortraitModel;

			// Token: 0x0402760D RID: 161293
			[Token(Token = "0x402760D")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_charLevelModel;

			// Token: 0x0402760E RID: 161294
			[Token(Token = "0x402760E")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_set_charLevelModel;

			// Token: 0x0402760F RID: 161295
			[Token(Token = "0x402760F")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_charPotentialIconModel;

			// Token: 0x04027610 RID: 161296
			[Token(Token = "0x4027610")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_set_charPotentialIconModel;

			// Token: 0x04027611 RID: 161297
			[Token(Token = "0x4027611")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_charSkillIconModel;

			// Token: 0x04027612 RID: 161298
			[Token(Token = "0x4027612")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_set_charSkillIconModel;

			// Token: 0x04027613 RID: 161299
			[Token(Token = "0x4027613")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_charEquipIconModel;

			// Token: 0x04027614 RID: 161300
			[Token(Token = "0x4027614")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_set_charEquipIconModel;

			// Token: 0x04027615 RID: 161301
			[Token(Token = "0x4027615")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_charHaveEquipObjectModel;

			// Token: 0x04027616 RID: 161302
			[Token(Token = "0x4027616")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_set_charHaveEquipObjectModel;

			// Token: 0x04027617 RID: 161303
			[Token(Token = "0x4027617")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_get_charNoEquipObjectModel;

			// Token: 0x04027618 RID: 161304
			[Token(Token = "0x4027618")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_set_charNoEquipObjectModel;

			// Token: 0x04027619 RID: 161305
			[Token(Token = "0x4027619")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x0402761A RID: 161306
			[Token(Token = "0x402761A")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
