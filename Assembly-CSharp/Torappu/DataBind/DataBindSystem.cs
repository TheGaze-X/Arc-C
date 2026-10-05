using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DataBind
{
	// Token: 0x02001492 RID: 5266
	[Token(Token = "0x2001492")]
	public class DataBindSystem : SingletonMonoBehaviour<DataBindSystem>, ISingletonNotAutoCreate
	{
		// Token: 0x060079BA RID: 31162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BA")]
		[Address(RVA = "0x2637170", Offset = "0x2635D70", VA = "0x182637170")]
		private void Update()
		{
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BB")]
		[Address(RVA = "0x26370E0", Offset = "0x2635CE0", VA = "0x1826370E0")]
		public void NotifyToUpdate(IBindProperty prop)
		{
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079BC")]
		[Address(RVA = "0x2637330", Offset = "0x2635F30", VA = "0x182637330")]
		public DataBindSystem()
		{
		}

		// Token: 0x040077D7 RID: 30679
		[Token(Token = "0x40077D7")]
		[FieldOffset(Offset = "0x18")]
		private List<IBindProperty> m_dirtyProps;

		// Token: 0x040077D8 RID: 30680
		[Token(Token = "0x40077D8")]
		[FieldOffset(Offset = "0x20")]
		private List<IBindProperty> m_propsBuffer;

		// Token: 0x040077D9 RID: 30681
		[Token(Token = "0x40077D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040077DA RID: 30682
		[Token(Token = "0x40077DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyToUpdate;

		// Token: 0x040077DB RID: 30683
		[Token(Token = "0x40077DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
