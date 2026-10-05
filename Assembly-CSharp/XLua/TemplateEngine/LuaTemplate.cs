using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua.LuaDLL;

namespace XLua.TemplateEngine
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x20002FC")]
	public class LuaTemplate
	{
		// Token: 0x06003809 RID: 14345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003809")]
		[Address(RVA = "0x3440A90", Offset = "0x343F690", VA = "0x183440A90")]
		public static string ComposeCode(List<Chunk> chunks)
		{
			return null;
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380A")]
		[Address(RVA = "0x34409D0", Offset = "0x343F5D0", VA = "0x1834409D0")]
		public static LuaFunction Compile(LuaEnv luaenv, string snippet)
		{
			return null;
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380B")]
		[Address(RVA = "0x3440CE0", Offset = "0x343F8E0", VA = "0x183440CE0")]
		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters)
		{
			return null;
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380C")]
		[Address(RVA = "0x3440D90", Offset = "0x343F990", VA = "0x183440D90")]
		public static string Execute(LuaFunction compiledTemplate)
		{
			return null;
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x00016C68 File Offset: 0x00014E68
		[Token(Token = "0x600380D")]
		[Address(RVA = "0x3440760", Offset = "0x343F360", VA = "0x183440760")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Compile(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x00016C80 File Offset: 0x00014E80
		[Token(Token = "0x600380E")]
		[Address(RVA = "0x3440E30", Offset = "0x343FA30", VA = "0x183440E30")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Execute(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x3440F90", Offset = "0x343FB90", VA = "0x183440F90")]
		public static void OpenLib(IntPtr L)
		{
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003810")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LuaTemplate()
		{
		}

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000DD5")]
		[FieldOffset(Offset = "0x0")]
		private static lua_CSFunction templateCompileFunction;

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000DD6")]
		[FieldOffset(Offset = "0x8")]
		private static lua_CSFunction templateExecuteFunction;
	}
}
