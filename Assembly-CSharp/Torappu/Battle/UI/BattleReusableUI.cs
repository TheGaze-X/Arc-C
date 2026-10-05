using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003356 RID: 13142
	[Token(Token = "0x2003356")]
	public class BattleReusableUI : MonoBehaviour, IHotfixable, IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x06014F8F RID: 85903 RVA: 0x00089D78 File Offset: 0x00087F78
		// (set) Token: 0x06014F90 RID: 85904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031C3")]
		public uint instanceUid
		{
			[Token(Token = "0x6014F8F")]
			[Address(RVA = "0xD55040", Offset = "0xD53C40", VA = "0x180D55040", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6014F90")]
			[Address(RVA = "0xD550A0", Offset = "0xD53CA0", VA = "0x180D550A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06014F91 RID: 85905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F91")]
		[Address(RVA = "0xD54E90", Offset = "0xD53A90", VA = "0x180D54E90", Slot = "7")]
		public virtual void OnAllocate()
		{
		}

		// Token: 0x06014F92 RID: 85906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F92")]
		[Address(RVA = "0xD54F40", Offset = "0xD53B40", VA = "0x180D54F40", Slot = "8")]
		public virtual void OnRecycle()
		{
		}

		// Token: 0x06014F93 RID: 85907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F93")]
		[Address(RVA = "0xD54FE0", Offset = "0xD53BE0", VA = "0x180D54FE0")]
		public BattleReusableUI()
		{
		}

		// Token: 0x04018F20 RID: 102176
		[Token(Token = "0x4018F20")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x04018F22 RID: 102178
		[Token(Token = "0x4018F22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_instanceUid;

		// Token: 0x04018F23 RID: 102179
		[Token(Token = "0x4018F23")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_instanceUid;

		// Token: 0x04018F24 RID: 102180
		[Token(Token = "0x4018F24")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04018F25 RID: 102181
		[Token(Token = "0x4018F25")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04018F26 RID: 102182
		[Token(Token = "0x4018F26")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
