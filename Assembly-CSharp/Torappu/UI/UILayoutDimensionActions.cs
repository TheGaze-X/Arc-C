using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038E9 RID: 14569
	[Token(Token = "0x20038E9")]
	public static class UILayoutDimensionActions
	{
		// Token: 0x020038EA RID: 14570
		[Token(Token = "0x20038EA")]
		[LuaCallCSharp(GenFlag.No)]
		public struct SetScrollVertPos : UILayoutDimensionListener.IAction
		{
			// Token: 0x06017082 RID: 94338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017082")]
			[Address(RVA = "0xF74F20", Offset = "0xF73B20", VA = "0x180F74F20", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401BCE0 RID: 113888
			[Token(Token = "0x401BCE0")]
			[FieldOffset(Offset = "0x0")]
			public ScrollRect scroll;

			// Token: 0x0401BCE1 RID: 113889
			[Token(Token = "0x401BCE1")]
			[FieldOffset(Offset = "0x8")]
			public float pos;
		}

		// Token: 0x020038EB RID: 14571
		[Token(Token = "0x20038EB")]
		[LuaCallCSharp(GenFlag.No)]
		public struct SetScrollHorzPos : UILayoutDimensionListener.IAction
		{
			// Token: 0x06017083 RID: 94339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017083")]
			[Address(RVA = "0xF74EA0", Offset = "0xF73AA0", VA = "0x180F74EA0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401BCE2 RID: 113890
			[Token(Token = "0x401BCE2")]
			[FieldOffset(Offset = "0x0")]
			public ScrollRect scroll;

			// Token: 0x0401BCE3 RID: 113891
			[Token(Token = "0x401BCE3")]
			[FieldOffset(Offset = "0x8")]
			public float pos;
		}

		// Token: 0x020038EC RID: 14572
		[Token(Token = "0x20038EC")]
		public class WaitForPostLayout : UILayoutDimensionListener.IAction
		{
			// Token: 0x170036F1 RID: 14065
			// (get) Token: 0x06017084 RID: 94340 RVA: 0x000946F8 File Offset: 0x000928F8
			// (set) Token: 0x06017085 RID: 94341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170036F1")]
			public bool isLayouted
			{
				[Token(Token = "0x6017084")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6017085")]
				[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06017086 RID: 94342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017086")]
			[Address(RVA = "0xF3CBA0", Offset = "0xF3B7A0", VA = "0x180F3CBA0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x06017087 RID: 94343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017087")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WaitForPostLayout()
			{
			}
		}
	}
}
