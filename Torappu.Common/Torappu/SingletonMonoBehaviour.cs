using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public class SingletonMonoBehaviour<T> : MonoBehaviour, IHotfixable where T : MonoBehaviour
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002B")]
		public static T instance
		{
			[Token(Token = "0x60001B2")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B3")]
		public static T CreateInstanceIfNot()
		{
			return null;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002C")]
		public static T instanceOrNull
		{
			[Token(Token = "0x60001B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x1700002D")]
		public static bool hasInstance
		{
			[Token(Token = "0x60001B5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001B6")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001B7")]
		protected virtual void OnDuplicated()
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001B8")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001B9")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BA")]
		private static T _CreateNewInstance()
		{
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001BB")]
		public SingletonMonoBehaviour()
		{
		}

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x0")]
		protected static T s_instance;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate8 __Hotfix0_get_hasInstance;
	}
}
