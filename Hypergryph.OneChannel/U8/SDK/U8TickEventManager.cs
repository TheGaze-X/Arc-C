using System;
using Il2CppDummyDll;
using UnityEngine;

namespace U8.SDK
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public class U8TickEventManager
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000284 RID: 644 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000045")]
		public static U8TickEventManager InstanceManager
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x4A2A2F0", Offset = "0x4A28EF0", VA = "0x184A2A2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x4A29F30", Offset = "0x4A28B30", VA = "0x184A29F30")]
		public void InitTickEvent()
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x4A2A100", Offset = "0x4A28D00", VA = "0x184A2A100")]
		public void UnInitTickEvent()
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8TickEventManager()
		{
		}

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x10")]
		private GameObject tickGameObject;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x18")]
		private U8SDKTickEvent tickEvent;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x0")]
		private static U8TickEventManager instanceManager;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;
	}
}
