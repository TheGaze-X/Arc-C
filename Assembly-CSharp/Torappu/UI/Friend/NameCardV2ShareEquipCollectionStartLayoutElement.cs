using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DD2 RID: 19922
	[Token(Token = "0x2004DD2")]
	public class NameCardV2ShareEquipCollectionStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DCA4 RID: 122020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DCA4")]
		[Address(RVA = "0x1763E80", Offset = "0x1762A80", VA = "0x181763E80", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DCA5 RID: 122021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCA5")]
		[Address(RVA = "0x1763FD0", Offset = "0x1762BD0", VA = "0x181763FD0")]
		public NameCardV2ShareEquipCollectionStartLayoutElement()
		{
		}

		// Token: 0x04027709 RID: 161545
		[Token(Token = "0x4027709")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bgRect;

		// Token: 0x0402770A RID: 161546
		[Token(Token = "0x402770A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bgIcon;

		// Token: 0x0402770B RID: 161547
		[Token(Token = "0x402770B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CrossAppShareStartLayoutContent _infoContent;

		// Token: 0x0402770C RID: 161548
		[Token(Token = "0x402770C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private NameCardV2EquipmentCollectionModuleView _view;

		// Token: 0x0402770D RID: 161549
		[Token(Token = "0x402770D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x0402770E RID: 161550
		[Token(Token = "0x402770E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DD3 RID: 19923
		[Token(Token = "0x2004DD3")]
		public class NameCardV2ShareEquipCollectionModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DCA6 RID: 122022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCA6")]
			[Address(RVA = "0x17638A0", Offset = "0x17624A0", VA = "0x1817638A0")]
			public void InitCollector(NameCardV2ShareEquipCollectionStartLayoutElement closure)
			{
			}

			// Token: 0x170045E8 RID: 17896
			// (get) Token: 0x0601DCA7 RID: 122023 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCA8 RID: 122024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E8")]
			public CrossAppShareImageModel bgRectModel
			{
				[Token(Token = "0x601DCA7")]
				[Address(RVA = "0x17639E0", Offset = "0x17625E0", VA = "0x1817639E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCA8")]
				[Address(RVA = "0x1763B20", Offset = "0x1762720", VA = "0x181763B20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045E9 RID: 17897
			// (get) Token: 0x0601DCA9 RID: 122025 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCAA RID: 122026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045E9")]
			public CrossAppShareImageModel bgIconModel
			{
				[Token(Token = "0x601DCA9")]
				[Address(RVA = "0x1763980", Offset = "0x1762580", VA = "0x181763980")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCAA")]
				[Address(RVA = "0x1763AA0", Offset = "0x17626A0", VA = "0x181763AA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045EA RID: 17898
			// (get) Token: 0x0601DCAB RID: 122027 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCAC RID: 122028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045EA")]
			public CrossAppShareLayoutContentModel infoItemModel
			{
				[Token(Token = "0x601DCAB")]
				[Address(RVA = "0x1763A40", Offset = "0x1762640", VA = "0x181763A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCAC")]
				[Address(RVA = "0x1763BA0", Offset = "0x17627A0", VA = "0x181763BA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DCAD RID: 122029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCAD")]
			[Address(RVA = "0x1763580", Offset = "0x1762180", VA = "0x181763580", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DCAE RID: 122030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCAE")]
			[Address(RVA = "0x1763920", Offset = "0x1762520", VA = "0x181763920")]
			public NameCardV2ShareEquipCollectionModelCollector()
			{
			}

			// Token: 0x0402770F RID: 161551
			[Token(Token = "0x402770F")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareEquipCollectionStartLayoutElement m_closure;

			// Token: 0x04027713 RID: 161555
			[Token(Token = "0x4027713")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x04027714 RID: 161556
			[Token(Token = "0x4027714")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_bgRectModel;

			// Token: 0x04027715 RID: 161557
			[Token(Token = "0x4027715")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_bgRectModel;

			// Token: 0x04027716 RID: 161558
			[Token(Token = "0x4027716")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_bgIconModel;

			// Token: 0x04027717 RID: 161559
			[Token(Token = "0x4027717")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_bgIconModel;

			// Token: 0x04027718 RID: 161560
			[Token(Token = "0x4027718")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_infoItemModel;

			// Token: 0x04027719 RID: 161561
			[Token(Token = "0x4027719")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_infoItemModel;

			// Token: 0x0402771A RID: 161562
			[Token(Token = "0x402771A")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x0402771B RID: 161563
			[Token(Token = "0x402771B")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
