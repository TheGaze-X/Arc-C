using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EA9 RID: 7849
	[Token(Token = "0x2001EA9")]
	public struct AVGReaderModeAutoPlayCache : IHotfixable
	{
		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x0600C265 RID: 49765 RVA: 0x00047598 File Offset: 0x00045798
		// (set) Token: 0x0600C266 RID: 49766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001741")]
		public AVGReaderModeAutoPlayCache.AutoMode autoMode
		{
			[Token(Token = "0x600C265")]
			[Address(RVA = "0x33F9D20", Offset = "0x33F8920", VA = "0x1833F9D20")]
			get
			{
				return AVGReaderModeAutoPlayCache.AutoMode.DEFAULT;
			}
			[Token(Token = "0x600C266")]
			[Address(RVA = "0x33F9DE0", Offset = "0x33F89E0", VA = "0x1833F9DE0")]
			set
			{
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x0600C267 RID: 49767 RVA: 0x000475B0 File Offset: 0x000457B0
		// (set) Token: 0x0600C268 RID: 49768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001742")]
		public int speedLevel
		{
			[Token(Token = "0x600C267")]
			[Address(RVA = "0x33F9D80", Offset = "0x33F8980", VA = "0x1833F9D80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600C268")]
			[Address(RVA = "0x33F9E60", Offset = "0x33F8A60", VA = "0x1833F9E60")]
			set
			{
			}
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C269")]
		[Address(RVA = "0x33F9BC0", Offset = "0x33F87C0", VA = "0x1833F9BC0")]
		private void _SaveAutoMode()
		{
		}

		// Token: 0x0600C26A RID: 49770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C26A")]
		[Address(RVA = "0x33F9C70", Offset = "0x33F8870", VA = "0x1833F9C70")]
		private void _SaveSpeedLevel()
		{
		}

		// Token: 0x0600C26B RID: 49771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C26B")]
		[Address(RVA = "0x33F9A90", Offset = "0x33F8690", VA = "0x1833F9A90")]
		public void LoadData()
		{
		}

		// Token: 0x0600C26C RID: 49772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C26C")]
		[Address(RVA = "0x33F9B60", Offset = "0x33F8760", VA = "0x1833F9B60")]
		public void Reset()
		{
		}

		// Token: 0x0400C432 RID: 50226
		[Token(Token = "0x400C432")]
		[FieldOffset(Offset = "0x0")]
		private AVGReaderModeAutoPlayCache.AutoMode m_autoMode;

		// Token: 0x0400C433 RID: 50227
		[Token(Token = "0x400C433")]
		[FieldOffset(Offset = "0x4")]
		private int m_speedLevel;

		// Token: 0x0400C434 RID: 50228
		[Token(Token = "0x400C434")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_autoMode;

		// Token: 0x0400C435 RID: 50229
		[Token(Token = "0x400C435")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_autoMode;

		// Token: 0x0400C436 RID: 50230
		[Token(Token = "0x400C436")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_speedLevel;

		// Token: 0x0400C437 RID: 50231
		[Token(Token = "0x400C437")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_speedLevel;

		// Token: 0x0400C438 RID: 50232
		[Token(Token = "0x400C438")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveAutoMode;

		// Token: 0x0400C439 RID: 50233
		[Token(Token = "0x400C439")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SaveSpeedLevel;

		// Token: 0x0400C43A RID: 50234
		[Token(Token = "0x400C43A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400C43B RID: 50235
		[Token(Token = "0x400C43B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x02001EAA RID: 7850
		[Token(Token = "0x2001EAA")]
		public enum AutoMode
		{
			// Token: 0x0400C43D RID: 50237
			[Token(Token = "0x400C43D")]
			DEFAULT,
			// Token: 0x0400C43E RID: 50238
			[Token(Token = "0x400C43E")]
			AUTO_PLAY
		}
	}
}
