using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007599 RID: 30105
	[Token(Token = "0x2007599")]
	public class Act24sideEntryMissionViewModel : IHotfixable
	{
		// Token: 0x0602A5EE RID: 173550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5EE")]
		[Address(RVA = "0x2607C70", Offset = "0x2606870", VA = "0x182607C70")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602A5EF RID: 173551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5EF")]
		[Address(RVA = "0x2607FC0", Offset = "0x2606BC0", VA = "0x182607FC0")]
		private void _InitData(string actId)
		{
		}

		// Token: 0x0602A5F0 RID: 173552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5F0")]
		[Address(RVA = "0x26080B0", Offset = "0x2606CB0", VA = "0x1826080B0")]
		public Act24sideEntryMissionViewModel()
		{
		}

		// Token: 0x0403CF54 RID: 249684
		[Token(Token = "0x403CF54")]
		[FieldOffset(Offset = "0x10")]
		public bool isHaveOver;

		// Token: 0x0403CF55 RID: 249685
		[Token(Token = "0x403CF55")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, Act24SideData.MissionExtraData> m_actMissionData;

		// Token: 0x0403CF56 RID: 249686
		[Token(Token = "0x403CF56")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0403CF57 RID: 249687
		[Token(Token = "0x403CF57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CF58 RID: 249688
		[Token(Token = "0x403CF58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0403CF59 RID: 249689
		[Token(Token = "0x403CF59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
