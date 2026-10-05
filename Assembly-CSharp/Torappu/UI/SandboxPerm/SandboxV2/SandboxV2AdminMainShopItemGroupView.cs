using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040DF RID: 16607
	[Token(Token = "0x20040DF")]
	public class SandboxV2AdminMainShopItemGroupView : DataBinder<SandboxV2AdminMainShopProperty>, IHotfixable
	{
		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x06019AFC RID: 105212 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019AFD RID: 105213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D45")]
		public UIPage page
		{
			[Token(Token = "0x6019AFC")]
			[Address(RVA = "0x12838E0", Offset = "0x12824E0", VA = "0x1812838E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019AFD")]
			[Address(RVA = "0x12839C0", Offset = "0x12825C0", VA = "0x1812839C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x06019AFE RID: 105214 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019AFF RID: 105215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D46")]
		public Action<int> onItemClicked
		{
			[Token(Token = "0x6019AFE")]
			[Address(RVA = "0x1283880", Offset = "0x1282480", VA = "0x181283880")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019AFF")]
			[Address(RVA = "0x1283940", Offset = "0x1282540", VA = "0x181283940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019B00 RID: 105216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B00")]
		[Address(RVA = "0x12833D0", Offset = "0x1281FD0", VA = "0x1812833D0", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainShopProperty property)
		{
		}

		// Token: 0x06019B01 RID: 105217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B01")]
		[Address(RVA = "0x1283640", Offset = "0x1282240", VA = "0x181283640")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019B02 RID: 105218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B02")]
		[Address(RVA = "0x1283810", Offset = "0x1282410", VA = "0x181283810")]
		public SandboxV2AdminMainShopItemGroupView()
		{
		}

		// Token: 0x040201FF RID: 131583
		[Token(Token = "0x40201FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2AdminMainShopItemGroupAdapter _adapter;

		// Token: 0x04020200 RID: 131584
		[Token(Token = "0x4020200")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04020203 RID: 131587
		[Token(Token = "0x4020203")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04020204 RID: 131588
		[Token(Token = "0x4020204")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04020205 RID: 131589
		[Token(Token = "0x4020205")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x04020206 RID: 131590
		[Token(Token = "0x4020206")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x04020207 RID: 131591
		[Token(Token = "0x4020207")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020208 RID: 131592
		[Token(Token = "0x4020208")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020209 RID: 131593
		[Token(Token = "0x4020209")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
