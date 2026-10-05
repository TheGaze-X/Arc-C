using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DA3 RID: 15779
	[Token(Token = "0x2003DA3")]
	public class TemplateMissionPage : StateEnginePage, IHotfixable
	{
		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x06018893 RID: 100499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A85")]
		public TemplateMissionInputParam inputParam
		{
			[Token(Token = "0x6018893")]
			[Address(RVA = "0x1114960", Offset = "0x1113560", VA = "0x181114960")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018894 RID: 100500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018894")]
		[Address(RVA = "0x1114850", Offset = "0x1113450", VA = "0x181114850", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06018895 RID: 100501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018895")]
		[Address(RVA = "0x11147A0", Offset = "0x11133A0", VA = "0x1811147A0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06018896 RID: 100502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018896")]
		[Address(RVA = "0x1114900", Offset = "0x1113500", VA = "0x181114900")]
		public TemplateMissionPage()
		{
		}

		// Token: 0x06018898 RID: 100504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018898")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06018899 RID: 100505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018899")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0401E157 RID: 123223
		[Token(Token = "0x401E157")]
		[FieldOffset(Offset = "0xF0")]
		private TemplateMissionInputParam m_inputParam;

		// Token: 0x0401E158 RID: 123224
		[Token(Token = "0x401E158")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inputParam;

		// Token: 0x0401E159 RID: 123225
		[Token(Token = "0x401E159")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401E15A RID: 123226
		[Token(Token = "0x401E15A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0401E15B RID: 123227
		[Token(Token = "0x401E15B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DA4 RID: 15780
		[Token(Token = "0x2003DA4")]
		public class Input
		{
			// Token: 0x0601889A RID: 100506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601889A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0401E15C RID: 123228
			[Token(Token = "0x401E15C")]
			[FieldOffset(Offset = "0x10")]
			public TemplateMissionInputParam inputParam;
		}
	}
}
