using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DE1 RID: 19937
	[Token(Token = "0x2004DE1")]
	public class NameCardV2ShareSignStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DCE9 RID: 122089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DCE9")]
		[Address(RVA = "0x17678F0", Offset = "0x17664F0", VA = "0x1817678F0", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DCEA RID: 122090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCEA")]
		[Address(RVA = "0x1767A40", Offset = "0x1766640", VA = "0x181767A40")]
		public NameCardV2ShareSignStartLayoutElement()
		{
		}

		// Token: 0x0402778A RID: 161674
		[Token(Token = "0x402778A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _resumeIcon;

		// Token: 0x0402778B RID: 161675
		[Token(Token = "0x402778B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bgRect;

		// Token: 0x0402778C RID: 161676
		[Token(Token = "0x402778C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _resumeText;

		// Token: 0x0402778D RID: 161677
		[Token(Token = "0x402778D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x0402778E RID: 161678
		[Token(Token = "0x402778E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DE2 RID: 19938
		[Token(Token = "0x2004DE2")]
		public class NameCardV2ShareSignModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x0601DCEB RID: 122091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCEB")]
			[Address(RVA = "0x1766F90", Offset = "0x1765B90", VA = "0x181766F90", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DCEC RID: 122092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCEC")]
			[Address(RVA = "0x1767320", Offset = "0x1765F20", VA = "0x181767320")]
			public void InitCollector(NameCardV2ShareSignStartLayoutElement closure)
			{
			}

			// Token: 0x170045F9 RID: 17913
			// (get) Token: 0x0601DCED RID: 122093 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCEE RID: 122094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045F9")]
			public CrossAppShareImageModel iconModel
			{
				[Token(Token = "0x601DCED")]
				[Address(RVA = "0x1767460", Offset = "0x1766060", VA = "0x181767460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCEE")]
				[Address(RVA = "0x17675A0", Offset = "0x17661A0", VA = "0x1817675A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045FA RID: 17914
			// (get) Token: 0x0601DCEF RID: 122095 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCF0 RID: 122096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045FA")]
			public CrossAppShareTextModel signTextModel
			{
				[Token(Token = "0x601DCEF")]
				[Address(RVA = "0x17674C0", Offset = "0x17660C0", VA = "0x1817674C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCF0")]
				[Address(RVA = "0x1767620", Offset = "0x1766220", VA = "0x181767620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170045FB RID: 17915
			// (get) Token: 0x0601DCF1 RID: 122097 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCF2 RID: 122098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045FB")]
			public CrossAppShareImageModel bgRectModel
			{
				[Token(Token = "0x601DCF1")]
				[Address(RVA = "0x1767400", Offset = "0x1766000", VA = "0x181767400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCF2")]
				[Address(RVA = "0x1767520", Offset = "0x1766120", VA = "0x181767520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DCF3 RID: 122099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCF3")]
			[Address(RVA = "0x17673A0", Offset = "0x1765FA0", VA = "0x1817673A0")]
			public NameCardV2ShareSignModelCollector()
			{
			}

			// Token: 0x0402778F RID: 161679
			[Token(Token = "0x402778F")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareSignStartLayoutElement m_closure;

			// Token: 0x04027793 RID: 161683
			[Token(Token = "0x4027793")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x04027794 RID: 161684
			[Token(Token = "0x4027794")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x04027795 RID: 161685
			[Token(Token = "0x4027795")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_iconModel;

			// Token: 0x04027796 RID: 161686
			[Token(Token = "0x4027796")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_iconModel;

			// Token: 0x04027797 RID: 161687
			[Token(Token = "0x4027797")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_signTextModel;

			// Token: 0x04027798 RID: 161688
			[Token(Token = "0x4027798")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_signTextModel;

			// Token: 0x04027799 RID: 161689
			[Token(Token = "0x4027799")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_bgRectModel;

			// Token: 0x0402779A RID: 161690
			[Token(Token = "0x402779A")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_bgRectModel;

			// Token: 0x0402779B RID: 161691
			[Token(Token = "0x402779B")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
