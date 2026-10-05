using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037A6 RID: 14246
	[Token(Token = "0x20037A6")]
	public class LuaUIMisc : IDisposable, IHotfixable
	{
		// Token: 0x0601699B RID: 92571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601699B")]
		[Address(RVA = "0xEFA130", Offset = "0xEF8D30", VA = "0x180EFA130")]
		public static LuaUIMisc ShowGainedItems(List<RewardItemModel> items, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x0601699C RID: 92572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601699C")]
		[Address(RVA = "0xEF9FD0", Offset = "0xEF8BD0", VA = "0x180EF9FD0")]
		public static LuaUIMisc OpenGuidebookExt(string[] pageids, int forceRead, Action onFinish)
		{
			return null;
		}

		// Token: 0x0601699D RID: 92573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601699D")]
		[Address(RVA = "0xEF9F50", Offset = "0xEF8B50", VA = "0x180EF9F50", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0601699E RID: 92574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601699E")]
		[Address(RVA = "0xEFA330", Offset = "0xEF8F30", VA = "0x180EFA330")]
		private void _OnConfirm()
		{
		}

		// Token: 0x0601699F RID: 92575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601699F")]
		[Address(RVA = "0xEFA2C0", Offset = "0xEF8EC0", VA = "0x180EFA2C0")]
		private void _OnCancel()
		{
		}

		// Token: 0x060169A0 RID: 92576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169A0")]
		[Address(RVA = "0xEFA3A0", Offset = "0xEF8FA0", VA = "0x180EFA3A0")]
		public LuaUIMisc()
		{
		}

		// Token: 0x0401B3D8 RID: 111576
		[Token(Token = "0x401B3D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Action m_onConfirm;

		// Token: 0x0401B3D9 RID: 111577
		[Token(Token = "0x401B3D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action m_onCancel;

		// Token: 0x0401B3DA RID: 111578
		[Token(Token = "0x401B3DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowGainedItems;

		// Token: 0x0401B3DB RID: 111579
		[Token(Token = "0x401B3DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenGuidebookExt;

		// Token: 0x0401B3DC RID: 111580
		[Token(Token = "0x401B3DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401B3DD RID: 111581
		[Token(Token = "0x401B3DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnConfirm;

		// Token: 0x0401B3DE RID: 111582
		[Token(Token = "0x401B3DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x0401B3DF RID: 111583
		[Token(Token = "0x401B3DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
