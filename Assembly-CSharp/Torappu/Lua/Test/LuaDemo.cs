using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Lua.Test
{
	// Token: 0x0200161B RID: 5659
	[Token(Token = "0x200161B")]
	[Hotfix(HotfixFlag.Stateless)]
	public class LuaDemo : MonoBehaviour
	{
		// Token: 0x0600808A RID: 32906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808A")]
		[Address(RVA = "0x288B880", Offset = "0x288A480", VA = "0x18288B880")]
		private void Start()
		{
		}

		// Token: 0x0600808B RID: 32907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600808B")]
		[Address(RVA = "0x288B930", Offset = "0x288A530", VA = "0x18288B930")]
		public LuaDemo()
		{
		}

		// Token: 0x040081A9 RID: 33193
		[Token(Token = "0x40081A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextAsset _script;

		// Token: 0x040081AA RID: 33194
		[Token(Token = "0x40081AA")]
		[FieldOffset(Offset = "0x20")]
		private LuaEnv m_env;

		// Token: 0x040081AB RID: 33195
		[Token(Token = "0x40081AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040081AC RID: 33196
		[Token(Token = "0x40081AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
