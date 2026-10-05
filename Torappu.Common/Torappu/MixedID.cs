using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;
using ZString;

namespace Torappu
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	public struct MixedID : IHotfixable
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000085")]
		public string id1
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x5523500", Offset = "0x5522100", VA = "0x185523500")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x5523670", Offset = "0x5522270", VA = "0x185523670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000086")]
		public string id2
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x5523570", Offset = "0x5522170", VA = "0x185523570")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x5523700", Offset = "0x5522300", VA = "0x185523700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000087")]
		public string id3
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x55235F0", Offset = "0x55221F0", VA = "0x1855235F0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x5523790", Offset = "0x5522390", VA = "0x185523790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x5523370", Offset = "0x5521F70", VA = "0x185523370")]
		public MixedID(string p1, string p2)
		{
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x5523430", Offset = "0x5522030", VA = "0x185523430")]
		public MixedID(string p1, string p2, string p3)
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x55231C0", Offset = "0x5521DC0", VA = "0x1855231C0")]
		private void _Validate()
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000694")]
		public TValue GetFromDict<TValue>(IDictionary<string, TValue> dict)
		{
			return null;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00006344 File Offset: 0x00004544
		[Token(Token = "0x6000695")]
		public bool RemoveFromDict<TValue>(IDictionary<string, TValue> dict)
		{
			return default(bool);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0000635C File Offset: 0x0000455C
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x5522AB0", Offset = "0x55216B0", VA = "0x185522AB0")]
		public bool ContainsInSet(ICollection<string> set)
		{
			return default(bool);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00006374 File Offset: 0x00004574
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x5522D50", Offset = "0x5521950", VA = "0x185522D50")]
		public bool RemoveFromSet(ICollection<string> set)
		{
			return default(bool);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x5522EF0", Offset = "0x5521AF0", VA = "0x185522EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x5522C50", Offset = "0x5521850", VA = "0x185522C50")]
		public string GetOrCreateString(Dictionary<string, string> stringCache)
		{
			return null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x5523050", Offset = "0x5521C50", VA = "0x185523050")]
		private zstring _CreateConcatIdInBlock()
		{
			return null;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x5522FF0", Offset = "0x5521BF0", VA = "0x185522FF0")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate118 __Hotfix0_get_id1;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate119 __Hotfix0_set_id1;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate118 __Hotfix0_get_id2;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate119 __Hotfix0_set_id2;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate118 __Hotfix0_get_id3;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate119 __Hotfix0_set_id3;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate120 _c__Hotfix0_ctor;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate121 _c__Hotfix1_ctor;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate122 __Hotfix0__Validate;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate123 __Hotfix0_ContainsInSet;

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate123 __Hotfix0_RemoveFromSet;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate118 __Hotfix0_ToString;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate124 __Hotfix0_GetOrCreateString;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate125 __Hotfix0__CreateConcatIdInBlock;
	}
}
