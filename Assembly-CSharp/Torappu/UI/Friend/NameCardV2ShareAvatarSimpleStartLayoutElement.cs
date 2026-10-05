using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DC7 RID: 19911
	[Token(Token = "0x2004DC7")]
	public class NameCardV2ShareAvatarSimpleStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DC48 RID: 121928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DC48")]
		[Address(RVA = "0x175FE00", Offset = "0x175EA00", VA = "0x18175FE00", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DC49 RID: 121929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC49")]
		[Address(RVA = "0x175FF50", Offset = "0x175EB50", VA = "0x18175FF50")]
		public NameCardV2ShareAvatarSimpleStartLayoutElement()
		{
		}

		// Token: 0x0402764E RID: 161358
		[Token(Token = "0x402764E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _doctorLevel;

		// Token: 0x0402764F RID: 161359
		[Token(Token = "0x402764F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _doctorName;

		// Token: 0x04027650 RID: 161360
		[Token(Token = "0x4027650")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _doctorUid;

		// Token: 0x04027651 RID: 161361
		[Token(Token = "0x4027651")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CrossAppShareStartDynAssetContent _crossAppShareAvatarContent;

		// Token: 0x04027652 RID: 161362
		[Token(Token = "0x4027652")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x04027653 RID: 161363
		[Token(Token = "0x4027653")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DC8 RID: 19912
		[Token(Token = "0x2004DC8")]
		public class NameCardV2ShareAvatarSimpleModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DC4A RID: 121930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC4A")]
			[Address(RVA = "0x175F5B0", Offset = "0x175E1B0", VA = "0x18175F5B0")]
			public void InitCollector(NameCardV2ShareAvatarSimpleStartLayoutElement closure)
			{
			}

			// Token: 0x170045C7 RID: 17863
			// (get) Token: 0x0601DC4B RID: 121931 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC4C RID: 121932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C7")]
			public CrossAppShareTextModel doctorLevelModel
			{
				[Token(Token = "0x601DC4B")]
				[Address(RVA = "0x175F6F0", Offset = "0x175E2F0", VA = "0x18175F6F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC4C")]
				[Address(RVA = "0x175F8F0", Offset = "0x175E4F0", VA = "0x18175F8F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045C8 RID: 17864
			// (get) Token: 0x0601DC4D RID: 121933 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC4E RID: 121934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C8")]
			public CrossAppShareTextModel doctorNameModel
			{
				[Token(Token = "0x601DC4D")]
				[Address(RVA = "0x175F750", Offset = "0x175E350", VA = "0x18175F750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC4E")]
				[Address(RVA = "0x175F970", Offset = "0x175E570", VA = "0x18175F970")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045C9 RID: 17865
			// (get) Token: 0x0601DC4F RID: 121935 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC50 RID: 121936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C9")]
			public CrossAppShareTextModel doctorUidModel
			{
				[Token(Token = "0x601DC4F")]
				[Address(RVA = "0x175F7B0", Offset = "0x175E3B0", VA = "0x18175F7B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC50")]
				[Address(RVA = "0x175F9F0", Offset = "0x175E5F0", VA = "0x18175F9F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045CA RID: 17866
			// (get) Token: 0x0601DC51 RID: 121937 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC52 RID: 121938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045CA")]
			public CrossAppShareDynAssetBaseModel avatarModel
			{
				[Token(Token = "0x601DC51")]
				[Address(RVA = "0x175F690", Offset = "0x175E290", VA = "0x18175F690")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC52")]
				[Address(RVA = "0x175F870", Offset = "0x175E470", VA = "0x18175F870")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045CB RID: 17867
			// (get) Token: 0x0601DC53 RID: 121939 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC54 RID: 121940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045CB")]
			public CrossAppShareObjectActiveModel uidObjectModel
			{
				[Token(Token = "0x601DC53")]
				[Address(RVA = "0x175F810", Offset = "0x175E410", VA = "0x18175F810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC54")]
				[Address(RVA = "0x175FA70", Offset = "0x175E670", VA = "0x18175FA70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DC55 RID: 121941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC55")]
			[Address(RVA = "0x175F0A0", Offset = "0x175DCA0", VA = "0x18175F0A0", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DC56 RID: 121942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC56")]
			[Address(RVA = "0x175F630", Offset = "0x175E230", VA = "0x18175F630")]
			public NameCardV2ShareAvatarSimpleModelCollector()
			{
			}

			// Token: 0x04027654 RID: 161364
			[Token(Token = "0x4027654")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareAvatarSimpleStartLayoutElement m_closure;

			// Token: 0x0402765A RID: 161370
			[Token(Token = "0x402765A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x0402765B RID: 161371
			[Token(Token = "0x402765B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_doctorLevelModel;

			// Token: 0x0402765C RID: 161372
			[Token(Token = "0x402765C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_doctorLevelModel;

			// Token: 0x0402765D RID: 161373
			[Token(Token = "0x402765D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_doctorNameModel;

			// Token: 0x0402765E RID: 161374
			[Token(Token = "0x402765E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_doctorNameModel;

			// Token: 0x0402765F RID: 161375
			[Token(Token = "0x402765F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_doctorUidModel;

			// Token: 0x04027660 RID: 161376
			[Token(Token = "0x4027660")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_doctorUidModel;

			// Token: 0x04027661 RID: 161377
			[Token(Token = "0x4027661")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_avatarModel;

			// Token: 0x04027662 RID: 161378
			[Token(Token = "0x4027662")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_set_avatarModel;

			// Token: 0x04027663 RID: 161379
			[Token(Token = "0x4027663")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_uidObjectModel;

			// Token: 0x04027664 RID: 161380
			[Token(Token = "0x4027664")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_set_uidObjectModel;

			// Token: 0x04027665 RID: 161381
			[Token(Token = "0x4027665")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x04027666 RID: 161382
			[Token(Token = "0x4027666")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
