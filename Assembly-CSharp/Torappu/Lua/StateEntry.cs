using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x02001608 RID: 5640
	[Token(Token = "0x2001608")]
	[ReflectionUse]
	internal class StateEntry : MonoBehaviour
	{
		// Token: 0x06008004 RID: 32772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008004")]
		[Address(RVA = "0x28A08D0", Offset = "0x289F4D0", VA = "0x1828A08D0")]
		public void HandleOpenState(string stateType)
		{
		}

		// Token: 0x06008005 RID: 32773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008005")]
		[Address(RVA = "0x28A0880", Offset = "0x289F480", VA = "0x1828A0880")]
		public void HandleOpenLuaState()
		{
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008006")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StateEntry()
		{
		}

		// Token: 0x04008177 RID: 33143
		[Token(Token = "0x4008177")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StateEngine _engine;
	}
}
