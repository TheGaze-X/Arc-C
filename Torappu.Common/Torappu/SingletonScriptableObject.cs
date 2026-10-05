using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002E")]
		public static T instance
		{
			[Token(Token = "0x60001BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BD")]
		public static T GetInstanceSafe()
		{
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001BE")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001BF")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001C0")]
		public SingletonScriptableObject()
		{
		}

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x0")]
		private static T s_instance;
	}
}
