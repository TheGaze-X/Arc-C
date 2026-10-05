using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BestHTTP.Examples
{
	// Token: 0x02000561 RID: 1377
	[Token(Token = "0x2000561")]
	public class GUIMessageList
	{
		// Token: 0x06002D9F RID: 11679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0x53EAD00", Offset = "0x53E9900", VA = "0x1853EAD00")]
		public void Draw()
		{
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0x53EAD30", Offset = "0x53E9930", VA = "0x1853EAD30")]
		public void Draw(float minWidth, float minHeight)
		{
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0x53EAC40", Offset = "0x53E9840", VA = "0x1853EAC40")]
		public void Add(string msg)
		{
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA2")]
		[Address(RVA = "0x53EACA0", Offset = "0x53E98A0", VA = "0x1853EACA0")]
		public void Clear()
		{
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA3")]
		[Address(RVA = "0x53EAF40", Offset = "0x53E9B40", VA = "0x1853EAF40")]
		public GUIMessageList()
		{
		}

		// Token: 0x0400199B RID: 6555
		[Token(Token = "0x400199B")]
		[FieldOffset(Offset = "0x10")]
		private List<string> messages;

		// Token: 0x0400199C RID: 6556
		[Token(Token = "0x400199C")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 scrollPos;
	}
}
