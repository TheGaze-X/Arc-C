using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main11
{
	// Token: 0x02006A34 RID: 27188
	[Token(Token = "0x2006A34")]
	public class Main11ZoneRecordGroupViewModel : ZoneRecordGroupViewModel
	{
		// Token: 0x17005BB0 RID: 23472
		// (get) Token: 0x06026DD1 RID: 159185 RVA: 0x000CC8B8 File Offset: 0x000CAAB8
		[Token(Token = "0x17005BB0")]
		public bool hasStageBanned
		{
			[Token(Token = "0x6026DD1")]
			[Address(RVA = "0x21F65C0", Offset = "0x21F51C0", VA = "0x1821F65C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026DD2 RID: 159186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DD2")]
		[Address(RVA = "0x21F60F0", Offset = "0x21F4CF0", VA = "0x1821F60F0", Slot = "4")]
		public override void LoadData(ZoneRecordGroupData groupData)
		{
		}

		// Token: 0x06026DD3 RID: 159187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DD3")]
		[Address(RVA = "0x21F6170", Offset = "0x21F4D70", VA = "0x1821F6170")]
		public void RefreshData(ZoneRecordGroupData groupData)
		{
		}

		// Token: 0x06026DD4 RID: 159188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DD4")]
		[Address(RVA = "0x21F6560", Offset = "0x21F5160", VA = "0x1821F6560")]
		public Main11ZoneRecordGroupViewModel()
		{
		}

		// Token: 0x06026DD5 RID: 159189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DD5")]
		[Address(RVA = "0x21EF4D0", Offset = "0x21EE0D0", VA = "0x1821EF4D0")]
		private void <>xLuaBaseProxy_LoadData(ZoneRecordGroupData P0)
		{
		}

		// Token: 0x04036F3B RID: 225083
		[Token(Token = "0x4036F3B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasStageBanned;

		// Token: 0x04036F3C RID: 225084
		[Token(Token = "0x4036F3C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04036F3D RID: 225085
		[Token(Token = "0x4036F3D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04036F3E RID: 225086
		[Token(Token = "0x4036F3E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
