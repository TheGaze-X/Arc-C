using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DC9 RID: 19913
	[Token(Token = "0x2004DC9")]
	public class NameCardV2ShareAvatarStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DC57 RID: 121943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DC57")]
		[Address(RVA = "0x175FFB0", Offset = "0x175EBB0", VA = "0x18175FFB0", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DC58 RID: 121944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC58")]
		[Address(RVA = "0x1760100", Offset = "0x175ED00", VA = "0x181760100")]
		public NameCardV2ShareAvatarStartLayoutElement()
		{
		}

		// Token: 0x04027667 RID: 161383
		[Token(Token = "0x4027667")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _doctorLevel;

		// Token: 0x04027668 RID: 161384
		[Token(Token = "0x4027668")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _doctorName;

		// Token: 0x04027669 RID: 161385
		[Token(Token = "0x4027669")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _doctorUid;

		// Token: 0x0402766A RID: 161386
		[Token(Token = "0x402766A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x0402766B RID: 161387
		[Token(Token = "0x402766B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CrossAppShareStartDynAssetContent _crossAppShareAvatarContent;

		// Token: 0x0402766C RID: 161388
		[Token(Token = "0x402766C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x0402766D RID: 161389
		[Token(Token = "0x402766D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DCA RID: 19914
		[Token(Token = "0x2004DCA")]
		public class NameCardV2ShareAvatarModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DC59 RID: 121945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC59")]
			[Address(RVA = "0x175E710", Offset = "0x175D310", VA = "0x18175E710")]
			public void InitCollector(NameCardV2ShareAvatarStartLayoutElement closure)
			{
			}

			// Token: 0x170045CC RID: 17868
			// (get) Token: 0x0601DC5A RID: 121946 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC5B RID: 121947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045CC")]
			public CrossAppShareTextModel doctorLevelModel
			{
				[Token(Token = "0x601DC5A")]
				[Address(RVA = "0x175E8B0", Offset = "0x175D4B0", VA = "0x18175E8B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC5B")]
				[Address(RVA = "0x175EB30", Offset = "0x175D730", VA = "0x18175EB30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045CD RID: 17869
			// (get) Token: 0x0601DC5C RID: 121948 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC5D RID: 121949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045CD")]
			public CrossAppShareTextModel doctorNameModel
			{
				[Token(Token = "0x601DC5C")]
				[Address(RVA = "0x175E910", Offset = "0x175D510", VA = "0x18175E910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC5D")]
				[Address(RVA = "0x175EBB0", Offset = "0x175D7B0", VA = "0x18175EBB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045CE RID: 17870
			// (get) Token: 0x0601DC5E RID: 121950 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC5F RID: 121951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045CE")]
			public CrossAppShareTextModel doctorUidModel
			{
				[Token(Token = "0x601DC5E")]
				[Address(RVA = "0x175E970", Offset = "0x175D570", VA = "0x18175E970")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC5F")]
				[Address(RVA = "0x175EC30", Offset = "0x175D830", VA = "0x18175EC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045CF RID: 17871
			// (get) Token: 0x0601DC60 RID: 121952 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC61 RID: 121953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045CF")]
			public CrossAppShareImageModel bgImgModel
			{
				[Token(Token = "0x601DC60")]
				[Address(RVA = "0x175E850", Offset = "0x175D450", VA = "0x18175E850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC61")]
				[Address(RVA = "0x175EAB0", Offset = "0x175D6B0", VA = "0x18175EAB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045D0 RID: 17872
			// (get) Token: 0x0601DC62 RID: 121954 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC63 RID: 121955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D0")]
			public CrossAppShareDynAssetBaseModel avatarModel
			{
				[Token(Token = "0x601DC62")]
				[Address(RVA = "0x175E7F0", Offset = "0x175D3F0", VA = "0x18175E7F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC63")]
				[Address(RVA = "0x175EA30", Offset = "0x175D630", VA = "0x18175EA30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045D1 RID: 17873
			// (get) Token: 0x0601DC64 RID: 121956 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC65 RID: 121957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D1")]
			public CrossAppShareObjectActiveModel uidObjectModel
			{
				[Token(Token = "0x601DC64")]
				[Address(RVA = "0x175E9D0", Offset = "0x175D5D0", VA = "0x18175E9D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC65")]
				[Address(RVA = "0x175ECB0", Offset = "0x175D8B0", VA = "0x18175ECB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DC66 RID: 121958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC66")]
			[Address(RVA = "0x175E110", Offset = "0x175CD10", VA = "0x18175E110", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DC67 RID: 121959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC67")]
			[Address(RVA = "0x175E790", Offset = "0x175D390", VA = "0x18175E790")]
			public NameCardV2ShareAvatarModelCollector()
			{
			}

			// Token: 0x0402766E RID: 161390
			[Token(Token = "0x402766E")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareAvatarStartLayoutElement m_closure;

			// Token: 0x04027675 RID: 161397
			[Token(Token = "0x4027675")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x04027676 RID: 161398
			[Token(Token = "0x4027676")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_doctorLevelModel;

			// Token: 0x04027677 RID: 161399
			[Token(Token = "0x4027677")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_doctorLevelModel;

			// Token: 0x04027678 RID: 161400
			[Token(Token = "0x4027678")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_doctorNameModel;

			// Token: 0x04027679 RID: 161401
			[Token(Token = "0x4027679")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_doctorNameModel;

			// Token: 0x0402767A RID: 161402
			[Token(Token = "0x402767A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_doctorUidModel;

			// Token: 0x0402767B RID: 161403
			[Token(Token = "0x402767B")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_doctorUidModel;

			// Token: 0x0402767C RID: 161404
			[Token(Token = "0x402767C")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_bgImgModel;

			// Token: 0x0402767D RID: 161405
			[Token(Token = "0x402767D")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_set_bgImgModel;

			// Token: 0x0402767E RID: 161406
			[Token(Token = "0x402767E")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_avatarModel;

			// Token: 0x0402767F RID: 161407
			[Token(Token = "0x402767F")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_set_avatarModel;

			// Token: 0x04027680 RID: 161408
			[Token(Token = "0x4027680")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_uidObjectModel;

			// Token: 0x04027681 RID: 161409
			[Token(Token = "0x4027681")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_set_uidObjectModel;

			// Token: 0x04027682 RID: 161410
			[Token(Token = "0x4027682")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x04027683 RID: 161411
			[Token(Token = "0x4027683")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
