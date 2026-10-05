using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;

namespace XLua.CSObjectWrap
{
	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	public class TorappuUILuaRecycleLoopScrollAdpaterILuaLayoutEventBridge : LuaBase, LuaRecycleLoopScrollAdpater.ILuaLayoutEvent
	{
		// Token: 0x0600435E RID: 17246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600435E")]
		[Address(RVA = "0xF2A400", Offset = "0xF29000", VA = "0x180F2A400")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435F")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuUILuaRecycleLoopScrollAdpaterILuaLayoutEventBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004360")]
		[Address(RVA = "0xF29E80", Offset = "0xF28A80", VA = "0x180F29E80", Slot = "7")]
		private void OnRender(Transform transform, int index)
		{
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x00024060 File Offset: 0x00022260
		[Token(Token = "0x6004361")]
		[Address(RVA = "0xF29C40", Offset = "0xF28840", VA = "0x180F29C40", Slot = "8")]
		private int GetTotalCount()
		{
			return 0;
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004362")]
		[Address(RVA = "0xF2A100", Offset = "0xF28D00", VA = "0x180F2A100", Slot = "9")]
		private GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}
	}
}
