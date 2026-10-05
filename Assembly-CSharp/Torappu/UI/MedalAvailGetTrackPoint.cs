using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AD9 RID: 15065
	[Token(Token = "0x2003AD9")]
	public class MedalAvailGetTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x06017C08 RID: 97288 RVA: 0x00097EC0 File Offset: 0x000960C0
		[Token(Token = "0x170038F1")]
		public bool isShow
		{
			[Token(Token = "0x6017C08")]
			[Address(RVA = "0xFFE8E0", Offset = "0xFFD4E0", VA = "0x180FFE8E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06017C09 RID: 97289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C09")]
		[Address(RVA = "0xFFE810", Offset = "0xFFD410", VA = "0x180FFE810", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06017C0A RID: 97290 RVA: 0x00097ED8 File Offset: 0x000960D8
		[Token(Token = "0x6017C0A")]
		[Address(RVA = "0xFFE5C0", Offset = "0xFFD1C0", VA = "0x180FFE5C0")]
		public static bool GetShowFlag()
		{
			return default(bool);
		}

		// Token: 0x06017C0B RID: 97291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C0B")]
		[Address(RVA = "0xFFE880", Offset = "0xFFD480", VA = "0x180FFE880")]
		public MedalAvailGetTrackPoint()
		{
		}

		// Token: 0x0401CAEA RID: 117482
		[Token(Token = "0x401CAEA")]
		[FieldOffset(Offset = "0x10")]
		private bool m_showFlag;

		// Token: 0x0401CAEB RID: 117483
		[Token(Token = "0x401CAEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0401CAEC RID: 117484
		[Token(Token = "0x401CAEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0401CAED RID: 117485
		[Token(Token = "0x401CAED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowFlag;

		// Token: 0x0401CAEE RID: 117486
		[Token(Token = "0x401CAEE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
