using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F58 RID: 16216
	[Token(Token = "0x2003F58")]
	public class SiracusaMapOperaPage : StateEnginePage
	{
		// Token: 0x060192DB RID: 103131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192DB")]
		[Address(RVA = "0x11EED00", Offset = "0x11ED900", VA = "0x1811EED00", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060192DC RID: 103132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192DC")]
		[Address(RVA = "0x11EF060", Offset = "0x11EDC60", VA = "0x1811EF060")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x060192DD RID: 103133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192DD")]
		[Address(RVA = "0x11EEFC0", Offset = "0x11EDBC0", VA = "0x1811EEFC0")]
		private void _CommonQuit()
		{
		}

		// Token: 0x060192DE RID: 103134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192DE")]
		[Address(RVA = "0x11EEE00", Offset = "0x11EDA00", VA = "0x1811EEE00")]
		public void ShowToast(string tips, bool isStrongAlert = false)
		{
		}

		// Token: 0x060192DF RID: 103135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192DF")]
		[Address(RVA = "0x11EF130", Offset = "0x11EDD30", VA = "0x1811EF130")]
		public SiracusaMapOperaPage()
		{
		}

		// Token: 0x060192E1 RID: 103137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192E1")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0401F37C RID: 127868
		[Token(Token = "0x401F37C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401F37D RID: 127869
		[Token(Token = "0x401F37D")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private SiracusaMapNotify _siracusaMapNotify;

		// Token: 0x0401F37E RID: 127870
		[Token(Token = "0x401F37E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401F37F RID: 127871
		[Token(Token = "0x401F37F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0401F380 RID: 127872
		[Token(Token = "0x401F380")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CommonQuit;

		// Token: 0x0401F381 RID: 127873
		[Token(Token = "0x401F381")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowToast;

		// Token: 0x0401F382 RID: 127874
		[Token(Token = "0x401F382")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F59 RID: 16217
		[Token(Token = "0x2003F59")]
		public class Param
		{
			// Token: 0x060192E2 RID: 103138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60192E2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0401F383 RID: 127875
			[Token(Token = "0x401F383")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;
		}
	}
}
