using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DC3 RID: 19907
	[Token(Token = "0x2004DC3")]
	public class NameCardV2ShareAssistStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DC35 RID: 121909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DC35")]
		[Address(RVA = "0x175DEF0", Offset = "0x175CAF0", VA = "0x18175DEF0", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DC36 RID: 121910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC36")]
		[Address(RVA = "0x175E0B0", Offset = "0x175CCB0", VA = "0x18175E0B0")]
		public NameCardV2ShareAssistStartLayoutElement()
		{
		}

		// Token: 0x04027623 RID: 161315
		[Token(Token = "0x4027623")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bgRect;

		// Token: 0x04027624 RID: 161316
		[Token(Token = "0x4027624")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _assistIcon;

		// Token: 0x04027625 RID: 161317
		[Token(Token = "0x4027625")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _constTextAssistCN;

		// Token: 0x04027626 RID: 161318
		[Token(Token = "0x4027626")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _constTextAssistEN;

		// Token: 0x04027627 RID: 161319
		[Token(Token = "0x4027627")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CrossAppShareStartLayoutContent _assistCharContent;

		// Token: 0x04027628 RID: 161320
		[Token(Token = "0x4027628")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private NameCardV2AssistModuleView _view;

		// Token: 0x04027629 RID: 161321
		[Token(Token = "0x4027629")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x0402762A RID: 161322
		[Token(Token = "0x402762A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DC4 RID: 19908
		[Token(Token = "0x2004DC4")]
		public class NameCardV2ShareAssistModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DC37 RID: 121911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC37")]
			[Address(RVA = "0x175D670", Offset = "0x175C270", VA = "0x18175D670")]
			public void InitCollector(NameCardV2ShareAssistStartLayoutElement closure)
			{
			}

			// Token: 0x170045C2 RID: 17858
			// (get) Token: 0x0601DC38 RID: 121912 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC39 RID: 121913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C2")]
			public CrossAppShareImageModel bgRectModel
			{
				[Token(Token = "0x601DC38")]
				[Address(RVA = "0x175D810", Offset = "0x175C410", VA = "0x18175D810")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC39")]
				[Address(RVA = "0x175DA30", Offset = "0x175C630", VA = "0x18175DA30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045C3 RID: 17859
			// (get) Token: 0x0601DC3A RID: 121914 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC3B RID: 121915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C3")]
			public CrossAppShareImageModel assistIconModel
			{
				[Token(Token = "0x601DC3A")]
				[Address(RVA = "0x175D7B0", Offset = "0x175C3B0", VA = "0x18175D7B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC3B")]
				[Address(RVA = "0x175D9B0", Offset = "0x175C5B0", VA = "0x18175D9B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045C4 RID: 17860
			// (get) Token: 0x0601DC3C RID: 121916 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC3D RID: 121917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C4")]
			public CrossAppShareTextModel constTextAssistCNModel
			{
				[Token(Token = "0x601DC3C")]
				[Address(RVA = "0x175D870", Offset = "0x175C470", VA = "0x18175D870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC3D")]
				[Address(RVA = "0x175DAB0", Offset = "0x175C6B0", VA = "0x18175DAB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045C5 RID: 17861
			// (get) Token: 0x0601DC3E RID: 121918 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC3F RID: 121919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C5")]
			public CrossAppShareTextModel constTextAssistENModel
			{
				[Token(Token = "0x601DC3E")]
				[Address(RVA = "0x175D8D0", Offset = "0x175C4D0", VA = "0x18175D8D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC3F")]
				[Address(RVA = "0x175DB30", Offset = "0x175C730", VA = "0x18175DB30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045C6 RID: 17862
			// (get) Token: 0x0601DC40 RID: 121920 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC41 RID: 121921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045C6")]
			public CrossAppShareLayoutContentModel assistCharModel
			{
				[Token(Token = "0x601DC40")]
				[Address(RVA = "0x175D750", Offset = "0x175C350", VA = "0x18175D750")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC41")]
				[Address(RVA = "0x175D930", Offset = "0x175C530", VA = "0x18175D930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DC42 RID: 121922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC42")]
			[Address(RVA = "0x175D180", Offset = "0x175BD80", VA = "0x18175D180", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DC43 RID: 121923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC43")]
			[Address(RVA = "0x175D6F0", Offset = "0x175C2F0", VA = "0x18175D6F0")]
			public NameCardV2ShareAssistModelCollector()
			{
			}

			// Token: 0x0402762B RID: 161323
			[Token(Token = "0x402762B")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareAssistStartLayoutElement m_closure;

			// Token: 0x0402762C RID: 161324
			[Token(Token = "0x402762C")]
			[FieldOffset(Offset = "0x30")]
			public bool isShow;

			// Token: 0x04027632 RID: 161330
			[Token(Token = "0x4027632")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x04027633 RID: 161331
			[Token(Token = "0x4027633")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_bgRectModel;

			// Token: 0x04027634 RID: 161332
			[Token(Token = "0x4027634")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_bgRectModel;

			// Token: 0x04027635 RID: 161333
			[Token(Token = "0x4027635")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_assistIconModel;

			// Token: 0x04027636 RID: 161334
			[Token(Token = "0x4027636")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_assistIconModel;

			// Token: 0x04027637 RID: 161335
			[Token(Token = "0x4027637")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_constTextAssistCNModel;

			// Token: 0x04027638 RID: 161336
			[Token(Token = "0x4027638")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_constTextAssistCNModel;

			// Token: 0x04027639 RID: 161337
			[Token(Token = "0x4027639")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_constTextAssistENModel;

			// Token: 0x0402763A RID: 161338
			[Token(Token = "0x402763A")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_set_constTextAssistENModel;

			// Token: 0x0402763B RID: 161339
			[Token(Token = "0x402763B")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_assistCharModel;

			// Token: 0x0402763C RID: 161340
			[Token(Token = "0x402763C")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_set_assistCharModel;

			// Token: 0x0402763D RID: 161341
			[Token(Token = "0x402763D")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x0402763E RID: 161342
			[Token(Token = "0x402763E")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
