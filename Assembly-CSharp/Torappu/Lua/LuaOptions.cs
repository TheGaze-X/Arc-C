using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;

namespace Torappu.Lua
{
	// Token: 0x020015F2 RID: 5618
	[Token(Token = "0x20015F2")]
	[CreateAssetMenu(menuName = "Torappu/Options/LuaOptions")]
	public class LuaOptions : SingletonScriptableObject<LuaOptions>
	{
		// Token: 0x06007F50 RID: 32592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F50")]
		[Address(RVA = "0x288E6B0", Offset = "0x288D2B0", VA = "0x18288E6B0")]
		public LuaOptions()
		{
		}

		// Token: 0x04008105 RID: 33029
		[Token(Token = "0x4008105")]
		[FieldOffset(Offset = "0x18")]
		public ConverterFactory.ConverterType cryptType;

		// Token: 0x04008106 RID: 33030
		[Token(Token = "0x4008106")]
		[FieldOffset(Offset = "0x20")]
		public string luaFolder;

		// Token: 0x04008107 RID: 33031
		[Token(Token = "0x4008107")]
		[FieldOffset(Offset = "0x28")]
		public string entryFile;
	}
}
