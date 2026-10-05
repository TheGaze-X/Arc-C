using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DB
{
	// Token: 0x020016AE RID: 5806
	[Token(Token = "0x20016AE")]
	public abstract class SingletonAbstractTable<T> : AbstractTable where T : ScriptableObject
	{
		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x060092F2 RID: 37618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA0")]
		public static T instance
		{
			[Token(Token = "0x60092F2")]
			get
			{
				return null;
			}
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F3")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F4")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060092F5 RID: 37621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F5")]
		protected SingletonAbstractTable()
		{
		}

		// Token: 0x0400888E RID: 34958
		[Token(Token = "0x400888E")]
		[FieldOffset(Offset = "0x0")]
		private static T s_instance;

		// Token: 0x0400888F RID: 34959
		[Token(Token = "0x400888F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instance;

		// Token: 0x04008890 RID: 34960
		[Token(Token = "0x4008890")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04008891 RID: 34961
		[Token(Token = "0x4008891")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04008892 RID: 34962
		[Token(Token = "0x4008892")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
