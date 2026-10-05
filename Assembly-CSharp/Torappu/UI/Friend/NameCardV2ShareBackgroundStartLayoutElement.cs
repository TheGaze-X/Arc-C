using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DCC RID: 19916
	[Token(Token = "0x2004DCC")]
	public class NameCardV2ShareBackgroundStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DC6A RID: 121962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DC6A")]
		[Address(RVA = "0x1760CC0", Offset = "0x175F8C0", VA = "0x181760CC0", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DC6B RID: 121963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC6B")]
		[Address(RVA = "0x1760E10", Offset = "0x175FA10", VA = "0x181760E10")]
		public NameCardV2ShareBackgroundStartLayoutElement()
		{
		}

		// Token: 0x0402768A RID: 161418
		[Token(Token = "0x402768A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0402768B RID: 161419
		[Token(Token = "0x402768B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bgPureColor;

		// Token: 0x0402768C RID: 161420
		[Token(Token = "0x402768C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _leftBorder;

		// Token: 0x0402768D RID: 161421
		[Token(Token = "0x402768D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _rightBorder;

		// Token: 0x0402768E RID: 161422
		[Token(Token = "0x402768E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x0402768F RID: 161423
		[Token(Token = "0x402768F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DCD RID: 19917
		[Token(Token = "0x2004DCD")]
		public class NameCardV2ShareBackgroundModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x170045D2 RID: 17874
			// (get) Token: 0x0601DC6C RID: 121964 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC6D RID: 121965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D2")]
			public CrossAppShareImageModel bgModel
			{
				[Token(Token = "0x601DC6C")]
				[Address(RVA = "0x17606A0", Offset = "0x175F2A0", VA = "0x1817606A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC6D")]
				[Address(RVA = "0x1760820", Offset = "0x175F420", VA = "0x181760820")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045D3 RID: 17875
			// (get) Token: 0x0601DC6E RID: 121966 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC6F RID: 121967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D3")]
			public CrossAppShareImageModel bgPureColorModel
			{
				[Token(Token = "0x601DC6E")]
				[Address(RVA = "0x1760700", Offset = "0x175F300", VA = "0x181760700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC6F")]
				[Address(RVA = "0x17608A0", Offset = "0x175F4A0", VA = "0x1817608A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045D4 RID: 17876
			// (get) Token: 0x0601DC70 RID: 121968 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC71 RID: 121969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D4")]
			public CrossAppShareImageModel leftBorderModel
			{
				[Token(Token = "0x601DC70")]
				[Address(RVA = "0x1760760", Offset = "0x175F360", VA = "0x181760760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC71")]
				[Address(RVA = "0x1760920", Offset = "0x175F520", VA = "0x181760920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045D5 RID: 17877
			// (get) Token: 0x0601DC72 RID: 121970 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DC73 RID: 121971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045D5")]
			public CrossAppShareImageModel rightBorderModel
			{
				[Token(Token = "0x601DC72")]
				[Address(RVA = "0x17607C0", Offset = "0x175F3C0", VA = "0x1817607C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DC73")]
				[Address(RVA = "0x17609A0", Offset = "0x175F5A0", VA = "0x1817609A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DC74 RID: 121972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC74")]
			[Address(RVA = "0x17605C0", Offset = "0x175F1C0", VA = "0x1817605C0")]
			public void InitCollector(NameCardV2ShareBackgroundStartLayoutElement closure)
			{
			}

			// Token: 0x0601DC75 RID: 121973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC75")]
			[Address(RVA = "0x1760160", Offset = "0x175ED60", VA = "0x181760160", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DC76 RID: 121974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DC76")]
			[Address(RVA = "0x1760640", Offset = "0x175F240", VA = "0x181760640")]
			public NameCardV2ShareBackgroundModelCollector()
			{
			}

			// Token: 0x04027690 RID: 161424
			[Token(Token = "0x4027690")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareBackgroundStartLayoutElement m_closure;

			// Token: 0x04027695 RID: 161429
			[Token(Token = "0x4027695")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_bgModel;

			// Token: 0x04027696 RID: 161430
			[Token(Token = "0x4027696")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_bgModel;

			// Token: 0x04027697 RID: 161431
			[Token(Token = "0x4027697")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_bgPureColorModel;

			// Token: 0x04027698 RID: 161432
			[Token(Token = "0x4027698")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_bgPureColorModel;

			// Token: 0x04027699 RID: 161433
			[Token(Token = "0x4027699")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_leftBorderModel;

			// Token: 0x0402769A RID: 161434
			[Token(Token = "0x402769A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_leftBorderModel;

			// Token: 0x0402769B RID: 161435
			[Token(Token = "0x402769B")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_rightBorderModel;

			// Token: 0x0402769C RID: 161436
			[Token(Token = "0x402769C")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_rightBorderModel;

			// Token: 0x0402769D RID: 161437
			[Token(Token = "0x402769D")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x0402769E RID: 161438
			[Token(Token = "0x402769E")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x0402769F RID: 161439
			[Token(Token = "0x402769F")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
