using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20002C5")]
	public class LuaEnv : IDisposable
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x000164E8 File Offset: 0x000146E8
		[Token(Token = "0x17000148")]
		internal IntPtr L
		{
			[Token(Token = "0x60036D6")]
			[Address(RVA = "0x3328950", Offset = "0x3327550", VA = "0x183328950")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000149")]
		internal object luaEnvLock
		{
			[Token(Token = "0x60036D7")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x3327940", Offset = "0x3326540", VA = "0x183327940")]
		public LuaEnv()
		{
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D9")]
		[Address(RVA = "0x3326770", Offset = "0x3325370", VA = "0x183326770")]
		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer)
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014A")]
		public LuaTable Global
		{
			[Token(Token = "0x60036DA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DB")]
		public T LoadString<T>(byte[] chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DC")]
		public T LoadString<T>(string chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DD")]
		[Address(RVA = "0x33270D0", Offset = "0x3325CD0", VA = "0x1833270D0")]
		public LuaFunction LoadString(string chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DE")]
		[Address(RVA = "0x3326CE0", Offset = "0x33258E0", VA = "0x183326CE0")]
		public object[] DoString(byte[] chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DF")]
		[Address(RVA = "0x3326EC0", Offset = "0x3325AC0", VA = "0x183326EC0")]
		public object[] DoString(string chunk, string chunkName = "chunk", [Optional] LuaTable env)
		{
			return null;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0x33268C0", Offset = "0x33254C0", VA = "0x1833268C0")]
		private void AddSearcher(lua_CSFunction searcher, int index)
		{
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0x3326A70", Offset = "0x3325670", VA = "0x183326A70")]
		public void Alias(Type type, string alias)
		{
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00016500 File Offset: 0x00014700
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0x3327320", Offset = "0x3325F20", VA = "0x183327320")]
		private static bool ObjectValidCheck(object obj)
		{
			return default(bool);
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E3")]
		[Address(RVA = "0x3327720", Offset = "0x3326320", VA = "0x183327720")]
		public void Tick()
		{
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E4")]
		[Address(RVA = "0x3327000", Offset = "0x3325C00", VA = "0x183327000")]
		public void GC()
		{
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E5")]
		[Address(RVA = "0x3327140", Offset = "0x3325D40", VA = "0x183327140")]
		public LuaTable NewTable()
		{
			return null;
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E6")]
		[Address(RVA = "0x3326C50", Offset = "0x3325850", VA = "0x183326C50", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E7")]
		[Address(RVA = "0x3326A90", Offset = "0x3325690", VA = "0x183326A90", Slot = "5")]
		public virtual void Dispose(bool dispose)
		{
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E8")]
		[Address(RVA = "0x3327570", Offset = "0x3326170", VA = "0x183327570")]
		public void ThrowExceptionFromError(int oldTop)
		{
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E9")]
		[Address(RVA = "0x33286E0", Offset = "0x33272E0", VA = "0x1833286E0")]
		internal void equeueGCAction(LuaEnv.GCAction action)
		{
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EA")]
		[Address(RVA = "0x3326860", Offset = "0x3325460", VA = "0x183326860")]
		public void AddLoader(LuaEnv.CustomLoader loader)
		{
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EB")]
		[Address(RVA = "0x33266A0", Offset = "0x33252A0", VA = "0x1833266A0")]
		public void AddBuildin(string name, lua_CSFunction initer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x00016518 File Offset: 0x00014718
		// (set) Token: 0x060036ED RID: 14061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700014B")]
		public int GcPause
		{
			[Token(Token = "0x60036EC")]
			[Address(RVA = "0x33287B0", Offset = "0x33273B0", VA = "0x1833287B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60036ED")]
			[Address(RVA = "0x3328AB0", Offset = "0x33276B0", VA = "0x183328AB0")]
			set
			{
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x00016530 File Offset: 0x00014730
		// (set) Token: 0x060036EF RID: 14063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700014C")]
		public int GcStepmul
		{
			[Token(Token = "0x60036EE")]
			[Address(RVA = "0x3328880", Offset = "0x3327480", VA = "0x183328880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60036EF")]
			[Address(RVA = "0x3328B60", Offset = "0x3327760", VA = "0x183328B60")]
			set
			{
			}
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x3326F60", Offset = "0x3325B60", VA = "0x183326F60")]
		public void FullGc()
		{
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x33274D0", Offset = "0x33260D0", VA = "0x1833274D0")]
		public void StopGc()
		{
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F2")]
		[Address(RVA = "0x3327430", Offset = "0x3326030", VA = "0x183327430")]
		public void RestartGc()
		{
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00016548 File Offset: 0x00014748
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x3327010", Offset = "0x3325C10", VA = "0x183327010")]
		public bool GcStep(int data)
		{
			return default(bool);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060036F4 RID: 14068 RVA: 0x00016560 File Offset: 0x00014760
		[Token(Token = "0x1700014D")]
		public int Memroy
		{
			[Token(Token = "0x60036F4")]
			[Address(RVA = "0x3328A00", Offset = "0x3327600", VA = "0x183328A00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		public const string CSHARP_NAMESPACE = "xlua_csharp_namespace";

		// Token: 0x04000D0D RID: 3341
		[Token(Token = "0x4000D0D")]
		public const string MAIN_SHREAD = "xlua_main_thread";

		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr rawL;

		// Token: 0x04000D0F RID: 3343
		[Token(Token = "0x4000D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LuaTable _G;

		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal ObjectTranslator translator;

		// Token: 0x04000D11 RID: 3345
		[Token(Token = "0x4000D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int errorFuncRef;

		// Token: 0x04000D12 RID: 3346
		[Token(Token = "0x4000D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal object luaLock;

		// Token: 0x04000D13 RID: 3347
		[Token(Token = "0x4000D13")]
		private const int LIB_VERSION_EXPECT = 105;

		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Action<LuaEnv, ObjectTranslator>> initers;

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int last_check_point;

		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int max_check_per_tick;

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Func<object, bool> object_valid_checker;

		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool disposed;

		// Token: 0x04000D19 RID: 3353
		[Token(Token = "0x4000D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Queue<LuaEnv.GCAction> refQueue;

		// Token: 0x04000D1A RID: 3354
		[Token(Token = "0x4000D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string init_xlua;

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal List<LuaEnv.CustomLoader> customLoaders;

		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal Dictionary<string, lua_CSFunction> buildin_initer;

		// Token: 0x020002C6 RID: 710
		[Token(Token = "0x20002C6")]
		internal struct GCAction
		{
			// Token: 0x04000D1D RID: 3357
			[Token(Token = "0x4000D1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Reference;

			// Token: 0x04000D1E RID: 3358
			[Token(Token = "0x4000D1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool IsDelegate;
		}

		// Token: 0x020002C7 RID: 711
		// (Invoke) Token: 0x060036F6 RID: 14070
		[Token(Token = "0x20002C7")]
		public delegate byte[] CustomLoader(ref string filepath);
	}
}
