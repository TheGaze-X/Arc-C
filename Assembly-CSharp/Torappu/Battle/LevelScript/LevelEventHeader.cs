using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002845 RID: 10309
	[Token(Token = "0x2002845")]
	public abstract class LevelEventHeader : ActionHeader
	{
		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x0601129D RID: 70301
		[Token(Token = "0x170025D5")]
		public abstract GameLevelEvent levelEventKey { [Token(Token = "0x601129D")] get; }

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x0601129E RID: 70302 RVA: 0x00069A68 File Offset: 0x00067C68
		[Token(Token = "0x170025D6")]
		public override uint keyEnumFilter
		{
			[Token(Token = "0x601129E")]
			[Address(RVA = "0x90FFD0", Offset = "0x90EBD0", VA = "0x18090FFD0", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x0601129F RID: 70303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025D7")]
		public override string keyFilter
		{
			[Token(Token = "0x601129F")]
			[Address(RVA = "0x910120", Offset = "0x90ED20", VA = "0x180910120", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060112A0 RID: 70304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60112A0")]
		[Address(RVA = "0x90FF70", Offset = "0x90EB70", VA = "0x18090FF70")]
		protected LevelEventHeader()
		{
		}

		// Token: 0x060112A1 RID: 70305 RVA: 0x00069A80 File Offset: 0x00067C80
		[Token(Token = "0x60112A1")]
		[Address(RVA = "0x906E20", Offset = "0x905A20", VA = "0x180906E20")]
		private uint <>xLuaBaseProxy_get_keyEnumFilter()
		{
			return 0U;
		}

		// Token: 0x060112A2 RID: 70306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60112A2")]
		[Address(RVA = "0x906E80", Offset = "0x905A80", VA = "0x180906E80")]
		private string <>xLuaBaseProxy_get_keyFilter()
		{
			return null;
		}

		// Token: 0x04013390 RID: 78736
		[Token(Token = "0x4013390")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_keyEnumFilter;

		// Token: 0x04013391 RID: 78737
		[Token(Token = "0x4013391")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_keyFilter;

		// Token: 0x04013392 RID: 78738
		[Token(Token = "0x4013392")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
