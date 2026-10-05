using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BE1 RID: 15329
	[Token(Token = "0x2003BE1")]
	public class UniEquipArchivePage : StateEnginePage
	{
		// Token: 0x06017FC3 RID: 98243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FC3")]
		[Address(RVA = "0x10673D0", Offset = "0x1065FD0", VA = "0x1810673D0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06017FC4 RID: 98244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FC4")]
		[Address(RVA = "0x10676A0", Offset = "0x10662A0", VA = "0x1810676A0")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x06017FC5 RID: 98245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FC5")]
		[Address(RVA = "0x1067570", Offset = "0x1066170", VA = "0x181067570")]
		private void _CommonQuit()
		{
		}

		// Token: 0x06017FC6 RID: 98246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FC6")]
		[Address(RVA = "0x1067810", Offset = "0x1066410", VA = "0x181067810")]
		public UniEquipArchivePage()
		{
		}

		// Token: 0x06017FC8 RID: 98248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FC8")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0401D0AC RID: 118956
		[Token(Token = "0x401D0AC")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401D0AD RID: 118957
		[Token(Token = "0x401D0AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401D0AE RID: 118958
		[Token(Token = "0x401D0AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0401D0AF RID: 118959
		[Token(Token = "0x401D0AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CommonQuit;

		// Token: 0x0401D0B0 RID: 118960
		[Token(Token = "0x401D0B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
