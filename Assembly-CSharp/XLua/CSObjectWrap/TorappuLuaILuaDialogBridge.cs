using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.Lua;
using UnityEngine;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000393 RID: 915
	[Token(Token = "0x2000393")]
	public class TorappuLuaILuaDialogBridge : LuaBase, ILuaDialog, ILuaCallCSharp
	{
		// Token: 0x06004051 RID: 16465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004051")]
		[Address(RVA = "0xC10BD0", Offset = "0xC0F7D0", VA = "0x180C10BD0")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004052")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuLuaILuaDialogBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004053")]
		[Address(RVA = "0xC0EA90", Offset = "0xC0D690", VA = "0x180C0EA90", Slot = "7")]
		private void ClosedByParent()
		{
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004054")]
		[Address(RVA = "0xC0EF10", Offset = "0xC0DB10", VA = "0x180C0EF10", Slot = "8")]
		private Transform GetHookRoot()
		{
			return null;
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004055")]
		[Address(RVA = "0xC0ECA0", Offset = "0xC0D8A0", VA = "0x180C0ECA0", Slot = "9")]
		private string GetData(string key)
		{
			return null;
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004056")]
		[Address(RVA = "0xC10430", Offset = "0xC0F030", VA = "0x180C10430", Slot = "10")]
		private void RequestClose(ILuaDialog child)
		{
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004057")]
		[Address(RVA = "0xC10130", Offset = "0xC0ED30", VA = "0x180C10130", Slot = "11")]
		private Sprite LoadSprite(string path)
		{
			return null;
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004058")]
		[Address(RVA = "0xC0FAF0", Offset = "0xC0E6F0", VA = "0x180C0FAF0", Slot = "12")]
		private GameObject LoadPrefab(string path)
		{
			return null;
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004059")]
		[Address(RVA = "0xC0F7B0", Offset = "0xC0E3B0", VA = "0x180C0F7B0", Slot = "13")]
		private LuaLayout LoadLayout(string path)
		{
			return null;
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405A")]
		[Address(RVA = "0xC0FDF0", Offset = "0xC0E9F0", VA = "0x180C0FDF0", Slot = "14")]
		private ScriptableObject LoadScriptableObject(string path)
		{
			return null;
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405B")]
		[Address(RVA = "0xC0F240", Offset = "0xC0DE40", VA = "0x180C0F240", Slot = "15")]
		private LuaLayout GetLuaLayout()
		{
			return null;
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405C")]
		[Address(RVA = "0xC10690", Offset = "0xC0F290", VA = "0x180C10690", Slot = "16")]
		private void ShowEnterEffect()
		{
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00020A30 File Offset: 0x0001EC30
		[Token(Token = "0x600405D")]
		[Address(RVA = "0xC0F570", Offset = "0xC0E170", VA = "0x180C0F570", Slot = "17")]
		private bool IsEnterEffectEnd()
		{
			return default(bool);
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405E")]
		[Address(RVA = "0xC108A0", Offset = "0xC0F4A0", VA = "0x180C108A0", Slot = "18")]
		private UnityEngine.Object UICompDialogHost()
		{
			return null;
		}
	}
}
