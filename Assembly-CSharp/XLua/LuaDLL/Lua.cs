using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XLua.LuaDLL
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	public class Lua
	{
		// Token: 0x06003822 RID: 14370
		[Token(Token = "0x6003822")]
		[Address(RVA = "0x3443B70", Offset = "0x3442770", VA = "0x183443B70")]
		[PreserveSig]
		public static extern IntPtr lua_tothread(IntPtr L, int index);

		// Token: 0x06003823 RID: 14371
		[Token(Token = "0x6003823")]
		[Address(RVA = "0x34442B0", Offset = "0x3442EB0", VA = "0x1834442B0")]
		[PreserveSig]
		public static extern int xlua_get_lib_version();

		// Token: 0x06003824 RID: 14372
		[Token(Token = "0x6003824")]
		[Address(RVA = "0x34420C0", Offset = "0x3440CC0", VA = "0x1834420C0")]
		[PreserveSig]
		public static extern int lua_gc(IntPtr L, LuaGCOptions what, int data);

		// Token: 0x06003825 RID: 14373
		[Token(Token = "0x6003825")]
		[Address(RVA = "0x3442260", Offset = "0x3440E60", VA = "0x183442260")]
		[PreserveSig]
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n);

		// Token: 0x06003826 RID: 14374
		[Token(Token = "0x6003826")]
		[Address(RVA = "0x34434A0", Offset = "0x34420A0", VA = "0x1834434A0")]
		[PreserveSig]
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n);

		// Token: 0x06003827 RID: 14375
		[Token(Token = "0x6003827")]
		[Address(RVA = "0x3442E70", Offset = "0x3441A70", VA = "0x183442E70")]
		[PreserveSig]
		public static extern int lua_pushthread(IntPtr L);

		// Token: 0x06003828 RID: 14376 RVA: 0x00016C98 File Offset: 0x00014E98
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x34423B0", Offset = "0x3440FB0", VA = "0x1834423B0")]
		public static bool lua_isfunction(IntPtr L, int stackPos)
		{
			return default(bool);
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00016CB0 File Offset: 0x00014EB0
		[Token(Token = "0x6003829")]
		[Address(RVA = "0x34424F0", Offset = "0x34410F0", VA = "0x1834424F0")]
		public static bool lua_islightuserdata(IntPtr L, int stackPos)
		{
			return default(bool);
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00016CC8 File Offset: 0x00014EC8
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x3442650", Offset = "0x3441250", VA = "0x183442650")]
		public static bool lua_istable(IntPtr L, int stackPos)
		{
			return default(bool);
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x00016CE0 File Offset: 0x00014EE0
		[Token(Token = "0x600382B")]
		[Address(RVA = "0x3442670", Offset = "0x3441270", VA = "0x183442670")]
		public static bool lua_isthread(IntPtr L, int stackPos)
		{
			return default(bool);
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00016CF8 File Offset: 0x00014EF8
		[Token(Token = "0x600382C")]
		[Address(RVA = "0x3441780", Offset = "0x3440380", VA = "0x183441780")]
		public static int luaL_error(IntPtr L, string message)
		{
			return 0;
		}

		// Token: 0x0600382D RID: 14381
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x34432F0", Offset = "0x3441EF0", VA = "0x1834432F0")]
		[PreserveSig]
		public static extern int lua_setfenv(IntPtr L, int stackPos);

		// Token: 0x0600382E RID: 14382
		[Token(Token = "0x600382E")]
		[Address(RVA = "0x3441A70", Offset = "0x3440670", VA = "0x183441A70")]
		[PreserveSig]
		public static extern IntPtr luaL_newstate();

		// Token: 0x0600382F RID: 14383
		[Token(Token = "0x600382F")]
		[Address(RVA = "0x3441F20", Offset = "0x3440B20", VA = "0x183441F20")]
		[PreserveSig]
		public static extern void lua_close(IntPtr L);

		// Token: 0x06003830 RID: 14384
		[Token(Token = "0x6003830")]
		[Address(RVA = "0x3443F90", Offset = "0x3442B90", VA = "0x183443F90")]
		[PreserveSig]
		public static extern void luaopen_xlua(IntPtr L);

		// Token: 0x06003831 RID: 14385
		[Token(Token = "0x6003831")]
		[Address(RVA = "0x3441AE0", Offset = "0x34406E0", VA = "0x183441AE0")]
		[PreserveSig]
		public static extern void luaL_openlibs(IntPtr L);

		// Token: 0x06003832 RID: 14386
		[Token(Token = "0x6003832")]
		[Address(RVA = "0x3444770", Offset = "0x3443370", VA = "0x183444770")]
		[PreserveSig]
		public static extern uint xlua_objlen(IntPtr L, int stackPos);

		// Token: 0x06003833 RID: 14387
		[Token(Token = "0x6003833")]
		[Address(RVA = "0x3441FA0", Offset = "0x3440BA0", VA = "0x183441FA0")]
		[PreserveSig]
		public static extern void lua_createtable(IntPtr L, int narr, int nrec);

		// Token: 0x06003834 RID: 14388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003834")]
		[Address(RVA = "0x3442720", Offset = "0x3441320", VA = "0x183442720")]
		public static void lua_newtable(IntPtr L)
		{
		}

		// Token: 0x06003835 RID: 14389
		[Token(Token = "0x6003835")]
		[Address(RVA = "0x3444390", Offset = "0x3442F90", VA = "0x183444390")]
		[PreserveSig]
		public static extern int xlua_getglobal(IntPtr L, string name);

		// Token: 0x06003836 RID: 14390
		[Token(Token = "0x6003836")]
		[Address(RVA = "0x34458C0", Offset = "0x34444C0", VA = "0x1834458C0")]
		[PreserveSig]
		public static extern int xlua_setglobal(IntPtr L, string name);

		// Token: 0x06003837 RID: 14391
		[Token(Token = "0x6003837")]
		[Address(RVA = "0x3444440", Offset = "0x3443040", VA = "0x183444440")]
		[PreserveSig]
		public static extern void xlua_getloaders(IntPtr L);

		// Token: 0x06003838 RID: 14392
		[Token(Token = "0x6003838")]
		[Address(RVA = "0x3443410", Offset = "0x3442010", VA = "0x183443410")]
		[PreserveSig]
		public static extern void lua_settop(IntPtr L, int newTop);

		// Token: 0x06003839 RID: 14393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003839")]
		[Address(RVA = "0x3442860", Offset = "0x3441460", VA = "0x183442860")]
		public static void lua_pop(IntPtr L, int amount)
		{
		}

		// Token: 0x0600383A RID: 14394
		[Token(Token = "0x600383A")]
		[Address(RVA = "0x3442300", Offset = "0x3440F00", VA = "0x183442300")]
		[PreserveSig]
		public static extern void lua_insert(IntPtr L, int newTop);

		// Token: 0x0600383B RID: 14395
		[Token(Token = "0x600383B")]
		[Address(RVA = "0x34431D0", Offset = "0x3441DD0", VA = "0x1834431D0")]
		[PreserveSig]
		public static extern void lua_remove(IntPtr L, int index);

		// Token: 0x0600383C RID: 14396
		[Token(Token = "0x600383C")]
		[Address(RVA = "0x34430B0", Offset = "0x3441CB0", VA = "0x1834430B0")]
		[PreserveSig]
		public static extern int lua_rawget(IntPtr L, int index);

		// Token: 0x0600383D RID: 14397
		[Token(Token = "0x600383D")]
		[Address(RVA = "0x3443140", Offset = "0x3441D40", VA = "0x183443140")]
		[PreserveSig]
		public static extern void lua_rawset(IntPtr L, int index);

		// Token: 0x0600383E RID: 14398
		[Token(Token = "0x600383E")]
		[Address(RVA = "0x3443380", Offset = "0x3441F80", VA = "0x183443380")]
		[PreserveSig]
		public static extern int lua_setmetatable(IntPtr L, int objIndex);

		// Token: 0x0600383F RID: 14399
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x3443010", Offset = "0x3441C10", VA = "0x183443010")]
		[PreserveSig]
		public static extern int lua_rawequal(IntPtr L, int index1, int index2);

		// Token: 0x06003840 RID: 14400
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x3442F80", Offset = "0x3441B80", VA = "0x183442F80")]
		[PreserveSig]
		public static extern void lua_pushvalue(IntPtr L, int index);

		// Token: 0x06003841 RID: 14401
		[Token(Token = "0x6003841")]
		[Address(RVA = "0x3442900", Offset = "0x3441500", VA = "0x183442900")]
		[PreserveSig]
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n);

		// Token: 0x06003842 RID: 14402
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x3443260", Offset = "0x3441E60", VA = "0x183443260")]
		[PreserveSig]
		public static extern void lua_replace(IntPtr L, int index);

		// Token: 0x06003843 RID: 14403
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x34421E0", Offset = "0x3440DE0", VA = "0x1834421E0")]
		[PreserveSig]
		public static extern int lua_gettop(IntPtr L);

		// Token: 0x06003844 RID: 14404
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x3443D20", Offset = "0x3442920", VA = "0x183443D20")]
		[PreserveSig]
		public static extern LuaTypes lua_type(IntPtr L, int index);

		// Token: 0x06003845 RID: 14405 RVA: 0x00016D10 File Offset: 0x00014F10
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x3442510", Offset = "0x3441110", VA = "0x183442510")]
		public static bool lua_isnil(IntPtr L, int index)
		{
			return default(bool);
		}

		// Token: 0x06003846 RID: 14406
		[Token(Token = "0x6003846")]
		[Address(RVA = "0x3442530", Offset = "0x3441130", VA = "0x183442530")]
		[PreserveSig]
		public static extern bool lua_isnumber(IntPtr L, int index);

		// Token: 0x06003847 RID: 14407 RVA: 0x00016D28 File Offset: 0x00014F28
		[Token(Token = "0x6003847")]
		[Address(RVA = "0x3442390", Offset = "0x3440F90", VA = "0x183442390")]
		public static bool lua_isboolean(IntPtr L, int index)
		{
			return default(bool);
		}

		// Token: 0x06003848 RID: 14408
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x3441B60", Offset = "0x3440760", VA = "0x183441B60")]
		[PreserveSig]
		public static extern int luaL_ref(IntPtr L, int registryIndex);

		// Token: 0x06003849 RID: 14409 RVA: 0x00016D40 File Offset: 0x00014F40
		[Token(Token = "0x6003849")]
		[Address(RVA = "0x3441BF0", Offset = "0x34407F0", VA = "0x183441BF0")]
		public static int luaL_ref(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600384A RID: 14410
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x3445780", Offset = "0x3444380", VA = "0x183445780")]
		[PreserveSig]
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index);

		// Token: 0x0600384B RID: 14411
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x3445820", Offset = "0x3444420", VA = "0x183445820")]
		[PreserveSig]
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index);

		// Token: 0x0600384C RID: 14412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x3442160", Offset = "0x3440D60", VA = "0x183442160")]
		public static void lua_getref(IntPtr L, int reference)
		{
		}

		// Token: 0x0600384D RID: 14413
		[Token(Token = "0x600384D")]
		[Address(RVA = "0x3444010", Offset = "0x3442C10", VA = "0x183444010")]
		[PreserveSig]
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref);

		// Token: 0x0600384E RID: 14414
		[Token(Token = "0x600384E")]
		[Address(RVA = "0x3441CC0", Offset = "0x34408C0", VA = "0x183441CC0")]
		[PreserveSig]
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference);

		// Token: 0x0600384F RID: 14415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384F")]
		[Address(RVA = "0x3443DB0", Offset = "0x34429B0", VA = "0x183443DB0")]
		public static void lua_unref(IntPtr L, int reference)
		{
		}

		// Token: 0x06003850 RID: 14416
		[Token(Token = "0x6003850")]
		[Address(RVA = "0x34425C0", Offset = "0x34411C0", VA = "0x1834425C0")]
		[PreserveSig]
		public static extern bool lua_isstring(IntPtr L, int index);

		// Token: 0x06003851 RID: 14417
		[Token(Token = "0x6003851")]
		[Address(RVA = "0x3442460", Offset = "0x3441060", VA = "0x183442460")]
		[PreserveSig]
		public static extern bool lua_isinteger(IntPtr L, int index);

		// Token: 0x06003852 RID: 14418
		[Token(Token = "0x6003852")]
		[Address(RVA = "0x3442AC0", Offset = "0x34416C0", VA = "0x183442AC0")]
		[PreserveSig]
		public static extern void lua_pushnil(IntPtr L);

		// Token: 0x06003853 RID: 14419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003853")]
		[Address(RVA = "0x3442BD0", Offset = "0x34417D0", VA = "0x183442BD0")]
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0)
		{
		}

		// Token: 0x06003854 RID: 14420
		[Token(Token = "0x6003854")]
		[Address(RVA = "0x3446540", Offset = "0x3445140", VA = "0x183446540")]
		[PreserveSig]
		public static extern int xlua_upvalueindex(int n);

		// Token: 0x06003855 RID: 14421
		[Token(Token = "0x6003855")]
		[Address(RVA = "0x34427C0", Offset = "0x34413C0", VA = "0x1834427C0")]
		[PreserveSig]
		public static extern int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc);

		// Token: 0x06003856 RID: 14422
		[Token(Token = "0x6003856")]
		[Address(RVA = "0x3443880", Offset = "0x3442480", VA = "0x183443880")]
		[PreserveSig]
		public static extern double lua_tonumber(IntPtr L, int index);

		// Token: 0x06003857 RID: 14423
		[Token(Token = "0x6003857")]
		[Address(RVA = "0x3445B00", Offset = "0x3444700", VA = "0x183445B00")]
		[PreserveSig]
		public static extern int xlua_tointeger(IntPtr L, int index);

		// Token: 0x06003858 RID: 14424
		[Token(Token = "0x6003858")]
		[Address(RVA = "0x3445B90", Offset = "0x3444790", VA = "0x183445B90")]
		[PreserveSig]
		public static extern uint xlua_touint(IntPtr L, int index);

		// Token: 0x06003859 RID: 14425
		[Token(Token = "0x6003859")]
		[Address(RVA = "0x3443540", Offset = "0x3442140", VA = "0x183443540")]
		[PreserveSig]
		public static extern bool lua_toboolean(IntPtr L, int index);

		// Token: 0x0600385A RID: 14426
		[Token(Token = "0x600385A")]
		[Address(RVA = "0x3443910", Offset = "0x3442510", VA = "0x183443910")]
		[PreserveSig]
		public static extern IntPtr lua_topointer(IntPtr L, int index);

		// Token: 0x0600385B RID: 14427
		[Token(Token = "0x600385B")]
		[Address(RVA = "0x34437E0", Offset = "0x34423E0", VA = "0x1834437E0")]
		[PreserveSig]
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen);

		// Token: 0x0600385C RID: 14428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385C")]
		[Address(RVA = "0x34439A0", Offset = "0x34425A0", VA = "0x1834439A0")]
		public static string lua_tostring(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x0600385D RID: 14429
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x3441DF0", Offset = "0x34409F0", VA = "0x183441DF0")]
		[PreserveSig]
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf);

		// Token: 0x0600385E RID: 14430
		[Token(Token = "0x600385E")]
		[Address(RVA = "0x3442B40", Offset = "0x3441740", VA = "0x183442B40")]
		[PreserveSig]
		public static extern void lua_pushnumber(IntPtr L, double number);

		// Token: 0x0600385F RID: 14431
		[Token(Token = "0x600385F")]
		[Address(RVA = "0x3442870", Offset = "0x3441470", VA = "0x183442870")]
		[PreserveSig]
		public static extern void lua_pushboolean(IntPtr L, bool value);

		// Token: 0x06003860 RID: 14432
		[Token(Token = "0x6003860")]
		[Address(RVA = "0x3445520", Offset = "0x3444120", VA = "0x183445520")]
		[PreserveSig]
		public static extern void xlua_pushinteger(IntPtr L, int value);

		// Token: 0x06003861 RID: 14433
		[Token(Token = "0x6003861")]
		[Address(RVA = "0x34456F0", Offset = "0x34442F0", VA = "0x1834456F0")]
		[PreserveSig]
		public static extern void xlua_pushuint(IntPtr L, uint value);

		// Token: 0x06003862 RID: 14434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003862")]
		[Address(RVA = "0x3442CC0", Offset = "0x34418C0", VA = "0x183442CC0")]
		public static void lua_pushstring(IntPtr L, string str)
		{
		}

		// Token: 0x06003863 RID: 14435
		[Token(Token = "0x6003863")]
		[Address(RVA = "0x34455B0", Offset = "0x34441B0", VA = "0x1834455B0")]
		[PreserveSig]
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size);

		// Token: 0x06003864 RID: 14436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003864")]
		[Address(RVA = "0x3442CC0", Offset = "0x34418C0", VA = "0x183442CC0")]
		public static void xlua_pushasciistring(IntPtr L, string str)
		{
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003865")]
		[Address(RVA = "0x3442DC0", Offset = "0x34419C0", VA = "0x183442DC0")]
		public static void lua_pushstring(IntPtr L, byte[] str)
		{
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003866")]
		[Address(RVA = "0x34435D0", Offset = "0x34421D0", VA = "0x1834435D0")]
		public static byte[] lua_tobytes(IntPtr L, int index)
		{
			return null;
		}

		// Token: 0x06003867 RID: 14439
		[Token(Token = "0x6003867")]
		[Address(RVA = "0x34419C0", Offset = "0x34405C0", VA = "0x1834419C0")]
		[PreserveSig]
		public static extern int luaL_newmetatable(IntPtr L, string meta);

		// Token: 0x06003868 RID: 14440
		[Token(Token = "0x6003868")]
		[Address(RVA = "0x3445150", Offset = "0x3443D50", VA = "0x183445150")]
		[PreserveSig]
		public static extern int xlua_pgettable(IntPtr L, int idx);

		// Token: 0x06003869 RID: 14441
		[Token(Token = "0x6003869")]
		[Address(RVA = "0x34452A0", Offset = "0x3443EA0", VA = "0x1834452A0")]
		[PreserveSig]
		public static extern int xlua_psettable(IntPtr L, int idx);

		// Token: 0x0600386A RID: 14442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386A")]
		[Address(RVA = "0x3441820", Offset = "0x3440420", VA = "0x183441820")]
		public static void luaL_getmetatable(IntPtr L, string meta)
		{
		}

		// Token: 0x0600386B RID: 14443
		[Token(Token = "0x600386B")]
		[Address(RVA = "0x34440B0", Offset = "0x3442CB0", VA = "0x1834440B0")]
		[PreserveSig]
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name);

		// Token: 0x0600386C RID: 14444 RVA: 0x00016D58 File Offset: 0x00014F58
		[Token(Token = "0x600386C")]
		[Address(RVA = "0x34418A0", Offset = "0x34404A0", VA = "0x1834418A0")]
		public static int luaL_loadbuffer(IntPtr L, string buff, string name)
		{
			return 0;
		}

		// Token: 0x0600386D RID: 14445
		[Token(Token = "0x600386D")]
		[Address(RVA = "0x3445A70", Offset = "0x3444670", VA = "0x183445A70")]
		[PreserveSig]
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj);

		// Token: 0x0600386E RID: 14446
		[Token(Token = "0x600386E")]
		[Address(RVA = "0x34459E0", Offset = "0x34445E0", VA = "0x1834459E0")]
		[PreserveSig]
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj);

		// Token: 0x0600386F RID: 14447 RVA: 0x00016D70 File Offset: 0x00014F70
		[Token(Token = "0x600386F")]
		[Address(RVA = "0x3442040", Offset = "0x3440C40", VA = "0x183442040")]
		public static int lua_error(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003870 RID: 14448
		[Token(Token = "0x6003870")]
		[Address(RVA = "0x3441E90", Offset = "0x3440A90", VA = "0x183441E90")]
		[PreserveSig]
		public static extern bool lua_checkstack(IntPtr L, int extra);

		// Token: 0x06003871 RID: 14449
		[Token(Token = "0x6003871")]
		[Address(RVA = "0x3442730", Offset = "0x3441330", VA = "0x183442730")]
		[PreserveSig]
		public static extern int lua_next(IntPtr L, int index);

		// Token: 0x06003872 RID: 14450
		[Token(Token = "0x6003872")]
		[Address(RVA = "0x3442A30", Offset = "0x3441630", VA = "0x183442A30")]
		[PreserveSig]
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata);

		// Token: 0x06003873 RID: 14451
		[Token(Token = "0x6003873")]
		[Address(RVA = "0x3445970", Offset = "0x3444570", VA = "0x183445970")]
		[PreserveSig]
		public static extern IntPtr xlua_tag();

		// Token: 0x06003874 RID: 14452
		[Token(Token = "0x6003874")]
		[Address(RVA = "0x3441D60", Offset = "0x3440960", VA = "0x183441D60")]
		[PreserveSig]
		public static extern void luaL_where(IntPtr L, int level);

		// Token: 0x06003875 RID: 14453
		[Token(Token = "0x6003875")]
		[Address(RVA = "0x3445C20", Offset = "0x3444820", VA = "0x183445C20")]
		[PreserveSig]
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref);

		// Token: 0x06003876 RID: 14454
		[Token(Token = "0x6003876")]
		[Address(RVA = "0x34453D0", Offset = "0x3443FD0", VA = "0x1834453D0")]
		[PreserveSig]
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref);

		// Token: 0x06003877 RID: 14455
		[Token(Token = "0x6003877")]
		[Address(RVA = "0x3441570", Offset = "0x3440170", VA = "0x183441570")]
		[PreserveSig]
		public static extern int gen_obj_indexer(IntPtr L);

		// Token: 0x06003878 RID: 14456
		[Token(Token = "0x6003878")]
		[Address(RVA = "0x34415F0", Offset = "0x34401F0", VA = "0x1834415F0")]
		[PreserveSig]
		public static extern int gen_obj_newindexer(IntPtr L);

		// Token: 0x06003879 RID: 14457
		[Token(Token = "0x6003879")]
		[Address(RVA = "0x3441470", Offset = "0x3440070", VA = "0x183441470")]
		[PreserveSig]
		public static extern int gen_cls_indexer(IntPtr L);

		// Token: 0x0600387A RID: 14458
		[Token(Token = "0x600387A")]
		[Address(RVA = "0x34414F0", Offset = "0x34400F0", VA = "0x1834414F0")]
		[PreserveSig]
		public static extern int gen_cls_newindexer(IntPtr L);

		// Token: 0x0600387B RID: 14459
		[Token(Token = "0x600387B")]
		[Address(RVA = "0x3441670", Offset = "0x3440270", VA = "0x183441670")]
		[PreserveSig]
		public static extern int get_error_func_ref(IntPtr L);

		// Token: 0x0600387C RID: 14460
		[Token(Token = "0x600387C")]
		[Address(RVA = "0x34416F0", Offset = "0x34402F0", VA = "0x1834416F0")]
		[PreserveSig]
		public static extern int load_error_func(IntPtr L, int Ref);

		// Token: 0x0600387D RID: 14461
		[Token(Token = "0x600387D")]
		[Address(RVA = "0x3443E90", Offset = "0x3442A90", VA = "0x183443E90")]
		[PreserveSig]
		public static extern int luaopen_i64lib(IntPtr L);

		// Token: 0x0600387E RID: 14462
		[Token(Token = "0x600387E")]
		[Address(RVA = "0x3443F10", Offset = "0x3442B10", VA = "0x183443F10")]
		[PreserveSig]
		public static extern int luaopen_socket_core(IntPtr L);

		// Token: 0x0600387F RID: 14463
		[Token(Token = "0x600387F")]
		[Address(RVA = "0x34429A0", Offset = "0x34415A0", VA = "0x1834429A0")]
		[PreserveSig]
		public static extern void lua_pushint64(IntPtr L, long n);

		// Token: 0x06003880 RID: 14464
		[Token(Token = "0x6003880")]
		[Address(RVA = "0x3442EF0", Offset = "0x3441AF0", VA = "0x183442EF0")]
		[PreserveSig]
		public static extern void lua_pushuint64(IntPtr L, ulong n);

		// Token: 0x06003881 RID: 14465
		[Token(Token = "0x6003881")]
		[Address(RVA = "0x34423D0", Offset = "0x3440FD0", VA = "0x1834423D0")]
		[PreserveSig]
		public static extern bool lua_isint64(IntPtr L, int idx);

		// Token: 0x06003882 RID: 14466
		[Token(Token = "0x6003882")]
		[Address(RVA = "0x3442690", Offset = "0x3441290", VA = "0x183442690")]
		[PreserveSig]
		public static extern bool lua_isuint64(IntPtr L, int idx);

		// Token: 0x06003883 RID: 14467
		[Token(Token = "0x6003883")]
		[Address(RVA = "0x3443750", Offset = "0x3442350", VA = "0x183443750")]
		[PreserveSig]
		public static extern long lua_toint64(IntPtr L, int idx);

		// Token: 0x06003884 RID: 14468
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x3443C00", Offset = "0x3442800", VA = "0x183443C00")]
		[PreserveSig]
		public static extern ulong lua_touint64(IntPtr L, int idx);

		// Token: 0x06003885 RID: 14469
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x3445330", Offset = "0x3443F30", VA = "0x183445330")]
		[PreserveSig]
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n);

		// Token: 0x06003886 RID: 14470
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x3444200", Offset = "0x3442E00", VA = "0x183444200")]
		[PreserveSig]
		public static extern int xlua_csharp_str_error(IntPtr L, string message);

		// Token: 0x06003887 RID: 14471
		[Token(Token = "0x6003887")]
		[Address(RVA = "0x3444180", Offset = "0x3442D80", VA = "0x183444180")]
		[PreserveSig]
		public static extern int xlua_csharp_error(IntPtr L);

		// Token: 0x06003888 RID: 14472
		[Token(Token = "0x6003888")]
		[Address(RVA = "0x3444FF0", Offset = "0x3443BF0", VA = "0x183444FF0")]
		[PreserveSig]
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field);

		// Token: 0x06003889 RID: 14473
		[Token(Token = "0x6003889")]
		[Address(RVA = "0x34464A0", Offset = "0x34450A0", VA = "0x1834464A0")]
		[PreserveSig]
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field);

		// Token: 0x0600388A RID: 14474
		[Token(Token = "0x600388A")]
		[Address(RVA = "0x3444E10", Offset = "0x3443A10", VA = "0x183444E10")]
		[PreserveSig]
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field);

		// Token: 0x0600388B RID: 14475
		[Token(Token = "0x600388B")]
		[Address(RVA = "0x34462C0", Offset = "0x3444EC0", VA = "0x1834462C0")]
		[PreserveSig]
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field);

		// Token: 0x0600388C RID: 14476
		[Token(Token = "0x600388C")]
		[Address(RVA = "0x3444EB0", Offset = "0x3443AB0", VA = "0x183444EB0")]
		[PreserveSig]
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field);

		// Token: 0x0600388D RID: 14477
		[Token(Token = "0x600388D")]
		[Address(RVA = "0x3446360", Offset = "0x3444F60", VA = "0x183446360")]
		[PreserveSig]
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field);

		// Token: 0x0600388E RID: 14478
		[Token(Token = "0x600388E")]
		[Address(RVA = "0x3444F50", Offset = "0x3443B50", VA = "0x183444F50")]
		[PreserveSig]
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field);

		// Token: 0x0600388F RID: 14479
		[Token(Token = "0x600388F")]
		[Address(RVA = "0x3446400", Offset = "0x3445000", VA = "0x183446400")]
		[PreserveSig]
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field);

		// Token: 0x06003890 RID: 14480
		[Token(Token = "0x6003890")]
		[Address(RVA = "0x3444D70", Offset = "0x3443970", VA = "0x183444D70")]
		[PreserveSig]
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field);

		// Token: 0x06003891 RID: 14481
		[Token(Token = "0x6003891")]
		[Address(RVA = "0x3446220", Offset = "0x3444E20", VA = "0x183446220")]
		[PreserveSig]
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field);

		// Token: 0x06003892 RID: 14482
		[Token(Token = "0x6003892")]
		[Address(RVA = "0x34448A0", Offset = "0x34434A0", VA = "0x1834448A0")]
		[PreserveSig]
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field);

		// Token: 0x06003893 RID: 14483
		[Token(Token = "0x6003893")]
		[Address(RVA = "0x3445D90", Offset = "0x3444990", VA = "0x183445D90")]
		[PreserveSig]
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field);

		// Token: 0x06003894 RID: 14484
		[Token(Token = "0x6003894")]
		[Address(RVA = "0x3445650", Offset = "0x3444250", VA = "0x183445650")]
		[PreserveSig]
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref);

		// Token: 0x06003895 RID: 14485
		[Token(Token = "0x6003895")]
		[Address(RVA = "0x3445480", Offset = "0x3444080", VA = "0x183445480")]
		[PreserveSig]
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref);

		// Token: 0x06003896 RID: 14486
		[Token(Token = "0x6003896")]
		[Address(RVA = "0x3443C90", Offset = "0x3442890", VA = "0x183443C90")]
		[PreserveSig]
		public static extern IntPtr lua_touserdata(IntPtr L, int idx);

		// Token: 0x06003897 RID: 14487
		[Token(Token = "0x6003897")]
		[Address(RVA = "0x34444C0", Offset = "0x34430C0", VA = "0x1834444C0")]
		[PreserveSig]
		public static extern int xlua_gettypeid(IntPtr L, int idx);

		// Token: 0x06003898 RID: 14488
		[Token(Token = "0x6003898")]
		[Address(RVA = "0x3444320", Offset = "0x3442F20", VA = "0x183444320")]
		[PreserveSig]
		public static extern int xlua_get_registry_index();

		// Token: 0x06003899 RID: 14489
		[Token(Token = "0x6003899")]
		[Address(RVA = "0x3445090", Offset = "0x3443C90", VA = "0x183445090")]
		[PreserveSig]
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path);

		// Token: 0x0600389A RID: 14490
		[Token(Token = "0x600389A")]
		[Address(RVA = "0x34451E0", Offset = "0x3443DE0", VA = "0x1834451E0")]
		[PreserveSig]
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path);

		// Token: 0x0600389B RID: 14491
		[Token(Token = "0x600389B")]
		[Address(RVA = "0x3444940", Offset = "0x3443540", VA = "0x183444940")]
		[PreserveSig]
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2);

		// Token: 0x0600389C RID: 14492
		[Token(Token = "0x600389C")]
		[Address(RVA = "0x3445E30", Offset = "0x3444A30", VA = "0x183445E30")]
		[PreserveSig]
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2);

		// Token: 0x0600389D RID: 14493
		[Token(Token = "0x600389D")]
		[Address(RVA = "0x34449F0", Offset = "0x34435F0", VA = "0x1834449F0")]
		[PreserveSig]
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3);

		// Token: 0x0600389E RID: 14494
		[Token(Token = "0x600389E")]
		[Address(RVA = "0x3445EE0", Offset = "0x3444AE0", VA = "0x183445EE0")]
		[PreserveSig]
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3);

		// Token: 0x0600389F RID: 14495
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x3444AC0", Offset = "0x34436C0", VA = "0x183444AC0")]
		[PreserveSig]
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4);

		// Token: 0x060038A0 RID: 14496
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x3445FA0", Offset = "0x3444BA0", VA = "0x183445FA0")]
		[PreserveSig]
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4);

		// Token: 0x060038A1 RID: 14497
		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x3444BA0", Offset = "0x34437A0", VA = "0x183444BA0")]
		[PreserveSig]
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5);

		// Token: 0x060038A2 RID: 14498
		[Token(Token = "0x60038A2")]
		[Address(RVA = "0x3446070", Offset = "0x3444C70", VA = "0x183446070")]
		[PreserveSig]
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5);

		// Token: 0x060038A3 RID: 14499
		[Token(Token = "0x60038A3")]
		[Address(RVA = "0x3444C80", Offset = "0x3443880", VA = "0x183444C80")]
		[PreserveSig]
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6);

		// Token: 0x060038A4 RID: 14500
		[Token(Token = "0x60038A4")]
		[Address(RVA = "0x3446140", Offset = "0x3444D40", VA = "0x183446140")]
		[PreserveSig]
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6);

		// Token: 0x060038A5 RID: 14501
		[Token(Token = "0x60038A5")]
		[Address(RVA = "0x3444800", Offset = "0x3443400", VA = "0x183444800")]
		[PreserveSig]
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec);

		// Token: 0x060038A6 RID: 14502
		[Token(Token = "0x60038A6")]
		[Address(RVA = "0x3445CC0", Offset = "0x34448C0", VA = "0x183445CC0")]
		[PreserveSig]
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64);

		// Token: 0x060038A7 RID: 14503 RVA: 0x00016D88 File Offset: 0x00014F88
		[Token(Token = "0x60038A7")]
		[Address(RVA = "0x34445D0", Offset = "0x34431D0", VA = "0x1834445D0")]
		public static bool xlua_is_eq_str(IntPtr L, int index, string str)
		{
			return default(bool);
		}

		// Token: 0x060038A8 RID: 14504
		[Token(Token = "0x60038A8")]
		[Address(RVA = "0x34446B0", Offset = "0x34432B0", VA = "0x1834446B0")]
		[PreserveSig]
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len);

		// Token: 0x060038A9 RID: 14505
		[Token(Token = "0x60038A9")]
		[Address(RVA = "0x3444550", Offset = "0x3443150", VA = "0x183444550")]
		[PreserveSig]
		public static extern IntPtr xlua_gl(IntPtr L);

		// Token: 0x060038AA RID: 14506
		[Token(Token = "0x60038AA")]
		[Address(RVA = "0x34413F0", Offset = "0x343FFF0", VA = "0x1834413F0")]
		[PreserveSig]
		public static extern int luaopen_rapidjson(IntPtr L);

		// Token: 0x060038AB RID: 14507 RVA: 0x00016DA0 File Offset: 0x00014FA0
		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x34413F0", Offset = "0x343FFF0", VA = "0x1834413F0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadRapidJson(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060038AC RID: 14508
		[Token(Token = "0x60038AC")]
		[Address(RVA = "0x34412F0", Offset = "0x343FEF0", VA = "0x1834412F0")]
		[PreserveSig]
		public static extern int luaopen_lpeg(IntPtr L);

		// Token: 0x060038AD RID: 14509 RVA: 0x00016DB8 File Offset: 0x00014FB8
		[Token(Token = "0x60038AD")]
		[Address(RVA = "0x34412F0", Offset = "0x343FEF0", VA = "0x1834412F0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLpeg(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060038AE RID: 14510
		[Token(Token = "0x60038AE")]
		[Address(RVA = "0x3441370", Offset = "0x343FF70", VA = "0x183441370")]
		[PreserveSig]
		public static extern int luaopen_pb(IntPtr L);

		// Token: 0x060038AF RID: 14511 RVA: 0x00016DD0 File Offset: 0x00014FD0
		[Token(Token = "0x60038AF")]
		[Address(RVA = "0x3441370", Offset = "0x343FF70", VA = "0x183441370")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaProfobuf(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060038B0 RID: 14512
		[Token(Token = "0x60038B0")]
		[Address(RVA = "0x3441270", Offset = "0x343FE70", VA = "0x183441270")]
		[PreserveSig]
		public static extern int luaopen_ffi(IntPtr L);

		// Token: 0x060038B1 RID: 14513 RVA: 0x00016DE8 File Offset: 0x00014FE8
		[Token(Token = "0x60038B1")]
		[Address(RVA = "0x3441270", Offset = "0x343FE70", VA = "0x183441270")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadFFI(IntPtr L)
		{
			return 0;
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Lua()
		{
		}

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		private const string LUADLL = "xlua";
	}
}
