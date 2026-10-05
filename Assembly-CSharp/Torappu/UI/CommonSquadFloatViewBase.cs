using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035E9 RID: 13801
	[Token(Token = "0x20035E9")]
	public abstract class CommonSquadFloatViewBase : DataBinder<CommonSquadGroupViewProperty>
	{
		// Token: 0x06015FA2 RID: 90018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FA2")]
		[Address(RVA = "0xE75960", Offset = "0xE74560", VA = "0x180E75960", Slot = "8")]
		public virtual void RegisterTutorialGO()
		{
		}

		// Token: 0x06015FA3 RID: 90019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FA3")]
		[Address(RVA = "0xE759C0", Offset = "0xE745C0", VA = "0x180E759C0")]
		protected CommonSquadFloatViewBase()
		{
		}

		// Token: 0x0401A68C RID: 108172
		[Token(Token = "0x401A68C")]
		[FieldOffset(Offset = "0x20")]
		protected UIStateFinder stateFinder;

		// Token: 0x0401A68D RID: 108173
		[Token(Token = "0x401A68D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0401A68E RID: 108174
		[Token(Token = "0x401A68E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
