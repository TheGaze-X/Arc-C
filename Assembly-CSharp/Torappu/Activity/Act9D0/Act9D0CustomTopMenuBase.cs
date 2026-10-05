using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200718D RID: 29069
	[Token(Token = "0x200718D")]
	public abstract class Act9D0CustomTopMenuBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602941F RID: 168991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602941F")]
		[Address(RVA = "0x2492500", Offset = "0x2491100", VA = "0x182492500")]
		public void InitIfNot()
		{
		}

		// Token: 0x170061AC RID: 25004
		// (get) Token: 0x06029420 RID: 168992 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029421 RID: 168993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061AC")]
		public Action onCommonBackClicked
		{
			[Token(Token = "0x6029420")]
			[Address(RVA = "0x24925F0", Offset = "0x24911F0", VA = "0x1824925F0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6029421")]
			[Address(RVA = "0x2492650", Offset = "0x2491250", VA = "0x182492650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06029422 RID: 168994
		[Token(Token = "0x6029422")]
		protected abstract void InitTopMenu();

		// Token: 0x06029423 RID: 168995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029423")]
		[Address(RVA = "0x2492590", Offset = "0x2491190", VA = "0x182492590")]
		protected Act9D0CustomTopMenuBase()
		{
		}

		// Token: 0x0403AECF RID: 241359
		[Token(Token = "0x403AECF")]
		[FieldOffset(Offset = "0x18")]
		private bool m_hasInited;

		// Token: 0x0403AED1 RID: 241361
		[Token(Token = "0x403AED1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0403AED2 RID: 241362
		[Token(Token = "0x403AED2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onCommonBackClicked;

		// Token: 0x0403AED3 RID: 241363
		[Token(Token = "0x403AED3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onCommonBackClicked;

		// Token: 0x0403AED4 RID: 241364
		[Token(Token = "0x403AED4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
