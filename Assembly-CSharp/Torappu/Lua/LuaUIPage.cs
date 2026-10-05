using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x02001604 RID: 5636
	[Token(Token = "0x2001604")]
	public class LuaUIPage : UIPage, IContextHost
	{
		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F26")]
		public Transform root
		{
			[Token(Token = "0x6007FE9")]
			[Address(RVA = "0x2892F10", Offset = "0x2891B10", VA = "0x182892F10", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06007FEA RID: 32746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F27")]
		public string mainDialog
		{
			[Token(Token = "0x6007FEA")]
			[Address(RVA = "0x2892EB0", Offset = "0x2891AB0", VA = "0x182892EB0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007FEB RID: 32747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FEB")]
		[Address(RVA = "0x2892CD0", Offset = "0x28918D0", VA = "0x182892CD0", Slot = "26")]
		public void OnLeaveContext()
		{
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FEC")]
		[Address(RVA = "0x2892A60", Offset = "0x2891660", VA = "0x182892A60", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FED")]
		[Address(RVA = "0x2892D30", Offset = "0x2891930", VA = "0x182892D30", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FEE")]
		[Address(RVA = "0x2892A00", Offset = "0x2891600", VA = "0x182892A00", Slot = "29")]
		public IDictionary<string, Type> CompDeclaration()
		{
			return null;
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FEF")]
		[Address(RVA = "0x2892DF0", Offset = "0x28919F0", VA = "0x182892DF0", Slot = "30")]
		public UnityEngine.Object UICompDialogHost()
		{
			return null;
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF0")]
		[Address(RVA = "0x2892E50", Offset = "0x2891A50", VA = "0x182892E50")]
		public LuaUIPage()
		{
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF1")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF2")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x0400815D RID: 33117
		[Token(Token = "0x400815D")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Tooltip("The root dialog of this page")]
		private string _mainDialog;

		// Token: 0x0400815E RID: 33118
		[Token(Token = "0x400815E")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform _dlgRoot;

		// Token: 0x0400815F RID: 33119
		[Token(Token = "0x400815F")]
		[FieldOffset(Offset = "0xE8")]
		private LuaUIContext m_context;

		// Token: 0x04008160 RID: 33120
		[Token(Token = "0x4008160")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_root;

		// Token: 0x04008161 RID: 33121
		[Token(Token = "0x4008161")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_mainDialog;

		// Token: 0x04008162 RID: 33122
		[Token(Token = "0x4008162")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLeaveContext;

		// Token: 0x04008163 RID: 33123
		[Token(Token = "0x4008163")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04008164 RID: 33124
		[Token(Token = "0x4008164")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x04008165 RID: 33125
		[Token(Token = "0x4008165")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CompDeclaration;

		// Token: 0x04008166 RID: 33126
		[Token(Token = "0x4008166")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UICompDialogHost;

		// Token: 0x04008167 RID: 33127
		[Token(Token = "0x4008167")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001605 RID: 5637
		[Token(Token = "0x2001605")]
		public class Params : Dictionary<string, string>
		{
			// Token: 0x06007FF3 RID: 32755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FF3")]
			[Address(RVA = "0x2899E20", Offset = "0x2898A20", VA = "0x182899E20")]
			public Params()
			{
			}

			// Token: 0x04008168 RID: 33128
			[Token(Token = "0x4008168")]
			[FieldOffset(Offset = "0x50")]
			public LuaTable luaTable;
		}
	}
}
