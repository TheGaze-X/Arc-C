using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DD8 RID: 19928
	[Token(Token = "0x2004DD8")]
	public class NameCardV2ShareIllustStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DCC0 RID: 122048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DCC0")]
		[Address(RVA = "0x1765250", Offset = "0x1763E50", VA = "0x181765250", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DCC1 RID: 122049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCC1")]
		[Address(RVA = "0x17653A0", Offset = "0x1763FA0", VA = "0x1817653A0")]
		public NameCardV2ShareIllustStartLayoutElement()
		{
		}

		// Token: 0x0402773E RID: 161598
		[Token(Token = "0x402773E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrossAppShareStartDynAssetContent _crossAppShareIllustContent;

		// Token: 0x0402773F RID: 161599
		[Token(Token = "0x402773F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x04027740 RID: 161600
		[Token(Token = "0x4027740")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DD9 RID: 19929
		[Token(Token = "0x2004DD9")]
		public class NameCardV2ShareIllustModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x170045EF RID: 17903
			// (get) Token: 0x0601DCC2 RID: 122050 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCC3 RID: 122051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045EF")]
			public CrossAppShareDynAssetBaseModel illustModel
			{
				[Token(Token = "0x601DCC2")]
				[Address(RVA = "0x1764FC0", Offset = "0x1763BC0", VA = "0x181764FC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCC3")]
				[Address(RVA = "0x1765020", Offset = "0x1763C20", VA = "0x181765020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DCC4 RID: 122052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCC4")]
			[Address(RVA = "0x1764EE0", Offset = "0x1763AE0", VA = "0x181764EE0")]
			public void InitCollector(NameCardV2ShareIllustStartLayoutElement closure)
			{
			}

			// Token: 0x0601DCC5 RID: 122053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCC5")]
			[Address(RVA = "0x1764D80", Offset = "0x1763980", VA = "0x181764D80", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DCC6 RID: 122054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCC6")]
			[Address(RVA = "0x1764F60", Offset = "0x1763B60", VA = "0x181764F60")]
			public NameCardV2ShareIllustModelCollector()
			{
			}

			// Token: 0x04027741 RID: 161601
			[Token(Token = "0x4027741")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareIllustStartLayoutElement m_closure;

			// Token: 0x04027743 RID: 161603
			[Token(Token = "0x4027743")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_illustModel;

			// Token: 0x04027744 RID: 161604
			[Token(Token = "0x4027744")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_illustModel;

			// Token: 0x04027745 RID: 161605
			[Token(Token = "0x4027745")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x04027746 RID: 161606
			[Token(Token = "0x4027746")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x04027747 RID: 161607
			[Token(Token = "0x4027747")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
