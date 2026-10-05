using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040DE RID: 16606
	[Token(Token = "0x20040DE")]
	public class SandboxV2AdminMainShopItemGroupAdapter : LoopScrollAdapter<SandboxV2AdminMainShopItemHolder, SandboxV2AdminMainShopItemViewModel>, IHotfixable
	{
		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x06019AF5 RID: 105205 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019AF6 RID: 105206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D43")]
		public UIPage page
		{
			[Token(Token = "0x6019AF5")]
			[Address(RVA = "0x1283270", Offset = "0x1281E70", VA = "0x181283270")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019AF6")]
			[Address(RVA = "0x1283350", Offset = "0x1281F50", VA = "0x181283350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x06019AF7 RID: 105207 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019AF8 RID: 105208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D44")]
		public Action<int> onItemClicked
		{
			[Token(Token = "0x6019AF7")]
			[Address(RVA = "0x1283210", Offset = "0x1281E10", VA = "0x181283210")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019AF8")]
			[Address(RVA = "0x12832D0", Offset = "0x1281ED0", VA = "0x1812832D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019AF9 RID: 105209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019AF9")]
		[Address(RVA = "0x1282E50", Offset = "0x1281A50", VA = "0x181282E50", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06019AFA RID: 105210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AFA")]
		[Address(RVA = "0x1282F00", Offset = "0x1281B00", VA = "0x181282F00", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SandboxV2AdminMainShopItemHolder holder, SandboxV2AdminMainShopItemViewModel data)
		{
		}

		// Token: 0x06019AFB RID: 105211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AFB")]
		[Address(RVA = "0x12831A0", Offset = "0x1281DA0", VA = "0x1812831A0")]
		public SandboxV2AdminMainShopItemGroupAdapter()
		{
		}

		// Token: 0x040201F5 RID: 131573
		[Token(Token = "0x40201F5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefabItem;

		// Token: 0x040201F8 RID: 131576
		[Token(Token = "0x40201F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x040201F9 RID: 131577
		[Token(Token = "0x40201F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x040201FA RID: 131578
		[Token(Token = "0x40201FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x040201FB RID: 131579
		[Token(Token = "0x40201FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x040201FC RID: 131580
		[Token(Token = "0x40201FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040201FD RID: 131581
		[Token(Token = "0x40201FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040201FE RID: 131582
		[Token(Token = "0x40201FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
