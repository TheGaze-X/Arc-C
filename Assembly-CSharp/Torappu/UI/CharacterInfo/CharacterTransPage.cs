using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EC8 RID: 24264
	[Token(Token = "0x2005EC8")]
	public class CharacterTransPage : StateEnginePage
	{
		// Token: 0x0602322B RID: 143915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602322B")]
		[Address(RVA = "0x1DB7720", Offset = "0x1DB6320", VA = "0x181DB7720")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602322C RID: 143916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602322C")]
		[Address(RVA = "0x1DB75D0", Offset = "0x1DB61D0", VA = "0x181DB75D0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602322D RID: 143917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602322D")]
		[Address(RVA = "0x1DB7830", Offset = "0x1DB6430", VA = "0x181DB7830")]
		public CharacterTransPage()
		{
		}

		// Token: 0x0602322E RID: 143918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602322E")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x040306E1 RID: 198369
		[Token(Token = "0x40306E1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _btnCancel;

		// Token: 0x040306E2 RID: 198370
		[Token(Token = "0x40306E2")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isInited;

		// Token: 0x040306E3 RID: 198371
		[Token(Token = "0x40306E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040306E4 RID: 198372
		[Token(Token = "0x40306E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040306E5 RID: 198373
		[Token(Token = "0x40306E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EC9 RID: 24265
		[Token(Token = "0x2005EC9")]
		public class Param
		{
			// Token: 0x0602322F RID: 143919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602322F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040306E6 RID: 198374
			[Token(Token = "0x40306E6")]
			[FieldOffset(Offset = "0x10")]
			public int charInstId;

			// Token: 0x040306E7 RID: 198375
			[Token(Token = "0x40306E7")]
			[FieldOffset(Offset = "0x18")]
			public string[] templates;
		}
	}
}
