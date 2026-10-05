using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A69 RID: 6761
	[Token(Token = "0x2001A69")]
	public class VCharacterManager : Singleton<VCharacter>
	{
		// Token: 0x0600AA53 RID: 43603 RVA: 0x00041F40 File Offset: 0x00040140
		[Token(Token = "0x600AA53")]
		[Address(RVA = "0x325D6B0", Offset = "0x325C2B0", VA = "0x18325D6B0")]
		public bool Register(VCharacter character)
		{
			return default(bool);
		}

		// Token: 0x0600AA54 RID: 43604 RVA: 0x00041F58 File Offset: 0x00040158
		[Token(Token = "0x600AA54")]
		[Address(RVA = "0x325D780", Offset = "0x325C380", VA = "0x18325D780")]
		public bool Unregister(VCharacter character)
		{
			return default(bool);
		}

		// Token: 0x0600AA55 RID: 43605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA55")]
		[Address(RVA = "0x325D500", Offset = "0x325C100", VA = "0x18325D500")]
		public void ClearAll()
		{
		}

		// Token: 0x0600AA56 RID: 43606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA56")]
		[Address(RVA = "0x325D5A0", Offset = "0x325C1A0", VA = "0x18325D5A0")]
		public void OnFixedUpdate(float deltaTime)
		{
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA57")]
		[Address(RVA = "0x325D810", Offset = "0x325C410", VA = "0x18325D810")]
		public VCharacterManager()
		{
		}

		// Token: 0x0400A293 RID: 41619
		[Token(Token = "0x400A293")]
		[FieldOffset(Offset = "0x10")]
		private List<VCharacter> m_list;

		// Token: 0x0400A294 RID: 41620
		[Token(Token = "0x400A294")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x0400A295 RID: 41621
		[Token(Token = "0x400A295")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Unregister;

		// Token: 0x0400A296 RID: 41622
		[Token(Token = "0x400A296")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearAll;

		// Token: 0x0400A297 RID: 41623
		[Token(Token = "0x400A297")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0400A298 RID: 41624
		[Token(Token = "0x400A298")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
